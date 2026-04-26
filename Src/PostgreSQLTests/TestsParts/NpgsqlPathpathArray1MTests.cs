

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
    internal partial interface INpgsqlPathArraypathArray
    {
    }
    
    internal partial class NpgsqlPathArraypathArray : INpgsqlPathArraypathArray
    {


#region TestData

        private readonly NpgsqlPathpathArray1M[] _testData = new NpgsqlPathpathArray1M[]
        {
            new NpgsqlPathpathArray1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21043284845632915d, y: 0.8408726101778413d), new NpgsqlTypes.NpgsqlPoint(x: 0.373602503457259d, y: 0.15878597375474723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7632359923913404d, y: 0.07317115346505476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12122487713784014d, y: 0.1244557610938386d), new NpgsqlTypes.NpgsqlPoint(x: 0.05450442186178528d, y: 0.12959931746749365d), new NpgsqlTypes.NpgsqlPoint(x: 0.04128914624717506d, y: 0.31878362366299584d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8219817493832919d, y: 0.004482411127829766d), new NpgsqlTypes.NpgsqlPoint(x: 0.38889949915747646d, y: 0.41296446928291985d), new NpgsqlTypes.NpgsqlPoint(x: 0.033556207923521875d, y: 0.332785464596719d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4538091503816982d, y: 0.6942061452310817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964825838039984d, y: 0.6985135750878081d), new NpgsqlTypes.NpgsqlPoint(x: 0.8022060996225292d, y: 0.6488053733578241d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018627686675220856d, y: 0.38894968554658704d), new NpgsqlTypes.NpgsqlPoint(x: 0.4535088697280707d, y: 0.6697724175700831d), new NpgsqlTypes.NpgsqlPoint(x: 0.6777723096317924d, y: 0.5064433489011788d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40382477722522414d, y: 0.6148483440438359d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281561285722189d, y: 0.23559785189463212d), new NpgsqlTypes.NpgsqlPoint(x: 0.08523537182415708d, y: 0.8760658584272771d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7218238497812406d, y: 0.4875150521254088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582081353641535d, y: 0.6407196290729671d), new NpgsqlTypes.NpgsqlPoint(x: 0.12014401277656939d, y: 0.6807691617514425d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11751205773493745d, y: 0.8714332427866543d), new NpgsqlTypes.NpgsqlPoint(x: 0.6654449947431527d, y: 0.9306906887374224d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881231377114455d, y: 0.2830463203211171d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4092992128831072d, y: 0.6697091014661554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6367708281953759d, y: 0.6957072958755046d), new NpgsqlTypes.NpgsqlPoint(x: 0.5668052954092299d, y: 0.4148004731144762d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5615960854085622d, y: 0.5278387758480751d), new NpgsqlTypes.NpgsqlPoint(x: 0.9427527015860995d, y: 0.661179535855729d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813297317276422d, y: 0.42471318929651947d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5382163733877606d, y: 0.4284187629621763d), new NpgsqlTypes.NpgsqlPoint(x: 0.14682278439571372d, y: 0.49116967471152506d), new NpgsqlTypes.NpgsqlPoint(x: 0.43374479610158656d, y: 0.5399022064874817d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1852167794747126d, y: 0.7138236218607971d), new NpgsqlTypes.NpgsqlPoint(x: 0.29095597644065285d, y: 0.6248767163226184d), new NpgsqlTypes.NpgsqlPoint(x: 0.1522853475625271d, y: 0.33326519153880574d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13145851704093403d, y: 0.5687170720986219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105204810591944d, y: 0.35387093105853973d), new NpgsqlTypes.NpgsqlPoint(x: 0.26087812299126734d, y: 0.3759156359957868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4696973863586026d, y: 0.5352911814176565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5538598354331545d, y: 0.31990099440140085d), new NpgsqlTypes.NpgsqlPoint(x: 0.07126437240855199d, y: 0.4576342586169885d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29137802206792063d, y: 0.7473588678576738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6449330483866913d, y: 0.7034825034783349d), new NpgsqlTypes.NpgsqlPoint(x: 0.18874678915424425d, y: 0.0034374158657973775d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25323061756229204d, y: 0.9208363507558494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180487361701713d, y: 0.5867748879900527d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868510540598297d, y: 0.6113212153657036d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5016617533002335d, y: 0.15333630531965636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7901713449503192d, y: 0.7946368931660461d), new NpgsqlTypes.NpgsqlPoint(x: 0.09578151004208235d, y: 0.7831786994029425d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30271232622545263d, y: 0.0876112904025631d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072228839359048d, y: 0.4272852118924455d), new NpgsqlTypes.NpgsqlPoint(x: 0.416460919592997d, y: 0.4758285203751431d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3680721934564174d, y: 0.28244245568903725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9263298518133513d, y: 0.507781459550086d), new NpgsqlTypes.NpgsqlPoint(x: 0.09834667824807253d, y: 0.3520288933016631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5652083848542417d, y: 0.7676103193101863d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211146896113956d, y: 0.10567162530634988d), new NpgsqlTypes.NpgsqlPoint(x: 0.6152181919174698d, y: 0.9739962859562743d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3955776559233367d, y: 0.5506256072475283d), new NpgsqlTypes.NpgsqlPoint(x: 0.23415158951348036d, y: 0.00919702178202908d), new NpgsqlTypes.NpgsqlPoint(x: 0.20774917823405414d, y: 0.6130400850479931d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45559096333148275d, y: 0.6779226058412098d), new NpgsqlTypes.NpgsqlPoint(x: 0.27701065058294827d, y: 0.7198383182609124d), new NpgsqlTypes.NpgsqlPoint(x: 0.024346625715860437d, y: 0.8908454534044276d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9190833199596475d, y: 0.2955820157718758d), new NpgsqlTypes.NpgsqlPoint(x: 0.053291571400908566d, y: 0.5756743097554504d), new NpgsqlTypes.NpgsqlPoint(x: 0.3440017810690773d, y: 0.1976186236799401d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27262232474849635d, y: 0.6450949831200248d), new NpgsqlTypes.NpgsqlPoint(x: 0.3951615371903815d, y: 0.6703755413940696d), new NpgsqlTypes.NpgsqlPoint(x: 0.8055349074028302d, y: 0.8036172756019545d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.38435385611781825d, y: 0.20704996703848144d), new NpgsqlTypes.NpgsqlPoint(x: 0.6656780375899761d, y: 0.5063552918287102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8952977383384612d, y: 0.3307599241275001d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15401535672799893d, y: 0.16435118493054557d), new NpgsqlTypes.NpgsqlPoint(x: 0.8189002312508022d, y: 0.7327710673792216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8992423167549142d, y: 0.5862649515769255d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.331786114461851d, y: 0.03459245418832979d), new NpgsqlTypes.NpgsqlPoint(x: 0.41236161291869877d, y: 0.6141156027000643d), new NpgsqlTypes.NpgsqlPoint(x: 0.7898711809923771d, y: 0.7940481481377052d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27770483016766334d, y: 0.5083174476171414d), new NpgsqlTypes.NpgsqlPoint(x: 0.7662174817645805d, y: 0.4121360551496962d), new NpgsqlTypes.NpgsqlPoint(x: 0.4732721169909845d, y: 0.3724360640965375d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6422765864104643d, y: 0.23650996415109082d), new NpgsqlTypes.NpgsqlPoint(x: 0.30383995161337185d, y: 0.5209423376044148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8330879311830728d, y: 0.7916487598013167d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13581423727575004d, y: 0.11847688263792022d), new NpgsqlTypes.NpgsqlPoint(x: 0.525385825808932d, y: 0.8021353937602804d), new NpgsqlTypes.NpgsqlPoint(x: 0.8366447088053688d, y: 0.5743758702053496d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6317623177501004d, y: 0.847407187719614d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180460700843469d, y: 0.2784653779356986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8505508157214662d, y: 0.07326527945963457d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9347609091305279d, y: 0.7007180376036868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6429306557402598d, y: 0.7278909525143459d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005935184505842d, y: 0.04942773742112072d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.023478857469921732d, y: 0.32596280450960213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5513872160419613d, y: 0.3427379545552024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8496856396082828d, y: 0.3412001044469628d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45000407776024287d, y: 0.17883418453654032d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720456260421625d, y: 0.8544428614741879d), new NpgsqlTypes.NpgsqlPoint(x: 0.246292367276033d, y: 0.3359814749550364d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5557695386858723d, y: 0.20631703639255272d), new NpgsqlTypes.NpgsqlPoint(x: 0.41959691604502347d, y: 0.6456298852689264d), new NpgsqlTypes.NpgsqlPoint(x: 0.08583017543984717d, y: 0.49874477598596656d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2775886619726141d, y: 0.724156963837845d), new NpgsqlTypes.NpgsqlPoint(x: 0.23320069762217865d, y: 0.6539846012007607d), new NpgsqlTypes.NpgsqlPoint(x: 0.4713242101556444d, y: 0.8856823072036808d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9126881089869093d, y: 0.7880897336942474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196039622932809d, y: 0.19063486508511018d), new NpgsqlTypes.NpgsqlPoint(x: 0.7426333336892998d, y: 0.11791849539912624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33077300078062755d, y: 0.22966373421801067d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668093349735982d, y: 0.2187528891604068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7277338614326276d, y: 0.6974144349850179d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6136741562863502d, y: 0.9703073804225703d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800841312834309d, y: 0.7574817524414797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810220729696404d, y: 0.9448645578966337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6808612552037732d, y: 0.9401369534630861d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638606711541953d, y: 0.6834058765667247d), new NpgsqlTypes.NpgsqlPoint(x: 0.7247810156903265d, y: 0.7524652295225083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356528891794915d, y: 0.917360302244559d), new NpgsqlTypes.NpgsqlPoint(x: 0.0025596023002592005d, y: 0.9354128216123456d), new NpgsqlTypes.NpgsqlPoint(x: 0.47730285869082023d, y: 0.30210062194973564d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8535523770221684d, y: 0.00992971967571632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887340965028484d, y: 0.6257784946119891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9860916872314567d, y: 0.35589281034487974d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8294553011980201d, y: 0.07539742591594056d), new NpgsqlTypes.NpgsqlPoint(x: 0.24600423912586777d, y: 0.963674019005155d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915117563486061d, y: 0.04117082903614244d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08576136034720394d, y: 0.32011837067407045d), new NpgsqlTypes.NpgsqlPoint(x: 0.2470444319949041d, y: 0.557499713754435d), new NpgsqlTypes.NpgsqlPoint(x: 0.10411223139134318d, y: 0.8115201776141339d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29518847702247075d, y: 0.6470710135890603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703179751194804d, y: 0.7422916115998563d), new NpgsqlTypes.NpgsqlPoint(x: 0.5556405468327605d, y: 0.6507339064587652d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3911085938616128d, y: 0.16887720371300996d), new NpgsqlTypes.NpgsqlPoint(x: 0.1092571376570628d, y: 0.4482858372524271d), new NpgsqlTypes.NpgsqlPoint(x: 0.014562454296287441d, y: 0.07718085004099973d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4756398666575872d, y: 0.9760765005428903d), new NpgsqlTypes.NpgsqlPoint(x: 0.21374506135220706d, y: 0.7923392012109186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080509558103635d, y: 0.3042781251333675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8466363343328542d, y: 0.7366759293885149d), new NpgsqlTypes.NpgsqlPoint(x: 0.4308940767681435d, y: 0.3368069210063297d), new NpgsqlTypes.NpgsqlPoint(x: 0.38436160440269307d, y: 0.08020832863976579d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16121163847503928d, y: 0.000318465446414784d), new NpgsqlTypes.NpgsqlPoint(x: 0.9004800807284957d, y: 0.24570066861197715d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142161747092437d, y: 0.20027739927342136d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6818077640972715d, y: 0.7956109752687831d), new NpgsqlTypes.NpgsqlPoint(x: 0.6555687224879757d, y: 0.7751190803134336d), new NpgsqlTypes.NpgsqlPoint(x: 0.8404671324632486d, y: 0.21765043500790937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9499009894213979d, y: 0.4038750267129315d), new NpgsqlTypes.NpgsqlPoint(x: 0.3598857883399801d, y: 0.8018721932536693d), new NpgsqlTypes.NpgsqlPoint(x: 0.3764489655730011d, y: 0.301692691103422d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26876803767995994d, y: 0.2561679688833658d), new NpgsqlTypes.NpgsqlPoint(x: 0.40594334206378757d, y: 0.269761692293234d), new NpgsqlTypes.NpgsqlPoint(x: 0.3829543191421282d, y: 0.5792386590235049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5168380452201925d, y: 0.32435222322685664d), new NpgsqlTypes.NpgsqlPoint(x: 0.30073376214475955d, y: 0.050130502012617706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835503119949895d, y: 0.26556989175045387d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.873788419115516d, y: 0.07188830298640614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564674442689975d, y: 0.3222910990128177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513401461081569d, y: 0.36382123572917435d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5248549012042768d, y: 0.5925044699905153d), new NpgsqlTypes.NpgsqlPoint(x: 0.40738338149085274d, y: 0.7737176293775827d), new NpgsqlTypes.NpgsqlPoint(x: 0.09092715823984687d, y: 0.5458064327655706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7524943211406049d, y: 0.9549008212559874d), new NpgsqlTypes.NpgsqlPoint(x: 0.7900632743657223d, y: 0.2499103382926786d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198977449910913d, y: 0.6478549206000295d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6256274714578671d, y: 0.09870562439935648d), new NpgsqlTypes.NpgsqlPoint(x: 0.08957879080835773d, y: 0.771027578850624d), new NpgsqlTypes.NpgsqlPoint(x: 0.20194408680246234d, y: 0.5815670937732688d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3016193777481623d, y: 0.6994975221711607d), new NpgsqlTypes.NpgsqlPoint(x: 0.7213989738102826d, y: 0.14624634475533427d), new NpgsqlTypes.NpgsqlPoint(x: 0.8096464834529036d, y: 0.3082748339304413d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.246602007841347d, y: 0.14022916841170563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9874955205042211d, y: 0.9924104049425496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9011601054914218d, y: 0.5741676314722544d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05476818569980468d, y: 0.37139690564157013d), new NpgsqlTypes.NpgsqlPoint(x: 0.32699765422180327d, y: 0.5992295359429733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6412866536720928d, y: 0.6292973809002316d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26960978946285574d, y: 0.9755047766254885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5549043606572023d, y: 0.48423364520241896d), new NpgsqlTypes.NpgsqlPoint(x: 0.7673296539614938d, y: 0.8075662217458728d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5725285809821465d, y: 0.30982200484849676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339997851760974d, y: 0.09963767524058986d), new NpgsqlTypes.NpgsqlPoint(x: 0.7481145827856489d, y: 0.9117890323830493d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25632240170638887d, y: 0.6068566411396628d), new NpgsqlTypes.NpgsqlPoint(x: 0.47655551997162937d, y: 0.051463292456707777d), new NpgsqlTypes.NpgsqlPoint(x: 0.7661712481754187d, y: 0.10171699494025987d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008585508142682219d, y: 0.3544328787946984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5435631690752214d, y: 0.8198700885222076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747558623109242d, y: 0.9075766698570493d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6693894780297786d, y: 0.7422690475915152d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339944995254073d, y: 0.46252241754910406d), new NpgsqlTypes.NpgsqlPoint(x: 0.4107060649510601d, y: 0.13346491004196548d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16289264914218127d, y: 0.7705676297249288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8063215979573207d, y: 0.9746779325798421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4401516252359572d, y: 0.6529449166068496d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5803540688775389d, y: 0.499725703581803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236595225023524d, y: 0.8736061217640209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391787750410835d, y: 0.6169105093811513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006897878745039221d, y: 0.5039785999850891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5902754849831352d, y: 0.6332076045876276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6308164888099691d, y: 0.3456765902087051d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7053703775375456d, y: 0.18130429133544845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412007510269792d, y: 0.6329225035552223d), new NpgsqlTypes.NpgsqlPoint(x: 0.08130925545598933d, y: 0.3741122121963163d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2264338972582406d, y: 0.6094929574544746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6213267264406583d, y: 0.6159569668561536d), new NpgsqlTypes.NpgsqlPoint(x: 0.6627631001816826d, y: 0.8777539129939503d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7930229082037186d, y: 0.5212606131461508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6437419913927461d, y: 0.17904893690730217d), new NpgsqlTypes.NpgsqlPoint(x: 0.47605667123311546d, y: 0.15132751423296442d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4812787557596563d, y: 0.09731924234627387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4226055591129009d, y: 0.5295691340178211d), new NpgsqlTypes.NpgsqlPoint(x: 0.08532679382494912d, y: 0.9700318888771978d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6596714852224006d, y: 0.7125719461905761d), new NpgsqlTypes.NpgsqlPoint(x: 0.37412022492926533d, y: 0.22372454040981737d), new NpgsqlTypes.NpgsqlPoint(x: 0.17447227579136915d, y: 0.11049187876868283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6039201790108908d, y: 0.7783324294155719d), new NpgsqlTypes.NpgsqlPoint(x: 0.9528630400085283d, y: 0.5697820077289351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413472229073454d, y: 0.0626457565110018d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7079043832270263d, y: 0.3017428928712663d), new NpgsqlTypes.NpgsqlPoint(x: 0.20259950695787554d, y: 0.7709267454562438d), new NpgsqlTypes.NpgsqlPoint(x: 0.47086556751936937d, y: 0.9348817877059293d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5452366035355801d, y: 0.21218255862095659d), new NpgsqlTypes.NpgsqlPoint(x: 0.3300407264243872d, y: 0.22769202297479485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4575739487966056d, y: 0.90475233615489d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2934177138390034d, y: 0.43102276616152146d), new NpgsqlTypes.NpgsqlPoint(x: 0.18629843599682971d, y: 0.7491618163154142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5998115210966869d, y: 0.5056379838158923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8009111611078515d, y: 0.7879504389173105d), new NpgsqlTypes.NpgsqlPoint(x: 0.2631517562944127d, y: 0.6369799326830888d), new NpgsqlTypes.NpgsqlPoint(x: 0.6190242918952374d, y: 0.6330260811928593d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.614124219961724d, y: 0.6732375912780699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752192511246365d, y: 0.7623006519729421d), new NpgsqlTypes.NpgsqlPoint(x: 0.4036123657882299d, y: 0.63666127061844d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7309124830242478d, y: 0.03344315178522439d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939501168724328d, y: 0.310795761530151d), new NpgsqlTypes.NpgsqlPoint(x: 0.12812719740295697d, y: 0.631763136862316d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6524138325281993d, y: 0.2569738963461853d), new NpgsqlTypes.NpgsqlPoint(x: 0.7582317801198674d, y: 0.921476878737931d), new NpgsqlTypes.NpgsqlPoint(x: 0.3514378264833359d, y: 0.7396619513372618d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7211430386474987d, y: 0.9916718800081007d), new NpgsqlTypes.NpgsqlPoint(x: 0.11761192918508678d, y: 0.9354154834191324d), new NpgsqlTypes.NpgsqlPoint(x: 0.5066427274119792d, y: 0.15228070913922054d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8868113622030903d, y: 0.32819211670138937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5602497105400014d, y: 0.8260934935105704d), new NpgsqlTypes.NpgsqlPoint(x: 0.20472332830642515d, y: 0.5089317741354551d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3079388599596218d, y: 0.7120958767958199d), new NpgsqlTypes.NpgsqlPoint(x: 0.0980146276815097d, y: 0.18809876111963275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623201005325231d, y: 0.7337209312182651d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7047982216664177d, y: 0.7462930369399546d), new NpgsqlTypes.NpgsqlPoint(x: 0.0637221078021738d, y: 0.41813693402589647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716473022527366d, y: 0.6499780241647608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6179678945215943d, y: 0.4205973481844152d), new NpgsqlTypes.NpgsqlPoint(x: 0.1400116327062676d, y: 0.2710224098176597d), new NpgsqlTypes.NpgsqlPoint(x: 0.30501978800779295d, y: 0.6938586479304113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296364675735513d, y: 0.40527606254113835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539055824176668d, y: 0.40041968048193144d), new NpgsqlTypes.NpgsqlPoint(x: 0.1530854433162837d, y: 0.68086768631178d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3780582653218949d, y: 0.20814350525440173d), new NpgsqlTypes.NpgsqlPoint(x: 0.22958035861136994d, y: 0.7012520077674282d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814964899040098d, y: 0.1765358103645377d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6353507053717088d, y: 0.7434768937553641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759351982991485d, y: 0.9899095349398117d), new NpgsqlTypes.NpgsqlPoint(x: 0.28581672768950306d, y: 0.7460715184409724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7031277403456594d, y: 0.056382014854991946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5234578741346398d, y: 0.31980998598832877d), new NpgsqlTypes.NpgsqlPoint(x: 0.3005571069326991d, y: 0.3804198507190151d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4669239128497962d, y: 0.23891799815030446d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036431691020639d, y: 0.2790281827116944d), new NpgsqlTypes.NpgsqlPoint(x: 0.13223213595270844d, y: 0.4208892120734228d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18504004011556152d, y: 0.19216572420864386d), new NpgsqlTypes.NpgsqlPoint(x: 0.681366480932368d, y: 0.8194261265510419d), new NpgsqlTypes.NpgsqlPoint(x: 0.087451311085055d, y: 0.9693267848482098d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20592837223342886d, y: 0.8073140897117679d), new NpgsqlTypes.NpgsqlPoint(x: 0.3888849923341261d, y: 0.7607724761782154d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619550602070958d, y: 0.8222528476363824d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7261528547892294d, y: 0.9471843251618982d), new NpgsqlTypes.NpgsqlPoint(x: 0.3833127078005928d, y: 0.6542419222426834d), new NpgsqlTypes.NpgsqlPoint(x: 0.07291120225144021d, y: 0.05206308511952229d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2495291648295207d, y: 0.7768460828570918d), new NpgsqlTypes.NpgsqlPoint(x: 0.9589804694723427d, y: 0.34004148977796367d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409758281904164d, y: 0.5081504314066554d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29790329577900965d, y: 0.062431275822136145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3919289855232875d, y: 0.6368084271237642d), new NpgsqlTypes.NpgsqlPoint(x: 0.789413270869868d, y: 0.2060781646761859d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8021183160438983d, y: 0.4080688530001033d), new NpgsqlTypes.NpgsqlPoint(x: 0.07484979171774953d, y: 0.7680643453585411d), new NpgsqlTypes.NpgsqlPoint(x: 0.18761858964701938d, y: 0.9778320914666632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5557619392608353d, y: 0.8145097619402613d), new NpgsqlTypes.NpgsqlPoint(x: 0.10037299859535687d, y: 0.16633161253746842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196153656371807d, y: 0.4801781235707243d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19519438854816762d, y: 0.6906397111417312d), new NpgsqlTypes.NpgsqlPoint(x: 0.6378007218587273d, y: 0.08545902688610973d), new NpgsqlTypes.NpgsqlPoint(x: 0.36506382725088815d, y: 0.11831889719813127d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35765483091329064d, y: 0.3764053784152036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352369454485244d, y: 0.9568394771969779d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180741758540471d, y: 0.6722473607491476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8880130008419377d, y: 0.9850243384987011d), new NpgsqlTypes.NpgsqlPoint(x: 0.792924866606739d, y: 0.07111570896281749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322239879891867d, y: 0.5292319895535988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23292188310350415d, y: 0.04539609458171223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298094350496528d, y: 0.809528930470182d), new NpgsqlTypes.NpgsqlPoint(x: 0.705577065981562d, y: 0.3476862240380777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29672092039111575d, y: 0.6000884792496269d), new NpgsqlTypes.NpgsqlPoint(x: 0.1835807004229021d, y: 0.4464157907978986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987176234743819d, y: 0.4175711329166164d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9899168298975306d, y: 0.6569837684640197d), new NpgsqlTypes.NpgsqlPoint(x: 0.13123738749540137d, y: 0.7972477835391664d), new NpgsqlTypes.NpgsqlPoint(x: 0.2385965156589901d, y: 0.2648094688370285d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4271662843363476d, y: 0.9906812174831151d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773654381414673d, y: 0.46016525160807464d), new NpgsqlTypes.NpgsqlPoint(x: 0.44297199281057975d, y: 0.8601109241548682d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8259567178487214d, y: 0.6927528375467269d), new NpgsqlTypes.NpgsqlPoint(x: 0.7992123205637909d, y: 0.34572298215011255d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980779771612974d, y: 0.9846741625660942d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7818530863297155d, y: 0.4994956712255234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890050011507749d, y: 0.15373539847821527d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005985819167497741d, y: 0.07340273775168538d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01710429985342865d, y: 0.6210626258066159d), new NpgsqlTypes.NpgsqlPoint(x: 0.4584274131828745d, y: 0.19537824381633073d), new NpgsqlTypes.NpgsqlPoint(x: 0.909451819538046d, y: 0.027453540583126657d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9991123910353592d, y: 0.04807763441857271d), new NpgsqlTypes.NpgsqlPoint(x: 0.3608714022836039d, y: 0.6993467484051696d), new NpgsqlTypes.NpgsqlPoint(x: 0.06352431044045881d, y: 0.3108290883847311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9160138549476848d, y: 0.6188603909486791d), new NpgsqlTypes.NpgsqlPoint(x: 0.27545662729606113d, y: 0.21995867121014323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8075493239015854d, y: 0.6967001401081941d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5227071434268128d, y: 0.2341300161242963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678317653891457d, y: 0.612387018988212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337171897255628d, y: 0.4785000136066706d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.823692125271219d, y: 0.30679936056783674d), new NpgsqlTypes.NpgsqlPoint(x: 0.463431842067508d, y: 0.471409461565347d), new NpgsqlTypes.NpgsqlPoint(x: 0.8727503094170377d, y: 0.8393885917994722d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.965434441644195d, y: 0.12361520859480823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565918986521865d, y: 0.9506162854710629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6595826573654129d, y: 0.8669607028610351d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06325789491768474d, y: 0.8549416395425536d), new NpgsqlTypes.NpgsqlPoint(x: 0.02298554499104022d, y: 0.1657944770197869d), new NpgsqlTypes.NpgsqlPoint(x: 0.4113651298722377d, y: 0.1624183196693857d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5596934085565282d, y: 0.202683014824952d), new NpgsqlTypes.NpgsqlPoint(x: 0.23092191692542519d, y: 0.31025914137065225d), new NpgsqlTypes.NpgsqlPoint(x: 0.520329173198191d, y: 0.0013814498195665603d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47438730955487807d, y: 0.7621274292547018d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856480147526092d, y: 0.8405815753151413d), new NpgsqlTypes.NpgsqlPoint(x: 0.18773264230554643d, y: 0.6907500429441933d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.136270590785179d, y: 0.7634969403958625d), new NpgsqlTypes.NpgsqlPoint(x: 0.49220843581942675d, y: 0.5573809644768636d), new NpgsqlTypes.NpgsqlPoint(x: 0.34102194496888616d, y: 0.4245467192098341d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21994989681162636d, y: 0.8435184098402966d), new NpgsqlTypes.NpgsqlPoint(x: 0.9353728874018804d, y: 0.12971753369323813d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217140644147285d, y: 0.13821598062773532d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8739944074245745d, y: 0.16540508140473886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7420599204106382d, y: 0.5687607278180898d), new NpgsqlTypes.NpgsqlPoint(x: 0.40260709357221613d, y: 0.42034446603018505d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7915828035140065d, y: 0.3423741614092467d), new NpgsqlTypes.NpgsqlPoint(x: 0.8887732798007101d, y: 0.5062760260959656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7221905186323783d, y: 0.9135727711666595d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9701306839626277d, y: 0.5647675580217049d), new NpgsqlTypes.NpgsqlPoint(x: 0.06976174524042278d, y: 0.14903441021050634d), new NpgsqlTypes.NpgsqlPoint(x: 0.3368995578021651d, y: 0.8169438383976662d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1597672973893235d, y: 0.7256060686716053d), new NpgsqlTypes.NpgsqlPoint(x: 0.19237540088380523d, y: 0.2100419141820845d), new NpgsqlTypes.NpgsqlPoint(x: 0.97879690636187d, y: 0.19995896145331604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9177488550844864d, y: 0.8976713972470768d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718852690557714d, y: 0.34225736521457417d), new NpgsqlTypes.NpgsqlPoint(x: 0.3693272911409411d, y: 0.2578982508901384d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033320132512677625d, y: 0.10839267114202733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7107329743718689d, y: 0.46640927796756115d), new NpgsqlTypes.NpgsqlPoint(x: 0.698839145909666d, y: 0.0760060012503988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34218002542684556d, y: 0.47090478243696343d), new NpgsqlTypes.NpgsqlPoint(x: 0.15896832224817836d, y: 0.6078657158030956d), new NpgsqlTypes.NpgsqlPoint(x: 0.5299774692675868d, y: 0.9916977379563604d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.153017459321227d, y: 0.43805231295935265d), new NpgsqlTypes.NpgsqlPoint(x: 0.09014001924843107d, y: 0.07963689071105806d), new NpgsqlTypes.NpgsqlPoint(x: 0.7876577116929872d, y: 0.9632824927331334d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18765624283459803d, y: 0.5384788560629825d), new NpgsqlTypes.NpgsqlPoint(x: 0.21376195936523124d, y: 0.0058217693218484134d), new NpgsqlTypes.NpgsqlPoint(x: 0.49305244033528095d, y: 0.6923191808312114d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6437946805924075d, y: 0.9265034739347038d), new NpgsqlTypes.NpgsqlPoint(x: 0.7024982206926967d, y: 0.6983242318132099d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413056804331214d, y: 0.3345020350457366d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7154802692858064d, y: 0.4488806613413213d), new NpgsqlTypes.NpgsqlPoint(x: 0.17051320423574567d, y: 0.14037479934173702d), new NpgsqlTypes.NpgsqlPoint(x: 0.23012727680014533d, y: 0.6521951404341549d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44457643154622917d, y: 0.8571760076309882d), new NpgsqlTypes.NpgsqlPoint(x: 0.28659959409304336d, y: 0.45331536079346735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3606144545099602d, y: 0.731991386883606d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7075480174223067d, y: 0.22930550677205075d), new NpgsqlTypes.NpgsqlPoint(x: 0.23674749099908277d, y: 0.3668079060814622d), new NpgsqlTypes.NpgsqlPoint(x: 0.695177083385057d, y: 0.8806359443254929d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7903230525494139d, y: 0.12483255563277296d), new NpgsqlTypes.NpgsqlPoint(x: 0.7303707882485583d, y: 0.7434547783387242d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673606201384049d, y: 0.5818496171021191d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3433433212674962d, y: 0.7264239864249679d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313944256134321d, y: 0.39808155600243467d), new NpgsqlTypes.NpgsqlPoint(x: 0.21043140205933952d, y: 0.3203389923276875d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9816806129738882d, y: 0.4805134671512742d), new NpgsqlTypes.NpgsqlPoint(x: 0.08297442868253369d, y: 0.9921227868067828d), new NpgsqlTypes.NpgsqlPoint(x: 0.8896350482109188d, y: 0.27137688764190204d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42605151499193095d, y: 0.38946452032482337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581454470628241d, y: 0.10475861354423333d), new NpgsqlTypes.NpgsqlPoint(x: 0.40066421589290835d, y: 0.6883599762044306d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6812602672664669d, y: 0.9938643298235205d), new NpgsqlTypes.NpgsqlPoint(x: 0.41193412251573847d, y: 0.2907790268594108d), new NpgsqlTypes.NpgsqlPoint(x: 0.9569737550899825d, y: 0.27925813253217435d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9128227301650259d, y: 0.3890496046214085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8656231430348387d, y: 0.945982030783745d), new NpgsqlTypes.NpgsqlPoint(x: 0.08006502941499505d, y: 0.521188445403674d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5147773263359869d, y: 0.742410120742628d), new NpgsqlTypes.NpgsqlPoint(x: 0.8094949205418287d, y: 0.3204136612651107d), new NpgsqlTypes.NpgsqlPoint(x: 0.48715998202950395d, y: 0.48254286037849414d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7934730196226488d, y: 0.8769384461938957d), new NpgsqlTypes.NpgsqlPoint(x: 0.4621580848891146d, y: 0.3688473843697543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590135493300659d, y: 0.02100996361844465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27153385470002034d, y: 0.3430572073796021d), new NpgsqlTypes.NpgsqlPoint(x: 0.10009693547287823d, y: 0.5887709769812766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116711106335285d, y: 0.9690200795712144d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991324003335346d, y: 0.11813975794994114d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354744770663139d, y: 0.9939862912736253d), new NpgsqlTypes.NpgsqlPoint(x: 0.677599139506812d, y: 0.39636610377216375d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7427406443203058d, y: 0.27138132235987733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587082292091915d, y: 0.5939276369209694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584494279637141d, y: 0.28980636276531124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11012376921861355d, y: 0.3294165546514102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9463434403855265d, y: 0.2551751097750615d), new NpgsqlTypes.NpgsqlPoint(x: 0.40089870908047165d, y: 0.6349514600108696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16564317414259822d, y: 0.5035392406667679d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735082674207062d, y: 0.30215116399384545d), new NpgsqlTypes.NpgsqlPoint(x: 0.31090330657048304d, y: 0.35627312144966583d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9342597391485715d, y: 0.934405728454543d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009232298610009071d, y: 0.26007241036951956d), new NpgsqlTypes.NpgsqlPoint(x: 0.3408391790653513d, y: 0.24028807773479488d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30823693676642694d, y: 0.8336863962046607d), new NpgsqlTypes.NpgsqlPoint(x: 0.048775670127016446d, y: 0.7585598750926332d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930357934312897d, y: 0.10921560511407324d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.602487524772199d, y: 0.5386338896486007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9894986364454215d, y: 0.12535920329009864d), new NpgsqlTypes.NpgsqlPoint(x: 0.19590111314269787d, y: 0.4666984326609772d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9544137690341665d, y: 0.8786323835319191d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982060075357063d, y: 0.7221176686833936d), new NpgsqlTypes.NpgsqlPoint(x: 0.7830567874933703d, y: 0.7537666069517033d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5858136134392692d, y: 0.09499967681011401d), new NpgsqlTypes.NpgsqlPoint(x: 0.02747656578545954d, y: 0.01104893714469457d), new NpgsqlTypes.NpgsqlPoint(x: 0.5590507752065733d, y: 0.7690288033182d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6687281304620915d, y: 0.202849730408313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6210924218481301d, y: 0.8832449791022502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7183425776299075d, y: 0.36073208545300295d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.77331117290853d, y: 0.9524014276280832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4864732960154412d, y: 0.6286290283154333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7604258071618852d, y: 0.057933110871470794d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2962403281164119d, y: 0.7937847418778343d), new NpgsqlTypes.NpgsqlPoint(x: 0.04773626168931977d, y: 0.7243840810851477d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524648144401415d, y: 0.04167574223357573d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8191423327114014d, y: 0.26176615011680104d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742189868471097d, y: 0.907832478529208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6929291594784378d, y: 0.34863374032130223d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8820640488744622d, y: 0.42204219409947086d), new NpgsqlTypes.NpgsqlPoint(x: 0.08065525592066702d, y: 0.31905503104087807d), new NpgsqlTypes.NpgsqlPoint(x: 0.15515169166793807d, y: 0.026531723560567877d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8435824777159107d, y: 0.06164598714128422d), new NpgsqlTypes.NpgsqlPoint(x: 0.6156906465627395d, y: 0.8635784627994898d), new NpgsqlTypes.NpgsqlPoint(x: 0.573250727492475d, y: 0.9370580660876522d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 94,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7306310541535763d, y: 0.5331865264790449d), new NpgsqlTypes.NpgsqlPoint(x: 0.46689230613711163d, y: 0.8712504117961879d), new NpgsqlTypes.NpgsqlPoint(x: 0.2714266000735679d, y: 0.8915009144511256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7197120073906382d, y: 0.38683529230540736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9205355859770831d, y: 0.5446469658083829d), new NpgsqlTypes.NpgsqlPoint(x: 0.19527431400778406d, y: 0.6588574584345706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2658853801298191d, y: 0.8569154273729899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673642069839638d, y: 0.4168498371738889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497887141971497d, y: 0.07642118736137538d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 39,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8659672658018696d, y: 0.6558139148693893d), new NpgsqlTypes.NpgsqlPoint(x: 0.0005642825800776796d, y: 0.474537557744688d), new NpgsqlTypes.NpgsqlPoint(x: 0.7845425102475313d, y: 0.42554921115424604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4632409986304147d, y: 0.6325447778798977d), new NpgsqlTypes.NpgsqlPoint(x: 0.9273398600815531d, y: 0.9677881863723137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3471316034234071d, y: 0.18789247935017805d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3408636438859136d, y: 0.7819319455071203d), new NpgsqlTypes.NpgsqlPoint(x: 0.559713731363661d, y: 0.24109822562845074d), new NpgsqlTypes.NpgsqlPoint(x: 0.9568291795576617d, y: 0.4934765862055621d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7006617901971721d, y: 0.7361561580940127d), new NpgsqlTypes.NpgsqlPoint(x: 0.20309440504281429d, y: 0.5662905319056545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8098168600936004d, y: 0.8658623888159251d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 97,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46563059824091413d, y: 0.9785155904154333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5279881624820237d, y: 0.6579308407062716d), new NpgsqlTypes.NpgsqlPoint(x: 0.45251426994984567d, y: 0.412069785438683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8144421139663512d, y: 0.14245992057256884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9920736956281222d, y: 0.5648223537918958d), new NpgsqlTypes.NpgsqlPoint(x: 0.3266536542986619d, y: 0.6569950281801865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7991233064018574d, y: 0.8050098553317254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5058434639430132d, y: 0.44899685723971494d), new NpgsqlTypes.NpgsqlPoint(x: 0.88621338463153d, y: 0.9412161299393478d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22015215605435734d, y: 0.49478893253253786d), new NpgsqlTypes.NpgsqlPoint(x: 0.412002405654187d, y: 0.6928330787967605d), new NpgsqlTypes.NpgsqlPoint(x: 0.31171649538297486d, y: 0.9223273063486929d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.015975628656468177d, y: 0.5158482797623534d), new NpgsqlTypes.NpgsqlPoint(x: 0.12826189529909593d, y: 0.8441464188432064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5948490713757291d, y: 0.8886038903619656d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2676488618499915d, y: 0.7667315743157131d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955239276866695d, y: 0.38637281742355845d), new NpgsqlTypes.NpgsqlPoint(x: 0.856173577433396d, y: 0.9625380240369552d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8346829480684244d, y: 0.6244215451734533d), new NpgsqlTypes.NpgsqlPoint(x: 0.04729559551606721d, y: 0.953342241967417d), new NpgsqlTypes.NpgsqlPoint(x: 0.938732187855845d, y: 0.3469312627093547d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9289784300640613d, y: 0.9306592560324451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569322863519859d, y: 0.04013400504842135d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006888282755018d, y: 0.9332158152635286d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.019083073683914487d, y: 0.34773380723881364d), new NpgsqlTypes.NpgsqlPoint(x: 0.909307191228166d, y: 0.48224488089650275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5444610877666488d, y: 0.4607010071127121d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9513225146426919d, y: 0.11390452924516559d), new NpgsqlTypes.NpgsqlPoint(x: 0.722951761022077d, y: 0.9399861174859273d), new NpgsqlTypes.NpgsqlPoint(x: 0.49393970620611527d, y: 0.3663082476310343d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9293634874726553d, y: 0.001858181724904373d), new NpgsqlTypes.NpgsqlPoint(x: 0.07236906144917743d, y: 0.18463346253409374d), new NpgsqlTypes.NpgsqlPoint(x: 0.010489193585985657d, y: 0.9690660568916143d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48481801062833796d, y: 0.059914352823767225d), new NpgsqlTypes.NpgsqlPoint(x: 0.7948425081142216d, y: 0.7526209772562634d), new NpgsqlTypes.NpgsqlPoint(x: 0.1441077466264532d, y: 0.09409804400691302d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09059065721436887d, y: 0.3884816871068838d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083479843974322d, y: 0.09625169211785067d), new NpgsqlTypes.NpgsqlPoint(x: 0.32665733809678743d, y: 0.7504873218034124d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3437600635452799d, y: 0.5512994790742259d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583906473756285d, y: 0.6726051639788995d), new NpgsqlTypes.NpgsqlPoint(x: 0.17446438149405719d, y: 0.842229508783252d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7118474252549084d, y: 0.314788448981695d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134443735359551d, y: 0.3867363373135382d), new NpgsqlTypes.NpgsqlPoint(x: 0.11564677375210375d, y: 0.9097987659195405d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8137368242730458d, y: 0.45868769206327664d), new NpgsqlTypes.NpgsqlPoint(x: 0.30152954682401867d, y: 0.4993744906161789d), new NpgsqlTypes.NpgsqlPoint(x: 0.650200201214554d, y: 0.21967625065091834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8829565787220128d, y: 0.24784614683808615d), new NpgsqlTypes.NpgsqlPoint(x: 0.4723395582918536d, y: 0.7366398001200198d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887886309163439d, y: 0.6602432664094809d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07320573476166559d, y: 0.5506522530987704d), new NpgsqlTypes.NpgsqlPoint(x: 0.3923609168152361d, y: 0.2781466284422548d), new NpgsqlTypes.NpgsqlPoint(x: 0.10922471582798465d, y: 0.22820540359761898d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12141793162165193d, y: 0.649103465996167d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422799736155594d, y: 0.5673051475353394d), new NpgsqlTypes.NpgsqlPoint(x: 0.03353782002828731d, y: 0.7565553156089169d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 104,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8486698724471804d, y: 0.5316526532815296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5425246098665004d, y: 0.7537208301112844d), new NpgsqlTypes.NpgsqlPoint(x: 0.009501475680198879d, y: 0.607133094414632d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7551659229888987d, y: 0.9813012922883645d), new NpgsqlTypes.NpgsqlPoint(x: 0.48561693384115867d, y: 0.5244924761855237d), new NpgsqlTypes.NpgsqlPoint(x: 0.41203531478369115d, y: 0.3913172335969568d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28720758177664485d, y: 0.45742629309701377d), new NpgsqlTypes.NpgsqlPoint(x: 0.5725982192096521d, y: 0.5180335486585164d), new NpgsqlTypes.NpgsqlPoint(x: 0.7006705744345675d, y: 0.6110490371215022d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6844373273323082d, y: 0.5657288369969278d), new NpgsqlTypes.NpgsqlPoint(x: 0.64503343999179d, y: 0.022041411851430492d), new NpgsqlTypes.NpgsqlPoint(x: 0.13061849488647748d, y: 0.6197706172026197d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6882340532831631d, y: 0.03436867356353923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6431001136271536d, y: 0.9381935755160594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049222123738676d, y: 0.1909709627151669d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5547284715051859d, y: 0.5877123480448545d), new NpgsqlTypes.NpgsqlPoint(x: 0.9746232670494139d, y: 0.31372692490169796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9143990776834852d, y: 0.14904044610720113d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3953713703167723d, y: 0.034674037657686174d), new NpgsqlTypes.NpgsqlPoint(x: 0.21259346334598173d, y: 0.5096876323170904d), new NpgsqlTypes.NpgsqlPoint(x: 0.34990678476427084d, y: 0.39466385456329567d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2574095727322062d, y: 0.9308025232775918d), new NpgsqlTypes.NpgsqlPoint(x: 0.14901792659719604d, y: 0.10429764082782d), new NpgsqlTypes.NpgsqlPoint(x: 0.44447466501740107d, y: 0.08856005703501157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5038929568816293d, y: 0.49653192832591575d), new NpgsqlTypes.NpgsqlPoint(x: 0.08192346965245878d, y: 0.9564260687836693d), new NpgsqlTypes.NpgsqlPoint(x: 0.1370525028299271d, y: 0.2162118125226613d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4291693218646685d, y: 0.22859069016223266d), new NpgsqlTypes.NpgsqlPoint(x: 0.7731800423163767d, y: 0.4356671048227405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342469382289542d, y: 0.4232304310587265d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06961761508722708d, y: 0.20367355542961474d), new NpgsqlTypes.NpgsqlPoint(x: 0.6128009629815444d, y: 0.89687898702093d), new NpgsqlTypes.NpgsqlPoint(x: 0.5069629030209107d, y: 0.41758810822381953d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6114596541447916d, y: 0.5083888145732313d), new NpgsqlTypes.NpgsqlPoint(x: 0.48147992180540045d, y: 0.2752078993443674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6273790798100931d, y: 0.9255561570628278d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9134448234326594d, y: 0.5925456715629269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9189850301871598d, y: 0.7943885185834133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6849599539725868d, y: 0.2582321456513105d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 113,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32418832843254575d, y: 0.29522691555204883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5108742351183572d, y: 0.07273795569870944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5651201656159139d, y: 0.92524016676827d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.624966223230829d, y: 0.2667227706740468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8224251676998602d, y: 0.5226887997674138d), new NpgsqlTypes.NpgsqlPoint(x: 0.47253224680682326d, y: 0.8413528982393692d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08712424016820375d, y: 0.7679117513260216d), new NpgsqlTypes.NpgsqlPoint(x: 0.2770977890645612d, y: 0.7730421307739592d), new NpgsqlTypes.NpgsqlPoint(x: 0.449955186444676d, y: 0.6110023597370885d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7157639010742463d, y: 0.3374801249742071d), new NpgsqlTypes.NpgsqlPoint(x: 0.49630713143652616d, y: 0.43489409912737753d), new NpgsqlTypes.NpgsqlPoint(x: 0.10137447780333475d, y: 0.656950212851656d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45001963903382936d, y: 0.4249571075465536d), new NpgsqlTypes.NpgsqlPoint(x: 0.2250244045506391d, y: 0.3783485447961116d), new NpgsqlTypes.NpgsqlPoint(x: 0.42558548718936595d, y: 0.5328362248583102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.40681918003051465d, y: 0.17474948319403927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764921222393048d, y: 0.3403127312713584d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712024975257422d, y: 0.836819322492765d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8934759723642479d, y: 0.13732458164471684d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280975941957077d, y: 0.9413452493911009d), new NpgsqlTypes.NpgsqlPoint(x: 0.994862084204983d, y: 0.8585675709367546d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3840915418652112d, y: 0.9506923474620373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4486015571418501d, y: 0.5217721158065849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8131465875577172d, y: 0.5471813487972182d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5536773201682285d, y: 0.5806423707799194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5618968663068411d, y: 0.5835729513114669d), new NpgsqlTypes.NpgsqlPoint(x: 0.22988914681039574d, y: 0.35568090194577306d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20291745199694067d, y: 0.11717281994499729d), new NpgsqlTypes.NpgsqlPoint(x: 0.22569312413773257d, y: 0.5668866289124528d), new NpgsqlTypes.NpgsqlPoint(x: 0.43060575779525767d, y: 0.19993055149108163d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.70349220358354d, y: 0.517590772938294d), new NpgsqlTypes.NpgsqlPoint(x: 0.35578862916454657d, y: 0.8955914681871411d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603534315916796d, y: 0.17797162549771461d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.022865576946028754d, y: 0.14906486648088102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9968785207313725d, y: 0.8650837545294129d), new NpgsqlTypes.NpgsqlPoint(x: 0.49493101719017885d, y: 0.19275008748086353d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3336984868638986d, y: 0.09494186483352507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9329205952243033d, y: 0.8009603266755533d), new NpgsqlTypes.NpgsqlPoint(x: 0.459529115506624d, y: 0.6558164953480705d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37555724829416703d, y: 0.7077127088658904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6064722498267957d, y: 0.21865212828368474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4174194011049138d, y: 0.18188391540916427d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.597889023149294d, y: 0.19821592100662244d), new NpgsqlTypes.NpgsqlPoint(x: 0.08071866379291381d, y: 0.44174466803851453d), new NpgsqlTypes.NpgsqlPoint(x: 0.11918142656864616d, y: 0.16226106639428672d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7596533894190842d, y: 0.9295277673526386d), new NpgsqlTypes.NpgsqlPoint(x: 0.1869107263118367d, y: 0.6253313632887041d), new NpgsqlTypes.NpgsqlPoint(x: 0.4740958301082653d, y: 0.22065181828476732d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9592532500444021d, y: 0.1143161867431044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852586940880961d, y: 0.23103844590407485d), new NpgsqlTypes.NpgsqlPoint(x: 0.16640892455657352d, y: 0.009252326388774823d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5942133954264686d, y: 0.9439374258680205d), new NpgsqlTypes.NpgsqlPoint(x: 0.2370397243959408d, y: 0.15257605585819933d), new NpgsqlTypes.NpgsqlPoint(x: 0.18457273185088663d, y: 0.7539063935798916d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3632861772497532d, y: 0.11922764226082072d), new NpgsqlTypes.NpgsqlPoint(x: 0.4510315136730927d, y: 0.721650963988621d), new NpgsqlTypes.NpgsqlPoint(x: 0.3407000777513087d, y: 0.9122206266518046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35916421018220845d, y: 0.4545216376517671d), new NpgsqlTypes.NpgsqlPoint(x: 0.4095793108997654d, y: 0.40932807956859496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807288333931615d, y: 0.2924700460364491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18053133093362062d, y: 0.2571766409267927d), new NpgsqlTypes.NpgsqlPoint(x: 0.9054123370045167d, y: 0.3272021387720475d), new NpgsqlTypes.NpgsqlPoint(x: 0.10823823432379476d, y: 0.8267793709299907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5205757084641975d, y: 0.16216198947480276d), new NpgsqlTypes.NpgsqlPoint(x: 0.3593384747033397d, y: 0.18487000620888538d), new NpgsqlTypes.NpgsqlPoint(x: 0.3202550005960033d, y: 0.06695455201082734d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 133,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6089841367591216d, y: 0.44413581164213733d), new NpgsqlTypes.NpgsqlPoint(x: 0.27815971152378405d, y: 0.707140472550992d), new NpgsqlTypes.NpgsqlPoint(x: 0.8915579973660838d, y: 0.45230262609048366d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5877245432273006d, y: 0.2808651060673607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9955163003868631d, y: 0.8770433959241695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7648847423038889d, y: 0.20331781121001147d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7649726863793425d, y: 0.2766682850838923d), new NpgsqlTypes.NpgsqlPoint(x: 0.2540678566922965d, y: 0.3099994962187973d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290569784988858d, y: 0.6224107824810812d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3198549467287467d, y: 0.7505487418522034d), new NpgsqlTypes.NpgsqlPoint(x: 0.2890297678736712d, y: 0.5205827487976827d), new NpgsqlTypes.NpgsqlPoint(x: 0.422313240525925d, y: 0.7861507963431937d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5689408731431421d, y: 0.14517352513538873d), new NpgsqlTypes.NpgsqlPoint(x: 0.30285197825404053d, y: 0.27461656744316043d), new NpgsqlTypes.NpgsqlPoint(x: 0.1988820166659262d, y: 0.982135856345311d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5301370521316507d, y: 0.7409070941071219d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847789495853608d, y: 0.49041911498012625d), new NpgsqlTypes.NpgsqlPoint(x: 0.3750708059778388d, y: 0.8573236586732981d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5048110105491741d, y: 0.8767068247670545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5290047534815001d, y: 0.36425103947572945d), new NpgsqlTypes.NpgsqlPoint(x: 0.675366417446519d, y: 0.543485054840556d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17910701112386607d, y: 0.6794533617135787d), new NpgsqlTypes.NpgsqlPoint(x: 0.6517641330167716d, y: 0.3584319341288328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7467948707205926d, y: 0.36466701328655604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6572360986271168d, y: 0.7023222677819613d), new NpgsqlTypes.NpgsqlPoint(x: 0.43714503524607606d, y: 0.7337207512300229d), new NpgsqlTypes.NpgsqlPoint(x: 0.9028734029318723d, y: 0.8725361695079135d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7253467339795273d, y: 0.7198573659521509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9468942198624523d, y: 0.5055728306066899d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107772648568279d, y: 0.7017113757360028d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7002440141875915d, y: 0.540094971205032d), new NpgsqlTypes.NpgsqlPoint(x: 0.3922109315309703d, y: 0.5599671267085558d), new NpgsqlTypes.NpgsqlPoint(x: 0.7932413725594201d, y: 0.16567479653590622d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6751665093559965d, y: 0.09978747400890964d), new NpgsqlTypes.NpgsqlPoint(x: 0.7901205712797541d, y: 0.39151800007657245d), new NpgsqlTypes.NpgsqlPoint(x: 0.31692196472338374d, y: 0.374922501703046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5455931789789978d, y: 0.6555840977926497d), new NpgsqlTypes.NpgsqlPoint(x: 0.5875924830123459d, y: 0.0011778693089720127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137919188973604d, y: 0.3193903307230491d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.550618082049419d, y: 0.5801315596704246d), new NpgsqlTypes.NpgsqlPoint(x: 0.1535368520400089d, y: 0.7675094217485645d), new NpgsqlTypes.NpgsqlPoint(x: 0.39992719161980983d, y: 0.7252336023113972d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9253949553272596d, y: 0.8654961513556879d), new NpgsqlTypes.NpgsqlPoint(x: 0.7644982903071228d, y: 0.9027631227206699d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550424601978824d, y: 0.35708592722730637d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46748900639709523d, y: 0.7265783573553939d), new NpgsqlTypes.NpgsqlPoint(x: 0.05361950767830603d, y: 0.569245741578287d), new NpgsqlTypes.NpgsqlPoint(x: 0.34227293129838343d, y: 0.5667926436135569d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.811586581257706d, y: 0.5411096498549951d), new NpgsqlTypes.NpgsqlPoint(x: 0.13137339798882453d, y: 0.14919559826500495d), new NpgsqlTypes.NpgsqlPoint(x: 0.29781507356656833d, y: 0.44583751443901665d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9106653578321418d, y: 0.2567743088675367d), new NpgsqlTypes.NpgsqlPoint(x: 0.11827899235870976d, y: 0.3293781949330956d), new NpgsqlTypes.NpgsqlPoint(x: 0.8010194839216452d, y: 0.8367467287421854d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8491115402116535d, y: 0.9268502060355263d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975818578730883d, y: 0.007668368075753995d), new NpgsqlTypes.NpgsqlPoint(x: 0.3514701110578775d, y: 0.46330892412098423d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9512410980147579d, y: 0.7948866971296915d), new NpgsqlTypes.NpgsqlPoint(x: 0.6321361145532045d, y: 0.35363990079579033d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974283691231845d, y: 0.2118310319080029d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7883082310343099d, y: 0.7956010147602917d), new NpgsqlTypes.NpgsqlPoint(x: 0.05628302925760165d, y: 0.33061404900731595d), new NpgsqlTypes.NpgsqlPoint(x: 0.25398212659498354d, y: 0.9717425915477917d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 142,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6501486794453217d, y: 0.6534554594505572d), new NpgsqlTypes.NpgsqlPoint(x: 0.5816032020433975d, y: 0.8248521482636939d), new NpgsqlTypes.NpgsqlPoint(x: 0.08327112405211734d, y: 0.14981089451873542d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3750781701690401d, y: 0.7634556614848019d), new NpgsqlTypes.NpgsqlPoint(x: 0.1919724110907065d, y: 0.22848214759198748d), new NpgsqlTypes.NpgsqlPoint(x: 0.9179896416337208d, y: 0.3729885871639931d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8987508294326281d, y: 0.5039502207550269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853271484264472d, y: 0.5254643155324119d), new NpgsqlTypes.NpgsqlPoint(x: 0.4831557692852917d, y: 0.8163983688011504d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.592299137622014d, y: 0.22463355181238387d), new NpgsqlTypes.NpgsqlPoint(x: 0.22497555931242907d, y: 0.7010129405379906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9506455182197406d, y: 0.6772492357613844d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9904856299282955d, y: 0.6400043376104723d), new NpgsqlTypes.NpgsqlPoint(x: 0.6775618901875743d, y: 0.266001965033694d), new NpgsqlTypes.NpgsqlPoint(x: 0.49159717113877144d, y: 0.7045378832415117d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8391861590360644d, y: 0.030343420010985334d), new NpgsqlTypes.NpgsqlPoint(x: 0.12895670280421923d, y: 0.4137619779646885d), new NpgsqlTypes.NpgsqlPoint(x: 0.47889348850815117d, y: 0.5858374366679744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9813691079988425d, y: 0.7486648366866139d), new NpgsqlTypes.NpgsqlPoint(x: 0.6559998873207206d, y: 0.13846116325085267d), new NpgsqlTypes.NpgsqlPoint(x: 0.31336653968176653d, y: 0.6664130348599565d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29886449748392385d, y: 0.7075191791422102d), new NpgsqlTypes.NpgsqlPoint(x: 0.3066624807438747d, y: 0.14024175392718008d), new NpgsqlTypes.NpgsqlPoint(x: 0.6462632878449662d, y: 0.3415965491241715d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9227518101358959d, y: 0.5394354746831427d), new NpgsqlTypes.NpgsqlPoint(x: 0.3173828086891769d, y: 0.5791558201876749d), new NpgsqlTypes.NpgsqlPoint(x: 0.15018029011331258d, y: 0.36005749294229217d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7847960632393928d, y: 0.3951887867516849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326963810008696d, y: 0.03662902452713024d), new NpgsqlTypes.NpgsqlPoint(x: 0.7893319668737493d, y: 0.929759055265039d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9716025140072079d, y: 0.7152300890577797d), new NpgsqlTypes.NpgsqlPoint(x: 0.06333681624397758d, y: 0.8280721669727741d), new NpgsqlTypes.NpgsqlPoint(x: 0.011412406653116158d, y: 0.7273456055407079d)),
},
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
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

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathArraypathArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathArraypathArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathArraypathArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathArraypathArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6136741562863502d, y: 0.9703073804225703d), new NpgsqlTypes.NpgsqlPoint(x: 0.3800841312834309d, y: 0.7574817524414797d), new NpgsqlTypes.NpgsqlPoint(x: 0.7810220729696404d, y: 0.9448645578966337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6808612552037732d, y: 0.9401369534630861d), new NpgsqlTypes.NpgsqlPoint(x: 0.3638606711541953d, y: 0.6834058765667247d), new NpgsqlTypes.NpgsqlPoint(x: 0.7247810156903265d, y: 0.7524652295225083d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7356528891794915d, y: 0.917360302244559d), new NpgsqlTypes.NpgsqlPoint(x: 0.0025596023002592005d, y: 0.9354128216123456d), new NpgsqlTypes.NpgsqlPoint(x: 0.47730285869082023d, y: 0.30210062194973564d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturning(connection, parameters);
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26876803767995994d, y: 0.2561679688833658d), new NpgsqlTypes.NpgsqlPoint(x: 0.40594334206378757d, y: 0.269761692293234d), new NpgsqlTypes.NpgsqlPoint(x: 0.3829543191421282d, y: 0.5792386590235049d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5168380452201925d, y: 0.32435222322685664d), new NpgsqlTypes.NpgsqlPoint(x: 0.30073376214475955d, y: 0.050130502012617706d), new NpgsqlTypes.NpgsqlPoint(x: 0.9835503119949895d, y: 0.26556989175045387d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.873788419115516d, y: 0.07188830298640614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564674442689975d, y: 0.3222910990128177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513401461081569d, y: 0.36382123572917435d)),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483634);
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

                    nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5803540688775389d, y: 0.499725703581803d), new NpgsqlTypes.NpgsqlPoint(x: 0.9236595225023524d, y: 0.8736061217640209d), new NpgsqlTypes.NpgsqlPoint(x: 0.9391787750410835d, y: 0.6169105093811513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006897878745039221d, y: 0.5039785999850891d), new NpgsqlTypes.NpgsqlPoint(x: 0.5902754849831352d, y: 0.6332076045876276d), new NpgsqlTypes.NpgsqlPoint(x: 0.6308164888099691d, y: 0.3456765902087051d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7053703775375456d, y: 0.18130429133544845d), new NpgsqlTypes.NpgsqlPoint(x: 0.3412007510269792d, y: 0.6329225035552223d), new NpgsqlTypes.NpgsqlPoint(x: 0.08130925545598933d, y: 0.3741122121963163d)),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpatharray1m(
	id,
    value,
    nullablevalue,
    npgsqlpathpatharray1mi_id
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
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpatharray1mi_id", 
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
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath[] nullable = null;
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3079388599596218d, y: 0.7120958767958199d), new NpgsqlTypes.NpgsqlPoint(x: 0.0980146276815097d, y: 0.18809876111963275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8623201005325231d, y: 0.7337209312182651d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7047982216664177d, y: 0.7462930369399546d), new NpgsqlTypes.NpgsqlPoint(x: 0.0637221078021738d, y: 0.41813693402589647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8716473022527366d, y: 0.6499780241647608d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6179678945215943d, y: 0.4205973481844152d), new NpgsqlTypes.NpgsqlPoint(x: 0.1400116327062676d, y: 0.2710224098176597d), new NpgsqlTypes.NpgsqlPoint(x: 0.30501978800779295d, y: 0.6938586479304113d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7296364675735513d, y: 0.40527606254113835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8539055824176668d, y: 0.40041968048193144d), new NpgsqlTypes.NpgsqlPoint(x: 0.1530854433162837d, y: 0.68086768631178d)),
}));
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35765483091329064d, y: 0.3764053784152036d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352369454485244d, y: 0.9568394771969779d), new NpgsqlTypes.NpgsqlPoint(x: 0.8180741758540471d, y: 0.6722473607491476d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8880130008419377d, y: 0.9850243384987011d), new NpgsqlTypes.NpgsqlPoint(x: 0.792924866606739d, y: 0.07111570896281749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322239879891867d, y: 0.5292319895535988d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23292188310350415d, y: 0.04539609458171223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298094350496528d, y: 0.809528930470182d), new NpgsqlTypes.NpgsqlPoint(x: 0.705577065981562d, y: 0.3476862240380777d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29672092039111575d, y: 0.6000884792496269d), new NpgsqlTypes.NpgsqlPoint(x: 0.1835807004229021d, y: 0.4464157907978986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9987176234743819d, y: 0.4175711329166164d)),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathArraypathArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathArray1M> models = null;

                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathArraypathArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathArraypathArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await ((INpgsqlPathArraypathArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathArraypathArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 133;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M), typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                await((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathArray1M>();
                var models2 = new List<FlatNpgsqlPathpathArray1M>();
                ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 3, query1, 54, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[28],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 104, query1, 64, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
LEFT JOIN public.npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatchAsync(connection, 104, 61))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[29], false);
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
                var models = ((INpgsqlPathArraypathArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSelectModelBatch(connection, 40, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 100);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
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
FROM public.binary_npgsqlpathpatharray1m m
LEFT JOIN public.binary_npgsqlpathpatharray1mi mi ON mi.id = m.npgsqlpathpatharray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpathArray1M>(15);

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
                ((INpgsqlPathArraypathArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathArraypathArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathArraypathArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpathArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpathArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpathArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpathArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpathArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpathArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpathArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpathArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpathArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpathArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpathArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpathArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpathArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpathArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpathArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpathArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpathArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpathArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpathArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpathArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpathArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpathArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpathArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpathArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpathArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpathArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpathArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpathArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpathArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpathArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpatharray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathArray1M)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MI)],
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
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

