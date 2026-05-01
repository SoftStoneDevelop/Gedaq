

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
    internal partial interface INpgsqlPointListpointArray
    {
    }
    
    internal partial class NpgsqlPointListpointArray : INpgsqlPointListpointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray2M[] _testData = new NpgsqlPointpointArray2M[]
        {
            new NpgsqlPointpointArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7375285233748873d, y: 0.7848693195884359d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7388939497863645d, y: 0.30867263139956846d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9237633558649802d, y: 0.28916054569326877d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10307442351135299d, y: 0.880773675469486d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7336896403619785d, y: 0.057768918804421476d),

new NpgsqlTypes.NpgsqlPoint(x: 0.020980975407683622d, y: 0.5896272808977806d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9370361694253369d, y: 0.4699991664302443d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8987712809663576d, y: 0.6080170152754909d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9097573828665655d, y: 0.20991671362410813d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8196176582764286d, y: 0.485466267867821d),

new NpgsqlTypes.NpgsqlPoint(x: 0.033919647364252015d, y: 0.9253164155948919d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.032037851097247105d, y: 0.7710426175686422d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027214289112852286d, y: 0.4620406327078326d),

new NpgsqlTypes.NpgsqlPoint(x: 0.37631470787326315d, y: 0.016902817576442408d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8878892244845903d, y: 0.9985772571184387d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08125418424769992d, y: 0.16648498037192527d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09483149884095843d, y: 0.1944575042288712d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11129526369294351d, y: 0.6437275190480816d),

new NpgsqlTypes.NpgsqlPoint(x: 0.30954258321128647d, y: 0.4990802189485315d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3883063144199067d, y: 0.33739890624394064d),

new NpgsqlTypes.NpgsqlPoint(x: 0.03167060128442145d, y: 0.9491291985001132d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.001221976188298446d, y: 0.5396516111336995d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9374436797345839d, y: 0.5082118567825933d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1941236268964105d, y: 0.7849200485085154d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7798403251960726d, y: 0.4495757827344564d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7450603397431793d, y: 0.8691884514464697d),

new NpgsqlTypes.NpgsqlPoint(x: 0.29306594018482846d, y: 0.24845446184865594d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5915926054806177d, y: 0.7745660826716793d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17243985064054834d, y: 0.4440385493383505d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27110488417195744d, y: 0.8147635214576028d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9612723620607841d, y: 0.10466080246829368d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9087947832847015d, y: 0.9228085120221973d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9295140153997241d, y: 0.8607167331727509d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6237790633167201d, y: 0.782266919965998d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07566261614842451d, y: 0.7541330603506107d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6034237199363753d, y: 0.25164976006556516d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15098297224701174d, y: 0.64534969051242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9139398893956923d, y: 0.19410455635661694d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14396497711978695d, y: 0.7791619390839898d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.798051505244873d, y: 0.4349377111222734d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6663821269772934d, y: 0.26000096668212513d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8578203674613204d, y: 0.5764601761133138d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9087996865869014d, y: 0.4180137546189926d),

new NpgsqlTypes.NpgsqlPoint(x: 0.779431453150352d, y: 0.8883680873209558d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7454399849001389d, y: 0.8883973921679587d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3590521918113503d, y: 0.8095464180071188d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.787295601375385d, y: 0.31793392383263974d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5733198831193621d, y: 0.7162859402733408d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7559843071851826d, y: 0.7284307909613316d),

new NpgsqlTypes.NpgsqlPoint(x: 0.39812650236198965d, y: 0.28533007698631696d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.271456490622232d, y: 0.5914775053181047d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6443172896157652d, y: 0.059301960640560814d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5280445631904609d, y: 0.3168249837095021d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6370752208709043d, y: 0.9067845543823113d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8492521432160134d, y: 0.32891059262469d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6522308244544456d, y: 0.48726090126259647d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10174523545622216d, y: 0.2619064997648253d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8827817848093631d, y: 0.7149682751971939d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016238272835160328d, y: 0.25824340968109905d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6577355661980323d, y: 0.4295246467135786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6223899204179542d, y: 0.06872259008063475d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.02968970671148885d, y: 0.9546368398156954d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6553461802233077d, y: 0.7431521726547812d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5690001928179902d, y: 0.18019524633337347d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6182331754134472d, y: 0.6093239350487369d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8425291835708489d, y: 0.06568317350632191d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09517170168579903d, y: 0.6351277819934658d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37905881282931486d, y: 0.7248662481620435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9971927447379649d, y: 0.7347738730750836d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9155970696461926d, y: 0.5050557712963724d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7834277652458856d, y: 0.7955302574090786d),

new NpgsqlTypes.NpgsqlPoint(x: 0.057369085246219864d, y: 0.0066714982367277464d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04382595819703494d, y: 0.466173058019722d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11685047716620034d, y: 0.3349354722176333d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.691773260409213d, y: 0.07091359201133707d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5967376095030528d, y: 0.7105610895268166d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8586429845954283d, y: 0.2334279128753306d),

new NpgsqlTypes.NpgsqlPoint(x: 0.82243669601791d, y: 0.9837377581917861d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.49156208067356744d, y: 0.9394610364751559d),

new NpgsqlTypes.NpgsqlPoint(x: 0.43651707522017513d, y: 0.3782984380051383d),

new NpgsqlTypes.NpgsqlPoint(x: 0.014018596334081646d, y: 0.4923985582247601d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5600409091173725d, y: 0.5599228237137216d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38582473996380917d, y: 0.752111482605081d),

new NpgsqlTypes.NpgsqlPoint(x: 0.27745393088194825d, y: 0.9313996299592417d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6758437101166471d, y: 0.6584610256860953d),

new NpgsqlTypes.NpgsqlPoint(x: 0.939772908605397d, y: 0.13681254090162598d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.575359963249918d, y: 0.3702445260676366d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3141476180664239d, y: 0.662531490836003d),

new NpgsqlTypes.NpgsqlPoint(x: 0.775460470943213d, y: 0.07224364361344515d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9908695467233548d, y: 0.5128676604730908d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.062438163896045396d, y: 0.840791042275247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.939178980120229d, y: 0.35636207664243635d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7233797659611726d, y: 0.8329201944106163d),

new NpgsqlTypes.NpgsqlPoint(x: 0.0007188097863011222d, y: 0.33320004025012784d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17268586130221075d, y: 0.4821720564673617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9660379993093393d, y: 0.2845240869949164d),

new NpgsqlTypes.NpgsqlPoint(x: 0.950328249365171d, y: 0.9012284056007247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5674792442607588d, y: 0.7601397388907618d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8725145154740113d, y: 0.008913997924327899d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6955641348742364d, y: 0.6654111260466867d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5059589623299672d, y: 0.05468474022225789d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9140309136467382d, y: 0.4809050529347063d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17047068423590328d, y: 0.1130280202402768d),

new NpgsqlTypes.NpgsqlPoint(x: 0.10648226990610121d, y: 0.27124146641940916d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6111855513897735d, y: 0.18129038002319242d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24147715104778278d, y: 0.10401597815678731d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8106143854246572d, y: 0.801543328412289d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06308327725472396d, y: 0.2912621917290106d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.63394571954992d, y: 0.6903175759262957d),

new NpgsqlTypes.NpgsqlPoint(x: 0.349848965153314d, y: 0.2700579479292403d),

new NpgsqlTypes.NpgsqlPoint(x: 0.41374671308024513d, y: 0.13575596929259415d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.25530086530255913d, y: 0.14560230268507013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1770211502148813d, y: 0.13659133333325912d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2167715768610493d, y: 0.5594215655737472d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14865844482651636d, y: 0.2136515741796886d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2313547305663628d, y: 0.7816981064227684d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23961860714265337d, y: 0.9291029181136188d),

new NpgsqlTypes.NpgsqlPoint(x: 0.495788911365983d, y: 0.3840679956496157d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7674731615385423d, y: 0.45044744585971463d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6140074356365582d, y: 0.15861618289727586d),

new NpgsqlTypes.NpgsqlPoint(x: 0.967745287738099d, y: 0.6034587197866721d),

new NpgsqlTypes.NpgsqlPoint(x: 0.995284854330224d, y: 0.45693521388847647d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6269659705695639d, y: 0.1807977153341932d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09526002981440307d, y: 0.48674140151400347d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8419540214044171d, y: 0.15619965907949063d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2399870515138216d, y: 0.009674756607129686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7770320860394775d, y: 0.7140064171486106d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6567582325450864d, y: 0.5688325014004563d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.34832433633491067d, y: 0.4026221938416381d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9333070108494165d, y: 0.2670308407406361d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8097656451876788d, y: 0.39871578987136247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08092799048480559d, y: 0.37900869867189935d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.19858049594353133d, y: 0.3390197153686324d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2511743875776511d, y: 0.8177307470462769d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9461859305769681d, y: 0.8748275249553489d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9688088560140351d, y: 0.18957950364664988d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8410092945386093d, y: 0.9784484246380039d),

new NpgsqlTypes.NpgsqlPoint(x: 0.24444804760613204d, y: 0.25025352020428093d),

new NpgsqlTypes.NpgsqlPoint(x: 0.31396852092503236d, y: 0.4440835973073892d),

new NpgsqlTypes.NpgsqlPoint(x: 0.15273671081726126d, y: 0.8271796482231192d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6225604655082397d, y: 0.8302335163039544d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3526304817917535d, y: 0.3262704626893276d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9686814743591199d, y: 0.06796331480916618d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6514567877306745d, y: 0.30632869443852206d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7139192746516845d, y: 0.49891053941715624d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2704797490871038d, y: 0.9255560718495004d),

new NpgsqlTypes.NpgsqlPoint(x: 0.016238533070473515d, y: 0.8654709311897931d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.08788632123845674d, y: 0.378818773362013d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32996887156592525d, y: 0.7395097437924738d),

new NpgsqlTypes.NpgsqlPoint(x: 0.832223027845214d, y: 0.6974658362435404d),

new NpgsqlTypes.NpgsqlPoint(x: 0.710254610851482d, y: 0.07286371464361818d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6675711731331067d, y: 0.8761248446561882d),

new NpgsqlTypes.NpgsqlPoint(x: 0.07249793816737127d, y: 0.9390258124749019d),

new NpgsqlTypes.NpgsqlPoint(x: 0.027472172162743447d, y: 0.7599706777951089d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.409112871329117d, y: 0.09033459177069014d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35400565326292777d, y: 0.8812255469426977d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06689592503828057d, y: 0.749643960107545d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7312802018307777d, y: 0.5475112199020641d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9748707484483449d, y: 0.1408809042835859d),

new NpgsqlTypes.NpgsqlPoint(x: 0.04924306984512716d, y: 0.9461587313314639d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.051962502156676416d, y: 0.2097255036984932d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9519423405460318d, y: 0.9484057093149514d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9690031716010431d, y: 0.8504550387071439d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2580685801095749d, y: 0.002029678542428748d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.71697706411866d, y: 0.7159597964532581d),

new NpgsqlTypes.NpgsqlPoint(x: 0.718201389502217d, y: 0.4652995995905057d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18671015687782444d, y: 0.2062711925507934d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18822957275092622d, y: 0.5685341522046328d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5415286360285887d, y: 0.8212339726002288d),

new NpgsqlTypes.NpgsqlPoint(x: 0.18837284118617703d, y: 0.8177427190126599d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8407100168335683d, y: 0.6979296281109775d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5516689300089546d, y: 0.5248443451648234d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2518094755548034d, y: 0.1672061482278887d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05037884726066599d, y: 0.13015751037072187d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7119664854468006d, y: 0.6536951898844198d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.005806931460450082d, y: 0.8493274745049265d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7766804552809448d, y: 0.45863432467696885d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8722641405447664d, y: 0.6351916019028131d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.48563825247837d, y: 0.6588157680003993d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7340304137434625d, y: 0.7229918588777235d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6002454702479334d, y: 0.7784649422231856d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09812351103554484d, y: 0.14770068166670225d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6455657096339747d, y: 0.02479457024684739d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05756003074472338d, y: 0.4261185037944627d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17183703798188443d, y: 0.3533237724403573d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8300099536142165d, y: 0.13380021598742575d),

new NpgsqlTypes.NpgsqlPoint(x: 0.21354627419084016d, y: 0.5830446661171654d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4848080618879388d, y: 0.9707500906775358d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5530843319493313d, y: 0.5756802149944898d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5358340398496536d, y: 0.5872213860686124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6257352795417449d, y: 0.3296525656741389d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.214104616721422d, y: 0.7051191655533033d),

new NpgsqlTypes.NpgsqlPoint(x: 0.06762147057376855d, y: 0.7143264995590022d),

new NpgsqlTypes.NpgsqlPoint(x: 0.34560873132120773d, y: 0.4692554555366256d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8869553258577303d, y: 0.5043125404929159d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1692117772950673d, y: 0.5996674323753274d),

new NpgsqlTypes.NpgsqlPoint(x: 0.438360345590994d, y: 0.8364808343413475d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5080283027920456d, y: 0.37914280661607247d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11748234876796715d, y: 0.7607550541164104d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4563933928477596d, y: 0.7229710882134535d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11779632141696661d, y: 0.6017917217300928d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9698709862716827d, y: 0.5024961805015686d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8510117343366665d, y: 0.8462252823753449d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5045491556461743d, y: 0.7774819723702012d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7653131514451317d, y: 0.6993480259092262d),

new NpgsqlTypes.NpgsqlPoint(x: 0.1388897727673205d, y: 0.6573444820491907d),

new NpgsqlTypes.NpgsqlPoint(x: 0.35977858489483827d, y: 0.8634757182999595d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.41218957409255763d, y: 0.8707558694545723d),

new NpgsqlTypes.NpgsqlPoint(x: 0.14786708220138378d, y: 0.2189114790550124d),

new NpgsqlTypes.NpgsqlPoint(x: 0.503081234563636d, y: 0.004947472183976287d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20499678188366333d, y: 0.6999644583321822d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5621840878324394d, y: 0.5917356604061896d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6250584556108727d, y: 0.7923241033292421d),

new NpgsqlTypes.NpgsqlPoint(x: 0.13351000070582686d, y: 0.9678692944327847d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2965408118491064d, y: 0.6028979944818625d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9093841493474629d, y: 0.22322668914478072d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2729746628748486d, y: 0.07766095960877084d),

new NpgsqlTypes.NpgsqlPoint(x: 0.32176366403121637d, y: 0.8830787651603184d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.20028931067541733d, y: 0.30261103294625435d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23093931921510946d, y: 0.6141726189553596d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9918618908445196d, y: 0.7704092441885078d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 138,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9196782739084182d, y: 0.2031929762465452d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6126061535158918d, y: 0.3823353640365169d),

new NpgsqlTypes.NpgsqlPoint(x: 0.8950710603092853d, y: 0.8688312757744642d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9508811432266484d, y: 0.709645616125304d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23749354461878658d, y: 0.1830072850546205d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6726288861658324d, y: 0.8008029829305094d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7346874817061401d, y: 0.9697015321502201d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13041880712099585d, y: 0.10139913622088637d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9288288688126667d, y: 0.4719970320455795d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2290963301436737d, y: 0.29329575664532137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7279416799875493d, y: 0.16298981495548526d),

},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.46168042891014993d, y: 0.35335852682961777d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4230600154859183d, y: 0.7887390508571496d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5255563770216808d, y: 0.21595422912487272d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2426677791485723d, y: 0.9955198900429504d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5544365734428016d, y: 0.05545095168390668d),

new NpgsqlTypes.NpgsqlPoint(x: 0.4094237002174803d, y: 0.19165220979621667d),

new NpgsqlTypes.NpgsqlPoint(x: 0.789992216793935d, y: 0.7903916368311781d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.13943256454073139d, y: 0.07312824442371213d),

new NpgsqlTypes.NpgsqlPoint(x: 0.012581796502043385d, y: 0.6399338393775577d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6794367934864447d, y: 0.24957093439435296d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.23607644635027591d, y: 0.3003728053041873d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6204248051099827d, y: 0.8468865636330133d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5938397358226982d, y: 0.7756817623626708d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.37152892308522445d, y: 0.9044557718678248d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6364857298906677d, y: 0.4654780149386988d),

new NpgsqlTypes.NpgsqlPoint(x: 0.413452185696752d, y: 0.29537836494941894d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9991941660866306d, y: 0.8003620064766828d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 159,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8377039297727171d, y: 0.07065675166377938d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5296965689337716d, y: 0.09982466439901161d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2986896263975648d, y: 0.2091759197890597d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2971613238525108d, y: 0.4649679565023638d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6225556613713324d, y: 0.3952790025191868d),

new NpgsqlTypes.NpgsqlPoint(x: 0.3651725512444558d, y: 0.8459010032450862d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9004212912834133d, y: 0.2989937935660857d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5036338594447438d, y: 0.7907620381652812d),

new NpgsqlTypes.NpgsqlPoint(x: 0.09844851739011107d, y: 0.356635731760617d),

new NpgsqlTypes.NpgsqlPoint(x: 0.08081397213256392d, y: 0.4266957503064349d),

new NpgsqlTypes.NpgsqlPoint(x: 0.2205295417422004d, y: 0.8284556107823167d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8416628755041242d, y: 0.8153318101101948d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7885181239006412d, y: 0.4130609724469432d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23868266120973625d, y: 0.20796263302158724d),

new NpgsqlTypes.NpgsqlPoint(x: 0.11446960501048797d, y: 0.6026469516429239d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06148937135141008d, y: 0.23112886730203253d),

new NpgsqlTypes.NpgsqlPoint(x: 0.20465285946865763d, y: 0.9839354995881736d),

new NpgsqlTypes.NpgsqlPoint(x: 0.033892709324821024d, y: 0.6512075530059512d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6457751922427895d, y: 0.8694931589050833d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17360728608984033d, y: 0.04474170813122147d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5379546566899615d, y: 0.23652996059452713d),

new NpgsqlTypes.NpgsqlPoint(x: 0.05747322743193295d, y: 0.18273620519738465d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(4)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4772861134600791d, y: 0.43645481683985365d),

new NpgsqlTypes.NpgsqlPoint(x: 0.17839715815327173d, y: 0.5572306696766303d),

new NpgsqlTypes.NpgsqlPoint(x: 0.23294805463519574d, y: 0.035981165130383186d),

new NpgsqlTypes.NpgsqlPoint(x: 0.7931408481416375d, y: 0.39502066635974176d),

},
    ModelInner = new NpgsqlPointpointArray2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3339761928467925d, y: 0.3245647397326592d),

new NpgsqlTypes.NpgsqlPoint(x: 0.010523700156721993d, y: 0.6645170647372849d),

new NpgsqlTypes.NpgsqlPoint(x: 0.5665818308264734d, y: 0.48772920371790174d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.30858677990698447d, y: 0.34184734656426163d),

new NpgsqlTypes.NpgsqlPoint(x: 0.9632503804021713d, y: 0.10189511156186137d),

new NpgsqlTypes.NpgsqlPoint(x: 0.6792187471635608d, y: 0.7865076783528172d),

},
},
            new NpgsqlPointpointArray2M
{
    Id = 174,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>(3)
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2617552728892245d, y: 0.13259790816263706d),

new NpgsqlTypes.NpgsqlPoint(x: 0.872434709336566d, y: 0.7883908439181881d),

new NpgsqlTypes.NpgsqlPoint(x: 0.22561508927501905d, y: 0.9463161020908308d),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
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

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointListpointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointListpointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointListpointArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
            asPartInterface: typeof(INpgsqlPointListpointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointListpointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointListpointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray2mi_id
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
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPoint>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray2mi_id", 
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
                List<NpgsqlPointpointArray2M> models = null;

                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPointListpointArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray2M> models = null;

                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointListpointArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointListpointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await ((INpgsqlPointListpointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointListpointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 159;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                Assert.That(firstItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
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
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 151;
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 5;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M), typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                await((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 151, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 56, query1, 43, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray2M>();
                var models2 = new List<FlatNpgsqlPointpointArray2M>();
                ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 26, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 24, query1, 11, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 11, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                await ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 164, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 24, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPointpointArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(models[29],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
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
FROM public.npgsqlpointpointarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray2M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray2M>();
                 ((INpgsqlPointListpointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 77, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPointpointArray2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpointpointarray2m m
LEFT JOIN public.npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
            asPartInterface: typeof(INpgsqlPointListpointArray)),
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
                var models = await((INpgsqlPointListpointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 90, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((INpgsqlPointListpointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointListpointArray)this).DbConnectionSTSelectModelBatch(connection, 70, 53))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlPointpointArray2M.AssertModel(models[0],_testData[12], false);
                        NpgsqlPointpointArray2M.AssertModel(models[1],_testData[13], false);
                        NpgsqlPointpointArray2M.AssertModel(models[2],_testData[14], false);
                        NpgsqlPointpointArray2M.AssertModel(models[3],_testData[15], false);
                        NpgsqlPointpointArray2M.AssertModel(models[4],_testData[16], false);
                        NpgsqlPointpointArray2M.AssertModel(models[5],_testData[17], false);
                        NpgsqlPointpointArray2M.AssertModel(models[6],_testData[18], false);
                        NpgsqlPointpointArray2M.AssertModel(models[7],_testData[19], false);
                        NpgsqlPointpointArray2M.AssertModel(models[8],_testData[20], false);
                        NpgsqlPointpointArray2M.AssertModel(models[9],_testData[21], false);
                        NpgsqlPointpointArray2M.AssertModel(models[10],_testData[22], false);
                        NpgsqlPointpointArray2M.AssertModel(models[11],_testData[23], false);
                        NpgsqlPointpointArray2M.AssertModel(models[12],_testData[24], false);
                        NpgsqlPointpointArray2M.AssertModel(models[13],_testData[25], false);
                        NpgsqlPointpointArray2M.AssertModel(models[14],_testData[26], false);
                        NpgsqlPointpointArray2M.AssertModel(models[15],_testData[27], false);
                        NpgsqlPointpointArray2M.AssertModel(models[16],_testData[28], false);
                        NpgsqlPointpointArray2M.AssertModel(models[17],_testData[29], false);
                        NpgsqlPointpointArray2M.AssertModel(models[18],_testData[30], false);
                        NpgsqlPointpointArray2M.AssertModel(models[19],_testData[31], false);
                        NpgsqlPointpointArray2M.AssertModel(models[20],_testData[32], false);
                        NpgsqlPointpointArray2M.AssertModel(models[21],_testData[33], false);
                        NpgsqlPointpointArray2M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 76);
                var models = await ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointListpointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointListpointArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((INpgsqlPointListpointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlPointpointArray2M.AssertModel(models[0],_testData[11], false);
                NpgsqlPointpointArray2M.AssertModel(models[1],_testData[12], false);
                NpgsqlPointpointArray2M.AssertModel(models[2],_testData[13], false);
                NpgsqlPointpointArray2M.AssertModel(models[3],_testData[14], false);
                NpgsqlPointpointArray2M.AssertModel(models[4],_testData[15], false);
                NpgsqlPointpointArray2M.AssertModel(models[5],_testData[16], false);
                NpgsqlPointpointArray2M.AssertModel(models[6],_testData[17], false);
                NpgsqlPointpointArray2M.AssertModel(models[7],_testData[18], false);
                NpgsqlPointpointArray2M.AssertModel(models[8],_testData[19], false);
                NpgsqlPointpointArray2M.AssertModel(models[9],_testData[20], false);
                NpgsqlPointpointArray2M.AssertModel(models[10],_testData[21], false);
                NpgsqlPointpointArray2M.AssertModel(models[11],_testData[22], false);
                NpgsqlPointpointArray2M.AssertModel(models[12],_testData[23], false);
                NpgsqlPointpointArray2M.AssertModel(models[13],_testData[24], false);
                NpgsqlPointpointArray2M.AssertModel(models[14],_testData[25], false);
                NpgsqlPointpointArray2M.AssertModel(models[15],_testData[26], false);
                NpgsqlPointpointArray2M.AssertModel(models[16],_testData[27], false);
                NpgsqlPointpointArray2M.AssertModel(models[17],_testData[28], false);
                NpgsqlPointpointArray2M.AssertModel(models[18],_testData[29], false);
                NpgsqlPointpointArray2M.AssertModel(models[19],_testData[30], false);
                NpgsqlPointpointArray2M.AssertModel(models[20],_testData[31], false);
                NpgsqlPointpointArray2M.AssertModel(models[21],_testData[32], false);
                NpgsqlPointpointArray2M.AssertModel(models[22],_testData[33], false);
                NpgsqlPointpointArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointListpointArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointListpointArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointListpointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
FROM public.binary_npgsqlpointpointarray2m m
LEFT JOIN public.binary_npgsqlpointpointarray2mi mi ON mi.id = m.npgsqlpointpointarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointListpointArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointListpointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointListpointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointListpointArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models =  ((INpgsqlPointListpointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointListpointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointarray2mi
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
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI), typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                await ((INpgsqlPointListpointArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MI>();
                var models2 = new List<NpgsqlPointpointArray2MI>();
                ((INpgsqlPointListpointArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633),
                (NpgsqlTypes.NpgsqlDbType)(-2147483633)
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
                var models = await ((INpgsqlPointListpointArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointarray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA), typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                await ((INpgsqlPointListpointArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointArray2MIWA>();
                var models2 = new List<NpgsqlPointpointArray2MIWA>();
                ((INpgsqlPointListpointArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointListpointArray))]
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
                var models = await ((INpgsqlPointListpointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointListpointArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

