

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
    Id = 1,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05061701347162406d, y: 0.1945124168249457d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320798964875855d, y: 0.4109014402044576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6679964198455155d, y: 0.30694336020390134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8067220814806484d, y: 0.6022972923084143d), new NpgsqlTypes.NpgsqlPoint(x: 0.49700269259968843d, y: 0.573889818810457d), new NpgsqlTypes.NpgsqlPoint(x: 0.059729548939833954d, y: 0.6306914511045254d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6983206942012303d, y: 0.8261404607972849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8812077128535877d, y: 0.5624751619902584d), new NpgsqlTypes.NpgsqlPoint(x: 0.5706970802909056d, y: 0.8228226960300822d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5043847513940412d, y: 0.8089400196759436d), new NpgsqlTypes.NpgsqlPoint(x: 0.2073841986082301d, y: 0.876417311346251d), new NpgsqlTypes.NpgsqlPoint(x: 0.887440668901387d, y: 0.9898553728297914d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5591460012864943d, y: 0.9602031805122755d), new NpgsqlTypes.NpgsqlPoint(x: 0.17387620241000235d, y: 0.22013066478942322d), new NpgsqlTypes.NpgsqlPoint(x: 0.04794302718123378d, y: 0.019715477128451897d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48143454986567913d, y: 0.8246645095623016d), new NpgsqlTypes.NpgsqlPoint(x: 0.41919169728159555d, y: 0.7947985488211458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5884944491930575d, y: 0.5000557929412971d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1355183789014881d, y: 0.020196537925193603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5627479546755906d, y: 0.6511779016960871d), new NpgsqlTypes.NpgsqlPoint(x: 0.35997942129815974d, y: 0.9662927155600477d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06262269550650501d, y: 0.1886044806018834d), new NpgsqlTypes.NpgsqlPoint(x: 0.4876553274602269d, y: 0.7117552237591337d), new NpgsqlTypes.NpgsqlPoint(x: 0.6736442193966602d, y: 0.784648519003667d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13384845915408905d, y: 0.6908172371116259d), new NpgsqlTypes.NpgsqlPoint(x: 0.7692638202340271d, y: 0.6069024169503648d), new NpgsqlTypes.NpgsqlPoint(x: 0.18635924398430348d, y: 0.7859361972266583d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6110567500270097d, y: 0.8465586841969555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788129452394998d, y: 0.9566157197432694d), new NpgsqlTypes.NpgsqlPoint(x: 0.7779121112840537d, y: 0.6437000775078258d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45122066943206796d, y: 0.5013133681375818d), new NpgsqlTypes.NpgsqlPoint(x: 0.2489647945862561d, y: 0.5778543582715386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6335397476963388d, y: 0.913203210446907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5257022337606269d, y: 0.8729214801963944d), new NpgsqlTypes.NpgsqlPoint(x: 0.9771030360245418d, y: 0.8558471835602366d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298065127911134d, y: 0.9398329478286731d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18075788780672164d, y: 0.6884205288985441d), new NpgsqlTypes.NpgsqlPoint(x: 0.964785459838677d, y: 0.8127851799106572d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881323498846364d, y: 0.5401728294637015d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18921989515069926d, y: 0.794962527695659d), new NpgsqlTypes.NpgsqlPoint(x: 0.08639633141703873d, y: 0.42509305402472464d), new NpgsqlTypes.NpgsqlPoint(x: 0.9270175052517016d, y: 0.8796548662986524d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4529160743925418d, y: 0.7523998397101627d), new NpgsqlTypes.NpgsqlPoint(x: 0.8703538487138394d, y: 0.6687582447625138d), new NpgsqlTypes.NpgsqlPoint(x: 0.0017657444716652204d, y: 0.10837413156922138d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9643776239716075d, y: 0.6411253969123492d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087230346741413d, y: 0.7167625404511523d), new NpgsqlTypes.NpgsqlPoint(x: 0.32770820399677525d, y: 0.5598898720252091d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6538585255108136d, y: 0.7246011757380102d), new NpgsqlTypes.NpgsqlPoint(x: 0.6134283989257722d, y: 0.8002164140062096d), new NpgsqlTypes.NpgsqlPoint(x: 0.010424225131149045d, y: 0.7459401942902455d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8803627757764165d, y: 0.4334303653335847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875037834941477d, y: 0.10155281281332673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5390937650844732d, y: 0.399130141332087d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8628421107883439d, y: 0.39679680873308854d), new NpgsqlTypes.NpgsqlPoint(x: 0.9349327418267002d, y: 0.12048199427783024d), new NpgsqlTypes.NpgsqlPoint(x: 0.20571317870755135d, y: 0.652736204408868d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3138919342742106d, y: 0.745196576662962d), new NpgsqlTypes.NpgsqlPoint(x: 0.25757162153570046d, y: 0.18560496102114588d), new NpgsqlTypes.NpgsqlPoint(x: 0.3099239589438061d, y: 0.2731661925196943d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.50218960055259d, y: 0.35865802321878726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6887185727475978d, y: 0.24287921751961272d), new NpgsqlTypes.NpgsqlPoint(x: 0.4317625813409208d, y: 0.559341059701074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8983216547823109d, y: 0.05210643020697292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9947102148900683d, y: 0.00772864425346953d), new NpgsqlTypes.NpgsqlPoint(x: 0.034466027594985404d, y: 0.24280829204486065d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4438142146872158d, y: 0.2271356052953436d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863093752689338d, y: 0.2409882352290299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7888333408789028d, y: 0.8143358030815068d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8931962331485482d, y: 0.6691116148214202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5372175152991672d, y: 0.9057991358536084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9781445082153866d, y: 0.05382768128839044d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14868636000927238d, y: 0.636706003127169d), new NpgsqlTypes.NpgsqlPoint(x: 0.3184055232653874d, y: 0.8598471515883197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9095850178113665d, y: 0.4836272216824907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8133474390509166d, y: 0.5039491640116383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7761132646181013d, y: 0.7885750647789159d), new NpgsqlTypes.NpgsqlPoint(x: 0.10579982834953017d, y: 0.2282339743542684d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7599552320517032d, y: 0.9607644027190625d), new NpgsqlTypes.NpgsqlPoint(x: 0.03825813205083606d, y: 0.01752829974204617d), new NpgsqlTypes.NpgsqlPoint(x: 0.1919286258933417d, y: 0.8157157800986611d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9542674441324459d, y: 0.8470097394308245d), new NpgsqlTypes.NpgsqlPoint(x: 0.724731978749507d, y: 0.9435251923699677d), new NpgsqlTypes.NpgsqlPoint(x: 0.11180256679104073d, y: 0.8581695258982277d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7009109317155594d, y: 0.2981468269945352d), new NpgsqlTypes.NpgsqlPoint(x: 0.8326977803342275d, y: 0.7522455060724251d), new NpgsqlTypes.NpgsqlPoint(x: 0.679113244036838d, y: 0.46448829199154684d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6624786821732281d, y: 0.1315802866103224d), new NpgsqlTypes.NpgsqlPoint(x: 0.42836930101737547d, y: 0.20790426612395596d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663273094948952d, y: 0.7631161268224685d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06602310076499096d, y: 0.9011696284704104d), new NpgsqlTypes.NpgsqlPoint(x: 0.01197418695405239d, y: 0.8378710045365015d), new NpgsqlTypes.NpgsqlPoint(x: 0.08122307458401867d, y: 0.13394804706212837d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30445038328615837d, y: 0.08535361510330308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4804546346005637d, y: 0.6952326764053128d), new NpgsqlTypes.NpgsqlPoint(x: 0.07189956067297731d, y: 0.7819798616400951d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9125824048295074d, y: 0.7674856970824508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917671021364958d, y: 0.8706996647228762d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296504145204902d, y: 0.028602141248314283d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26120153712980343d, y: 0.7867807499522361d), new NpgsqlTypes.NpgsqlPoint(x: 0.3295070096134157d, y: 0.9240560210102995d), new NpgsqlTypes.NpgsqlPoint(x: 0.9529542270730313d, y: 0.6499413263483186d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10343364962464396d, y: 0.5276003038188923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673806202002046d, y: 0.7847651451133255d), new NpgsqlTypes.NpgsqlPoint(x: 0.542393672575526d, y: 0.3966651216106333d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066609766541252d, y: 0.8474946724249319d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129669177033513d, y: 0.49579708001997425d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787163297013523d, y: 0.760705709546724d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29663596357641087d, y: 0.11513163743447896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423769052155333d, y: 0.542464231078264d), new NpgsqlTypes.NpgsqlPoint(x: 0.451506918803826d, y: 0.5703802799829327d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8658198815548729d, y: 0.609487556852431d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151342970576678d, y: 0.23668129378230196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5476398102046852d, y: 0.09995966442859039d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9478086012228041d, y: 0.33391462308217523d), new NpgsqlTypes.NpgsqlPoint(x: 0.05540603730406901d, y: 0.7630481582825651d), new NpgsqlTypes.NpgsqlPoint(x: 0.208147014117658d, y: 0.9413843808752835d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5008849246177363d, y: 0.34235469674779506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2374899343857766d, y: 0.60049322890588d), new NpgsqlTypes.NpgsqlPoint(x: 0.5987296016466379d, y: 0.04422516485258832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5603416438095288d, y: 0.5874633143457589d), new NpgsqlTypes.NpgsqlPoint(x: 0.6996192745166468d, y: 0.31871051813406104d), new NpgsqlTypes.NpgsqlPoint(x: 0.3705132722547285d, y: 0.6357491747996462d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 9,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17444671980289217d, y: 0.706956640799662d), new NpgsqlTypes.NpgsqlPoint(x: 0.4959666120906515d, y: 0.0902285924341929d), new NpgsqlTypes.NpgsqlPoint(x: 0.8390157808577583d, y: 0.12439717759763158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5558481005814894d, y: 0.2945602041862603d), new NpgsqlTypes.NpgsqlPoint(x: 0.9990402970020367d, y: 0.29272217287646884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4643950633148036d, y: 0.6989330028509362d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46126388355430015d, y: 0.23718704170473703d), new NpgsqlTypes.NpgsqlPoint(x: 0.05171619312335274d, y: 0.07553898684875826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7756212340254023d, y: 0.5454782086849282d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029712879327528d, y: 0.647539158635214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301018901929837d, y: 0.23338933744914492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229444072616432d, y: 0.32021234505687446d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17083290167852927d, y: 0.7380079582682697d), new NpgsqlTypes.NpgsqlPoint(x: 0.17250947619972712d, y: 0.13278357920521966d), new NpgsqlTypes.NpgsqlPoint(x: 0.23423981102511082d, y: 0.9155828995325677d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9417542516738129d, y: 0.708677066475891d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317689942168638d, y: 0.33566500069659844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6529109202173469d, y: 0.19119164174657233d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37593486102085316d, y: 0.8801351296014592d), new NpgsqlTypes.NpgsqlPoint(x: 0.9466675935839569d, y: 0.026327912530749287d), new NpgsqlTypes.NpgsqlPoint(x: 0.2266752371718691d, y: 0.12519316166437044d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36865235654856243d, y: 0.44701650374234503d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654557310426132d, y: 0.5063586105332574d), new NpgsqlTypes.NpgsqlPoint(x: 0.32378586012954114d, y: 0.4335684275222169d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6202440611028575d, y: 0.3667129146079111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122245755281337d, y: 0.22114662671918173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081492614267063d, y: 0.9154853638852154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.842485456572816d, y: 0.0013309478510629136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238276597524044d, y: 0.009757352523112939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784764039664825d, y: 0.7257534199039848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9316995428899931d, y: 0.5658490200612073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336802175359503d, y: 0.7433824605500396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7806965035161539d, y: 0.678261275122861d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6332746482929763d, y: 0.17841217906007878d), new NpgsqlTypes.NpgsqlPoint(x: 0.952710961464295d, y: 0.030043243151952503d), new NpgsqlTypes.NpgsqlPoint(x: 0.8118018375832964d, y: 0.5258679904589134d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6652338741976395d, y: 0.8954203890826868d), new NpgsqlTypes.NpgsqlPoint(x: 0.037030411878806735d, y: 0.8796692098621466d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726534877018064d, y: 0.9656650089718501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7461611200970776d, y: 0.3938635173759728d), new NpgsqlTypes.NpgsqlPoint(x: 0.3936650060167336d, y: 0.8145413351351091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9217565544432527d, y: 0.9462070983537985d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.038519834152300425d, y: 0.46801930544741754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9526604266880343d, y: 0.7794511362917143d), new NpgsqlTypes.NpgsqlPoint(x: 0.10953450937040432d, y: 0.8123499224187909d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22886826547702466d, y: 0.13504435066900922d), new NpgsqlTypes.NpgsqlPoint(x: 0.6651852765652918d, y: 0.012496073041356248d), new NpgsqlTypes.NpgsqlPoint(x: 0.6314220127584401d, y: 0.2696104248618918d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6291285611809243d, y: 0.03833438393638666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2371535437215876d, y: 0.6455448143828317d), new NpgsqlTypes.NpgsqlPoint(x: 0.23606213919043095d, y: 0.498941218323009d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7020939329905445d, y: 0.7339643686876416d), new NpgsqlTypes.NpgsqlPoint(x: 0.1184701331987934d, y: 0.0902236210572519d), new NpgsqlTypes.NpgsqlPoint(x: 0.57961945346637d, y: 0.7200071233857501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20085424752884995d, y: 0.9966985889619618d), new NpgsqlTypes.NpgsqlPoint(x: 0.15254219260974677d, y: 0.8328845847827125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565763136200115d, y: 0.4096990719347332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9058735542781742d, y: 0.6808192771079562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238763665102568d, y: 0.16530665996789629d), new NpgsqlTypes.NpgsqlPoint(x: 0.08731656005627286d, y: 0.7473702138901198d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 47,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5488052181208621d, y: 0.4220786696110489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7027557034964723d, y: 0.7837952301057192d), new NpgsqlTypes.NpgsqlPoint(x: 0.015908189402306427d, y: 0.6606400320169159d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2997519311909018d, y: 0.21856552128057027d), new NpgsqlTypes.NpgsqlPoint(x: 0.6058678705238182d, y: 0.5647401378072618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5233995109936072d, y: 0.8202455907135655d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22622126843155022d, y: 0.0007356695044740125d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624868096268495d, y: 0.6921275353630842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5512357487079161d, y: 0.1573091202816307d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18553716983099477d, y: 0.42014070743364573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965969370645177d, y: 0.4645508660233082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727219877548191d, y: 0.6300690592524946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35661218532462235d, y: 0.6332291890985099d), new NpgsqlTypes.NpgsqlPoint(x: 0.23578718708759872d, y: 0.42624741621924345d), new NpgsqlTypes.NpgsqlPoint(x: 0.10671572479651148d, y: 0.7410469411371683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8946218484097214d, y: 0.5280424145409329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636724783897341d, y: 0.24608718139506636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371296115179745d, y: 0.01095958346125614d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29407863506079956d, y: 0.33267342342490114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7429713581083672d, y: 0.5191885069831073d), new NpgsqlTypes.NpgsqlPoint(x: 0.16760178049851038d, y: 0.07118475470218488d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8553170350768359d, y: 0.7883348948065213d), new NpgsqlTypes.NpgsqlPoint(x: 0.18971893884779467d, y: 0.9937036117716842d), new NpgsqlTypes.NpgsqlPoint(x: 0.7410516531041367d, y: 0.41648170998236256d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2249116997763686d, y: 0.9334474640991792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9491405414258242d, y: 0.47659414031994196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7854823017974444d, y: 0.001990204762634451d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09160611657465112d, y: 0.7241656736841482d), new NpgsqlTypes.NpgsqlPoint(x: 0.2840019207053768d, y: 0.5398072084893628d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701137994371235d, y: 0.202865229916251d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2850013311939745d, y: 0.05822635901985318d), new NpgsqlTypes.NpgsqlPoint(x: 0.08736454292196205d, y: 0.67265278931914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8723185399277347d, y: 0.5079261472038026d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7590536549149319d, y: 0.9382797393192719d), new NpgsqlTypes.NpgsqlPoint(x: 0.882565818552173d, y: 0.06983448270563675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745508034099999d, y: 0.241407704980781d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6682126843665684d, y: 0.8693532684942289d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126194427032728d, y: 0.1522811809942557d), new NpgsqlTypes.NpgsqlPoint(x: 0.0684085343341927d, y: 0.09590670905208876d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11128149416729782d, y: 0.6293911803361477d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799540475476918d, y: 0.2954123271631991d), new NpgsqlTypes.NpgsqlPoint(x: 0.4635240853453745d, y: 0.9537565117970773d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6470221954473776d, y: 0.07534315473155295d), new NpgsqlTypes.NpgsqlPoint(x: 0.813384188865947d, y: 0.8896909496552841d), new NpgsqlTypes.NpgsqlPoint(x: 0.21086586403583918d, y: 0.7685002915725934d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32870978878995016d, y: 0.7756408445940605d), new NpgsqlTypes.NpgsqlPoint(x: 0.2790250170566042d, y: 0.9832604673535128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9086578416375621d, y: 0.820922475459428d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8492509099587535d, y: 0.06425935491027535d), new NpgsqlTypes.NpgsqlPoint(x: 0.695796693510404d, y: 0.4202088038185138d), new NpgsqlTypes.NpgsqlPoint(x: 0.7901046547670716d, y: 0.9535969164810599d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15137500573201035d, y: 0.21017303848689128d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038283286448429d, y: 0.16994026281093122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173407307745751d, y: 0.6619318549791015d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4106272708340456d, y: 0.16632115488575616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2057445449937204d, y: 0.878237005234618d), new NpgsqlTypes.NpgsqlPoint(x: 0.49128898520166364d, y: 0.684068791190552d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7556066247271227d, y: 0.21846218406535944d), new NpgsqlTypes.NpgsqlPoint(x: 0.5644568184453176d, y: 0.2601860992795586d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018288251107182d, y: 0.02901894567180474d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8394384282131501d, y: 0.4043209804960648d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822839737968978d, y: 0.5148665982000468d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143765702577151d, y: 0.4581373280192166d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9460957368952393d, y: 0.6822596253189818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5897472786170498d, y: 0.3740291165393682d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984872962056194d, y: 0.32608259369319337d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01846084593136177d, y: 0.1619994646474503d), new NpgsqlTypes.NpgsqlPoint(x: 0.5200677789196219d, y: 0.4952324984430788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2655589131367664d, y: 0.9609939036660682d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1884353648142505d, y: 0.5612352782053069d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273707701737099d, y: 0.7550593976748381d), new NpgsqlTypes.NpgsqlPoint(x: 0.5847201214649265d, y: 0.3183084567646486d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9444086326993787d, y: 0.044788668928446795d), new NpgsqlTypes.NpgsqlPoint(x: 0.576041957332105d, y: 0.8585624889170386d), new NpgsqlTypes.NpgsqlPoint(x: 0.7962777808178588d, y: 0.30233529882109056d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3594684078250573d, y: 0.31054098138584385d), new NpgsqlTypes.NpgsqlPoint(x: 0.37267183175286833d, y: 0.7662908259013425d), new NpgsqlTypes.NpgsqlPoint(x: 0.04578803596558356d, y: 0.5020241337430222d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3637053402629017d, y: 0.11825899074231871d), new NpgsqlTypes.NpgsqlPoint(x: 0.11761948018978463d, y: 0.3948577170628501d), new NpgsqlTypes.NpgsqlPoint(x: 0.46161495355430016d, y: 0.8923616039489853d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 3.151556950065082E-05d, y: 0.74502252554327d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914526460285865d, y: 0.35945373666246194d), new NpgsqlTypes.NpgsqlPoint(x: 0.09187467167601915d, y: 0.31756272089309456d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11129138209884748d, y: 0.8950537924559008d), new NpgsqlTypes.NpgsqlPoint(x: 0.4311494388892816d, y: 0.12081168570605538d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815384981050848d, y: 0.302259222976482d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03510032640466798d, y: 0.23242866754372093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620121197393087d, y: 0.2967631967172747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7627212375269811d, y: 0.09168285497875728d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 64,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9387545409169006d, y: 0.6630100961993073d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551554564241599d, y: 0.34005682924576386d), new NpgsqlTypes.NpgsqlPoint(x: 0.6532388492735732d, y: 0.48109229248739604d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39025863527224913d, y: 0.3918723576265648d), new NpgsqlTypes.NpgsqlPoint(x: 0.4446127582663332d, y: 0.7302654408624811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6092025804248927d, y: 0.35967745100775106d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31089251849415456d, y: 0.22205571045096217d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177898969761423d, y: 0.4194801072110538d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081282596165719d, y: 0.2123602402385959d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3365298881589551d, y: 0.8279564864999155d), new NpgsqlTypes.NpgsqlPoint(x: 0.18644853858900412d, y: 0.38686249526343874d), new NpgsqlTypes.NpgsqlPoint(x: 0.06031864802327769d, y: 0.07329502397192789d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.036311907514012254d, y: 0.6649274134737951d), new NpgsqlTypes.NpgsqlPoint(x: 0.67901100821653d, y: 0.6792366010248562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364149888478422d, y: 0.6392557275645807d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8338675413220779d, y: 0.9758210461567806d), new NpgsqlTypes.NpgsqlPoint(x: 0.17804268663167766d, y: 0.7437572164537777d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006297091929605d, y: 0.17747584476887535d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002892675332108574d, y: 0.49688567863424005d), new NpgsqlTypes.NpgsqlPoint(x: 0.4112267833797115d, y: 0.22084260177012727d), new NpgsqlTypes.NpgsqlPoint(x: 0.42327677583490664d, y: 0.004054348061429458d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9757395909673958d, y: 0.13820394625306376d), new NpgsqlTypes.NpgsqlPoint(x: 0.2633257865926254d, y: 0.023602831464122898d), new NpgsqlTypes.NpgsqlPoint(x: 0.021224813287789024d, y: 0.39796486100654194d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26066036351223254d, y: 0.9569821341695282d), new NpgsqlTypes.NpgsqlPoint(x: 0.12493248972855031d, y: 0.9783792649203868d), new NpgsqlTypes.NpgsqlPoint(x: 0.6766186295714961d, y: 0.4988417786063045d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3594499689531734d, y: 0.833619450728584d), new NpgsqlTypes.NpgsqlPoint(x: 0.8863258756031521d, y: 0.37589238888715604d), new NpgsqlTypes.NpgsqlPoint(x: 0.7437451893187346d, y: 0.9083433191333546d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4905169777506797d, y: 0.6650551259848395d), new NpgsqlTypes.NpgsqlPoint(x: 0.46629567615086953d, y: 0.21032443742595486d), new NpgsqlTypes.NpgsqlPoint(x: 0.19760857125030307d, y: 0.3132381492017777d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3009580855405083d, y: 0.6746408086808985d), new NpgsqlTypes.NpgsqlPoint(x: 0.26879992187323865d, y: 0.5943702461644185d), new NpgsqlTypes.NpgsqlPoint(x: 0.15587519811581663d, y: 0.9032147065272436d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3225614702668236d, y: 0.0247945931443867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6166019450871413d, y: 0.9156005763241877d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654574585986821d, y: 0.5506219236403023d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7390558981735507d, y: 0.08689399674763532d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099931645375873d, y: 0.2972073858721441d), new NpgsqlTypes.NpgsqlPoint(x: 0.5659009075938009d, y: 0.7251594895889317d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2401522350024623d, y: 0.7123285557366066d), new NpgsqlTypes.NpgsqlPoint(x: 0.6956736508841899d, y: 0.46750542590456157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9677678239097429d, y: 0.6573011175315007d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8472408259639965d, y: 0.42723437721583857d), new NpgsqlTypes.NpgsqlPoint(x: 0.49510759634866863d, y: 0.9819735518475509d), new NpgsqlTypes.NpgsqlPoint(x: 0.30946344451034835d, y: 0.2537949118019839d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5639869585692393d, y: 0.7230937155102897d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039243737976633d, y: 0.7910767211367633d), new NpgsqlTypes.NpgsqlPoint(x: 0.7034220691622413d, y: 0.174482466432909d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4683642662057247d, y: 0.44799662775194216d), new NpgsqlTypes.NpgsqlPoint(x: 0.9578997282797572d, y: 0.23268291504219385d), new NpgsqlTypes.NpgsqlPoint(x: 0.519183649643266d, y: 0.05787706731886921d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34133056741939016d, y: 0.020603562350217652d), new NpgsqlTypes.NpgsqlPoint(x: 0.2025698516867831d, y: 0.003676615124064919d), new NpgsqlTypes.NpgsqlPoint(x: 0.6945132841337346d, y: 0.5579350821603829d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9212727881795023d, y: 0.3087163432410305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2904684976822597d, y: 0.6875671083162967d), new NpgsqlTypes.NpgsqlPoint(x: 0.16704649341428945d, y: 0.2529572002550977d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35870584567715214d, y: 0.6777512394185427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5021363184325077d, y: 0.5243374770580695d), new NpgsqlTypes.NpgsqlPoint(x: 0.2933714432640594d, y: 0.8210787847801744d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6824525405466916d, y: 0.5619289868674077d), new NpgsqlTypes.NpgsqlPoint(x: 0.07605419875433772d, y: 0.49956944927025815d), new NpgsqlTypes.NpgsqlPoint(x: 0.2518647579812493d, y: 0.3692736458917003d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7758978515977843d, y: 0.17120542681507733d), new NpgsqlTypes.NpgsqlPoint(x: 0.2915609460386074d, y: 0.3356885239191779d), new NpgsqlTypes.NpgsqlPoint(x: 0.012339130144034094d, y: 0.028628078060008444d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 25,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07969907664380338d, y: 0.6814773784381978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8769721634602654d, y: 0.44040228673466264d), new NpgsqlTypes.NpgsqlPoint(x: 0.10261276778486994d, y: 0.8841414380474556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17277331005095964d, y: 0.854498022492577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5971276393922849d, y: 0.9445554134177838d), new NpgsqlTypes.NpgsqlPoint(x: 0.2620352669980216d, y: 0.22633007684083195d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.924527709384602d, y: 0.3380974896134157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307166999020338d, y: 0.3029051589158742d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052000895429968d, y: 0.1471162488353418d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6111742647837616d, y: 0.41042317576810994d), new NpgsqlTypes.NpgsqlPoint(x: 0.08962830030811153d, y: 0.4489489643998027d), new NpgsqlTypes.NpgsqlPoint(x: 0.7434116157540485d, y: 0.22968307973056423d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 73,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10360624201712298d, y: 0.8474929052842172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393459467370745d, y: 0.6473338923361394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601163986410913d, y: 0.5551571146177519d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9218919218175887d, y: 0.9587604782040163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9924459080149249d, y: 0.28786217037954165d), new NpgsqlTypes.NpgsqlPoint(x: 0.25892060483491197d, y: 0.43357259004066506d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9057454242217993d, y: 0.46345908818156734d), new NpgsqlTypes.NpgsqlPoint(x: 0.4780172422506813d, y: 0.7557400573604435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3479750331538234d, y: 0.9261720977949055d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6674449368874126d, y: 0.31797567596552434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8830922519642431d, y: 0.46329949784029456d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805912890101061d, y: 0.8673359842179982d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8629706705333732d, y: 0.6396160818175326d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993893205595089d, y: 0.7664136680599817d), new NpgsqlTypes.NpgsqlPoint(x: 0.9970336390796507d, y: 0.1579700653109446d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5523228573864661d, y: 0.38183581334225847d), new NpgsqlTypes.NpgsqlPoint(x: 0.9168994773191321d, y: 0.7332982964144219d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238609290841908d, y: 0.10680963409892785d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10332795453796584d, y: 0.3374110297810946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247800448321372d, y: 0.23866738443765367d), new NpgsqlTypes.NpgsqlPoint(x: 0.85868285285211d, y: 0.9243145793927513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10815961357079551d, y: 0.39467611463242624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6418997800406866d, y: 0.41150788568258045d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766906423936383d, y: 0.20643080542169256d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49293050447186915d, y: 0.2889981263774679d), new NpgsqlTypes.NpgsqlPoint(x: 0.35776984527437805d, y: 0.6813632330235665d), new NpgsqlTypes.NpgsqlPoint(x: 0.10386930320500132d, y: 0.827185434492275d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06192228839769642d, y: 0.4496561939954614d), new NpgsqlTypes.NpgsqlPoint(x: 0.2872905596181188d, y: 0.06616297084319789d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209459560649824d, y: 0.8792303271872408d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.044870542085750476d, y: 0.2659447519981256d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370731000426515d, y: 0.5718322073644859d), new NpgsqlTypes.NpgsqlPoint(x: 0.6323536665711802d, y: 0.17349119875254881d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7320395456532323d, y: 0.6975939710999961d), new NpgsqlTypes.NpgsqlPoint(x: 0.8738591215592064d, y: 0.28294138355232734d), new NpgsqlTypes.NpgsqlPoint(x: 0.630477198111449d, y: 0.00739310950153349d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4052451631237801d, y: 0.6198339415575685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335320341679621d, y: 0.8354974867079842d), new NpgsqlTypes.NpgsqlPoint(x: 0.08720729280179562d, y: 0.2401073226065209d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6653007877540354d, y: 0.8689630772938798d), new NpgsqlTypes.NpgsqlPoint(x: 0.22739251306403419d, y: 0.03334566482614287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638834438719496d, y: 0.9341575491200074d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3193478405149791d, y: 0.6423978942414144d), new NpgsqlTypes.NpgsqlPoint(x: 0.3435302030376588d, y: 0.09196410319986725d), new NpgsqlTypes.NpgsqlPoint(x: 0.8853424423126921d, y: 0.7321254819742837d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5798357800969058d, y: 0.4663225098642597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5839657447427249d, y: 0.257273542714345d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099704509601058d, y: 0.44540920201573d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4497516116345227d, y: 0.4661780233424546d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511675333487529d, y: 0.7707942601509907d), new NpgsqlTypes.NpgsqlPoint(x: 0.968474482561087d, y: 0.6384825415664706d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9194615966320336d, y: 0.3207793928785514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272841902748188d, y: 0.06412334179486734d), new NpgsqlTypes.NpgsqlPoint(x: 0.513704097337284d, y: 0.6682898688320532d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07812763624781438d, y: 0.49414623300737304d), new NpgsqlTypes.NpgsqlPoint(x: 0.3187033858675936d, y: 0.8407793063494472d), new NpgsqlTypes.NpgsqlPoint(x: 0.8570571832872519d, y: 0.6748661804982832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41296679592480223d, y: 0.08225265139226967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851425070515587d, y: 0.3032953409889304d), new NpgsqlTypes.NpgsqlPoint(x: 0.177998799401348d, y: 0.10259005494839513d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8845802011889329d, y: 0.6505462317272571d), new NpgsqlTypes.NpgsqlPoint(x: 0.03811526749088623d, y: 0.6979189874886804d), new NpgsqlTypes.NpgsqlPoint(x: 0.18584144302714956d, y: 0.13862120036752146d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5597010810928661d, y: 0.6956438038344899d), new NpgsqlTypes.NpgsqlPoint(x: 0.7526371719694799d, y: 0.7526152385674931d), new NpgsqlTypes.NpgsqlPoint(x: 0.16830462629646625d, y: 0.8148185293181355d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43649542351794757d, y: 0.21848529460374d), new NpgsqlTypes.NpgsqlPoint(x: 0.0014770523250230427d, y: 0.1115219167735576d), new NpgsqlTypes.NpgsqlPoint(x: 0.9583630533898206d, y: 0.06099484456010784d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3486028550496203d, y: 0.6505205566370539d), new NpgsqlTypes.NpgsqlPoint(x: 0.11735520450834525d, y: 0.9586979825919318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5485363129396693d, y: 0.9913067982254027d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2349163705484889d, y: 0.034368195314175454d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884778501656903d, y: 0.5712091085506079d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192562690367245d, y: 0.24295131393642633d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8696616793961273d, y: 0.9114858287564395d), new NpgsqlTypes.NpgsqlPoint(x: 0.8655319216580729d, y: 0.5954224683760512d), new NpgsqlTypes.NpgsqlPoint(x: 0.48813712575207546d, y: 0.7957024228126478d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.01841596577173399d, y: 0.11352968687606457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7136349498372664d, y: 0.12037666615513432d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385698284142532d, y: 0.5649288464147832d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29557337867064915d, y: 0.1001071358858876d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134788005738305d, y: 0.2290158320780159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6440913582586912d, y: 0.17762999784447187d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9925291078220461d, y: 0.5094939263796092d), new NpgsqlTypes.NpgsqlPoint(x: 0.2237891202614397d, y: 0.6845370612783279d), new NpgsqlTypes.NpgsqlPoint(x: 0.006536002432750432d, y: 0.9474483010926061d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4378188043671286d, y: 0.7103564551836808d), new NpgsqlTypes.NpgsqlPoint(x: 0.8746697653987322d, y: 0.24674533513478314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8619074734709665d, y: 0.9960003000633284d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9000789632853434d, y: 0.4053090386102465d), new NpgsqlTypes.NpgsqlPoint(x: 0.727005030247238d, y: 0.006870994893924509d), new NpgsqlTypes.NpgsqlPoint(x: 0.0264822437130523d, y: 0.1976435953742397d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0030769698179521354d, y: 0.11814399239119133d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262603372089635d, y: 0.21893083347193387d), new NpgsqlTypes.NpgsqlPoint(x: 0.46438654705062576d, y: 0.9992967790959696d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1723339615749131d, y: 0.43796232135835467d), new NpgsqlTypes.NpgsqlPoint(x: 0.11283580754316336d, y: 0.706291708559198d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073002867502699d, y: 0.3243738870590077d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05731116896158461d, y: 0.551895703108255d), new NpgsqlTypes.NpgsqlPoint(x: 0.39638337734021756d, y: 0.9463410698888213d), new NpgsqlTypes.NpgsqlPoint(x: 0.3476316957836959d, y: 0.49792266050168577d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8829072692801704d, y: 0.6522416443863263d), new NpgsqlTypes.NpgsqlPoint(x: 0.30316614711037704d, y: 0.2785367428552621d), new NpgsqlTypes.NpgsqlPoint(x: 0.27519805565719313d, y: 0.008703509083185512d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07909503204452617d, y: 0.5597399802409906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6500118658218375d, y: 0.6283046200853172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6445266595134889d, y: 0.5016278465973827d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 45,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8822853710251752d, y: 0.4387092846749113d), new NpgsqlTypes.NpgsqlPoint(x: 0.6508063085786009d, y: 0.7336149822973494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5284552215362739d, y: 0.3368301955979075d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6517576312069079d, y: 0.42216820744471995d), new NpgsqlTypes.NpgsqlPoint(x: 0.44036656879262825d, y: 0.4836170362282888d), new NpgsqlTypes.NpgsqlPoint(x: 0.005911832118621008d, y: 0.4935467321414414d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.034338506981117844d, y: 0.17701561316935144d), new NpgsqlTypes.NpgsqlPoint(x: 0.8663454060614173d, y: 0.17749465552307675d), new NpgsqlTypes.NpgsqlPoint(x: 0.7444497423416787d, y: 0.019502128495832882d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18417982934175392d, y: 0.589465592605345d), new NpgsqlTypes.NpgsqlPoint(x: 0.38822835476665596d, y: 0.3890748422092686d), new NpgsqlTypes.NpgsqlPoint(x: 0.536951665191312d, y: 0.6816212019516631d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3187973885097969d, y: 0.04517558545551792d), new NpgsqlTypes.NpgsqlPoint(x: 0.9910064978435854d, y: 0.007824195741953477d), new NpgsqlTypes.NpgsqlPoint(x: 0.03636833989395383d, y: 0.599123789139121d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3520324353502068d, y: 0.6348004273475628d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342530753142508d, y: 0.9521107726317202d), new NpgsqlTypes.NpgsqlPoint(x: 0.7623722952238271d, y: 0.029460728996320462d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7220082860412537d, y: 0.6427791069926445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4023344228547877d, y: 0.21855488315412352d), new NpgsqlTypes.NpgsqlPoint(x: 0.006260536885210999d, y: 0.3532021159468378d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14482839788824808d, y: 0.589967321064224d), new NpgsqlTypes.NpgsqlPoint(x: 0.0726223460136356d, y: 0.4350055213247095d), new NpgsqlTypes.NpgsqlPoint(x: 0.7922907475720509d, y: 0.47888166336995475d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07284519294995762d, y: 0.73302988696548d), new NpgsqlTypes.NpgsqlPoint(x: 0.7445152416159092d, y: 0.528634281453832d), new NpgsqlTypes.NpgsqlPoint(x: 0.27823304803730187d, y: 0.8915778736817487d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5763670951612441d, y: 0.07006552503733077d), new NpgsqlTypes.NpgsqlPoint(x: 0.34681091481805226d, y: 0.4976174303790838d), new NpgsqlTypes.NpgsqlPoint(x: 0.38057151198426875d, y: 0.4072026474647803d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12686456285398695d, y: 0.369720560746965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8374301456327533d, y: 0.9694773120159388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878873310084093d, y: 0.9263688484897309d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7917973991353393d, y: 0.23863687469848271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266859932857345d, y: 0.15870733215116117d), new NpgsqlTypes.NpgsqlPoint(x: 0.41251857217849175d, y: 0.2222722009848631d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7232955467213498d, y: 0.320216754172983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5471500040144971d, y: 0.9822318925825034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8384083054065281d, y: 0.646501892440882d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10083459270306494d, y: 0.6644986903203449d), new NpgsqlTypes.NpgsqlPoint(x: 0.6220813135451824d, y: 0.24089296441503372d), new NpgsqlTypes.NpgsqlPoint(x: 0.637217360102993d, y: 0.8685300861093874d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5632793088961323d, y: 0.4181895651749161d), new NpgsqlTypes.NpgsqlPoint(x: 0.703498915650403d, y: 0.561872239465947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372498356749821d, y: 0.6864236837524741d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3292273825938331d, y: 0.32472841198887215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284312444950219d, y: 0.7952085322278988d), new NpgsqlTypes.NpgsqlPoint(x: 0.22014795799097442d, y: 0.23800423561375994d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7411534375781162d, y: 0.7834293376564039d), new NpgsqlTypes.NpgsqlPoint(x: 0.7572912566301739d, y: 0.31607049045233326d), new NpgsqlTypes.NpgsqlPoint(x: 0.028048962216805418d, y: 0.0020113649764414987d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04499394425838987d, y: 0.4127525083330805d), new NpgsqlTypes.NpgsqlPoint(x: 0.7859241471457632d, y: 0.8959559780495114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7311405383936278d, y: 0.3538113799651158d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02948146766681503d, y: 0.12108535084605698d), new NpgsqlTypes.NpgsqlPoint(x: 0.43063104683999587d, y: 0.336063701189911d), new NpgsqlTypes.NpgsqlPoint(x: 0.4613470347908527d, y: 0.5631727336564102d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.07993313664116519d, y: 0.6509883970842589d), new NpgsqlTypes.NpgsqlPoint(x: 0.3222543029186139d, y: 0.8500896191331543d), new NpgsqlTypes.NpgsqlPoint(x: 0.05014341137372014d, y: 0.7310433723477923d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7294164290703179d, y: 0.09629656091566463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683293966741567d, y: 0.5264828869533827d), new NpgsqlTypes.NpgsqlPoint(x: 0.44090426656465476d, y: 0.3404312625496845d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26997627372990396d, y: 0.39579832316109453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069035097732585d, y: 0.7947232577665323d), new NpgsqlTypes.NpgsqlPoint(x: 0.3561677841108848d, y: 0.34259988395481344d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43112666600358607d, y: 0.07999122558235983d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316423141808877d, y: 0.2449339803682845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5901746334702849d, y: 0.06304898929720637d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6960713246695187d, y: 0.09941708404041927d), new NpgsqlTypes.NpgsqlPoint(x: 0.26767968691610733d, y: 0.9913798425412222d), new NpgsqlTypes.NpgsqlPoint(x: 0.8610284311499602d, y: 0.11441899235218933d)),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20076147812387557d, y: 0.8273503770515199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5716121288097017d, y: 0.9509162697527701d), new NpgsqlTypes.NpgsqlPoint(x: 0.6502744514433433d, y: 0.1764454478743439d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3626174594635573d, y: 0.4790933785774917d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787511491225201d, y: 0.9785135237382319d), new NpgsqlTypes.NpgsqlPoint(x: 0.1469315715759807d, y: 0.6059160961956763d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22359877874349288d, y: 0.16037394711698316d), new NpgsqlTypes.NpgsqlPoint(x: 0.4527650013262394d, y: 0.7949731658584744d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213119704287809d, y: 0.26292786211023944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.062206675712542125d, y: 0.022498958351237053d), new NpgsqlTypes.NpgsqlPoint(x: 0.26624720307842686d, y: 0.3562310976027251d), new NpgsqlTypes.NpgsqlPoint(x: 0.49095439526467544d, y: 0.9506221217384986d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6892170563962406d, y: 0.6456454383158651d), new NpgsqlTypes.NpgsqlPoint(x: 0.2812776100564174d, y: 0.22289922786967442d), new NpgsqlTypes.NpgsqlPoint(x: 0.981594136749235d, y: 0.8254008521714834d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08391249113635935d, y: 0.8212408917687115d), new NpgsqlTypes.NpgsqlPoint(x: 0.5975125541180291d, y: 0.36043865393411445d), new NpgsqlTypes.NpgsqlPoint(x: 0.020764865471026628d, y: 0.20236881628815206d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7720519135373292d, y: 0.8689891341746142d), new NpgsqlTypes.NpgsqlPoint(x: 0.7795562184313244d, y: 0.42727658444870953d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581761527577671d, y: 0.9411376146184239d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9196676245377764d, y: 0.2914371088660115d), new NpgsqlTypes.NpgsqlPoint(x: 0.6588947519563935d, y: 0.3534776489211856d), new NpgsqlTypes.NpgsqlPoint(x: 0.26190223136754753d, y: 0.142304359514826d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.796156679891024d, y: 0.4026709601834374d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636285405698199d, y: 0.449730298622777d), new NpgsqlTypes.NpgsqlPoint(x: 0.29620743266600436d, y: 0.46097054832063944d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3005256462437761d, y: 0.06622308317808356d), new NpgsqlTypes.NpgsqlPoint(x: 0.0654571088550191d, y: 0.2698682685711601d), new NpgsqlTypes.NpgsqlPoint(x: 0.47736721997667997d, y: 0.0064429463910241624d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2964512023214859d, y: 0.32561757576773953d), new NpgsqlTypes.NpgsqlPoint(x: 0.05550077834482958d, y: 0.6286166127241549d), new NpgsqlTypes.NpgsqlPoint(x: 0.9146545460350585d, y: 0.9867986727586863d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6109676059690016d, y: 0.7683352832564725d), new NpgsqlTypes.NpgsqlPoint(x: 0.6074904517754477d, y: 0.1946693062108963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379192007486536d, y: 0.3411307512382933d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4708723581338169d, y: 0.386644074937618d), new NpgsqlTypes.NpgsqlPoint(x: 0.8430728341229584d, y: 0.38329101164326185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4070222951230963d, y: 0.5281768586197263d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46307763402229274d, y: 0.4893908118093496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293645955098778d, y: 0.24573489144986382d), new NpgsqlTypes.NpgsqlPoint(x: 0.061126085761740834d, y: 0.762942047403663d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4424367309394418d, y: 0.7199668145171686d), new NpgsqlTypes.NpgsqlPoint(x: 0.4789270724101019d, y: 0.2379099211489757d), new NpgsqlTypes.NpgsqlPoint(x: 0.28133564308728254d, y: 0.7549127273022952d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018862434961028907d, y: 0.09505536842760254d), new NpgsqlTypes.NpgsqlPoint(x: 0.3198838128893773d, y: 0.7595149481263717d), new NpgsqlTypes.NpgsqlPoint(x: 0.004435980072236778d, y: 0.45344568014187603d)),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 120,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.257557838145799d, y: 0.5679736483057248d), new NpgsqlTypes.NpgsqlPoint(x: 0.44940711717209636d, y: 0.0818446987532585d), new NpgsqlTypes.NpgsqlPoint(x: 0.25777377352543895d, y: 0.6027463687967752d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2871980584081625d, y: 0.1713149082584534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7029449971618835d, y: 0.40686888604485405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141512624204841d, y: 0.738099986670364d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7499738204577642d, y: 0.821103652182369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9845001777929937d, y: 0.1978469480045375d), new NpgsqlTypes.NpgsqlPoint(x: 0.39634396934328064d, y: 0.2548439806554046d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.29896909294151053d, y: 0.23554897453660617d), new NpgsqlTypes.NpgsqlPoint(x: 0.5115156265365948d, y: 0.49154416883265806d), new NpgsqlTypes.NpgsqlPoint(x: 0.091095472802591d, y: 0.36496428652328416d)),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.014819439699573556d, y: 0.8933332584172401d), new NpgsqlTypes.NpgsqlPoint(x: 0.6927040767882662d, y: 0.24025543433210617d), new NpgsqlTypes.NpgsqlPoint(x: 0.729129890830942d, y: 0.4555621228102047d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4637920354368775d, y: 0.7409157375080339d), new NpgsqlTypes.NpgsqlPoint(x: 0.5789291703593228d, y: 0.49652410742992137d), new NpgsqlTypes.NpgsqlPoint(x: 0.23916554580532579d, y: 0.7614685319522179d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12685547796215513d, y: 0.8634302614155358d), new NpgsqlTypes.NpgsqlPoint(x: 0.30045839157860044d, y: 0.6932525894296173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912115455209997d, y: 0.8338813883401358d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6074377003393185d, y: 0.13567284623805487d), new NpgsqlTypes.NpgsqlPoint(x: 0.5443274625542747d, y: 0.9250233127639043d), new NpgsqlTypes.NpgsqlPoint(x: 0.689326921821229d, y: 0.7109669809971291d)),
},
},
            new NpgsqlPathpathArray1M
{
    Id = 129,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6746114852698708d, y: 0.8198213408922507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6839296785403769d, y: 0.5958600694051925d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397100403375575d, y: 0.46456157819835675d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39166850803434483d, y: 0.8066169334194622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838491552691469d, y: 0.770963977067326d), new NpgsqlTypes.NpgsqlPoint(x: 0.17105578718737158d, y: 0.364040667464386d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37304381569290856d, y: 0.48748425077233903d), new NpgsqlTypes.NpgsqlPoint(x: 0.33349473849980893d, y: 0.9023411401364412d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238563881338685d, y: 0.3806952542622295d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8704764459541632d, y: 0.6435825571880642d), new NpgsqlTypes.NpgsqlPoint(x: 0.21502593032427852d, y: 0.9091393572151049d), new NpgsqlTypes.NpgsqlPoint(x: 0.42795008549660196d, y: 0.2830668667743096d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9209086058879817d, y: 0.8044400308184416d), new NpgsqlTypes.NpgsqlPoint(x: 0.866469811123523d, y: 0.23444151948136938d), new NpgsqlTypes.NpgsqlPoint(x: 0.7740065937307956d, y: 0.23641424956661528d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6052936664980572d, y: 0.9245303064151394d), new NpgsqlTypes.NpgsqlPoint(x: 0.12275537729270802d, y: 0.42413855651738364d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138236660789082d, y: 0.4243290130010894d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5088965256576952d, y: 0.7214750069129071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8111556317439763d, y: 0.5623842342093229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6745903896054838d, y: 0.09367186938093541d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7923671429784191d, y: 0.3164263127434608d), new NpgsqlTypes.NpgsqlPoint(x: 0.9909436519530521d, y: 0.8512917374564063d), new NpgsqlTypes.NpgsqlPoint(x: 0.7259585450153824d, y: 0.16152472472464907d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6318609489545345d, y: 0.5049780581853993d), new NpgsqlTypes.NpgsqlPoint(x: 0.11238913388705984d, y: 0.21476600135937163d), new NpgsqlTypes.NpgsqlPoint(x: 0.20495836862610073d, y: 0.4197939133187556d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786366860340239d, y: 0.33121699523029446d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827200838066831d, y: 0.24359156219353062d), new NpgsqlTypes.NpgsqlPoint(x: 0.009146977641154574d, y: 0.18797447601075568d)),
},
},
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12135330013657397d, y: 0.923161641473257d), new NpgsqlTypes.NpgsqlPoint(x: 0.5393387316403229d, y: 0.9855221782908394d), new NpgsqlTypes.NpgsqlPoint(x: 0.08900707082072923d, y: 0.34695011842902335d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.024127698047316293d, y: 0.1829753324379354d), new NpgsqlTypes.NpgsqlPoint(x: 0.004819743588057812d, y: 0.4152742793956382d), new NpgsqlTypes.NpgsqlPoint(x: 0.6965845412278479d, y: 0.35027833538717157d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.852045444570451d, y: 0.6694206727624844d), new NpgsqlTypes.NpgsqlPoint(x: 0.6317339372422986d, y: 0.13907561510415445d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178382070082379d, y: 0.4792090730988574d)),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathArray1M
{
    Id = 141,
    Value = 
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.698021809181766d, y: 0.5502562188760681d), new NpgsqlTypes.NpgsqlPoint(x: 0.06100505926907385d, y: 0.8756298416686855d), new NpgsqlTypes.NpgsqlPoint(x: 0.36801737332300233d, y: 0.6910895174805619d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49204414686577924d, y: 0.8741523469021596d), new NpgsqlTypes.NpgsqlPoint(x: 0.4300210496250635d, y: 0.3078417701106979d), new NpgsqlTypes.NpgsqlPoint(x: 0.42247351614563966d, y: 0.5223313958864902d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4798340621009153d, y: 0.28019925471929774d), new NpgsqlTypes.NpgsqlPoint(x: 0.329483220574707d, y: 0.4346085300960244d), new NpgsqlTypes.NpgsqlPoint(x: 0.27756773235655685d, y: 0.8246133786061767d)),
},
    ModelInner = new NpgsqlPathpathArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6072502584466649d, y: 0.9186756849907919d), new NpgsqlTypes.NpgsqlPoint(x: 0.646807613927717d, y: 0.19651285823351883d), new NpgsqlTypes.NpgsqlPoint(x: 0.0903716985400973d, y: 0.9958845151414465d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.952294516881991d, y: 0.388198070197595d), new NpgsqlTypes.NpgsqlPoint(x: 0.8910593892372805d, y: 0.6772498707530797d), new NpgsqlTypes.NpgsqlPoint(x: 0.2117856822968247d, y: 0.17518654841684422d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6009142194783142d, y: 0.013603278137360508d), new NpgsqlTypes.NpgsqlPoint(x: 0.0712407624787692d, y: 0.013820111775213806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3326998905876787d, y: 0.9190714853692754d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6857454295839379d, y: 0.7598779530765865d), new NpgsqlTypes.NpgsqlPoint(x: 0.013276805730793928d, y: 0.9060577733804893d), new NpgsqlTypes.NpgsqlPoint(x: 0.31364696984306606d, y: 0.2929269908914234d)),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15534852786455455d, y: 0.15179571686638527d), new NpgsqlTypes.NpgsqlPoint(x: 0.3604867779838151d, y: 0.9063906485217738d), new NpgsqlTypes.NpgsqlPoint(x: 0.09801297890125094d, y: 0.2943572243640449d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.97735914770182d, y: 0.8247997570788292d), new NpgsqlTypes.NpgsqlPoint(x: 0.852367746304792d, y: 0.414554003734124d), new NpgsqlTypes.NpgsqlPoint(x: 0.864260609645166d, y: 0.6698135889079748d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.983209862006031d, y: 0.2625262567579816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6838264599004049d, y: 0.08155189493779402d), new NpgsqlTypes.NpgsqlPoint(x: 0.7553627354377269d, y: 0.011240017881220754d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19993855903553337d, y: 0.269274093030207d), new NpgsqlTypes.NpgsqlPoint(x: 0.8529478384431524d, y: 0.2728974581773915d), new NpgsqlTypes.NpgsqlPoint(x: 0.19253268509443322d, y: 0.0971970742339402d)),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7174952316626229d, y: 0.8538074561050983d), new NpgsqlTypes.NpgsqlPoint(x: 0.2219257523164213d, y: 0.6292502597137755d), new NpgsqlTypes.NpgsqlPoint(x: 0.865404846436397d, y: 0.5894560381902865d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.600363311500442d, y: 0.5594709122993731d), new NpgsqlTypes.NpgsqlPoint(x: 0.9576712237370354d, y: 0.6899475041618819d), new NpgsqlTypes.NpgsqlPoint(x: 0.36307017167848976d, y: 0.8341943147205497d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7385062389976388d, y: 0.8594364074791883d), new NpgsqlTypes.NpgsqlPoint(x: 0.5086900900221485d, y: 0.6930004542790125d), new NpgsqlTypes.NpgsqlPoint(x: 0.4690942663183084d, y: 0.06885873582648683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.30150023953780347d, y: 0.7279000201049319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6711318013924402d, y: 0.2250970825465518d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171744102432388d, y: 0.21309505539886053d)),
},
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlPath[4]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36865235654856243d, y: 0.44701650374234503d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654557310426132d, y: 0.5063586105332574d), new NpgsqlTypes.NpgsqlPoint(x: 0.32378586012954114d, y: 0.4335684275222169d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6202440611028575d, y: 0.3667129146079111d), new NpgsqlTypes.NpgsqlPoint(x: 0.9122245755281337d, y: 0.22114662671918173d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081492614267063d, y: 0.9154853638852154d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.842485456572816d, y: 0.0013309478510629136d), new NpgsqlTypes.NpgsqlPoint(x: 0.7238276597524044d, y: 0.009757352523112939d), new NpgsqlTypes.NpgsqlPoint(x: 0.7784764039664825d, y: 0.7257534199039848d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9316995428899931d, y: 0.5658490200612073d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336802175359503d, y: 0.7433824605500396d), new NpgsqlTypes.NpgsqlPoint(x: 0.7806965035161539d, y: 0.678261275122861d)),
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
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7020939329905445d, y: 0.7339643686876416d), new NpgsqlTypes.NpgsqlPoint(x: 0.1184701331987934d, y: 0.0902236210572519d), new NpgsqlTypes.NpgsqlPoint(x: 0.57961945346637d, y: 0.7200071233857501d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20085424752884995d, y: 0.9966985889619618d), new NpgsqlTypes.NpgsqlPoint(x: 0.15254219260974677d, y: 0.8328845847827125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565763136200115d, y: 0.4096990719347332d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9058735542781742d, y: 0.6808192771079562d), new NpgsqlTypes.NpgsqlPoint(x: 0.5238763665102568d, y: 0.16530665996789629d), new NpgsqlTypes.NpgsqlPoint(x: 0.08731656005627286d, y: 0.7473702138901198d)),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPath[3]
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18553716983099477d, y: 0.42014070743364573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8965969370645177d, y: 0.4645508660233082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6727219877548191d, y: 0.6300690592524946d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35661218532462235d, y: 0.6332291890985099d), new NpgsqlTypes.NpgsqlPoint(x: 0.23578718708759872d, y: 0.42624741621924345d), new NpgsqlTypes.NpgsqlPoint(x: 0.10671572479651148d, y: 0.7410469411371683d)),
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8946218484097214d, y: 0.5280424145409329d), new NpgsqlTypes.NpgsqlPoint(x: 0.6636724783897341d, y: 0.24608718139506636d), new NpgsqlTypes.NpgsqlPoint(x: 0.8371296115179745d, y: 0.01095958346125614d)),
}));
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
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathArraypathArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 129;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 74;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 20;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(26));
                Assert.That(firstItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 36;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 92;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlPathArraypathArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpathArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 47;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[9], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
            asPartInterface: typeof(INpgsqlPathArraypathArray)),
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 26, query1, 74, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 30, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 1, query1, 30, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[23],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var firstItems2 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 30, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 74, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[10],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[11],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                await ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 129, query1, 111, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 80, query1, 89, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
FROM public.npgsqlpathpatharray1m m
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
FROM public.npgsqlpathpatharray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems1 = new List<FlatNpgsqlPathpathArray1M>();
                var secondItems2 = new List<FlatNpgsqlPathpathArray1M>();
                 ((INpgsqlPathArraypathArray)this).DbConnectionDynQuerySelectModelBatch(connection, 62, query1, 54, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(firstItems1[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlPathpathArray1M.AssertModel(secondItems2[18],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatchAsync(connection, 63, 89))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[8],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathArraypathArray)this).DbConnectionSTSelectModelBatch(connection, 111, 120))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathArray1M.AssertModel(models[0],_testData[27], false);
                        NpgsqlPathpathArray1M.AssertModel(models[1],_testData[28], false);
                        NpgsqlPathpathArray1M.AssertModel(models[2],_testData[29], false);
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
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 30);
                var models = await ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathArraypathArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathArraypathArray)this).SetDbConnectionSelectModelParametrs(cmd, 11);
                var models =  ((INpgsqlPathArraypathArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlPathpathArray1M.AssertModel(models[0],_testData[3], false);NpgsqlPathpathArray1M.AssertModel(models[1],_testData[4], false);NpgsqlPathpathArray1M.AssertModel(models[2],_testData[5], false);NpgsqlPathpathArray1M.AssertModel(models[3],_testData[6], false);NpgsqlPathpathArray1M.AssertModel(models[4],_testData[7], false);NpgsqlPathpathArray1M.AssertModel(models[5],_testData[8], false);NpgsqlPathpathArray1M.AssertModel(models[6],_testData[9], false);NpgsqlPathpathArray1M.AssertModel(models[7],_testData[10], false);NpgsqlPathpathArray1M.AssertModel(models[8],_testData[11], false);NpgsqlPathpathArray1M.AssertModel(models[9],_testData[12], false);NpgsqlPathpathArray1M.AssertModel(models[10],_testData[13], false);NpgsqlPathpathArray1M.AssertModel(models[11],_testData[14], false);NpgsqlPathpathArray1M.AssertModel(models[12],_testData[15], false);NpgsqlPathpathArray1M.AssertModel(models[13],_testData[16], false);NpgsqlPathpathArray1M.AssertModel(models[14],_testData[17], false);NpgsqlPathpathArray1M.AssertModel(models[15],_testData[18], false);NpgsqlPathpathArray1M.AssertModel(models[16],_testData[19], false);NpgsqlPathpathArray1M.AssertModel(models[17],_testData[20], false);NpgsqlPathpathArray1M.AssertModel(models[18],_testData[21], false);NpgsqlPathpathArray1M.AssertModel(models[19],_testData[22], false);NpgsqlPathpathArray1M.AssertModel(models[20],_testData[23], false);NpgsqlPathpathArray1M.AssertModel(models[21],_testData[24], false);NpgsqlPathpathArray1M.AssertModel(models[22],_testData[25], false);NpgsqlPathpathArray1M.AssertModel(models[23],_testData[26], false);NpgsqlPathpathArray1M.AssertModel(models[24],_testData[27], false);NpgsqlPathpathArray1M.AssertModel(models[25],_testData[28], false);NpgsqlPathpathArray1M.AssertModel(models[26],_testData[29], false);
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
FROM public.binary_npgsqlpathpatharray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathArraypathArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathArray1MIWA),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathArraypathArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathArray1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathArraypathArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathArraypathArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(actual, expect, false);
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
            queryMapType: typeof(NpgsqlPathpathArray1MI),
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathArraypathArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathArraypathArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlPathpathArray1MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathArraypathArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathArraypathArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            queryMapType: typeof(NpgsqlPathpathArray1M),
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathArray1MIWA)],
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
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathArraypathArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(6)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathArraypathArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpatharray1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathArray1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

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

        [Test, Order(6)]
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

        [Test, Order(6)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPathArraypathArray)this).ExportModelInner(connection).ToList();
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

