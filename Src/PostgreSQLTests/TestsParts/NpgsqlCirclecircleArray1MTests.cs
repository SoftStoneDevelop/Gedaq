

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
    internal partial interface INpgsqlCircleArraycircleArray
    {
    }
    
    internal partial class NpgsqlCircleArraycircleArray : INpgsqlCircleArraycircleArray
    {


#region TestData

        private readonly NpgsqlCirclecircleArray1M[] _testData = new NpgsqlCirclecircleArray1M[]
        {
            new NpgsqlCirclecircleArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06766918311022752d, y: 0.5423746701574818d), radius: 0.4104455742182376d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6480721545461288d, y: 0.1514861139485857d), radius: 0.18588627142943193d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6237275065533887d, y: 0.47714835718396154d), radius: 0.4891386902629734d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31571168550511475d, y: 0.8276015874818441d), radius: 0.21908207308581196d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7437338345143334d, y: 0.42670531722114546d), radius: 0.10755925601107752d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3278695615685011d, y: 0.5215797450529596d), radius: 0.6367444840221548d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.509196895189966d, y: 0.6784299679445912d), radius: 0.17814583620951874d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8432683146852745d, y: 0.7667063541831808d), radius: 0.7674833770749684d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13117141126193288d, y: 0.947434211788631d), radius: 0.41555913268013633d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.58078318453472d, y: 0.32747461504548747d), radius: 0.5704882596804824d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9953928400147112d, y: 0.521812178252182d), radius: 0.7999100110859508d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7774791556454237d, y: 0.14539003912153103d), radius: 0.9560712863504105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4682191513921421d, y: 0.42413574111992924d), radius: 0.9314630424582985d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7549172329371113d, y: 0.7463942197467449d), radius: 0.04392526496301541d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8645136552958955d, y: 0.4270624013887032d), radius: 0.9048666548252094d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8576148776903322d, y: 0.17086443752092706d), radius: 0.7368880578848386d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45985568656514286d, y: 0.22441788431127374d), radius: 0.516893573570501d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0973871567501482d, y: 0.8786844293764845d), radius: 0.06594193087699773d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8200855395255497d, y: 0.8801952118113248d), radius: 0.4818697810391218d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8652273118503508d, y: 0.42936375558338913d), radius: 0.4054564226061381d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9415948336362266d, y: 0.3441457906508527d), radius: 0.9023080736940682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28759283631148447d, y: 0.5544683779961882d), radius: 0.7924263637588209d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.551613581974113d, y: 0.8649032312856417d), radius: 0.2058227910704843d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6579060882883129d, y: 0.7419664880118515d), radius: 0.14642344579414968d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43265195088278596d, y: 0.049353857086708586d), radius: 0.7520455686733507d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9926436413534022d, y: 0.34980562489456213d), radius: 0.8335759250489081d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1122498814321643d, y: 0.8316888678068759d), radius: 0.28659616232147567d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40770905451795314d, y: 0.5491543099019903d), radius: 0.4885323666124728d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6879285175365467d, y: 0.8381106288495667d), radius: 0.13456992895054332d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.058499128541332546d, y: 0.564167114054901d), radius: 0.34799520289490804d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2551434126366765d, y: 0.6986442738915032d), radius: 0.21907406485816605d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3380188727556471d, y: 0.4817261218932999d), radius: 0.9361672652428216d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11537262800936277d, y: 0.8163345503102273d), radius: 0.09505549811333258d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8813692695041764d, y: 0.7442347616071101d), radius: 0.5894218164249223d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31223774611992317d, y: 0.9676800593238887d), radius: 0.3995741221403821d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.381967301106626d, y: 0.6565333881149888d), radius: 0.6336370957668427d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4448334111111837d, y: 0.07067077273012878d), radius: 0.8939033806370671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.829559415497193d, y: 0.7413027342383863d), radius: 0.26895217083012346d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7647211266128695d, y: 0.9853971034304502d), radius: 0.41826323567677814d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027767325951977617d, y: 0.4073645898559167d), radius: 0.4808173107239174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15355609824488448d, y: 0.3336017652913382d), radius: 0.2753692789317904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9838390117594475d, y: 0.23540916760184016d), radius: 0.743641972749213d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7252162234316837d, y: 0.6741546741518651d), radius: 0.2640341998578075d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021561625454261213d, y: 0.4714332645523851d), radius: 0.3009663418659493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7399148945819723d, y: 0.8681669415774023d), radius: 0.5712999681284199d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.358556242208376d, y: 0.2590998759522155d), radius: 0.7142272811620297d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6170304499806467d, y: 0.4275016036878658d), radius: 0.0017457022528676314d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.999705820430707d, y: 0.08813823681692712d), radius: 0.7791897924673784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1916317985054865d, y: 0.8575853308213985d), radius: 0.5067760605031455d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32956771802058815d, y: 0.3166441481896459d), radius: 0.5132871927211493d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7852658013732341d, y: 0.16969336303421267d), radius: 0.02145547304963069d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8012216662386258d, y: 0.14571709296495372d), radius: 0.839211698116834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4573386069124096d, y: 0.8559259564118343d), radius: 0.1793931286691537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5037062152706815d, y: 0.836380284253721d), radius: 0.9591847745561851d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5088743073692834d, y: 0.8516517333747574d), radius: 0.16511260653764426d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7346467929206965d, y: 0.36004678659052447d), radius: 0.5849461124489466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649588010069415d, y: 0.7337464046899748d), radius: 0.5317964208029278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7424016218073335d, y: 0.8935587480173762d), radius: 0.6280995402081567d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9304636583124948d, y: 0.3912902678096484d), radius: 0.6687313471925005d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7788069096672094d, y: 0.0858697016239468d), radius: 0.6730076128029563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9882294180344381d, y: 0.6924447891202137d), radius: 0.10611983951424797d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.615840338267297d, y: 0.43636866697278764d), radius: 0.6229267320637364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14764135669853473d, y: 0.40539611992533187d), radius: 0.4033854155839647d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3734247741276021d, y: 0.42599037468322454d), radius: 0.13032767092810305d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21462831667931603d, y: 0.07696468115270139d), radius: 0.8230322571345013d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25577821801247125d, y: 0.16057306727148435d), radius: 0.6310830286575184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7714036789589759d, y: 0.5039766316423725d), radius: 0.19701414629305525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3312909461290976d, y: 0.909597811291643d), radius: 0.4968953484633938d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09102689257250296d, y: 0.6353100277011234d), radius: 0.8580935446791075d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.57815048340658d, y: 0.9506130574735396d), radius: 0.19958218696445107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5946768225407223d, y: 0.23354947691277939d), radius: 0.3409834582536698d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5227062314267089d, y: 0.6674024825836443d), radius: 0.04808403191792532d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.964704361340022d, y: 0.058190799017984185d), radius: 0.8068411651327598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1617919300077041d, y: 0.28996262564705955d), radius: 0.915336957308126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7148531689917992d, y: 0.745187423474294d), radius: 0.0685853785575612d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4539310597394828d, y: 0.34933814818402964d), radius: 0.42815480073507806d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8251735266278729d, y: 0.2699160164471486d), radius: 0.17833590965609103d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8521041245314416d, y: 0.7854592230321491d), radius: 0.15059068467409853d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8965782051283243d, y: 0.9318007413459458d), radius: 0.1940354949573051d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3691445042345407d, y: 0.2975124456122463d), radius: 0.759252242903668d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7089145043420577d, y: 0.2594698413557809d), radius: 0.7145821279202004d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13779162954169266d, y: 0.14975702540982216d), radius: 0.5499361659263245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7192923322588043d, y: 0.9750028858147323d), radius: 0.5187237826981653d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19678755401483417d, y: 0.6990248911774203d), radius: 0.29243820541037946d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.47045298686735515d, y: 0.18967893177985795d), radius: 0.1708633298402028d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037303834369129985d, y: 0.6863053986498862d), radius: 0.8645405727209179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9748351538287177d, y: 0.4057948194059615d), radius: 0.13630873782721642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13835500694830083d, y: 0.7667531097115041d), radius: 0.561622383281462d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.555910465132235d, y: 0.1959224215629779d), radius: 0.5707108060106784d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9448688428287547d, y: 0.26033252160324627d), radius: 0.370540345829394d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4501234974453413d, y: 0.3557266705185913d), radius: 0.9287094945186021d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6336857011131576d, y: 0.04940986359194699d), radius: 0.21607029046206505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.561747799116669d, y: 0.36991294644125483d), radius: 0.5842491582202426d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6085497174170913d, y: 0.8048259566575215d), radius: 0.8240612433010539d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7784550259361013d, y: 0.7644112698815839d), radius: 0.33888421819090553d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.508659029055838d, y: 0.8096908261940653d), radius: 0.535382612777172d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5554396382532589d, y: 0.8092487351568796d), radius: 0.8055610350204997d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.025984077951157203d, y: 0.3940711143724862d), radius: 0.6095865103477243d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3962248587067688d, y: 0.549029128721743d), radius: 0.9043914209485996d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5445369069866874d, y: 0.0905767252734152d), radius: 0.24676503409975437d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1920164778701149d, y: 0.028800113965747887d), radius: 0.5220749991815642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7009456378617803d, y: 0.8467115728087516d), radius: 0.0671707520304935d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5774270492911647d, y: 0.1610710281541119d), radius: 0.611919850367784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9281022234388817d, y: 0.033818961515648005d), radius: 0.8201029343530085d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4273333058058071d, y: 0.8322267170346606d), radius: 0.7724108307152759d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5466397525781671d, y: 0.8859238928062171d), radius: 0.7399307931387221d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2482627831837344d, y: 0.7170725153143259d), radius: 0.9181574946897827d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2693605016802373d, y: 0.7323316353335911d), radius: 0.9890100985436491d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5245413272450342d, y: 0.9473567836138569d), radius: 0.6579211471527133d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9157426280708606d, y: 0.40160469677811217d), radius: 0.7035470739377261d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16324862966902576d, y: 0.9817475944893231d), radius: 0.08372957439209328d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5342265697207436d, y: 0.777197361122737d), radius: 0.22805608815716327d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9785083250118082d, y: 0.9372459215021467d), radius: 0.7711146008092371d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40778624185669243d, y: 0.842509010250406d), radius: 0.6503897197070297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9624914052410746d, y: 0.016523745869864603d), radius: 0.18436807309732928d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6291008064072353d, y: 0.5643964110776123d), radius: 0.6251408645700356d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5362774327638888d, y: 0.6849833179416104d), radius: 0.09764062269549179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9600213472636886d, y: 0.2820705511071595d), radius: 0.40292698486318834d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19113040383729585d, y: 0.4170766486072742d), radius: 0.8023719145567322d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9527025105776032d, y: 0.77259683286076d), radius: 0.6018960955277431d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9444717518113755d, y: 0.392164303560399d), radius: 0.7777819282022977d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7169804907656274d, y: 0.5116753492742365d), radius: 0.14830466443707147d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13813749065421366d, y: 0.867723098728757d), radius: 0.11475625410884882d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02522466809942614d, y: 0.24690893600057895d), radius: 0.4692101035322417d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07405088544402016d, y: 0.19496796257007065d), radius: 0.5672113172718773d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009841781866125165d, y: 0.5977192456256422d), radius: 0.7263812097098619d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 41,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1976002386134902d, y: 0.14311612371309446d), radius: 0.6252495404062475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1778524219332831d, y: 0.38357393701472176d), radius: 0.5403053030693139d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.496193007687195d, y: 0.6704583415958706d), radius: 0.9267972388356556d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.902795941798267d, y: 0.1719413498458493d), radius: 0.5679486703420497d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.011723424654727421d, y: 0.44330001233675853d), radius: 0.5589806667203364d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8362847167603072d, y: 0.687086030468135d), radius: 0.46431495042448256d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.014153345043641075d, y: 0.10995737248216064d), radius: 0.4919843042300379d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10546382836488388d, y: 0.3886070744105006d), radius: 0.759084139546204d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08008351403482061d, y: 0.38603382585372803d), radius: 0.8843194664884654d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073966218725956d, y: 0.07212907742346486d), radius: 0.25429987349573835d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31888530157136685d, y: 0.27613907121195425d), radius: 0.3570855449188045d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9759613989525271d, y: 0.09476125651304035d), radius: 0.9655350162339111d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5357613798373013d, y: 0.3874742350880711d), radius: 0.6152621124015765d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 44,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5426907479103538d, y: 0.06436482367556062d), radius: 0.6887342262399718d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6755901591355161d, y: 0.12470370942188191d), radius: 0.6714129774325044d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0337456275980893d, y: 0.8618499776758085d), radius: 0.15272236866978983d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7577093872879958d, y: 0.7590511881290752d), radius: 0.11703576534813442d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4380429734364347d, y: 0.1770381187345954d), radius: 0.41892074928897316d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7471579043494161d, y: 0.27760596023041995d), radius: 0.589344548718685d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9678982176729092d, y: 0.3629939384239388d), radius: 0.17934468315670438d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 95,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7020271714419937d, y: 0.5718825916635049d), radius: 0.29612371419663885d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15215807312538943d, y: 0.6857951984686799d), radius: 0.3952050341618525d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6349445484240972d, y: 0.07802781069395748d), radius: 0.806022305667935d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5470964334792147d, y: 0.8354835865545024d), radius: 0.7357036127132058d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 51,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32264374061228285d, y: 0.5791820178976202d), radius: 0.8599767636042162d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1384557905681013d, y: 0.5943025944890026d), radius: 0.9009358663690787d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5276160167591164d, y: 0.3759418435294012d), radius: 0.8682169038812978d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08746075522765928d, y: 0.5888630837739167d), radius: 0.14619753641585587d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020656309162791042d, y: 0.8331079215172021d), radius: 0.06616854615419598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15831883975894867d, y: 0.5160057722097429d), radius: 0.8167863628370877d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6120625076640683d, y: 0.2438600647897774d), radius: 0.323628442027899d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.769040460751622d, y: 0.7377091110173086d), radius: 0.5264362242066363d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02416245975084519d, y: 0.5332471787298229d), radius: 0.9774629736744247d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.042256802505816426d, y: 0.43486677687897946d), radius: 0.8392069122594805d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8546860541066842d, y: 0.34034078701775816d), radius: 0.5132877333135852d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7965936204501284d, y: 0.4653986515512959d), radius: 0.8359363228623189d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5551630034972355d, y: 0.9238514300228491d), radius: 0.604853482025216d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6722348844496863d, y: 0.24254601280941157d), radius: 0.7785119463193605d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.02826409247107231d, y: 0.5654757753959267d), radius: 0.5499068101048818d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254133005301607d, y: 0.940056247383204d), radius: 0.09083687898706994d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9341288960742755d, y: 0.9390230260307834d), radius: 0.6664375439128062d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2568140776085174d, y: 0.9443275753104036d), radius: 0.46286177442430476d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.752654673051568d, y: 0.6230158893278499d), radius: 0.47792904125877766d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7031602135865245d, y: 0.8703702470533257d), radius: 0.4748956434697391d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24169087906662512d, y: 0.21211311615398265d), radius: 0.028679635261836145d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19102991248637324d, y: 0.7547297211990758d), radius: 0.6746000766406922d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6667500227576237d, y: 0.1889500611632604d), radius: 0.5851074161299493d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2540171197450697d, y: 0.42050184092200327d), radius: 0.916868590646165d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7840011202979692d, y: 0.645826249475356d), radius: 0.5679370626568707d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5165563745487594d, y: 0.6819042814034794d), radius: 0.49162893414220243d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8488530213931625d, y: 0.7924393044716769d), radius: 0.20061943959766548d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35478722076765445d, y: 0.22349164166971525d), radius: 0.5341633840046519d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20746632269574006d, y: 0.37381719219559106d), radius: 0.05220510169344372d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36085134383301076d, y: 0.4702232123905379d), radius: 0.9752110422580625d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9286871681729961d, y: 0.6971490768492481d), radius: 0.7355764325944897d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.928583932621356d, y: 0.7394575631328885d), radius: 0.664304975304842d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7239313407991974d, y: 0.5115479200127468d), radius: 0.5579772467495526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6326954410799773d, y: 0.7030197133433889d), radius: 0.23638250762976687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5268937125757256d, y: 0.44775133921822796d), radius: 0.13191703646286568d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9080378872769552d, y: 0.8601189387780925d), radius: 0.9615444167648447d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16850848404362417d, y: 0.35906526465243127d), radius: 0.6153048151269208d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5150730710628756d, y: 0.2102245442153563d), radius: 0.4985536273440341d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8054075411460833d, y: 0.7884276082908847d), radius: 0.24896215728840565d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9481785562261893d, y: 0.7711026908831373d), radius: 0.790231883384475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2424827270115517d, y: 0.8789914255875633d), radius: 0.4690540262130193d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08849228989029989d, y: 0.8560039306601746d), radius: 0.7526108568436655d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.62157465108777d, y: 0.36470244884678626d), radius: 0.10567392973626444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8803209268885268d, y: 0.8418137947820351d), radius: 0.6906592145729682d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3153054096676572d, y: 0.011947865204885888d), radius: 0.4243303825072946d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8156810720402969d, y: 0.20125564375026006d), radius: 0.058427547294321425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36760189187173276d, y: 0.5635908846353362d), radius: 0.523387166922207d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16694104367428553d, y: 0.9576499229345646d), radius: 0.8105455647540163d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46312333055036325d, y: 0.42336364297863416d), radius: 0.5086024251223196d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44210146575130105d, y: 0.5374860346794758d), radius: 0.2649051668647239d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.01786425675958625d, y: 0.18244594245573453d), radius: 0.6828348142851642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6702763160340204d, y: 0.5290425759630327d), radius: 0.8443018421350891d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3093968350591304d, y: 0.8686042601138103d), radius: 0.38307534395426945d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12743631240494369d, y: 0.24044022832143896d), radius: 0.9829569346713282d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11573949968205499d, y: 0.8436456812146147d), radius: 0.6267468624008555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3040614036535856d, y: 0.3320897082875818d), radius: 0.8866398314239662d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13209778418780427d, y: 0.5064057680310305d), radius: 0.877173171991412d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1492626229053743d, y: 0.2606897934485882d), radius: 0.8225349784001348d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3980089916151991d, y: 0.9802359834079035d), radius: 0.6633147914721299d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 134,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39277498789936316d, y: 0.8154729702923965d), radius: 0.810670159919257d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9202044844081771d, y: 0.7427389651022903d), radius: 0.5068160852653544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6522309716002586d, y: 0.11519283758758359d), radius: 0.16005954435785918d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34752669300691774d, y: 0.47200038250636367d), radius: 0.9649734905966634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03633276837856936d, y: 0.42014956769174316d), radius: 0.5550177036981855d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17453580792521106d, y: 0.866404308273064d), radius: 0.9996848466203552d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8162503806682618d, y: 0.5532499684260435d), radius: 0.9964451770142351d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6136046128826088d, y: 0.09703899612176903d), radius: 0.599387472972374d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09717717531303982d, y: 0.7347125535395334d), radius: 0.4148408506039237d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8885140550211039d, y: 0.3879673010524499d), radius: 0.4485780493198611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8944785191839647d, y: 0.16185535695698938d), radius: 0.8792993449083634d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38964777742376466d, y: 0.3847683052833214d), radius: 0.3767864506611178d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4079780219637107d, y: 0.5736485615490841d), radius: 0.9359367194796107d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12975344949017786d, y: 0.6909390334308778d), radius: 0.36902828203014815d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2826521242198221d, y: 0.2860228808958073d), radius: 0.9678383408004126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6614132563362214d, y: 0.6027926033713344d), radius: 0.3058202948864973d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5205686313199044d, y: 0.06345781790679739d), radius: 0.8967767432343755d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5217645735645595d, y: 0.0395947331185742d), radius: 0.9808549682980675d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.31277756126390466d, y: 0.5485629354604925d), radius: 0.38230804494829784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2963048840966922d, y: 0.5710102584758694d), radius: 0.35828216956852266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6936195684942357d, y: 0.4870183129262784d), radius: 0.8946777972818599d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.333407754438967d, y: 0.09550204824191821d), radius: 0.7761103549508392d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5449282658440381d, y: 0.03300865582149015d), radius: 0.7349142644871514d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05645645278522082d, y: 0.7593537799576806d), radius: 0.8724036954465543d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14584346475039367d, y: 0.09029905446351749d), radius: 0.8091223569588346d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20484162207239764d, y: 0.6392808413252115d), radius: 0.34445727703398643d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25838039608739294d, y: 0.11282262332270865d), radius: 0.7529900508609219d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46366863150761184d, y: 0.5684080818193853d), radius: 0.8667811646373148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03958141250888314d, y: 0.5915855343710416d), radius: 0.5387417764221312d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 148,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16022614353873066d, y: 0.9905279975116741d), radius: 0.32032648864401747d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24563088495162122d, y: 0.6144045420392155d), radius: 0.9791769518457762d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5904194996105702d, y: 0.6154709653151631d), radius: 0.2769689091127806d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7457160859792412d, y: 0.4633902921091856d), radius: 0.5940986678762294d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 149,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.858274581511757d, y: 0.354055244816032d), radius: 0.21322087879738572d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10576950398543628d, y: 0.5212697374142632d), radius: 0.4118098850872214d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09311698335426555d, y: 0.19446720810705187d), radius: 0.010162750806290477d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7941101447637677d, y: 0.8034226200715185d), radius: 0.9935502911457944d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8634763617729599d, y: 0.5392492574753428d), radius: 0.16607074617492412d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.949801967773977d, y: 0.7542545100528761d), radius: 0.9398315096053894d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7652280704776935d, y: 0.42257428077190917d), radius: 0.6449773857248277d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9735543372235049d, y: 0.33662169335957537d), radius: 0.17643847591112338d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6222852761634736d, y: 0.6776672020007708d), radius: 0.666401064496729d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.962179663579735d, y: 0.7358442430044132d), radius: 0.22619421198909162d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleArray1M
{
    Id = 152,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.39233592347061363d, y: 0.39658798371635984d), radius: 0.9727665896206228d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5508032876875048d, y: 0.2178992828869749d), radius: 0.502318248182702d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8955599368729791d, y: 0.25101088692981344d), radius: 0.15526907146678515d),
},
    ModelInner = new NpgsqlCirclecircleArray1MI
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9329084958947743d, y: 0.640040860283268d), radius: 0.7122025179154979d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09855414757771652d, y: 0.2635095268600842d), radius: 0.0017452137502921294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9605662868197632d, y: 0.2818034937463487d), radius: 0.6601030556243024d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9012787742710616d, y: 0.5805719538613329d), radius: 0.16566868552598069d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4337734222934384d, y: 0.4601178468031105d), radius: 0.7223993531874953d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8991815681579343d, y: 0.6254964622778617d), radius: 0.5727099371256975d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9617331501139122d, y: 0.14986023856291653d), radius: 0.2918039358879728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9066078565334948d, y: 0.7101026639174272d), radius: 0.24915696834071455d),
},
},
            new NpgsqlCirclecircleArray1M
{
    Id = 160,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8463570991166663d, y: 0.01987524874689217d), radius: 0.02971318477345608d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6878840169482897d, y: 0.5594960610348924d), radius: 0.8721188185562904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5440085600493354d, y: 0.20009092183992627d), radius: 0.7945962302386326d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6117592026364024d, y: 0.08141878449025475d), radius: 0.2361810403389062d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36437173835970593d, y: 0.9113197564250096d), radius: 0.7657706792758069d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.903620581209096d, y: 0.32162097877307283d), radius: 0.09174907891238693d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7254806508698606d, y: 0.6608544654748094d), radius: 0.41179865388937353d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
INSERT INTO public.npgsqlcirclecirclearray1mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleArraycircleArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)), 
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
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleArraycircleArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleArraycircleArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.027767325951977617d, y: 0.4073645898559167d), radius: 0.4808173107239174d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15355609824488448d, y: 0.3336017652913382d), radius: 0.2753692789317904d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9838390117594475d, y: 0.23540916760184016d), radius: 0.743641972749213d),
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

                    nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5088743073692834d, y: 0.8516517333747574d), radius: 0.16511260653764426d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7346467929206965d, y: 0.36004678659052447d), radius: 0.5849461124489466d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9649588010069415d, y: 0.7337464046899748d), radius: 0.5317964208029278d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7424016218073335d, y: 0.8935587480173762d), radius: 0.6280995402081567d),
}));
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
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

                    nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.964704361340022d, y: 0.058190799017984185d), radius: 0.8068411651327598d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1617919300077041d, y: 0.28996262564705955d), radius: 0.915336957308126d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7148531689917992d, y: 0.745187423474294d), radius: 0.0685853785575612d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclearray1m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclearray1mi_id
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
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                methodParametrName: "npgsqlcirclecirclearray1mi_id", 
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
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.037303834369129985d, y: 0.6863053986498862d), radius: 0.8645405727209179d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9748351538287177d, y: 0.4057948194059615d), radius: 0.13630873782721642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13835500694830083d, y: 0.7667531097115041d), radius: 0.561622383281462d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.555910465132235d, y: 0.1959224215629779d), radius: 0.5707108060106784d),
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
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlCircleArraycircleArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlCircleArraycircleArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleArray1M> models = null;

                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleArraycircleArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleArraycircleArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr2.Value = 95;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 41;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
                parametr2.Value = 116;
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 112;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[34], false);
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
                parametr2.Value = 42;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 149;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 98;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M), typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 112, query1, 148, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[30],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var models2 = new List<FlatNpgsqlCirclecircleArray1M>();
                ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 59, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 43, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                await ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 145, query1, 148, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 142, query1, 52, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
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
FROM public.npgsqlcirclecirclearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleArray1M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleArray1M>();
                 ((INpgsqlCircleArraycircleArray)this).DbConnectionDynQuerySelectModelBatch(connection, 150, query1, 27, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleArray1M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclearray1m m
LEFT JOIN public.npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray)),
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
                var models = await((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatchAsync(connection, 16, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[2], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[3], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[4], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[5], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[6], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[7], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[8], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[9], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[10], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[11], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[23],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[24],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[25],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[26],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[27],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[28],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[29],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[30],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[31],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[34], false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleArraycircleArray)this).DbConnectionSTSelectModelBatch(connection, 145, 52))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlCirclecircleArray1M.AssertModel(models[22],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 92);
                var models = await ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(16));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[19], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[20], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[14],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[15],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleArraycircleArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleArraycircleArray)this).SetDbConnectionSelectModelParametrs(cmd, 98);
                var models =  ((INpgsqlCircleArraycircleArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(14));
NpgsqlCirclecircleArray1M.AssertModel(models[0],_testData[21], false);NpgsqlCirclecircleArray1M.AssertModel(models[1],_testData[22], false);NpgsqlCirclecircleArray1M.AssertModel(models[2],_testData[23], false);NpgsqlCirclecircleArray1M.AssertModel(models[3],_testData[24], false);NpgsqlCirclecircleArray1M.AssertModel(models[4],_testData[25], false);NpgsqlCirclecircleArray1M.AssertModel(models[5],_testData[26], false);NpgsqlCirclecircleArray1M.AssertModel(models[6],_testData[27], false);NpgsqlCirclecircleArray1M.AssertModel(models[7],_testData[28], false);NpgsqlCirclecircleArray1M.AssertModel(models[8],_testData[29], false);NpgsqlCirclecircleArray1M.AssertModel(models[9],_testData[30], false);NpgsqlCirclecircleArray1M.AssertModel(models[10],_testData[31], false);NpgsqlCirclecircleArray1M.AssertModel(models[11],_testData[32], false);NpgsqlCirclecircleArray1M.AssertModel(models[12],_testData[33], false);NpgsqlCirclecircleArray1M.AssertModel(models[13],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleArraycircleArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MI),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleArray1M),
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
FROM public.binary_npgsqlcirclecirclearray1m m
LEFT JOIN public.binary_npgsqlcirclecirclearray1mi mi ON mi.id = m.npgsqlcirclecirclearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleArraycircleArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleArraycircleArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleArraycircleArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleArraycircleArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1M)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlCircleArraycircleArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclearray1mi
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
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI), typeof(NpgsqlCirclecircleArray1MI)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                await ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MI>();
                var models2 = new List<NpgsqlCirclecircleArray1MI>();
                ((INpgsqlCircleArraycircleArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MI)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA), typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                await ((INpgsqlCircleArraycircleArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleArray1MIWA>();
                var models2 = new List<NpgsqlCirclecircleArray1MIWA>();
                ((INpgsqlCircleArraycircleArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleArray1MIWA)],
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
            asPartInterface: typeof(INpgsqlCircleArraycircleArray))]
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
                var models = await ((INpgsqlCircleArraycircleArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleArraycircleArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

