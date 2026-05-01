

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
    internal partial interface INpgsqlLineListlineArray
    {
    }
    
    internal partial class NpgsqlLineListlineArray : INpgsqlLineListlineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray2M[] _testData = new NpgsqlLinelineArray2M[]
        {
            new NpgsqlLinelineArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6078488257512867d, b: 0.9194064222946254d, c: 0.08230867520075258d),

new NpgsqlTypes.NpgsqlLine(a: 0.8304145604211792d, b: 0.33426219538428137d, c: 0.7449207226389996d),

new NpgsqlTypes.NpgsqlLine(a: 0.6003815387434632d, b: 0.24791988983490743d, c: 0.6206163645345191d),

new NpgsqlTypes.NpgsqlLine(a: 0.7115460017311946d, b: 0.17457781944786743d, c: 0.7807227146882129d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44757127132021446d, b: 0.9178156852270314d, c: 0.37667687582321663d),

new NpgsqlTypes.NpgsqlLine(a: 0.46537734527000174d, b: 0.6469853023525175d, c: 0.5222150075735674d),

new NpgsqlTypes.NpgsqlLine(a: 0.5114957375684154d, b: 0.8566683383983259d, c: 0.39202763258164963d),

new NpgsqlTypes.NpgsqlLine(a: 0.29401763571017137d, b: 0.3768384766474031d, c: 0.05237012666710894d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1924692545998402d, b: 0.07359622172146896d, c: 0.7660112879343391d),

new NpgsqlTypes.NpgsqlLine(a: 0.11461643333301219d, b: 0.8506842745443203d, c: 0.693031117479302d),

new NpgsqlTypes.NpgsqlLine(a: 0.012981527873071497d, b: 0.6168746439636199d, c: 0.7522308861026729d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17642666602855217d, b: 0.5538372600530228d, c: 0.21275003199507536d),

new NpgsqlTypes.NpgsqlLine(a: 0.3727210829416987d, b: 0.09474617005381558d, c: 0.1451093706366131d),

new NpgsqlTypes.NpgsqlLine(a: 0.2724954887868376d, b: 0.9110419333705853d, c: 0.21026181286925683d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5802788203956777d, b: 0.6281638760568531d, c: 0.12766456906024415d),

new NpgsqlTypes.NpgsqlLine(a: 0.7577480562712127d, b: 0.7636293584621996d, c: 0.04327764075894758d),

new NpgsqlTypes.NpgsqlLine(a: 0.22930279950042343d, b: 0.8870602619076872d, c: 0.05726546705936375d),

new NpgsqlTypes.NpgsqlLine(a: 0.16498686942749707d, b: 0.701733077703926d, c: 0.8814771914617844d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8235594132317772d, b: 0.6653537937156239d, c: 0.26597351989209217d),

new NpgsqlTypes.NpgsqlLine(a: 0.27836421446530646d, b: 0.9100978432876575d, c: 0.9668966592350123d),

new NpgsqlTypes.NpgsqlLine(a: 0.002102000081348976d, b: 0.3246829120809629d, c: 0.4875562682409307d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22567308924225138d, b: 0.6040623173349277d, c: 0.007511996753660322d),

new NpgsqlTypes.NpgsqlLine(a: 0.12032150917997264d, b: 0.8867821296167574d, c: 0.11576882284538481d),

new NpgsqlTypes.NpgsqlLine(a: 0.9896736734018928d, b: 0.7655215081089777d, c: 0.3936000312890299d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15828863943113625d, b: 0.02146009945707006d, c: 0.06776864123579684d),

new NpgsqlTypes.NpgsqlLine(a: 0.24739086580551872d, b: 0.5316292607897507d, c: 0.9326240408768929d),

new NpgsqlTypes.NpgsqlLine(a: 0.882603282915582d, b: 0.1803892645218853d, c: 0.19182348957214967d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.73811577173504d, b: 0.6822335419834786d, c: 0.24816567776339105d),

new NpgsqlTypes.NpgsqlLine(a: 0.30987655139578385d, b: 0.989736368389014d, c: 0.9501865353910129d),

new NpgsqlTypes.NpgsqlLine(a: 0.1299098785618671d, b: 0.4910399300072765d, c: 0.17231958006299408d),

new NpgsqlTypes.NpgsqlLine(a: 0.8405152575381418d, b: 0.36305910860625934d, c: 0.7858715064629308d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03316974910241999d, b: 0.499963723447962d, c: 0.8500311671749181d),

new NpgsqlTypes.NpgsqlLine(a: 0.5418166676313654d, b: 0.5170060149075655d, c: 0.8124074395539724d),

new NpgsqlTypes.NpgsqlLine(a: 0.5507466952766485d, b: 0.9340708394373233d, c: 0.732497535342919d),

new NpgsqlTypes.NpgsqlLine(a: 0.6940943081547364d, b: 0.006147767944571503d, c: 0.804625767042846d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6645982999199624d, b: 0.30200691587023465d, c: 0.475128432797303d),

new NpgsqlTypes.NpgsqlLine(a: 0.012571820957145596d, b: 0.6359524893714469d, c: 0.09843671560443734d),

new NpgsqlTypes.NpgsqlLine(a: 0.20628411913207656d, b: 0.19455039911295513d, c: 0.025845131154614176d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6843157223807274d, b: 0.9532442184378741d, c: 0.432533855193441d),

new NpgsqlTypes.NpgsqlLine(a: 0.5448697246721296d, b: 0.4463298867056199d, c: 0.6546117136642712d),

new NpgsqlTypes.NpgsqlLine(a: 0.34145180627945737d, b: 0.9521791741682339d, c: 0.08622546147173482d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11576330003052315d, b: 0.6980283305751747d, c: 0.7321161548456002d),

new NpgsqlTypes.NpgsqlLine(a: 0.4717061075713721d, b: 0.1527302864114719d, c: 0.05511318161354062d),

new NpgsqlTypes.NpgsqlLine(a: 0.3999852093235323d, b: 0.7707336758127623d, c: 0.6049296356139192d),

new NpgsqlTypes.NpgsqlLine(a: 0.4929007904422268d, b: 0.15515594895767348d, c: 0.09926257534065475d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4560750500385723d, b: 0.43754074658176134d, c: 0.36050987465220197d),

new NpgsqlTypes.NpgsqlLine(a: 0.1594341803866851d, b: 0.053977118019453596d, c: 0.8925993328270633d),

new NpgsqlTypes.NpgsqlLine(a: 0.5120358002670724d, b: 0.4066363992269244d, c: 0.8070864780114748d),

new NpgsqlTypes.NpgsqlLine(a: 0.16224890769285905d, b: 0.4661148961436187d, c: 0.6763554800516138d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36855288684221155d, b: 0.020867116703116584d, c: 0.8401772553067024d),

new NpgsqlTypes.NpgsqlLine(a: 0.2778002740724794d, b: 0.2369666036665422d, c: 0.9801947948207167d),

new NpgsqlTypes.NpgsqlLine(a: 0.7471320611629997d, b: 0.8341168483869419d, c: 0.3252847626601283d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5057663537133876d, b: 0.3933268618873885d, c: 0.9402144806556753d),

new NpgsqlTypes.NpgsqlLine(a: 0.6251032411003539d, b: 0.5975567789532725d, c: 0.8420508162442137d),

new NpgsqlTypes.NpgsqlLine(a: 0.7441229088347856d, b: 0.3585576425098843d, c: 0.7099850104839366d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7715663949462378d, b: 0.019982952289634315d, c: 0.13717223540643753d),

new NpgsqlTypes.NpgsqlLine(a: 0.47875265025627844d, b: 0.18893071056106292d, c: 0.8924384666047285d),

new NpgsqlTypes.NpgsqlLine(a: 0.21665731783538955d, b: 0.6260516544278402d, c: 0.26908401173539676d),

new NpgsqlTypes.NpgsqlLine(a: 0.8271444654433698d, b: 0.38011230274839813d, c: 0.9012705718790672d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43338908821347255d, b: 0.5406537743349192d, c: 0.5091027714421708d),

new NpgsqlTypes.NpgsqlLine(a: 0.49973384981636193d, b: 0.4222172056297574d, c: 0.27672495530062935d),

new NpgsqlTypes.NpgsqlLine(a: 0.6924948721352945d, b: 0.9499754270616139d, c: 0.7758731936399396d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44282687833278334d, b: 0.8402321054393997d, c: 0.08881831142104901d),

new NpgsqlTypes.NpgsqlLine(a: 0.31329213165355385d, b: 0.8551013828886517d, c: 0.23552446479984301d),

new NpgsqlTypes.NpgsqlLine(a: 0.9137937061380365d, b: 0.35898823891956544d, c: 0.458643809764786d),

new NpgsqlTypes.NpgsqlLine(a: 0.09457967768857889d, b: 0.6515873792018448d, c: 0.8749187547291133d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7913426896287717d, b: 0.6839676562255285d, c: 0.11556359545429185d),

new NpgsqlTypes.NpgsqlLine(a: 0.6163793738517446d, b: 0.752799304504982d, c: 0.8402243859116024d),

new NpgsqlTypes.NpgsqlLine(a: 0.2553326466821546d, b: 0.7317508995165621d, c: 0.9362724281923549d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17328491046509642d, b: 0.6483679702041698d, c: 0.05406815123620956d),

new NpgsqlTypes.NpgsqlLine(a: 0.8859376177275811d, b: 0.49994589759071084d, c: 0.21492754270741765d),

new NpgsqlTypes.NpgsqlLine(a: 0.9676021269491613d, b: 0.40522063236755546d, c: 0.07337244281667898d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.668680193885672d, b: 0.09274060189294864d, c: 0.18147314551498206d),

new NpgsqlTypes.NpgsqlLine(a: 0.5169328920954006d, b: 0.3499333505312705d, c: 0.2165888324867059d),

new NpgsqlTypes.NpgsqlLine(a: 0.6780538212820018d, b: 0.6729233927191712d, c: 0.2019907798679904d),

new NpgsqlTypes.NpgsqlLine(a: 0.7292082675145595d, b: 0.4579586363342437d, c: 0.16030628215001963d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9036225040132785d, b: 0.8491245626035179d, c: 0.7090715766714025d),

new NpgsqlTypes.NpgsqlLine(a: 0.29635069285362436d, b: 0.5695468697994861d, c: 0.08144216469027032d),

new NpgsqlTypes.NpgsqlLine(a: 0.23701392368537855d, b: 0.17181924464689668d, c: 0.8556357637434199d),

new NpgsqlTypes.NpgsqlLine(a: 0.32373468301831d, b: 0.8638115840946937d, c: 0.5946377134214286d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7048514696587292d, b: 0.7800282560094602d, c: 0.25855543317042184d),

new NpgsqlTypes.NpgsqlLine(a: 0.9085739621815152d, b: 0.3116537391982752d, c: 0.21262820993037013d),

new NpgsqlTypes.NpgsqlLine(a: 0.17344216256949918d, b: 0.8737214386934912d, c: 0.1022008442085579d),

new NpgsqlTypes.NpgsqlLine(a: 0.6859578285648257d, b: 0.9732232466632564d, c: 0.8113322740577635d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11305313496087521d, b: 0.43516307505090046d, c: 0.4749188545288068d),

new NpgsqlTypes.NpgsqlLine(a: 0.6321480077658689d, b: 0.018307691617454158d, c: 0.8376014697530219d),

new NpgsqlTypes.NpgsqlLine(a: 0.3939258133818845d, b: 0.09625658151154981d, c: 0.5769179168694243d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7799017015645775d, b: 0.40730252746037154d, c: 0.8694624826384421d),

new NpgsqlTypes.NpgsqlLine(a: 0.7306957956230272d, b: 0.8284223792113763d, c: 0.5001821577750614d),

new NpgsqlTypes.NpgsqlLine(a: 0.09111504459229136d, b: 0.8926148718742909d, c: 0.39872445235784437d),

new NpgsqlTypes.NpgsqlLine(a: 0.00463884106393786d, b: 0.3784739065790875d, c: 0.2674122781658913d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6910017100217923d, b: 0.1730136809667473d, c: 0.20674900619890946d),

new NpgsqlTypes.NpgsqlLine(a: 0.8981205262959819d, b: 0.45640811717919816d, c: 0.6736365371882453d),

new NpgsqlTypes.NpgsqlLine(a: 0.34844624667817203d, b: 0.08544615218438278d, c: 0.847772079527148d),

new NpgsqlTypes.NpgsqlLine(a: 0.6266602524586501d, b: 0.891546387947554d, c: 0.34192626044051055d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5544817358075852d, b: 0.7537246127647687d, c: 0.10077105381693374d),

new NpgsqlTypes.NpgsqlLine(a: 0.0794833261696617d, b: 0.0965486988215436d, c: 0.5853876682750677d),

new NpgsqlTypes.NpgsqlLine(a: 0.15348913067108982d, b: 0.10024056560268102d, c: 0.9446162077099254d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31540146366992106d, b: 0.7262946650994386d, c: 0.2681954592745144d),

new NpgsqlTypes.NpgsqlLine(a: 0.3580651276856428d, b: 0.8115875822789312d, c: 0.8302109338240379d),

new NpgsqlTypes.NpgsqlLine(a: 0.6315306891861728d, b: 0.32996743581950905d, c: 0.5635472947350532d),

new NpgsqlTypes.NpgsqlLine(a: 0.34168346680878847d, b: 0.5026893177688528d, c: 0.3940579890223407d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.0958789417532091d, b: 0.2318117669769182d, c: 0.36203135980400825d),

new NpgsqlTypes.NpgsqlLine(a: 0.9126832143980467d, b: 0.5894068795423071d, c: 0.8169589863314574d),

new NpgsqlTypes.NpgsqlLine(a: 0.08499196903483641d, b: 0.2890301155833974d, c: 0.48034753048271384d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9362189370045111d, b: 0.07057325477031162d, c: 0.9520193608552956d),

new NpgsqlTypes.NpgsqlLine(a: 0.4365662246430476d, b: 0.5387876290988678d, c: 0.6693621865996078d),

new NpgsqlTypes.NpgsqlLine(a: 0.9812575009887409d, b: 0.5472814281998417d, c: 0.7813495195895551d),

new NpgsqlTypes.NpgsqlLine(a: 0.15982235324792937d, b: 0.7896283563850093d, c: 0.39856883997715664d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.983630298727541d, b: 0.1268179471600005d, c: 0.1691467861782714d),

new NpgsqlTypes.NpgsqlLine(a: 0.7356539617003348d, b: 0.8374237562698339d, c: 0.016816751565722377d),

new NpgsqlTypes.NpgsqlLine(a: 0.6056046380093412d, b: 0.3538934622395581d, c: 0.18347410128192743d),

new NpgsqlTypes.NpgsqlLine(a: 0.9458682953033485d, b: 0.9899372958302238d, c: 0.5064484689308136d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7797391440564517d, b: 0.23455981704211448d, c: 0.07814116612950206d),

new NpgsqlTypes.NpgsqlLine(a: 0.2151088552289805d, b: 0.03216766563780826d, c: 0.6333753058843062d),

new NpgsqlTypes.NpgsqlLine(a: 0.7289157545058366d, b: 0.017885314165779653d, c: 0.47861475309639556d),

new NpgsqlTypes.NpgsqlLine(a: 0.023873967868423773d, b: 0.09068083902352464d, c: 0.25653038678775d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5034252790568791d, b: 0.47198783294514235d, c: 0.06995097426484409d),

new NpgsqlTypes.NpgsqlLine(a: 0.07367274985108851d, b: 0.411302320919148d, c: 0.8981414834266359d),

new NpgsqlTypes.NpgsqlLine(a: 0.02371733352183547d, b: 0.2854416471820379d, c: 0.30659774299222764d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9936082356290268d, b: 0.8503376665705628d, c: 0.40533929812326785d),

new NpgsqlTypes.NpgsqlLine(a: 0.5748782479621497d, b: 0.3027230482126886d, c: 0.5795999450744699d),

new NpgsqlTypes.NpgsqlLine(a: 0.43699536598022926d, b: 0.9579161368726945d, c: 0.5944767199995992d),

new NpgsqlTypes.NpgsqlLine(a: 0.4657442614867663d, b: 0.31362236316503656d, c: 0.16726443688280868d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8589882286968307d, b: 0.05319243386758199d, c: 0.5337189797697321d),

new NpgsqlTypes.NpgsqlLine(a: 0.3737644705463218d, b: 0.5217764056032699d, c: 0.41638288384247235d),

new NpgsqlTypes.NpgsqlLine(a: 0.4192878571721651d, b: 0.9264428521238706d, c: 0.6155546462323855d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07037444324054187d, b: 0.019222469181440327d, c: 0.7116646439750647d),

new NpgsqlTypes.NpgsqlLine(a: 0.5778889354560037d, b: 0.8134549254895213d, c: 0.044331100171245086d),

new NpgsqlTypes.NpgsqlLine(a: 0.13659892750160751d, b: 0.5425357698137502d, c: 0.9883421608945879d),

new NpgsqlTypes.NpgsqlLine(a: 0.8636353828881667d, b: 0.4679780089710258d, c: 0.14126320984255536d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49394175534711116d, b: 0.6093757714967187d, c: 0.4871640908430571d),

new NpgsqlTypes.NpgsqlLine(a: 0.2941464550929228d, b: 0.09891487015910172d, c: 0.29669594898385654d),

new NpgsqlTypes.NpgsqlLine(a: 0.7745566996280022d, b: 0.3095554571265319d, c: 0.2249029574618805d),

new NpgsqlTypes.NpgsqlLine(a: 0.430402264148272d, b: 0.7373143221499733d, c: 0.0011789127050418902d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 61,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6383736097648437d, b: 0.7148345824765255d, c: 0.602410189598949d),

new NpgsqlTypes.NpgsqlLine(a: 0.5707015794658602d, b: 0.7041908853399943d, c: 0.0036654540830219906d),

new NpgsqlTypes.NpgsqlLine(a: 0.4582235433857247d, b: 0.3089791779030149d, c: 0.8706300957933215d),

new NpgsqlTypes.NpgsqlLine(a: 0.7871677828391455d, b: 0.6127641125834201d, c: 0.38259824654763597d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4572073860507955d, b: 0.6884576701456355d, c: 0.6432302932718231d),

new NpgsqlTypes.NpgsqlLine(a: 0.9806297278885678d, b: 0.6751746487924937d, c: 0.5439133623374025d),

new NpgsqlTypes.NpgsqlLine(a: 0.6668508980538606d, b: 0.3633665806816452d, c: 0.17405918788686436d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6424763367911736d, b: 0.430383467008038d, c: 0.740364963902945d),

new NpgsqlTypes.NpgsqlLine(a: 0.8905586055408208d, b: 0.8276690060662663d, c: 0.57724747409311d),

new NpgsqlTypes.NpgsqlLine(a: 0.3852425968940023d, b: 0.40186466722613723d, c: 0.76270678714994d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46578340831364595d, b: 0.004038773479487334d, c: 0.6546723466120099d),

new NpgsqlTypes.NpgsqlLine(a: 0.4099526121139553d, b: 0.595268851198236d, c: 0.9105463991800081d),

new NpgsqlTypes.NpgsqlLine(a: 0.05614141025550623d, b: 0.7764920189667085d, c: 0.9999651715388687d),

new NpgsqlTypes.NpgsqlLine(a: 0.24553499662842426d, b: 0.05324374191344561d, c: 0.651374907390405d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6487356695164535d, b: 0.7862175453805534d, c: 0.4507964944495222d),

new NpgsqlTypes.NpgsqlLine(a: 0.24316182680901188d, b: 0.17159297666007622d, c: 0.7702040668350429d),

new NpgsqlTypes.NpgsqlLine(a: 0.5985687246098953d, b: 0.2830645446362121d, c: 0.2598945794807781d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4164190229297581d, b: 0.48925549030299775d, c: 0.1270709942299183d),

new NpgsqlTypes.NpgsqlLine(a: 0.7154912579162966d, b: 0.7980916028296835d, c: 0.3978615914406881d),

new NpgsqlTypes.NpgsqlLine(a: 0.9580043513130274d, b: 0.6021775852101323d, c: 0.1421391195048206d),

new NpgsqlTypes.NpgsqlLine(a: 0.11638301332988055d, b: 0.8872638705959712d, c: 0.2885818521305764d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8323008742334121d, b: 0.7013382233174793d, c: 0.2867579090858906d),

new NpgsqlTypes.NpgsqlLine(a: 0.5047130868916453d, b: 0.054639665891535794d, c: 0.8408131120749213d),

new NpgsqlTypes.NpgsqlLine(a: 0.4084411724434307d, b: 0.22840106497317658d, c: 0.6788262144955111d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.15734372939024355d, b: 0.7737692552604806d, c: 0.44620181943824966d),

new NpgsqlTypes.NpgsqlLine(a: 0.37385234671865974d, b: 0.10898267565181996d, c: 0.27786256997775693d),

new NpgsqlTypes.NpgsqlLine(a: 0.14238569371220522d, b: 0.3110837435846987d, c: 0.2545415894299605d),

new NpgsqlTypes.NpgsqlLine(a: 0.14727372759686352d, b: 0.08431593287323458d, c: 0.5989660661892792d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02022326560870169d, b: 0.5356114611688446d, c: 0.29619774526916454d),

new NpgsqlTypes.NpgsqlLine(a: 0.29542757432491984d, b: 0.597707441035406d, c: 0.5701988216685715d),

new NpgsqlTypes.NpgsqlLine(a: 0.5216707821624095d, b: 0.5969110969757297d, c: 0.8029783107271777d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6849272902364121d, b: 0.8417879119431263d, c: 0.5200959905617243d),

new NpgsqlTypes.NpgsqlLine(a: 0.3159682598394521d, b: 0.33391561320018714d, c: 0.2656891657586573d),

new NpgsqlTypes.NpgsqlLine(a: 0.338068433110711d, b: 0.4803308348168577d, c: 0.8189535407744879d),

new NpgsqlTypes.NpgsqlLine(a: 0.7105862657785619d, b: 0.062430012062158036d, c: 0.058927965816164884d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7717384804954434d, b: 0.07771171283633094d, c: 0.3709986566603164d),

new NpgsqlTypes.NpgsqlLine(a: 0.3941974204649724d, b: 0.1524343157612471d, c: 0.7628474295005712d),

new NpgsqlTypes.NpgsqlLine(a: 0.30460335247514114d, b: 0.10603270394341058d, c: 0.05989937484307195d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04818356992621109d, b: 0.4246326798592408d, c: 0.5338519051260103d),

new NpgsqlTypes.NpgsqlLine(a: 0.1867705036919859d, b: 0.07929963628993619d, c: 0.9711970192398691d),

new NpgsqlTypes.NpgsqlLine(a: 0.0032675611885598643d, b: 0.3690292084880502d, c: 0.7849336288856555d),

new NpgsqlTypes.NpgsqlLine(a: 0.9414756270407191d, b: 0.5098891222205582d, c: 0.45116434262554717d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8772140114951854d, b: 0.5705916005453149d, c: 0.49891585714342634d),

new NpgsqlTypes.NpgsqlLine(a: 0.6513855429046017d, b: 0.23022007970045333d, c: 0.5955071163017859d),

new NpgsqlTypes.NpgsqlLine(a: 0.636560530174123d, b: 0.4198825653431052d, c: 0.2975920706149666d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7650373440407596d, b: 0.5586181622896168d, c: 0.1414826524933831d),

new NpgsqlTypes.NpgsqlLine(a: 0.919552872385798d, b: 0.2620388446595926d, c: 0.7704624818580023d),

new NpgsqlTypes.NpgsqlLine(a: 0.3960942658377056d, b: 0.30644519341241816d, c: 0.06320297975582845d),

new NpgsqlTypes.NpgsqlLine(a: 0.09293797103045942d, b: 0.46368196079327195d, c: 0.7015743725893756d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6430932768119835d, b: 0.48427914752442724d, c: 0.7490034534990856d),

new NpgsqlTypes.NpgsqlLine(a: 0.032393577505553606d, b: 0.685654775020173d, c: 0.22736669713234192d),

new NpgsqlTypes.NpgsqlLine(a: 0.4373607545411764d, b: 0.03726097789296745d, c: 0.6859065070004873d),

new NpgsqlTypes.NpgsqlLine(a: 0.7078591643708801d, b: 0.9530250127884222d, c: 0.03914173526369624d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25233985174354023d, b: 0.0998336165773086d, c: 0.7942543597594611d),

new NpgsqlTypes.NpgsqlLine(a: 0.02739246772915893d, b: 0.3844409857143718d, c: 0.08678451557161937d),

new NpgsqlTypes.NpgsqlLine(a: 0.10645333434306137d, b: 0.2716509343832736d, c: 0.7158181568143832d),

new NpgsqlTypes.NpgsqlLine(a: 0.325371317488122d, b: 0.47884745128104145d, c: 0.3160237834006324d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7910027266793139d, b: 0.4109227535182437d, c: 0.37871407105049804d),

new NpgsqlTypes.NpgsqlLine(a: 0.44710964468588976d, b: 0.617538225626701d, c: 0.7652622110900152d),

new NpgsqlTypes.NpgsqlLine(a: 0.5929039307778351d, b: 0.6105010444334417d, c: 0.5371649491740926d),

new NpgsqlTypes.NpgsqlLine(a: 0.16689880967585424d, b: 0.2662756883257674d, c: 0.7973163298666817d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8710718141385847d, b: 0.17410582241342354d, c: 0.4206933508302124d),

new NpgsqlTypes.NpgsqlLine(a: 0.7470524511462535d, b: 0.40411194676008233d, c: 0.8727969289600414d),

new NpgsqlTypes.NpgsqlLine(a: 0.6953955366978279d, b: 0.778058166423309d, c: 0.8627841411309723d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7246770000918862d, b: 0.9508003512275336d, c: 0.5823086225229358d),

new NpgsqlTypes.NpgsqlLine(a: 0.1344265169384532d, b: 0.7795550012219961d, c: 0.898160374243264d),

new NpgsqlTypes.NpgsqlLine(a: 0.7722632459470744d, b: 0.6717721715248908d, c: 0.3677504210212974d),

new NpgsqlTypes.NpgsqlLine(a: 0.21177307142183455d, b: 0.4920956278446238d, c: 0.09914824340790207d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22872259185027455d, b: 0.42680743172143276d, c: 0.5275012603496035d),

new NpgsqlTypes.NpgsqlLine(a: 0.5536867874836073d, b: 0.09288212124398243d, c: 0.1753088733078727d),

new NpgsqlTypes.NpgsqlLine(a: 0.7850429094163769d, b: 0.3878170334203248d, c: 0.8697102072790319d),

new NpgsqlTypes.NpgsqlLine(a: 0.3234003452422002d, b: 0.020439206294731838d, c: 0.07408078895002257d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32195344567654416d, b: 0.8129603981830174d, c: 0.2995426885503486d),

new NpgsqlTypes.NpgsqlLine(a: 0.08714302337957858d, b: 0.05911016728102747d, c: 0.7482109375684324d),

new NpgsqlTypes.NpgsqlLine(a: 0.13628232176099786d, b: 0.10997953443674324d, c: 0.7426503222789091d),

new NpgsqlTypes.NpgsqlLine(a: 0.5101500584805987d, b: 0.27484606244686793d, c: 0.7876105822419213d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3283884617183155d, b: 0.8129657026225328d, c: 0.6441167623326551d),

new NpgsqlTypes.NpgsqlLine(a: 0.5201781971832891d, b: 0.2261078334262906d, c: 0.036861872106960014d),

new NpgsqlTypes.NpgsqlLine(a: 0.00014747077086862959d, b: 0.7552595560550032d, c: 0.6149557769740852d),

new NpgsqlTypes.NpgsqlLine(a: 0.11604244376096862d, b: 0.8081584130887423d, c: 0.47379648092003823d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2500676039017974d, b: 0.8130671094412127d, c: 0.6675845813613132d),

new NpgsqlTypes.NpgsqlLine(a: 0.4387768865226629d, b: 0.5252174706761948d, c: 0.11165501272142597d),

new NpgsqlTypes.NpgsqlLine(a: 0.9554721599122131d, b: 0.6092708887156814d, c: 0.017369213685235918d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32231406649188754d, b: 0.2898736644768187d, c: 0.33094339532378336d),

new NpgsqlTypes.NpgsqlLine(a: 0.9818333434563098d, b: 0.8783814920579814d, c: 0.023167128486737854d),

new NpgsqlTypes.NpgsqlLine(a: 0.5097724372038032d, b: 0.2186847911557256d, c: 0.29664773115532905d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8060171641150686d, b: 0.6706783436272157d, c: 0.6837717217578632d),

new NpgsqlTypes.NpgsqlLine(a: 0.4407916189120398d, b: 0.9395789294313367d, c: 0.09529983854056434d),

new NpgsqlTypes.NpgsqlLine(a: 0.5456478569417176d, b: 0.3609369982386066d, c: 0.8941631854663356d),

new NpgsqlTypes.NpgsqlLine(a: 0.6016876777056068d, b: 0.8220275292912723d, c: 0.6047963193699101d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28036361486442896d, b: 0.9843392613839699d, c: 0.5478148682158056d),

new NpgsqlTypes.NpgsqlLine(a: 0.48611363196570034d, b: 0.254899785788812d, c: 0.5710195549296329d),

new NpgsqlTypes.NpgsqlLine(a: 0.4747707379976812d, b: 0.5563930023930033d, c: 0.7624258438043344d),

new NpgsqlTypes.NpgsqlLine(a: 0.8081351496127198d, b: 0.7281312894382825d, c: 0.8905988836996918d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9522330534876156d, b: 0.7042119716678272d, c: 0.6347022745104984d),

new NpgsqlTypes.NpgsqlLine(a: 0.879896789002168d, b: 0.1633731610082243d, c: 0.04593497770073929d),

new NpgsqlTypes.NpgsqlLine(a: 0.8031144146995004d, b: 0.13536383138166763d, c: 0.45861672449603585d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30129723001557773d, b: 0.673591821794256d, c: 0.08288678132129557d),

new NpgsqlTypes.NpgsqlLine(a: 0.9040918451192616d, b: 0.8425384510701724d, c: 0.7597148974723857d),

new NpgsqlTypes.NpgsqlLine(a: 0.8246686340367713d, b: 0.677405643944376d, c: 0.7403915941414553d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18102839944788574d, b: 0.1076194627150856d, c: 0.09706709403726965d),

new NpgsqlTypes.NpgsqlLine(a: 0.4731841308865542d, b: 0.27313898706398665d, c: 0.0599093255306552d),

new NpgsqlTypes.NpgsqlLine(a: 0.6400783217342325d, b: 0.06851216929934323d, c: 0.44103848332715057d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2893454574428017d, b: 0.9921709537096981d, c: 0.14482415408984572d),

new NpgsqlTypes.NpgsqlLine(a: 0.7609824343640296d, b: 0.8739610803240878d, c: 0.2467171442254319d),

new NpgsqlTypes.NpgsqlLine(a: 0.35324935391066326d, b: 0.6917425326977207d, c: 0.8218714883921421d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21840543197078344d, b: 0.05992493064857607d, c: 0.0781395554172537d),

new NpgsqlTypes.NpgsqlLine(a: 0.5877151370344348d, b: 0.7101904472264218d, c: 0.7370104412566494d),

new NpgsqlTypes.NpgsqlLine(a: 0.3980455966728109d, b: 0.5580867471215398d, c: 0.8627029804663942d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31455267668488407d, b: 0.12563353712103342d, c: 0.9039609518974475d),

new NpgsqlTypes.NpgsqlLine(a: 0.10759352188443794d, b: 0.23764386039933094d, c: 0.4024236884718977d),

new NpgsqlTypes.NpgsqlLine(a: 0.07937869716462764d, b: 0.8692232538363616d, c: 0.4551798247964276d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7349129436567794d, b: 0.5253489208905506d, c: 0.7634943392276828d),

new NpgsqlTypes.NpgsqlLine(a: 0.571380237666147d, b: 0.486119019869956d, c: 0.7712763270884256d),

new NpgsqlTypes.NpgsqlLine(a: 0.4146535379338915d, b: 0.43902570391794504d, c: 0.49139667283054933d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9177230530902036d, b: 0.20620282010321644d, c: 0.9414021312590259d),

new NpgsqlTypes.NpgsqlLine(a: 0.6607630445886705d, b: 0.6112059323754006d, c: 0.23227420619077133d),

new NpgsqlTypes.NpgsqlLine(a: 0.45119476745267495d, b: 0.6574766766874771d, c: 0.5759011595169912d),

new NpgsqlTypes.NpgsqlLine(a: 0.14185416859374778d, b: 0.8244158441910711d, c: 0.16641522762785965d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8962480726077745d, b: 0.021661332594746563d, c: 0.8216708282473227d),

new NpgsqlTypes.NpgsqlLine(a: 0.10824594753413297d, b: 0.43109031351189087d, c: 0.3845693650278582d),

new NpgsqlTypes.NpgsqlLine(a: 0.514389062318803d, b: 0.7273298670745935d, c: 0.6098048490048398d),

new NpgsqlTypes.NpgsqlLine(a: 0.6590786396305708d, b: 0.46260089092106915d, c: 0.4118394076572768d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.691961609584124d, b: 0.25668579952483694d, c: 0.27319694792706206d),

new NpgsqlTypes.NpgsqlLine(a: 0.504148581669394d, b: 0.24268292263839475d, c: 0.4524639355216251d),

new NpgsqlTypes.NpgsqlLine(a: 0.7246170373368317d, b: 0.33997285482028117d, c: 0.29089490120080075d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3320288634854942d, b: 0.3002767362298293d, c: 0.7315908283247851d),

new NpgsqlTypes.NpgsqlLine(a: 0.8276566153606371d, b: 0.5414808582301897d, c: 0.03177864707666844d),

new NpgsqlTypes.NpgsqlLine(a: 0.8199222166973924d, b: 0.968685145261943d, c: 0.3567172140275653d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4184623173787383d, b: 0.13325050969588248d, c: 0.15318456624551458d),

new NpgsqlTypes.NpgsqlLine(a: 0.7609729505486279d, b: 0.5012824446527919d, c: 0.9278946107685728d),

new NpgsqlTypes.NpgsqlLine(a: 0.15606063801729553d, b: 0.4923757070404817d, c: 0.43476373019165315d),

new NpgsqlTypes.NpgsqlLine(a: 0.8335442106082771d, b: 0.39053891638960714d, c: 0.566189785333268d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.603372001790412d, b: 0.05198217261773275d, c: 0.41709700336667177d),

new NpgsqlTypes.NpgsqlLine(a: 0.5239265547273607d, b: 0.591232518369979d, c: 0.8909003289005809d),

new NpgsqlTypes.NpgsqlLine(a: 0.09224319452633456d, b: 0.3256767859106514d, c: 0.3191942292520543d),

new NpgsqlTypes.NpgsqlLine(a: 0.11980048041659486d, b: 0.3612281160523718d, c: 0.48101415985710794d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.030055236409034847d, b: 0.6098353575973484d, c: 0.16300503815247158d),

new NpgsqlTypes.NpgsqlLine(a: 0.2134220204392756d, b: 0.02611392363962417d, c: 0.886179926808157d),

new NpgsqlTypes.NpgsqlLine(a: 0.6184292104637807d, b: 0.48523510784853907d, c: 0.12670368074965588d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21520684374121046d, b: 0.3266933130522376d, c: 0.8668334854110679d),

new NpgsqlTypes.NpgsqlLine(a: 0.6107213579670568d, b: 0.48032847488840946d, c: 0.3264772296096937d),

new NpgsqlTypes.NpgsqlLine(a: 0.973621487948828d, b: 0.463741863200666d, c: 0.5322316661220844d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49187900989919753d, b: 0.11313503052644647d, c: 0.8264589166053488d),

new NpgsqlTypes.NpgsqlLine(a: 0.7876206220461224d, b: 0.8818922808902195d, c: 0.5386235494250043d),

new NpgsqlTypes.NpgsqlLine(a: 0.9912553334795603d, b: 0.05979328143376006d, c: 0.2935515344002657d),

new NpgsqlTypes.NpgsqlLine(a: 0.6465932206133982d, b: 0.34183847057377315d, c: 0.03393216204414129d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8012296547711226d, b: 0.32079115168194516d, c: 0.5674274623290195d),

new NpgsqlTypes.NpgsqlLine(a: 0.9478950116579504d, b: 0.3253619440449377d, c: 0.6714617236451325d),

new NpgsqlTypes.NpgsqlLine(a: 0.22731684278383368d, b: 0.9322819028477813d, c: 0.761798772869794d),

new NpgsqlTypes.NpgsqlLine(a: 0.4752055865355811d, b: 0.8003524832180982d, c: 0.23010455097521465d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.044643033677881805d, b: 0.5552321616767625d, c: 0.11683859551324882d),

new NpgsqlTypes.NpgsqlLine(a: 0.8112347902932681d, b: 0.2577273304408131d, c: 0.5761468845424479d),

new NpgsqlTypes.NpgsqlLine(a: 0.2775507604463603d, b: 0.2867626386379266d, c: 0.4979515144635268d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
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

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray2mi_id
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
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray2mi_id", 
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
                List<NpgsqlLinelineArray2M> models = null;

                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray2M> models = null;

                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 22;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 42;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 8;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 44;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 82;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 104;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
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
                parametr1.Value = 100;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[34], false);
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
                parametr1.Value = 93;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M), typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                await((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 61, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 61, query1, 100, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 22, query1, 42, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 51, query1, 120, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 79, query1, 113, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 23, query1, 42, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 22, query1, 8, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqllinelinearray2m m
LEFT JOIN public.npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 104, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlLineListlineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 22, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 8);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(34));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 39);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(25));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
FROM public.binary_npgsqllinelinearray2m m
LEFT JOIN public.binary_npgsqllinelinearray2mi mi ON mi.id = m.npgsqllinelinearray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

