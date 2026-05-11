

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
    internal partial interface INpgsqlPolygonListpolygonListD1
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonListD1 : INpgsqlPolygonListpolygonListD1
    {


#region TestData

        private readonly NpgsqlPolygonpolygonListD1E2M[] _testData = new NpgsqlPolygonpolygonListD1E2M[]
        {
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0997853446705802d, y: 0.3186962009464639d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549771827935692d, y: 0.5412062671449164d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825045480043648d, y: 0.33128293312018875d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5221949490238859d, y: 0.01107698866547091d), new NpgsqlTypes.NpgsqlPoint(x: 0.007651893356460326d, y: 0.6883504278493466d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349137800211982d, y: 0.028398057248039454d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.526515491905511d, y: 0.4073588591188002d), new NpgsqlTypes.NpgsqlPoint(x: 0.861217335496893d, y: 0.5634282229820773d), new NpgsqlTypes.NpgsqlPoint(x: 0.44028527714934795d, y: 0.5936152192128376d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38502339596576385d, y: 0.16825521732138515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172295372887917d, y: 0.7487768791584964d), new NpgsqlTypes.NpgsqlPoint(x: 0.05763035244420378d, y: 0.626298450703948d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1440836552821193d, y: 0.7429058667053007d), new NpgsqlTypes.NpgsqlPoint(x: 0.29909397898718026d, y: 0.942592318641686d), new NpgsqlTypes.NpgsqlPoint(x: 0.11353652665342762d, y: 0.13564006513647298d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20964721617324322d, y: 0.1656128270875017d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770961205830019d, y: 0.8231785481753788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568096077943093d, y: 0.9295985899249484d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03458441992400563d, y: 0.7763690592482385d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441240961680482d, y: 0.3174467055941015d), new NpgsqlTypes.NpgsqlPoint(x: 0.49718494592675466d, y: 0.3867269733354556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7175484611440948d, y: 0.3868716426179122d), new NpgsqlTypes.NpgsqlPoint(x: 0.615628307884956d, y: 0.9261777879631325d), new NpgsqlTypes.NpgsqlPoint(x: 0.13775537345095934d, y: 0.012859945819862051d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.966784486156496d, y: 0.1948319215343738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341742699828079d, y: 0.8344097092886474d), new NpgsqlTypes.NpgsqlPoint(x: 0.26719977382412086d, y: 0.15471153953945938d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014722334141466287d, y: 0.37504917965733775d), new NpgsqlTypes.NpgsqlPoint(x: 0.41697097358073265d, y: 0.17230891334614962d), new NpgsqlTypes.NpgsqlPoint(x: 0.3559316325029783d, y: 0.20732615097634488d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5506332374741416d, y: 0.39326679457435343d), new NpgsqlTypes.NpgsqlPoint(x: 0.16477305560869315d, y: 0.6411956859771527d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827398226956439d, y: 0.38626561203520837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17507139955209206d, y: 0.7439767151894395d), new NpgsqlTypes.NpgsqlPoint(x: 0.03617187781011755d, y: 0.5982757842860821d), new NpgsqlTypes.NpgsqlPoint(x: 0.2803627470830645d, y: 0.5005124407446268d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.042736686640467814d, y: 0.6881303477491018d), new NpgsqlTypes.NpgsqlPoint(x: 0.18627513999585887d, y: 0.3024321119185239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8209677876958962d, y: 0.8687412097882931d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8146637772745241d, y: 0.11893044899462213d), new NpgsqlTypes.NpgsqlPoint(x: 0.11567170913814984d, y: 0.30680596705765983d), new NpgsqlTypes.NpgsqlPoint(x: 0.9451193018285686d, y: 0.6183194937799805d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4270225924122425d, y: 0.6246057562841288d), new NpgsqlTypes.NpgsqlPoint(x: 0.03601644835587381d, y: 0.2129992872045059d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348769835795363d, y: 0.5060812532791253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5692778272653359d, y: 0.9336775309124501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7742250821557247d, y: 0.9290333268032853d), new NpgsqlTypes.NpgsqlPoint(x: 0.3778974524463916d, y: 0.2155126347566576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26741690928975903d, y: 0.3243842617357725d), new NpgsqlTypes.NpgsqlPoint(x: 0.31821002986939084d, y: 0.685045600943952d), new NpgsqlTypes.NpgsqlPoint(x: 0.12495434277968354d, y: 0.02936437381180812d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09185956766323544d, y: 0.7171807768027775d), new NpgsqlTypes.NpgsqlPoint(x: 0.004879007734452712d, y: 0.9891984677791141d), new NpgsqlTypes.NpgsqlPoint(x: 0.27731524470888624d, y: 0.5913704033777252d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6468235321141097d, y: 0.1647041379288513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8608413082379881d, y: 0.1389806083562637d), new NpgsqlTypes.NpgsqlPoint(x: 0.6695333046200853d, y: 0.7317958952122973d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5730110046347754d, y: 0.9409087973495509d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330981473994523d, y: 0.4509351906457616d), new NpgsqlTypes.NpgsqlPoint(x: 0.33006715191965597d, y: 0.28950924461366645d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6491040537130678d, y: 0.24985813696032622d), new NpgsqlTypes.NpgsqlPoint(x: 0.44536959522811925d, y: 0.09497235319632069d), new NpgsqlTypes.NpgsqlPoint(x: 0.08446127601514786d, y: 0.29863502826424126d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6105609473460935d, y: 0.7695289465685707d), new NpgsqlTypes.NpgsqlPoint(x: 0.14046153725384192d, y: 0.23816401712604074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787021865826306d, y: 0.33362187521254116d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.716650270812797d, y: 0.19983377702185823d), new NpgsqlTypes.NpgsqlPoint(x: 0.1972343059523215d, y: 0.43799666604587706d), new NpgsqlTypes.NpgsqlPoint(x: 0.6455929127552513d, y: 0.5169933763457837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6189364765140634d, y: 0.20857560874476055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7990326442440921d, y: 0.9215372202118265d), new NpgsqlTypes.NpgsqlPoint(x: 0.11565830335611427d, y: 0.2538162641036634d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.829784031247452d, y: 0.04908538591142608d), new NpgsqlTypes.NpgsqlPoint(x: 0.848970856122993d, y: 0.9662609900330259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105519592272632d, y: 0.37166318606166615d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14666886370101695d, y: 0.36074485850181626d), new NpgsqlTypes.NpgsqlPoint(x: 0.2409882902862016d, y: 0.40804956931635594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5308015925747226d, y: 0.6538476578321172d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6987979426602002d, y: 0.2587636663977262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8532209072710214d, y: 0.9149896796472045d), new NpgsqlTypes.NpgsqlPoint(x: 0.44852635194645085d, y: 0.9248252764369521d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23775010838545108d, y: 0.8487845170204921d), new NpgsqlTypes.NpgsqlPoint(x: 0.15605997477536782d, y: 0.3105901288022296d), new NpgsqlTypes.NpgsqlPoint(x: 0.45399677628485946d, y: 0.562761203819887d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7432051242981291d, y: 0.27576298605440697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9846270197359263d, y: 0.23232139331105905d), new NpgsqlTypes.NpgsqlPoint(x: 0.6871591201543602d, y: 0.47563893658012546d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4318312508096963d, y: 0.46988149266532697d), new NpgsqlTypes.NpgsqlPoint(x: 0.4566090047896665d, y: 0.55396201485871d), new NpgsqlTypes.NpgsqlPoint(x: 0.07345611603168078d, y: 0.9440975314108179d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8609601976166272d, y: 0.488564916633594d), new NpgsqlTypes.NpgsqlPoint(x: 0.07614043091818212d, y: 0.2084271616548522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4348875912557355d, y: 0.9195368184332129d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15173502511671666d, y: 0.0843519304429402d), new NpgsqlTypes.NpgsqlPoint(x: 0.23319082864543395d, y: 0.11671721066892238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9098628637930258d, y: 0.08313875451429498d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5154768510144679d, y: 0.023812932922444796d), new NpgsqlTypes.NpgsqlPoint(x: 0.36244391212547455d, y: 0.6871411806375707d), new NpgsqlTypes.NpgsqlPoint(x: 0.34415259356491157d, y: 0.44122249780703826d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5326029926272384d, y: 0.12465793831965954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431460748428694d, y: 0.3517858439135739d), new NpgsqlTypes.NpgsqlPoint(x: 0.5795330750733306d, y: 0.29282626885054286d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6890334333480537d, y: 0.03171864124813428d), new NpgsqlTypes.NpgsqlPoint(x: 0.4630046340674674d, y: 0.05882066890155746d), new NpgsqlTypes.NpgsqlPoint(x: 0.30670814148821124d, y: 0.02247488236243289d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00036275096944315965d, y: 0.21321089254578296d), new NpgsqlTypes.NpgsqlPoint(x: 0.0632392767558424d, y: 0.5463677725447738d), new NpgsqlTypes.NpgsqlPoint(x: 0.30919836177286886d, y: 0.8527933119428397d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46443291118684427d, y: 0.021469653738448224d), new NpgsqlTypes.NpgsqlPoint(x: 0.028787814573877357d, y: 0.03461934138590228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7478653273856877d, y: 0.9431898797879387d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8093682337909823d, y: 0.9544544207953616d), new NpgsqlTypes.NpgsqlPoint(x: 0.1811504315928988d, y: 0.8996808299799821d), new NpgsqlTypes.NpgsqlPoint(x: 0.37576247142185737d, y: 0.560820454365976d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25552666976439786d, y: 0.9454835247011781d), new NpgsqlTypes.NpgsqlPoint(x: 0.30410759585490366d, y: 0.6093391517833404d), new NpgsqlTypes.NpgsqlPoint(x: 0.29923470898909943d, y: 0.900312408294602d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23516395929053246d, y: 0.6851140084472739d), new NpgsqlTypes.NpgsqlPoint(x: 0.1622757585394482d, y: 0.9256366329555951d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114289617881776d, y: 0.9652629566731509d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10675342200597815d, y: 0.3641331597736338d), new NpgsqlTypes.NpgsqlPoint(x: 0.35681657040410997d, y: 0.5991315952146116d), new NpgsqlTypes.NpgsqlPoint(x: 0.8359335974219726d, y: 0.700579867685257d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02573635381092454d, y: 0.4432950897746225d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252162744302165d, y: 0.1477107134293455d), new NpgsqlTypes.NpgsqlPoint(x: 0.5742671255316717d, y: 0.47867625273020775d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7862356133107247d, y: 0.5558026738219134d), new NpgsqlTypes.NpgsqlPoint(x: 0.04501309996388436d, y: 0.08169076241827333d), new NpgsqlTypes.NpgsqlPoint(x: 0.22262688576672973d, y: 0.48153974915392705d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6866402266404449d, y: 0.4907506142760655d), new NpgsqlTypes.NpgsqlPoint(x: 0.040643396474568494d, y: 0.42318530800341625d), new NpgsqlTypes.NpgsqlPoint(x: 0.3421755195290679d, y: 0.49792468029175097d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47385190578505987d, y: 0.867770518275027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4109160700246832d, y: 0.44588608190666135d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639280079867604d, y: 0.7721746578655414d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11733798068430812d, y: 0.19340346908556938d), new NpgsqlTypes.NpgsqlPoint(x: 0.8060944661896517d, y: 0.8632260377587142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421302195782096d, y: 0.3596019555967517d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3731669837132122d, y: 0.26534390037654043d), new NpgsqlTypes.NpgsqlPoint(x: 0.054869652083982534d, y: 0.9882998615272509d), new NpgsqlTypes.NpgsqlPoint(x: 0.49636091565487406d, y: 0.7821664492484092d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6600810491807086d, y: 0.684863915451162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8765303581698243d, y: 0.8771732861095948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447048679896238d, y: 0.5920094340216745d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7498550749754668d, y: 0.5275525252822294d), new NpgsqlTypes.NpgsqlPoint(x: 0.3955856949502461d, y: 0.17839983381809554d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488365324723563d, y: 0.030691002598833172d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15512603408598957d, y: 0.806655672456672d), new NpgsqlTypes.NpgsqlPoint(x: 0.14174343563390723d, y: 0.6224441575211305d), new NpgsqlTypes.NpgsqlPoint(x: 0.14792555527941542d, y: 0.4222536336639203d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8408485904619399d, y: 0.6690511519863536d), new NpgsqlTypes.NpgsqlPoint(x: 0.890552471272028d, y: 0.2510881297205606d), new NpgsqlTypes.NpgsqlPoint(x: 0.18416690138912495d, y: 0.8327972114181308d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33173934899498725d, y: 0.5423158483114368d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837199822193603d, y: 0.4178513312117822d), new NpgsqlTypes.NpgsqlPoint(x: 0.583119893197505d, y: 0.7101112621252447d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26956498821245756d, y: 0.06143233290463501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3737625936706872d, y: 0.9397018470045684d), new NpgsqlTypes.NpgsqlPoint(x: 0.45702286549464766d, y: 0.4522180570684782d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3415543500132078d, y: 0.15399524214570393d), new NpgsqlTypes.NpgsqlPoint(x: 0.17665070230901747d, y: 0.8368150640202344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2638861802418947d, y: 0.373021765619579d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4392981977576297d, y: 0.9221293776052311d), new NpgsqlTypes.NpgsqlPoint(x: 0.8270206380076985d, y: 0.13565199056958943d), new NpgsqlTypes.NpgsqlPoint(x: 0.22139592530160113d, y: 0.5075332325754729d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29128710503707755d, y: 0.0573486354063909d), new NpgsqlTypes.NpgsqlPoint(x: 0.20981761531243126d, y: 0.5744434555679775d), new NpgsqlTypes.NpgsqlPoint(x: 0.0886036642613246d, y: 0.8132079244753537d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6911852810117497d, y: 0.18749100876518443d), new NpgsqlTypes.NpgsqlPoint(x: 0.09696606749566095d, y: 0.9526572280141811d), new NpgsqlTypes.NpgsqlPoint(x: 0.09806737956819456d, y: 0.9667494603946845d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47036187891231585d, y: 0.6176510711012999d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369919223976738d, y: 0.9051284506179933d), new NpgsqlTypes.NpgsqlPoint(x: 0.34430914526500245d, y: 0.4128637195703859d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9050788726137512d, y: 0.0348601133328843d), new NpgsqlTypes.NpgsqlPoint(x: 0.6197701665031309d, y: 0.11204077225475029d), new NpgsqlTypes.NpgsqlPoint(x: 0.3796355363707441d, y: 0.2246069646206298d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8233571728757979d, y: 0.19861647140471672d), new NpgsqlTypes.NpgsqlPoint(x: 0.720293717876754d, y: 0.8519010869343083d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082504760277727d, y: 0.3218539499326164d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19850571875347311d, y: 0.8179780492320295d), new NpgsqlTypes.NpgsqlPoint(x: 0.16729148971066732d, y: 0.8557476962175619d), new NpgsqlTypes.NpgsqlPoint(x: 0.378917177581126d, y: 0.30865800576666025d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9302719904830286d, y: 0.5673880714619063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4363135062133757d, y: 0.5393056828673147d), new NpgsqlTypes.NpgsqlPoint(x: 0.017173976607091745d, y: 0.5763740226802224d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28167899852309375d, y: 0.7377532542444023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4865658862706077d, y: 0.6640458332441607d), new NpgsqlTypes.NpgsqlPoint(x: 0.14569004812915942d, y: 0.6613172939340539d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25105771967949775d, y: 0.6110796909970052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7407181030885407d, y: 0.8282882363664893d), new NpgsqlTypes.NpgsqlPoint(x: 0.2309980837229182d, y: 0.7716590636864087d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6592518276467005d, y: 0.1939391133615005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5675600059001584d, y: 0.3717857783344687d), new NpgsqlTypes.NpgsqlPoint(x: 0.33952518254802266d, y: 0.615553839159252d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30967180332939215d, y: 0.44864526699897933d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574767758994837d, y: 0.5325140880886842d), new NpgsqlTypes.NpgsqlPoint(x: 0.21205738761627202d, y: 0.9728852082157103d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7752084247303338d, y: 0.4621745935355609d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569080202934279d, y: 0.5744557126066585d), new NpgsqlTypes.NpgsqlPoint(x: 0.3352097683951323d, y: 0.26099249155944815d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0434519728166346d, y: 0.8765300967884787d), new NpgsqlTypes.NpgsqlPoint(x: 0.08529585622076608d, y: 0.9479175069460387d), new NpgsqlTypes.NpgsqlPoint(x: 0.09447262965192593d, y: 0.3087786903438374d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0866766221226084d, y: 0.7321818366776536d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799747038573139d, y: 0.055658849193093274d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836466508205317d, y: 0.7858405104958894d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24783115612207196d, y: 0.9673719436805109d), new NpgsqlTypes.NpgsqlPoint(x: 0.718363781746821d, y: 0.4004882978484734d), new NpgsqlTypes.NpgsqlPoint(x: 0.19968113986212532d, y: 0.3979409790521772d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5099061317271292d, y: 0.05721472078890344d), new NpgsqlTypes.NpgsqlPoint(x: 0.1964582272290719d, y: 0.634826004827394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9522692694254189d, y: 0.17139863870806327d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10456751604697057d, y: 0.05656710550117505d), new NpgsqlTypes.NpgsqlPoint(x: 0.16645552225227622d, y: 0.5477221921119803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670574686184637d, y: 0.39224300287324687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3499516169419069d, y: 0.6301303592316182d), new NpgsqlTypes.NpgsqlPoint(x: 0.01177145964345172d, y: 0.7629989858757857d), new NpgsqlTypes.NpgsqlPoint(x: 0.22515405032734326d, y: 0.39797315413246237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08316509954012197d, y: 0.8827310667397474d), new NpgsqlTypes.NpgsqlPoint(x: 0.7638682470833501d, y: 0.4440683092087d), new NpgsqlTypes.NpgsqlPoint(x: 0.30740084940243895d, y: 0.9231717154450472d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6085527595657959d, y: 0.22835477243240454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533122868201799d, y: 0.6120679145283672d), new NpgsqlTypes.NpgsqlPoint(x: 0.09836405151184191d, y: 0.6221356586478624d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6883709248939064d, y: 0.12771639730313245d), new NpgsqlTypes.NpgsqlPoint(x: 0.2178017321524227d, y: 0.5693911087430831d), new NpgsqlTypes.NpgsqlPoint(x: 0.27941835906537316d, y: 0.5320074595375905d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1591684220248899d, y: 0.2758583154012102d), new NpgsqlTypes.NpgsqlPoint(x: 0.03903996585435121d, y: 0.15970320219362422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7780992838266176d, y: 0.5353502283073449d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9272147406105283d, y: 0.07095964382782949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5533463645926605d, y: 0.8314863476117405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814968306151454d, y: 0.8898529253185361d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2072502402020766d, y: 0.7921453944679064d), new NpgsqlTypes.NpgsqlPoint(x: 0.1162616154338153d, y: 0.028317048656055333d), new NpgsqlTypes.NpgsqlPoint(x: 0.4158461358333273d, y: 0.659393152406092d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970985521613996d, y: 0.5241507980653455d), new NpgsqlTypes.NpgsqlPoint(x: 0.41123065058603425d, y: 0.5775224202022505d), new NpgsqlTypes.NpgsqlPoint(x: 0.3659430927524464d, y: 0.8793565405633544d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20734728309171369d, y: 0.6016563757114917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6446239374109037d, y: 0.44493881853192097d), new NpgsqlTypes.NpgsqlPoint(x: 0.8926280874312528d, y: 0.12496476230157061d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11022967574525322d, y: 0.9909680591544238d), new NpgsqlTypes.NpgsqlPoint(x: 0.3898738698219322d, y: 0.6827862654105558d), new NpgsqlTypes.NpgsqlPoint(x: 0.4534871340334812d, y: 0.894424530666787d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5975220674210067d, y: 0.7949447980193954d), new NpgsqlTypes.NpgsqlPoint(x: 0.26852349156052824d, y: 0.8593910978790922d), new NpgsqlTypes.NpgsqlPoint(x: 0.24856383347149547d, y: 0.1133606603612759d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7296223228940989d, y: 0.6707397445551236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932797807720497d, y: 0.8356566770648928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6888188207811872d, y: 0.016942450630588413d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8972123226326382d, y: 0.6222539716808031d), new NpgsqlTypes.NpgsqlPoint(x: 0.752056953663425d, y: 0.3517868530509468d), new NpgsqlTypes.NpgsqlPoint(x: 0.6852450325126367d, y: 0.7782750108055425d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4797316148378753d, y: 0.34916523925553256d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861920810506872d, y: 0.709181132608864d), new NpgsqlTypes.NpgsqlPoint(x: 0.27164535184612437d, y: 0.8276898198861411d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3850915061939201d, y: 0.5581453061359956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061079012755696d, y: 0.42505727501125756d), new NpgsqlTypes.NpgsqlPoint(x: 0.30085364678938753d, y: 0.12429184478556765d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8500055399682948d, y: 0.5639038541543394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9401543065686702d, y: 0.5572632821420348d), new NpgsqlTypes.NpgsqlPoint(x: 0.24562173765395867d, y: 0.9346621219438304d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24792198681803823d, y: 0.29814219385363827d), new NpgsqlTypes.NpgsqlPoint(x: 0.8804513016301715d, y: 0.2449322344341468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4086093752515907d, y: 0.9363608139416961d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04862691148511389d, y: 0.21758577617365082d), new NpgsqlTypes.NpgsqlPoint(x: 0.864661928146706d, y: 0.7024911414856099d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430653556277475d, y: 0.035826383658463246d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07322855782289384d, y: 0.28319302818850456d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083495412436921d, y: 0.4443542929372354d), new NpgsqlTypes.NpgsqlPoint(x: 0.21103612839870955d, y: 0.4776298520104445d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5262659648230184d, y: 0.2222559739820701d), new NpgsqlTypes.NpgsqlPoint(x: 0.9611757344128029d, y: 0.7094265440839557d), new NpgsqlTypes.NpgsqlPoint(x: 0.012777615045035717d, y: 0.9348686345701557d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39546401308951407d, y: 0.39571795447054203d), new NpgsqlTypes.NpgsqlPoint(x: 0.7717929359904232d, y: 0.2909745042379711d), new NpgsqlTypes.NpgsqlPoint(x: 0.9124429061246306d, y: 0.5556210100244209d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3119457341869609d, y: 0.905414312787887d), new NpgsqlTypes.NpgsqlPoint(x: 0.043046665302611586d, y: 0.11418032744913242d), new NpgsqlTypes.NpgsqlPoint(x: 0.22399569360644034d, y: 0.28247839204360903d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20380676667520692d, y: 0.1919670868216108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150665572043989d, y: 0.7618640190334757d), new NpgsqlTypes.NpgsqlPoint(x: 0.30241360676845364d, y: 0.2596922302560145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7107152057149776d, y: 0.6881672207449023d), new NpgsqlTypes.NpgsqlPoint(x: 0.4321872347064454d, y: 0.15484513319219384d), new NpgsqlTypes.NpgsqlPoint(x: 0.20571806228718903d, y: 0.23307243409336809d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4519095776968276d, y: 0.7666817597473579d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046862075474068d, y: 0.21726424564616564d), new NpgsqlTypes.NpgsqlPoint(x: 0.536443982255926d, y: 0.9623179937878319d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30327704363526675d, y: 0.028089996269203277d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722167676927222d, y: 0.9326646993263297d), new NpgsqlTypes.NpgsqlPoint(x: 0.22090111765170017d, y: 0.3445253011810452d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2493000159619515d, y: 0.2929632154489883d), new NpgsqlTypes.NpgsqlPoint(x: 0.8981584078746049d, y: 0.6978136552505169d), new NpgsqlTypes.NpgsqlPoint(x: 0.3490830247801433d, y: 0.9017438139443853d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25051585643277585d, y: 0.7344466331145663d), new NpgsqlTypes.NpgsqlPoint(x: 0.27662818584900795d, y: 0.34126143431484224d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432207288090018d, y: 0.47023525748963446d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9524542338433751d, y: 0.3282242347467986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350807220597905d, y: 0.631579200333394d), new NpgsqlTypes.NpgsqlPoint(x: 0.5260628908524638d, y: 0.9616601816445403d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3645638676112144d, y: 0.9863893862972477d), new NpgsqlTypes.NpgsqlPoint(x: 0.12697699200843404d, y: 0.84565976089751d), new NpgsqlTypes.NpgsqlPoint(x: 0.42474468921437025d, y: 0.7782176502851417d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.880192877121877d, y: 0.8975500229114319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754405859373199d, y: 0.6749712593493299d), new NpgsqlTypes.NpgsqlPoint(x: 0.8605315312522458d, y: 0.6722735758693359d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4143652716032702d, y: 0.8776547105904886d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047931894916612d, y: 0.21972638651788723d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172064622914098d, y: 0.053993678625955166d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9193469111999606d, y: 0.8183072452298442d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581347874183305d, y: 0.49473811832100845d), new NpgsqlTypes.NpgsqlPoint(x: 0.4914027846121397d, y: 0.734420230452708d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5748691882023678d, y: 0.216479981445038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5348789084602144d, y: 0.08587809540514602d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103585336217584d, y: 0.8778075489534872d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7305371810999657d, y: 0.08418365651211468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132720623898543d, y: 0.6874049501698166d), new NpgsqlTypes.NpgsqlPoint(x: 0.18766990617689294d, y: 0.013512521632686236d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07241594674549434d, y: 0.6607606632119417d), new NpgsqlTypes.NpgsqlPoint(x: 0.19131192167178446d, y: 0.3128155316332296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7910419947482807d, y: 0.643258536433299d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6682618561471019d, y: 0.8243479916078924d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402000578217027d, y: 0.9181854985247144d), new NpgsqlTypes.NpgsqlPoint(x: 0.010906649626589715d, y: 0.4415979158144917d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9079365865517266d, y: 0.6825407711099517d), new NpgsqlTypes.NpgsqlPoint(x: 0.6224634870818477d, y: 0.2830245977120155d), new NpgsqlTypes.NpgsqlPoint(x: 0.9022031996273742d, y: 0.14470412596862925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6849104021773853d, y: 0.7300481464180119d), new NpgsqlTypes.NpgsqlPoint(x: 0.8735475119542582d, y: 0.7402522806030601d), new NpgsqlTypes.NpgsqlPoint(x: 0.7073221037816896d, y: 0.4577615820573939d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8096730575782339d, y: 0.4925197177759013d), new NpgsqlTypes.NpgsqlPoint(x: 0.13914673843044745d, y: 0.5722284959349392d), new NpgsqlTypes.NpgsqlPoint(x: 0.941838964786856d, y: 0.3495979422852352d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9906433279169797d, y: 0.22627294417138222d), new NpgsqlTypes.NpgsqlPoint(x: 0.6698388154638419d, y: 0.0005082509244197508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935528033515369d, y: 0.4104303345974317d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34772159432283656d, y: 0.5802277723746888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290233540966838d, y: 0.5808919976336752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465442390959921d, y: 0.21911888876117547d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024989929811162215d, y: 0.6508683093661468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4227384669219785d, y: 0.5562743380967847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5350057190795847d, y: 0.6635442849870569d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7032470712858389d, y: 0.4675858305271313d), new NpgsqlTypes.NpgsqlPoint(x: 0.2191387818334951d, y: 0.7425831155342537d), new NpgsqlTypes.NpgsqlPoint(x: 0.1276686318808946d, y: 0.15491623936912202d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.529570826766612d, y: 0.0032424356818728794d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840063223909522d, y: 0.9254110185739093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4833507797768868d, y: 0.5726766414984902d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2544834715477231d, y: 0.3616464487075074d), new NpgsqlTypes.NpgsqlPoint(x: 0.24238476139916065d, y: 0.606058820621659d), new NpgsqlTypes.NpgsqlPoint(x: 0.3441425606000633d, y: 0.481188267717932d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12114365028542129d, y: 0.3038005556534975d), new NpgsqlTypes.NpgsqlPoint(x: 0.06867552547109612d, y: 0.8167495686570356d), new NpgsqlTypes.NpgsqlPoint(x: 0.494625236957016d, y: 0.6623101407415692d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2384563309419011d, y: 0.9175532098761316d), new NpgsqlTypes.NpgsqlPoint(x: 0.012241319349896918d, y: 0.9307499584102088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512548981797627d, y: 0.9144609143817053d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20550870315090541d, y: 0.8472557058696238d), new NpgsqlTypes.NpgsqlPoint(x: 0.2947835542562277d, y: 0.6799852369724042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731770672172479d, y: 0.5035855342734077d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17934519965534568d, y: 0.25581931495082855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781988490947366d, y: 0.43103344098242713d), new NpgsqlTypes.NpgsqlPoint(x: 0.44653008017197626d, y: 0.27898285342747586d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6887016763896413d, y: 0.6593454564844481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9725776219581798d, y: 0.14085633304482392d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605602859427554d, y: 0.2821246687828233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.662207591008644d, y: 0.6030906661180938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9016039030921174d, y: 0.01662147354049237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111730110087294d, y: 0.30947491306372776d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6150013223838249d, y: 0.16420260843581047d), new NpgsqlTypes.NpgsqlPoint(x: 0.18665459868019985d, y: 0.9377888192986154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6678640625871514d, y: 0.7222980895101069d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6380626091879087d, y: 0.6699958691766704d), new NpgsqlTypes.NpgsqlPoint(x: 0.24953838888832203d, y: 0.9163466151075156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9770818186613897d, y: 0.643946167262606d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3786703256951175d, y: 0.0672352959902276d), new NpgsqlTypes.NpgsqlPoint(x: 0.8621182328531963d, y: 0.667230123860046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055296257322642d, y: 0.8630936833805687d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3482150477488315d, y: 0.1176651158048646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590702240152948d, y: 0.5730238594285607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955772633927732d, y: 0.8676352335528744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1347169883959649d, y: 0.2276133140381129d), new NpgsqlTypes.NpgsqlPoint(x: 0.09381885114273203d, y: 0.8574697134780741d), new NpgsqlTypes.NpgsqlPoint(x: 0.5552083689279836d, y: 0.6795884153563085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06164489254102634d, y: 0.4473033456125727d), new NpgsqlTypes.NpgsqlPoint(x: 0.449876096345855d, y: 0.2872860102696728d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919173495505299d, y: 0.6176462899771379d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06551195330368398d, y: 0.9621867270902392d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097003715730432d, y: 0.4988662232721235d), new NpgsqlTypes.NpgsqlPoint(x: 0.053932317219371084d, y: 0.07874902190078514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7801120313349934d, y: 0.6094110956715975d), new NpgsqlTypes.NpgsqlPoint(x: 0.758030119864176d, y: 0.5272480129502544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8237716610883459d, y: 0.41668668210525006d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2798983480873818d, y: 0.6410816026297457d), new NpgsqlTypes.NpgsqlPoint(x: 0.15211465784561873d, y: 0.34836880158089767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975694600296667d, y: 0.9751433507530008d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41472978093513246d, y: 0.4226007688663407d), new NpgsqlTypes.NpgsqlPoint(x: 0.9071015189836548d, y: 0.15462394594972417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6146413794875856d, y: 0.6729499468138006d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8121719318307008d, y: 0.3579778476232923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536496158003577d, y: 0.6931998621774799d), new NpgsqlTypes.NpgsqlPoint(x: 0.4382380309128402d, y: 0.21112292617678008d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9547947284694286d, y: 0.9714806018994856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976380598983918d, y: 0.3718843832412456d), new NpgsqlTypes.NpgsqlPoint(x: 0.12797271853553327d, y: 0.10320065105970122d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32476378750457824d, y: 0.8214788714657875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379799668192237d, y: 0.5052991413252149d), new NpgsqlTypes.NpgsqlPoint(x: 0.21161862421321975d, y: 0.888401511221886d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5313639869743d, y: 0.24901756449263246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074244473176565d, y: 0.40391369475726246d), new NpgsqlTypes.NpgsqlPoint(x: 0.5235408273614861d, y: 0.12910818496261967d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8988788741587108d, y: 0.7989128294890557d), new NpgsqlTypes.NpgsqlPoint(x: 0.31089489363847467d, y: 0.7746121269714895d), new NpgsqlTypes.NpgsqlPoint(x: 0.1339756021437415d, y: 0.283450795329916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04145940986179608d, y: 0.11298327967036637d), new NpgsqlTypes.NpgsqlPoint(x: 0.18895065588601578d, y: 0.3195560917935194d), new NpgsqlTypes.NpgsqlPoint(x: 0.29237520287122576d, y: 0.22367324867681482d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8406883222964334d, y: 0.7902504676816811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248793669783802d, y: 0.9560579920011906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826763620145448d, y: 0.6671543307519884d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6371939312138353d, y: 0.7970420536802075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9854073534778333d, y: 0.5596088053263671d), new NpgsqlTypes.NpgsqlPoint(x: 0.18389934176065736d, y: 0.05476367699756923d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8675502863511337d, y: 0.3864667448385274d), new NpgsqlTypes.NpgsqlPoint(x: 0.49773719432032626d, y: 0.671874808596832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9877142073119013d, y: 0.8034360717747239d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5499650818955226d, y: 0.5714014383530579d), new NpgsqlTypes.NpgsqlPoint(x: 0.6854762159040289d, y: 0.03549046676784107d), new NpgsqlTypes.NpgsqlPoint(x: 0.8292631776178443d, y: 0.8046029542039924d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9263072123136501d, y: 0.05914256203193624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7473303516557478d, y: 0.14536462443845788d), new NpgsqlTypes.NpgsqlPoint(x: 0.037702451831493566d, y: 0.808782835505912d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9859285825845086d, y: 0.10109291906465578d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550290659236737d, y: 0.3823967771263166d), new NpgsqlTypes.NpgsqlPoint(x: 0.46028030336757786d, y: 0.6414795192430995d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5565641036493365d, y: 0.6779981342404979d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789219622735621d, y: 0.05946625780981807d), new NpgsqlTypes.NpgsqlPoint(x: 0.8996531102895182d, y: 0.9273547311683066d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4081959967496207d, y: 0.041602161897254186d), new NpgsqlTypes.NpgsqlPoint(x: 0.655762162154181d, y: 0.06807967880336885d), new NpgsqlTypes.NpgsqlPoint(x: 0.1536965524532542d, y: 0.8973379788937484d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40698265815933754d, y: 0.6608699578075413d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206298036260324d, y: 0.5902752724484003d), new NpgsqlTypes.NpgsqlPoint(x: 0.36832969717762554d, y: 0.27855743357991014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07795623579187139d, y: 0.18575762564120946d), new NpgsqlTypes.NpgsqlPoint(x: 0.8379792743516736d, y: 0.40919564519705176d), new NpgsqlTypes.NpgsqlPoint(x: 0.4494491508371622d, y: 0.8880087207097332d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.953484053076376d, y: 0.7266329859361957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8053031109975948d, y: 0.3460927150153893d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404151536587529d, y: 0.09543151356602775d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34033131744365064d, y: 0.45638958783924444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5045126021895038d, y: 0.4446119297717994d), new NpgsqlTypes.NpgsqlPoint(x: 0.42119547096662324d, y: 0.6228069803648013d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4045603754858035d, y: 0.9050003993351655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3016104344345488d, y: 0.11627065632373235d), new NpgsqlTypes.NpgsqlPoint(x: 0.29373164947887553d, y: 0.989799609413676d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9438689182574869d, y: 0.2993849806716731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6614536979043982d, y: 0.7036145608736337d), new NpgsqlTypes.NpgsqlPoint(x: 0.34291033923041914d, y: 0.9877587010906623d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8320816932549554d, y: 0.7236414491134484d), new NpgsqlTypes.NpgsqlPoint(x: 0.16757487790516612d, y: 0.9855510161750517d), new NpgsqlTypes.NpgsqlPoint(x: 0.21315110472668441d, y: 0.5961370618782136d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4570307554030192d, y: 0.7696309842289519d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390679136555056d, y: 0.6355430891033671d), new NpgsqlTypes.NpgsqlPoint(x: 0.565317440911254d, y: 0.8835357602860153d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.937502482618397d, y: 0.7106646844502366d), new NpgsqlTypes.NpgsqlPoint(x: 0.22012206752294416d, y: 0.4284464998917963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441221107373924d, y: 0.548345771807513d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3544792621080458d, y: 0.8452090120428197d), new NpgsqlTypes.NpgsqlPoint(x: 0.08838897939739199d, y: 0.24519472546767962d), new NpgsqlTypes.NpgsqlPoint(x: 0.7776794608434d, y: 0.5371043491005881d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2003294300099241d, y: 0.24913936899605615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3562623386076925d, y: 0.086451701577689d), new NpgsqlTypes.NpgsqlPoint(x: 0.11353600912737383d, y: 0.7546010504726505d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5001483576458945d, y: 0.9155300082962761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8758800812381432d, y: 0.25152161149472796d), new NpgsqlTypes.NpgsqlPoint(x: 0.09986242544062862d, y: 0.265331088306233d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2914746756444869d, y: 0.9355012923932872d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698339487249381d, y: 0.2993104441803316d), new NpgsqlTypes.NpgsqlPoint(x: 0.991481361035206d, y: 0.768011607345467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056324298044616694d, y: 0.9606353388097345d), new NpgsqlTypes.NpgsqlPoint(x: 0.9984271502901059d, y: 0.3060835990065417d), new NpgsqlTypes.NpgsqlPoint(x: 0.46011663090119537d, y: 0.7732598009213141d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6575260262688157d, y: 0.920293599015244d), new NpgsqlTypes.NpgsqlPoint(x: 0.159019768770846d, y: 0.18267122742320918d), new NpgsqlTypes.NpgsqlPoint(x: 0.288910976553022d, y: 0.7159155179968791d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22552759431710068d, y: 0.8782025688570467d), new NpgsqlTypes.NpgsqlPoint(x: 0.17867788600410228d, y: 0.37146705404685554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412474767086749d, y: 0.5775311681319436d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07711432203201696d, y: 0.5578530421394491d), new NpgsqlTypes.NpgsqlPoint(x: 0.5583543457638931d, y: 0.9213196955547132d), new NpgsqlTypes.NpgsqlPoint(x: 0.324799755572458d, y: 0.5660901197659478d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2361826147286169d, y: 0.8963042435897848d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729098906901487d, y: 0.5599344060867645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6373070107668614d, y: 0.9500073634940865d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9695906814306392d, y: 0.5206525175600024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7527883299087655d, y: 0.8940923776919705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952310128777377d, y: 0.47240392145443666d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37274232516958283d, y: 0.8265558075616554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9527072529601976d, y: 0.8350493146202045d), new NpgsqlTypes.NpgsqlPoint(x: 0.895115662668049d, y: 0.3250573958507468d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0811891103244553d, y: 0.6021792359391315d), new NpgsqlTypes.NpgsqlPoint(x: 0.041773328054711345d, y: 0.44548052677404115d), new NpgsqlTypes.NpgsqlPoint(x: 0.21214999919969602d, y: 0.7575242551805953d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6730103294075676d, y: 0.16303927260887785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7806803764629109d, y: 0.9938882642768231d), new NpgsqlTypes.NpgsqlPoint(x: 0.01662319224870612d, y: 0.7385245475999744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05517914950718339d, y: 0.9626552005955079d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083096224711506d, y: 0.48784175792217044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292226940082488d, y: 0.8127765046003884d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.935707259634696d, y: 0.23400614837173306d), new NpgsqlTypes.NpgsqlPoint(x: 0.05883697177256464d, y: 0.6706042343854586d), new NpgsqlTypes.NpgsqlPoint(x: 0.5633928960274007d, y: 0.6778153351613739d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13142653575624896d, y: 0.2877918290011079d), new NpgsqlTypes.NpgsqlPoint(x: 0.22989325032237418d, y: 0.0604019920877481d), new NpgsqlTypes.NpgsqlPoint(x: 0.8929900368566943d, y: 0.5976695045649058d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9618975844481067d, y: 0.7079094353550903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5976202360325837d, y: 0.05549913424296371d), new NpgsqlTypes.NpgsqlPoint(x: 0.030156955205006497d, y: 0.9188420295009837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29082320920463434d, y: 0.9276280099656556d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928986521164272d, y: 0.2689540430375331d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605813781700093d, y: 0.39389400301022803d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.566267800464298d, y: 0.31502897293626986d), new NpgsqlTypes.NpgsqlPoint(x: 0.036413400697919984d, y: 0.22499604154427133d), new NpgsqlTypes.NpgsqlPoint(x: 0.10496480428165944d, y: 0.6699984905218956d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5950838009607826d, y: 0.34466272611981186d), new NpgsqlTypes.NpgsqlPoint(x: 0.496366197144263d, y: 0.9919514590710382d), new NpgsqlTypes.NpgsqlPoint(x: 0.2709293263782909d, y: 0.24832206557296255d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22816816888908575d, y: 0.9021943003807793d), new NpgsqlTypes.NpgsqlPoint(x: 0.277887342939091d, y: 0.042001914916717675d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860571866396469d, y: 0.21680214522644792d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.954253116301705d, y: 0.29192892336341025d), new NpgsqlTypes.NpgsqlPoint(x: 0.19502009409640975d, y: 0.06683418682036557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8724641880152638d, y: 0.5900312454373697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19183806803519288d, y: 0.48600706299667384d), new NpgsqlTypes.NpgsqlPoint(x: 0.02686745912646049d, y: 0.49560615430711985d), new NpgsqlTypes.NpgsqlPoint(x: 0.30320201662903645d, y: 0.6647202964951797d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.53348763751398d, y: 0.7097488193021718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006103506720747d, y: 0.13717345631317046d), new NpgsqlTypes.NpgsqlPoint(x: 0.08734308386307088d, y: 0.10519501235593531d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.606175814630879d, y: 0.5825745717914516d), new NpgsqlTypes.NpgsqlPoint(x: 0.9528842005487499d, y: 0.4231489778816897d), new NpgsqlTypes.NpgsqlPoint(x: 0.15917751040817718d, y: 0.7915778842133186d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5338854100313944d, y: 0.674004689978025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194756903642397d, y: 0.7510098989337443d), new NpgsqlTypes.NpgsqlPoint(x: 0.10890844743779049d, y: 0.4983368710700018d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6135343443065101d, y: 0.3241553403576617d), new NpgsqlTypes.NpgsqlPoint(x: 0.11484863695150604d, y: 0.21024454927295178d), new NpgsqlTypes.NpgsqlPoint(x: 0.3541613727159967d, y: 0.3739997974887369d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21269784648722823d, y: 0.9240378202411954d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772051175867139d, y: 0.8881267139991237d), new NpgsqlTypes.NpgsqlPoint(x: 0.4634125658325511d, y: 0.4353523576329785d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3551403175011746d, y: 0.6838422774497845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005864960329816d, y: 0.9658362024923451d), new NpgsqlTypes.NpgsqlPoint(x: 0.21779708253036478d, y: 0.8655934105815878d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23931168369016098d, y: 0.9114770699131175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529443035168671d, y: 0.5950193900961351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8373910268696421d, y: 0.7365945818482295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3993763223325021d, y: 0.7814336827604822d), new NpgsqlTypes.NpgsqlPoint(x: 0.49693481341414614d, y: 0.20609431194894978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8812334444233444d, y: 0.8360471898611287d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5617674997911238d, y: 0.45018570303577465d), new NpgsqlTypes.NpgsqlPoint(x: 0.0844704351402985d, y: 0.05988378022467755d), new NpgsqlTypes.NpgsqlPoint(x: 0.08523864015265559d, y: 0.902470713515513d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7359667485976857d, y: 0.7746039817123719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223011223305716d, y: 0.48622195967669113d), new NpgsqlTypes.NpgsqlPoint(x: 0.010145864506351354d, y: 0.5810465842521311d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7395436605920804d, y: 0.3322707101130876d), new NpgsqlTypes.NpgsqlPoint(x: 0.6328181043976794d, y: 0.1283512626803135d), new NpgsqlTypes.NpgsqlPoint(x: 0.4448889749020638d, y: 0.38050003613566696d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4663544676656476d, y: 0.2849252200548321d), new NpgsqlTypes.NpgsqlPoint(x: 0.010805692497049213d, y: 0.7490862007812483d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235472864370301d, y: 0.23137361149141789d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9810405817187524d, y: 0.34555416628320623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6593873355571028d, y: 0.8375357705723425d), new NpgsqlTypes.NpgsqlPoint(x: 0.45109080081263087d, y: 0.6180407909318824d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9610822730487655d, y: 0.04273722348665254d), new NpgsqlTypes.NpgsqlPoint(x: 0.028716684180999597d, y: 0.8186596844534826d), new NpgsqlTypes.NpgsqlPoint(x: 0.28161239714217334d, y: 0.7066091676031455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8593349009384859d, y: 0.3662868544566624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9552134506037584d, y: 0.7694930707540427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176227696648082d, y: 0.8817182326059354d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1794721587122312d, y: 0.8057450634285225d), new NpgsqlTypes.NpgsqlPoint(x: 0.18692746632480617d, y: 0.9464926363057169d), new NpgsqlTypes.NpgsqlPoint(x: 0.3294982433524243d, y: 0.03838137371985584d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5525547478391095d, y: 0.4748875281672199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4783004384453611d, y: 0.6169440649843949d), new NpgsqlTypes.NpgsqlPoint(x: 0.4374707499270163d, y: 0.9447106933746167d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8006916908928171d, y: 0.08883656336977508d), new NpgsqlTypes.NpgsqlPoint(x: 0.020170607075145952d, y: 0.2480974719849124d), new NpgsqlTypes.NpgsqlPoint(x: 0.46023663940332227d, y: 0.5264001468806686d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7240538301269627d, y: 0.09944930007534492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341679922200125d, y: 0.9303986523653038d), new NpgsqlTypes.NpgsqlPoint(x: 0.6925623630334917d, y: 0.12054795973164478d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7761996706133524d, y: 0.6142355870311677d), new NpgsqlTypes.NpgsqlPoint(x: 0.25375199476854227d, y: 0.05948659170880177d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004125693535944d, y: 0.43683709326888687d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0162900919648864d, y: 0.833022404210227d), new NpgsqlTypes.NpgsqlPoint(x: 0.92939138978846d, y: 0.28316455599551227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7415645785335298d, y: 0.9539606629506607d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5035281880684556d, y: 0.5839619317573953d), new NpgsqlTypes.NpgsqlPoint(x: 0.42959873863136677d, y: 0.498288073587565d), new NpgsqlTypes.NpgsqlPoint(x: 0.16618459265752472d, y: 0.46035204192834267d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5458951620686244d, y: 0.22123553360418358d), new NpgsqlTypes.NpgsqlPoint(x: 0.3943815429046946d, y: 0.4444033334872619d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393425518031367d, y: 0.566288695449568d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8755619733199721d, y: 0.4876358948958399d), new NpgsqlTypes.NpgsqlPoint(x: 0.38583108554778167d, y: 0.5860130026273378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7869857348234436d, y: 0.7002855159724916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8427807760810899d, y: 0.5174280682619306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917550997094692d, y: 0.1695810801625287d), new NpgsqlTypes.NpgsqlPoint(x: 0.8749437500691897d, y: 0.2023010821451473d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9599982783353328d, y: 0.9267391471110048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853109359993979d, y: 0.9544982207958169d), new NpgsqlTypes.NpgsqlPoint(x: 0.8804842506980064d, y: 0.7726003977238057d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.811101907111587d, y: 0.7052224941395694d), new NpgsqlTypes.NpgsqlPoint(x: 0.9356112152078294d, y: 0.3455955552857116d), new NpgsqlTypes.NpgsqlPoint(x: 0.5356439830373388d, y: 0.38043409124435124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33263376605167694d, y: 0.5899751354840159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4747280923997871d, y: 0.3665477116109108d), new NpgsqlTypes.NpgsqlPoint(x: 0.529166538755576d, y: 0.9478979918929721d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18613299791721882d, y: 0.24704645392478775d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404038062952063d, y: 0.6271276499921338d), new NpgsqlTypes.NpgsqlPoint(x: 0.9142656717870216d, y: 0.8485111055187471d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8817893368445294d, y: 0.897691779106306d), new NpgsqlTypes.NpgsqlPoint(x: 0.549871998199126d, y: 0.29587407107591257d), new NpgsqlTypes.NpgsqlPoint(x: 0.19376023557865596d, y: 0.73617302260743d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 160,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4872463194406914d, y: 0.8799917169787183d), new NpgsqlTypes.NpgsqlPoint(x: 0.1306573817205453d, y: 0.6591639145680369d), new NpgsqlTypes.NpgsqlPoint(x: 0.34412597125640054d, y: 0.5077661987862718d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8468755015681776d, y: 0.4954414970602954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584639799910194d, y: 0.9287771524101869d), new NpgsqlTypes.NpgsqlPoint(x: 0.9570353050981382d, y: 0.8098294554687582d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5278087601736925d, y: 0.9989000182236151d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374401682350274d, y: 0.11325519590009459d), new NpgsqlTypes.NpgsqlPoint(x: 0.14586517041752112d, y: 0.5503341580780067d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9824684241085019d, y: 0.6118464193963502d), new NpgsqlTypes.NpgsqlPoint(x: 0.14040695104365652d, y: 0.22501703220344538d), new NpgsqlTypes.NpgsqlPoint(x: 0.5124930944719402d, y: 0.6367832268403295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.410446766649991d, y: 0.6013531149817405d), new NpgsqlTypes.NpgsqlPoint(x: 0.2576330528165549d, y: 0.47556961069369896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7993120771205047d, y: 0.3277627801923697d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6489439796571149d, y: 0.36750327645350833d), new NpgsqlTypes.NpgsqlPoint(x: 0.01626399658665245d, y: 0.3465283008738187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2085851699046738d, y: 0.38672455511731496d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13588098096724865d, y: 0.968515250384465d), new NpgsqlTypes.NpgsqlPoint(x: 0.41466276283933046d, y: 0.11895518973828978d), new NpgsqlTypes.NpgsqlPoint(x: 0.47028611228710293d, y: 0.5823136727166163d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7271011075563509d, y: 0.26857988693045587d), new NpgsqlTypes.NpgsqlPoint(x: 0.23616748114932462d, y: 0.28123095077523597d), new NpgsqlTypes.NpgsqlPoint(x: 0.20947475817796923d, y: 0.07044232104259518d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3724467945404345d, y: 0.0747416014458715d), new NpgsqlTypes.NpgsqlPoint(x: 0.607511567093968d, y: 0.6776634951679331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3464677323941029d, y: 0.31747239965428076d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8023958492653935d, y: 0.04747148855998573d), new NpgsqlTypes.NpgsqlPoint(x: 0.16979606499156885d, y: 0.702039401434112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7520461731505482d, y: 0.5001004609065309d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6439141104971697d, y: 0.3669748248447233d), new NpgsqlTypes.NpgsqlPoint(x: 0.8178704615951159d, y: 0.5890961617242902d), new NpgsqlTypes.NpgsqlPoint(x: 0.0047908194354223665d, y: 0.24300753189001567d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36823569336737705d, y: 0.7069250909092539d), new NpgsqlTypes.NpgsqlPoint(x: 0.2701550853349258d, y: 0.03698320669553756d), new NpgsqlTypes.NpgsqlPoint(x: 0.488487104232868d, y: 0.9169764010540175d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2187245321701501d, y: 0.5894897715555483d), new NpgsqlTypes.NpgsqlPoint(x: 0.5609220547100655d, y: 0.2044994386857445d), new NpgsqlTypes.NpgsqlPoint(x: 0.422509847745681d, y: 0.628436072365577d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9211344152555011d, y: 0.9365753541929804d), new NpgsqlTypes.NpgsqlPoint(x: 0.17891951325115496d, y: 0.8774389229384213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419465440641308d, y: 0.40396911892463794d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12993216609104385d, y: 0.7644180322172734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646480535310565d, y: 0.22668635481056676d), new NpgsqlTypes.NpgsqlPoint(x: 0.6466978829812867d, y: 0.6598782099127426d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.439072885702249d, y: 0.2876252200976598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6555130766109937d, y: 0.7075373699562064d), new NpgsqlTypes.NpgsqlPoint(x: 0.6981053728323555d, y: 0.9439552558736769d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.881716888042047d, y: 0.07938990823223291d), new NpgsqlTypes.NpgsqlPoint(x: 0.22244328822601d, y: 0.21168341582606665d), new NpgsqlTypes.NpgsqlPoint(x: 0.902588313963791d, y: 0.10767339466173576d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9300713754948134d, y: 0.8900175580185404d), new NpgsqlTypes.NpgsqlPoint(x: 0.08957530645355138d, y: 0.6823240978960039d), new NpgsqlTypes.NpgsqlPoint(x: 0.3157646637836339d, y: 0.8458479705625022d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06038270658718725d, y: 0.33867373307456605d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289850541531427d, y: 0.8774687692631211d), new NpgsqlTypes.NpgsqlPoint(x: 0.6942954702590608d, y: 0.6088410795728282d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9168954926518613d, y: 0.07730035767878707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5751040688806807d, y: 0.991165194788739d), new NpgsqlTypes.NpgsqlPoint(x: 0.10657686389190124d, y: 0.20895168462895908d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7777534585697007d, y: 0.15347432239509062d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425955472301907d, y: 0.2643354213635176d), new NpgsqlTypes.NpgsqlPoint(x: 0.12254208309197001d, y: 0.3222292309460252d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 183,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8979906067800106d, y: 0.6384519385233458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4144781091715186d, y: 0.2869690138910347d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722348493451294d, y: 0.37742571336734143d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5775580811850305d, y: 0.11475122740233679d), new NpgsqlTypes.NpgsqlPoint(x: 0.5622897160979982d, y: 0.9736870150266111d), new NpgsqlTypes.NpgsqlPoint(x: 0.8434408706448988d, y: 0.6019270360421062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3817437176281555d, y: 0.49351327162016767d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084233169050828d, y: 0.6338170014981898d), new NpgsqlTypes.NpgsqlPoint(x: 0.32016377559661446d, y: 0.9431374139696259d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9191986645435396d, y: 0.2744301709058916d), new NpgsqlTypes.NpgsqlPoint(x: 0.28767001901126965d, y: 0.4124363587665949d), new NpgsqlTypes.NpgsqlPoint(x: 0.2980026158222069d, y: 0.5356353537173534d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9944369972563196d, y: 0.6968243661153036d), new NpgsqlTypes.NpgsqlPoint(x: 0.1501583034858961d, y: 0.06706139878071615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9298353136202733d, y: 0.7234468620077328d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4921175518202606d, y: 0.7015485907386205d), new NpgsqlTypes.NpgsqlPoint(x: 0.11439327128163768d, y: 0.3028730014420806d), new NpgsqlTypes.NpgsqlPoint(x: 0.17216774323205797d, y: 0.25864605709712574d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4700229419090203d, y: 0.16923904708971205d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577661771229663d, y: 0.9340218213832887d), new NpgsqlTypes.NpgsqlPoint(x: 0.6305157273950889d, y: 0.2050085932584238d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5103835354649396d, y: 0.45158177705350977d), new NpgsqlTypes.NpgsqlPoint(x: 0.11375238416457356d, y: 0.8261826098907028d), new NpgsqlTypes.NpgsqlPoint(x: 0.9390645329667164d, y: 0.8860225754937833d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12360507815280475d, y: 0.5354134499828501d), new NpgsqlTypes.NpgsqlPoint(x: 0.050710986795811985d, y: 0.8323307333643929d), new NpgsqlTypes.NpgsqlPoint(x: 0.06797066811721952d, y: 0.06162547392645179d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09252691265690649d, y: 0.5148404586257814d), new NpgsqlTypes.NpgsqlPoint(x: 0.11061723272342827d, y: 0.9255413639758641d), new NpgsqlTypes.NpgsqlPoint(x: 0.33761998090073797d, y: 0.18638836483009558d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6680251237853877d, y: 0.03338735882250943d), new NpgsqlTypes.NpgsqlPoint(x: 0.060062896175615554d, y: 0.29705686360387495d), new NpgsqlTypes.NpgsqlPoint(x: 0.8833796659320703d, y: 0.8470311829562794d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8456948400760083d, y: 0.9816466860210842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5678247807950612d, y: 0.05906169112351878d), new NpgsqlTypes.NpgsqlPoint(x: 0.9941128440386561d, y: 0.04181484149126735d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13448443706573898d, y: 0.7818297301427602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924695911236774d, y: 0.5734815767662009d), new NpgsqlTypes.NpgsqlPoint(x: 0.387845131460945d, y: 0.6929548014688082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8826955549740128d, y: 0.8886046825057076d), new NpgsqlTypes.NpgsqlPoint(x: 0.34192358797530453d, y: 0.059080920233863354d), new NpgsqlTypes.NpgsqlPoint(x: 0.5779483012942829d, y: 0.8045307398349133d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21343594630112972d, y: 0.28333771219636184d), new NpgsqlTypes.NpgsqlPoint(x: 0.09776181534442463d, y: 0.2885639615813692d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853225302254149d, y: 0.3179413688077455d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2315764281289815d, y: 0.46651647023454645d), new NpgsqlTypes.NpgsqlPoint(x: 0.07804660880550107d, y: 0.6018342345073054d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021920952718313d, y: 0.9650213660101695d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613172684165897d, y: 0.03250939513106432d), new NpgsqlTypes.NpgsqlPoint(x: 0.9565407058033938d, y: 0.8695135776443723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6771163412257991d, y: 0.7211282577198492d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6516497701887186d, y: 0.16977846999078428d), new NpgsqlTypes.NpgsqlPoint(x: 0.4715147246618683d, y: 0.5907315076786654d), new NpgsqlTypes.NpgsqlPoint(x: 0.07830157607919408d, y: 0.6458191129111671d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8317658915769249d, y: 0.36709292777214364d), new NpgsqlTypes.NpgsqlPoint(x: 0.483004494514238d, y: 0.7626982887477485d), new NpgsqlTypes.NpgsqlPoint(x: 0.586854420986425d, y: 0.0691406074198393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2855092398966139d, y: 0.5070457860146236d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657852337286626d, y: 0.2283231176659004d), new NpgsqlTypes.NpgsqlPoint(x: 0.1751558598142361d, y: 0.3707142364454762d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.011451801493377545d, y: 0.7237951588158014d), new NpgsqlTypes.NpgsqlPoint(x: 0.7903725218165303d, y: 0.775273579217605d), new NpgsqlTypes.NpgsqlPoint(x: 0.2745054328162889d, y: 0.15437992068656237d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10344203392955165d, y: 0.17724506432236553d), new NpgsqlTypes.NpgsqlPoint(x: 0.4360156586088042d, y: 0.5064132974517728d), new NpgsqlTypes.NpgsqlPoint(x: 0.693398874978813d, y: 0.7455971476012332d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 189,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7907982821089328d, y: 0.7908712479796146d), new NpgsqlTypes.NpgsqlPoint(x: 0.16898095574775618d, y: 0.4065825703807995d), new NpgsqlTypes.NpgsqlPoint(x: 0.8742007590083872d, y: 0.7215532690416308d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.530806803468446d, y: 0.9549263030174526d), new NpgsqlTypes.NpgsqlPoint(x: 0.12045826316447783d, y: 0.5818568065614802d), new NpgsqlTypes.NpgsqlPoint(x: 0.39488142582923247d, y: 0.8946738625142423d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18773534689499094d, y: 0.2884535973466287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617559879322291d, y: 0.7934806905383961d), new NpgsqlTypes.NpgsqlPoint(x: 0.552677318664922d, y: 0.07043383743834253d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4005884061191046d, y: 0.9736295762925243d), new NpgsqlTypes.NpgsqlPoint(x: 0.4154612913808994d, y: 0.9452784493810732d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746943426532047d, y: 0.14110730595552523d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42469420591086116d, y: 0.31036677438409144d), new NpgsqlTypes.NpgsqlPoint(x: 0.4956633925456625d, y: 0.5120630128248564d), new NpgsqlTypes.NpgsqlPoint(x: 0.09155255143915941d, y: 0.4089138717443195d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6420731105403451d, y: 0.05062525921588246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968975172371986d, y: 0.7185208669249619d), new NpgsqlTypes.NpgsqlPoint(x: 0.4015642822590624d, y: 0.35263986621412247d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 191,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.747958536385031d, y: 0.18080262135693725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853557036000573d, y: 0.20200529751038632d), new NpgsqlTypes.NpgsqlPoint(x: 0.91610581542596d, y: 0.3422231773946883d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2859277450408222d, y: 0.4754362634240753d), new NpgsqlTypes.NpgsqlPoint(x: 0.9931317181836243d, y: 0.41203430235946115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5050742374796563d, y: 0.1788817334464864d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09205142338297823d, y: 0.40690203777737566d), new NpgsqlTypes.NpgsqlPoint(x: 0.6092341672057868d, y: 0.28510724124748454d), new NpgsqlTypes.NpgsqlPoint(x: 0.018946166636166994d, y: 0.4084624129472548d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9840684303059514d, y: 0.698143978638299d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977432843334699d, y: 0.6641120974401625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8540669396030747d, y: 0.28320332027820116d)),

},
    ModelInner = new NpgsqlPolygonpolygonListD12MI
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1056863934563208d, y: 0.9030940246158273d), new NpgsqlTypes.NpgsqlPoint(x: 0.4837818285468499d, y: 0.14611938160332028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4300871940238955d, y: 0.21045714421086092d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4778785488561439d, y: 0.9271334045042926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7528675861325435d, y: 0.22529594561615518d), new NpgsqlTypes.NpgsqlPoint(x: 0.018484209037950783d, y: 0.6313038960112851d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27291876339103427d, y: 0.7269621260062155d), new NpgsqlTypes.NpgsqlPoint(x: 0.10806070700665182d, y: 0.09430184526277241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589539613042656d, y: 0.6613650019743801d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02531399601830231d, y: 0.4770449621639863d), new NpgsqlTypes.NpgsqlPoint(x: 0.6332105612682372d, y: 0.9497599062347092d), new NpgsqlTypes.NpgsqlPoint(x: 0.2831443921445528d, y: 0.5741854839225587d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7688596437952695d, y: 0.5325304290146106d), new NpgsqlTypes.NpgsqlPoint(x: 0.08026305555724356d, y: 0.7853324105722609d), new NpgsqlTypes.NpgsqlPoint(x: 0.1569732218986437d, y: 0.23290719759683653d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1736633015086192d, y: 0.9339587671729671d), new NpgsqlTypes.NpgsqlPoint(x: 0.17317719556677147d, y: 0.19105007482462721d), new NpgsqlTypes.NpgsqlPoint(x: 0.8310656312915098d, y: 0.31768117106283167d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9674916194594652d, y: 0.7461876234606658d), new NpgsqlTypes.NpgsqlPoint(x: 0.1442874160639881d, y: 0.758870364460627d), new NpgsqlTypes.NpgsqlPoint(x: 0.017324193088100626d, y: 0.43125980522505114d)),

},
},
            new NpgsqlPolygonpolygonListD1E2M
{
    Id = 200,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9147219943679005d, y: 0.1750516713674911d), new NpgsqlTypes.NpgsqlPoint(x: 0.4774215881098357d, y: 0.7191326689742208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6547928097221885d, y: 0.2725413061315457d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6231279394965811d, y: 0.6702131845898359d), new NpgsqlTypes.NpgsqlPoint(x: 0.7972098672006523d, y: 0.3615483188995885d), new NpgsqlTypes.NpgsqlPoint(x: 0.8402103650059165d, y: 0.5224203374599069d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44156794140003264d, y: 0.4749765830847008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4811801963741059d, y: 0.018672020314330684d), new NpgsqlTypes.NpgsqlPoint(x: 0.18485433676892926d, y: 0.17922344795576073d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2956803705725002d, y: 0.48003819117997226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079547760596898d, y: 0.555724597538204d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648687803850457d, y: 0.5681656407629014d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.606576981638859d, y: 0.04007373459690411d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276766762799405d, y: 0.7943650996866982d), new NpgsqlTypes.NpgsqlPoint(x: 0.0033393763319878866d, y: 0.1317207646981955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2322906112250448d, y: 0.5628186290620083d), new NpgsqlTypes.NpgsqlPoint(x: 0.30290786930449587d, y: 0.3105336069571615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9219262902201826d, y: 0.5382246805453337d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd12mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd12mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
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

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd12mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd12mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd12mi_id
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
    npgsqlpolygonpolygonlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonlistd12mi_id
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
    npgsqlpolygonpolygonlistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonlistd12mi_id", 
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
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonListD1E2M> models = null;

                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd12mi mi ON mi.id = m.npgsqlpolygonpolygonlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd12mi mi ON mi.id = m.npgsqlpolygonpolygonlistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 140;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 120;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 110;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 83;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 124;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 77;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd12mi mi ON mi.id = m.npgsqlpolygonpolygonlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 37;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 160;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[5], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[6], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[7], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 174;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M), typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 58, query1, 168, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 183, query1, 154, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 147, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 83, query1, 168, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 104, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 154, query1, 168, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonListD1E2M>();
                 ((INpgsqlPolygonListpolygonListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 37, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPolygonpolygonListD1E2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.npgsqlpolygonpolygonlistd12mi mi ON mi.id = m.npgsqlpolygonpolygonlistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
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
                var models = await((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 72, 104))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonListD1)this).DbConnectionSTSelectModelBatch(connection, 133, 51))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[8], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[9], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[10], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[11], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[12], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[13], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[14], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[15], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[16], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[17], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[18], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[19], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[20], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[21], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[22], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[23], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[24], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[25], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[26], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[27], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[28], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[29], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[30], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[31], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[32], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[25],_testData[33], false);
                        NpgsqlPolygonpolygonListD1E2M.AssertModel(models[26],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 66);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[10], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[11], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[12], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[13], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[14], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[15], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[16], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[17], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[18], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[18],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[19],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[20],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[21],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[22],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[23],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonListD1)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlPolygonpolygonListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD12MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD12MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonlistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonlistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
FROM public.binary_npgsqlpolygonpolygonlistd1e2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonlistd12mi mi ON mi.id = m.npgsqlpolygonpolygonlistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonlistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonListpolygonListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA), typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
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
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
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
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA), typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
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
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
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
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MI), typeof(NpgsqlPolygonpolygonListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MI>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MI>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MI>();
                ((INpgsqlPolygonListpolygonListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonlistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA), typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                await ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonListD12MIWA>();
                ((INpgsqlPolygonListpolygonListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonlistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonListD1))]
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
                var models = await ((INpgsqlPolygonListpolygonListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonListpolygonListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

