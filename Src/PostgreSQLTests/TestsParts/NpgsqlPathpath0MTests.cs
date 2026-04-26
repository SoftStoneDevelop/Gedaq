

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 8,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2189227495567111d, y: 0.7953645502997058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964069223019759d, y: 0.9702037127114762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446134373343732d, y: 0.05917405765184036d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09942203643626013d, y: 0.4396035441005738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117817753357166d, y: 0.581066551330822d), new NpgsqlTypes.NpgsqlPoint(x: 0.09046531163295723d, y: 0.22484882123816852d)),
},
            new NpgsqlPathpath0M
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35235366165477733d, y: 0.4800224037201507d), new NpgsqlTypes.NpgsqlPoint(x: 0.12454096717983532d, y: 0.6047817206038547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776670870933129d, y: 0.20558246572333716d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8753744599023471d, y: 0.9278805505130364d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968177581937916d, y: 0.29523070292011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054845372147944d, y: 0.26434744177064096d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51998200069598d, y: 0.5613694512892544d), new NpgsqlTypes.NpgsqlPoint(x: 0.23999284438958102d, y: 0.29010418204460253d), new NpgsqlTypes.NpgsqlPoint(x: 0.014410660696045796d, y: 0.15347071364656495d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267500061477756d, y: 0.3162931707725525d), new NpgsqlTypes.NpgsqlPoint(x: 0.15370636422618067d, y: 0.5196589748187531d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826434854372153d, y: 0.09928925587987125d)),
},
            new NpgsqlPathpath0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7742276254272494d, y: 0.9469746272908941d), new NpgsqlTypes.NpgsqlPoint(x: 0.994330888464615d, y: 0.2547261987234557d), new NpgsqlTypes.NpgsqlPoint(x: 0.39903182245247026d, y: 0.555132955619006d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 30,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769595946958287d, y: 0.7503656094549572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696280270739027d, y: 0.7847506928883194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408020021786591d, y: 0.999482343480459d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 4,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2982055038751137d, y: 0.4883470112951178d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774274087545078d, y: 0.21976837265514804d), new NpgsqlTypes.NpgsqlPoint(x: 0.12655590305280218d, y: 0.5734209853984238d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6647109107541981d, y: 0.6141241270825976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855808978917994d, y: 0.7782825933273981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526807443821085d, y: 0.03312355261236899d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26990379344577264d, y: 0.19373694591545132d), new NpgsqlTypes.NpgsqlPoint(x: 0.02788918744227198d, y: 0.8255260732467798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016368456066477d, y: 0.6552148560709737d)),
},
            new NpgsqlPathpath0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144830795855961d, y: 0.654024925260595d), new NpgsqlTypes.NpgsqlPoint(x: 0.07151039136004111d, y: 0.6780583704929974d), new NpgsqlTypes.NpgsqlPoint(x: 0.21923961120003232d, y: 0.0891513141119411d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45427788323747853d, y: 0.9809762233341147d), new NpgsqlTypes.NpgsqlPoint(x: 0.11170472747136484d, y: 0.8523829991375342d), new NpgsqlTypes.NpgsqlPoint(x: 0.16673907233910334d, y: 0.03330418975323124d)),
},
            new NpgsqlPathpath0M
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48301210443300246d, y: 0.5953583233120174d), new NpgsqlTypes.NpgsqlPoint(x: 0.045698123049121575d, y: 0.1890325646039711d), new NpgsqlTypes.NpgsqlPoint(x: 0.10770205180684977d, y: 0.12381096292937388d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2520179949331556d, y: 0.1766294144861742d), new NpgsqlTypes.NpgsqlPoint(x: 0.10673558970514108d, y: 0.9603128122335248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2884249552324789d, y: 0.6661069174407435d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10149037000586714d, y: 0.2539768729780746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828624926732541d, y: 0.12301818795436892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535424200075816d, y: 0.36603975119351184d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 47,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8309386708281992d, y: 0.31961973914922037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166078220414075d, y: 0.36691686861332085d), new NpgsqlTypes.NpgsqlPoint(x: 0.18706798910115952d, y: 0.3847985801286036d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25272172080529964d, y: 0.2841143894332411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646492855103149d, y: 0.49105137649956854d), new NpgsqlTypes.NpgsqlPoint(x: 0.49369794618811036d, y: 0.98161667918157d)),
},
            new NpgsqlPathpath0M
{
    Id = 56,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4725909346798387d, y: 0.9187842077242787d), new NpgsqlTypes.NpgsqlPoint(x: 0.47702557408568d, y: 0.8511148516405151d), new NpgsqlTypes.NpgsqlPoint(x: 0.22759881631160472d, y: 0.976505039781374d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799905297372835d, y: 0.03578667580331185d), new NpgsqlTypes.NpgsqlPoint(x: 0.05729734311778467d, y: 0.48462205454384244d), new NpgsqlTypes.NpgsqlPoint(x: 0.843040544875481d, y: 0.6985302960425436d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603652972071596d, y: 0.3012218572009018d), new NpgsqlTypes.NpgsqlPoint(x: 0.14467240787226d, y: 0.5360141987702431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470183452468408d, y: 0.7801356040732268d)),
},
            new NpgsqlPathpath0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3271639897530574d, y: 0.4189534277636101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359605405393844d, y: 0.8325422673169907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341231604444228d, y: 0.5834049551626248d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 69,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7821419951949851d, y: 0.5074761026511777d), new NpgsqlTypes.NpgsqlPoint(x: 0.27535783904715605d, y: 0.5003797286441106d), new NpgsqlTypes.NpgsqlPoint(x: 0.14777808106647017d, y: 0.10198566126591224d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4796602938278838d, y: 0.4681611484364979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380228561262578d, y: 0.2886970779378324d), new NpgsqlTypes.NpgsqlPoint(x: 0.18165109328422158d, y: 0.363826734640066d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42955811114475495d, y: 0.22511338048370433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986912684827678d, y: 0.2049067121349879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3349854704639268d, y: 0.25799307385663994d)),
},
            new NpgsqlPathpath0M
{
    Id = 77,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149227462871196d, y: 0.6649264313298537d), new NpgsqlTypes.NpgsqlPoint(x: 0.19322893745870884d, y: 0.8200440734348876d), new NpgsqlTypes.NpgsqlPoint(x: 0.28600312823776797d, y: 0.2869776908389656d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004980543699430573d, y: 0.3967343551850333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617846981991705d, y: 0.06271424621463706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232945565520461d, y: 0.8069923477508439d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 35,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109437651493808d, y: 0.9942060378718481d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675106434457435d, y: 0.2699866394336651d), new NpgsqlTypes.NpgsqlPoint(x: 0.12489627758136324d, y: 0.6540242840346888d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9235484314613535d, y: 0.08779729168683659d), new NpgsqlTypes.NpgsqlPoint(x: 0.19254093510550208d, y: 0.5383833570907887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12582654962126494d, y: 0.06378105345254181d)),
},
            new NpgsqlPathpath0M
{
    Id = 88,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1271884447212165d, y: 0.4741657745990411d), new NpgsqlTypes.NpgsqlPoint(x: 0.41831605393000937d, y: 0.5432170090444595d), new NpgsqlTypes.NpgsqlPoint(x: 0.46485191215357924d, y: 0.3542839034287594d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 91,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5271762043642606d, y: 0.009538732988901288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723887906873063d, y: 0.1266847052426695d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573418547507628d, y: 0.0060039643584341995d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13179138807449853d, y: 0.9893471148130966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668986203135748d, y: 0.09239031776567852d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517770158971484d, y: 0.26549335111317574d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7862511217202373d, y: 0.7061997322981216d), new NpgsqlTypes.NpgsqlPoint(x: 0.19352406302727898d, y: 0.1517005568719043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374821409883827d, y: 0.9561844125441902d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9445350110454052d, y: 0.874049006012129d), new NpgsqlTypes.NpgsqlPoint(x: 0.523644761697069d, y: 0.2801753136875367d), new NpgsqlTypes.NpgsqlPoint(x: 0.17134383242957252d, y: 0.6211309038309809d)),
},
            new NpgsqlPathpath0M
{
    Id = 93,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644953895820004d, y: 0.708564412018665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4690768767755298d, y: 0.21379018697465657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605155319527363d, y: 0.31425848245608445d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5128802824828923d, y: 0.12776311645675198d), new NpgsqlTypes.NpgsqlPoint(x: 0.23237015929711025d, y: 0.9305410463500695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983225285756291d, y: 0.17646733603994658d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22026115739127117d, y: 0.37986854922571756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237424053869747d, y: 0.574299735625904d), new NpgsqlTypes.NpgsqlPoint(x: 0.032201458485206946d, y: 0.8115326979729651d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4758846329851648d, y: 0.11502493089857646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3338186428002905d, y: 0.47246355119361083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05055655314608254d, y: 0.7907849177700481d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 102,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48735549058302463d, y: 0.4079138396730505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904056404251869d, y: 0.31580522729619454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638481719900568d, y: 0.9775566725812868d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15107964933093188d, y: 0.2655916062112461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797511839292623d, y: 0.7517614838099033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544480984269417d, y: 0.936606224128484d)),
},
            new NpgsqlPathpath0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5330510876596817d, y: 0.8972763540957318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707426474834403d, y: 0.93972972065625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058025954717935d, y: 0.45904681533184655d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 43,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21605175415556133d, y: 0.4221591497236521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669405591530945d, y: 0.5215306261171658d), new NpgsqlTypes.NpgsqlPoint(x: 0.1106152276860003d, y: 0.07864032140274857d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5154277641383327d, y: 0.4053066112059073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096716804398995d, y: 0.731856243291637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8037501680995489d, y: 0.6519603651201641d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1834106405564424d, y: 0.3039518080692556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772769680652043d, y: 0.1176989672202261d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549556690334854d, y: 0.5884758009812651d)),
},
            new NpgsqlPathpath0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9892759919358696d, y: 0.06024481856177266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987029071833638d, y: 0.6843673487210349d), new NpgsqlTypes.NpgsqlPoint(x: 0.15452228397868817d, y: 0.2438310511069619d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 45,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7012506941238211d, y: 0.9583589884892046d), new NpgsqlTypes.NpgsqlPoint(x: 0.566848761493783d, y: 0.20014293211075596d), new NpgsqlTypes.NpgsqlPoint(x: 0.265759060807076d, y: 0.9756671502154494d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061061518149287286d, y: 0.5760704423862878d), new NpgsqlTypes.NpgsqlPoint(x: 0.28003194730207426d, y: 0.6460551384392724d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273832451273143d, y: 0.636114908879662d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042799525657353d, y: 0.5791196989967886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163144222028568d, y: 0.4595807487440522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393599555966017d, y: 0.4084499114975688d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3320420993543747d, y: 0.42144180162699296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445176254986651d, y: 0.45415182987819636d), new NpgsqlTypes.NpgsqlPoint(x: 0.37729113539948456d, y: 0.26864730660789526d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03909828987499353d, y: 0.4800253927437279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640264935261912d, y: 0.05959922389985939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2566780832043327d, y: 0.32983367283563336d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2843719079664646d, y: 0.7927850597923253d), new NpgsqlTypes.NpgsqlPoint(x: 0.19101655411056495d, y: 0.10004958629403637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313974548545494d, y: 0.07593421071211237d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3185415102402017d, y: 0.37084226332100323d), new NpgsqlTypes.NpgsqlPoint(x: 0.509671151294685d, y: 0.8183744327646559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437653824929834d, y: 0.7137072585164388d)),
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14398846988528047d, y: 0.6148670561568224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349266766457501d, y: 0.41521140844279214d), new NpgsqlTypes.NpgsqlPoint(x: 0.43766351691884187d, y: 0.8406757224940902d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2330658724196557d, y: 0.5940424916035113d), new NpgsqlTypes.NpgsqlPoint(x: 0.32443905797150796d, y: 0.9229961063047712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068596818376021d, y: 0.463671930924084d)),
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6435476409128427d, y: 0.9459893721899224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973440307546856d, y: 0.9961889176739951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895053302425396d, y: 0.6184941678226201d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9197749050155641d, y: 0.6436562955230933d), new NpgsqlTypes.NpgsqlPoint(x: 0.24578845986334297d, y: 0.7500142896944455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467052104865955d, y: 0.39760627887851907d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 137,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048168888319043646d, y: 0.00978292707316053d), new NpgsqlTypes.NpgsqlPoint(x: 0.019865628298156413d, y: 0.21507066253004847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988090629494766d, y: 0.06317040131951046d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8222596510925003d, y: 0.6603431811448217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112384910983567d, y: 0.11044955132293743d), new NpgsqlTypes.NpgsqlPoint(x: 0.2433306580846314d, y: 0.1386722360300724d)),
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24622089613177534d, y: 0.37694946647988603d), new NpgsqlTypes.NpgsqlPoint(x: 0.16710651789785003d, y: 0.7663586414371911d), new NpgsqlTypes.NpgsqlPoint(x: 0.39534190922770973d, y: 0.044168043145480396d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 52,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39486583638858685d, y: 0.08630885692584689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2407106293291844d, y: 0.768361657753647d), new NpgsqlTypes.NpgsqlPoint(x: 0.48266732434378556d, y: 0.06512443016091485d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022288403092467d, y: 0.2847986322099507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810966377425964d, y: 0.2481587869551547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244314438375259d, y: 0.44810805621400085d)),
},
            new NpgsqlPathpath0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8911161535688619d, y: 0.03050290573777603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818545983077867d, y: 0.5134041614010146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617681291033239d, y: 0.41478797879653195d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02005691682781463d, y: 0.3995234258048973d), new NpgsqlTypes.NpgsqlPoint(x: 0.19075794153291992d, y: 0.6596686716986664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278202959231755d, y: 0.024477165490353392d)),
},
            new NpgsqlPathpath0M
{
    Id = 153,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3119317240106658d, y: 0.9063965154884641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934870123269425d, y: 0.12980594787561361d), new NpgsqlTypes.NpgsqlPoint(x: 0.09811237721654897d, y: 0.5782963624577454d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597862307447919d, y: 0.38611728163617587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234063835590409d, y: 0.5264343550627133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25223247667726445d, y: 0.766238247277753d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 158,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16377536995641317d, y: 0.3673534681149929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870272124760802d, y: 0.4980936345113365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280907947841662d, y: 0.18000885161564062d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 165,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088980975212303d, y: 0.712100963910764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242497897581768d, y: 0.6478739603575036d), new NpgsqlTypes.NpgsqlPoint(x: 0.17183278789662848d, y: 0.7126853301033473d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 62,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590964512754704d, y: 0.15216109240569642d), new NpgsqlTypes.NpgsqlPoint(x: 0.30213770978533816d, y: 0.24463516163043197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673321661885494d, y: 0.6372125098894159d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395669946396211d, y: 0.11584921667075565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355575105554963d, y: 0.2041480747302803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7715291972590211d, y: 0.8624188147075346d)),
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45427788323747853d, y: 0.9809762233341147d), new NpgsqlTypes.NpgsqlPoint(x: 0.11170472747136484d, y: 0.8523829991375342d), new NpgsqlTypes.NpgsqlPoint(x: 0.16673907233910334d, y: 0.03330418975323124d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25272172080529964d, y: 0.2841143894332411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646492855103149d, y: 0.49105137649956854d), new NpgsqlTypes.NpgsqlPoint(x: 0.49369794618811036d, y: 0.98161667918157d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603652972071596d, y: 0.3012218572009018d), new NpgsqlTypes.NpgsqlPoint(x: 0.14467240787226d, y: 0.5360141987702431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470183452468408d, y: 0.7801356040732268d))));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42955811114475495d, y: 0.22511338048370433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986912684827678d, y: 0.2049067121349879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3349854704639268d, y: 0.25799307385663994d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9235484314613535d, y: 0.08779729168683659d), new NpgsqlTypes.NpgsqlPoint(x: 0.19254093510550208d, y: 0.5383833570907887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12582654962126494d, y: 0.06378105345254181d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 141;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 69;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 108;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPathpath0M.AssertModel(models[0],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 17;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 21, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 153, query1, 77, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatchAsync(connection, 77, 93))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatch(connection, 39, 114))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlPathpath0M.AssertModel(models[0],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 47);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));
NpgsqlPathpath0M.AssertModel(models[0],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 106);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPathpath0M.AssertModel(models[0],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2189227495567111d, y: 0.7953645502997058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964069223019759d, y: 0.9702037127114762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446134373343732d, y: 0.05917405765184036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09942203643626013d, y: 0.4396035441005738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117817753357166d, y: 0.581066551330822d), new NpgsqlTypes.NpgsqlPoint(x: 0.09046531163295723d, y: 0.22484882123816852d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35235366165477733d, y: 0.4800224037201507d), new NpgsqlTypes.NpgsqlPoint(x: 0.12454096717983532d, y: 0.6047817206038547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776670870933129d, y: 0.20558246572333716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8753744599023471d, y: 0.9278805505130364d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968177581937916d, y: 0.29523070292011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054845372147944d, y: 0.26434744177064096d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51998200069598d, y: 0.5613694512892544d), new NpgsqlTypes.NpgsqlPoint(x: 0.23999284438958102d, y: 0.29010418204460253d), new NpgsqlTypes.NpgsqlPoint(x: 0.014410660696045796d, y: 0.15347071364656495d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267500061477756d, y: 0.3162931707725525d), new NpgsqlTypes.NpgsqlPoint(x: 0.15370636422618067d, y: 0.5196589748187531d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826434854372153d, y: 0.09928925587987125d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7742276254272494d, y: 0.9469746272908941d), new NpgsqlTypes.NpgsqlPoint(x: 0.994330888464615d, y: 0.2547261987234557d), new NpgsqlTypes.NpgsqlPoint(x: 0.39903182245247026d, y: 0.555132955619006d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769595946958287d, y: 0.7503656094549572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696280270739027d, y: 0.7847506928883194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408020021786591d, y: 0.999482343480459d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2982055038751137d, y: 0.4883470112951178d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774274087545078d, y: 0.21976837265514804d), new NpgsqlTypes.NpgsqlPoint(x: 0.12655590305280218d, y: 0.5734209853984238d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6647109107541981d, y: 0.6141241270825976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855808978917994d, y: 0.7782825933273981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526807443821085d, y: 0.03312355261236899d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26990379344577264d, y: 0.19373694591545132d), new NpgsqlTypes.NpgsqlPoint(x: 0.02788918744227198d, y: 0.8255260732467798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016368456066477d, y: 0.6552148560709737d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144830795855961d, y: 0.654024925260595d), new NpgsqlTypes.NpgsqlPoint(x: 0.07151039136004111d, y: 0.6780583704929974d), new NpgsqlTypes.NpgsqlPoint(x: 0.21923961120003232d, y: 0.0891513141119411d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45427788323747853d, y: 0.9809762233341147d), new NpgsqlTypes.NpgsqlPoint(x: 0.11170472747136484d, y: 0.8523829991375342d), new NpgsqlTypes.NpgsqlPoint(x: 0.16673907233910334d, y: 0.03330418975323124d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48301210443300246d, y: 0.5953583233120174d), new NpgsqlTypes.NpgsqlPoint(x: 0.045698123049121575d, y: 0.1890325646039711d), new NpgsqlTypes.NpgsqlPoint(x: 0.10770205180684977d, y: 0.12381096292937388d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2520179949331556d, y: 0.1766294144861742d), new NpgsqlTypes.NpgsqlPoint(x: 0.10673558970514108d, y: 0.9603128122335248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2884249552324789d, y: 0.6661069174407435d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10149037000586714d, y: 0.2539768729780746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828624926732541d, y: 0.12301818795436892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535424200075816d, y: 0.36603975119351184d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8309386708281992d, y: 0.31961973914922037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166078220414075d, y: 0.36691686861332085d), new NpgsqlTypes.NpgsqlPoint(x: 0.18706798910115952d, y: 0.3847985801286036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25272172080529964d, y: 0.2841143894332411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646492855103149d, y: 0.49105137649956854d), new NpgsqlTypes.NpgsqlPoint(x: 0.49369794618811036d, y: 0.98161667918157d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4725909346798387d, y: 0.9187842077242787d), new NpgsqlTypes.NpgsqlPoint(x: 0.47702557408568d, y: 0.8511148516405151d), new NpgsqlTypes.NpgsqlPoint(x: 0.22759881631160472d, y: 0.976505039781374d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799905297372835d, y: 0.03578667580331185d), new NpgsqlTypes.NpgsqlPoint(x: 0.05729734311778467d, y: 0.48462205454384244d), new NpgsqlTypes.NpgsqlPoint(x: 0.843040544875481d, y: 0.6985302960425436d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603652972071596d, y: 0.3012218572009018d), new NpgsqlTypes.NpgsqlPoint(x: 0.14467240787226d, y: 0.5360141987702431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470183452468408d, y: 0.7801356040732268d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3271639897530574d, y: 0.4189534277636101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359605405393844d, y: 0.8325422673169907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341231604444228d, y: 0.5834049551626248d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7821419951949851d, y: 0.5074761026511777d), new NpgsqlTypes.NpgsqlPoint(x: 0.27535783904715605d, y: 0.5003797286441106d), new NpgsqlTypes.NpgsqlPoint(x: 0.14777808106647017d, y: 0.10198566126591224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4796602938278838d, y: 0.4681611484364979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380228561262578d, y: 0.2886970779378324d), new NpgsqlTypes.NpgsqlPoint(x: 0.18165109328422158d, y: 0.363826734640066d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42955811114475495d, y: 0.22511338048370433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986912684827678d, y: 0.2049067121349879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3349854704639268d, y: 0.25799307385663994d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149227462871196d, y: 0.6649264313298537d), new NpgsqlTypes.NpgsqlPoint(x: 0.19322893745870884d, y: 0.8200440734348876d), new NpgsqlTypes.NpgsqlPoint(x: 0.28600312823776797d, y: 0.2869776908389656d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004980543699430573d, y: 0.3967343551850333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617846981991705d, y: 0.06271424621463706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232945565520461d, y: 0.8069923477508439d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109437651493808d, y: 0.9942060378718481d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675106434457435d, y: 0.2699866394336651d), new NpgsqlTypes.NpgsqlPoint(x: 0.12489627758136324d, y: 0.6540242840346888d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9235484314613535d, y: 0.08779729168683659d), new NpgsqlTypes.NpgsqlPoint(x: 0.19254093510550208d, y: 0.5383833570907887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12582654962126494d, y: 0.06378105345254181d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1271884447212165d, y: 0.4741657745990411d), new NpgsqlTypes.NpgsqlPoint(x: 0.41831605393000937d, y: 0.5432170090444595d), new NpgsqlTypes.NpgsqlPoint(x: 0.46485191215357924d, y: 0.3542839034287594d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5271762043642606d, y: 0.009538732988901288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723887906873063d, y: 0.1266847052426695d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573418547507628d, y: 0.0060039643584341995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13179138807449853d, y: 0.9893471148130966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668986203135748d, y: 0.09239031776567852d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517770158971484d, y: 0.26549335111317574d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7862511217202373d, y: 0.7061997322981216d), new NpgsqlTypes.NpgsqlPoint(x: 0.19352406302727898d, y: 0.1517005568719043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374821409883827d, y: 0.9561844125441902d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9445350110454052d, y: 0.874049006012129d), new NpgsqlTypes.NpgsqlPoint(x: 0.523644761697069d, y: 0.2801753136875367d), new NpgsqlTypes.NpgsqlPoint(x: 0.17134383242957252d, y: 0.6211309038309809d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644953895820004d, y: 0.708564412018665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4690768767755298d, y: 0.21379018697465657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605155319527363d, y: 0.31425848245608445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5128802824828923d, y: 0.12776311645675198d), new NpgsqlTypes.NpgsqlPoint(x: 0.23237015929711025d, y: 0.9305410463500695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983225285756291d, y: 0.17646733603994658d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22026115739127117d, y: 0.37986854922571756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237424053869747d, y: 0.574299735625904d), new NpgsqlTypes.NpgsqlPoint(x: 0.032201458485206946d, y: 0.8115326979729651d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4758846329851648d, y: 0.11502493089857646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3338186428002905d, y: 0.47246355119361083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05055655314608254d, y: 0.7907849177700481d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48735549058302463d, y: 0.4079138396730505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904056404251869d, y: 0.31580522729619454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638481719900568d, y: 0.9775566725812868d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15107964933093188d, y: 0.2655916062112461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797511839292623d, y: 0.7517614838099033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544480984269417d, y: 0.936606224128484d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5330510876596817d, y: 0.8972763540957318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707426474834403d, y: 0.93972972065625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058025954717935d, y: 0.45904681533184655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21605175415556133d, y: 0.4221591497236521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669405591530945d, y: 0.5215306261171658d), new NpgsqlTypes.NpgsqlPoint(x: 0.1106152276860003d, y: 0.07864032140274857d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5154277641383327d, y: 0.4053066112059073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096716804398995d, y: 0.731856243291637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8037501680995489d, y: 0.6519603651201641d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1834106405564424d, y: 0.3039518080692556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772769680652043d, y: 0.1176989672202261d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549556690334854d, y: 0.5884758009812651d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9892759919358696d, y: 0.06024481856177266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987029071833638d, y: 0.6843673487210349d), new NpgsqlTypes.NpgsqlPoint(x: 0.15452228397868817d, y: 0.2438310511069619d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7012506941238211d, y: 0.9583589884892046d), new NpgsqlTypes.NpgsqlPoint(x: 0.566848761493783d, y: 0.20014293211075596d), new NpgsqlTypes.NpgsqlPoint(x: 0.265759060807076d, y: 0.9756671502154494d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061061518149287286d, y: 0.5760704423862878d), new NpgsqlTypes.NpgsqlPoint(x: 0.28003194730207426d, y: 0.6460551384392724d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273832451273143d, y: 0.636114908879662d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042799525657353d, y: 0.5791196989967886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163144222028568d, y: 0.4595807487440522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393599555966017d, y: 0.4084499114975688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3320420993543747d, y: 0.42144180162699296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445176254986651d, y: 0.45415182987819636d), new NpgsqlTypes.NpgsqlPoint(x: 0.37729113539948456d, y: 0.26864730660789526d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03909828987499353d, y: 0.4800253927437279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640264935261912d, y: 0.05959922389985939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2566780832043327d, y: 0.32983367283563336d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2843719079664646d, y: 0.7927850597923253d), new NpgsqlTypes.NpgsqlPoint(x: 0.19101655411056495d, y: 0.10004958629403637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313974548545494d, y: 0.07593421071211237d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3185415102402017d, y: 0.37084226332100323d), new NpgsqlTypes.NpgsqlPoint(x: 0.509671151294685d, y: 0.8183744327646559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437653824929834d, y: 0.7137072585164388d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14398846988528047d, y: 0.6148670561568224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349266766457501d, y: 0.41521140844279214d), new NpgsqlTypes.NpgsqlPoint(x: 0.43766351691884187d, y: 0.8406757224940902d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2330658724196557d, y: 0.5940424916035113d), new NpgsqlTypes.NpgsqlPoint(x: 0.32443905797150796d, y: 0.9229961063047712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068596818376021d, y: 0.463671930924084d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6435476409128427d, y: 0.9459893721899224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973440307546856d, y: 0.9961889176739951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895053302425396d, y: 0.6184941678226201d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9197749050155641d, y: 0.6436562955230933d), new NpgsqlTypes.NpgsqlPoint(x: 0.24578845986334297d, y: 0.7500142896944455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467052104865955d, y: 0.39760627887851907d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048168888319043646d, y: 0.00978292707316053d), new NpgsqlTypes.NpgsqlPoint(x: 0.019865628298156413d, y: 0.21507066253004847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988090629494766d, y: 0.06317040131951046d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8222596510925003d, y: 0.6603431811448217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112384910983567d, y: 0.11044955132293743d), new NpgsqlTypes.NpgsqlPoint(x: 0.2433306580846314d, y: 0.1386722360300724d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24622089613177534d, y: 0.37694946647988603d), new NpgsqlTypes.NpgsqlPoint(x: 0.16710651789785003d, y: 0.7663586414371911d), new NpgsqlTypes.NpgsqlPoint(x: 0.39534190922770973d, y: 0.044168043145480396d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39486583638858685d, y: 0.08630885692584689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2407106293291844d, y: 0.768361657753647d), new NpgsqlTypes.NpgsqlPoint(x: 0.48266732434378556d, y: 0.06512443016091485d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022288403092467d, y: 0.2847986322099507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810966377425964d, y: 0.2481587869551547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244314438375259d, y: 0.44810805621400085d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8911161535688619d, y: 0.03050290573777603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818545983077867d, y: 0.5134041614010146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617681291033239d, y: 0.41478797879653195d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02005691682781463d, y: 0.3995234258048973d), new NpgsqlTypes.NpgsqlPoint(x: 0.19075794153291992d, y: 0.6596686716986664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278202959231755d, y: 0.024477165490353392d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3119317240106658d, y: 0.9063965154884641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934870123269425d, y: 0.12980594787561361d), new NpgsqlTypes.NpgsqlPoint(x: 0.09811237721654897d, y: 0.5782963624577454d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597862307447919d, y: 0.38611728163617587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234063835590409d, y: 0.5264343550627133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25223247667726445d, y: 0.766238247277753d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16377536995641317d, y: 0.3673534681149929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870272124760802d, y: 0.4980936345113365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280907947841662d, y: 0.18000885161564062d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088980975212303d, y: 0.712100963910764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242497897581768d, y: 0.6478739603575036d), new NpgsqlTypes.NpgsqlPoint(x: 0.17183278789662848d, y: 0.7126853301033473d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590964512754704d, y: 0.15216109240569642d), new NpgsqlTypes.NpgsqlPoint(x: 0.30213770978533816d, y: 0.24463516163043197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673321661885494d, y: 0.6372125098894159d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395669946396211d, y: 0.11584921667075565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355575105554963d, y: 0.2041480747302803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7715291972590211d, y: 0.8624188147075346d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((8)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2189227495567111d, y: 0.7953645502997058d), new NpgsqlTypes.NpgsqlPoint(x: 0.9964069223019759d, y: 0.9702037127114762d), new NpgsqlTypes.NpgsqlPoint(x: 0.8446134373343732d, y: 0.05917405765184036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09942203643626013d, y: 0.4396035441005738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117817753357166d, y: 0.581066551330822d), new NpgsqlTypes.NpgsqlPoint(x: 0.09046531163295723d, y: 0.22484882123816852d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((17)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35235366165477733d, y: 0.4800224037201507d), new NpgsqlTypes.NpgsqlPoint(x: 0.12454096717983532d, y: 0.6047817206038547d), new NpgsqlTypes.NpgsqlPoint(x: 0.8776670870933129d, y: 0.20558246572333716d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8753744599023471d, y: 0.9278805505130364d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968177581937916d, y: 0.29523070292011d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054845372147944d, y: 0.26434744177064096d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.51998200069598d, y: 0.5613694512892544d), new NpgsqlTypes.NpgsqlPoint(x: 0.23999284438958102d, y: 0.29010418204460253d), new NpgsqlTypes.NpgsqlPoint(x: 0.014410660696045796d, y: 0.15347071364656495d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9267500061477756d, y: 0.3162931707725525d), new NpgsqlTypes.NpgsqlPoint(x: 0.15370636422618067d, y: 0.5196589748187531d), new NpgsqlTypes.NpgsqlPoint(x: 0.2826434854372153d, y: 0.09928925587987125d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7742276254272494d, y: 0.9469746272908941d), new NpgsqlTypes.NpgsqlPoint(x: 0.994330888464615d, y: 0.2547261987234557d), new NpgsqlTypes.NpgsqlPoint(x: 0.39903182245247026d, y: 0.555132955619006d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((30)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.769595946958287d, y: 0.7503656094549572d), new NpgsqlTypes.NpgsqlPoint(x: 0.9696280270739027d, y: 0.7847506928883194d), new NpgsqlTypes.NpgsqlPoint(x: 0.9408020021786591d, y: 0.999482343480459d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((4)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2982055038751137d, y: 0.4883470112951178d), new NpgsqlTypes.NpgsqlPoint(x: 0.23774274087545078d, y: 0.21976837265514804d), new NpgsqlTypes.NpgsqlPoint(x: 0.12655590305280218d, y: 0.5734209853984238d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6647109107541981d, y: 0.6141241270825976d), new NpgsqlTypes.NpgsqlPoint(x: 0.7855808978917994d, y: 0.7782825933273981d), new NpgsqlTypes.NpgsqlPoint(x: 0.2526807443821085d, y: 0.03312355261236899d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26990379344577264d, y: 0.19373694591545132d), new NpgsqlTypes.NpgsqlPoint(x: 0.02788918744227198d, y: 0.8255260732467798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7016368456066477d, y: 0.6552148560709737d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144830795855961d, y: 0.654024925260595d), new NpgsqlTypes.NpgsqlPoint(x: 0.07151039136004111d, y: 0.6780583704929974d), new NpgsqlTypes.NpgsqlPoint(x: 0.21923961120003232d, y: 0.0891513141119411d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45427788323747853d, y: 0.9809762233341147d), new NpgsqlTypes.NpgsqlPoint(x: 0.11170472747136484d, y: 0.8523829991375342d), new NpgsqlTypes.NpgsqlPoint(x: 0.16673907233910334d, y: 0.03330418975323124d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((43)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48301210443300246d, y: 0.5953583233120174d), new NpgsqlTypes.NpgsqlPoint(x: 0.045698123049121575d, y: 0.1890325646039711d), new NpgsqlTypes.NpgsqlPoint(x: 0.10770205180684977d, y: 0.12381096292937388d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2520179949331556d, y: 0.1766294144861742d), new NpgsqlTypes.NpgsqlPoint(x: 0.10673558970514108d, y: 0.9603128122335248d), new NpgsqlTypes.NpgsqlPoint(x: 0.2884249552324789d, y: 0.6661069174407435d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10149037000586714d, y: 0.2539768729780746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8828624926732541d, y: 0.12301818795436892d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535424200075816d, y: 0.36603975119351184d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((47)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8309386708281992d, y: 0.31961973914922037d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166078220414075d, y: 0.36691686861332085d), new NpgsqlTypes.NpgsqlPoint(x: 0.18706798910115952d, y: 0.3847985801286036d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25272172080529964d, y: 0.2841143894332411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6646492855103149d, y: 0.49105137649956854d), new NpgsqlTypes.NpgsqlPoint(x: 0.49369794618811036d, y: 0.98161667918157d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((56)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4725909346798387d, y: 0.9187842077242787d), new NpgsqlTypes.NpgsqlPoint(x: 0.47702557408568d, y: 0.8511148516405151d), new NpgsqlTypes.NpgsqlPoint(x: 0.22759881631160472d, y: 0.976505039781374d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5799905297372835d, y: 0.03578667580331185d), new NpgsqlTypes.NpgsqlPoint(x: 0.05729734311778467d, y: 0.48462205454384244d), new NpgsqlTypes.NpgsqlPoint(x: 0.843040544875481d, y: 0.6985302960425436d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.603652972071596d, y: 0.3012218572009018d), new NpgsqlTypes.NpgsqlPoint(x: 0.14467240787226d, y: 0.5360141987702431d), new NpgsqlTypes.NpgsqlPoint(x: 0.5470183452468408d, y: 0.7801356040732268d)))));

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3271639897530574d, y: 0.4189534277636101d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359605405393844d, y: 0.8325422673169907d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341231604444228d, y: 0.5834049551626248d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((69)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7821419951949851d, y: 0.5074761026511777d), new NpgsqlTypes.NpgsqlPoint(x: 0.27535783904715605d, y: 0.5003797286441106d), new NpgsqlTypes.NpgsqlPoint(x: 0.14777808106647017d, y: 0.10198566126591224d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((26)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4796602938278838d, y: 0.4681611484364979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3380228561262578d, y: 0.2886970779378324d), new NpgsqlTypes.NpgsqlPoint(x: 0.18165109328422158d, y: 0.363826734640066d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42955811114475495d, y: 0.22511338048370433d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986912684827678d, y: 0.2049067121349879d), new NpgsqlTypes.NpgsqlPoint(x: 0.3349854704639268d, y: 0.25799307385663994d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((77)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149227462871196d, y: 0.6649264313298537d), new NpgsqlTypes.NpgsqlPoint(x: 0.19322893745870884d, y: 0.8200440734348876d), new NpgsqlTypes.NpgsqlPoint(x: 0.28600312823776797d, y: 0.2869776908389656d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004980543699430573d, y: 0.3967343551850333d), new NpgsqlTypes.NpgsqlPoint(x: 0.2617846981991705d, y: 0.06271424621463706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9232945565520461d, y: 0.8069923477508439d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((35)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3109437651493808d, y: 0.9942060378718481d), new NpgsqlTypes.NpgsqlPoint(x: 0.1675106434457435d, y: 0.2699866394336651d), new NpgsqlTypes.NpgsqlPoint(x: 0.12489627758136324d, y: 0.6540242840346888d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9235484314613535d, y: 0.08779729168683659d), new NpgsqlTypes.NpgsqlPoint(x: 0.19254093510550208d, y: 0.5383833570907887d), new NpgsqlTypes.NpgsqlPoint(x: 0.12582654962126494d, y: 0.06378105345254181d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((88)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1271884447212165d, y: 0.4741657745990411d), new NpgsqlTypes.NpgsqlPoint(x: 0.41831605393000937d, y: 0.5432170090444595d), new NpgsqlTypes.NpgsqlPoint(x: 0.46485191215357924d, y: 0.3542839034287594d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((91)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5271762043642606d, y: 0.009538732988901288d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723887906873063d, y: 0.1266847052426695d), new NpgsqlTypes.NpgsqlPoint(x: 0.09573418547507628d, y: 0.0060039643584341995d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13179138807449853d, y: 0.9893471148130966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668986203135748d, y: 0.09239031776567852d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517770158971484d, y: 0.26549335111317574d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7862511217202373d, y: 0.7061997322981216d), new NpgsqlTypes.NpgsqlPoint(x: 0.19352406302727898d, y: 0.1517005568719043d), new NpgsqlTypes.NpgsqlPoint(x: 0.9374821409883827d, y: 0.9561844125441902d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9445350110454052d, y: 0.874049006012129d), new NpgsqlTypes.NpgsqlPoint(x: 0.523644761697069d, y: 0.2801753136875367d), new NpgsqlTypes.NpgsqlPoint(x: 0.17134383242957252d, y: 0.6211309038309809d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((93)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6644953895820004d, y: 0.708564412018665d), new NpgsqlTypes.NpgsqlPoint(x: 0.4690768767755298d, y: 0.21379018697465657d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605155319527363d, y: 0.31425848245608445d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5128802824828923d, y: 0.12776311645675198d), new NpgsqlTypes.NpgsqlPoint(x: 0.23237015929711025d, y: 0.9305410463500695d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983225285756291d, y: 0.17646733603994658d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22026115739127117d, y: 0.37986854922571756d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237424053869747d, y: 0.574299735625904d), new NpgsqlTypes.NpgsqlPoint(x: 0.032201458485206946d, y: 0.8115326979729651d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4758846329851648d, y: 0.11502493089857646d), new NpgsqlTypes.NpgsqlPoint(x: 0.3338186428002905d, y: 0.47246355119361083d), new NpgsqlTypes.NpgsqlPoint(x: 0.05055655314608254d, y: 0.7907849177700481d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((102)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48735549058302463d, y: 0.4079138396730505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8904056404251869d, y: 0.31580522729619454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638481719900568d, y: 0.9775566725812868d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15107964933093188d, y: 0.2655916062112461d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797511839292623d, y: 0.7517614838099033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3544480984269417d, y: 0.936606224128484d)))));

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5330510876596817d, y: 0.8972763540957318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5707426474834403d, y: 0.93972972065625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9058025954717935d, y: 0.45904681533184655d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((43)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21605175415556133d, y: 0.4221591497236521d), new NpgsqlTypes.NpgsqlPoint(x: 0.4669405591530945d, y: 0.5215306261171658d), new NpgsqlTypes.NpgsqlPoint(x: 0.1106152276860003d, y: 0.07864032140274857d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5154277641383327d, y: 0.4053066112059073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5096716804398995d, y: 0.731856243291637d), new NpgsqlTypes.NpgsqlPoint(x: 0.8037501680995489d, y: 0.6519603651201641d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1834106405564424d, y: 0.3039518080692556d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772769680652043d, y: 0.1176989672202261d), new NpgsqlTypes.NpgsqlPoint(x: 0.4549556690334854d, y: 0.5884758009812651d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9892759919358696d, y: 0.06024481856177266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987029071833638d, y: 0.6843673487210349d), new NpgsqlTypes.NpgsqlPoint(x: 0.15452228397868817d, y: 0.2438310511069619d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((45)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7012506941238211d, y: 0.9583589884892046d), new NpgsqlTypes.NpgsqlPoint(x: 0.566848761493783d, y: 0.20014293211075596d), new NpgsqlTypes.NpgsqlPoint(x: 0.265759060807076d, y: 0.9756671502154494d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.061061518149287286d, y: 0.5760704423862878d), new NpgsqlTypes.NpgsqlPoint(x: 0.28003194730207426d, y: 0.6460551384392724d), new NpgsqlTypes.NpgsqlPoint(x: 0.07273832451273143d, y: 0.636114908879662d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1042799525657353d, y: 0.5791196989967886d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163144222028568d, y: 0.4595807487440522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393599555966017d, y: 0.4084499114975688d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3320420993543747d, y: 0.42144180162699296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445176254986651d, y: 0.45415182987819636d), new NpgsqlTypes.NpgsqlPoint(x: 0.37729113539948456d, y: 0.26864730660789526d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03909828987499353d, y: 0.4800253927437279d), new NpgsqlTypes.NpgsqlPoint(x: 0.3640264935261912d, y: 0.05959922389985939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2566780832043327d, y: 0.32983367283563336d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2843719079664646d, y: 0.7927850597923253d), new NpgsqlTypes.NpgsqlPoint(x: 0.19101655411056495d, y: 0.10004958629403637d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313974548545494d, y: 0.07593421071211237d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3185415102402017d, y: 0.37084226332100323d), new NpgsqlTypes.NpgsqlPoint(x: 0.509671151294685d, y: 0.8183744327646559d), new NpgsqlTypes.NpgsqlPoint(x: 0.3437653824929834d, y: 0.7137072585164388d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14398846988528047d, y: 0.6148670561568224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349266766457501d, y: 0.41521140844279214d), new NpgsqlTypes.NpgsqlPoint(x: 0.43766351691884187d, y: 0.8406757224940902d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2330658724196557d, y: 0.5940424916035113d), new NpgsqlTypes.NpgsqlPoint(x: 0.32443905797150796d, y: 0.9229961063047712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5068596818376021d, y: 0.463671930924084d)))));

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6435476409128427d, y: 0.9459893721899224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973440307546856d, y: 0.9961889176739951d), new NpgsqlTypes.NpgsqlPoint(x: 0.9895053302425396d, y: 0.6184941678226201d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((51)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9197749050155641d, y: 0.6436562955230933d), new NpgsqlTypes.NpgsqlPoint(x: 0.24578845986334297d, y: 0.7500142896944455d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467052104865955d, y: 0.39760627887851907d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((137)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048168888319043646d, y: 0.00978292707316053d), new NpgsqlTypes.NpgsqlPoint(x: 0.019865628298156413d, y: 0.21507066253004847d), new NpgsqlTypes.NpgsqlPoint(x: 0.7988090629494766d, y: 0.06317040131951046d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8222596510925003d, y: 0.6603431811448217d), new NpgsqlTypes.NpgsqlPoint(x: 0.6112384910983567d, y: 0.11044955132293743d), new NpgsqlTypes.NpgsqlPoint(x: 0.2433306580846314d, y: 0.1386722360300724d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24622089613177534d, y: 0.37694946647988603d), new NpgsqlTypes.NpgsqlPoint(x: 0.16710651789785003d, y: 0.7663586414371911d), new NpgsqlTypes.NpgsqlPoint(x: 0.39534190922770973d, y: 0.044168043145480396d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((52)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39486583638858685d, y: 0.08630885692584689d), new NpgsqlTypes.NpgsqlPoint(x: 0.2407106293291844d, y: 0.768361657753647d), new NpgsqlTypes.NpgsqlPoint(x: 0.48266732434378556d, y: 0.06512443016091485d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9022288403092467d, y: 0.2847986322099507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810966377425964d, y: 0.2481587869551547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7244314438375259d, y: 0.44810805621400085d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8911161535688619d, y: 0.03050290573777603d), new NpgsqlTypes.NpgsqlPoint(x: 0.8818545983077867d, y: 0.5134041614010146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8617681291033239d, y: 0.41478797879653195d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02005691682781463d, y: 0.3995234258048973d), new NpgsqlTypes.NpgsqlPoint(x: 0.19075794153291992d, y: 0.6596686716986664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9278202959231755d, y: 0.024477165490353392d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((153)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3119317240106658d, y: 0.9063965154884641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3934870123269425d, y: 0.12980594787561361d), new NpgsqlTypes.NpgsqlPoint(x: 0.09811237721654897d, y: 0.5782963624577454d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9597862307447919d, y: 0.38611728163617587d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234063835590409d, y: 0.5264343550627133d), new NpgsqlTypes.NpgsqlPoint(x: 0.25223247667726445d, y: 0.766238247277753d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((158)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16377536995641317d, y: 0.3673534681149929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870272124760802d, y: 0.4980936345113365d), new NpgsqlTypes.NpgsqlPoint(x: 0.9280907947841662d, y: 0.18000885161564062d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((165)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7088980975212303d, y: 0.712100963910764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6242497897581768d, y: 0.6478739603575036d), new NpgsqlTypes.NpgsqlPoint(x: 0.17183278789662848d, y: 0.7126853301033473d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((62)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.590964512754704d, y: 0.15216109240569642d), new NpgsqlTypes.NpgsqlPoint(x: 0.30213770978533816d, y: 0.24463516163043197d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673321661885494d, y: 0.6372125098894159d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6395669946396211d, y: 0.11584921667075565d), new NpgsqlTypes.NpgsqlPoint(x: 0.4355575105554963d, y: 0.2041480747302803d), new NpgsqlTypes.NpgsqlPoint(x: 0.7715291972590211d, y: 0.8624188147075346d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

