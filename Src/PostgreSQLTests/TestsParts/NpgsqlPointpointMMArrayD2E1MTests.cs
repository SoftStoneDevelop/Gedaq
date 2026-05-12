

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
    internal partial interface INpgsqlPointMArraypointMMArrayD2
    {
    }
    
    internal partial class NpgsqlPointMArraypointMMArrayD2 : INpgsqlPointMArraypointMMArrayD2
    {


#region TestData

        private readonly NpgsqlPointpointMMArrayD2E1M[] _testData = new NpgsqlPointpointMMArrayD2E1M[]
        {
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9146705941186517d, y: 0.08706683292586392d), new NpgsqlTypes.NpgsqlPoint(x: 0.45067789992700835d, y: 0.39293446757920225d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1513589049473103d, y: 0.8146606354140651d), new NpgsqlTypes.NpgsqlPoint(x: 0.7675829159756471d, y: 0.47657052609806094d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6124828604050708d, y: 0.8142289211339785d), new NpgsqlTypes.NpgsqlPoint(x: 0.025774315968558725d, y: 0.30252469063489007d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3679152525462307d, y: 0.032932662962580794d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657750916962608d, y: 0.568594139790882d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.07920568515860982d, y: 0.27382952853597964d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503280622129185d, y: 0.14942480570515504d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.32865382729558423d, y: 0.7901823650141804d), new NpgsqlTypes.NpgsqlPoint(x: 0.41888963169834237d, y: 0.4112751273723573d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.65695336975725d, y: 0.1827224530940078d), new NpgsqlTypes.NpgsqlPoint(x: 0.03218967537107753d, y: 0.17452699810155992d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5388201854418196d, y: 0.8775868626222557d), new NpgsqlTypes.NpgsqlPoint(x: 0.954586182248504d, y: 0.5403769724972639d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2410357229279333d, y: 0.5864636929221063d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144473536195404d, y: 0.8870390219554055d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.41865599840771694d, y: 0.7390105464246048d), new NpgsqlTypes.NpgsqlPoint(x: 0.632287085251019d, y: 0.36953950146791603d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5740283196055401d, y: 0.997839127221352d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667052779374018d, y: 0.7667669585584502d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6802132281362442d, y: 0.9820316634405343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799403596933966d, y: 0.15597581067431565d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9054326571724296d, y: 0.9569374909274767d), new NpgsqlTypes.NpgsqlPoint(x: 0.6285254193725512d, y: 0.0177284549306157d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3993162292537832d, y: 0.5628140433044415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015236780842773d, y: 0.8017785269655228d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8245542510368786d, y: 0.1041042520564246d), new NpgsqlTypes.NpgsqlPoint(x: 0.984665569440526d, y: 0.5127297087486113d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9720683598487981d, y: 0.37523084866632606d), new NpgsqlTypes.NpgsqlPoint(x: 0.36693091084652885d, y: 0.29752949764688785d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8618048085928447d, y: 0.8779907360762693d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485023317665011d, y: 0.45112670052346626d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.005833738430108704d, y: 0.6518559170554122d), new NpgsqlTypes.NpgsqlPoint(x: 0.9432601219098314d, y: 0.9238825011018192d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.885918651151187d, y: 0.8053049121936672d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847731872312842d, y: 0.17388521317783645d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3536041302450933d, y: 0.33938744062094506d), new NpgsqlTypes.NpgsqlPoint(x: 0.3831628734732133d, y: 0.9068708436944519d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.35640338065700017d, y: 0.6470333974568202d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968998621266751d, y: 0.4808298577860215d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.803261175069095d, y: 0.9174585366980824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407762066997d, y: 0.8862761175427484d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8119212842125243d, y: 0.9312399067177115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913544761169129d, y: 0.8699503343012277d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7025489598720137d, y: 0.024859280960754848d), new NpgsqlTypes.NpgsqlPoint(x: 0.28422389185332875d, y: 0.43333387179346883d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.570272524999985d, y: 0.6635468472645062d), new NpgsqlTypes.NpgsqlPoint(x: 0.8886694527077071d, y: 0.8440056245596054d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.536354353474895d, y: 0.014913284501951063d), new NpgsqlTypes.NpgsqlPoint(x: 0.4704668318693125d, y: 0.4204741980637636d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6774508052595619d, y: 0.5899507715251397d), new NpgsqlTypes.NpgsqlPoint(x: 0.22644439205473887d, y: 0.39267953752678586d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.513757455920046d, y: 0.06787814703266348d), new NpgsqlTypes.NpgsqlPoint(x: 0.19306675600769063d, y: 0.6023443972081866d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7193777981890757d, y: 0.35397673843913924d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560144230403216d, y: 0.14162589795835745d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.929407158312731d, y: 0.577189683217193d), new NpgsqlTypes.NpgsqlPoint(x: 0.38920301613179387d, y: 0.8784312081129015d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7958225514077998d, y: 0.24769540236633358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404754238001693d, y: 0.9511018231648176d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.31574142035592123d, y: 0.8719174799427198d), new NpgsqlTypes.NpgsqlPoint(x: 0.19445882161201156d, y: 0.16484236805600627d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9808306653909257d, y: 0.3290480636397356d), new NpgsqlTypes.NpgsqlPoint(x: 0.8159888452770124d, y: 0.7840850387885667d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6051251216576168d, y: 0.43344657938258513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592252393210448d, y: 0.39598821071428447d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.27978608430290697d, y: 0.1955752350476233d), new NpgsqlTypes.NpgsqlPoint(x: 0.4969993246382083d, y: 0.9303841948138368d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6218054311577907d, y: 0.27412653270509924d), new NpgsqlTypes.NpgsqlPoint(x: 0.638204053215838d, y: 0.7079533506686126d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2928372420359404d, y: 0.650482857752847d), new NpgsqlTypes.NpgsqlPoint(x: 0.5065247170529354d, y: 0.4452555966184102d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1035602196992429d, y: 0.2008872451595901d), new NpgsqlTypes.NpgsqlPoint(x: 0.2088944091088749d, y: 0.1148898672570674d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4051380448067846d, y: 0.2473555353256368d), new NpgsqlTypes.NpgsqlPoint(x: 0.9329920976347797d, y: 0.745785851039728d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3008906722793542d, y: 0.40506845703629957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720453635838147d, y: 0.11945342792421232d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3497526980508572d, y: 0.4838762756325238d), new NpgsqlTypes.NpgsqlPoint(x: 0.6250846602576653d, y: 0.38884494667157565d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3345280349308637d, y: 0.08084893766428425d), new NpgsqlTypes.NpgsqlPoint(x: 0.023395389905125463d, y: 0.23676059027828655d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7312371867450234d, y: 0.8726321850379561d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925011545437315d, y: 0.8881840761496115d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.09171920009188939d, y: 0.5088058999275594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591944209971469d, y: 0.9691275240882123d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8944772829392743d, y: 0.2962194449243519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826169536088281d, y: 0.3880562875376773d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4485089870062269d, y: 0.9966396596794028d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072073954589164d, y: 0.9254761379375787d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.05767766349183556d, y: 0.25316092710646443d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798715747352863d, y: 0.14290199903828793d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8600536386982656d, y: 0.39391277582917805d), new NpgsqlTypes.NpgsqlPoint(x: 0.9035085488685751d, y: 0.04864329374648235d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.48297322837217027d, y: 0.2551601597899362d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581279418814255d, y: 0.3679121398073406d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5600168717399605d, y: 0.727622375022488d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999485191816648d, y: 0.37250975889563986d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.03939758301875773d, y: 0.2876076702768764d), new NpgsqlTypes.NpgsqlPoint(x: 0.31837863075523143d, y: 0.28521762082457724d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.434814625934435d, y: 0.6021412040484111d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759609347187105d, y: 0.7792828223501209d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5491735651876689d, y: 0.26035006873733824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9215788858279994d, y: 0.7618547648162238d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6355776313311535d, y: 0.012051950539483602d), new NpgsqlTypes.NpgsqlPoint(x: 0.0353481361254111d, y: 0.9136574878541389d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.06121883967213981d, y: 0.6690359630341708d), new NpgsqlTypes.NpgsqlPoint(x: 0.342371005900753d, y: 0.8807583575888867d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.43124926019628196d, y: 0.3829139016002978d), new NpgsqlTypes.NpgsqlPoint(x: 0.22086415367803625d, y: 0.9093042224392138d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.1496965152586447d, y: 0.8112048955053881d), new NpgsqlTypes.NpgsqlPoint(x: 0.16900824845948414d, y: 0.4375335968129963d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9931703933363575d, y: 0.7192470066558031d), new NpgsqlTypes.NpgsqlPoint(x: 0.3029865131793239d, y: 0.9004386566653535d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.653829409668068d, y: 0.6898182788167292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9991759662203835d, y: 0.8950715485584096d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5940293919844325d, y: 0.040294489601152894d), new NpgsqlTypes.NpgsqlPoint(x: 0.27351289413933466d, y: 0.9903614624176204d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9771904663769956d, y: 0.18946272073423953d), new NpgsqlTypes.NpgsqlPoint(x: 0.6805482847581565d, y: 0.5308227140482762d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8426864619052883d, y: 0.2788433786609299d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568254191004986d, y: 0.5843632005425932d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5624585083632837d, y: 0.17572903514920601d), new NpgsqlTypes.NpgsqlPoint(x: 0.05036499098861569d, y: 0.7378201285379652d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2877189926386069d, y: 0.1889656243991098d), new NpgsqlTypes.NpgsqlPoint(x: 0.9163965735652965d, y: 0.26646776472657907d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6054000273691048d, y: 0.15139379546630816d), new NpgsqlTypes.NpgsqlPoint(x: 0.2605138733085406d, y: 0.9347027612494282d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.23473685966872815d, y: 0.6248629586164124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7363173745824363d, y: 0.007601318959652437d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5261381833320028d, y: 0.8901975286505565d), new NpgsqlTypes.NpgsqlPoint(x: 0.042817346479882d, y: 0.05746238657344993d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5165909311792513d, y: 0.593165731810012d), new NpgsqlTypes.NpgsqlPoint(x: 0.6720236198052942d, y: 0.3764227675745623d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.6002629966141468d, y: 0.19019615415072155d), new NpgsqlTypes.NpgsqlPoint(x: 0.1914190380645685d, y: 0.9351992347457544d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.45705856195916506d, y: 0.13785182051513334d), new NpgsqlTypes.NpgsqlPoint(x: 0.950166533000434d, y: 0.439596378477662d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8594728567474558d, y: 0.3207977095757949d), new NpgsqlTypes.NpgsqlPoint(x: 0.29994300740624635d, y: 0.9378300793633095d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8300872563612202d, y: 0.4812439876147502d), new NpgsqlTypes.NpgsqlPoint(x: 0.5257867786361002d, y: 0.0032880175519023336d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 93,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5317870434525513d, y: 0.27162689303992016d), new NpgsqlTypes.NpgsqlPoint(x: 0.3446428361904683d, y: 0.7649249460101356d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.4728995847602798d, y: 0.2467577418145731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9358978573394614d, y: 0.2943586857272785d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.049121753630821385d, y: 0.7963820232255179d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989851002718361d, y: 0.8044655075125504d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3671682495242369d, y: 0.9305798571018576d), new NpgsqlTypes.NpgsqlPoint(x: 0.3616494477567497d, y: 0.43209492772887925d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.0006054790608618354d, y: 0.9181480211310166d), new NpgsqlTypes.NpgsqlPoint(x: 0.9149853964119367d, y: 0.3492557192558533d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.44138356119454436d, y: 0.9255353811118772d), new NpgsqlTypes.NpgsqlPoint(x: 0.5517161966512285d, y: 0.20848201920838239d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.45151827540356726d, y: 0.31774447037235076d), new NpgsqlTypes.NpgsqlPoint(x: 0.775153425734053d, y: 0.821759324243464d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3043227723500722d, y: 0.09014505470860379d), new NpgsqlTypes.NpgsqlPoint(x: 0.15167107051984385d, y: 0.8409240961368644d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.40440441316870945d, y: 0.9640020176503105d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476274012331128d, y: 0.4068407560084455d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.330862522829625d, y: 0.55812980430953d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091733418169666d, y: 0.4915296772824784d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3319602953599101d, y: 0.5378399771576308d), new NpgsqlTypes.NpgsqlPoint(x: 0.2715502904458018d, y: 0.5167968279649144d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.660533390585217d, y: 0.7041785546676321d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141765505318442d, y: 0.055483654962377504d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4688866411988345d, y: 0.4499293717286915d), new NpgsqlTypes.NpgsqlPoint(x: 0.08091187931906763d, y: 0.9515175245395365d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6748412059771075d, y: 0.939222334431261d), new NpgsqlTypes.NpgsqlPoint(x: 0.7066122556521995d, y: 0.4625249108840238d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9779108682196549d, y: 0.8737653540370445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7918199733618204d, y: 0.29193811042143425d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5387595472445277d, y: 0.48248933482191037d), new NpgsqlTypes.NpgsqlPoint(x: 0.4742627195190696d, y: 0.04056947464915328d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5069059057513546d, y: 0.2775873263730907d), new NpgsqlTypes.NpgsqlPoint(x: 0.7960591102894474d, y: 0.36087762871357065d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9476611645215526d, y: 0.24144072718630238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659754271972311d, y: 0.5773084094255684d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.29932794293617415d, y: 0.09203013959799544d), new NpgsqlTypes.NpgsqlPoint(x: 0.08238787260637992d, y: 0.4802055214543247d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6670660187572753d, y: 0.19461559789780536d), new NpgsqlTypes.NpgsqlPoint(x: 0.0882800030990728d, y: 0.41324137642011893d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4613952785021752d, y: 0.561199370792208d), new NpgsqlTypes.NpgsqlPoint(x: 0.36853057147239354d, y: 0.5553828466948655d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9627805921620253d, y: 0.03694092486606548d), new NpgsqlTypes.NpgsqlPoint(x: 0.5787120825345012d, y: 0.9789515056120545d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.04725604049664811d, y: 0.22008115986791987d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991993676139673d, y: 0.8244175287982863d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.10331936730697433d, y: 0.34267985528795586d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862280725706715d, y: 0.4087767147996171d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.007969213784479456d, y: 0.49935397215197974d), new NpgsqlTypes.NpgsqlPoint(x: 0.3653220352142754d, y: 0.13116703879198977d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.35170502019384864d, y: 0.16876634844846383d), new NpgsqlTypes.NpgsqlPoint(x: 0.11406614561081296d, y: 0.8606631461797755d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.09524761083791222d, y: 0.6968967573871729d), new NpgsqlTypes.NpgsqlPoint(x: 0.930829749577453d, y: 0.6637402033626101d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.2200595537253336d, y: 0.7633572022220443d), new NpgsqlTypes.NpgsqlPoint(x: 0.5240656790026003d, y: 0.7335544077674878d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.438179876831732d, y: 0.665234369089003d), new NpgsqlTypes.NpgsqlPoint(x: 0.900891929751068d, y: 0.7828674585488204d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5317913480041166d, y: 0.7853931099369245d), new NpgsqlTypes.NpgsqlPoint(x: 0.3742002346549008d, y: 0.19390808356239286d), }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7748199958244091d, y: 0.19038352695661354d), new NpgsqlTypes.NpgsqlPoint(x: 0.3954911907988967d, y: 0.23841204901213708d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9138742344864025d, y: 0.12566263318042592d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677861843750115d, y: 0.16970638690088669d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8526852893830589d, y: 0.8085328773780462d), new NpgsqlTypes.NpgsqlPoint(x: 0.35132218932583104d, y: 0.7326999003007204d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7882132127509335d, y: 0.7873143722043815d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798815453279594d, y: 0.4099550648972169d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7957806428066948d, y: 0.571882423947458d), new NpgsqlTypes.NpgsqlPoint(x: 0.21307041052878095d, y: 0.7186455691508411d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8072668858166552d, y: 0.486620593244265d), new NpgsqlTypes.NpgsqlPoint(x: 0.2306770609054195d, y: 0.5344144094634375d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2828178184619978d, y: 0.9132051749378903d), new NpgsqlTypes.NpgsqlPoint(x: 0.45768777341663847d, y: 0.8438000044657563d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.12983460778956213d, y: 0.3793335711271718d), new NpgsqlTypes.NpgsqlPoint(x: 0.5721413155936709d, y: 0.3916458613731083d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.272822485064676d, y: 0.9867691476194536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6826312170822737d, y: 0.4008383072429438d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.9881734406450343d, y: 0.6297952177727508d), new NpgsqlTypes.NpgsqlPoint(x: 0.10950750851385105d, y: 0.2250580648861008d), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.48823505322784044d, y: 0.22701532793891532d), new NpgsqlTypes.NpgsqlPoint(x: 0.0854961912892207d, y: 0.384658590495656d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.1329699133842991d, y: 0.36656715802623696d), new NpgsqlTypes.NpgsqlPoint(x: 0.14924621516160042d, y: 0.23938420917754988d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 143,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3155813627621431d, y: 0.8531624057675541d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032898087412492d, y: 0.3263529057399236d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7897197218223759d, y: 0.9544407168175033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3213187093967743d, y: 0.7450158233341071d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5671904667750098d, y: 0.5384208441429713d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878691404963809d, y: 0.042850793226710815d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.038176548024346224d, y: 0.30108160494220215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207017142394d, y: 0.0373136073601974d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2400337705639921d, y: 0.5677171824229859d), new NpgsqlTypes.NpgsqlPoint(x: 0.4902965394384945d, y: 0.3265186362546084d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8684399496160558d, y: 0.48185945500265637d), new NpgsqlTypes.NpgsqlPoint(x: 0.13791703579224324d, y: 0.8408884365881969d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.5333930376030012d, y: 0.23105315110631663d), new NpgsqlTypes.NpgsqlPoint(x: 0.37928219722891987d, y: 0.6820080535341455d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.8541275319262781d, y: 0.8640879272217438d), new NpgsqlTypes.NpgsqlPoint(x: 0.48701547429363d, y: 0.9439368255770662d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4716871989344634d, y: 0.5806429748836868d), new NpgsqlTypes.NpgsqlPoint(x: 0.7617132290717229d, y: 0.6031071204048674d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3335655587151728d, y: 0.47327541199194956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8891732939552278d, y: 0.9530321759891285d), }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 157,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.32972783325975785d, y: 0.3994374046236663d), new NpgsqlTypes.NpgsqlPoint(x: 0.303525447255769d, y: 0.8561506184197444d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.21293710778265684d, y: 0.5342069892123696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639216626339498d, y: 0.7444049306161272d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.22501557444822473d, y: 0.5599774040005436d), new NpgsqlTypes.NpgsqlPoint(x: 0.06225503664277687d, y: 0.9953457166745147d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7932929545412527d, y: 0.3096738458626431d), new NpgsqlTypes.NpgsqlPoint(x: 0.6582750599317125d, y: 0.39272257682826694d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.44640269855210324d, y: 0.7850643826716158d), new NpgsqlTypes.NpgsqlPoint(x: 0.9493788530208147d, y: 0.17803075731331852d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6991186509217915d, y: 0.3105817453188222d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536801646920833d, y: 0.8440776716517472d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2642116178151497d, y: 0.7499096995563873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211075812810342d, y: 0.4529825815413514d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6852911436417218d, y: 0.2329201534123656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6308974028144256d, y: 0.3391490957147699d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8288173474257112d, y: 0.1484154067547374d), new NpgsqlTypes.NpgsqlPoint(x: 0.6949467085401343d, y: 0.2993414658046859d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5193870273195552d, y: 0.5021279081926182d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806886511558758d, y: 0.6805091494732984d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.8866624370444971d, y: 0.7547844552359488d), new NpgsqlTypes.NpgsqlPoint(x: 0.014784020444572499d, y: 0.4819132749064927d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.5348632566688672d, y: 0.8079144759560166d), new NpgsqlTypes.NpgsqlPoint(x: 0.22277072228170314d, y: 0.4693790665191808d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 68,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.9259962703640098d, y: 0.747990982237496d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194988710956926d, y: 0.5344154626571366d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.49824464614883623d, y: 0.2984593392524001d), new NpgsqlTypes.NpgsqlPoint(x: 0.45776185710535977d, y: 0.1320452714387711d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4970723261316856d, y: 0.40351458306314114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556852203743831d, y: 0.1374985505814713d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7936902404283496d, y: 0.5687991985357448d), new NpgsqlTypes.NpgsqlPoint(x: 0.06733796482402987d, y: 0.7196657929428711d), }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.2774957472624635d, y: 0.9244358482462421d), new NpgsqlTypes.NpgsqlPoint(x: 0.5164934623442774d, y: 0.502285546159585d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.7686825905438425d, y: 0.5822521081955323d), new NpgsqlTypes.NpgsqlPoint(x: 0.22889192664153246d, y: 0.008900983276418528d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.546842004833437d, y: 0.11463302674264686d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907640688950697d, y: 0.7349051295832347d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.36686272898801364d, y: 0.3235646117156592d), new NpgsqlTypes.NpgsqlPoint(x: 0.75033384682718d, y: 0.11532300894311476d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.49026526615297217d, y: 0.6877795325657251d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298637741673073d, y: 0.6507962803432088d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.27355453964823706d, y: 0.9297036081015232d), new NpgsqlTypes.NpgsqlPoint(x: 0.13150831894242188d, y: 0.2982978888480604d), }, },
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 175,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.01671767903302812d, y: 0.2586243277079363d), new NpgsqlTypes.NpgsqlPoint(x: 0.003146896432592361d, y: 0.9205932024142737d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.547032236631497d, y: 0.7748576155377123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5439201047353438d, y: 0.783151982752399d), }, },
    ModelInner = new NpgsqlPointpointMMArrayD2E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.07597191088545663d, y: 0.4205822166028178d), new NpgsqlTypes.NpgsqlPoint(x: 0.3385056158535501d, y: 0.7050013997351893d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.019128780989471683d, y: 0.27403420479576135d), new NpgsqlTypes.NpgsqlPoint(x: 0.36786799643491896d, y: 0.382647003173333d), }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.48681572409087537d, y: 0.9388151810887112d), new NpgsqlTypes.NpgsqlPoint(x: 0.03710213367377957d, y: 0.6198896291358499d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.3456866821605975d, y: 0.8001072542431518d), new NpgsqlTypes.NpgsqlPoint(x: 0.9332663781413663d, y: 0.21318469923792083d), }, },
},
    NullableValue = null,
},
            new NpgsqlPointpointMMArrayD2E1M
{
    Id = 177,
    Value = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.3149124754640724d, y: 0.02106107875474794d), new NpgsqlTypes.NpgsqlPoint(x: 0.17196719824696582d, y: 0.735768159319294d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6506576779486746d, y: 0.13784753665172889d), new NpgsqlTypes.NpgsqlPoint(x: 0.7022743678221184d, y: 0.7445432300108431d), }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.4591217379816789d, y: 0.01966549845691201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9630349605063618d, y: 0.7475691621525424d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.6450769380161329d, y: 0.5198855272982955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592728138703099d, y: 0.004869245858071358d), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1mi(
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
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
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

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.35640338065700017d, y: 0.6470333974568202d), new NpgsqlTypes.NpgsqlPoint(x: 0.1968998621266751d, y: 0.4808298577860215d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.803261175069095d, y: 0.9174585366980824d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407762066997d, y: 0.8862761175427484d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.7958225514077998d, y: 0.24769540236633358d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404754238001693d, y: 0.9511018231648176d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.31574142035592123d, y: 0.8719174799427198d), new NpgsqlTypes.NpgsqlPoint(x: 0.19445882161201156d, y: 0.16484236805600627d), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483633);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPoint[,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpointpointmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    npgsqlpointpointmmarrayd2e1mi_id
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
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPoint[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483633)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpointpointmmarrayd2e1mi_id", 
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
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPoint[,] nullable = null;
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPointMArraypointMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPoint[,] { { new NpgsqlTypes.NpgsqlPoint(x: 0.06121883967213981d, y: 0.6690359630341708d), new NpgsqlTypes.NpgsqlPoint(x: 0.342371005900753d, y: 0.8807583575888867d), }, { new NpgsqlTypes.NpgsqlPoint(x: 0.43124926019628196d, y: 0.3829139016002978d), new NpgsqlTypes.NpgsqlPoint(x: 0.22086415367803625d, y: 0.9093042224392138d), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPointpointMMArrayD2E1M> models = null;

                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPointMArraypointMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 174;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 68;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 3;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[33],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 52;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 164;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 157;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 93;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 132;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M), typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 3, query1, 102, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 46, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var models2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 123, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[32],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var firstItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 131, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[31],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 9, query1, 37, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 143, query1, 174, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 85, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
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
FROM public.npgsqlpointpointmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems1 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                var secondItems2 = new List<FlatNpgsqlPointpointMMArrayD2E1M>();
                 ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 26, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPointpointMMArrayD2E1M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 167, 132))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[34], false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPointMArraypointMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 85, 85))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 3);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[1], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[2], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[3], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[4], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[5], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[6], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[6],_testData[7], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[7],_testData[8], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[8],_testData[9], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[9],_testData[10], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[10],_testData[11], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[11],_testData[12], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[12],_testData[13], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[13],_testData[14], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[14],_testData[15], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[15],_testData[16], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[16],_testData[17], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[17],_testData[18], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[18],_testData[19], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[19],_testData[20], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[20],_testData[21], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[21],_testData[22], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[22],_testData[23], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[23],_testData[24], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[24],_testData[25], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[25],_testData[26], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[26],_testData[27], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[27],_testData[28], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[28],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[29],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[30],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[31],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[32],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPointMArraypointMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPointMArraypointMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));

                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                NpgsqlPointpointMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MI),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpointpointmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPointpointMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPointpointMMArrayD2E1M),
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
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
FROM public.binary_npgsqlpointpointmmarrayd2e1m m
LEFT JOIN public.binary_npgsqlpointpointmmarrayd2e1mi mi ON mi.id = m.npgsqlpointpointmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPointMArraypointMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPointpointMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPointMArraypointMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpointpointmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models =  ((INpgsqlPointMArraypointMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPointpointMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
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
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI), typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MI>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2)),
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpointpointmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA), typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                await ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                var models2 = new List<NpgsqlPointpointMMArrayD2E1MIWA>();
                ((INpgsqlPointMArraypointMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpointpointmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPointpointMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPointMArraypointMMArrayD2))]
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
                var models = await ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPointMArraypointMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPointpointMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

