

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.052523008745415156d, y: 0.3822037758603173d), new NpgsqlTypes.NpgsqlPoint(x: 0.18577205233934668d, y: 0.48476423920310896d), new NpgsqlTypes.NpgsqlPoint(x: 0.20230232171301288d, y: 0.8373289682340969d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7159199067370268d, y: 0.8500974668075266d), new NpgsqlTypes.NpgsqlPoint(x: 0.541887083144803d, y: 0.9184275341233921d), new NpgsqlTypes.NpgsqlPoint(x: 0.27153042040533526d, y: 0.6145796702821699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0011613762707026742d, y: 0.10847684790845125d), new NpgsqlTypes.NpgsqlPoint(x: 0.8588989026514912d, y: 0.653838421795809d), new NpgsqlTypes.NpgsqlPoint(x: 0.22880799784246353d, y: 0.4343272491089456d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9898929862202228d, y: 0.04879280456683599d), new NpgsqlTypes.NpgsqlPoint(x: 0.8691560536369897d, y: 0.103424428159414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6711413979022067d, y: 0.002057222732879005d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7895800967059945d, y: 0.4122127496140028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8819179048900725d, y: 0.46748684178913724d), new NpgsqlTypes.NpgsqlPoint(x: 0.22988153471006667d, y: 0.28486779988163413d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9862771833110988d, y: 0.604918268645532d), new NpgsqlTypes.NpgsqlPoint(x: 0.13229265625152997d, y: 0.13788057906000317d), new NpgsqlTypes.NpgsqlPoint(x: 0.4511785951001279d, y: 0.028839972667827785d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1819650700932769d, y: 0.595408417362772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895256865613727d, y: 0.755768735062684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284557017602512d, y: 0.6759798905417641d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3934415275085805d, y: 0.3433341322591327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6397375252138946d, y: 0.9914245944050297d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610964541840511d, y: 0.8343269468798837d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38428424505330194d, y: 0.054745911487592114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7798414974134904d, y: 0.4753237246109261d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718914347182894d, y: 0.9828452719747512d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6163338673829403d, y: 0.7979296995953108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455998796779825d, y: 0.1078832687777288d), new NpgsqlTypes.NpgsqlPoint(x: 0.4828238543794513d, y: 0.7445144915900009d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5698738340629002d, y: 0.13703508280700172d), new NpgsqlTypes.NpgsqlPoint(x: 0.047059813129797345d, y: 0.41897437643240865d), new NpgsqlTypes.NpgsqlPoint(x: 0.0346226066436065d, y: 0.3992659539110156d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19392938717373143d, y: 0.16289085477362186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3019914661348324d, y: 0.19033967668923357d), new NpgsqlTypes.NpgsqlPoint(x: 0.838402535913462d, y: 0.823609326556668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9762161255686054d, y: 0.10842283743825099d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890564802488525d, y: 0.6803962917334431d), new NpgsqlTypes.NpgsqlPoint(x: 0.12899666925446807d, y: 0.4847411052575812d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4925548746236633d, y: 0.880562739821518d), new NpgsqlTypes.NpgsqlPoint(x: 0.11955476323765346d, y: 0.5118769766345616d), new NpgsqlTypes.NpgsqlPoint(x: 0.10978171892584832d, y: 0.8808477590598291d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9891146353422312d, y: 0.2501859591339177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7318328633501849d, y: 0.5264094719502322d), new NpgsqlTypes.NpgsqlPoint(x: 0.26682760183095244d, y: 0.5034251464878796d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10065379750309844d, y: 0.906305926964813d), new NpgsqlTypes.NpgsqlPoint(x: 0.17447634553376068d, y: 0.7819345362487675d), new NpgsqlTypes.NpgsqlPoint(x: 0.10688822993095848d, y: 0.7155436896572006d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5338109023774065d, y: 0.4461832052413921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2201357767879354d, y: 0.0920025928874526d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171776090400357d, y: 0.5246641044828307d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9127833426061005d, y: 0.9557166563130292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4477491422703732d, y: 0.0856078274281259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6460947319822227d, y: 0.08932917106862825d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5408264278727417d, y: 0.08549606552452338d), new NpgsqlTypes.NpgsqlPoint(x: 0.11172162239210404d, y: 0.31799340635244044d), new NpgsqlTypes.NpgsqlPoint(x: 0.1603451382011849d, y: 0.47224371001428445d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5012015785611188d, y: 0.18047058261909654d), new NpgsqlTypes.NpgsqlPoint(x: 0.3700446898219104d, y: 0.933328036786385d), new NpgsqlTypes.NpgsqlPoint(x: 0.38577687329425314d, y: 0.1283275303775283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14121545773105804d, y: 0.8985118707886958d), new NpgsqlTypes.NpgsqlPoint(x: 0.8474784948813058d, y: 0.2928985345396887d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231385087867885d, y: 0.03442593765142121d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8478333464176213d, y: 0.5183571935364093d), new NpgsqlTypes.NpgsqlPoint(x: 0.9053727019139616d, y: 0.963014139801103d), new NpgsqlTypes.NpgsqlPoint(x: 0.48274799040500793d, y: 0.11175335196174974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8888708479383829d, y: 0.8482303814263468d), new NpgsqlTypes.NpgsqlPoint(x: 0.9470466804632999d, y: 0.41168302274008717d), new NpgsqlTypes.NpgsqlPoint(x: 0.14062723076748196d, y: 0.30796478283929163d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.708702609926608d, y: 0.006498852766337104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6885360420829263d, y: 0.5343014172934983d), new NpgsqlTypes.NpgsqlPoint(x: 0.45451887460013807d, y: 0.14817300793335453d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5959463123441048d, y: 0.8490790350459845d), new NpgsqlTypes.NpgsqlPoint(x: 0.999139753686745d, y: 0.1771444436388221d), new NpgsqlTypes.NpgsqlPoint(x: 0.3333913532657883d, y: 0.5755359678719536d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7806389863997569d, y: 0.26939983152391345d), new NpgsqlTypes.NpgsqlPoint(x: 0.46506766575274394d, y: 0.3445819243045879d), new NpgsqlTypes.NpgsqlPoint(x: 0.20405880405200616d, y: 0.48100616687009734d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9879284711632826d, y: 0.6677259933813756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6219733819381142d, y: 0.8909991086689493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721579193466817d, y: 0.9876533249703077d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7052515181780352d, y: 0.5099622181987665d), new NpgsqlTypes.NpgsqlPoint(x: 0.43750523866832813d, y: 0.9668011469774342d), new NpgsqlTypes.NpgsqlPoint(x: 0.2758911493564782d, y: 0.005042734420818595d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4413518784583478d, y: 0.5364092039038646d), new NpgsqlTypes.NpgsqlPoint(x: 0.830086630266514d, y: 0.001381962744763432d), new NpgsqlTypes.NpgsqlPoint(x: 0.26111717989235006d, y: 0.22424690209047982d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06784433578456528d, y: 0.9768903104735637d), new NpgsqlTypes.NpgsqlPoint(x: 0.22246133347827068d, y: 0.3283695410871813d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106345284450067d, y: 0.12896972856567357d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7400950691020596d, y: 0.9755528674961433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6648598734009364d, y: 0.6381008142747229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681855551160631d, y: 0.9457384997659749d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14395138705761357d, y: 0.562986266057681d), new NpgsqlTypes.NpgsqlPoint(x: 0.9912861898751621d, y: 0.6659819346032149d), new NpgsqlTypes.NpgsqlPoint(x: 0.32858568804451793d, y: 0.9271085788263118d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9519881052661371d, y: 0.19857559006376813d), new NpgsqlTypes.NpgsqlPoint(x: 0.09966065546933378d, y: 0.09120236730569709d), new NpgsqlTypes.NpgsqlPoint(x: 0.8903705058407784d, y: 0.6848343405481383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8552237254491767d, y: 0.03601839652039995d), new NpgsqlTypes.NpgsqlPoint(x: 0.09343395721888637d, y: 0.7913831810867539d), new NpgsqlTypes.NpgsqlPoint(x: 0.1235333524925456d, y: 0.7240941154609088d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8782847147422985d, y: 0.42610415988372397d), new NpgsqlTypes.NpgsqlPoint(x: 0.892562285649657d, y: 0.3442059534251435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6022863262630873d, y: 0.14819726723804383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12845987231996236d, y: 0.6436015869672989d), new NpgsqlTypes.NpgsqlPoint(x: 0.4135071512480726d, y: 0.6794247438807405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5462769535199479d, y: 0.8766006845290106d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2738380091550229d, y: 0.20562326124792796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4365326972754079d, y: 0.4145769511262529d), new NpgsqlTypes.NpgsqlPoint(x: 0.7225811146740408d, y: 0.03541518492769469d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3327906306240128d, y: 0.4912101597731209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901611976803921d, y: 0.8947084018301582d), new NpgsqlTypes.NpgsqlPoint(x: 0.9517699483809198d, y: 0.8607875593748231d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14695070128730436d, y: 0.709528048159213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927092853764469d, y: 0.31377931721363894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807568133795121d, y: 0.6091138766019767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17097946405028674d, y: 0.5954749324677472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095147228078827d, y: 0.8470438993263053d), new NpgsqlTypes.NpgsqlPoint(x: 0.7629223485573445d, y: 0.11688582910997103d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06494685700196523d, y: 0.506740296018559d), new NpgsqlTypes.NpgsqlPoint(x: 0.6124954269086832d, y: 0.5323137851143535d), new NpgsqlTypes.NpgsqlPoint(x: 0.07143689988058655d, y: 0.3427713698664431d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4084016030475226d, y: 0.4828069405982863d), new NpgsqlTypes.NpgsqlPoint(x: 0.7363759130797487d, y: 0.5269077521634062d), new NpgsqlTypes.NpgsqlPoint(x: 0.7646985691988523d, y: 0.004281283327230878d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.905682252224231d, y: 0.7692705431540033d), new NpgsqlTypes.NpgsqlPoint(x: 0.731704682392231d, y: 0.3141022432067849d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577362198170131d, y: 0.43764672417028394d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2970901809970593d, y: 0.9121863684978319d), new NpgsqlTypes.NpgsqlPoint(x: 0.1669851405541074d, y: 0.9244937072070681d), new NpgsqlTypes.NpgsqlPoint(x: 0.17817643607251743d, y: 0.7128036560652526d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7444974227170484d, y: 0.564391002148927d), new NpgsqlTypes.NpgsqlPoint(x: 0.0625884487793934d, y: 0.3682964314041641d), new NpgsqlTypes.NpgsqlPoint(x: 0.11715439030560215d, y: 0.7776004827205371d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.357806873284756d, y: 0.9228375327448677d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590311084566939d, y: 0.9183534572691908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455133465872692d, y: 0.8565627720680609d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7563587786194871d, y: 0.7165367894837181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9346596363292958d, y: 0.6600172712398815d), new NpgsqlTypes.NpgsqlPoint(x: 0.1426386856241153d, y: 0.21487292330878938d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22214074665474948d, y: 0.6198925263896474d), new NpgsqlTypes.NpgsqlPoint(x: 0.37104772502401395d, y: 0.39931951133594157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756610651455767d, y: 0.6930231565447759d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9599073141170107d, y: 0.5942861602424386d), new NpgsqlTypes.NpgsqlPoint(x: 0.0968313929876008d, y: 0.04756583677273962d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568017551397452d, y: 0.36604963557452264d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4968020461946612d, y: 0.8305642124032405d), new NpgsqlTypes.NpgsqlPoint(x: 0.06019169991182305d, y: 0.013423542222095297d), new NpgsqlTypes.NpgsqlPoint(x: 0.06799955251594314d, y: 0.38570969824626555d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7189257289884214d, y: 0.5379325838381736d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974998593797792d, y: 0.33830529119408925d), new NpgsqlTypes.NpgsqlPoint(x: 0.07031164055325723d, y: 0.9047421172052179d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8018767076511948d, y: 0.07398733829399307d), new NpgsqlTypes.NpgsqlPoint(x: 0.8233238207157718d, y: 0.9408102333124405d), new NpgsqlTypes.NpgsqlPoint(x: 0.40552961839646906d, y: 0.5755666511806945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06470785286670244d, y: 0.9248839094896406d), new NpgsqlTypes.NpgsqlPoint(x: 0.17389230556881796d, y: 0.4986087937268059d), new NpgsqlTypes.NpgsqlPoint(x: 0.373587965886629d, y: 0.18018524475804976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3172429069376822d, y: 0.8319120067080084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8937229110472484d, y: 0.2244652048023883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6803990858176923d, y: 0.7023233632926066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8801777969525888d, y: 0.009698989971974492d), new NpgsqlTypes.NpgsqlPoint(x: 0.18841971837946436d, y: 0.18260607897757564d), new NpgsqlTypes.NpgsqlPoint(x: 0.5301973388357031d, y: 0.49441977542779936d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8397952526078993d, y: 0.0013450440775862882d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109239305083051d, y: 0.040365360111098925d), new NpgsqlTypes.NpgsqlPoint(x: 0.8730458774996034d, y: 0.19672556624641224d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42443173561619485d, y: 0.5494745193714139d), new NpgsqlTypes.NpgsqlPoint(x: 0.596785218605374d, y: 0.8123126846446531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9939208069827107d, y: 0.6384076245224011d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0485481667564176d, y: 0.2561075705590674d), new NpgsqlTypes.NpgsqlPoint(x: 0.3708701014434491d, y: 0.9282953283350941d), new NpgsqlTypes.NpgsqlPoint(x: 0.19587404599541736d, y: 0.5758292273991188d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942681326362925d, y: 0.4831616414294181d), new NpgsqlTypes.NpgsqlPoint(x: 0.04583730573972222d, y: 0.4937537498327246d), new NpgsqlTypes.NpgsqlPoint(x: 0.07158540857474338d, y: 0.8138923643033947d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42103712819280004d, y: 0.02058360029170836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520042699601863d, y: 0.732755609344342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5799110701165953d, y: 0.5662351720446623d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10725614302292996d, y: 0.9052885299074628d), new NpgsqlTypes.NpgsqlPoint(x: 0.11870006058259108d, y: 0.5400908905149859d), new NpgsqlTypes.NpgsqlPoint(x: 0.4103286414898756d, y: 0.9317384172933495d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.987483947252127d, y: 0.050168691174792945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7025466528346028d, y: 0.18246838696796752d), new NpgsqlTypes.NpgsqlPoint(x: 0.43807380236155957d, y: 0.7424283307287293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5268295072243213d, y: 0.15693782396953826d), new NpgsqlTypes.NpgsqlPoint(x: 0.2614770454710784d, y: 0.11594406565252457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235910129000769d, y: 0.5314260284277637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.697197034977573d, y: 0.20411150396570976d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352887687435517d, y: 0.26288372722524855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7886705790225903d, y: 0.63154700738472d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7567127921209628d, y: 0.11954713101036196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7115019987546585d, y: 0.689460096146104d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987743161994187d, y: 0.06561113830943854d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08312129255289158d, y: 0.8697590456462085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3244653898515365d, y: 0.9622172185587984d), new NpgsqlTypes.NpgsqlPoint(x: 0.6459086873771706d, y: 0.17354914434457347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7480489714188933d, y: 0.11681671501042779d), new NpgsqlTypes.NpgsqlPoint(x: 0.7856824629590148d, y: 0.8350373785082109d), new NpgsqlTypes.NpgsqlPoint(x: 0.18235555319060126d, y: 0.8000696532035559d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15260618706290485d, y: 0.2916885959498814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8831230002657686d, y: 0.6952820461257272d), new NpgsqlTypes.NpgsqlPoint(x: 0.2704482578306878d, y: 0.04525481614218674d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02589672672527199d, y: 0.8427313460614593d), new NpgsqlTypes.NpgsqlPoint(x: 0.04700401123028908d, y: 0.9400651269558932d), new NpgsqlTypes.NpgsqlPoint(x: 0.530313594439184d, y: 0.7141480342638488d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20866517786904992d, y: 0.9974984276559388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4649379091999899d, y: 0.9537331188765701d), new NpgsqlTypes.NpgsqlPoint(x: 0.19028539369417974d, y: 0.20289171735078193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6952382138939435d, y: 0.2583032565092259d), new NpgsqlTypes.NpgsqlPoint(x: 0.4303024146829194d, y: 0.43547675320531376d), new NpgsqlTypes.NpgsqlPoint(x: 0.03264046842427448d, y: 0.6212588411075509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0649076234338869d, y: 0.22002577247405009d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977096147301733d, y: 0.19627351951712768d), new NpgsqlTypes.NpgsqlPoint(x: 0.02775216880762199d, y: 0.5731695127256434d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3408840899013663d, y: 0.6913571899692432d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848680215059779d, y: 0.33536041700842745d), new NpgsqlTypes.NpgsqlPoint(x: 0.954347352055079d, y: 0.15241023042181934d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40482624995997674d, y: 0.5625884125626351d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244472599884348d, y: 0.5015124931483794d), new NpgsqlTypes.NpgsqlPoint(x: 0.004345018144867541d, y: 0.34681885516665323d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9163824196890942d, y: 0.3823524357971979d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503286688544954d, y: 0.7225958265570179d), new NpgsqlTypes.NpgsqlPoint(x: 0.4033713354302937d, y: 0.9708138383137738d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18713009573738926d, y: 0.890098590191853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8232770130397188d, y: 0.5493478669636148d), new NpgsqlTypes.NpgsqlPoint(x: 0.386496223299735d, y: 0.6875150971174473d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46888402047043565d, y: 0.2238778659334023d), new NpgsqlTypes.NpgsqlPoint(x: 0.633075979416777d, y: 0.17890328370856157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952627249085839d, y: 0.4742155918889317d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05733715058764788d, y: 0.09006156546569932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118302075020734d, y: 0.6531968465368029d), new NpgsqlTypes.NpgsqlPoint(x: 0.1571718036807861d, y: 0.11518846876900823d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06734154956475602d, y: 0.04420423315807598d), new NpgsqlTypes.NpgsqlPoint(x: 0.7849721671885659d, y: 0.9985832361969614d), new NpgsqlTypes.NpgsqlPoint(x: 0.8155045041005268d, y: 0.9174409195460481d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41049296044905903d, y: 0.4899769624254804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407481461958495d, y: 0.3119057518852686d), new NpgsqlTypes.NpgsqlPoint(x: 0.16021189278101378d, y: 0.012867041937748125d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3731095165244368d, y: 0.4988462715394283d), new NpgsqlTypes.NpgsqlPoint(x: 0.40671202812386764d, y: 0.44585617780083675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6182743728376167d, y: 0.4704639625512983d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6157296356819545d, y: 0.7571835392326499d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316713114437786d, y: 0.15130771492628947d), new NpgsqlTypes.NpgsqlPoint(x: 0.22654837430105546d, y: 0.45821148991190974d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5856193086053941d, y: 0.3810930965324051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8005427921128714d, y: 0.2786684824823151d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842802854929432d, y: 0.9336175522448568d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9396387545212223d, y: 0.9287155363061924d), new NpgsqlTypes.NpgsqlPoint(x: 0.25745109712018577d, y: 0.5209847745602396d), new NpgsqlTypes.NpgsqlPoint(x: 0.29924279167389134d, y: 0.2991112950196325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4748357489621182d, y: 0.20234870014030182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789499662381734d, y: 0.6816135519319472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633197932817447d, y: 0.057271751755181954d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5519283743801234d, y: 0.46630397645535293d), new NpgsqlTypes.NpgsqlPoint(x: 0.46768410347392264d, y: 0.9726445543052653d), new NpgsqlTypes.NpgsqlPoint(x: 0.07074023739353341d, y: 0.6717961675160705d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8134666637037737d, y: 0.2601813184794707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701560611664986d, y: 0.6808210756975165d), new NpgsqlTypes.NpgsqlPoint(x: 0.8854653226084986d, y: 0.2633382645499832d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9542958403783857d, y: 0.962403318040845d), new NpgsqlTypes.NpgsqlPoint(x: 0.10026085381729544d, y: 0.4642434904875121d), new NpgsqlTypes.NpgsqlPoint(x: 0.004824717281190494d, y: 0.9945582016379143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4635977103958915d, y: 0.8427273155554241d), new NpgsqlTypes.NpgsqlPoint(x: 0.9507711836467233d, y: 0.8399295951271064d), new NpgsqlTypes.NpgsqlPoint(x: 0.20102344276867412d, y: 0.25382492049908356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8296793591193673d, y: 0.39258478654732487d), new NpgsqlTypes.NpgsqlPoint(x: 0.007560934178133416d, y: 0.6196457307378218d), new NpgsqlTypes.NpgsqlPoint(x: 0.10767910908484635d, y: 0.026975572809695758d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5860611432363833d, y: 0.7487084952099387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680953189805407d, y: 0.07073486913825322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264292378663191d, y: 0.9497632381566161d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09687172938212885d, y: 0.1333908537194457d), new NpgsqlTypes.NpgsqlPoint(x: 0.804645994299936d, y: 0.6647950041774194d), new NpgsqlTypes.NpgsqlPoint(x: 0.37964621515884833d, y: 0.46037242409232526d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8661596674148965d, y: 0.030744511245281214d), new NpgsqlTypes.NpgsqlPoint(x: 0.3088604247979033d, y: 0.008753527652053394d), new NpgsqlTypes.NpgsqlPoint(x: 0.004899988127811561d, y: 0.28357493074120643d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17729416633421058d, y: 0.41430468376885277d), new NpgsqlTypes.NpgsqlPoint(x: 0.3955840710239674d, y: 0.45366969943527913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152444409991096d, y: 0.010657899267186077d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8244821308739803d, y: 0.12630808325258447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7472517598695188d, y: 0.9916909379718087d), new NpgsqlTypes.NpgsqlPoint(x: 0.873542153005527d, y: 0.47809500504596014d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4135668409316965d, y: 0.7339998199091795d), new NpgsqlTypes.NpgsqlPoint(x: 0.17807152294016382d, y: 0.43400482647705463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121177088350023d, y: 0.337202919750774d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5946131338057732d, y: 0.12089343874406189d), new NpgsqlTypes.NpgsqlPoint(x: 0.6213133768587902d, y: 0.376912285987395d), new NpgsqlTypes.NpgsqlPoint(x: 0.0777427159667895d, y: 0.9321263354952558d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1875119078643046d, y: 0.37919506018127713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7273526581056774d, y: 0.46580301534558677d), new NpgsqlTypes.NpgsqlPoint(x: 0.09430077880366283d, y: 0.9348568291995727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37335810813874193d, y: 0.5015003284612892d), new NpgsqlTypes.NpgsqlPoint(x: 0.38743993096125295d, y: 0.32863931063200313d), new NpgsqlTypes.NpgsqlPoint(x: 0.18985267859448118d, y: 0.32399198228464576d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5668692460770466d, y: 0.7627589718343101d), new NpgsqlTypes.NpgsqlPoint(x: 0.21026624873882072d, y: 0.026399296740193923d), new NpgsqlTypes.NpgsqlPoint(x: 0.24974956677938875d, y: 0.27613472796221394d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20760533773158363d, y: 0.25763948305209483d), new NpgsqlTypes.NpgsqlPoint(x: 0.6750422802598702d, y: 0.553612963155053d), new NpgsqlTypes.NpgsqlPoint(x: 0.8088627231171986d, y: 0.34724916537427286d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.548934543648108d, y: 0.21190167233990065d), new NpgsqlTypes.NpgsqlPoint(x: 0.40346003660091223d, y: 0.2940016661059188d), new NpgsqlTypes.NpgsqlPoint(x: 0.45526110593513236d, y: 0.46118096941613396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3862395336273895d, y: 0.8081314444565373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4283316111069094d, y: 0.6078712894864171d), new NpgsqlTypes.NpgsqlPoint(x: 0.273444377046957d, y: 0.6196441679550363d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26180486262337765d, y: 0.02761282578898261d), new NpgsqlTypes.NpgsqlPoint(x: 0.839538182157342d, y: 0.5959170393118589d), new NpgsqlTypes.NpgsqlPoint(x: 0.06398989922005671d, y: 0.9487087792368567d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14219577408647288d, y: 0.25153596150473545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8881705984835226d, y: 0.6189026093662817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7385487599766491d, y: 0.22246767729641348d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.984479525333613d, y: 0.5894058596548054d), new NpgsqlTypes.NpgsqlPoint(x: 0.890024144244528d, y: 0.6789644462513091d), new NpgsqlTypes.NpgsqlPoint(x: 0.905643150478348d, y: 0.06850215763235912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20821445472734068d, y: 0.5105914661684838d), new NpgsqlTypes.NpgsqlPoint(x: 0.29392879104571357d, y: 0.8962497465275102d), new NpgsqlTypes.NpgsqlPoint(x: 0.33986531119063434d, y: 0.9956393801483612d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1331398678422374d, y: 0.5003349798678137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432941933094847d, y: 0.2558007339647491d), new NpgsqlTypes.NpgsqlPoint(x: 0.048522140252936885d, y: 0.18805713892552067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2988514370632538d, y: 0.3677997191206549d), new NpgsqlTypes.NpgsqlPoint(x: 0.33590691764093183d, y: 0.5868676753126086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6374487993588216d, y: 0.36053218948304944d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6841338002333699d, y: 0.8225454578549332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7701031225477349d, y: 0.1553533644342514d), new NpgsqlTypes.NpgsqlPoint(x: 0.36130276115117554d, y: 0.6430408517772135d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4816664415646249d, y: 0.760166752332243d), new NpgsqlTypes.NpgsqlPoint(x: 0.1387357511394791d, y: 0.16217502325106226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989513275522698d, y: 0.8273815007422275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13904912395262348d, y: 0.8067088078822443d), new NpgsqlTypes.NpgsqlPoint(x: 0.982166617955859d, y: 0.45923736050917463d), new NpgsqlTypes.NpgsqlPoint(x: 0.45289451200851494d, y: 0.7261197490236668d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7730904568319218d, y: 0.3528047971849061d), new NpgsqlTypes.NpgsqlPoint(x: 0.5342548274891874d, y: 0.48468737910507553d), new NpgsqlTypes.NpgsqlPoint(x: 0.06622984380822117d, y: 0.999726321083823d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14751998240369346d, y: 0.6428506490665921d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941577151928741d, y: 0.6904908692907917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370450113510062d, y: 0.8336722242996784d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46187500977772145d, y: 0.33834301296099834d), new NpgsqlTypes.NpgsqlPoint(x: 0.13415794110846357d, y: 0.6275638524304672d), new NpgsqlTypes.NpgsqlPoint(x: 0.2818275053221032d, y: 0.25479692984944036d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5249779452260832d, y: 0.30270386388877346d), new NpgsqlTypes.NpgsqlPoint(x: 0.14172243759473568d, y: 0.8425315879205006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115796200322106d, y: 0.5363098944651162d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5006640429991406d, y: 0.6268719432175952d), new NpgsqlTypes.NpgsqlPoint(x: 0.8579022045298512d, y: 0.8151390002046379d), new NpgsqlTypes.NpgsqlPoint(x: 0.7836180321888631d, y: 0.11752336771418948d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5208276129918278d, y: 0.07962681659387527d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028705502142618d, y: 0.8516367099691597d), new NpgsqlTypes.NpgsqlPoint(x: 0.38880254280500737d, y: 0.7146457280917505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9719243514565507d, y: 0.2661417265500783d), new NpgsqlTypes.NpgsqlPoint(x: 0.46420692558970633d, y: 0.7615869487580956d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417637588643839d, y: 0.9171620704648559d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5804481692914809d, y: 0.7839980370778478d), new NpgsqlTypes.NpgsqlPoint(x: 0.057969602555754896d, y: 0.2965467362549623d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540101170575407d, y: 0.07985641719886105d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4872546460200978d, y: 0.9621761667283575d), new NpgsqlTypes.NpgsqlPoint(x: 0.6512729496762282d, y: 0.6476046499646881d), new NpgsqlTypes.NpgsqlPoint(x: 0.3397660963635777d, y: 0.7465896847456492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46831721369067736d, y: 0.631241659973083d), new NpgsqlTypes.NpgsqlPoint(x: 0.7249935730214322d, y: 0.20966213113770615d), new NpgsqlTypes.NpgsqlPoint(x: 0.005052495412891322d, y: 0.09084310291744924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3099759298415673d, y: 0.8720056810203474d), new NpgsqlTypes.NpgsqlPoint(x: 0.017852973430321217d, y: 0.7277809691150839d), new NpgsqlTypes.NpgsqlPoint(x: 0.258753341656649d, y: 0.5598774963244733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01692499324502794d, y: 0.6626837815513995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9573849737824218d, y: 0.10782009158165062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5347737836144992d, y: 0.56954385259521d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43830914797177045d, y: 0.863937874804586d), new NpgsqlTypes.NpgsqlPoint(x: 0.1133991529650723d, y: 0.5596930937955907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784896566156303d, y: 0.5340277348308303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9892276314936773d, y: 0.37231604867646895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6368340147026466d, y: 0.13764182575995554d), new NpgsqlTypes.NpgsqlPoint(x: 0.305782350248995d, y: 0.7677342977210899d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44307098441291604d, y: 0.029297451486553827d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255621936575992d, y: 0.7611482059399826d), new NpgsqlTypes.NpgsqlPoint(x: 0.1563342632995386d, y: 0.6345826682892379d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34903142044857105d, y: 0.6453912744249913d), new NpgsqlTypes.NpgsqlPoint(x: 0.8473925431254035d, y: 0.9978246789736036d), new NpgsqlTypes.NpgsqlPoint(x: 0.15008929667265503d, y: 0.6458244451371445d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36883412469494214d, y: 0.8782741618786386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218823638078151d, y: 0.07302805478038721d), new NpgsqlTypes.NpgsqlPoint(x: 0.5203699488344229d, y: 0.45243278492495376d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47496321829479127d, y: 0.7342762802074605d), new NpgsqlTypes.NpgsqlPoint(x: 0.021834776783491328d, y: 0.6432533442711572d), new NpgsqlTypes.NpgsqlPoint(x: 0.20413388296620982d, y: 0.8374283490142637d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3361180184094982d, y: 0.4821457695756588d), new NpgsqlTypes.NpgsqlPoint(x: 0.36480581079180685d, y: 0.5463105884944486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8145618555335671d, y: 0.4401668014263066d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3016971238825663d, y: 0.5416654533602847d), new NpgsqlTypes.NpgsqlPoint(x: 0.22748759721619016d, y: 0.011538847557322929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8239156528916769d, y: 0.5965126333202235d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8023822484252712d, y: 0.2102763442537131d), new NpgsqlTypes.NpgsqlPoint(x: 0.44028419549828424d, y: 0.6644422320418831d), new NpgsqlTypes.NpgsqlPoint(x: 0.13259075573951284d, y: 0.4122131310379912d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7487468904239568d, y: 0.010870997990106046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6019292029729498d, y: 0.12770242888626793d), new NpgsqlTypes.NpgsqlPoint(x: 0.03969592928987675d, y: 0.11750349302815244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5692929709762452d, y: 0.1770972238692088d), new NpgsqlTypes.NpgsqlPoint(x: 0.4582075791448329d, y: 0.2789065534230212d), new NpgsqlTypes.NpgsqlPoint(x: 0.005757129667284033d, y: 0.9977839597520438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7575613712527789d, y: 0.5637385579429939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499246054637785d, y: 0.5284609346378981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5796927732965905d, y: 0.4858783105365436d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8322422206963459d, y: 0.27642540964738704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231457349240093d, y: 0.7173473993525608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9653256040328126d, y: 0.5899487540295505d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9334875523979288d, y: 0.8515966838855901d), new NpgsqlTypes.NpgsqlPoint(x: 0.49450404301749507d, y: 0.17599557882293237d), new NpgsqlTypes.NpgsqlPoint(x: 0.3996019757088921d, y: 0.19180085634633948d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9006960633367725d, y: 0.7969484106507978d), new NpgsqlTypes.NpgsqlPoint(x: 0.10289481525274546d, y: 0.53618683495859d), new NpgsqlTypes.NpgsqlPoint(x: 0.15935092809464246d, y: 0.05955545836514309d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.708214872629276d, y: 0.21339970475883685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4592432051906654d, y: 0.8576406893400027d), new NpgsqlTypes.NpgsqlPoint(x: 0.4934811056078998d, y: 0.08878898267529534d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17436058400373777d, y: 0.1599763094134239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094816119758198d, y: 0.27737527637117787d), new NpgsqlTypes.NpgsqlPoint(x: 0.17944797843701643d, y: 0.9372690198736221d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20993770726157424d, y: 0.18999066363261075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9507624669359174d, y: 0.07414228993221106d), new NpgsqlTypes.NpgsqlPoint(x: 0.32549595871420955d, y: 0.6369598959470268d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47998367659740193d, y: 0.8168171410435532d), new NpgsqlTypes.NpgsqlPoint(x: 0.14760723287620514d, y: 0.2213857357855833d), new NpgsqlTypes.NpgsqlPoint(x: 0.1217868418856134d, y: 0.04657312074702413d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9572284230083006d, y: 0.08423132571189773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6872714292774634d, y: 0.572324172360875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314588997722918d, y: 0.925232875234896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6338337322570103d, y: 0.1393226598735039d), new NpgsqlTypes.NpgsqlPoint(x: 0.5670375162761473d, y: 0.9686068294658989d), new NpgsqlTypes.NpgsqlPoint(x: 0.04747989308222744d, y: 0.1236295566185287d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33911763670724837d, y: 0.9265660738160633d), new NpgsqlTypes.NpgsqlPoint(x: 0.17761119112355905d, y: 0.32156074282525393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175042933725383d, y: 0.5365334173040784d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5609104393752722d, y: 0.3375512245904717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5496999205779888d, y: 0.06674025162990349d), new NpgsqlTypes.NpgsqlPoint(x: 0.34288617509654273d, y: 0.09047427091963134d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.020625019512665155d, y: 0.9487360250770415d), new NpgsqlTypes.NpgsqlPoint(x: 0.7201158328914624d, y: 0.5887924545236605d), new NpgsqlTypes.NpgsqlPoint(x: 0.639121074233158d, y: 0.21569053044829656d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3304930494695195d, y: 0.5917993046981463d), new NpgsqlTypes.NpgsqlPoint(x: 0.15415370414497176d, y: 0.09285051852453963d), new NpgsqlTypes.NpgsqlPoint(x: 0.09805790419120408d, y: 0.7941027474824212d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9905864257439703d, y: 0.6335026443658619d), new NpgsqlTypes.NpgsqlPoint(x: 0.659713425338294d, y: 0.2195855548934741d), new NpgsqlTypes.NpgsqlPoint(x: 0.60731255586855d, y: 0.17935510011816447d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9669702155226171d, y: 0.12198578669345117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3413066223404996d, y: 0.9325966421082766d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896824751272107d, y: 0.14898648480030163d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7589677424273015d, y: 0.7863518613730932d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384827329202688d, y: 0.7848373185824287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2618994111112991d, y: 0.052686008584154065d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8045628833014189d, y: 0.8230836539043674d), new NpgsqlTypes.NpgsqlPoint(x: 0.0641593203355788d, y: 0.07010311437282224d), new NpgsqlTypes.NpgsqlPoint(x: 0.0355682003857799d, y: 0.6965260346631283d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7527717334938868d, y: 0.9270211412747538d), new NpgsqlTypes.NpgsqlPoint(x: 0.15098159438537273d, y: 0.8640853203164084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6347636126337771d, y: 0.64764481277495d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9968433161768032d, y: 0.9027867961891711d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931914561909191d, y: 0.9371471951965011d), new NpgsqlTypes.NpgsqlPoint(x: 0.1138102214148119d, y: 0.005197713641971635d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.962186327732852d, y: 0.49955255424191614d), new NpgsqlTypes.NpgsqlPoint(x: 0.44819288902544774d, y: 0.4576265999353205d), new NpgsqlTypes.NpgsqlPoint(x: 0.7118186939221809d, y: 0.8056671400095479d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16318132513999284d, y: 0.6238089188853604d), new NpgsqlTypes.NpgsqlPoint(x: 0.6348808536001199d, y: 0.507015263880342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5373027125644715d, y: 0.09479991544128663d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.027407996576238602d, y: 0.04218795006248577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5677381195779926d, y: 0.4388437880970739d), new NpgsqlTypes.NpgsqlPoint(x: 0.675290137553763d, y: 0.8559790385897844d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592499931040079d, y: 0.13269433780488138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8811109433629445d, y: 0.9847658359748297d), new NpgsqlTypes.NpgsqlPoint(x: 0.35144298647706185d, y: 0.20020225439713135d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32326406871036606d, y: 0.6351493098430897d), new NpgsqlTypes.NpgsqlPoint(x: 0.9087113534821086d, y: 0.763971404073062d), new NpgsqlTypes.NpgsqlPoint(x: 0.5783838236105686d, y: 0.5029297327449699d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29135131183481444d, y: 0.6920500374880564d), new NpgsqlTypes.NpgsqlPoint(x: 0.15192797617122145d, y: 0.5871674001449839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853855822486096d, y: 0.9276318582330754d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7805178865012316d, y: 0.9927826178294152d), new NpgsqlTypes.NpgsqlPoint(x: 0.014464580576906028d, y: 0.07109055157104638d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793920946505093d, y: 0.448653314407945d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6401113675501225d, y: 0.4148989281714117d), new NpgsqlTypes.NpgsqlPoint(x: 0.5594306088537406d, y: 0.711669199830496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460175974567842d, y: 0.8850514629476165d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33213846769718214d, y: 0.5381872014108037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292640775558641d, y: 0.8259175631700313d), new NpgsqlTypes.NpgsqlPoint(x: 0.8921950041905811d, y: 0.9969071068162142d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.877558910093322d, y: 0.8601759396871578d), new NpgsqlTypes.NpgsqlPoint(x: 0.8994390508921146d, y: 0.710001434764622d), new NpgsqlTypes.NpgsqlPoint(x: 0.20825245994533004d, y: 0.46322318924802675d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09782133807076776d, y: 0.14429637909723847d), new NpgsqlTypes.NpgsqlPoint(x: 0.3600537076117565d, y: 0.059603061546080416d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069907085876982d, y: 0.21088542751407735d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06799393969355672d, y: 0.5399065771395652d), new NpgsqlTypes.NpgsqlPoint(x: 0.08922379398984182d, y: 0.03315722280902422d), new NpgsqlTypes.NpgsqlPoint(x: 0.3694335771402554d, y: 0.7395907327081658d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7471610817770479d, y: 0.9868191724816181d), new NpgsqlTypes.NpgsqlPoint(x: 0.49350085906725616d, y: 0.7705967422615421d), new NpgsqlTypes.NpgsqlPoint(x: 0.7180139340549695d, y: 0.577305652746483d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03277887896600162d, y: 0.8738812059570044d), new NpgsqlTypes.NpgsqlPoint(x: 0.8241469790015384d, y: 0.47627274482632276d), new NpgsqlTypes.NpgsqlPoint(x: 0.45234398106044016d, y: 0.9899084043352322d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3122207484873468d, y: 0.9496225444952113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567940364055633d, y: 0.7882337728691073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850630574860753d, y: 0.730674339472861d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6048509187583764d, y: 0.6191541902792709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766447790554443d, y: 0.4786547651465193d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481113925053885d, y: 0.9022987409885461d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6616650835151779d, y: 0.6534063955094751d), new NpgsqlTypes.NpgsqlPoint(x: 0.6896052590279566d, y: 0.0831932932056414d), new NpgsqlTypes.NpgsqlPoint(x: 0.3980719041968115d, y: 0.4274405523171104d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3176797419664641d, y: 0.03377122949946554d), new NpgsqlTypes.NpgsqlPoint(x: 0.38648580513354636d, y: 0.45320410248007104d), new NpgsqlTypes.NpgsqlPoint(x: 0.13330990116097674d, y: 0.8744593504333543d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.65285129325479d, y: 0.7049406440688747d), new NpgsqlTypes.NpgsqlPoint(x: 0.39587669190291264d, y: 0.7531167025480948d), new NpgsqlTypes.NpgsqlPoint(x: 0.42346153534027553d, y: 0.5199308697534919d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6305112250798913d, y: 0.39160715149969094d), new NpgsqlTypes.NpgsqlPoint(x: 0.1737185336100302d, y: 0.6648073717631822d), new NpgsqlTypes.NpgsqlPoint(x: 0.3579143853440434d, y: 0.5311422714827544d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40892313450024265d, y: 0.8041531391690471d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730299956295767d, y: 0.7158484478642829d), new NpgsqlTypes.NpgsqlPoint(x: 0.2631037059055138d, y: 0.8929050635490113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2389130138412695d, y: 0.47237690839279334d), new NpgsqlTypes.NpgsqlPoint(x: 0.8283487515436003d, y: 0.8736212952120528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572954141791826d, y: 0.8871207060339044d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9600945432948933d, y: 0.787230280477495d), new NpgsqlTypes.NpgsqlPoint(x: 0.06981378619709822d, y: 0.5794300347565747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677401045015145d, y: 0.2717073053124228d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.515425841088439d, y: 0.8347156397664467d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947725435972572d, y: 0.8355478930736762d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598712582830846d, y: 0.07130957530206883d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21992663690986858d, y: 0.3819183664768451d), new NpgsqlTypes.NpgsqlPoint(x: 0.30085085429185987d, y: 0.3802817009899593d), new NpgsqlTypes.NpgsqlPoint(x: 0.888585216333202d, y: 0.8709067874311647d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29416489521056066d, y: 0.024484255200716287d), new NpgsqlTypes.NpgsqlPoint(x: 0.689521579569115d, y: 0.16704349926906636d), new NpgsqlTypes.NpgsqlPoint(x: 0.1201855675191863d, y: 0.2933509270926231d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21159749868726163d, y: 0.8955695808329704d), new NpgsqlTypes.NpgsqlPoint(x: 0.4575687650648125d, y: 0.7225726602879599d), new NpgsqlTypes.NpgsqlPoint(x: 0.6748054900000044d, y: 0.30605940712839075d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3559678674487916d, y: 0.09867235986457479d), new NpgsqlTypes.NpgsqlPoint(x: 0.9182362756948823d, y: 0.34046803593103603d), new NpgsqlTypes.NpgsqlPoint(x: 0.15272966451517744d, y: 0.7906432787960219d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4066742443354421d, y: 0.7007141634218517d), new NpgsqlTypes.NpgsqlPoint(x: 0.08681781924801191d, y: 0.465155401664894d), new NpgsqlTypes.NpgsqlPoint(x: 0.09083699750083196d, y: 0.7166826172003001d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5425211086150264d, y: 0.15903182392509596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735680939803738d, y: 0.6151645487817227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582444644476622d, y: 0.5308714220883113d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4960096847929597d, y: 0.4105194600717532d), new NpgsqlTypes.NpgsqlPoint(x: 0.08478364590465559d, y: 0.6543176205206812d), new NpgsqlTypes.NpgsqlPoint(x: 0.08599392474946543d, y: 0.11192236406711564d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30885239309482315d, y: 0.13604610203400824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9887259996369967d, y: 0.6256552745353118d), new NpgsqlTypes.NpgsqlPoint(x: 0.2765876605041435d, y: 0.586091000579166d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7764994988632159d, y: 0.8048643249648454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6978005164952272d, y: 0.07120352763481652d), new NpgsqlTypes.NpgsqlPoint(x: 0.7116699869980889d, y: 0.5587720974435083d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03280477978632057d, y: 0.4123787645064314d), new NpgsqlTypes.NpgsqlPoint(x: 0.09783667772594196d, y: 0.7275302299270636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8651340912740972d, y: 0.5930658082958798d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5291901801880142d, y: 0.02155380682727881d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514104156057098d, y: 0.15316838402347643d), new NpgsqlTypes.NpgsqlPoint(x: 0.276522647332647d, y: 0.8752184850508494d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9884981669141891d, y: 0.09171621487604398d), new NpgsqlTypes.NpgsqlPoint(x: 0.49179413565380703d, y: 0.7600295568112236d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557855343445303d, y: 0.3811120675811075d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9831688364917596d, y: 0.12250571149069112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520644059736654d, y: 0.05325729470816942d), new NpgsqlTypes.NpgsqlPoint(x: 0.14494418862645686d, y: 0.9524995607675428d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4449693112151051d, y: 0.5695153078023955d), new NpgsqlTypes.NpgsqlPoint(x: 0.3955040814061519d, y: 0.8902424628377463d), new NpgsqlTypes.NpgsqlPoint(x: 0.17021350028712123d, y: 0.9637410701321094d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3704151840694069d, y: 0.8776251723018844d), new NpgsqlTypes.NpgsqlPoint(x: 0.14124062001965443d, y: 0.6300247465564782d), new NpgsqlTypes.NpgsqlPoint(x: 0.22636726929987483d, y: 0.5300642628022048d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 141,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7772788503824349d, y: 0.5166796427463733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115691336952522d, y: 0.013917303798991476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382802286196857d, y: 0.6712394068731187d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6230460476292422d, y: 0.3572335997669833d), new NpgsqlTypes.NpgsqlPoint(x: 0.19989124113417467d, y: 0.8190291734443716d), new NpgsqlTypes.NpgsqlPoint(x: 0.15782734622926742d, y: 0.9367701926527229d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3412223569873739d, y: 0.6777673097557371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891345618492572d, y: 0.03435058592344464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8774990114791187d, y: 0.31628492975754896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6761669781551892d, y: 0.7664421509334094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8477720137917778d, y: 0.40922097730334384d), new NpgsqlTypes.NpgsqlPoint(x: 0.9110801308812551d, y: 0.5646567474589406d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5084654317146d, y: 0.22177726604878611d), new NpgsqlTypes.NpgsqlPoint(x: 0.32342222990642067d, y: 0.6916147526751089d), new NpgsqlTypes.NpgsqlPoint(x: 0.21861763585807958d, y: 0.6326109652352022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12350184841100875d, y: 0.9223740061853577d), new NpgsqlTypes.NpgsqlPoint(x: 0.39706275603195795d, y: 0.2903039747874475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605403244392588d, y: 0.22070288869546484d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022529751351893945d, y: 0.38049791187939375d), new NpgsqlTypes.NpgsqlPoint(x: 0.17659625043285143d, y: 0.4355689507401298d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251918551700898d, y: 0.08658272864951533d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9128280800511874d, y: 0.3994228279668435d), new NpgsqlTypes.NpgsqlPoint(x: 0.8028069442332664d, y: 0.9885693233673924d), new NpgsqlTypes.NpgsqlPoint(x: 0.01500099910131103d, y: 0.0928508521096828d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18367028058551227d, y: 0.38621150526432924d), new NpgsqlTypes.NpgsqlPoint(x: 0.4855504748236471d, y: 0.8456470287014501d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075533789275092d, y: 0.24121740427338256d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008076415655062008d, y: 0.7744566539213685d), new NpgsqlTypes.NpgsqlPoint(x: 0.713963355384925d, y: 0.3022684707620381d), new NpgsqlTypes.NpgsqlPoint(x: 0.13436765190218258d, y: 0.14803005123051982d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7236803652850983d, y: 0.14700594889085083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6561291500554213d, y: 0.7834630614895796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6223257012272218d, y: 0.7430045841464936d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4215935848979484d, y: 0.5394946451004778d), new NpgsqlTypes.NpgsqlPoint(x: 0.1578547558414728d, y: 0.8368968881417633d), new NpgsqlTypes.NpgsqlPoint(x: 0.34758801692645414d, y: 0.782566111765608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4394330544677497d, y: 0.09174473896257151d), new NpgsqlTypes.NpgsqlPoint(x: 0.2729758576030563d, y: 0.8131073347653546d), new NpgsqlTypes.NpgsqlPoint(x: 0.23104276051804895d, y: 0.540116718587329d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4792579997808085d, y: 0.14989276683890806d), new NpgsqlTypes.NpgsqlPoint(x: 0.46461038993729675d, y: 0.47717893161197256d), new NpgsqlTypes.NpgsqlPoint(x: 0.6578497264669291d, y: 0.7669627875117181d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19039186230299476d, y: 0.0011934854938042694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8345718309599672d, y: 0.589338971377068d), new NpgsqlTypes.NpgsqlPoint(x: 0.71029156638394d, y: 0.3231432895508185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6550651770985784d, y: 0.2784708530457236d), new NpgsqlTypes.NpgsqlPoint(x: 0.688815351209489d, y: 0.2647752120280682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5608562105346463d, y: 0.809626592534133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42722622358377427d, y: 0.42866256764406807d), new NpgsqlTypes.NpgsqlPoint(x: 0.46921527190187706d, y: 0.9646272481538364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806115540810589d, y: 0.6219437160093579d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5781393984946691d, y: 0.025824008933130416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302224410828655d, y: 0.5937443374443696d), new NpgsqlTypes.NpgsqlPoint(x: 0.4063349232130875d, y: 0.29907570218774837d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1780616126506135d, y: 0.524221913152171d), new NpgsqlTypes.NpgsqlPoint(x: 0.5747152642219717d, y: 0.522412174123661d), new NpgsqlTypes.NpgsqlPoint(x: 0.053264242755690194d, y: 0.05669983477744356d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7979812054834863d, y: 0.501664174239261d), new NpgsqlTypes.NpgsqlPoint(x: 0.8056023160181948d, y: 0.14454117192369975d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359182079517646d, y: 0.7390652712416337d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7107503149828932d, y: 0.8665605734636126d), new NpgsqlTypes.NpgsqlPoint(x: 0.8285103604502543d, y: 0.6706913214011228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051529060300721d, y: 0.2911014905074203d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 161,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5343642809001545d, y: 0.0799218102389283d), new NpgsqlTypes.NpgsqlPoint(x: 0.21133504479335818d, y: 0.8361893907817376d), new NpgsqlTypes.NpgsqlPoint(x: 0.45353345552898505d, y: 0.9276652948653719d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8109339300733942d, y: 0.8378869399188288d), new NpgsqlTypes.NpgsqlPoint(x: 0.18622091053958345d, y: 0.7346112312795403d), new NpgsqlTypes.NpgsqlPoint(x: 0.06594423143428207d, y: 0.5328840844089214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7797423773740885d, y: 0.43802205775649095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2993633555041667d, y: 0.8347048814048181d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096950604407618d, y: 0.5220153478531501d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00480228779952685d, y: 0.841202577971222d), new NpgsqlTypes.NpgsqlPoint(x: 0.42296294196203355d, y: 0.7511120757845261d), new NpgsqlTypes.NpgsqlPoint(x: 0.690213014786804d, y: 0.012845246729513038d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3162164655034645d, y: 0.3933958739191643d), new NpgsqlTypes.NpgsqlPoint(x: 0.512836240961774d, y: 0.23942189927674973d), new NpgsqlTypes.NpgsqlPoint(x: 0.24021926311718333d, y: 0.22393161933261507d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01544196935320541d, y: 0.9295096988739917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476625285447055d, y: 0.7372993338677878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8387472708473853d, y: 0.7257850292312297d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3938690529672745d, y: 0.10212148509933794d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034529214438952d, y: 0.5093294250042656d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133326553494084d, y: 0.8266256092313089d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4547182818161353d, y: 0.519987098303864d), new NpgsqlTypes.NpgsqlPoint(x: 0.05509666380371092d, y: 0.9956286959826489d), new NpgsqlTypes.NpgsqlPoint(x: 0.043843682153040464d, y: 0.4592133344930167d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6134685693508176d, y: 0.39957390201162635d), new NpgsqlTypes.NpgsqlPoint(x: 0.650698433121583d, y: 0.21619426255945318d), new NpgsqlTypes.NpgsqlPoint(x: 0.005423754734375286d, y: 0.9348629522821662d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8229790028671894d, y: 0.22069760447740128d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442514194875669d, y: 0.6900574025588146d), new NpgsqlTypes.NpgsqlPoint(x: 0.14244574878835725d, y: 0.924541603893651d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.887866173886694d, y: 0.50285522498052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7959875635853424d, y: 0.4665958417307179d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114082031284898d, y: 0.5842034631249843d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27542463454353094d, y: 0.20757980977705215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6407692104012671d, y: 0.41234828847968064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5758869852362726d, y: 0.28781071144743464d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7319494503163845d, y: 0.7308285637292512d), new NpgsqlTypes.NpgsqlPoint(x: 0.08396534008097545d, y: 0.7822395242199064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316490105928816d, y: 0.4305513482053409d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8096017996181405d, y: 0.10251630336485718d), new NpgsqlTypes.NpgsqlPoint(x: 0.4182112764483019d, y: 0.7168305398435174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962064473081144d, y: 0.22534013432456734d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8276275299967709d, y: 0.3489821947704218d), new NpgsqlTypes.NpgsqlPoint(x: 0.09418890205509978d, y: 0.10791049496285587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581506067169644d, y: 0.0195492308898898d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6506863906970535d, y: 0.3877208101574364d), new NpgsqlTypes.NpgsqlPoint(x: 0.6252724348475547d, y: 0.976091590281028d), new NpgsqlTypes.NpgsqlPoint(x: 0.3699454031315518d, y: 0.03391205718389678d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8117073318464512d, y: 0.6980537281252447d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060093314841495d, y: 0.5146692933466902d), new NpgsqlTypes.NpgsqlPoint(x: 0.49602770778714633d, y: 0.2383608599161937d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.462181963411469d, y: 0.400462431348968d), new NpgsqlTypes.NpgsqlPoint(x: 0.017222519157498395d, y: 0.03344875027523708d), new NpgsqlTypes.NpgsqlPoint(x: 0.866931748591544d, y: 0.43714673599879117d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36393800374134344d, y: 0.9085301781040137d), new NpgsqlTypes.NpgsqlPoint(x: 0.20797793570457568d, y: 0.3332625487652009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7642577977412772d, y: 0.7211721159385861d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10257848330472463d, y: 0.14553682645011767d), new NpgsqlTypes.NpgsqlPoint(x: 0.5284867770731837d, y: 0.41810861545375955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9740530801675388d, y: 0.768225219042347d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033487347166660686d, y: 0.46112820880848604d), new NpgsqlTypes.NpgsqlPoint(x: 0.12892954630235132d, y: 0.732695773679256d), new NpgsqlTypes.NpgsqlPoint(x: 0.09182274936879986d, y: 0.8470169716778223d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9932238236278204d, y: 0.3864123715220059d), new NpgsqlTypes.NpgsqlPoint(x: 0.4235874962685656d, y: 0.7441983453345005d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792843391337016d, y: 0.2734976213447987d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 178,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.93438969023188d, y: 0.3769326751533668d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335925047477799d, y: 0.44773713078940836d), new NpgsqlTypes.NpgsqlPoint(x: 0.313773684958368d, y: 0.851898698793348d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3577840563529565d, y: 0.36844374482333264d), new NpgsqlTypes.NpgsqlPoint(x: 0.2774020714370242d, y: 0.6539631584750119d), new NpgsqlTypes.NpgsqlPoint(x: 0.5353279137180098d, y: 0.23070393639128772d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9230720197168545d, y: 0.2791218028640887d), new NpgsqlTypes.NpgsqlPoint(x: 0.725870552599052d, y: 0.9690033448299606d), new NpgsqlTypes.NpgsqlPoint(x: 0.32760288772515167d, y: 0.20705800591092494d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21728985952779312d, y: 0.22838867281401587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688588747480801d, y: 0.08895361083418318d), new NpgsqlTypes.NpgsqlPoint(x: 0.3310732621342608d, y: 0.3805005125228581d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.601572230464979d, y: 0.8342811767343294d), new NpgsqlTypes.NpgsqlPoint(x: 0.09067803915289796d, y: 0.32328160731750655d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735633910886614d, y: 0.5907280185422435d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.037574239871474235d, y: 0.7125420253049223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7218733400675517d, y: 0.785743269928536d), new NpgsqlTypes.NpgsqlPoint(x: 0.9619514590229609d, y: 0.20916613422628438d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24245824879890243d, y: 0.9640724561482936d), new NpgsqlTypes.NpgsqlPoint(x: 0.15794282873890408d, y: 0.824830452199091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8780743084160655d, y: 0.11622780287398271d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5978282377947429d, y: 0.8233920427477027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141805353074687d, y: 0.8728834486818735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903309986139725d, y: 0.9055230103043357d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5946917046251697d, y: 0.6845113251268411d), new NpgsqlTypes.NpgsqlPoint(x: 0.283479959875095d, y: 0.6804155574697596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6724640525111232d, y: 0.5547897639116244d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22615220185037777d, y: 0.5988515551217929d), new NpgsqlTypes.NpgsqlPoint(x: 0.26276160120811554d, y: 0.13245875395710482d), new NpgsqlTypes.NpgsqlPoint(x: 0.6205810255537534d, y: 0.6486774558660181d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 186,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.814861974890964d, y: 0.9389192835598404d), new NpgsqlTypes.NpgsqlPoint(x: 0.07568553106122922d, y: 0.7775283774939201d), new NpgsqlTypes.NpgsqlPoint(x: 0.39448659739480296d, y: 0.7859239305706879d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49607593728316746d, y: 0.3796894684382883d), new NpgsqlTypes.NpgsqlPoint(x: 0.02643298565094465d, y: 0.08195880341507444d), new NpgsqlTypes.NpgsqlPoint(x: 0.31854166503018777d, y: 0.2160947903300069d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7713246329036384d, y: 0.15559546501542998d), new NpgsqlTypes.NpgsqlPoint(x: 0.3042764394922589d, y: 0.6752284849148188d), new NpgsqlTypes.NpgsqlPoint(x: 0.9638972978548392d, y: 0.9681687868922583d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7156256911274436d, y: 0.770921204204452d), new NpgsqlTypes.NpgsqlPoint(x: 0.6068103159793142d, y: 0.9078511457581854d), new NpgsqlTypes.NpgsqlPoint(x: 0.37984605737259636d, y: 0.47445459849926164d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5806154214879884d, y: 0.09241746123236827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761810427934092d, y: 0.8503200577257561d), new NpgsqlTypes.NpgsqlPoint(x: 0.2750378815179756d, y: 0.8298257588159951d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2749187967518548d, y: 0.6869872319717341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5138994891667937d, y: 0.7550512326065062d), new NpgsqlTypes.NpgsqlPoint(x: 0.09690299871245367d, y: 0.7401150236391412d)),

},
},
            new NpgsqlPathpathArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9046450336420735d, y: 0.13252511815533752d), new NpgsqlTypes.NpgsqlPoint(x: 0.3525006079141113d, y: 0.8352557310611259d), new NpgsqlTypes.NpgsqlPoint(x: 0.9242992589752898d, y: 0.14056070611662896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2673767692714901d, y: 0.6133316007076803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5329380519669514d, y: 0.44263958044045915d), new NpgsqlTypes.NpgsqlPoint(x: 0.23289663004527728d, y: 0.9745345193183546d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.182612063429878d, y: 0.11446040893291387d), new NpgsqlTypes.NpgsqlPoint(x: 0.5841049182541245d, y: 0.4431627474389551d), new NpgsqlTypes.NpgsqlPoint(x: 0.910153036859373d, y: 0.23463114501371263d)),

},
    ModelInner = new NpgsqlPathpathArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6247541662848762d, y: 0.37974676774824745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457142492639079d, y: 0.8705695220765204d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617448914771351d, y: 0.6699219793066509d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18080600667965985d, y: 0.04606354132913948d), new NpgsqlTypes.NpgsqlPoint(x: 0.06064957195799403d, y: 0.5947554473456025d), new NpgsqlTypes.NpgsqlPoint(x: 0.7580854291173963d, y: 0.6089928953747996d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9457360330764258d, y: 0.9586117252054474d), new NpgsqlTypes.NpgsqlPoint(x: 0.010173853165690527d, y: 0.9783799035812576d), new NpgsqlTypes.NpgsqlPoint(x: 0.7408253713826964d, y: 0.48902457888093576d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3766539141600763d, y: 0.7983673948593569d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183296319790196d, y: 0.7492325363214889d), new NpgsqlTypes.NpgsqlPoint(x: 0.3501538374900437d, y: 0.9401716881206791d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1705254573920958d, y: 0.9603999251340668d), new NpgsqlTypes.NpgsqlPoint(x: 0.8284264825928077d, y: 0.9065350768473389d), new NpgsqlTypes.NpgsqlPoint(x: 0.8132065189999014d, y: 0.305776711277275d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02537984126677395d, y: 0.5599131781370998d), new NpgsqlTypes.NpgsqlPoint(x: 0.20298925040559412d, y: 0.9948877142999585d), new NpgsqlTypes.NpgsqlPoint(x: 0.008864952874128806d, y: 0.0821592045461238d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8244046741210733d, y: 0.7843326611113011d), new NpgsqlTypes.NpgsqlPoint(x: 0.8031955898777228d, y: 0.985328065471015d), new NpgsqlTypes.NpgsqlPoint(x: 0.12691218806522275d, y: 0.8089966380581326d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4643155485913014d, y: 0.1791606131202561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7219467578560363d, y: 0.6790417704860623d), new NpgsqlTypes.NpgsqlPoint(x: 0.4798711086639358d, y: 0.7791874935089645d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1831346455190459d, y: 0.3910893292622919d), new NpgsqlTypes.NpgsqlPoint(x: 0.525465667248858d, y: 0.3206681884450229d), new NpgsqlTypes.NpgsqlPoint(x: 0.30371926092838486d, y: 0.9718032256497696d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09162642836177592d, y: 0.27503587726521217d), new NpgsqlTypes.NpgsqlPoint(x: 0.2648144652962735d, y: 0.3279540377485145d), new NpgsqlTypes.NpgsqlPoint(x: 0.11800600185123267d, y: 0.9609947461256522d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5422786799746588d, y: 0.09596185766825649d), new NpgsqlTypes.NpgsqlPoint(x: 0.48795166813411195d, y: 0.9435251146010012d), new NpgsqlTypes.NpgsqlPoint(x: 0.9938098189615022d, y: 0.1608294781747197d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7504081024168635d, y: 0.24197694123736002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8664748785787648d, y: 0.5157914288087772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7163856381059105d, y: 0.4197560643658389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7891424825154697d, y: 0.7524414246164665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7389340746841259d, y: 0.9892378022322665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6580361947762188d, y: 0.7620027933327608d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0880740397831189d, y: 0.6029593027957202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5132880179114522d, y: 0.28828714885098106d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279940804222331d, y: 0.3924269004418631d)),

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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
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
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[34], false);
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
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 29;
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                parametr1.Value = 134;
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
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 58;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
                parametr1.Value = 134;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 174;
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[34], false);
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
                parametr1.Value = 18;
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
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[34], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[34], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 186;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                await ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 18, query1, 130, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
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
                 ((INpgsqlPathListpathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 37, query1, 105, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[28],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 141, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 129, query1, 101, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[17],_testData[34], false);
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
                await ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 4, query1, 134, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 134, query1, 122, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPathpathArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(models[12],_testData[34], false);
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
                 ((INpgsqlPathListpathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 105, query1, 65, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPathpathArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 29, 98))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                foreach(var batchResult in  ((INpgsqlPathListpathArray)this).DbConnectionSTSelectModelBatch(connection, 65, 29))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPathpathArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPathpathArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPathpathArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPathpathArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPathpathArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPathpathArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPathpathArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPathpathArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPathpathArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPathpathArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPathpathArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPathpathArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPathpathArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPathpathArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPathpathArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPathpathArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPathpathArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPathpathArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPathpathArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPathpathArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPathpathArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPathpathArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPathpathArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPathpathArray2M.AssertModel(models[23],_testData[34], false);
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
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 29);
                var models = await ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(30));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[5], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[6], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[7], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[8], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[9], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[10], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[11], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[12], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[22],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[23],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[24],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[25],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[26],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[27],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[28],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathArray)this).SetDbConnectionSelectModelParametrs(cmd, 77);
                var models =  ((INpgsqlPathListpathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray2M.AssertModel(models[0],_testData[13], false);NpgsqlPathpathArray2M.AssertModel(models[1],_testData[14], false);NpgsqlPathpathArray2M.AssertModel(models[2],_testData[15], false);NpgsqlPathpathArray2M.AssertModel(models[3],_testData[16], false);NpgsqlPathpathArray2M.AssertModel(models[4],_testData[17], false);NpgsqlPathpathArray2M.AssertModel(models[5],_testData[18], false);NpgsqlPathpathArray2M.AssertModel(models[6],_testData[19], false);NpgsqlPathpathArray2M.AssertModel(models[7],_testData[20], false);NpgsqlPathpathArray2M.AssertModel(models[8],_testData[21], false);NpgsqlPathpathArray2M.AssertModel(models[9],_testData[22], false);NpgsqlPathpathArray2M.AssertModel(models[10],_testData[23], false);NpgsqlPathpathArray2M.AssertModel(models[11],_testData[24], false);NpgsqlPathpathArray2M.AssertModel(models[12],_testData[25], false);NpgsqlPathpathArray2M.AssertModel(models[13],_testData[26], false);NpgsqlPathpathArray2M.AssertModel(models[14],_testData[27], false);NpgsqlPathpathArray2M.AssertModel(models[15],_testData[28], false);NpgsqlPathpathArray2M.AssertModel(models[16],_testData[29], false);NpgsqlPathpathArray2M.AssertModel(models[17],_testData[30], false);NpgsqlPathpathArray2M.AssertModel(models[18],_testData[31], false);NpgsqlPathpathArray2M.AssertModel(models[19],_testData[32], false);NpgsqlPathpathArray2M.AssertModel(models[20],_testData[33], false);NpgsqlPathpathArray2M.AssertModel(models[21],_testData[34], false);
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

