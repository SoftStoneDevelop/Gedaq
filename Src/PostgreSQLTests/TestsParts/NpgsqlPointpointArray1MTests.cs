

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
    internal partial interface INpgsqlPointArraypointArray
    {
    }
    
    internal partial class NpgsqlPointArraypointArray : INpgsqlPointArraypointArray
    {


#region TestData

        private readonly NpgsqlPointpointArray1M[] _testData = new NpgsqlPointpointArray1M[]
        {
            new NpgsqlPointpointArray1M
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4634400233863135d, y: 0.5857767885748774d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6285289146229842d, y: 0.8356368175548973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14642885918870008d, y: 0.15321192490964597d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16006774879410557d, y: 0.06864581120303215d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6673726201640194d, y: 0.6824715186840924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6176981177854138d, y: 0.34374344210910857d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3644984176637053d, y: 0.4919319942275816d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06318077976069647d, y: 0.8630062776881373d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3750780308666338d, y: 0.2034213587792323d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8885897806530646d, y: 0.5630790277379868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17052162371687019d, y: 0.2573267132966597d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8116741677488787d, y: 0.46757817143829805d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6623330461286897d, y: 0.7596691778192951d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7184082816358759d, y: 0.7212240631854856d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21449956442253437d, y: 0.9569924020937755d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2778194595880763d, y: 0.3577795540015113d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.14653596224818644d, y: 0.77035367505729d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6643289432222212d, y: 0.7984643256679997d),
new NpgsqlTypes.NpgsqlPoint(x: 0.09611532464340189d, y: 0.7029989812441673d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04315358809763148d, y: 0.6103556315188531d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2715667749798103d, y: 0.7735233730215717d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5008920972063771d, y: 0.13122073881890872d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2826920481377123d, y: 0.16677961109900663d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09810971700389959d, y: 0.9713567601557963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6632281049382089d, y: 0.7241085461389285d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24623479177424745d, y: 0.12474526134980324d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5837328021476987d, y: 0.9945426532507986d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7334947134151941d, y: 0.466135634108935d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6844355497804643d, y: 0.7355706695840598d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5290378551877482d, y: 0.4737505429681468d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3924604588173696d, y: 0.6101210238657963d),
new NpgsqlTypes.NpgsqlPoint(x: 0.14509773168907047d, y: 0.19986557478908173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9224121616315895d, y: 0.35164929497607267d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.024033321423432508d, y: 0.6096285623835868d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39750764088750634d, y: 0.42917473941787554d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7704252711631552d, y: 0.228512383510304d),
new NpgsqlTypes.NpgsqlPoint(x: 0.510334536907695d, y: 0.49140338384081417d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3889164944646688d, y: 0.406864286819674d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21793467122515708d, y: 0.07440610278757231d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8267526855800709d, y: 0.9301714246350345d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3799929206827408d, y: 0.4890118011097633d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9205627773187941d, y: 0.26326408182297956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6634499376030273d, y: 0.8967546711944038d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25693922599370944d, y: 0.6552004194107972d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8098427579979612d, y: 0.11634061559213527d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7152295859897299d, y: 0.8174088442727392d),
new NpgsqlTypes.NpgsqlPoint(x: 0.924397294561379d, y: 0.7388566932954961d),
new NpgsqlTypes.NpgsqlPoint(x: 0.826216587483205d, y: 0.7455663147598226d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.16877888446914147d, y: 0.33567531134676d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5116787874258036d, y: 0.4933799037174693d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9436039629749051d, y: 0.8695663835554805d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3980810315237333d, y: 0.04836515260115415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21505739504828714d, y: 0.9978822521233396d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6664095567879781d, y: 0.8968655154368184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45730697603990156d, y: 0.3793029228029037d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06217080144423226d, y: 0.641877758836657d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2878502277288756d, y: 0.5811899638997937d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5082519080736074d, y: 0.2659958842290664d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544225624324793d, y: 0.1994276494446502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5492550077082413d, y: 0.24793774000002888d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8892012348011217d, y: 0.8070016352754001d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8595136632722754d, y: 0.0022416094256626495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6247224795034858d, y: 0.6043217798683973d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24413554884130584d, y: 0.44035868780668774d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5616207551490967d, y: 0.17140945579520706d),
new NpgsqlTypes.NpgsqlPoint(x: 0.40850820332760707d, y: 0.6925291358949516d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13723009860496882d, y: 0.2743782950789897d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6585059483826756d, y: 0.11852001929635259d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.22523543974388105d, y: 0.11917584104070356d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7368025276038785d, y: 0.510529009603731d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7119907401308239d, y: 0.07031675627637413d),
new NpgsqlTypes.NpgsqlPoint(x: 0.24581559024917232d, y: 0.4080922536436925d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.33565371898750573d, y: 0.9428973742101099d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7455816769467286d, y: 0.8498925690357296d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06822502187168d, y: 0.5813973301454074d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8851840477932008d, y: 0.792473291602848d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2597486604583015d, y: 0.12130146046123558d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18229625893957002d, y: 0.6034410628760815d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6206786805234137d, y: 0.5227922366766297d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7777420979354148d, y: 0.2811778834978713d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4748767352312475d, y: 0.08421890392184506d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2886983051500257d, y: 0.15509025038288915d),
new NpgsqlTypes.NpgsqlPoint(x: 0.49428255339525384d, y: 0.8764881610591054d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.648956492780254d, y: 0.0192832787441517d),
new NpgsqlTypes.NpgsqlPoint(x: 0.517949057701399d, y: 0.7829812418507281d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5574013858496321d, y: 0.5468767784800571d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6712045951028109d, y: 0.7938015020879803d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5595814175111368d, y: 0.10026317856330047d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3518837753433668d, y: 0.18918375158181666d),
new NpgsqlTypes.NpgsqlPoint(x: 0.00472617603368175d, y: 0.07528040711665718d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.062236573630072844d, y: 0.3388188701426875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26635074885681886d, y: 0.8009125311621837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7316225924096702d, y: 0.5971070069900368d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04584368597382571d, y: 0.9468633814047349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.20834231284941873d, y: 0.07434610666944408d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5768946810837888d, y: 0.9498670582937639d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2957528312236799d, y: 0.2641667270576189d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5792499669917299d, y: 0.6292974918874177d),
new NpgsqlTypes.NpgsqlPoint(x: 0.35942690389395304d, y: 0.07166901455795682d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9760152987451012d, y: 0.06308049643929148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8660627888590492d, y: 0.5555747546974301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12401014319556891d, y: 0.6987573270345037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4063271687840716d, y: 0.8130771479571478d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7309624218377557d, y: 0.19353767546285094d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9847398589544873d, y: 0.9939034261906806d),
new NpgsqlTypes.NpgsqlPoint(x: 0.11946051363194099d, y: 0.2009466705947739d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5977119767603637d, y: 0.1299009228713186d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6792262994741816d, y: 0.4422872495607494d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3736239713454568d, y: 0.08503208312790211d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8086305630088382d, y: 0.4254677717381373d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3840360461650283d, y: 0.3816264447531863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6613238145255146d, y: 0.07698032391874099d),
new NpgsqlTypes.NpgsqlPoint(x: 0.561516709187266d, y: 0.5399064304299599d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8537956710484486d, y: 0.7340946879624082d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8139279202329592d, y: 0.6519206684943114d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9995800358725272d, y: 0.404888845386732d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.17478427738857671d, y: 0.20377985309885882d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21099741634500602d, y: 0.9592010951641153d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19252003772335347d, y: 0.09972783921696649d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8412104109580688d, y: 0.07634624768389642d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4289244572176498d, y: 0.6991167204866701d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9104674096514994d, y: 0.8269145355904622d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9333305393480303d, y: 0.8737293039269045d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4458039737580244d, y: 0.7603972425619072d),
new NpgsqlTypes.NpgsqlPoint(x: 0.16601063484992284d, y: 0.5561089391708803d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1934140459209054d, y: 0.22900440864192062d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.18210768762168905d, y: 0.7320432747485994d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7865998177770026d, y: 0.4610985863620618d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6309817790391338d, y: 0.8731478806126822d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47037800596248824d, y: 0.5365133759828098d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8426220241370472d, y: 0.3345769816395101d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38715055667981924d, y: 0.6313587623960467d),
new NpgsqlTypes.NpgsqlPoint(x: 0.08883624016148806d, y: 0.7468301168551065d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.09494205062066507d, y: 0.28170983023661555d),
new NpgsqlTypes.NpgsqlPoint(x: 0.980242032041982d, y: 0.8953203292453832d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15522299207225077d, y: 0.7186258968674278d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5893834386079376d, y: 0.8932348167076651d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5069488767838353d, y: 0.01842116484626455d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4429008695676834d, y: 0.507849991997029d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4344846044971833d, y: 0.9462880356557509d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9158473044710054d, y: 0.4236306577838085d),
new NpgsqlTypes.NpgsqlPoint(x: 0.03115905037918354d, y: 0.766057043671329d),
new NpgsqlTypes.NpgsqlPoint(x: 0.47514765705264983d, y: 0.24353052227171945d),
},
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4786927838408457d, y: 0.5429558308093381d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7022215001720977d, y: 0.6182335544993363d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3587969765501886d, y: 0.32857583382736144d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6823112127244986d, y: 0.4913036197512888d),
new NpgsqlTypes.NpgsqlPoint(x: 0.615899111015697d, y: 0.5119281443900475d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2826574657760277d, y: 0.8678244421386644d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5682637296017948d, y: 0.6448197060200759d),
new NpgsqlTypes.NpgsqlPoint(x: 0.13662196261826032d, y: 0.0331973317042622d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9615198017214935d, y: 0.3409950764484375d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7616623017674483d, y: 0.5341005494077739d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.06931517908721752d, y: 0.8109132589829091d),
new NpgsqlTypes.NpgsqlPoint(x: 0.44265580446592745d, y: 0.3791100039817924d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7879874418126837d, y: 0.437565538491424d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6652625146211741d, y: 0.06192271444759068d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9514403313776707d, y: 0.8582465192719169d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8845496263412242d, y: 0.28122105345046133d),
new NpgsqlTypes.NpgsqlPoint(x: 0.983223678051098d, y: 0.9390963894883844d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5293594804640128d, y: 0.3722808898105482d),
new NpgsqlTypes.NpgsqlPoint(x: 0.64331349643859d, y: 0.30228698340880966d),
new NpgsqlTypes.NpgsqlPoint(x: 0.17275792191994566d, y: 0.40997740659150617d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5417057075184827d, y: 0.7484445141766716d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5268545123859507d, y: 0.31406208549212833d),
new NpgsqlTypes.NpgsqlPoint(x: 0.18801653093619686d, y: 0.39988733592131354d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9348672553394654d, y: 0.34424111953354464d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.04564407737757059d, y: 0.7571973855260794d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5820924839748264d, y: 0.06602161444861698d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3670538115368528d, y: 0.45582958736023116d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8967910548621846d, y: 0.3148503887141846d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8753293252466161d, y: 0.3909223683304863d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9992049048909349d, y: 0.6575477913837033d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4776972951022014d, y: 0.8332462618392542d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.6925922381197291d, y: 0.1959033441121948d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6888032036878597d, y: 0.12011211850200587d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9517660031299927d, y: 0.3274094453130285d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.876304911799684d, y: 0.5886318740812275d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7489363455012157d, y: 0.7633283514638584d),
new NpgsqlTypes.NpgsqlPoint(x: 0.940276826616063d, y: 0.7586834382110575d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5262945126458995d, y: 0.520445199794585d),
new NpgsqlTypes.NpgsqlPoint(x: 0.04170703652878904d, y: 0.5780462445089107d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6531231889120008d, y: 0.7426593060935955d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.4356147106727243d, y: 0.5451091830107269d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6073573760998793d, y: 0.4151208347559381d),
new NpgsqlTypes.NpgsqlPoint(x: 0.33229768587367237d, y: 0.3640572310786826d),
new NpgsqlTypes.NpgsqlPoint(x: 0.2737847348543332d, y: 0.17064874536764163d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.0016630311459221447d, y: 0.8013476938882286d),
new NpgsqlTypes.NpgsqlPoint(x: 0.41894399207370925d, y: 0.8186635698632699d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5931789147022435d, y: 0.7802254886154977d),
new NpgsqlTypes.NpgsqlPoint(x: 0.32834674205019954d, y: 0.13553707687725314d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5670021084525081d, y: 0.13259446158645094d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5535774492242941d, y: 0.07289207610956139d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4658958971522874d, y: 0.38285979079420573d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7742662304480226d, y: 0.6633518733759769d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.38968111654710524d, y: 0.8541271485405907d),
new NpgsqlTypes.NpgsqlPoint(x: 0.1455975480614724d, y: 0.6512000776504809d),
new NpgsqlTypes.NpgsqlPoint(x: 0.3343323025343855d, y: 0.7573497007182891d),
new NpgsqlTypes.NpgsqlPoint(x: 0.922921170040914d, y: 0.7005903690026156d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 138,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.846624610133849d, y: 0.05258428701749118d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4744947051801125d, y: 0.4783894257919148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.06981812487586114d, y: 0.8756513203924046d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.2660762372753457d, y: 0.7999158119301384d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6475021253741431d, y: 0.8127769683837255d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4723995732572084d, y: 0.26000595299524765d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8333404384689382d, y: 0.6250707115943619d),
new NpgsqlTypes.NpgsqlPoint(x: 0.39426208073674696d, y: 0.21825838487167704d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4574127602826873d, y: 0.5647556470737984d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7582291289933196d, y: 0.5608675205365106d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8532589055728435d, y: 0.5767704888683378d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9065587189180749d, y: 0.6091180910392124d),
new NpgsqlTypes.NpgsqlPoint(x: 0.38197673031635526d, y: 0.6442036013875029d),
new NpgsqlTypes.NpgsqlPoint(x: 0.960918506308221d, y: 0.5001357581773404d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.10109794773637759d, y: 0.7395925589228596d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6463174606983944d, y: 0.49815084365986173d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6183008917717252d, y: 0.957106790007389d),
new NpgsqlTypes.NpgsqlPoint(x: 0.29912401258655186d, y: 0.26643697552233414d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.47378926352211936d, y: 0.6028736789496638d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9149336775976878d, y: 0.8113937763059604d),
new NpgsqlTypes.NpgsqlPoint(x: 0.19119201919206663d, y: 0.46849622034450145d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8566450103811287d, y: 0.3909515828212785d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6349783395663361d, y: 0.9592886966075349d),
new NpgsqlTypes.NpgsqlPoint(x: 0.15749524377233803d, y: 0.29000505720920056d),
},
},
            new NpgsqlPointpointArray1M
{
    Id = 153,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.7143287371932646d, y: 0.3292739612161715d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6625270999701955d, y: 0.9258377168773495d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5010413195654286d, y: 0.46800300361004454d),
new NpgsqlTypes.NpgsqlPoint(x: 0.865208396415842d, y: 0.04490159847848718d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointArray1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.8108304802747814d, y: 0.9511212918179452d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6307942071385715d, y: 0.16709005127868337d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5553970214592345d, y: 0.12451482322512575d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9710860396747587d, y: 0.5731754584467762d),
},
    ModelInner = new NpgsqlPointpointArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3072915637546292d, y: 0.54806842873425d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6203360304397758d, y: 0.6458270925010061d),
new NpgsqlTypes.NpgsqlPoint(x: 0.007736289178085443d, y: 0.7192222678801268d),
new NpgsqlTypes.NpgsqlPoint(x: 0.9436564484412346d, y: 0.7937435610203217d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.11680108003092182d, y: 0.22618589207120932d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8410597332531821d, y: 0.6741295508460458d),
new NpgsqlTypes.NpgsqlPoint(x: 0.37602692001168236d, y: 0.13605283474517849d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
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

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointArraypointArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointArraypointArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointArraypointArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointArraypointArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9205627773187941d, y: 0.26326408182297956d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6634499376030273d, y: 0.8967546711944038d),
new NpgsqlTypes.NpgsqlPoint(x: 0.25693922599370944d, y: 0.6552004194107972d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.3980810315237333d, y: 0.04836515260115415d),
new NpgsqlTypes.NpgsqlPoint(x: 0.21505739504828714d, y: 0.9978822521233396d),
new NpgsqlTypes.NpgsqlPoint(x: 0.6664095567879781d, y: 0.8968655154368184d),
new NpgsqlTypes.NpgsqlPoint(x: 0.45730697603990156d, y: 0.3793029228029037d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.5544225624324793d, y: 0.1994276494446502d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5492550077082413d, y: 0.24793774000002888d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8892012348011217d, y: 0.8070016352754001d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
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

                    nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointarray1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointarray1mi_id
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
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointarray1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.648956492780254d, y: 0.0192832787441517d),
new NpgsqlTypes.NpgsqlPoint(x: 0.517949057701399d, y: 0.7829812418507281d),
new NpgsqlTypes.NpgsqlPoint(x: 0.5574013858496321d, y: 0.5468767784800571d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[] nullable = null;
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[3]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.062236573630072844d, y: 0.3388188701426875d),
new NpgsqlTypes.NpgsqlPoint(x: 0.26635074885681886d, y: 0.8009125311621837d),
new NpgsqlTypes.NpgsqlPoint(x: 0.7316225924096702d, y: 0.5971070069900368d),
}));
                nullable = await ((INpgsqlPointArraypointArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[4]
{
new NpgsqlTypes.NpgsqlPoint(x: 0.9760152987451012d, y: 0.06308049643929148d),
new NpgsqlTypes.NpgsqlPoint(x: 0.8660627888590492d, y: 0.5555747546974301d),
new NpgsqlTypes.NpgsqlPoint(x: 0.12401014319556891d, y: 0.6987573270345037d),
new NpgsqlTypes.NpgsqlPoint(x: 0.4063271687840716d, y: 0.8130771479571478d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointArraypointArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointArray1M> models = null;

                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointArraypointArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointArraypointArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointArraypointArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await ((INpgsqlPointArraypointArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointArraypointArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 20;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
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
                parametr2.Value = 121;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 7;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 130;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 15;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 121;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 15;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[25],_testData[29], false);
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
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 138;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
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
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M), typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                await((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 81, query1, 76, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[29], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointArray1M>();
                var models2 = new List<FlatNpgsqlPointpointArray1M>();
                ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 138, query1, 28, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 59, query1, 144, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 112, query1, 88, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                await ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 7, query1, 96, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[30], false);
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
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
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 105, query1, 20, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPointpointArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(models[24],_testData[29], false);
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
                int resultIndex = 0;
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointarray1m m
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
FROM public.npgsqlpointpointarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointArray1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointArray1M>();
                 ((INpgsqlPointArraypointArray)this).DbConnectionDynQuerySelectModelBatch(connection, 55, query1, 20, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(firstItems1[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlPointpointArray1M.AssertModel(secondItems2[24],_testData[30], false);
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
FROM public.npgsqlpointpointarray1m m
LEFT JOIN public.npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
            asPartInterface: typeof(INpgsqlPointArraypointArray)),
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
                var models = await((INpgsqlPointArraypointArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatchAsync(connection, 103, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[15],_testData[29], false);
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
                var models = ((INpgsqlPointArraypointArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPointpointArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointArraypointArray)this).DbConnectionSTSelectModelBatch(connection, 96, 96))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPointpointArray1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlPointpointArray1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlPointpointArray1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlPointpointArray1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlPointpointArray1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlPointpointArray1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlPointpointArray1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlPointpointArray1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlPointpointArray1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlPointpointArray1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlPointpointArray1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlPointpointArray1M.AssertModel(models[11],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models = await ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[2], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[3], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[4], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[5], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[6], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[23],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[24],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[25],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[26],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[27],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointArraypointArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointArraypointArray)this).SetDbConnectionSelectModelParametrs(cmd, 37);
                var models =  ((INpgsqlPointArraypointArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPointpointArray1M.AssertModel(models[0],_testData[7], false);NpgsqlPointpointArray1M.AssertModel(models[1],_testData[8], false);NpgsqlPointpointArray1M.AssertModel(models[2],_testData[9], false);NpgsqlPointpointArray1M.AssertModel(models[3],_testData[10], false);NpgsqlPointpointArray1M.AssertModel(models[4],_testData[11], false);NpgsqlPointpointArray1M.AssertModel(models[5],_testData[12], false);NpgsqlPointpointArray1M.AssertModel(models[6],_testData[13], false);NpgsqlPointpointArray1M.AssertModel(models[7],_testData[14], false);NpgsqlPointpointArray1M.AssertModel(models[8],_testData[15], false);NpgsqlPointpointArray1M.AssertModel(models[9],_testData[16], false);NpgsqlPointpointArray1M.AssertModel(models[10],_testData[17], false);NpgsqlPointpointArray1M.AssertModel(models[11],_testData[18], false);NpgsqlPointpointArray1M.AssertModel(models[12],_testData[19], false);NpgsqlPointpointArray1M.AssertModel(models[13],_testData[20], false);NpgsqlPointpointArray1M.AssertModel(models[14],_testData[21], false);NpgsqlPointpointArray1M.AssertModel(models[15],_testData[22], false);NpgsqlPointpointArray1M.AssertModel(models[16],_testData[23], false);NpgsqlPointpointArray1M.AssertModel(models[17],_testData[24], false);NpgsqlPointpointArray1M.AssertModel(models[18],_testData[25], false);NpgsqlPointpointArray1M.AssertModel(models[19],_testData[26], false);NpgsqlPointpointArray1M.AssertModel(models[20],_testData[27], false);NpgsqlPointpointArray1M.AssertModel(models[21],_testData[28], false);NpgsqlPointpointArray1M.AssertModel(models[22],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPointArraypointArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
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
FROM public.binary_npgsqlpointpointarray1m m
LEFT JOIN public.binary_npgsqlpointpointarray1mi mi ON mi.id = m.npgsqlpointpointarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPointpointArray1M>(15);

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
                ((INpgsqlPointArraypointArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointArraypointArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPointArraypointArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPointArraypointArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPointpointArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPointpointArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPointpointArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPointpointArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPointpointArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPointpointArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPointpointArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPointpointArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPointpointArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPointpointArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPointpointArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPointpointArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPointpointArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPointpointArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPointpointArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPointpointArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPointpointArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPointpointArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPointpointArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPointpointArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPointpointArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPointpointArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPointpointArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPointpointArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPointpointArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPointpointArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPointpointArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPointpointArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPointpointArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPointpointArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointArray1M)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointArray1MI)],
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
            asPartInterface: typeof(INpgsqlPointArraypointArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPointArraypointArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointArraypointArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

