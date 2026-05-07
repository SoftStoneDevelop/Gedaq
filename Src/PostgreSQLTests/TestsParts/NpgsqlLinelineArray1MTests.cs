

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
    internal partial interface INpgsqlLineArraylineArray
    {
    }
    
    internal partial class NpgsqlLineArraylineArray : INpgsqlLineArraylineArray
    {


#region TestData

        private readonly NpgsqlLinelineArray1M[] _testData = new NpgsqlLinelineArray1M[]
        {
            new NpgsqlLinelineArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.46214649123908647d, b: 0.7400868941474288d, c: 0.6159624843369d),
new NpgsqlTypes.NpgsqlLine(a: 0.6705488663117012d, b: 0.2994313155276045d, c: 0.1305607963559433d),
new NpgsqlTypes.NpgsqlLine(a: 0.877746123918187d, b: 0.7325403713087335d, c: 0.4599059120683481d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10848731221539576d, b: 0.261249875063134d, c: 0.5719106176423802d),
new NpgsqlTypes.NpgsqlLine(a: 0.5902568019819479d, b: 0.6629477695399414d, c: 0.9564091043265662d),
new NpgsqlTypes.NpgsqlLine(a: 0.5749478303923793d, b: 0.4672413562956538d, c: 0.7176786052772992d),
new NpgsqlTypes.NpgsqlLine(a: 0.2598598399691596d, b: 0.8289136411956278d, c: 0.29147981800481926d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7920351554150964d, b: 0.03535445086799882d, c: 0.5675584327171004d),
new NpgsqlTypes.NpgsqlLine(a: 0.17289286218235267d, b: 0.38920252076209727d, c: 0.9424839044812413d),
new NpgsqlTypes.NpgsqlLine(a: 0.36462005934702846d, b: 0.6416120265894313d, c: 0.8793670314203647d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9718785382045255d, b: 0.8672899480248641d, c: 0.14840016545385315d),
new NpgsqlTypes.NpgsqlLine(a: 0.2774991384357105d, b: 0.7517532895679462d, c: 0.4250553530717929d),
new NpgsqlTypes.NpgsqlLine(a: 0.7640894615109567d, b: 0.2924680944226341d, c: 0.7910931555789678d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4869181686252372d, b: 0.9558672815832431d, c: 0.7817661986268587d),
new NpgsqlTypes.NpgsqlLine(a: 0.596848306059718d, b: 0.003977109664172529d, c: 0.9399476025624435d),
new NpgsqlTypes.NpgsqlLine(a: 0.5281556630311597d, b: 0.14917236728800531d, c: 0.8160462639154401d),
new NpgsqlTypes.NpgsqlLine(a: 0.21526835145618284d, b: 0.0653634657298241d, c: 0.34997728371326653d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.45177830153232634d, b: 0.19212812497728504d, c: 0.718682463164115d),
new NpgsqlTypes.NpgsqlLine(a: 0.9107808607500925d, b: 0.009415164985574043d, c: 0.9702204779873234d),
new NpgsqlTypes.NpgsqlLine(a: 0.8855015533478423d, b: 0.25375562242595784d, c: 0.742185608883577d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17925474829296628d, b: 0.19591557182760944d, c: 0.4854487600642562d),
new NpgsqlTypes.NpgsqlLine(a: 0.3772159200716034d, b: 0.23032115858458546d, c: 0.32370922657652657d),
new NpgsqlTypes.NpgsqlLine(a: 0.7450461104028719d, b: 0.5853481742542233d, c: 0.2875947778510237d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6964778407781042d, b: 0.5121970926316218d, c: 0.11294247246066913d),
new NpgsqlTypes.NpgsqlLine(a: 0.028615651149813903d, b: 0.9645371885181973d, c: 0.251231777175571d),
new NpgsqlTypes.NpgsqlLine(a: 0.8302669552120849d, b: 0.25260709856557695d, c: 0.8072487071624246d),
new NpgsqlTypes.NpgsqlLine(a: 0.5127286935665929d, b: 0.48658766556744537d, c: 0.11177387181912002d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.05352104692794457d, b: 0.7670567119971072d, c: 0.902361121551004d),
new NpgsqlTypes.NpgsqlLine(a: 0.018587349203726955d, b: 0.8133836265011316d, c: 0.8020433812703678d),
new NpgsqlTypes.NpgsqlLine(a: 0.6881910174975816d, b: 0.1532303071938742d, c: 0.6271368458906212d),
new NpgsqlTypes.NpgsqlLine(a: 0.4262402439646086d, b: 0.6193765460690731d, c: 0.11203038424651213d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.15254740827583446d, b: 0.4956326406643793d, c: 0.46566548790763373d),
new NpgsqlTypes.NpgsqlLine(a: 0.7463915187424833d, b: 0.2297833229077647d, c: 0.7203669390385381d),
new NpgsqlTypes.NpgsqlLine(a: 0.5095195243268179d, b: 0.8375177781750495d, c: 0.8830856975253354d),
new NpgsqlTypes.NpgsqlLine(a: 0.05777293312704079d, b: 0.5560624160501902d, c: 0.46152509123255503d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.09024150670638065d, b: 0.45293346170053383d, c: 0.8340970004419599d),
new NpgsqlTypes.NpgsqlLine(a: 0.2597159803827058d, b: 0.6430512671316237d, c: 0.75776874217159d),
new NpgsqlTypes.NpgsqlLine(a: 0.40811234496238913d, b: 0.1235138343916985d, c: 0.9078729685035143d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 33,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4104925220290181d, b: 0.8839804522328351d, c: 0.6348568126466795d),
new NpgsqlTypes.NpgsqlLine(a: 0.8831322629426994d, b: 0.30178389640591097d, c: 0.6038567354471279d),
new NpgsqlTypes.NpgsqlLine(a: 0.701099464091543d, b: 0.09587757819276688d, c: 0.09108950333475807d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.51123759393403d, b: 0.4506964525892827d, c: 0.5756386800998669d),
new NpgsqlTypes.NpgsqlLine(a: 0.5920633527083377d, b: 0.09029091989917781d, c: 0.6242930672506148d),
new NpgsqlTypes.NpgsqlLine(a: 0.46571661423015576d, b: 0.007929272102531137d, c: 0.1898172292879694d),
new NpgsqlTypes.NpgsqlLine(a: 0.07349997078773896d, b: 0.11536230690197258d, c: 0.04882248666565747d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 5,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8937129221258988d, b: 0.449362895799126d, c: 0.6021444850209836d),
new NpgsqlTypes.NpgsqlLine(a: 0.9790540029204419d, b: 0.9241260073436801d, c: 0.9212978058542346d),
new NpgsqlTypes.NpgsqlLine(a: 0.09622538504576184d, b: 0.04836521517592052d, c: 0.21682213148855434d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5185972587720263d, b: 0.52149024802383d, c: 0.24616124102108883d),
new NpgsqlTypes.NpgsqlLine(a: 0.2000184511472317d, b: 0.7557322792883703d, c: 0.8749499405595119d),
new NpgsqlTypes.NpgsqlLine(a: 0.4107537956293634d, b: 0.14495408128335985d, c: 0.0505950004193394d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06449013354774913d, b: 0.9619786643826904d, c: 0.06858620788873304d),
new NpgsqlTypes.NpgsqlLine(a: 0.8625999884677916d, b: 0.2548768060905451d, c: 0.4271431525814403d),
new NpgsqlTypes.NpgsqlLine(a: 0.9252232013684087d, b: 0.971330077551422d, c: 0.7702171674286922d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5464528755295855d, b: 0.8581878724248415d, c: 0.5319540884354318d),
new NpgsqlTypes.NpgsqlLine(a: 0.32555895607391216d, b: 0.5150969212121329d, c: 0.31610194057273566d),
new NpgsqlTypes.NpgsqlLine(a: 0.2471859436558167d, b: 0.666814083709053d, c: 0.4202061218016496d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7493156547742668d, b: 0.6116010453395637d, c: 0.7759118098473913d),
new NpgsqlTypes.NpgsqlLine(a: 0.3469283856566817d, b: 0.32831607244049366d, c: 0.9194511922490055d),
new NpgsqlTypes.NpgsqlLine(a: 0.9424202401124292d, b: 0.1875460418094297d, c: 0.9164918435976205d),
new NpgsqlTypes.NpgsqlLine(a: 0.6834049475348756d, b: 0.09363768779311421d, c: 0.3188472331379806d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2779833870668067d, b: 0.3296419329402598d, c: 0.5728338258035535d),
new NpgsqlTypes.NpgsqlLine(a: 0.12108009304609502d, b: 0.5462510054673678d, c: 0.25063133478594724d),
new NpgsqlTypes.NpgsqlLine(a: 0.08700627541515049d, b: 0.015511651797353587d, c: 0.2628439810194376d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0022150425113200978d, b: 0.6408101889053142d, c: 0.8818600053379897d),
new NpgsqlTypes.NpgsqlLine(a: 0.18923828543872778d, b: 0.43004089676582935d, c: 0.3158207477691355d),
new NpgsqlTypes.NpgsqlLine(a: 0.19639422262170636d, b: 0.7300862753166656d, c: 0.8996468245708105d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.11874642342676944d, b: 0.7478220773078548d, c: 0.7456944733126416d),
new NpgsqlTypes.NpgsqlLine(a: 0.0344423219752078d, b: 0.7595471473527846d, c: 0.6618458442520146d),
new NpgsqlTypes.NpgsqlLine(a: 0.19114849049960936d, b: 0.42705439943743606d, c: 0.05172531617562737d),
new NpgsqlTypes.NpgsqlLine(a: 0.6344657070267692d, b: 0.7638443794749263d, c: 0.004457646774533197d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9435516077228964d, b: 0.3703111852582195d, c: 0.7986266696368896d),
new NpgsqlTypes.NpgsqlLine(a: 0.6468699545099748d, b: 0.8791600680575022d, c: 0.5628970743659366d),
new NpgsqlTypes.NpgsqlLine(a: 0.6817308823519784d, b: 0.060589942485553605d, c: 0.24840284132735913d),
new NpgsqlTypes.NpgsqlLine(a: 0.24432197561651214d, b: 0.2458640181013243d, c: 0.5404016160166809d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2797181212403863d, b: 0.31205571850604463d, c: 0.16549550530034252d),
new NpgsqlTypes.NpgsqlLine(a: 0.6496890877870705d, b: 0.2538113515032816d, c: 0.8757113789522505d),
new NpgsqlTypes.NpgsqlLine(a: 0.9849214454900094d, b: 0.08961581363981064d, c: 0.3208101284989613d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9815146928662979d, b: 0.321788680795262d, c: 0.4392847910612606d),
new NpgsqlTypes.NpgsqlLine(a: 0.19958841310414943d, b: 0.36285708774607917d, c: 0.8317170189019173d),
new NpgsqlTypes.NpgsqlLine(a: 0.31734049058215763d, b: 0.3409847388502808d, c: 0.9194540101194463d),
new NpgsqlTypes.NpgsqlLine(a: 0.5607656367459762d, b: 0.7054350512141503d, c: 0.37812036364269297d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 59,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.017799055062195812d, b: 0.842110613425906d, c: 0.3680048182066915d),
new NpgsqlTypes.NpgsqlLine(a: 0.07849065009397527d, b: 0.8784084799891432d, c: 0.7336138015023926d),
new NpgsqlTypes.NpgsqlLine(a: 0.7691824081002904d, b: 0.6737266907351943d, c: 0.04241543490354771d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.712430620450372d, b: 0.3769269004048841d, c: 0.16356483969284863d),
new NpgsqlTypes.NpgsqlLine(a: 0.1959146201582812d, b: 0.24046800149891157d, c: 0.9084190663865472d),
new NpgsqlTypes.NpgsqlLine(a: 0.15197438113162542d, b: 0.029541736524577478d, c: 0.8389743035295713d),
new NpgsqlTypes.NpgsqlLine(a: 0.3241486142345872d, b: 0.7851276571820734d, c: 0.13207640982564017d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.43471443660687303d, b: 0.9834806490640858d, c: 0.6975152048029329d),
new NpgsqlTypes.NpgsqlLine(a: 0.2550089834688023d, b: 0.6289379152914615d, c: 0.5707647992634087d),
new NpgsqlTypes.NpgsqlLine(a: 0.9506936959390687d, b: 0.3923156482969622d, c: 0.5516612870744425d),
new NpgsqlTypes.NpgsqlLine(a: 0.1832068937832727d, b: 0.8811859727571089d, c: 0.16989145215628132d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8356517608368355d, b: 0.42981874137609266d, c: 0.06767203083374795d),
new NpgsqlTypes.NpgsqlLine(a: 0.3109784508894251d, b: 0.8343131226675743d, c: 0.7055552499174728d),
new NpgsqlTypes.NpgsqlLine(a: 0.9558722315798303d, b: 0.8406924505094069d, c: 0.0725755384553024d),
new NpgsqlTypes.NpgsqlLine(a: 0.13651124487630328d, b: 0.977347170076717d, c: 0.8029990351689954d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.30705173865297664d, b: 0.4203542861847307d, c: 0.2897042064590879d),
new NpgsqlTypes.NpgsqlLine(a: 0.7754200086559564d, b: 0.8342304896070782d, c: 0.6472416750317611d),
new NpgsqlTypes.NpgsqlLine(a: 0.07780890581543276d, b: 0.6682921939551508d, c: 0.963176990580972d),
new NpgsqlTypes.NpgsqlLine(a: 0.9128956074766625d, b: 0.5042781995641273d, c: 0.32633314747930864d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.829309919088488d, b: 0.7192160620193357d, c: 0.7412848257097379d),
new NpgsqlTypes.NpgsqlLine(a: 0.294076368166434d, b: 0.564430218591598d, c: 0.3107299992531264d),
new NpgsqlTypes.NpgsqlLine(a: 0.07035019722392932d, b: 0.3373192641953121d, c: 0.24440719738783967d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9338001305701459d, b: 0.19671493110273242d, c: 0.3989524757963855d),
new NpgsqlTypes.NpgsqlLine(a: 0.016757174990864265d, b: 0.5682466962057037d, c: 0.5185438211450122d),
new NpgsqlTypes.NpgsqlLine(a: 0.30068692619887927d, b: 0.7670451278831497d, c: 0.7084562531163827d),
new NpgsqlTypes.NpgsqlLine(a: 0.852502249599776d, b: 0.19418735584383584d, c: 0.6041097979273756d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1588023458277571d, b: 0.6511251864150815d, c: 0.4418379730319255d),
new NpgsqlTypes.NpgsqlLine(a: 0.7540209524936514d, b: 0.34684458906072435d, c: 0.6701507111984292d),
new NpgsqlTypes.NpgsqlLine(a: 0.39067460571137436d, b: 0.47920170019056785d, c: 0.909886795313186d),
new NpgsqlTypes.NpgsqlLine(a: 0.4171891317674452d, b: 0.028008533430502025d, c: 0.6986772537264914d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7388477643682295d, b: 0.6779259776049009d, c: 0.45704715405746843d),
new NpgsqlTypes.NpgsqlLine(a: 0.6386590274582462d, b: 0.7549766477205357d, c: 0.04427864084677913d),
new NpgsqlTypes.NpgsqlLine(a: 0.6108700696074925d, b: 0.8771966176082899d, c: 0.3715413131192946d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4776235753742234d, b: 0.007725830784295007d, c: 0.4712368112691424d),
new NpgsqlTypes.NpgsqlLine(a: 0.0446880436856546d, b: 0.9569643135061481d, c: 0.6347396625661968d),
new NpgsqlTypes.NpgsqlLine(a: 0.21520602921497323d, b: 0.5127256779304102d, c: 0.19464758285819417d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 81,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4026818204699456d, b: 0.7611768207934548d, c: 0.47617447216327935d),
new NpgsqlTypes.NpgsqlLine(a: 0.5106426274369691d, b: 0.7637768661670347d, c: 0.7855620828991593d),
new NpgsqlTypes.NpgsqlLine(a: 0.5947182681104048d, b: 0.13058468753577523d, c: 0.459252224106811d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.18133488865427894d, b: 0.4048026550471884d, c: 0.8188609950155157d),
new NpgsqlTypes.NpgsqlLine(a: 0.9202187490243089d, b: 0.19508546778621538d, c: 0.48660026485992447d),
new NpgsqlTypes.NpgsqlLine(a: 0.12426549727672553d, b: 0.12037238060092059d, c: 0.8472762886488826d),
new NpgsqlTypes.NpgsqlLine(a: 0.3426930837193416d, b: 0.376375900895192d, c: 0.8357347099965493d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6867498646226587d, b: 0.7290133832441529d, c: 0.9170290887084986d),
new NpgsqlTypes.NpgsqlLine(a: 0.09488494269510583d, b: 0.06600235902688578d, c: 0.41418970879145267d),
new NpgsqlTypes.NpgsqlLine(a: 0.3842196996352425d, b: 0.6794296666300509d, c: 0.08836421705677477d),
new NpgsqlTypes.NpgsqlLine(a: 0.7902118908886225d, b: 0.49333540173165347d, c: 0.5591137738043555d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6175748629093032d, b: 0.9331872703977421d, c: 0.5997786122876536d),
new NpgsqlTypes.NpgsqlLine(a: 0.016885375575677042d, b: 0.8920335484263503d, c: 0.7544879144956989d),
new NpgsqlTypes.NpgsqlLine(a: 0.8620275855213207d, b: 0.5871933814292293d, c: 0.9592205888232032d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9102914345194708d, b: 0.056395088681375216d, c: 0.5208856472211495d),
new NpgsqlTypes.NpgsqlLine(a: 0.35248446259484767d, b: 0.5536870982724149d, c: 0.36762048534527514d),
new NpgsqlTypes.NpgsqlLine(a: 0.08807173965971071d, b: 0.3134064012813934d, c: 0.356520242879663d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6420433505617565d, b: 0.8770167636848628d, c: 0.06776590396840976d),
new NpgsqlTypes.NpgsqlLine(a: 0.31423116239883986d, b: 0.7429683920450817d, c: 0.21632532966074725d),
new NpgsqlTypes.NpgsqlLine(a: 0.9533624295441067d, b: 0.1514225439784892d, c: 0.9067603101074971d),
new NpgsqlTypes.NpgsqlLine(a: 0.2513210960083827d, b: 0.5726932685823088d, c: 0.33532741973378277d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6793210557455832d, b: 0.4608885749175903d, c: 0.8821162673238384d),
new NpgsqlTypes.NpgsqlLine(a: 0.07017194035065466d, b: 0.26514136333068816d, c: 0.1904701759908658d),
new NpgsqlTypes.NpgsqlLine(a: 0.3815765721574047d, b: 0.989864576743882d, c: 0.8121556405457445d),
new NpgsqlTypes.NpgsqlLine(a: 0.4800200332103479d, b: 0.5883823751514823d, c: 0.4502009231956263d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.17546834399060307d, b: 0.7806862346428142d, c: 0.9073618258536895d),
new NpgsqlTypes.NpgsqlLine(a: 0.36464000780926864d, b: 0.029899727087090433d, c: 0.7015629760646384d),
new NpgsqlTypes.NpgsqlLine(a: 0.08651181865736834d, b: 0.2632035422489907d, c: 0.1715067597047899d),
new NpgsqlTypes.NpgsqlLine(a: 0.7036468155408322d, b: 0.8209597330581917d, c: 0.793303334389216d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2777470839536933d, b: 0.8487222893355182d, c: 0.29229646013537924d),
new NpgsqlTypes.NpgsqlLine(a: 0.291520231938748d, b: 0.901277324691297d, c: 0.36952490869308185d),
new NpgsqlTypes.NpgsqlLine(a: 0.1706396254155096d, b: 0.26258020923915537d, c: 0.27349674595968443d),
new NpgsqlTypes.NpgsqlLine(a: 0.5743574112817891d, b: 0.8110925884598862d, c: 0.9166675862243464d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5504699672022288d, b: 0.8301492072590496d, c: 0.7506088359760945d),
new NpgsqlTypes.NpgsqlLine(a: 0.9813049067638006d, b: 0.9494582114628586d, c: 0.9899930177557082d),
new NpgsqlTypes.NpgsqlLine(a: 0.18141985211098088d, b: 0.3953776007085723d, c: 0.39152880676059243d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 108,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6179879168920368d, b: 0.26978660065534676d, c: 0.133868301233099d),
new NpgsqlTypes.NpgsqlLine(a: 0.2359008078228778d, b: 0.22974201071646216d, c: 0.09286422369400404d),
new NpgsqlTypes.NpgsqlLine(a: 0.33324686828627037d, b: 0.7074867290983172d, c: 0.572798624566234d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8100449847404052d, b: 0.9337017339868605d, c: 0.2236145477999546d),
new NpgsqlTypes.NpgsqlLine(a: 0.4835952105248581d, b: 0.27161184161346885d, c: 0.35288721573824366d),
new NpgsqlTypes.NpgsqlLine(a: 0.2395582641368631d, b: 0.08284872594980197d, c: 0.9913736232456729d),
new NpgsqlTypes.NpgsqlLine(a: 0.481104561873147d, b: 0.20762230662833414d, c: 0.5103627182931564d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4938814286798303d, b: 0.8460386553809653d, c: 0.5040832610355581d),
new NpgsqlTypes.NpgsqlLine(a: 0.2518481232283135d, b: 0.5349421403399384d, c: 0.6542787530162031d),
new NpgsqlTypes.NpgsqlLine(a: 0.5040399660906733d, b: 0.49919808277814626d, c: 0.5340477678707858d),
new NpgsqlTypes.NpgsqlLine(a: 0.9308522857020463d, b: 0.3827251879697412d, c: 0.8829363272612086d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7330289340098131d, b: 0.9908604128664027d, c: 0.7314076265860161d),
new NpgsqlTypes.NpgsqlLine(a: 0.28377016687624046d, b: 0.7009024430129256d, c: 0.20507693113296077d),
new NpgsqlTypes.NpgsqlLine(a: 0.24441928849539551d, b: 0.7383228929344845d, c: 0.8407786518776533d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.4705373566402131d, b: 0.06137004078010322d, c: 0.22969213223155094d),
new NpgsqlTypes.NpgsqlLine(a: 0.022911203574958794d, b: 0.845774164136822d, c: 0.8693702511666792d),
new NpgsqlTypes.NpgsqlLine(a: 0.544260781958386d, b: 0.20389600934824303d, c: 0.9541101188641996d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.48193617929515253d, b: 0.6558788173505083d, c: 0.9884525681189718d),
new NpgsqlTypes.NpgsqlLine(a: 0.6028454121131799d, b: 0.9894999074529912d, c: 0.3825428366908733d),
new NpgsqlTypes.NpgsqlLine(a: 0.5300578050581057d, b: 0.5463542523002541d, c: 0.33744578077945575d),
new NpgsqlTypes.NpgsqlLine(a: 0.406937904230563d, b: 0.6442846775672212d, c: 0.9831609733492013d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.031874909408058705d, b: 0.14622369798595103d, c: 0.3263802360595046d),
new NpgsqlTypes.NpgsqlLine(a: 0.6921545575036786d, b: 0.9387053229724758d, c: 0.6281055414384692d),
new NpgsqlTypes.NpgsqlLine(a: 0.939000599347899d, b: 0.10352674143298846d, c: 0.5739671803157855d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.669204046237092d, b: 0.2910200445929314d, c: 0.5074749539025152d),
new NpgsqlTypes.NpgsqlLine(a: 0.22495118818899784d, b: 0.7216304548350286d, c: 0.9027697207000077d),
new NpgsqlTypes.NpgsqlLine(a: 0.8827612712215833d, b: 0.4084202899452921d, c: 0.9217605632262239d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0646946197677849d, b: 0.16074562039518925d, c: 0.11552171435127534d),
new NpgsqlTypes.NpgsqlLine(a: 0.6409324716209126d, b: 0.11996650359731331d, c: 0.7378059783589173d),
new NpgsqlTypes.NpgsqlLine(a: 0.5190007400546048d, b: 0.19887666587934583d, c: 0.2870083823090086d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.021978317398986813d, b: 0.9491904278900507d, c: 0.19687348380747394d),
new NpgsqlTypes.NpgsqlLine(a: 0.8353973925808136d, b: 0.8662445704285866d, c: 0.0328938673391761d),
new NpgsqlTypes.NpgsqlLine(a: 0.45917013847396304d, b: 0.3573243692517879d, c: 0.19500214292807183d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.08515424519924275d, b: 0.7109662190035455d, c: 0.6184085290955135d),
new NpgsqlTypes.NpgsqlLine(a: 0.10346753741794823d, b: 0.3457198034559571d, c: 0.6552413471636955d),
new NpgsqlTypes.NpgsqlLine(a: 0.6498408090000524d, b: 0.7220177948638312d, c: 0.9412560454382036d),
new NpgsqlTypes.NpgsqlLine(a: 0.3445779701369768d, b: 0.6306144973442771d, c: 0.5204017330624324d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35770003364566705d, b: 0.12006876320162496d, c: 0.7493272799394528d),
new NpgsqlTypes.NpgsqlLine(a: 0.546182179681861d, b: 0.8000921826584789d, c: 0.15908951217150868d),
new NpgsqlTypes.NpgsqlLine(a: 0.22349455739426638d, b: 0.15030307327049552d, c: 0.4562339266037787d),
new NpgsqlTypes.NpgsqlLine(a: 0.5612345502237005d, b: 0.7755984132951744d, c: 0.7050885027000479d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.35292364868783976d, b: 0.6027478178988317d, c: 0.190637656626637d),
new NpgsqlTypes.NpgsqlLine(a: 0.9630174213339076d, b: 0.4759452303676672d, c: 0.6415527886198029d),
new NpgsqlTypes.NpgsqlLine(a: 0.7857340557031242d, b: 0.3465895950843042d, c: 0.2858839508669384d),
new NpgsqlTypes.NpgsqlLine(a: 0.838523770102738d, b: 0.9768951117159305d, c: 0.8061934259497044d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8905673886770981d, b: 0.7955562313599901d, c: 0.43437041684509425d),
new NpgsqlTypes.NpgsqlLine(a: 0.8729642481860573d, b: 0.19422377825434634d, c: 0.46232043468048034d),
new NpgsqlTypes.NpgsqlLine(a: 0.010077479004399703d, b: 0.8493383646382077d, c: 0.09065390693120334d),
new NpgsqlTypes.NpgsqlLine(a: 0.9725601248039826d, b: 0.6514860777645688d, c: 0.00729601162872362d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1967715006633164d, b: 0.46468550773997674d, c: 0.23835954476321686d),
new NpgsqlTypes.NpgsqlLine(a: 0.9344548579983855d, b: 0.03316149901985277d, c: 0.03335243966469659d),
new NpgsqlTypes.NpgsqlLine(a: 0.25558873393983783d, b: 0.06966787971438382d, c: 0.13593713496277926d),
new NpgsqlTypes.NpgsqlLine(a: 0.9728161157631033d, b: 0.5191501087889888d, c: 0.24528283843177767d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8229983286218971d, b: 0.8257064934250162d, c: 0.8196858947258417d),
new NpgsqlTypes.NpgsqlLine(a: 0.6914894160002232d, b: 0.10543176196129378d, c: 0.26534497429666093d),
new NpgsqlTypes.NpgsqlLine(a: 0.7378997710070508d, b: 0.6218153083658535d, c: 0.8113521471913685d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5830715546693518d, b: 0.5984262225851835d, c: 0.6422160155079227d),
new NpgsqlTypes.NpgsqlLine(a: 0.23174746518354328d, b: 0.23155202403969888d, c: 0.16362004398075247d),
new NpgsqlTypes.NpgsqlLine(a: 0.6313353141857783d, b: 0.2427494437315949d, c: 0.8263375225571886d),
new NpgsqlTypes.NpgsqlLine(a: 0.8749567831662252d, b: 0.32828614977757886d, c: 0.5421172507050459d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8583712832691595d, b: 0.4144066593240856d, c: 0.768882804900996d),
new NpgsqlTypes.NpgsqlLine(a: 0.9615157879365966d, b: 0.6095650010927494d, c: 0.4672733922597685d),
new NpgsqlTypes.NpgsqlLine(a: 0.6085906271675479d, b: 0.6669843261164832d, c: 0.64912346643777d),
new NpgsqlTypes.NpgsqlLine(a: 0.9766571390587863d, b: 0.2139625829722558d, c: 0.5903241691779629d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.26252781133887026d, b: 0.9428768300637259d, c: 0.11110919617115145d),
new NpgsqlTypes.NpgsqlLine(a: 0.25325262405913607d, b: 0.6408580778237805d, c: 0.2276357496641629d),
new NpgsqlTypes.NpgsqlLine(a: 0.9102683472329451d, b: 0.44870615070058895d, c: 0.2879576210004746d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 139,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.10199733546025791d, b: 0.9480824874272146d, c: 0.40450569947669857d),
new NpgsqlTypes.NpgsqlLine(a: 0.04450153767955978d, b: 0.020043951217610045d, c: 0.9833901229512214d),
new NpgsqlTypes.NpgsqlLine(a: 0.08122862788080976d, b: 0.4241516817119082d, c: 0.6632719840995388d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.6997839468039708d, b: 0.5655219018310712d, c: 0.6794177085447285d),
new NpgsqlTypes.NpgsqlLine(a: 0.5867849541299872d, b: 0.33679013881090925d, c: 0.8266437517095104d),
new NpgsqlTypes.NpgsqlLine(a: 0.5255117192423474d, b: 0.6895588467237559d, c: 0.327578429715326d),
new NpgsqlTypes.NpgsqlLine(a: 0.310948774319026d, b: 0.05825820242637314d, c: 0.4305061121076549d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.19121105728621923d, b: 0.9793395332530133d, c: 0.11976010163470441d),
new NpgsqlTypes.NpgsqlLine(a: 0.4876690052606092d, b: 0.7524578912468254d, c: 0.8487389618661048d),
new NpgsqlTypes.NpgsqlLine(a: 0.823581378086534d, b: 0.44949483466527296d, c: 0.04818552992425684d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8755291985551679d, b: 0.7839591607677511d, c: 0.4128048768377155d),
new NpgsqlTypes.NpgsqlLine(a: 0.18842226795591221d, b: 0.7374702163305525d, c: 0.3894048832557627d),
new NpgsqlTypes.NpgsqlLine(a: 0.6729138822043853d, b: 0.9332657579005184d, c: 0.8982123393358311d),
new NpgsqlTypes.NpgsqlLine(a: 0.6450333992650072d, b: 0.08378873198579062d, c: 0.7776742388625764d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2739247637422776d, b: 0.7791961039530324d, c: 0.01514564864098733d),
new NpgsqlTypes.NpgsqlLine(a: 0.018673828763588918d, b: 0.7995176431826049d, c: 0.5751049247237134d),
new NpgsqlTypes.NpgsqlLine(a: 0.633792863906512d, b: 0.6587520040334627d, c: 0.718563690301471d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.7519705383054286d, b: 0.616966755978148d, c: 0.21028528011552206d),
new NpgsqlTypes.NpgsqlLine(a: 0.7135912258020995d, b: 0.6745978187933411d, c: 0.2085786155831132d),
new NpgsqlTypes.NpgsqlLine(a: 0.18507101570726414d, b: 0.5746194115592691d, c: 0.5532395326972892d),
new NpgsqlTypes.NpgsqlLine(a: 0.364110893393098d, b: 0.500381780858207d, c: 0.5591622389285111d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 150,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.44683655283863266d, b: 0.8736783642982313d, c: 0.7529815261565731d),
new NpgsqlTypes.NpgsqlLine(a: 0.4549468172977206d, b: 0.5574024951594747d, c: 0.7437116136409029d),
new NpgsqlTypes.NpgsqlLine(a: 0.36961559534760013d, b: 0.64183810751881d, c: 0.170006432696295d),
new NpgsqlTypes.NpgsqlLine(a: 0.6319710538643009d, b: 0.4926594924366663d, c: 0.014032669578019852d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9728752805472707d, b: 0.17545431996616168d, c: 0.24072820961959096d),
new NpgsqlTypes.NpgsqlLine(a: 0.07459235499198458d, b: 0.5915807509839566d, c: 0.2692695113927963d),
new NpgsqlTypes.NpgsqlLine(a: 0.46653944680455606d, b: 0.12981589437861263d, c: 0.5563094089862091d),
new NpgsqlTypes.NpgsqlLine(a: 0.744483888079181d, b: 0.565655763468003d, c: 0.15132438474614196d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 158,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.3817623853332319d, b: 0.23416827366394566d, c: 0.5446968224417535d),
new NpgsqlTypes.NpgsqlLine(a: 0.7095041844943384d, b: 0.7151986298987048d, c: 0.058778611322177654d),
new NpgsqlTypes.NpgsqlLine(a: 0.02971062083845022d, b: 0.6646159030520777d, c: 0.330039487039158d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5640031825235816d, b: 0.4585335511250571d, c: 0.761199765383247d),
new NpgsqlTypes.NpgsqlLine(a: 0.018134097233802215d, b: 0.3170266808363458d, c: 0.1630131595243154d),
new NpgsqlTypes.NpgsqlLine(a: 0.6756755762812711d, b: 0.06646705207691761d, c: 0.2629012093898623d),
new NpgsqlTypes.NpgsqlLine(a: 0.2626986312497819d, b: 0.39525024658514063d, c: 0.6916838394572704d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8958624323695923d, b: 0.09299028066353421d, c: 0.605067070428134d),
new NpgsqlTypes.NpgsqlLine(a: 0.27182996192415d, b: 0.6933443676744087d, c: 0.18243810128642224d),
new NpgsqlTypes.NpgsqlLine(a: 0.007914871972225956d, b: 0.3723095981843235d, c: 0.9631811181135922d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.1602510528218869d, b: 0.7283176692155834d, c: 0.767760341592136d),
new NpgsqlTypes.NpgsqlLine(a: 0.7580185300470513d, b: 0.2721579986304551d, c: 0.6245787885205855d),
new NpgsqlTypes.NpgsqlLine(a: 0.9355966589358813d, b: 0.26070800260254046d, c: 0.40569037404868946d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.322976628060312d, b: 0.9174094538562233d, c: 0.05125462056803487d),
new NpgsqlTypes.NpgsqlLine(a: 0.6631494657167851d, b: 0.30007263439996745d, c: 0.16557119319044777d),
new NpgsqlTypes.NpgsqlLine(a: 0.5158889239488736d, b: 0.26071437676081666d, c: 0.6334095200769477d),
new NpgsqlTypes.NpgsqlLine(a: 0.26833998929298475d, b: 0.5492176941160983d, c: 0.6422929737732564d),
},
},
            new NpgsqlLinelineArray1M
{
    Id = 167,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.2012186592292735d, b: 0.8389696022682168d, c: 0.49586214755385893d),
new NpgsqlTypes.NpgsqlLine(a: 0.6419794867918497d, b: 0.043745092262978735d, c: 0.9104713179426291d),
new NpgsqlTypes.NpgsqlLine(a: 0.8076276755964327d, b: 0.21921377919517704d, c: 0.9346577132159303d),
new NpgsqlTypes.NpgsqlLine(a: 0.8116405244488438d, b: 0.3964634397326954d, c: 0.2635742371208921d),
},
    ModelInner = new NpgsqlLinelineArray1MI
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.5996930882883532d, b: 0.0995885874847986d, c: 0.7779089850902375d),
new NpgsqlTypes.NpgsqlLine(a: 0.05694635780593271d, b: 0.15229511720715927d, c: 0.25583278677177124d),
new NpgsqlTypes.NpgsqlLine(a: 0.04319504015901654d, b: 0.47267758331155985d, c: 0.6978219913292456d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.029289217806884538d, b: 0.9226777635646278d, c: 0.2405107933302456d),
new NpgsqlTypes.NpgsqlLine(a: 0.39159880015224713d, b: 0.07179680472905126d, c: 0.7829528412181909d),
new NpgsqlTypes.NpgsqlLine(a: 0.8512527721185157d, b: 0.3220545209234742d, c: 0.2302804507173306d),
},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.8487436835711608d, b: 0.1834334187515333d, c: 0.175635522059017d),
new NpgsqlTypes.NpgsqlLine(a: 0.6243483539267111d, b: 0.4995797844885078d, c: 0.016449431927391123d),
new NpgsqlTypes.NpgsqlLine(a: 0.7828405429171532d, b: 0.6444481168093537d, c: 0.8275768350502347d),
new NpgsqlTypes.NpgsqlLine(a: 0.5305800084013456d, b: 0.7581668916587119d, c: 0.9405981713384688d),
},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
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

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineArraylineArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineArraylineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineArraylineArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineArraylineArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.06449013354774913d, b: 0.9619786643826904d, c: 0.06858620788873304d),
new NpgsqlTypes.NpgsqlLine(a: 0.8625999884677916d, b: 0.2548768060905451d, c: 0.4271431525814403d),
new NpgsqlTypes.NpgsqlLine(a: 0.9252232013684087d, b: 0.971330077551422d, c: 0.7702171674286922d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlLine[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483638);
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

                    nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[3]
{
new NpgsqlTypes.NpgsqlLine(a: 0.0022150425113200978d, b: 0.6408101889053142d, c: 0.8818600053379897d),
new NpgsqlTypes.NpgsqlLine(a: 0.18923828543872778d, b: 0.43004089676582935d, c: 0.3158207477691355d),
new NpgsqlTypes.NpgsqlLine(a: 0.19639422262170636d, b: 0.7300862753166656d, c: 0.8996468245708105d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinearray1m(
	id,
    value,
    nullablevalue,
    npgsqllinelinearray1mi_id
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
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlLine[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483638)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqllinelinearray1mi_id", 
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
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.9815146928662979d, b: 0.321788680795262d, c: 0.4392847910612606d),
new NpgsqlTypes.NpgsqlLine(a: 0.19958841310414943d, b: 0.36285708774607917d, c: 0.8317170189019173d),
new NpgsqlTypes.NpgsqlLine(a: 0.31734049058215763d, b: 0.3409847388502808d, c: 0.9194540101194463d),
new NpgsqlTypes.NpgsqlLine(a: 0.5607656367459762d, b: 0.7054350512141503d, c: 0.37812036364269297d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlLine[] nullable = null;
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlLine[4]
{
new NpgsqlTypes.NpgsqlLine(a: 0.712430620450372d, b: 0.3769269004048841d, c: 0.16356483969284863d),
new NpgsqlTypes.NpgsqlLine(a: 0.1959146201582812d, b: 0.24046800149891157d, c: 0.9084190663865472d),
new NpgsqlTypes.NpgsqlLine(a: 0.15197438113162542d, b: 0.029541736524577478d, c: 0.8389743035295713d),
new NpgsqlTypes.NpgsqlLine(a: 0.3241486142345872d, b: 0.7851276571820734d, c: 0.13207640982564017d),
}));
                nullable = await ((INpgsqlLineArraylineArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlLineArraylineArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineArray1M> models = null;

                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineArraylineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineArraylineArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineArraylineArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[31],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 141;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 23;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 31;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 81;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                Assert.That(firstItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
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
                parametr1.Value = 111;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 158;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 65;
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 33;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 39;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 9;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[1], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[2], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[3], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[4], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[5], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[6], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[7], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[27],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[28],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[29],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[30],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[31],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[32],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M), typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                await((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 141, query1, 110, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 65, query1, 59, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[23],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray1M>();
                var models2 = new List<FlatNpgsqlLinelineArray1M>();
                ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 111, query1, 139, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 141, query1, 150, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[0],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[1],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[2],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[3],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems2[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 99, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[26],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[27],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[28],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[29],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[30],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[31],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                await ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 108, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 96, query1, 150, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
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
FROM public.npgsqllinelinearray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray1M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray1M>();
                 ((INpgsqlLineArraylineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 96, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqllinelinearray1m m
LEFT JOIN public.npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await((INpgsqlLineArraylineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 48))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[8], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[9], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[10], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[11], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[12], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[13], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[21],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[22],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[23],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[24],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[25],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[26],_testData[34], false);
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
                var models = ((INpgsqlLineArraylineArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineArraylineArray)this).DbConnectionSTSelectModelBatch(connection, 133, 71))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlLinelineArray1M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineArray1M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineArray1M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineArray1M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineArray1M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineArray1M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineArray1M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineArray1M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineArray1M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineArray1M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineArray1M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineArray1M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineArray1M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineArray1M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineArray1M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineArray1M.AssertModel(models[15],_testData[29], false);
                        NpgsqlLinelineArray1M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineArray1M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineArray1M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineArray1M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineArray1M.AssertModel(models[20],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 150);
                var models = await ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(4));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[31], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[32], false);
                NpgsqlLinelineArray1M.AssertModel(models[2],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineArraylineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineArraylineArray)this).SetDbConnectionSelectModelParametrs(cmd, 164);
                var models =  ((INpgsqlLineArraylineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(2));

                NpgsqlLinelineArray1M.AssertModel(models[0],_testData[33], false);
                NpgsqlLinelineArray1M.AssertModel(models[1],_testData[34], false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineArraylineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MI),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinearray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineArraylineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineArray1M),
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
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
FROM public.binary_npgsqllinelinearray1m m
LEFT JOIN public.binary_npgsqllinelinearray1mi mi ON mi.id = m.npgsqllinelinearray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineArraylineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineArraylineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineArraylineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineArraylineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinearray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models =  ((INpgsqlLineArraylineArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray1mi
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
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI), typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                await ((INpgsqlLineArraylineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MI>();
                var models2 = new List<NpgsqlLinelineArray1MI>();
                ((INpgsqlLineArraylineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray)),
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
                var models = await ((INpgsqlLineArraylineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA), typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                await ((INpgsqlLineArraylineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray1MIWA>();
                var models2 = new List<NpgsqlLinelineArray1MIWA>();
                ((INpgsqlLineArraylineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineArraylineArray))]
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
                var models = await ((INpgsqlLineArraylineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineArraylineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

