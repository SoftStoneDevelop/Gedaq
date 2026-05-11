

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
    internal partial interface INpgsqlCircleMArraycircleMMArrayD1
    {
    }
    
    internal partial class NpgsqlCircleMArraycircleMMArrayD1 : INpgsqlCircleMArraycircleMMArrayD1
    {


#region TestData

        private readonly NpgsqlCirclecircleMMArrayD1E1M[] _testData = new NpgsqlCirclecircleMMArrayD1E1M[]
        {
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3815053594504141d, y: 0.6480309290138792d), radius: 0.13621543865012153d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31409923974557685d, y: 0.993314918109441d), radius: 0.6243414662274651d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4746108519223804d, y: 0.6532389100451309d), radius: 0.24719844681874126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31491060273610716d, y: 0.19079499434397662d), radius: 0.2514162728332091d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10910189193972608d, y: 0.13102647624136943d), radius: 0.5569596508437167d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20459433928559945d, y: 0.2350323725965221d), radius: 0.3360690733371685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20456758743589454d, y: 0.9958583183271991d), radius: 0.7407050216673899d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7276376002318595d, y: 0.4823723516126923d), radius: 0.04148264907653465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13405390973832154d, y: 0.37880790619835936d), radius: 0.5058501854871192d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48102653501574766d, y: 0.4612516227876231d), radius: 0.4867662615859689d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7903965052327317d, y: 0.14373939153902981d), radius: 0.0677826713555355d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.892489756681071d, y: 0.8054638926243927d), radius: 0.21681343566610056d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21136212381155417d, y: 0.30469668253040894d), radius: 0.1855774888322398d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1694742284323013d, y: 0.5747835069980657d), radius: 0.1386986218743681d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07097787787003829d, y: 0.04844627265520063d), radius: 0.09861897892909122d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9760975149787304d, y: 0.2840092185302514d), radius: 0.46595033798797303d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7435460021375276d, y: 0.21659856983514392d), radius: 0.7193876888639693d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7465522703721447d, y: 0.872675820012196d), radius: 0.2645632375318242d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9814195373661406d, y: 0.2609606141076197d), radius: 0.4598676962601079d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7843876393769434d, y: 0.24800630059882267d), radius: 0.5819240557069846d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.001958732641966998d, y: 0.2144961585886157d), radius: 0.5346996429067051d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04129308327484493d, y: 0.21883372935231415d), radius: 0.4681008088948415d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9579012371570763d, y: 0.02546073394368631d), radius: 0.2348586452375433d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3709267443079639d, y: 0.5800067786279192d), radius: 0.30500460010077857d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6319378264578038d, y: 0.19029680934322413d), radius: 0.396699511278779d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22328117174358109d, y: 0.12006411835294784d), radius: 0.18730136357596627d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20931240074534052d, y: 0.27229449169412245d), radius: 0.8378954713966726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14644254469383877d, y: 0.6094162985117481d), radius: 0.10779337815111256d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14291132460659473d, y: 0.7220177586035473d), radius: 0.6428283173510608d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.044384507912411886d, y: 0.5566653642468771d), radius: 0.956116519760623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08589731971494763d, y: 0.4772517642023333d), radius: 0.33217282658113434d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5900375576702424d, y: 0.1040733352939327d), radius: 0.7214437388007964d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.721408115357147d, y: 0.5336438401352933d), radius: 0.2853561667674217d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10896908522063986d, y: 0.2880136616160507d), radius: 0.7441840264417632d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09017613270033753d, y: 0.025202246987059862d), radius: 0.3500506511662388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130554837038536d, y: 0.6250228828132607d), radius: 0.5859583226801799d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9523936057545802d, y: 0.13897035865214102d), radius: 0.9178830680572736d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35958711885653516d, y: 0.1625150858644574d), radius: 0.03218677731168684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2783437211710954d, y: 0.022847853387609085d), radius: 0.49386240909015133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29010784525586764d, y: 0.06519978892704126d), radius: 0.038596975613201634d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27865076455607174d, y: 0.15965832584859663d), radius: 0.17585062254702188d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9559978699744455d, y: 0.15592149274214273d), radius: 0.10224804685412903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4695602829617723d, y: 0.9507907983255401d), radius: 0.43015286652055773d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2914465019406256d, y: 0.1602442503278776d), radius: 0.2737227466447065d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.740069027441479d, y: 0.3987763979167369d), radius: 0.9360195244175853d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2806414393929092d, y: 0.3752214828948951d), radius: 0.0829529702427656d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1767758037300764d, y: 0.7442681411482643d), radius: 0.6707102839355755d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7788577814351847d, y: 0.7706256649207008d), radius: 0.20203693386374888d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667920414178552d, y: 0.7386701939894834d), radius: 0.9575430760121786d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5028432089082645d, y: 0.2873186726933421d), radius: 0.9363814206821136d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.658093916310893d, y: 0.7716658860242491d), radius: 0.07388866901864044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22146241421448998d, y: 0.1927220166709127d), radius: 0.6566243672663319d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8602775931449913d, y: 0.6414232496414025d), radius: 0.497925393699278d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6774123219968122d, y: 0.39754728933958305d), radius: 0.7532955892351308d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3374167445513375d, y: 0.8473980449173105d), radius: 0.12764246503423804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5471330725573943d, y: 0.9827049187017837d), radius: 0.6119334189416673d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25541007472142085d, y: 0.5583984641682963d), radius: 0.7252539539934558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8907067645152614d, y: 0.8020323400233664d), radius: 0.1475979438183781d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18544440826496955d, y: 0.010765880003683281d), radius: 0.6068414454994492d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6903370988294962d, y: 0.13601123938590376d), radius: 0.09569002785404201d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22652418457314705d, y: 0.23208961555886365d), radius: 0.5481337138724325d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1549731730726024d, y: 0.8026288737814451d), radius: 0.7171315342642296d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8682182466037284d, y: 0.13958566662513383d), radius: 0.46734437166520004d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403035582884161d, y: 0.8930102172850065d), radius: 0.4694151389343486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10039099057752121d, y: 0.7172944399130586d), radius: 0.4240818886794383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47832576120611514d, y: 0.8783321267292143d), radius: 0.25526289688271875d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27587464418135943d, y: 0.6152553626292971d), radius: 0.5005448636542272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33316906192268303d, y: 0.05700336028244557d), radius: 0.29943471657024956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7775001094515436d, y: 0.8317042391326506d), radius: 0.27679732859794526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21914454358350066d, y: 0.7980078326443172d), radius: 0.013529845737151103d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44005508966974927d, y: 0.9825434307178331d), radius: 0.32097849689710534d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3672414524071187d, y: 0.36386643185484613d), radius: 0.5487042871096073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8052479331272167d, y: 0.28479188144319045d), radius: 0.7154769785115727d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8078814039242337d, y: 0.39928640017173844d), radius: 0.9534227232887059d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784649793097176d, y: 0.044467869866090304d), radius: 0.6948393158121717d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7036551585545952d, y: 0.21677673943563835d), radius: 0.46148337352566493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9603890548296806d, y: 0.7759419879163346d), radius: 0.09327253482633857d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09641186020640258d, y: 0.9069155899894957d), radius: 0.9629716077272628d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12465397184159999d, y: 0.23275988244688506d), radius: 0.7427881550968184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05766717553554457d, y: 0.8121417783470598d), radius: 0.5885971586763576d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20323749309443773d, y: 0.26308790466089127d), radius: 0.29963795174339936d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0033730112501926257d, y: 0.8519724411834018d), radius: 0.8411497176864801d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14751884398226212d, y: 0.28281631399748164d), radius: 0.23845974049578023d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7367699595092462d, y: 0.19210998949722358d), radius: 0.6967175463314689d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48853479251724063d, y: 0.39524232371056267d), radius: 0.3894073388528865d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03369701682822368d, y: 0.09867412731233016d), radius: 0.9336390597473312d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1399868145125468d, y: 0.09918793770345224d), radius: 0.39271871523829893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1825847162896732d, y: 0.22429656124859398d), radius: 0.20405588300262978d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08269267791057555d, y: 0.28438392434994064d), radius: 0.44154415081476994d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7908485498806996d, y: 0.6347160086821797d), radius: 0.7493091775149293d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9538536050706504d, y: 0.37525600441047513d), radius: 0.09633559586266272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4514832590671859d, y: 0.978455372030913d), radius: 0.667724317274249d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7518545423250667d, y: 0.18518484190661488d), radius: 0.40904084622324466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35717249699622733d, y: 0.8712587876711686d), radius: 0.2664949566004041d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6934891748389896d, y: 0.5379505859287442d), radius: 0.07981399787326726d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10559697748227848d, y: 0.7528559812459295d), radius: 0.5867878535984492d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19206515681346414d, y: 0.041831386708406915d), radius: 0.2559183284597103d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3725883194528322d, y: 0.6493672841189216d), radius: 0.1356230282532137d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08960795482852957d, y: 0.04548744056390808d), radius: 0.4886973883668775d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9639874623859642d, y: 0.005267748717290743d), radius: 0.540313376577401d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3965943746573548d, y: 0.1689984863179862d), radius: 0.8081119679984681d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7937412998129934d, y: 0.32361701413729416d), radius: 0.8380754385392581d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7647121703804275d, y: 0.653686754679545d), radius: 0.5765790757423243d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47681008900108224d, y: 0.8683804409788057d), radius: 0.5718343836280105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26610882490903376d, y: 0.22382760647902444d), radius: 0.9477133204507485d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8916954522834549d, y: 0.7823886317244122d), radius: 0.7493262062793636d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3063421159082884d, y: 0.6589776742145684d), radius: 0.5819550488213588d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7455664928456394d, y: 0.9087882771950595d), radius: 0.2848610727849732d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6321919752602883d, y: 0.16333175263324662d), radius: 0.523274972473121d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13223421665618795d, y: 0.4577435858602189d), radius: 0.8578312919036032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5417042166142592d, y: 0.04648898520336042d), radius: 0.6758240561110477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8049620357639898d, y: 0.13459303558407498d), radius: 0.929071320818469d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2862429029167006d, y: 0.6455062745766299d), radius: 0.05212418239896577d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9741521203235768d, y: 0.17838751336358882d), radius: 0.3777729803725991d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6448921577647065d, y: 0.9188726732629298d), radius: 0.8059398906678988d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39175660448181626d, y: 0.9561122455228189d), radius: 0.6409476872432206d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7900508596770007d, y: 0.6913951145653223d), radius: 0.7089955666513117d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9769001612579826d, y: 0.6718121863782426d), radius: 0.19342652085264955d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40322581053883977d, y: 0.18072271292425524d), radius: 0.7979002581294495d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004217441119615861d, y: 0.6134160287739577d), radius: 0.35649760955318155d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9090250586986224d, y: 0.03957567660248151d), radius: 0.23342670960471357d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45707459122172067d, y: 0.5777379373379871d), radius: 0.7850621354438115d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4330967428986068d, y: 0.6137485518874181d), radius: 0.4688652140959363d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14305053393430778d, y: 0.288983385614741d), radius: 0.0867593855825819d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9892530080176718d, y: 0.8016413888026676d), radius: 0.4945475608793162d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31516531204228526d, y: 0.7849119984546168d), radius: 0.6160443072067673d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.948967455350986d, y: 0.7646562507524739d), radius: 0.38254989571630593d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3203483471117755d, y: 0.7553193353888529d), radius: 0.624110297422427d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36027997929481426d, y: 0.6524456247745959d), radius: 0.19459563571044658d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.099488985076855d, y: 0.8565136027498063d), radius: 0.3773370254752402d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19858424334293245d, y: 0.1637296417986449d), radius: 0.18914442320239155d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4899018905382715d, y: 0.5458525151839668d), radius: 0.6429937349722231d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4172459895817623d, y: 0.6365729085919016d), radius: 0.22849633646988565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5794348601440624d, y: 0.489832682446359d), radius: 0.2785550170525395d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6877164265777537d, y: 0.9379671978834057d), radius: 0.7932307895908111d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7802383458821819d, y: 0.3755875015566771d), radius: 0.46561366499085055d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9023130057292451d, y: 0.6172781886421637d), radius: 0.5209549235990888d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18090569211335206d, y: 0.9087076431368947d), radius: 0.040671358004377045d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27309825157248724d, y: 0.3033401933201987d), radius: 0.39351898443313327d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6215106567659786d, y: 0.27541311420924d), radius: 0.4102614827797393d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7235996872865673d, y: 0.782965424907081d), radius: 0.5566115595533202d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2861032282674725d, y: 0.4607889076712852d), radius: 0.21243504098680122d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5658172831762187d, y: 0.1419796617489455d), radius: 0.6237732298207134d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5925710372436374d, y: 0.6120280487967295d), radius: 0.6337357354045885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30446727178557964d, y: 0.5866012531706697d), radius: 0.39458105856528947d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6225168105847552d, y: 0.38672331601686327d), radius: 0.03947792019579255d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8347895471056349d, y: 0.6790515486641319d), radius: 0.7683161549036623d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05214489771060138d, y: 0.20588274173773002d), radius: 0.44395043200891016d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.788884220467599d, y: 0.3477862708721092d), radius: 0.29197271239916345d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6873960215183461d, y: 0.07585162612276719d), radius: 0.9530761429334722d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3077821530577717d, y: 0.600542403651648d), radius: 0.4337294658782993d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13522022017317314d, y: 0.8877645310412715d), radius: 0.48324025065492093d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8168000491414847d, y: 0.500363154743792d), radius: 0.4350479312034068d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0786055968067837d, y: 0.22498111664056875d), radius: 0.4911153883106062d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9294054867360304d, y: 0.7462869606308342d), radius: 0.8315336621207525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3195629520489951d, y: 0.5304827394796813d), radius: 0.3704510157584502d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7889638378234868d, y: 0.20786886548608063d), radius: 0.4752379949883173d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8036837696415183d, y: 0.6283404181786523d), radius: 0.17375371426933295d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29428873606264394d, y: 0.48628016716739586d), radius: 0.3901196670616982d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7512573689472732d, y: 0.8444396432489468d), radius: 0.24208464222885073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8141747043152311d, y: 0.4451138866924269d), radius: 0.08126499385797492d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3132014323387321d, y: 0.8870032153354007d), radius: 0.7111773511611506d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 119,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9558933652118279d, y: 0.998762997390516d), radius: 0.43493658503898336d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25317450378729633d, y: 0.569269811889323d), radius: 0.6751601986121524d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9008690503225416d, y: 0.8591350407784869d), radius: 0.36383617854765027d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10616222604237713d, y: 0.5814403816281408d), radius: 0.32159772191886715d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9303207202622905d, y: 0.4464000936233229d), radius: 0.809525447899937d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19678889979931014d, y: 0.9646873886211698d), radius: 0.002630730338036402d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40014343887152903d, y: 0.08719268270204172d), radius: 0.21592708994469612d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19868553273216383d, y: 0.6079563010767796d), radius: 0.9150877475377144d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4118791145031129d, y: 0.4093830727486053d), radius: 0.38927471804404545d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.572078461548738d, y: 0.10497549377782034d), radius: 0.855431565551422d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6320970251402162d, y: 0.9861737985076889d), radius: 0.5810401374693276d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7750517645071443d, y: 0.3384284093838559d), radius: 0.7746384447111518d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6640288836630772d, y: 0.09967494332128024d), radius: 0.3555048653367169d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8985887548769238d, y: 0.2145749274128841d), radius: 0.43851437421339334d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33147309879268283d, y: 0.9570588912718965d), radius: 0.7925283092455843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5624002702996179d, y: 0.9174665656812536d), radius: 0.5870617806292778d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7413228107983725d, y: 0.0249088778335238d), radius: 0.0669864275841856d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16684101221646963d, y: 0.7875920175075946d), radius: 0.9000981032484966d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37299945107073806d, y: 0.3741156908080038d), radius: 0.28485613932975384d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8081847059679076d, y: 0.7058107127706397d), radius: 0.9134930721258767d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6045650803841918d, y: 0.0870088815660115d), radius: 0.8589259296941926d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2626237104512007d, y: 0.49679074532943723d), radius: 0.30967307061191607d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 130,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0004968565632723632d, y: 0.6415456612864389d), radius: 0.891270426629415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25375213683045994d, y: 0.6372669978344923d), radius: 0.38005498766511814d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5817407550595765d, y: 0.23258340105749087d), radius: 0.8387710387589372d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3506193768190049d, y: 0.9150069680570021d), radius: 0.9426853799546339d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6916867943561683d, y: 0.2802861342404904d), radius: 0.5266330717449503d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7925217676968955d, y: 0.6359128083945064d), radius: 0.34881382043685716d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.023548879017257884d, y: 0.16742384788559372d), radius: 0.4323705833775616d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16762088020281507d, y: 0.9363295332477828d), radius: 0.39316696460596956d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40570442221401726d, y: 0.691387084081996d), radius: 0.5077595963285643d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43261890616313237d, y: 0.7293928707541159d), radius: 0.6098903399973127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.30900291523600265d, y: 0.9962003034110172d), radius: 0.9980831138816861d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2991365313264791d, y: 0.5787004046027701d), radius: 0.7971752867316892d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2390561798843457d, y: 0.5878312102104949d), radius: 0.4350053742332708d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5178304994313113d, y: 0.460204454543536d), radius: 0.1499971269908823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7976070019829077d, y: 0.0941481776707882d), radius: 0.7784200976100404d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7657331814066622d, y: 0.08104991865977085d), radius: 0.36986928069857494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8033029042574494d, y: 0.5811089272171949d), radius: 0.30046119926031956d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9989899289536299d, y: 0.2850887275062127d), radius: 0.03278389037435425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.055793022516056d, y: 0.7490335639913359d), radius: 0.05959161561150195d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47533369073424114d, y: 0.36924423347773094d), radius: 0.2201438202172885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9900054379806484d, y: 0.8750016986843495d), radius: 0.514294110178126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9147280936379392d, y: 0.4595692996129316d), radius: 0.6650940348189796d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11443495395589298d, y: 0.5533236535109635d), radius: 0.612683127900931d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6618403365270947d, y: 0.059366827625207175d), radius: 0.7812192305529385d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6755032773254109d, y: 0.8607933929704107d), radius: 0.03706120165203619d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.58923692704743d, y: 0.5650577810756d), radius: 0.7363200181549984d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10936785821299921d, y: 0.8612622607831053d), radius: 0.5271291380688831d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15172918285212222d, y: 0.7786145038551027d), radius: 0.5576368270651731d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9185169691173475d, y: 0.21254317071236972d), radius: 0.5886298244224077d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2518159645581035d, y: 0.5601053710381638d), radius: 0.4422809909364761d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6070118800898183d, y: 0.8725544173574872d), radius: 0.06669136653774788d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7086874593654491d, y: 0.23084857971284967d), radius: 0.7899032231640172d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.527758457166096d, y: 0.01679168959215238d), radius: 0.6849219315081762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5386054423634198d, y: 0.6914980200102419d), radius: 0.46932162892110696d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.240646493035363d, y: 0.21112641787908804d), radius: 0.3960030795432812d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43641439029269313d, y: 0.4340886536011478d), radius: 0.00801862719832147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6214660656325627d, y: 0.7450523852077715d), radius: 0.5134943450884858d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45195831560428024d, y: 0.03339784802426404d), radius: 0.33519004567618316d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14307819967479174d, y: 0.934022326148943d), radius: 0.8751264897035441d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39492204782118057d, y: 0.41391976184599777d), radius: 0.3444440939221587d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19214510362667425d, y: 0.2928371628899593d), radius: 0.5763613658673915d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06560854562630669d, y: 0.017597943690126572d), radius: 0.12891321200789552d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10761623861606417d, y: 0.5096709139838134d), radius: 0.9916441154215269d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9990995336763385d, y: 0.6081438470922026d), radius: 0.6461327595254254d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015756963800352297d, y: 0.4660806137086071d), radius: 0.5586634794758409d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5316970438173235d, y: 0.05274157941144075d), radius: 0.7454910229627282d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.68440787002013d, y: 0.1865650896107811d), radius: 0.5516753996617783d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06197244775753974d, y: 0.8458819638693819d), radius: 0.4283214618274074d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32534682209107224d, y: 0.24702011956482328d), radius: 0.2009048851683083d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6275538927150769d, y: 0.2833529449442517d), radius: 0.4888872114550846d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 156,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45658833978347435d, y: 0.7912152573796795d), radius: 0.7741325570858105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.702340231003113d, y: 0.3521653805451098d), radius: 0.9587104422512349d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7043856242956699d, y: 0.7801617931544256d), radius: 0.5720307710340481d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7995705129246403d, y: 0.9803784132678728d), radius: 0.5584345895669505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5438022491079031d, y: 0.9246516368020448d), radius: 0.5540816306958223d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8381734017465229d, y: 0.3766022242638175d), radius: 0.4348878522242776d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25373755343541105d, y: 0.9939973456316402d), radius: 0.8573568724858885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39701835986800127d, y: 0.310153938840115d), radius: 0.2301531160437067d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5075371599402558d, y: 0.9879292708729753d), radius: 0.071188262260508d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5889546665721562d, y: 0.16174902565190885d), radius: 0.4311276236354582d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.97969613995083d, y: 0.1670519466935142d), radius: 0.7003673487631319d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4929508443149768d, y: 0.29601494770305325d), radius: 0.6439196772518471d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5208489128650288d, y: 0.16538847194817174d), radius: 0.2590880465036278d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 163,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4464118864809654d, y: 0.4001063732853667d), radius: 0.25330624098798127d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5152180321026049d, y: 0.13478846309877335d), radius: 0.18518655991417443d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9403011012870524d, y: 0.5714206821017094d), radius: 0.7190467513633575d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4390627661762354d, y: 0.3336866507374491d), radius: 0.4595588166068283d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 169,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44334586663744646d, y: 0.07177418249553658d), radius: 0.4701244082358731d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6459398866839369d, y: 0.5714682417216411d), radius: 0.042543207130114724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7842560004356148d, y: 0.6976670807086534d), radius: 0.7238257756949692d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7509965588252084d, y: 0.7235439548798822d), radius: 0.4594092684933634d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8810602526887987d, y: 0.2988188964707955d), radius: 0.3745053799012463d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.718191934697189d, y: 0.08759097908822266d), radius: 0.10995880667495384d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0836903381258407d, y: 0.13941454606912163d), radius: 0.7130831001993938d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9283230658001526d, y: 0.36760786002514967d), radius: 0.6550596120146283d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7792605014581514d, y: 0.02863238005865676d), radius: 0.6803302762697557d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8862966495856706d, y: 0.16277093782538732d), radius: 0.5294089501860872d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45190793130653806d, y: 0.7932074369054095d), radius: 0.701864077758561d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069481515910739d, y: 0.19312356921323137d), radius: 0.1762754065563289d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6068108053606208d, y: 0.8259474388004026d), radius: 0.37882636994020535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04495678537014225d, y: 0.8844035121271624d), radius: 0.5547895547986289d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9302195363709366d, y: 0.3915924423687155d), radius: 0.5116777776920362d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2592051996145964d, y: 0.18969171707112298d), radius: 0.7416872841746158d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2990836286896349d, y: 0.45062117280285596d), radius: 0.492468447127688d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5611931145611482d, y: 0.9102797425804051d), radius: 0.05525105408462083d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7713700664617161d, y: 0.21827438794591703d), radius: 0.2753186370918246d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 181,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9105996714658033d, y: 0.10270216513050612d), radius: 0.5674714420705955d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42344325518863946d, y: 0.3633329333273194d), radius: 0.4047263308479535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6175002676205263d, y: 0.5996257144805855d), radius: 0.7110418425390669d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24650088224432343d, y: 0.8682854432810372d), radius: 0.9217077444850065d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4532517438114202d, y: 0.5816373616793323d), radius: 0.5479509772765713d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8057197096094464d, y: 0.06081496824388111d), radius: 0.41502438352926907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8931791949329971d, y: 0.7153080033038701d), radius: 0.4942519527702961d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3696849383851496d, y: 0.28802374521307406d), radius: 0.33208726063693217d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7445991025271756d, y: 0.1434216327527703d), radius: 0.3140241270795402d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6066084123955241d, y: 0.4140637224277155d), radius: 0.3416034170752502d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8315155282710089d, y: 0.22260528165067128d), radius: 0.6106295333783457d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5863426626177793d, y: 0.6333936350895109d), radius: 0.04694489918324651d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.566357495218684d, y: 0.4377906186029855d), radius: 0.9281489006095281d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4094960953948593d, y: 0.26482160355472084d), radius: 0.8459543098372574d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20567817791266418d, y: 0.025359993288302962d), radius: 0.6668871042115702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8166418444341657d, y: 0.795659461556498d), radius: 0.35298620906804357d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 186,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37896153434935476d, y: 0.6929148010347108d), radius: 0.6813615711759815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15713709929132935d, y: 0.025203471114974674d), radius: 0.37781545114582693d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5522913814145579d, y: 0.19254359964821588d), radius: 0.09261310705041625d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8707697488750175d, y: 0.36522852784473847d), radius: 0.2313230241542592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.553396181334602d, y: 0.7421186615316051d), radius: 0.39824323770742764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8173709728791012d, y: 0.5657888147474548d), radius: 0.6782758746302362d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1mi(
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
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

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd1e1mi_id", 
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
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09017613270033753d, y: 0.025202246987059862d), radius: 0.3500506511662388d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9130554837038536d, y: 0.6250228828132607d), radius: 0.5859583226801799d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9523936057545802d, y: 0.13897035865214102d), radius: 0.9178830680572736d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlCircle[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483643);
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

                    nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclemmarrayd1e1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclemmarrayd1e1mi_id
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
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlCircle[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclemmarrayd1e1mi_id", 
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
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7403035582884161d, y: 0.8930102172850065d), radius: 0.4694151389343486d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10039099057752121d, y: 0.7172944399130586d), radius: 0.4240818886794383d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47832576120611514d, y: 0.8783321267292143d), radius: 0.25526289688271875d),
}));
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6784649793097176d, y: 0.044467869866090304d), radius: 0.6948393158121717d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7036551585545952d, y: 0.21677673943563835d), radius: 0.46148337352566493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9603890548296806d, y: 0.7759419879163346d), radius: 0.09327253482633857d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlCircle[] nullable = null;
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7908485498806996d, y: 0.6347160086821797d), radius: 0.7493091775149293d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9538536050706504d, y: 0.37525600441047513d), radius: 0.09633559586266272d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4514832590671859d, y: 0.978455372030913d), radius: 0.667724317274249d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD1E1M> models = null;

                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleMMArrayD1E1M> models = null;

                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 162;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[34], false);
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
                parametr2.Value = 133;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 156;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 140;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 130;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 175;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 149;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 99;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 31;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M), typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 163, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 163, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var models2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 88, query1, 94, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 163, query1, 17, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[32],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 111, query1, 162, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 149, query1, 175, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 88, query1, 17, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[32],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleMMArrayD1E1M>();
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 48, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[34], false);
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
FROM public.npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
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
                var models = await((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 141, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 127, 162))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleMArraycircleMMArrayD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 72);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[12], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[13], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[14], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[15], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[16], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[17], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[18], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[19], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[20], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[21], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[22], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[23], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[24], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[25], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[26], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[27], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[28], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[29], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[30], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[31], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[32], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[33], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 67);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(24));

                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleMMArrayD1E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleMMArrayD1E1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
FROM public.binary_npgsqlcirclecirclemmarrayd1e1m m
LEFT JOIN public.binary_npgsqlcirclecirclemmarrayd1e1mi mi ON mi.id = m.npgsqlcirclecirclemmarrayd1e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleMMArrayD1E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleMArraycircleMMArrayD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclemmarrayd1e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleMMArrayD1E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
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
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI), typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MI>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643),
                (NpgsqlTypes.NpgsqlDbType)(-2147483643)
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclemmarrayd1e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA), typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                var models2 = new List<NpgsqlCirclecircleMMArrayD1E1MIWA>();
                ((INpgsqlCircleMArraycircleMMArrayD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclemmarrayd1e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleMMArrayD1E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleMArraycircleMMArrayD1))]
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
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleMArraycircleMMArrayD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleMMArrayD1E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

