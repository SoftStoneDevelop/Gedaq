

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
    internal partial interface INpgsqlPolygonArraypolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonArraypolygonArray : INpgsqlPolygonArraypolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray1M[] _testData = new NpgsqlPolygonpolygonArray1M[]
        {
            new NpgsqlPolygonpolygonArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33611160344156166d, y: 0.6016567683653852d), new NpgsqlTypes.NpgsqlPoint(x: 0.8668181065656735d, y: 0.0128968768782447d), new NpgsqlTypes.NpgsqlPoint(x: 0.778641667764141d, y: 0.29249632634230116d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7137096271424967d, y: 0.6680008173403603d), new NpgsqlTypes.NpgsqlPoint(x: 0.26498571949560634d, y: 0.6152889809936998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9522350834939352d, y: 0.2053391417187218d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33716343236822066d, y: 0.46797368352044233d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234517417480902d, y: 0.6441863744802228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5459577129619572d, y: 0.5473403389788276d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8106101916275393d, y: 0.6120575119952665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7106260827311944d, y: 0.9421824507389237d), new NpgsqlTypes.NpgsqlPoint(x: 0.1294815580665324d, y: 0.1872235628903285d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1447976016290342d, y: 0.7317108193097603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9962670003648828d, y: 0.01831438489597359d), new NpgsqlTypes.NpgsqlPoint(x: 0.24053210633512645d, y: 0.7669230791979302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21538166131844516d, y: 0.8018136945157414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4889420212615079d, y: 0.41329170332338594d), new NpgsqlTypes.NpgsqlPoint(x: 0.13091487736772134d, y: 0.0844820068838158d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4018769518505767d, y: 0.35928364629202403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225399633246594d, y: 0.5721446056049606d), new NpgsqlTypes.NpgsqlPoint(x: 0.3604932435930741d, y: 0.5620338583964919d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5037101113666679d, y: 0.34555464507752076d), new NpgsqlTypes.NpgsqlPoint(x: 0.1174286603721244d, y: 0.41153892954532467d), new NpgsqlTypes.NpgsqlPoint(x: 0.35757229865838713d, y: 0.4450170619628886d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11348842367226741d, y: 0.4176343678572254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396075829230156d, y: 0.5872425372056531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5231235181266705d, y: 0.8266220287938255d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.031646243878011515d, y: 0.1640834074415175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9471450050734501d, y: 0.22450104054198972d), new NpgsqlTypes.NpgsqlPoint(x: 0.29515060058689413d, y: 0.42316146305540625d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08333794981683651d, y: 0.5176922369761865d), new NpgsqlTypes.NpgsqlPoint(x: 0.22243245188825533d, y: 0.06062927468876378d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291568686368651d, y: 0.8092286053160358d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8403059890511284d, y: 0.1367913822629676d), new NpgsqlTypes.NpgsqlPoint(x: 0.4772179643850718d, y: 0.5932743456765066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9077759966653667d, y: 0.37673401662023964d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38377324666195267d, y: 0.47868824700582924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7730468547631617d, y: 0.01733553877422167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8090003352631671d, y: 0.8455521139913535d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5424023755086261d, y: 0.0016379536810218198d), new NpgsqlTypes.NpgsqlPoint(x: 0.1333342244653385d, y: 0.9612847270484474d), new NpgsqlTypes.NpgsqlPoint(x: 0.8464066703157819d, y: 0.5784356356928125d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7728412879914435d, y: 0.25090612865893813d), new NpgsqlTypes.NpgsqlPoint(x: 0.1571563666178547d, y: 0.292105330198439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6481760607838164d, y: 0.6346460314123824d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4415804455950182d, y: 0.6737686146828948d), new NpgsqlTypes.NpgsqlPoint(x: 0.3296262131452904d, y: 0.20469468710881233d), new NpgsqlTypes.NpgsqlPoint(x: 0.10913406209568133d, y: 0.6591603881198835d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9327307320557832d, y: 0.9806163641071083d), new NpgsqlTypes.NpgsqlPoint(x: 0.2817388909699321d, y: 0.3593544694194786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6387765552685297d, y: 0.4510556205519226d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5626699850930144d, y: 0.16609260409221138d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594085252240723d, y: 0.08629165617066092d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351156191399433d, y: 0.6787939422653224d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28015455414107604d, y: 0.7191232176328337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8349166054541394d, y: 0.578831673110185d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989507549903522d, y: 0.9696939991504212d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4457418830691149d, y: 0.5588464790256158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462333146712107d, y: 0.4470051972082154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3564301569868057d, y: 0.07077631390785222d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28326764881516453d, y: 0.8735952625154751d), new NpgsqlTypes.NpgsqlPoint(x: 0.40441292663447703d, y: 0.4634371369779665d), new NpgsqlTypes.NpgsqlPoint(x: 0.26770935058701806d, y: 0.07898212158942419d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.258635374827499d, y: 0.6388564958159281d), new NpgsqlTypes.NpgsqlPoint(x: 0.8388402607467489d, y: 0.9916535936186852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9100694636435035d, y: 0.5683579973999491d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6573266652247952d, y: 0.21901191305520562d), new NpgsqlTypes.NpgsqlPoint(x: 0.6615674438779915d, y: 0.24386887487072018d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842338674614494d, y: 0.7624007456109979d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03543466019791264d, y: 0.6995045395430123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9375030537258857d, y: 0.892295600633882d), new NpgsqlTypes.NpgsqlPoint(x: 0.2056883257260772d, y: 0.6531549898989504d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.867839310123493d, y: 0.757242614393159d), new NpgsqlTypes.NpgsqlPoint(x: 0.17155405814425417d, y: 0.3239439433187784d), new NpgsqlTypes.NpgsqlPoint(x: 0.886666167590984d, y: 0.6650971549662599d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7897026213032579d, y: 0.5080342188168931d), new NpgsqlTypes.NpgsqlPoint(x: 0.730423630155299d, y: 0.10029303024080427d), new NpgsqlTypes.NpgsqlPoint(x: 0.907395519111681d, y: 0.7459578481994298d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3679779921044545d, y: 0.27122444985838134d), new NpgsqlTypes.NpgsqlPoint(x: 0.09044141922958293d, y: 0.08833585188923454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4856968515553517d, y: 0.09479557392296456d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27383794495759006d, y: 0.5466726026312497d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256801658086987d, y: 0.13185388026679257d), new NpgsqlTypes.NpgsqlPoint(x: 0.46158618856721323d, y: 0.5033179610354949d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9451339493973454d, y: 0.5197617042594583d), new NpgsqlTypes.NpgsqlPoint(x: 0.5655393763793173d, y: 0.4103477518958689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7998904552682276d, y: 0.0373366900885288d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8613801472856423d, y: 0.5116865172676394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379683821903549d, y: 0.3314318433622939d), new NpgsqlTypes.NpgsqlPoint(x: 0.29136130957142825d, y: 0.6684787074317943d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8215517668868629d, y: 0.904400620888989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710167502774266d, y: 0.7540251737612252d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951336546323738d, y: 0.8602621792815717d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7331962564605229d, y: 0.2765365494035591d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009476145263887d, y: 0.6186716377341636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5047965229599644d, y: 0.580488167287798d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6096570645252783d, y: 0.7434747033625466d), new NpgsqlTypes.NpgsqlPoint(x: 0.20921314382203104d, y: 0.6053875446094737d), new NpgsqlTypes.NpgsqlPoint(x: 0.10418848875499986d, y: 0.8913203759013705d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2593707404036768d, y: 0.8355955382541912d), new NpgsqlTypes.NpgsqlPoint(x: 0.31369052679997556d, y: 0.9266155698979134d), new NpgsqlTypes.NpgsqlPoint(x: 0.27105115690713333d, y: 0.2613358873091852d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9127602397526078d, y: 0.18999098294629757d), new NpgsqlTypes.NpgsqlPoint(x: 0.22018563816903747d, y: 0.5647351200027927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5703653719360217d, y: 0.10431554148601307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48837234731114276d, y: 0.06815986771655969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5676224357559462d, y: 0.7282199676465835d), new NpgsqlTypes.NpgsqlPoint(x: 0.28102861134186374d, y: 0.4108002046366247d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12334375914301943d, y: 0.7359025197343316d), new NpgsqlTypes.NpgsqlPoint(x: 0.49667631046231675d, y: 0.19664401779506668d), new NpgsqlTypes.NpgsqlPoint(x: 0.35643297809573693d, y: 0.9431204242352687d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7838908614046168d, y: 0.8215388740911768d), new NpgsqlTypes.NpgsqlPoint(x: 0.0955470583333704d, y: 0.35811892453461214d), new NpgsqlTypes.NpgsqlPoint(x: 0.371568078649241d, y: 0.5038224957119226d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3791260854255655d, y: 0.9683646270778495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9365246721721839d, y: 0.7968079863508347d), new NpgsqlTypes.NpgsqlPoint(x: 0.9543679834556112d, y: 0.655809435916257d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2323087575388938d, y: 0.17678418533721296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444217051209457d, y: 0.3902658930432502d), new NpgsqlTypes.NpgsqlPoint(x: 0.899319890529758d, y: 0.668350390810126d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.127082412928326d, y: 0.19759310495063576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493998638456983d, y: 0.4323488960192935d), new NpgsqlTypes.NpgsqlPoint(x: 0.4415339460240112d, y: 0.28217795260658196d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5193676160227934d, y: 0.06187646026021265d), new NpgsqlTypes.NpgsqlPoint(x: 0.44144360988441333d, y: 0.7449381736306474d), new NpgsqlTypes.NpgsqlPoint(x: 0.09291454698553092d, y: 0.5912360413834501d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8246078316855631d, y: 0.7364381740649195d), new NpgsqlTypes.NpgsqlPoint(x: 0.7750531988658939d, y: 0.9667199633129193d), new NpgsqlTypes.NpgsqlPoint(x: 0.11745397949794156d, y: 0.7706550417119056d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24310382881488002d, y: 0.8679111337503838d), new NpgsqlTypes.NpgsqlPoint(x: 0.45889291108824004d, y: 0.18161250252750605d), new NpgsqlTypes.NpgsqlPoint(x: 0.0910832302199569d, y: 0.37156885610952894d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.670298615356443d, y: 0.3185104649975522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403280486855363d, y: 0.3214880046460259d), new NpgsqlTypes.NpgsqlPoint(x: 0.48512160745663324d, y: 0.008571083395843448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3234073098742709d, y: 0.9886547157537462d), new NpgsqlTypes.NpgsqlPoint(x: 0.49111169240264463d, y: 0.4901986341656861d), new NpgsqlTypes.NpgsqlPoint(x: 0.4047912555628581d, y: 0.822869462114566d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022135982818421662d, y: 0.7801995477868305d), new NpgsqlTypes.NpgsqlPoint(x: 0.19375267195214507d, y: 0.37146955871640985d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623743609096509d, y: 0.7555175818646471d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7452227977608064d, y: 0.3698855716155992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9838772108621694d, y: 0.004949127372894324d), new NpgsqlTypes.NpgsqlPoint(x: 0.11086263600763369d, y: 0.5607603260884667d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2651901785165519d, y: 0.896615532882713d), new NpgsqlTypes.NpgsqlPoint(x: 0.13451771548072544d, y: 0.06014070690730744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032597784825776d, y: 0.7319869344145788d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6531276811972296d, y: 0.9138040316522655d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916460964716604d, y: 0.8798427547756894d), new NpgsqlTypes.NpgsqlPoint(x: 0.14897931233167283d, y: 0.3674113678783384d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9795346716296507d, y: 0.5721848609852036d), new NpgsqlTypes.NpgsqlPoint(x: 0.09840243991382136d, y: 0.09183161531090633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603115704833207d, y: 0.5549584313863931d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731995482117321d, y: 0.14675073190236587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987511647227824d, y: 0.9165861201950408d), new NpgsqlTypes.NpgsqlPoint(x: 0.1827970170567772d, y: 0.9362092190929323d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13283506443042647d, y: 0.744836298095001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916446460782999d, y: 0.9620471425704584d), new NpgsqlTypes.NpgsqlPoint(x: 0.8124285850136079d, y: 0.5136104519948923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28390254882966237d, y: 0.32639635413819956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263183320308655d, y: 0.5421092010426839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366622277051807d, y: 0.30551039308494565d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 38,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6704477339688357d, y: 0.8127149544506534d), new NpgsqlTypes.NpgsqlPoint(x: 0.21535962013648746d, y: 0.49242013631098114d), new NpgsqlTypes.NpgsqlPoint(x: 0.046852866527046344d, y: 0.7835545544487484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969555836824265d, y: 0.5863691537902902d), new NpgsqlTypes.NpgsqlPoint(x: 0.06496917935762514d, y: 0.06512622880314745d), new NpgsqlTypes.NpgsqlPoint(x: 0.13925408518096216d, y: 0.4206013701980742d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2849462843211865d, y: 0.8849420533550838d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556544276921244d, y: 0.40088498361257097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3752437175942708d, y: 0.7146181345741504d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19850360023183666d, y: 0.7409187856006102d), new NpgsqlTypes.NpgsqlPoint(x: 0.2845578340756284d, y: 0.805898319686918d), new NpgsqlTypes.NpgsqlPoint(x: 0.6622803355540668d, y: 0.5545779041542329d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8907839916792933d, y: 0.5977201357615934d), new NpgsqlTypes.NpgsqlPoint(x: 0.20866405087644369d, y: 0.33225031636919644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8500214875863193d, y: 0.05773713814868631d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18432661506831394d, y: 0.637437195390748d), new NpgsqlTypes.NpgsqlPoint(x: 0.6693443066992244d, y: 0.3495077683142934d), new NpgsqlTypes.NpgsqlPoint(x: 0.2780283334927609d, y: 0.8128162842956164d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.050861404395827536d, y: 0.3111188870659143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4642932388488703d, y: 0.3102221261695244d), new NpgsqlTypes.NpgsqlPoint(x: 0.779064507109108d, y: 0.14078432869434243d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5213869867590241d, y: 0.10726018424383654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5484496133037786d, y: 0.5834283751346883d), new NpgsqlTypes.NpgsqlPoint(x: 0.0850109264841915d, y: 0.1192265949037129d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.58497962796382d, y: 0.10934024550622068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4830952592453732d, y: 0.9696008883869117d), new NpgsqlTypes.NpgsqlPoint(x: 0.6493004661961229d, y: 0.6540001823424174d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12293249450177546d, y: 0.49779046246069636d), new NpgsqlTypes.NpgsqlPoint(x: 0.655818058509713d, y: 0.3448604325623099d), new NpgsqlTypes.NpgsqlPoint(x: 0.595187339549148d, y: 0.7380401425003126d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08752735041911686d, y: 0.05586878302500253d), new NpgsqlTypes.NpgsqlPoint(x: 0.030306926932421985d, y: 0.40195508468013197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8603404388626358d, y: 0.16990090453904005d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030532875026658024d, y: 0.3367966444697431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805759306726027d, y: 0.9249448176297052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595603625652123d, y: 0.6557822382100643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06455086168032975d, y: 0.4246146603622317d), new NpgsqlTypes.NpgsqlPoint(x: 0.35587909045803723d, y: 0.23849217528045563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33055832209706926d, y: 0.07116875236451281d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37794082965198206d, y: 0.07279253859657231d), new NpgsqlTypes.NpgsqlPoint(x: 0.18841831956880017d, y: 0.21111997142737327d), new NpgsqlTypes.NpgsqlPoint(x: 0.137903822134973d, y: 0.20948117215287632d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9614022306303857d, y: 0.641578447752167d), new NpgsqlTypes.NpgsqlPoint(x: 0.36426795459323247d, y: 0.7426795022741112d), new NpgsqlTypes.NpgsqlPoint(x: 0.19167795013047917d, y: 0.1830631210385738d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2899927952191025d, y: 0.9846800203110886d), new NpgsqlTypes.NpgsqlPoint(x: 0.2389797981627877d, y: 0.8245329053777133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423775847595623d, y: 0.4127322908803863d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03512858278511055d, y: 0.15020159904505725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8360020441092162d, y: 0.5577856458880854d), new NpgsqlTypes.NpgsqlPoint(x: 0.8399215407315691d, y: 0.9549717105776845d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453094961185102d, y: 0.8024918086725888d), new NpgsqlTypes.NpgsqlPoint(x: 0.370890693789376d, y: 0.39039182912038506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5226162806109713d, y: 0.1772695103144144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2794406885003562d, y: 0.5860429637393313d), new NpgsqlTypes.NpgsqlPoint(x: 0.05638975658273748d, y: 0.5426800211346625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812837654220115d, y: 0.7526363660989324d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4496438154065582d, y: 0.5843467231276306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576473918544308d, y: 0.564106048883746d), new NpgsqlTypes.NpgsqlPoint(x: 0.36604134743834427d, y: 0.7517043387903797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2947490610097543d, y: 0.2661666415322417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944122293271942d, y: 0.7280566926930002d), new NpgsqlTypes.NpgsqlPoint(x: 0.043162808380773576d, y: 0.8277672245729757d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17760547803481808d, y: 0.42556081298575865d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109893944162427d, y: 0.9161443519280489d), new NpgsqlTypes.NpgsqlPoint(x: 0.9957697889267991d, y: 0.8684546747445342d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9220401661313843d, y: 0.8569373670305904d), new NpgsqlTypes.NpgsqlPoint(x: 0.08927693890328403d, y: 0.03014796931383601d), new NpgsqlTypes.NpgsqlPoint(x: 0.3702892912271878d, y: 0.5054654812333654d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31672252811098334d, y: 0.4507391465665309d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019508079089158d, y: 0.06226341705960836d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879690019708085d, y: 0.08653350219588918d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6930033518181808d, y: 0.12198810805675397d), new NpgsqlTypes.NpgsqlPoint(x: 0.5915408430874277d, y: 0.12191406539090976d), new NpgsqlTypes.NpgsqlPoint(x: 0.4270054935406211d, y: 0.428345630095442d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2518397322372904d, y: 0.987910358629599d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768368203724968d, y: 0.42914585367367075d), new NpgsqlTypes.NpgsqlPoint(x: 0.04940995963311512d, y: 0.03411624712240113d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7071004563769991d, y: 0.5176487202299824d), new NpgsqlTypes.NpgsqlPoint(x: 0.711632980583601d, y: 0.8155832324284369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809280012930109d, y: 0.6852875244589428d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3169038403490958d, y: 0.5233039370771807d), new NpgsqlTypes.NpgsqlPoint(x: 0.991956470933412d, y: 0.9885537280041536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386621336548154d, y: 0.3638112149199527d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8445731589797714d, y: 0.6070847618061375d), new NpgsqlTypes.NpgsqlPoint(x: 0.982805069059242d, y: 0.1530128565412543d), new NpgsqlTypes.NpgsqlPoint(x: 0.18287395261362904d, y: 0.9661696476987093d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8621892391303989d, y: 0.29676360421032055d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739404617933106d, y: 0.9856421098685623d), new NpgsqlTypes.NpgsqlPoint(x: 0.6476948410982181d, y: 0.7558273953306602d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.648760375896179d, y: 0.46107326829852835d), new NpgsqlTypes.NpgsqlPoint(x: 0.2368438464780509d, y: 0.17715823030969613d), new NpgsqlTypes.NpgsqlPoint(x: 0.6120975660072082d, y: 0.12335168293094423d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012805934530457641d, y: 0.8508169340118251d), new NpgsqlTypes.NpgsqlPoint(x: 0.03012281385063742d, y: 0.3558093182791515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815453312354168d, y: 0.919293279179505d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24008106472091761d, y: 0.4354260595177071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9308774305476805d, y: 0.8362703384144248d), new NpgsqlTypes.NpgsqlPoint(x: 0.40759839986188606d, y: 0.36792774061162015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7544925816225613d, y: 0.6854688211018225d), new NpgsqlTypes.NpgsqlPoint(x: 0.635297162374937d, y: 0.7814181789209546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622217948700764d, y: 0.8740486550553167d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7560148446370284d, y: 0.9767493946463324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591581104929522d, y: 0.7341309043564445d), new NpgsqlTypes.NpgsqlPoint(x: 0.37827311306641764d, y: 0.35624137144045853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6152201907895996d, y: 0.4784598075720068d), new NpgsqlTypes.NpgsqlPoint(x: 0.03235485186202136d, y: 0.016349362371484655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5493064480504019d, y: 0.12178648820936233d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9656448178446266d, y: 0.4226867673706599d), new NpgsqlTypes.NpgsqlPoint(x: 0.12136357416339427d, y: 0.7753390222444658d), new NpgsqlTypes.NpgsqlPoint(x: 0.2842663118897315d, y: 0.4944351533798572d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15681241014114866d, y: 0.8723634649410911d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382873608126501d, y: 0.7723806751678984d), new NpgsqlTypes.NpgsqlPoint(x: 0.6393153866895432d, y: 0.3824105313587951d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2770002724963153d, y: 0.8941069274590571d), new NpgsqlTypes.NpgsqlPoint(x: 0.21550375437642288d, y: 0.5797991438207786d), new NpgsqlTypes.NpgsqlPoint(x: 0.03681620833785604d, y: 0.6905786508378613d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29945571840795004d, y: 0.638669013310685d), new NpgsqlTypes.NpgsqlPoint(x: 0.768013106865291d, y: 0.35119037800185904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682233627077445d, y: 0.6927735955721065d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03844543637766462d, y: 0.6882956261325063d), new NpgsqlTypes.NpgsqlPoint(x: 0.005690699312689063d, y: 0.7767701291796495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377023764648695d, y: 0.799147976548541d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9995498933967898d, y: 0.49184981241953163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991676900229444d, y: 0.6643051910892697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7588968378927933d, y: 0.6936577688161917d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9268952062059805d, y: 0.7185346273385246d), new NpgsqlTypes.NpgsqlPoint(x: 0.24295961484660045d, y: 0.18094999631862363d), new NpgsqlTypes.NpgsqlPoint(x: 0.7321189547270008d, y: 0.7072672945817154d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9398301433956503d, y: 0.12791582987738137d), new NpgsqlTypes.NpgsqlPoint(x: 0.201075822834908d, y: 0.425313714183438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6423633094522859d, y: 0.29476880577501696d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1307123513103965d, y: 0.28080569590128335d), new NpgsqlTypes.NpgsqlPoint(x: 0.4341052117935289d, y: 0.622372581065614d), new NpgsqlTypes.NpgsqlPoint(x: 0.22799104959876892d, y: 0.9699935031179271d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8199686518651091d, y: 0.7333883327813557d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034085052640902d, y: 0.033709852809795327d), new NpgsqlTypes.NpgsqlPoint(x: 0.012112338149487534d, y: 0.5169081359017972d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3383540109112916d, y: 0.0845544141537049d), new NpgsqlTypes.NpgsqlPoint(x: 0.06053749507526063d, y: 0.3654232800101581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832301842390234d, y: 0.6995557000443734d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.053804349686547126d, y: 0.9962237420084814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353391826563627d, y: 0.7729349968709616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2715519098759407d, y: 0.13660630815158592d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114585456272898d, y: 0.008658470270596186d), new NpgsqlTypes.NpgsqlPoint(x: 0.39080979779536584d, y: 0.06386513454270315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165155259761989d, y: 0.11130440406885422d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22989250761725288d, y: 0.3112807990927131d), new NpgsqlTypes.NpgsqlPoint(x: 0.3288873194624683d, y: 0.48629778011076574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6235294328270425d, y: 0.7622720528415333d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47799268862549926d, y: 0.13945258722315512d), new NpgsqlTypes.NpgsqlPoint(x: 0.7938708167704059d, y: 0.9738075706261164d), new NpgsqlTypes.NpgsqlPoint(x: 0.9675944083209506d, y: 0.8931652391245779d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02842640856852441d, y: 0.91061606811155d), new NpgsqlTypes.NpgsqlPoint(x: 0.8817781043947364d, y: 0.1631375422184127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6660926411283844d, y: 0.47296034104817253d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4696830481846649d, y: 0.5060530127255921d), new NpgsqlTypes.NpgsqlPoint(x: 0.1831880139499692d, y: 0.1449850208622777d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374226502703852d, y: 0.42089304514670745d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49138126678421556d, y: 0.9033891680766893d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727260378557695d, y: 0.0674248265854357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9043654187410567d, y: 0.9187225507080349d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9970153431738659d, y: 0.4553489707575308d), new NpgsqlTypes.NpgsqlPoint(x: 0.603506287516688d, y: 0.39912055099788746d), new NpgsqlTypes.NpgsqlPoint(x: 0.3489997665013779d, y: 0.7410968643235352d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35736838018665285d, y: 0.3779758413767851d), new NpgsqlTypes.NpgsqlPoint(x: 0.11539250019814662d, y: 0.6626872461564112d), new NpgsqlTypes.NpgsqlPoint(x: 0.6036397198293421d, y: 0.265181897451209d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07743374030170858d, y: 0.5928647947431324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5248398407794709d, y: 0.4366518784302922d), new NpgsqlTypes.NpgsqlPoint(x: 0.4290324542695867d, y: 0.47522990247794916d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9734021140673975d, y: 0.6616372199956704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6115775337713922d, y: 0.5920611227881784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8988167612451227d, y: 0.47270926788516876d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7926292593047576d, y: 0.06797363147714586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9163395614774649d, y: 0.3019080086407112d), new NpgsqlTypes.NpgsqlPoint(x: 0.849261469450212d, y: 0.28018699681215076d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9419615754529608d, y: 0.9137127888251098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9839385284219916d, y: 0.19399942327392272d), new NpgsqlTypes.NpgsqlPoint(x: 0.06867415468498361d, y: 0.39878519331466367d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5125605709028755d, y: 0.13394499788541092d), new NpgsqlTypes.NpgsqlPoint(x: 0.859023245796989d, y: 0.8314941829898801d), new NpgsqlTypes.NpgsqlPoint(x: 0.980567843273428d, y: 0.7363500389979805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24132917734878667d, y: 0.7492844897538076d), new NpgsqlTypes.NpgsqlPoint(x: 0.3439610988101244d, y: 0.7756408858846218d), new NpgsqlTypes.NpgsqlPoint(x: 0.36310035717934885d, y: 0.5732669250794342d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2184731276477534d, y: 0.6934732696380848d), new NpgsqlTypes.NpgsqlPoint(x: 0.56898705115779d, y: 0.9336350543659298d), new NpgsqlTypes.NpgsqlPoint(x: 0.7455352884707105d, y: 0.6620228608603611d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20342746786123278d, y: 0.8856468309116196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5568624192137693d, y: 0.9612491732486376d), new NpgsqlTypes.NpgsqlPoint(x: 0.032824321729882255d, y: 0.03411324347169409d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6854300680668697d, y: 0.09520143705768247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799023021791255d, y: 0.45172167676374275d), new NpgsqlTypes.NpgsqlPoint(x: 0.10256297814563864d, y: 0.19040720614379714d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.682155847174155d, y: 0.5944147634369638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6341082897486809d, y: 0.2028132362733065d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024190674689982d, y: 0.8352121125957259d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.810144728875665d, y: 0.2797420765748091d), new NpgsqlTypes.NpgsqlPoint(x: 0.2929517142936864d, y: 0.16351677134587206d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350583112926473d, y: 0.5854345840462462d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7021440494154617d, y: 0.47463023365255597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7605296991709187d, y: 0.050358273351848504d), new NpgsqlTypes.NpgsqlPoint(x: 0.46804710532687854d, y: 0.2663799763281228d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6907626692952773d, y: 0.4361333555813325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8172222354071512d, y: 0.47309116609705726d), new NpgsqlTypes.NpgsqlPoint(x: 0.5267931334228588d, y: 0.24803693314554642d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.720621796478692d, y: 0.4983554879615427d), new NpgsqlTypes.NpgsqlPoint(x: 0.636776844375819d, y: 0.4740045888736064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8520139181884266d, y: 0.510209772949543d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1110920647257877d, y: 0.5850675899328588d), new NpgsqlTypes.NpgsqlPoint(x: 0.9755533669770212d, y: 0.9238650071396781d), new NpgsqlTypes.NpgsqlPoint(x: 0.06404267387382379d, y: 0.744912089919709d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06848143953077046d, y: 0.13180295342360904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6880911460348104d, y: 0.510064029671775d), new NpgsqlTypes.NpgsqlPoint(x: 0.3089214884752116d, y: 0.9639568300920965d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0915459569983923d, y: 0.8884653501909574d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060314051759383d, y: 0.46903050727608986d), new NpgsqlTypes.NpgsqlPoint(x: 0.057509776359037534d, y: 0.834534687123307d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6935736322821062d, y: 0.08728888894676545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343497726664312d, y: 0.6259257598913212d), new NpgsqlTypes.NpgsqlPoint(x: 0.612706091720765d, y: 0.8700560094554192d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8012897100822058d, y: 0.2572422793252537d), new NpgsqlTypes.NpgsqlPoint(x: 0.27110976822201893d, y: 0.2654521475111883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09014227701428656d, y: 0.9175442015608608d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49456081049142664d, y: 0.3424746047781819d), new NpgsqlTypes.NpgsqlPoint(x: 0.29276934950932265d, y: 0.8131757878355893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8744569519978537d, y: 0.47258606797585667d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9813978488649814d, y: 0.9219292035702608d), new NpgsqlTypes.NpgsqlPoint(x: 0.1786622604678889d, y: 0.7559432436761757d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611764700462107d, y: 0.4261052599248416d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2587569665019286d, y: 0.5482665221324035d), new NpgsqlTypes.NpgsqlPoint(x: 0.24487344436646596d, y: 0.8518231886829032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732555311557991d, y: 0.43707807413024913d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5604124080066002d, y: 0.6588643978924167d), new NpgsqlTypes.NpgsqlPoint(x: 0.3063267659391764d, y: 0.651901706878347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687328916308742d, y: 0.9932141635997576d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9633342227477241d, y: 0.7448519937591841d), new NpgsqlTypes.NpgsqlPoint(x: 0.17624492601749853d, y: 0.2819324957005791d), new NpgsqlTypes.NpgsqlPoint(x: 0.09824077550388355d, y: 0.7331935165052857d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9178229898779858d, y: 0.31477664744599676d), new NpgsqlTypes.NpgsqlPoint(x: 0.7096633136035067d, y: 0.0270173013209406d), new NpgsqlTypes.NpgsqlPoint(x: 0.1237736000104781d, y: 0.5087745587213418d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8669629446205593d, y: 0.7648954742777437d), new NpgsqlTypes.NpgsqlPoint(x: 0.21224697940883364d, y: 0.008476652982497335d), new NpgsqlTypes.NpgsqlPoint(x: 0.985232044492161d, y: 0.5074049411785889d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37568002480093765d, y: 0.4256758001276998d), new NpgsqlTypes.NpgsqlPoint(x: 0.47783499035737376d, y: 0.5087997036259941d), new NpgsqlTypes.NpgsqlPoint(x: 0.9883164044662364d, y: 0.9150755158590325d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16574300850985735d, y: 0.9506739635400393d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445560847660265d, y: 0.3336343094271672d), new NpgsqlTypes.NpgsqlPoint(x: 0.0772755096642459d, y: 0.4990681632499455d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09294598174623458d, y: 0.12650181752447176d), new NpgsqlTypes.NpgsqlPoint(x: 0.31081696695504246d, y: 0.6700609387637546d), new NpgsqlTypes.NpgsqlPoint(x: 0.8475053237452317d, y: 0.03861233930354202d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26728810269772485d, y: 0.9085702286381427d), new NpgsqlTypes.NpgsqlPoint(x: 0.6345716988348806d, y: 0.3170072920072189d), new NpgsqlTypes.NpgsqlPoint(x: 0.018384000148474744d, y: 0.8830677846054518d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8956503035566294d, y: 0.40804956230240763d), new NpgsqlTypes.NpgsqlPoint(x: 0.23861533785854194d, y: 0.3414206901257826d), new NpgsqlTypes.NpgsqlPoint(x: 0.10150030949986555d, y: 0.8100288482242013d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9596321200574053d, y: 0.3931878121337974d), new NpgsqlTypes.NpgsqlPoint(x: 0.5288683938048654d, y: 0.012274215670272759d), new NpgsqlTypes.NpgsqlPoint(x: 0.33780849301588767d, y: 0.0956498610030343d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8377559912636293d, y: 0.5343949631717534d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910956157324349d, y: 0.7210571458790671d), new NpgsqlTypes.NpgsqlPoint(x: 0.2876185080310719d, y: 0.1407686297795181d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06869515406796156d, y: 0.7946327703642955d), new NpgsqlTypes.NpgsqlPoint(x: 0.6167050332887712d, y: 0.8313893001870736d), new NpgsqlTypes.NpgsqlPoint(x: 0.47047430780345967d, y: 0.3412608898625781d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8134249929757909d, y: 0.9829454662257758d), new NpgsqlTypes.NpgsqlPoint(x: 0.36498549933757174d, y: 0.19802984344877828d), new NpgsqlTypes.NpgsqlPoint(x: 0.10106044720074125d, y: 0.03219779136552814d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4055371463383308d, y: 0.13500018148286508d), new NpgsqlTypes.NpgsqlPoint(x: 0.03402186347539038d, y: 0.10177439827486656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674335650060328d, y: 0.3835786120399448d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047921622184163626d, y: 0.21016516129026075d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544999110694894d, y: 0.4797436658345624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924614377338905d, y: 0.21909966053649066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837437015877504d, y: 0.7091237955391642d), new NpgsqlTypes.NpgsqlPoint(x: 0.16632560501697025d, y: 0.4995757561171751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7143912185091003d, y: 0.7065269073584696d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15148824192764365d, y: 0.4556259759241439d), new NpgsqlTypes.NpgsqlPoint(x: 0.30836261871482284d, y: 0.1139846529067371d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061698066837604d, y: 0.9148561245980479d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2853988913157821d, y: 0.7263776759433048d), new NpgsqlTypes.NpgsqlPoint(x: 0.3287340270931489d, y: 0.6410470663390614d), new NpgsqlTypes.NpgsqlPoint(x: 0.25893509643939583d, y: 0.6147956464806745d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9943235606988559d, y: 0.575785027790333d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995105452429455d, y: 0.38041459648656306d), new NpgsqlTypes.NpgsqlPoint(x: 0.77471092530607d, y: 0.542155142949363d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22179552254527657d, y: 0.18683483531596745d), new NpgsqlTypes.NpgsqlPoint(x: 0.1476231010664466d, y: 0.8400316078502587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940066361747345d, y: 0.4200568023550114d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8151253113818683d, y: 0.9436360880295541d), new NpgsqlTypes.NpgsqlPoint(x: 0.4123807494049244d, y: 0.581008911351707d), new NpgsqlTypes.NpgsqlPoint(x: 0.24294308560408184d, y: 0.9880054961514588d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.797970105577836d, y: 0.675804947452914d), new NpgsqlTypes.NpgsqlPoint(x: 0.3025611895903867d, y: 0.842355026465375d), new NpgsqlTypes.NpgsqlPoint(x: 0.28005826089774943d, y: 0.1760668826017403d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22771364627163737d, y: 0.15363417286569203d), new NpgsqlTypes.NpgsqlPoint(x: 0.11145226528471752d, y: 0.7503310781266408d), new NpgsqlTypes.NpgsqlPoint(x: 0.17349094554082423d, y: 0.7899319854555427d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02952100426319204d, y: 0.36158078684417017d), new NpgsqlTypes.NpgsqlPoint(x: 0.669264992959373d, y: 0.052742035732438186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8012181089318929d, y: 0.8673863230187723d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7830709829284722d, y: 0.298669907278983d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837484238468365d, y: 0.3065435560930374d), new NpgsqlTypes.NpgsqlPoint(x: 0.9061494649426528d, y: 0.14809767249746342d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9355423190509484d, y: 0.5878203130373397d), new NpgsqlTypes.NpgsqlPoint(x: 0.09380623763044549d, y: 0.9540764522518032d), new NpgsqlTypes.NpgsqlPoint(x: 0.762004623639364d, y: 0.03938136080155741d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3646871825485517d, y: 0.5251187798601132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5147718299644557d, y: 0.5190132066093024d), new NpgsqlTypes.NpgsqlPoint(x: 0.516396134315987d, y: 0.81307453817502d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6427880496177216d, y: 0.862855907743817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9682336233777593d, y: 0.4922903820226219d), new NpgsqlTypes.NpgsqlPoint(x: 0.36029977608409547d, y: 0.883563195504331d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7198770775391661d, y: 0.6980591799950779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973277134225773d, y: 0.7618686075964654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174928670213678d, y: 0.15404182127128274d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6353624648456404d, y: 0.24925816135265022d), new NpgsqlTypes.NpgsqlPoint(x: 0.20039786741653598d, y: 0.7046626103451615d), new NpgsqlTypes.NpgsqlPoint(x: 0.5870183825334006d, y: 0.9449254999221959d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.474303199078574d, y: 0.694291143091961d), new NpgsqlTypes.NpgsqlPoint(x: 0.2785772354945677d, y: 0.7880103911912695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739275182365201d, y: 0.7404140375019617d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6952274333818188d, y: 0.11304687793977553d), new NpgsqlTypes.NpgsqlPoint(x: 0.11708699707723746d, y: 0.2876778351877174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9780204462752012d, y: 0.22590894530468597d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6216317563123044d, y: 0.647899311691202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221071583295883d, y: 0.046772923029892666d), new NpgsqlTypes.NpgsqlPoint(x: 0.8745157578400572d, y: 0.5287387552807442d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8369996365287423d, y: 0.013356098526984495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363840327041861d, y: 0.8372161948019828d), new NpgsqlTypes.NpgsqlPoint(x: 0.9123617839962795d, y: 0.9771653076194114d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23698494164691353d, y: 0.6278992598644888d), new NpgsqlTypes.NpgsqlPoint(x: 0.9471934647786545d, y: 0.8368745931414683d), new NpgsqlTypes.NpgsqlPoint(x: 0.4752901011746443d, y: 0.29288334909471114d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8049457807201789d, y: 0.7252705806101091d), new NpgsqlTypes.NpgsqlPoint(x: 0.16047735059017243d, y: 0.21992848137935306d), new NpgsqlTypes.NpgsqlPoint(x: 0.1810002810403224d, y: 0.3822696411304769d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021251495198517434d, y: 0.8826902084897973d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188135557537054d, y: 0.8056884322941271d), new NpgsqlTypes.NpgsqlPoint(x: 0.24410479253008666d, y: 0.7819057860998001d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15578211336308012d, y: 0.6418548767085765d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327620411818256d, y: 0.26502691689643154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156766849812065d, y: 0.9209164135288431d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20823218279313405d, y: 0.5613902187972958d), new NpgsqlTypes.NpgsqlPoint(x: 0.00013354198971771147d, y: 0.9523220512438348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8008196157008708d, y: 0.4670456360355777d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18107820432328026d, y: 0.6964083468152655d), new NpgsqlTypes.NpgsqlPoint(x: 0.36588867589644003d, y: 0.9060537856299488d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416131418028605d, y: 0.6033101125655254d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8073202517664686d, y: 0.8897470823430093d), new NpgsqlTypes.NpgsqlPoint(x: 0.20928031876335873d, y: 0.13169319031257554d), new NpgsqlTypes.NpgsqlPoint(x: 0.19048242142333582d, y: 0.25289482921457695d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21376846674316574d, y: 0.014230379614019184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5493546978337891d, y: 0.020176788463737716d), new NpgsqlTypes.NpgsqlPoint(x: 0.41854066984296545d, y: 0.8632534598560635d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34598543931745296d, y: 0.1274966189042236d), new NpgsqlTypes.NpgsqlPoint(x: 0.09536329154725043d, y: 0.45792956054346723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6454254170944805d, y: 0.6116679129642394d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15198631448213917d, y: 0.21448791167655956d), new NpgsqlTypes.NpgsqlPoint(x: 0.6807483241505241d, y: 0.7459304252446759d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971794757745141d, y: 0.1857428294213943d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8358538491670788d, y: 0.9286175195526517d), new NpgsqlTypes.NpgsqlPoint(x: 0.17351358918662207d, y: 0.40852465673420524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485679019003171d, y: 0.14714253629005847d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6662149474087036d, y: 0.5467407452592881d), new NpgsqlTypes.NpgsqlPoint(x: 0.12783017542733122d, y: 0.36437011842807265d), new NpgsqlTypes.NpgsqlPoint(x: 0.14464323009718616d, y: 0.5415146652055185d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6673426090345147d, y: 0.7385600434385975d), new NpgsqlTypes.NpgsqlPoint(x: 0.353308049623281d, y: 0.3262583060157582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6256982910148043d, y: 0.2363509096869315d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.893969514701823d, y: 0.924779942170262d), new NpgsqlTypes.NpgsqlPoint(x: 0.5097494870614048d, y: 0.7149379075279226d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953377687114523d, y: 0.834370263956074d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3347648177977651d, y: 0.9092265565631823d), new NpgsqlTypes.NpgsqlPoint(x: 0.005500486831247708d, y: 0.12997496830691013d), new NpgsqlTypes.NpgsqlPoint(x: 0.39249922179447105d, y: 0.8774387181193737d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8246657040169725d, y: 0.4931418451907079d), new NpgsqlTypes.NpgsqlPoint(x: 0.22205001686827708d, y: 0.19782356305992221d), new NpgsqlTypes.NpgsqlPoint(x: 0.2685499645990944d, y: 0.17219309824868767d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10217731525800633d, y: 0.35333460199436295d), new NpgsqlTypes.NpgsqlPoint(x: 0.634536938886803d, y: 0.8596192697711186d), new NpgsqlTypes.NpgsqlPoint(x: 0.786556820673486d, y: 0.9856811380183931d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5237582143093861d, y: 0.41491207185669665d), new NpgsqlTypes.NpgsqlPoint(x: 0.8879493383552881d, y: 0.9731158618351949d), new NpgsqlTypes.NpgsqlPoint(x: 0.5291426367376094d, y: 0.10605127185509677d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2422366517218787d, y: 0.9937103368407608d), new NpgsqlTypes.NpgsqlPoint(x: 0.2974167116134221d, y: 0.49352970126183093d), new NpgsqlTypes.NpgsqlPoint(x: 0.1626496324715826d, y: 0.20571919999636645d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7619375345454943d, y: 0.4821542855401598d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811733862806904d, y: 0.8428974028463353d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740686504487838d, y: 0.6649197380129778d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.698944216663511d, y: 0.7019098945576948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701680147713601d, y: 0.9995348821162678d), new NpgsqlTypes.NpgsqlPoint(x: 0.18789774047396546d, y: 0.19135852953792942d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4693875516439293d, y: 0.4168619635000912d), new NpgsqlTypes.NpgsqlPoint(x: 0.1747237271165335d, y: 0.10199369828463678d), new NpgsqlTypes.NpgsqlPoint(x: 0.6450343989941867d, y: 0.8954356176008431d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8855194349669925d, y: 0.3316192762006872d), new NpgsqlTypes.NpgsqlPoint(x: 0.800060568887534d, y: 0.23951210118972732d), new NpgsqlTypes.NpgsqlPoint(x: 0.636929788749998d, y: 0.08658852481104318d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2690562873035872d, y: 0.9031406036594148d), new NpgsqlTypes.NpgsqlPoint(x: 0.11966027715360628d, y: 0.9663271596373727d), new NpgsqlTypes.NpgsqlPoint(x: 0.17006957255670352d, y: 0.42105448710726d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09882332414662287d, y: 0.5871716563709245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5689845353859536d, y: 0.42379851310005445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9487498700131354d, y: 0.6140383083356211d)),
},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.427372065847881d, y: 0.8996516029265724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403419775082147d, y: 0.14562620746291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5748158143936015d, y: 0.0371985051248781d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9603779900157255d, y: 0.14811170030367693d), new NpgsqlTypes.NpgsqlPoint(x: 0.49273213658013826d, y: 0.8248868482161076d), new NpgsqlTypes.NpgsqlPoint(x: 0.10644505481855637d, y: 0.261783641723335d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46384873955053196d, y: 0.8472506749214002d), new NpgsqlTypes.NpgsqlPoint(x: 0.915716866770426d, y: 0.23396423686184342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7751884221569869d, y: 0.018479582088032243d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6037292119516228d, y: 0.747847910568708d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305751697045699d, y: 0.35586741568347147d), new NpgsqlTypes.NpgsqlPoint(x: 0.11914957501137402d, y: 0.4043676853758136d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7608087112338746d, y: 0.33202805423947035d), new NpgsqlTypes.NpgsqlPoint(x: 0.48383569671614d, y: 0.4988425620614293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6061840639412774d, y: 0.042704761004001d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7570704137840423d, y: 0.4485501719355195d), new NpgsqlTypes.NpgsqlPoint(x: 0.16097472360520493d, y: 0.30421699184459094d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491291833263481d, y: 0.4833727683995709d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33425694565372477d, y: 0.4210966517039004d), new NpgsqlTypes.NpgsqlPoint(x: 0.43818732759889967d, y: 0.9702251865284683d), new NpgsqlTypes.NpgsqlPoint(x: 0.790031565612352d, y: 0.4331957709878329d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028312987418462332d, y: 0.7380917124316015d), new NpgsqlTypes.NpgsqlPoint(x: 0.10290678831637345d, y: 0.7083173556065512d), new NpgsqlTypes.NpgsqlPoint(x: 0.6853252808291463d, y: 0.33602021574218643d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7018607280911283d, y: 0.805682552052863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8014411181777179d, y: 0.45648784790505514d), new NpgsqlTypes.NpgsqlPoint(x: 0.5616771129389341d, y: 0.8942431416086435d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3967705757121559d, y: 0.915898717908815d), new NpgsqlTypes.NpgsqlPoint(x: 0.15575213281733946d, y: 0.107720120218178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589730866096044d, y: 0.06455136793266558d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0387045829366901d, y: 0.9189553158730668d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523695889085851d, y: 0.19958134411868322d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726064565952732d, y: 0.7734918485104328d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7550325048502007d, y: 0.27489266472358587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3623978808621704d, y: 0.6300110421541256d), new NpgsqlTypes.NpgsqlPoint(x: 0.863797734785275d, y: 0.49933966305273014d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34160697980444543d, y: 0.5815990004514222d), new NpgsqlTypes.NpgsqlPoint(x: 0.47962634004789073d, y: 0.7216587517891059d), new NpgsqlTypes.NpgsqlPoint(x: 0.07585273866720976d, y: 0.3581185142989066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15822360548930758d, y: 0.6634660304952519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3622384777540478d, y: 0.32842140172651224d), new NpgsqlTypes.NpgsqlPoint(x: 0.6073493220002092d, y: 0.1793708881392787d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5866522742623457d, y: 0.39540827009768065d), new NpgsqlTypes.NpgsqlPoint(x: 0.3865379704305929d, y: 0.22579929804014964d), new NpgsqlTypes.NpgsqlPoint(x: 0.34065482022138527d, y: 0.31862008132438635d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9434315858595054d, y: 0.29571048526497057d), new NpgsqlTypes.NpgsqlPoint(x: 0.9237705916520875d, y: 0.030112595061818515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5776273672028744d, y: 0.5113140127957747d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7804484642537309d, y: 0.6607038621057971d), new NpgsqlTypes.NpgsqlPoint(x: 0.8601423073607535d, y: 0.015180693862628658d), new NpgsqlTypes.NpgsqlPoint(x: 0.20462196583112147d, y: 0.4871383295979137d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41539384674789703d, y: 0.8270079804477406d), new NpgsqlTypes.NpgsqlPoint(x: 0.8462835051745262d, y: 0.2930357499069901d), new NpgsqlTypes.NpgsqlPoint(x: 0.1390209270943107d, y: 0.6501339464938408d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11876611013309402d, y: 0.6959896389733372d), new NpgsqlTypes.NpgsqlPoint(x: 0.879525124105522d, y: 0.3397508249516673d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271803193779515d, y: 0.642751559997843d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9688671321175745d, y: 0.22267795221302134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3701368022512247d, y: 0.994423425282944d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636292043690045d, y: 0.9054736686782331d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4678718133427381d, y: 0.23621683647991099d), new NpgsqlTypes.NpgsqlPoint(x: 0.4785870819362795d, y: 0.6766302914294547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7187594871200332d, y: 0.6271603993663238d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6408230940477125d, y: 0.653525015121708d), new NpgsqlTypes.NpgsqlPoint(x: 0.46787111536891224d, y: 0.7401383466034295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887335884059874d, y: 0.06508910303709836d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7268019199345782d, y: 0.11947392309898586d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020641357007577d, y: 0.4692813505575303d), new NpgsqlTypes.NpgsqlPoint(x: 0.1571926808535593d, y: 0.5387444801621761d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2133688449814639d, y: 0.5322727988343108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085467130272834d, y: 0.08350931088488822d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439361593238247d, y: 0.7162809432205144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7642631034675983d, y: 0.2067599559053962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722827679484956d, y: 0.8898933977212867d), new NpgsqlTypes.NpgsqlPoint(x: 0.45422123667170944d, y: 0.6425868409212229d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5311382506724707d, y: 0.47420035778380376d), new NpgsqlTypes.NpgsqlPoint(x: 0.14723003633889842d, y: 0.3944977901911054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2898550829186779d, y: 0.8106857626749948d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7763801860248506d, y: 0.9139879802499515d), new NpgsqlTypes.NpgsqlPoint(x: 0.8000764243017678d, y: 0.8570980849462919d), new NpgsqlTypes.NpgsqlPoint(x: 0.908172389524101d, y: 0.09338719499467829d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21234730940667046d, y: 0.6768553795178983d), new NpgsqlTypes.NpgsqlPoint(x: 0.30684366821438414d, y: 0.1497866881619203d), new NpgsqlTypes.NpgsqlPoint(x: 0.6392543784903032d, y: 0.5884530987112374d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6551563774033982d, y: 0.4490385746297476d), new NpgsqlTypes.NpgsqlPoint(x: 0.14624116872897308d, y: 0.9014242100509697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9613686000225443d, y: 0.040774716260389865d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9782010754771286d, y: 0.3747664941411212d), new NpgsqlTypes.NpgsqlPoint(x: 0.011180585713853608d, y: 0.9994708766962707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7060644400023178d, y: 0.7251778963848758d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20508522007578d, y: 0.4978056109152953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229359666842706d, y: 0.5263003028232932d), new NpgsqlTypes.NpgsqlPoint(x: 0.39826606776702456d, y: 0.49247288824072066d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4893124854713158d, y: 0.683794315169477d), new NpgsqlTypes.NpgsqlPoint(x: 0.36235089264945053d, y: 0.4069095566940567d), new NpgsqlTypes.NpgsqlPoint(x: 0.007278970275095276d, y: 0.7669999687345451d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8931195007473153d, y: 0.05773774033393342d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773119621492236d, y: 0.23018109615524918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5530882069263983d, y: 0.1374076245919843d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19050861626813986d, y: 0.47918058705870936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260854678278813d, y: 0.3002388905333768d), new NpgsqlTypes.NpgsqlPoint(x: 0.4468765818631596d, y: 0.8838124782440636d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.502831988298972d, y: 0.9010468634440197d), new NpgsqlTypes.NpgsqlPoint(x: 0.588915722208658d, y: 0.26941478244830963d), new NpgsqlTypes.NpgsqlPoint(x: 0.15967048931132988d, y: 0.8991830292491894d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2801022462329873d, y: 0.15585732668097219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8107519882378945d, y: 0.6049536099045958d), new NpgsqlTypes.NpgsqlPoint(x: 0.17067391406230814d, y: 0.032849057860699915d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38337130339595027d, y: 0.10347240260547641d), new NpgsqlTypes.NpgsqlPoint(x: 0.831319819309294d, y: 0.12270420544437666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3980376539711238d, y: 0.28582131460302096d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6129538085722088d, y: 0.07137687068880705d), new NpgsqlTypes.NpgsqlPoint(x: 0.6611362252162025d, y: 0.3635794106286304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5175132302324484d, y: 0.20886282258208788d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35290247484920556d, y: 0.25603308984012263d), new NpgsqlTypes.NpgsqlPoint(x: 0.0877508823071581d, y: 0.5597845007328714d), new NpgsqlTypes.NpgsqlPoint(x: 0.19120309492560084d, y: 0.6102021782219302d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8354614249588214d, y: 0.4858996120947171d), new NpgsqlTypes.NpgsqlPoint(x: 0.2722232877099995d, y: 0.5897281341445919d), new NpgsqlTypes.NpgsqlPoint(x: 0.972662839766021d, y: 0.8605522775919081d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.560239025633474d, y: 0.6286465721305148d), new NpgsqlTypes.NpgsqlPoint(x: 0.011553365463488952d, y: 0.2561524055315897d), new NpgsqlTypes.NpgsqlPoint(x: 0.17649943663835876d, y: 0.45802173364672805d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3010962786145702d, y: 0.9900148622197876d), new NpgsqlTypes.NpgsqlPoint(x: 0.016422416127639283d, y: 0.378195634308263d), new NpgsqlTypes.NpgsqlPoint(x: 0.42395853400586925d, y: 0.4895764675154556d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04147817423166855d, y: 0.07957435799130941d), new NpgsqlTypes.NpgsqlPoint(x: 0.01777705540115726d, y: 0.11630606076977879d), new NpgsqlTypes.NpgsqlPoint(x: 0.712584568915598d, y: 0.36907483135059305d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6223553566562007d, y: 0.21102228119806066d), new NpgsqlTypes.NpgsqlPoint(x: 0.9297576184767212d, y: 0.022603398976817513d), new NpgsqlTypes.NpgsqlPoint(x: 0.3998068888220344d, y: 0.48179819344407493d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4101885157439382d, y: 0.05916108619376814d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341531880021017d, y: 0.36566171458655294d), new NpgsqlTypes.NpgsqlPoint(x: 0.013971459744845816d, y: 0.082406911737546d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11639008111480198d, y: 0.7550885334109052d), new NpgsqlTypes.NpgsqlPoint(x: 0.884082574499361d, y: 0.05259173130291517d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094778646208851d, y: 0.49109386684584055d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4430262389361235d, y: 0.24897353635368835d), new NpgsqlTypes.NpgsqlPoint(x: 0.7979029103430882d, y: 0.0025254475778075935d), new NpgsqlTypes.NpgsqlPoint(x: 0.1329212511602641d, y: 0.5460301662959478d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31262087302550046d, y: 0.32337959648700143d), new NpgsqlTypes.NpgsqlPoint(x: 0.34956122410403667d, y: 0.4037436400740396d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501068754250336d, y: 0.6010152591593176d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9519821308078285d, y: 0.6963155583909029d), new NpgsqlTypes.NpgsqlPoint(x: 0.3264796463310403d, y: 0.8472767132722658d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746748200114918d, y: 0.3559365004335484d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41141124761757697d, y: 0.748148544575231d), new NpgsqlTypes.NpgsqlPoint(x: 0.47057169815958844d, y: 0.42153568164975885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9936629709871269d, y: 0.16341502871641922d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31604830878753076d, y: 0.08692682274849439d), new NpgsqlTypes.NpgsqlPoint(x: 0.156255753621938d, y: 0.9700150918402174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738197156097354d, y: 0.06773623220941793d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4121716291156271d, y: 0.3499219888786046d), new NpgsqlTypes.NpgsqlPoint(x: 0.13630852732874055d, y: 0.44780879975460386d), new NpgsqlTypes.NpgsqlPoint(x: 0.40585304511018916d, y: 0.2515504419901705d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45039976587976116d, y: 0.676392898565416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949435680157906d, y: 0.5887023763845963d), new NpgsqlTypes.NpgsqlPoint(x: 0.673245373659055d, y: 0.6197341238362825d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8055195592459194d, y: 0.5517409215460303d), new NpgsqlTypes.NpgsqlPoint(x: 0.084192751394921d, y: 0.4830530326972795d), new NpgsqlTypes.NpgsqlPoint(x: 0.2420645275559581d, y: 0.7974927094462241d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20975425816023396d, y: 0.2489892836191705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968768208022321d, y: 0.184299628446022d), new NpgsqlTypes.NpgsqlPoint(x: 0.9896574258190114d, y: 0.13974420938546628d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15308235627196676d, y: 0.02317244957447928d), new NpgsqlTypes.NpgsqlPoint(x: 0.2946948892809663d, y: 0.62452923164413d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090579371211231d, y: 0.7012364066350786d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8790564108236331d, y: 0.7640099930150981d), new NpgsqlTypes.NpgsqlPoint(x: 0.08280643272364319d, y: 0.9452508464398205d), new NpgsqlTypes.NpgsqlPoint(x: 0.18768813222396574d, y: 0.8775850186596771d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6577344717861802d, y: 0.021402497643943974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6228111209724202d, y: 0.9139315415044733d), new NpgsqlTypes.NpgsqlPoint(x: 0.1475699498997144d, y: 0.2635889640537804d)),
},
},
            new NpgsqlPolygonpolygonArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21559155723177792d, y: 0.6596145363773254d), new NpgsqlTypes.NpgsqlPoint(x: 0.1368491582908401d, y: 0.7740730819052549d), new NpgsqlTypes.NpgsqlPoint(x: 0.04629768869635131d, y: 0.7992268513913661d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8339895039067954d, y: 0.3300900926269247d), new NpgsqlTypes.NpgsqlPoint(x: 0.0547009918756477d, y: 0.8869177196918152d), new NpgsqlTypes.NpgsqlPoint(x: 0.06551497632340164d, y: 0.6854681716195058d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15568177246397685d, y: 0.050230366197272724d), new NpgsqlTypes.NpgsqlPoint(x: 0.22465729883725105d, y: 0.8088111795723562d), new NpgsqlTypes.NpgsqlPoint(x: 0.560351242063193d, y: 0.6235302189061771d)),
},
    ModelInner = new NpgsqlPolygonpolygonArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9237331982812559d, y: 0.43903503567372704d), new NpgsqlTypes.NpgsqlPoint(x: 0.0159287051349154d, y: 0.06504792251236513d), new NpgsqlTypes.NpgsqlPoint(x: 0.30973698453448895d, y: 0.7401479239896633d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.656587608793394d, y: 0.7147110126305286d), new NpgsqlTypes.NpgsqlPoint(x: 0.06954457520941626d, y: 0.9319566716345817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635262907776835d, y: 0.000693352351078147d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8191682029928743d, y: 0.06709860868333617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5945084361564161d, y: 0.6532752626445179d), new NpgsqlTypes.NpgsqlPoint(x: 0.7261421158550543d, y: 0.0011039669428297705d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13337291919580452d, y: 0.40635286449620567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8654308626275726d, y: 0.23880958061889135d), new NpgsqlTypes.NpgsqlPoint(x: 0.10859891038128189d, y: 0.820256515498933d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46847424146491357d, y: 0.8418595798845644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7315385589450334d, y: 0.5257834154322873d), new NpgsqlTypes.NpgsqlPoint(x: 0.758557072585139d, y: 0.2923245216727465d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9298815211408712d, y: 0.3766078025671282d), new NpgsqlTypes.NpgsqlPoint(x: 0.07174718780523248d, y: 0.41613965048508317d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236144152115938d, y: 0.2901169653944061d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.988846119473019d, y: 0.7287650313364343d), new NpgsqlTypes.NpgsqlPoint(x: 0.2988781696002253d, y: 0.827501874737888d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290342085660679d, y: 0.9408710674990852d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
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

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonArraypolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2731995482117321d, y: 0.14675073190236587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6987511647227824d, y: 0.9165861201950408d), new NpgsqlTypes.NpgsqlPoint(x: 0.1827970170567772d, y: 0.9362092190929323d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13283506443042647d, y: 0.744836298095001d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916446460782999d, y: 0.9620471425704584d), new NpgsqlTypes.NpgsqlPoint(x: 0.8124285850136079d, y: 0.5136104519948923d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28390254882966237d, y: 0.32639635413819956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7263183320308655d, y: 0.5421092010426839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4366622277051807d, y: 0.30551039308494565d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
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

                    nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[3]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.030532875026658024d, y: 0.3367966444697431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5805759306726027d, y: 0.9249448176297052d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595603625652123d, y: 0.6557822382100643d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06455086168032975d, y: 0.4246146603622317d), new NpgsqlTypes.NpgsqlPoint(x: 0.35587909045803723d, y: 0.23849217528045563d), new NpgsqlTypes.NpgsqlPoint(x: 0.33055832209706926d, y: 0.07116875236451281d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37794082965198206d, y: 0.07279253859657231d), new NpgsqlTypes.NpgsqlPoint(x: 0.18841831956880017d, y: 0.21111997142737327d), new NpgsqlTypes.NpgsqlPoint(x: 0.137903822134973d, y: 0.20948117215287632d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray1mi_id
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
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453094961185102d, y: 0.8024918086725888d), new NpgsqlTypes.NpgsqlPoint(x: 0.370890693789376d, y: 0.39039182912038506d), new NpgsqlTypes.NpgsqlPoint(x: 0.5226162806109713d, y: 0.1772695103144144d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2794406885003562d, y: 0.5860429637393313d), new NpgsqlTypes.NpgsqlPoint(x: 0.05638975658273748d, y: 0.5426800211346625d), new NpgsqlTypes.NpgsqlPoint(x: 0.7812837654220115d, y: 0.7526363660989324d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4496438154065582d, y: 0.5843467231276306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6576473918544308d, y: 0.564106048883746d), new NpgsqlTypes.NpgsqlPoint(x: 0.36604134743834427d, y: 0.7517043387903797d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2947490610097543d, y: 0.2661666415322417d), new NpgsqlTypes.NpgsqlPoint(x: 0.5944122293271942d, y: 0.7280566926930002d), new NpgsqlTypes.NpgsqlPoint(x: 0.043162808380773576d, y: 0.8277672245729757d)),
}));
                nullable =  ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24008106472091761d, y: 0.4354260595177071d), new NpgsqlTypes.NpgsqlPoint(x: 0.9308774305476805d, y: 0.8362703384144248d), new NpgsqlTypes.NpgsqlPoint(x: 0.40759839986188606d, y: 0.36792774061162015d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7544925816225613d, y: 0.6854688211018225d), new NpgsqlTypes.NpgsqlPoint(x: 0.635297162374937d, y: 0.7814181789209546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7622217948700764d, y: 0.8740486550553167d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7560148446370284d, y: 0.9767493946463324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5591581104929522d, y: 0.7341309043564445d), new NpgsqlTypes.NpgsqlPoint(x: 0.37827311306641764d, y: 0.35624137144045853d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6152201907895996d, y: 0.4784598075720068d), new NpgsqlTypes.NpgsqlPoint(x: 0.03235485186202136d, y: 0.016349362371484655d), new NpgsqlTypes.NpgsqlPoint(x: 0.5493064480504019d, y: 0.12178648820936233d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[] nullable = null;
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonArraypolygonArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[4]
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3383540109112916d, y: 0.0845544141537049d), new NpgsqlTypes.NpgsqlPoint(x: 0.06053749507526063d, y: 0.3654232800101581d), new NpgsqlTypes.NpgsqlPoint(x: 0.5832301842390234d, y: 0.6995557000443734d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.053804349686547126d, y: 0.9962237420084814d), new NpgsqlTypes.NpgsqlPoint(x: 0.7353391826563627d, y: 0.7729349968709616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2715519098759407d, y: 0.13660630815158592d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9114585456272898d, y: 0.008658470270596186d), new NpgsqlTypes.NpgsqlPoint(x: 0.39080979779536584d, y: 0.06386513454270315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3165155259761989d, y: 0.11130440406885422d)),
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22989250761725288d, y: 0.3112807990927131d), new NpgsqlTypes.NpgsqlPoint(x: 0.3288873194624683d, y: 0.48629778011076574d), new NpgsqlTypes.NpgsqlPoint(x: 0.6235294328270425d, y: 0.7622720528415333d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray1M> models = null;

                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonArraypolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await ((INpgsqlPolygonArraypolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 85;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 49;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 16;
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[1], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[2], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 38;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M), typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                await((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray1M>();
                ((INpgsqlPolygonArraypolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 114, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
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
FROM public.npgsqlpolygonpolygonarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 59, query1, 130, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlpolygonpolygonarray1m m
LEFT JOIN public.npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray)),
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
                var models = await((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatchAsync(connection, 102, 7))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[29], false);
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
                var models = ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygonArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonArraypolygonArray)this).DbConnectionSelectModelBatch(connection, 85, 102))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[19], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[20], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[21], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[22], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonArraypolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonArraypolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonArraypolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray1mi mi ON mi.id = m.npgsqlpolygonpolygonarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygonArray1M>(15);

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
                ((INpgsqlPolygonArraypolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonArraypolygonArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonArraypolygonArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonArraypolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygonArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygonArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1M)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray1MI)],
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
            asPartInterface: typeof(INpgsqlPolygonArraypolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonArraypolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonArraypolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

