

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
    internal partial interface INpgsqlPolygonMArraypolygonMMArrayD3
    {
    }
    
    internal partial class NpgsqlPolygonMArraypolygonMMArrayD3 : INpgsqlPolygonMArraypolygonMMArrayD3
    {


#region TestData

        private readonly NpgsqlPolygonpolygonMMArrayD3E1M[] _testData = new NpgsqlPolygonpolygonMMArrayD3E1M[]
        {
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 3,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40980788194481454d, y: 0.10309557857718288d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855050701622538d, y: 0.4348514003372981d), new NpgsqlTypes.NpgsqlPoint(x: 0.941200527835309d, y: 0.5979397931281287d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8989615530616032d, y: 0.3036314995183631d), new NpgsqlTypes.NpgsqlPoint(x: 0.014924998634075037d, y: 0.8998721559026761d), new NpgsqlTypes.NpgsqlPoint(x: 0.18409821050613673d, y: 0.4820740723398368d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12246726116372197d, y: 0.24256504406449098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502506233937257d, y: 0.5388943165269139d), new NpgsqlTypes.NpgsqlPoint(x: 0.10154544613028682d, y: 0.3032082693285768d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30407865015760993d, y: 0.6569961339308634d), new NpgsqlTypes.NpgsqlPoint(x: 0.47014251085292413d, y: 0.13730403776246114d), new NpgsqlTypes.NpgsqlPoint(x: 0.8560520638535554d, y: 0.0734872463038082d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19538271583396338d, y: 0.7125378350215864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4165494891560073d, y: 0.15139406489560026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3061784892983427d, y: 0.4652359571141488d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4873660984602105d, y: 0.7701241588675755d), new NpgsqlTypes.NpgsqlPoint(x: 0.30943083451209275d, y: 0.7865854817898581d), new NpgsqlTypes.NpgsqlPoint(x: 0.31132205664867263d, y: 0.23713641802073693d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33029741048248784d, y: 0.13085405407545003d), new NpgsqlTypes.NpgsqlPoint(x: 0.3107291342704315d, y: 0.8747736879919614d), new NpgsqlTypes.NpgsqlPoint(x: 0.11257994519527947d, y: 0.5725649338349861d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20481117403513316d, y: 0.3992456054076643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6351500848550026d, y: 0.7871446193678595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6079034417944611d, y: 0.22871535987781966d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5574429052829646d, y: 0.1956445679527672d), new NpgsqlTypes.NpgsqlPoint(x: 0.9140344539182119d, y: 0.49064828930526627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382120711904941d, y: 0.5412402661931517d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5270069307033693d, y: 0.19572421845608712d), new NpgsqlTypes.NpgsqlPoint(x: 0.6201941079709266d, y: 0.5388531638414026d), new NpgsqlTypes.NpgsqlPoint(x: 0.39216219607833613d, y: 0.8057772383316815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5025451726878055d, y: 0.5234284046332831d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633866359289859d, y: 0.14216466548901951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8930696632382883d, y: 0.8449701730796618d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9006900336215126d, y: 0.06585930153968012d), new NpgsqlTypes.NpgsqlPoint(x: 0.51982236180977d, y: 0.4136345048100277d), new NpgsqlTypes.NpgsqlPoint(x: 0.8648085673372007d, y: 0.7585155138952333d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5910049676917837d, y: 0.42462424716514646d), new NpgsqlTypes.NpgsqlPoint(x: 0.568662580528771d, y: 0.7737830805600406d), new NpgsqlTypes.NpgsqlPoint(x: 0.04280320389260628d, y: 0.2987338735116677d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.76861637765678d, y: 0.9036464569795047d), new NpgsqlTypes.NpgsqlPoint(x: 0.11729602000890116d, y: 0.514390467881519d), new NpgsqlTypes.NpgsqlPoint(x: 0.16197152586999275d, y: 0.38994708285640733d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3332059835683463d, y: 0.0003905744580493531d), new NpgsqlTypes.NpgsqlPoint(x: 0.9260354341279078d, y: 0.9110524087208837d), new NpgsqlTypes.NpgsqlPoint(x: 0.20202108971148525d, y: 0.08791140250081231d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.266063792866404d, y: 0.7776837041155537d), new NpgsqlTypes.NpgsqlPoint(x: 0.9357487363408359d, y: 0.4960158658856434d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014858779304543d, y: 0.40756559504154644d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40302017378492816d, y: 0.681524682613785d), new NpgsqlTypes.NpgsqlPoint(x: 0.6496559816716475d, y: 0.03634194027169935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8824936143866279d, y: 0.3269701677750998d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25040194452830244d, y: 0.18540204768501167d), new NpgsqlTypes.NpgsqlPoint(x: 0.49540671589059604d, y: 0.12927804282821842d), new NpgsqlTypes.NpgsqlPoint(x: 0.5284987536672104d, y: 0.7823235473145848d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5749584840704414d, y: 0.8670548590063322d), new NpgsqlTypes.NpgsqlPoint(x: 0.9136868422737373d, y: 0.43226185677465156d), new NpgsqlTypes.NpgsqlPoint(x: 0.9296037452746648d, y: 0.536219719353135d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.747253214353452d, y: 0.7898605321317932d), new NpgsqlTypes.NpgsqlPoint(x: 0.656891718311946d, y: 0.20645462812550608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4017627926534464d, y: 0.7825408796665011d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2683320047906266d, y: 0.8243498140949322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4937827541940454d, y: 0.24716448460814544d), new NpgsqlTypes.NpgsqlPoint(x: 0.48026816687369345d, y: 0.04885231316948435d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8208625421779645d, y: 0.2943587171863862d), new NpgsqlTypes.NpgsqlPoint(x: 0.7939524404602137d, y: 0.8149975408850842d), new NpgsqlTypes.NpgsqlPoint(x: 0.888749551391311d, y: 0.954163181917337d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.899894340770315d, y: 0.6508412114812328d), new NpgsqlTypes.NpgsqlPoint(x: 0.3186759974707526d, y: 0.09551629270446615d), new NpgsqlTypes.NpgsqlPoint(x: 0.35637399676453074d, y: 0.5066151520641435d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4776759739627702d, y: 0.5911820788606464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381504691288534d, y: 0.7700174080783065d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009689809066916188d, y: 0.9979589756182308d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8145209925017459d, y: 0.8659014398376395d), new NpgsqlTypes.NpgsqlPoint(x: 0.32632180484879014d, y: 0.6453683690789012d), new NpgsqlTypes.NpgsqlPoint(x: 0.14955021232353516d, y: 0.8929970983561454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5584671290920422d, y: 0.8262624078849248d), new NpgsqlTypes.NpgsqlPoint(x: 0.02182292696615762d, y: 0.5930837362042978d), new NpgsqlTypes.NpgsqlPoint(x: 0.8287645412810122d, y: 0.32358823316345975d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3087203802222108d, y: 0.25409823297558376d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665021732544204d, y: 0.79131870690571d), new NpgsqlTypes.NpgsqlPoint(x: 0.48395899401816267d, y: 0.6150420665207651d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6354059912489325d, y: 0.7477372022219171d), new NpgsqlTypes.NpgsqlPoint(x: 0.8259556469217562d, y: 0.845852897393297d), new NpgsqlTypes.NpgsqlPoint(x: 0.1845111584688779d, y: 0.5908339859449866d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8364374064206089d, y: 0.24099581641135714d), new NpgsqlTypes.NpgsqlPoint(x: 0.4371035066724618d, y: 0.4345300272384748d), new NpgsqlTypes.NpgsqlPoint(x: 0.04664247187778847d, y: 0.6238082206545816d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7177511896384975d, y: 0.6322307758775106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4079876852678904d, y: 0.10286731881204081d), new NpgsqlTypes.NpgsqlPoint(x: 0.2972048101563426d, y: 0.2746318231153949d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.606389746868233d, y: 0.13104697472000515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6377475930855572d, y: 0.240181404302781d), new NpgsqlTypes.NpgsqlPoint(x: 0.11398877226885407d, y: 0.1397144088739226d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.697655518056748d, y: 0.2866881693249218d), new NpgsqlTypes.NpgsqlPoint(x: 0.0199086952059363d, y: 0.38409914015625435d), new NpgsqlTypes.NpgsqlPoint(x: 0.75939184012412d, y: 0.4884366252752831d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8514237607381734d, y: 0.48248348938049634d), new NpgsqlTypes.NpgsqlPoint(x: 0.9187090575760241d, y: 0.20139089751591788d), new NpgsqlTypes.NpgsqlPoint(x: 0.11020411908799244d, y: 0.23867170403447113d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6941204579784093d, y: 0.8317514080562017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3107565842182264d, y: 0.9925226507626306d), new NpgsqlTypes.NpgsqlPoint(x: 0.9921200315496804d, y: 0.09104914398874586d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1747866913581354d, y: 0.5070602464874095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8525061567874705d, y: 0.3942956309849105d), new NpgsqlTypes.NpgsqlPoint(x: 0.33333373571226577d, y: 0.012635566200743242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08158395883372305d, y: 0.9833444032432958d), new NpgsqlTypes.NpgsqlPoint(x: 0.1183412191279477d, y: 0.689044800037587d), new NpgsqlTypes.NpgsqlPoint(x: 0.5078332436586652d, y: 0.6200204310384678d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7134199768523064d, y: 0.4747531249577328d), new NpgsqlTypes.NpgsqlPoint(x: 0.004944885224399953d, y: 0.7179905256018703d), new NpgsqlTypes.NpgsqlPoint(x: 0.29129453621016155d, y: 0.40330617602087837d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.195047803429666d, y: 0.8235614965263749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3044614925671554d, y: 0.4833064413195973d), new NpgsqlTypes.NpgsqlPoint(x: 0.10262583395159641d, y: 0.5322826879457371d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8785506530242688d, y: 0.8231419009833423d), new NpgsqlTypes.NpgsqlPoint(x: 0.22312368047544417d, y: 0.5727617649677835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999624966195488d, y: 0.20999106712235982d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9068176518391426d, y: 0.3449461699974299d), new NpgsqlTypes.NpgsqlPoint(x: 0.01910867469849231d, y: 0.8839247891231417d), new NpgsqlTypes.NpgsqlPoint(x: 0.34637354993965674d, y: 0.4648170827288549d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3773255317111276d, y: 0.29833592549671906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209162794263214d, y: 0.2647525593833918d), new NpgsqlTypes.NpgsqlPoint(x: 0.7112322163385623d, y: 0.9636061718194403d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8638588286996414d, y: 0.2285867869043392d), new NpgsqlTypes.NpgsqlPoint(x: 0.32456830930686786d, y: 0.5380276848183704d), new NpgsqlTypes.NpgsqlPoint(x: 0.5981114868448785d, y: 0.8990297207335383d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07362360826208281d, y: 0.1899122274300592d), new NpgsqlTypes.NpgsqlPoint(x: 0.5266217328497452d, y: 0.31470421955943484d), new NpgsqlTypes.NpgsqlPoint(x: 0.24514785797386085d, y: 0.2605928916782504d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3639945659283108d, y: 0.6330882711179449d), new NpgsqlTypes.NpgsqlPoint(x: 0.3014458827194384d, y: 0.8069343390691769d), new NpgsqlTypes.NpgsqlPoint(x: 0.7986593804243912d, y: 0.3217658215308723d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7806546427256993d, y: 0.21085416954518033d), new NpgsqlTypes.NpgsqlPoint(x: 0.3777541466970884d, y: 0.4814033517910513d), new NpgsqlTypes.NpgsqlPoint(x: 0.5183511783671779d, y: 0.3855574541680713d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025717649598205328d, y: 0.36924082274535797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8085644625210433d, y: 0.948334907278128d), new NpgsqlTypes.NpgsqlPoint(x: 0.0653461568059317d, y: 0.6393423518996625d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003989402658225116d, y: 0.5821791256833261d), new NpgsqlTypes.NpgsqlPoint(x: 0.16581078751173195d, y: 0.9214440410926541d), new NpgsqlTypes.NpgsqlPoint(x: 0.9740062071438008d, y: 0.8120550256606276d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7698453446486115d, y: 0.9453882117101359d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524957255286425d, y: 0.36185435172557556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7477219164781002d, y: 0.8026987588635776d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5988218058406152d, y: 0.4673354792518428d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476157435050531d, y: 0.6446380607374383d), new NpgsqlTypes.NpgsqlPoint(x: 0.167978220954212d, y: 0.6715289834829131d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24692211065458491d, y: 0.6347214377427628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388625604220258d, y: 0.4931236873842131d), new NpgsqlTypes.NpgsqlPoint(x: 0.20096726976781631d, y: 0.6613998893625508d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5426335309256496d, y: 0.2862604732263089d), new NpgsqlTypes.NpgsqlPoint(x: 0.09458669193021929d, y: 0.7737789201969975d), new NpgsqlTypes.NpgsqlPoint(x: 0.8859778966845634d, y: 0.8024395136330639d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.820096661352834d, y: 0.15412900371275629d), new NpgsqlTypes.NpgsqlPoint(x: 0.7001521706325887d, y: 0.7558633106800772d), new NpgsqlTypes.NpgsqlPoint(x: 0.34453430649341954d, y: 0.18267479913028584d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39937549916074455d, y: 0.7421699700400852d), new NpgsqlTypes.NpgsqlPoint(x: 0.4755668142334576d, y: 0.5913749411911122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188313101232462d, y: 0.28863389269986517d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8665186050583386d, y: 0.7306280857407464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565905175982373d, y: 0.7423470196536464d), new NpgsqlTypes.NpgsqlPoint(x: 0.24599691652524358d, y: 0.41164930920608744d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07309229558781538d, y: 0.8206566393400652d), new NpgsqlTypes.NpgsqlPoint(x: 0.4656265374020101d, y: 0.5779212623093132d), new NpgsqlTypes.NpgsqlPoint(x: 0.17144968994475374d, y: 0.7959202786777074d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9116227766585666d, y: 0.482171810995083d), new NpgsqlTypes.NpgsqlPoint(x: 0.6800613395137044d, y: 0.6919921847849817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143603468075115d, y: 0.24362734001999775d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7750858807283074d, y: 0.474082391265661d), new NpgsqlTypes.NpgsqlPoint(x: 0.5986429710707769d, y: 0.6729074889028271d), new NpgsqlTypes.NpgsqlPoint(x: 0.2901755090333583d, y: 0.3558409280739554d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6267869586463718d, y: 0.8120309069684286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7352357017048036d, y: 0.6477882791415502d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954316137744563d, y: 0.6436841099529881d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3708072463816696d, y: 0.732086969893624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7541660868194259d, y: 0.9385891907341932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5714329886227888d, y: 0.8366036706538789d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2839514415582881d, y: 0.9289349124001958d), new NpgsqlTypes.NpgsqlPoint(x: 0.9150246984829405d, y: 0.5753802582768963d), new NpgsqlTypes.NpgsqlPoint(x: 0.4300060093004341d, y: 0.42171819537876565d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7471169825665093d, y: 0.12958712716761578d), new NpgsqlTypes.NpgsqlPoint(x: 0.11038916571337909d, y: 0.8431834172908639d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968127509339419d, y: 0.12919795274896417d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31871291392661827d, y: 0.6869235560500935d), new NpgsqlTypes.NpgsqlPoint(x: 0.48703096273962554d, y: 0.448685520261087d), new NpgsqlTypes.NpgsqlPoint(x: 0.34730903283651104d, y: 0.9668535299684409d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7869867711577837d, y: 0.8227990398252227d), new NpgsqlTypes.NpgsqlPoint(x: 0.7364349940376145d, y: 0.3208191210487097d), new NpgsqlTypes.NpgsqlPoint(x: 0.03452209377319038d, y: 0.5452089964601378d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4904739823216723d, y: 0.46213584946525743d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279197460450376d, y: 0.21589032929965168d), new NpgsqlTypes.NpgsqlPoint(x: 0.3577148569524403d, y: 0.16226828054641929d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9766949255516686d, y: 0.02648445911439956d), new NpgsqlTypes.NpgsqlPoint(x: 0.37491694903220973d, y: 0.3226929309640556d), new NpgsqlTypes.NpgsqlPoint(x: 0.24830288503082154d, y: 0.5884443840680328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9436091290857691d, y: 0.41417807320392996d), new NpgsqlTypes.NpgsqlPoint(x: 0.9335515945708308d, y: 0.962280802484751d), new NpgsqlTypes.NpgsqlPoint(x: 0.1939362750240644d, y: 0.5785032786345078d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30066317023796285d, y: 0.3350678699105406d), new NpgsqlTypes.NpgsqlPoint(x: 0.21107123854667964d, y: 0.8615439531050681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7267542913042938d, y: 0.662480382248088d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2509810166313815d, y: 0.21155834207131352d), new NpgsqlTypes.NpgsqlPoint(x: 0.7159406512673958d, y: 0.9181965860245902d), new NpgsqlTypes.NpgsqlPoint(x: 0.3048322799556178d, y: 0.7779605240372275d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27187230233919923d, y: 0.6386368507294112d), new NpgsqlTypes.NpgsqlPoint(x: 0.1652086847611428d, y: 0.7536503895235225d), new NpgsqlTypes.NpgsqlPoint(x: 0.0963560244420969d, y: 0.9878645154957506d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24491156987715024d, y: 0.7949878911207047d), new NpgsqlTypes.NpgsqlPoint(x: 0.2607412717636841d, y: 0.3149620324311987d), new NpgsqlTypes.NpgsqlPoint(x: 0.12399650554970931d, y: 0.7738107993238841d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2630214864815137d, y: 0.9486527407424246d), new NpgsqlTypes.NpgsqlPoint(x: 0.6703630447518929d, y: 0.19077033204807592d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075634697814253d, y: 0.021313807451309397d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033286720105014656d, y: 0.736495676733539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484170032946677d, y: 0.027218270137947975d), new NpgsqlTypes.NpgsqlPoint(x: 0.358849821514192d, y: 0.6678474870868283d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9799497048820741d, y: 0.33701027472635425d), new NpgsqlTypes.NpgsqlPoint(x: 0.613361278236441d, y: 0.9802829336985296d), new NpgsqlTypes.NpgsqlPoint(x: 0.009491239764028991d, y: 0.9617450648600235d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9165283716031659d, y: 0.645063304420681d), new NpgsqlTypes.NpgsqlPoint(x: 0.4358700765132405d, y: 0.33657679264906215d), new NpgsqlTypes.NpgsqlPoint(x: 0.6982485016856279d, y: 0.5223752940556087d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.491388454671124d, y: 0.4513347066604507d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961281733013603d, y: 0.2018009214250691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585364758424528d, y: 0.006689235594203979d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3032310915819184d, y: 0.3753088787482439d), new NpgsqlTypes.NpgsqlPoint(x: 0.8143430391648793d, y: 0.8785751638837418d), new NpgsqlTypes.NpgsqlPoint(x: 0.4544933180485825d, y: 0.8189217702461055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2826352507686919d, y: 0.7776011103842769d), new NpgsqlTypes.NpgsqlPoint(x: 0.4014251630773573d, y: 0.10596265629492929d), new NpgsqlTypes.NpgsqlPoint(x: 0.9132404356094175d, y: 0.8098637136807743d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8252025746594212d, y: 0.4294554520614302d), new NpgsqlTypes.NpgsqlPoint(x: 0.42578616250239554d, y: 0.33958953898178845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5674212302683754d, y: 0.3344475347419764d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7777035013836484d, y: 0.4848012518051297d), new NpgsqlTypes.NpgsqlPoint(x: 0.04944253425398726d, y: 0.8447713835024748d), new NpgsqlTypes.NpgsqlPoint(x: 0.02528845438554772d, y: 0.3240848459894845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6484526616181279d, y: 0.9176009732034262d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589461723941727d, y: 0.7148086065564748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833747357197874d, y: 0.9013273562499147d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6085365007992521d, y: 0.9540205043420548d), new NpgsqlTypes.NpgsqlPoint(x: 0.2544265505307036d, y: 0.9125810095674275d), new NpgsqlTypes.NpgsqlPoint(x: 0.1228529599569761d, y: 0.4528217116560199d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.998041946317806d, y: 0.2882314342658058d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303092548641617d, y: 0.6561785732895056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294823526144929d, y: 0.9361744809847234d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6149491001498691d, y: 0.4195737673398323d), new NpgsqlTypes.NpgsqlPoint(x: 0.21697061110832438d, y: 0.8774693313379743d), new NpgsqlTypes.NpgsqlPoint(x: 0.16485328589714476d, y: 0.1581351949124169d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23376775290042073d, y: 0.6260526622974784d), new NpgsqlTypes.NpgsqlPoint(x: 0.6787528335604105d, y: 0.550919845521242d), new NpgsqlTypes.NpgsqlPoint(x: 0.10237365693211553d, y: 0.16021336861086222d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5766722881063913d, y: 0.6992226045176763d), new NpgsqlTypes.NpgsqlPoint(x: 0.744121555733067d, y: 0.8939606847563001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725112873292092d, y: 0.9458315788330821d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9911077407608744d, y: 0.16329431079878054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2425841922124009d, y: 0.5952862456549886d), new NpgsqlTypes.NpgsqlPoint(x: 0.1412749510267034d, y: 0.41526012310846827d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.756694374875554d, y: 0.6883397925111735d), new NpgsqlTypes.NpgsqlPoint(x: 0.2668099887846215d, y: 0.2857099771035634d), new NpgsqlTypes.NpgsqlPoint(x: 0.6253223700389028d, y: 0.9620708024764513d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35155938233079465d, y: 0.8103197052291573d), new NpgsqlTypes.NpgsqlPoint(x: 0.2002028913365822d, y: 0.7685464028163307d), new NpgsqlTypes.NpgsqlPoint(x: 0.6832601040501038d, y: 0.16622670085608426d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5885064057546843d, y: 0.5223476914555409d), new NpgsqlTypes.NpgsqlPoint(x: 0.1857736676000784d, y: 0.38840175103911845d), new NpgsqlTypes.NpgsqlPoint(x: 0.25855166970527377d, y: 0.7854635197993706d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4677083111467123d, y: 0.24265312876932343d), new NpgsqlTypes.NpgsqlPoint(x: 0.6603654129086265d, y: 0.5237912679140173d), new NpgsqlTypes.NpgsqlPoint(x: 0.3533539441164023d, y: 0.7151268278634318d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2878646624688386d, y: 0.20697910076228354d), new NpgsqlTypes.NpgsqlPoint(x: 0.49895886353555585d, y: 0.7934399913847018d), new NpgsqlTypes.NpgsqlPoint(x: 0.9730276657889122d, y: 0.13711864153449682d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9322666429924981d, y: 0.04512690317068435d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859026585122523d, y: 0.7961820768462926d), new NpgsqlTypes.NpgsqlPoint(x: 0.040195868901471976d, y: 0.6480446710337475d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7927409907831359d, y: 0.17368399047418126d), new NpgsqlTypes.NpgsqlPoint(x: 0.10133179147016935d, y: 0.10527240678081928d), new NpgsqlTypes.NpgsqlPoint(x: 0.597284097846587d, y: 0.8780157352106558d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4442440664226943d, y: 0.5331991887219464d), new NpgsqlTypes.NpgsqlPoint(x: 0.4621294737852113d, y: 0.7865666478817949d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489129512148572d, y: 0.5593794591121947d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7612506966603833d, y: 0.5723581098269482d), new NpgsqlTypes.NpgsqlPoint(x: 0.38545637161492685d, y: 0.2835165105601597d), new NpgsqlTypes.NpgsqlPoint(x: 0.37319440448760444d, y: 0.20709840183097372d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42436354823932043d, y: 0.08568641808959088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8358851937660823d, y: 0.062375963257136235d), new NpgsqlTypes.NpgsqlPoint(x: 0.26760340508189573d, y: 0.1415599568669832d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15523086203308312d, y: 0.786857225965256d), new NpgsqlTypes.NpgsqlPoint(x: 0.1442176405790374d, y: 0.7574631058091282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9400756276187427d, y: 0.24087947438797597d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9714614899680395d, y: 0.7089769676355132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278827915701602d, y: 0.5737627998820045d), new NpgsqlTypes.NpgsqlPoint(x: 0.740771960238617d, y: 0.5965936987703238d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4670076427464257d, y: 0.8138114471496568d), new NpgsqlTypes.NpgsqlPoint(x: 0.8110593718559027d, y: 0.6293262198720583d), new NpgsqlTypes.NpgsqlPoint(x: 0.283345996108606d, y: 0.48341276795619736d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5430847935928119d, y: 0.7733790680053734d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280140471576223d, y: 0.5541237905727951d), new NpgsqlTypes.NpgsqlPoint(x: 0.7409581498121438d, y: 0.18577213446178642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5165745476823096d, y: 0.6203041829403604d), new NpgsqlTypes.NpgsqlPoint(x: 0.18518679507431934d, y: 0.32948566888451103d), new NpgsqlTypes.NpgsqlPoint(x: 0.03691748324998401d, y: 0.5561333801285891d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7079517696806242d, y: 0.3732063149703293d), new NpgsqlTypes.NpgsqlPoint(x: 0.3390146980779559d, y: 0.34855357744240445d), new NpgsqlTypes.NpgsqlPoint(x: 0.2539463154706404d, y: 0.5137065057844825d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5684020346125856d, y: 0.8920315390336055d), new NpgsqlTypes.NpgsqlPoint(x: 0.860497488927067d, y: 0.3180070142185988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8508157290606445d, y: 0.052161418613788424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7257706396484706d, y: 0.03608287065046556d), new NpgsqlTypes.NpgsqlPoint(x: 0.7130868311499379d, y: 0.7981361010511109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024754580888499d, y: 0.16946179670012973d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5537128780353426d, y: 0.3751053480462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7316665497768933d, y: 0.5137716255044141d), new NpgsqlTypes.NpgsqlPoint(x: 0.28027317758553194d, y: 0.9236297671111757d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9753181413195054d, y: 0.8760542450992657d), new NpgsqlTypes.NpgsqlPoint(x: 0.166486853406289d, y: 0.20670020331233097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917052277244355d, y: 0.4174832037853139d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5803274848140821d, y: 0.43689454180509457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6303573024627813d, y: 0.3030809491484412d), new NpgsqlTypes.NpgsqlPoint(x: 0.01540843007640369d, y: 0.948864499864066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9549872830118854d, y: 0.9023137549714781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4186207965870089d, y: 0.13039493608932717d), new NpgsqlTypes.NpgsqlPoint(x: 0.08319066230850658d, y: 0.8922802106395192d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.015361766516511444d, y: 0.3140777605394084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9719008201091959d, y: 0.16067070500597658d), new NpgsqlTypes.NpgsqlPoint(x: 0.10542045630569796d, y: 0.4339020389849374d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1549320703313949d, y: 0.8469569291743151d), new NpgsqlTypes.NpgsqlPoint(x: 0.03656380821156391d, y: 0.4548777743715625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563322856847659d, y: 0.6500933408986025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5300618363213628d, y: 0.16181185023974853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8485079641680584d, y: 0.8861869229400074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8868750648343265d, y: 0.8867550734955075d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5630057191476001d, y: 0.008538402256408117d), new NpgsqlTypes.NpgsqlPoint(x: 0.21579386386803445d, y: 0.6202704082428451d), new NpgsqlTypes.NpgsqlPoint(x: 0.13940067175857118d, y: 0.7668059902481539d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08755077289503455d, y: 0.9036737708166375d), new NpgsqlTypes.NpgsqlPoint(x: 0.16221239986889202d, y: 0.23239968833484115d), new NpgsqlTypes.NpgsqlPoint(x: 0.0457763475284525d, y: 0.1173951232191015d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39836987667810886d, y: 0.8121568466197308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4478302629760855d, y: 0.11060338282199866d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806533762407953d, y: 0.4662666957835798d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45692513957678016d, y: 0.0709189951295881d), new NpgsqlTypes.NpgsqlPoint(x: 0.43313191348758595d, y: 0.2295423679551759d), new NpgsqlTypes.NpgsqlPoint(x: 0.7210400494794221d, y: 0.24644724430314524d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30713666520112326d, y: 0.6173735000380893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6877918055203868d, y: 0.21393676355387736d), new NpgsqlTypes.NpgsqlPoint(x: 0.572952736655171d, y: 0.4235731107511176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7984893264743428d, y: 0.5983945123453334d), new NpgsqlTypes.NpgsqlPoint(x: 0.43664015999746875d, y: 0.10477729359304977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408561961493729d, y: 0.3495805845733907d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15921465329639983d, y: 0.5839087244985256d), new NpgsqlTypes.NpgsqlPoint(x: 0.06039285205453204d, y: 0.6850776468592654d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454089180182825d, y: 0.8869720198030911d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4778218939910923d, y: 0.13283580627771585d), new NpgsqlTypes.NpgsqlPoint(x: 0.8220959429522336d, y: 0.8161615803517055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9695302652478235d, y: 0.6942898946598833d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3524843512171868d, y: 0.8147921331716147d), new NpgsqlTypes.NpgsqlPoint(x: 0.969656051183308d, y: 0.23864748815285441d), new NpgsqlTypes.NpgsqlPoint(x: 0.286276476504681d, y: 0.3140772776738261d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22717143858012545d, y: 0.40243964743426963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5263460341372324d, y: 0.8046176093825029d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972061943879481d, y: 0.562337617691539d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3944713315546512d, y: 0.3195124712126326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2317900978906322d, y: 0.42481258672713806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8946252819846567d, y: 0.12333293207757523d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2077037585126411d, y: 0.9522048398583692d), new NpgsqlTypes.NpgsqlPoint(x: 0.24441069773012458d, y: 0.32068357627718824d), new NpgsqlTypes.NpgsqlPoint(x: 0.9500485040451211d, y: 0.11592421391305607d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5674767919660197d, y: 0.032295664258959356d), new NpgsqlTypes.NpgsqlPoint(x: 0.43059854120084795d, y: 0.112592822239444d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982622304213846d, y: 0.44559868792658885d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.99142763677733d, y: 0.17969367227747068d), new NpgsqlTypes.NpgsqlPoint(x: 0.2721961569250938d, y: 0.35262664553044565d), new NpgsqlTypes.NpgsqlPoint(x: 0.665464151561722d, y: 0.9708109419725346d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6118651774183151d, y: 0.940293837072644d), new NpgsqlTypes.NpgsqlPoint(x: 0.40209232641420933d, y: 0.6540347410964129d), new NpgsqlTypes.NpgsqlPoint(x: 0.01061538435717424d, y: 0.7978472646751164d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19408302091666996d, y: 0.6777143126866515d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968720068212785d, y: 0.04083593438470301d), new NpgsqlTypes.NpgsqlPoint(x: 0.3508993957740325d, y: 0.7323713584290006d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.68800290717677d, y: 0.5724318565035703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459819623309295d, y: 0.3596137137597597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4250616845945371d, y: 0.35965516470277836d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4883428634748318d, y: 0.47685132243667183d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459362016198329d, y: 0.893983413609816d), new NpgsqlTypes.NpgsqlPoint(x: 0.10505771835550082d, y: 0.036748867292124676d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23908282896397126d, y: 0.9564510237939625d), new NpgsqlTypes.NpgsqlPoint(x: 0.0274873269563789d, y: 0.7882690271111027d), new NpgsqlTypes.NpgsqlPoint(x: 0.9972756452085626d, y: 0.34205374120963095d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4571534654783711d, y: 0.37279019850424344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4506690182347366d, y: 0.945253242870793d), new NpgsqlTypes.NpgsqlPoint(x: 0.610555823863731d, y: 0.6371656987539492d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3282990249062293d, y: 0.6667548016320995d), new NpgsqlTypes.NpgsqlPoint(x: 0.4852074070598583d, y: 0.8457465864653566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5109319516601165d, y: 0.06719673277276017d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5998121495569935d, y: 0.7299480803302179d), new NpgsqlTypes.NpgsqlPoint(x: 0.3330403094784504d, y: 0.7902788022868322d), new NpgsqlTypes.NpgsqlPoint(x: 0.1729118238406685d, y: 0.467432376238493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0027897083721013516d, y: 0.6955433090104781d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267869549731772d, y: 0.5620053013186015d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646424487586059d, y: 0.05772498712189034d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5848879800523805d, y: 0.5721909026521111d), new NpgsqlTypes.NpgsqlPoint(x: 0.2174520862528927d, y: 0.49432256740807234d), new NpgsqlTypes.NpgsqlPoint(x: 0.04988425520984452d, y: 0.5991373608315559d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5122476445684963d, y: 0.9191216105755373d), new NpgsqlTypes.NpgsqlPoint(x: 0.25398255552395854d, y: 0.1442083692449705d), new NpgsqlTypes.NpgsqlPoint(x: 0.715121637790335d, y: 0.07625997722576705d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14984547235758228d, y: 0.3246703087225624d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776367721956311d, y: 0.8062441557003002d), new NpgsqlTypes.NpgsqlPoint(x: 0.5711560132368617d, y: 0.3243347053849531d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7954296383925995d, y: 0.38791201594380476d), new NpgsqlTypes.NpgsqlPoint(x: 0.07243920059194864d, y: 0.039608582997109565d), new NpgsqlTypes.NpgsqlPoint(x: 0.568501305646354d, y: 0.060865766554522915d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8771438834776335d, y: 0.4393060932306849d), new NpgsqlTypes.NpgsqlPoint(x: 0.2359365605337881d, y: 0.3918363417244153d), new NpgsqlTypes.NpgsqlPoint(x: 0.03741752017211253d, y: 0.5380197550024738d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2440365088980896d, y: 0.8157309694711938d), new NpgsqlTypes.NpgsqlPoint(x: 0.11633666458988579d, y: 0.5615587455002986d), new NpgsqlTypes.NpgsqlPoint(x: 0.11361578152685536d, y: 0.4645268093702726d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01783552155430701d, y: 0.13059755628606962d), new NpgsqlTypes.NpgsqlPoint(x: 0.9074393708847875d, y: 0.35386687224405866d), new NpgsqlTypes.NpgsqlPoint(x: 0.22522850271777373d, y: 0.21499359555063202d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7112396748340736d, y: 0.010525754526583886d), new NpgsqlTypes.NpgsqlPoint(x: 0.895944579024827d, y: 0.3295243554616023d), new NpgsqlTypes.NpgsqlPoint(x: 0.46416732772322744d, y: 0.5628346415082587d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6451602881296411d, y: 0.12386535883295702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5540182860699074d, y: 0.5002404334112857d), new NpgsqlTypes.NpgsqlPoint(x: 0.12706087714356606d, y: 0.4108497545691384d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48347432786118494d, y: 0.17468778741334112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7698132728890092d, y: 0.8130746057740228d), new NpgsqlTypes.NpgsqlPoint(x: 0.6550140625237182d, y: 0.23528424914675283d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10571108496500614d, y: 0.3548450871527874d), new NpgsqlTypes.NpgsqlPoint(x: 0.256993297090222d, y: 0.6617496188397355d), new NpgsqlTypes.NpgsqlPoint(x: 0.8924758977235518d, y: 0.759675284971121d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.923373110409826d, y: 0.6105592999520949d), new NpgsqlTypes.NpgsqlPoint(x: 0.23234017490957493d, y: 0.3322920540119456d), new NpgsqlTypes.NpgsqlPoint(x: 0.9579363896132083d, y: 0.3186212568576201d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8610088933567971d, y: 0.7413391821493664d), new NpgsqlTypes.NpgsqlPoint(x: 0.18949070519067557d, y: 0.16148433564638365d), new NpgsqlTypes.NpgsqlPoint(x: 0.24424969592499368d, y: 0.6476313830962223d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8571036798815946d, y: 0.817620765074808d), new NpgsqlTypes.NpgsqlPoint(x: 0.5055055388943981d, y: 0.6341059454120894d), new NpgsqlTypes.NpgsqlPoint(x: 0.43584479503514373d, y: 0.9704592989277928d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07637176133214452d, y: 0.1818241515134087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8244392492536525d, y: 0.22570448749216376d), new NpgsqlTypes.NpgsqlPoint(x: 0.36088561937143304d, y: 0.06286358501416112d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1469438650021926d, y: 0.6146292228906015d), new NpgsqlTypes.NpgsqlPoint(x: 0.24916835797852988d, y: 0.7391502778826711d), new NpgsqlTypes.NpgsqlPoint(x: 0.4536368974996273d, y: 0.22130653109279952d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7692201044017245d, y: 0.4276005930859925d), new NpgsqlTypes.NpgsqlPoint(x: 0.4694175867599846d, y: 0.7971999801663625d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462607713338619d, y: 0.9191530449391858d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4748754310237917d, y: 0.7933860091451223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7738241071261452d, y: 0.19680058410602064d), new NpgsqlTypes.NpgsqlPoint(x: 0.8316791069699065d, y: 0.44944605140929206d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.402102183130144d, y: 0.32002265143386d), new NpgsqlTypes.NpgsqlPoint(x: 0.17574421066028534d, y: 0.7502715565593648d), new NpgsqlTypes.NpgsqlPoint(x: 0.1549769047345123d, y: 0.8109533286183696d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6329646798843946d, y: 0.5941782881447899d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836601557604651d, y: 0.04510492370462926d), new NpgsqlTypes.NpgsqlPoint(x: 0.0917548941737999d, y: 0.5387813673185058d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4104862617523196d, y: 0.5581212292130361d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603434196499572d, y: 0.7200319415962059d), new NpgsqlTypes.NpgsqlPoint(x: 0.2703381240480429d, y: 0.4897840427398147d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8140270067217291d, y: 0.9718955346587235d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281971076295456d, y: 0.1956205101093217d), new NpgsqlTypes.NpgsqlPoint(x: 0.4963993344828641d, y: 0.2588701281053184d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08566408069440401d, y: 0.26195560054782085d), new NpgsqlTypes.NpgsqlPoint(x: 0.5053865250146984d, y: 0.752551793086947d), new NpgsqlTypes.NpgsqlPoint(x: 0.5828574639666126d, y: 0.9191614635680262d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26085890313837856d, y: 0.22063418994954698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5137902730610703d, y: 0.0765514722885633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6205621151301334d, y: 0.9548787381865278d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7304787960794599d, y: 0.24115084232065365d), new NpgsqlTypes.NpgsqlPoint(x: 0.15987904886920867d, y: 0.4934500699986196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7240913009674301d, y: 0.3063306187091206d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8471155164374273d, y: 0.35746652719824423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4431593397625534d, y: 0.41710605493320907d), new NpgsqlTypes.NpgsqlPoint(x: 0.27392267822632166d, y: 0.9797826301713575d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7281746642064115d, y: 0.8427452178777102d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492800329912118d, y: 0.7138916880870908d), new NpgsqlTypes.NpgsqlPoint(x: 0.616833433916571d, y: 0.5295362474689822d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5242858435739216d, y: 0.36499307537050485d), new NpgsqlTypes.NpgsqlPoint(x: 0.5630022433427685d, y: 0.08857726126620524d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254671483887683d, y: 0.35320628740863147d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18139672708670962d, y: 0.6074298776872921d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517803779603537d, y: 0.45958626286939586d), new NpgsqlTypes.NpgsqlPoint(x: 0.776074165832283d, y: 0.5147768067458083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02833727275156417d, y: 0.3404328397065839d), new NpgsqlTypes.NpgsqlPoint(x: 0.3881706265091802d, y: 0.6235184893769343d), new NpgsqlTypes.NpgsqlPoint(x: 0.02655124082877247d, y: 0.7206879933548191d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0862686371082837d, y: 0.5213322533476024d), new NpgsqlTypes.NpgsqlPoint(x: 0.9834026967448156d, y: 0.3386928811906581d), new NpgsqlTypes.NpgsqlPoint(x: 0.18822406951575454d, y: 0.31146709865067146d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1495993792714555d, y: 0.8313099877517767d), new NpgsqlTypes.NpgsqlPoint(x: 0.579321138803261d, y: 0.06530992892088783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5523347342689011d, y: 0.6996131997953379d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2697704649799547d, y: 0.05194386294373654d), new NpgsqlTypes.NpgsqlPoint(x: 0.16243629564757023d, y: 0.23038410696683298d), new NpgsqlTypes.NpgsqlPoint(x: 0.37526578747856354d, y: 0.16504746239825852d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3890371728229639d, y: 0.39287349647679726d), new NpgsqlTypes.NpgsqlPoint(x: 0.3498589375833008d, y: 0.6255523985711638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9839973054774266d, y: 0.7300898584292771d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31657144018261263d, y: 0.00208817211411938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5743505270907813d, y: 0.1058558223802718d), new NpgsqlTypes.NpgsqlPoint(x: 0.34158305388474297d, y: 0.011421401349692606d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46747471628596804d, y: 0.6619583587542381d), new NpgsqlTypes.NpgsqlPoint(x: 0.8783963811920646d, y: 0.4331506927297345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8518596614076784d, y: 0.1768452431593056d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6495928800724836d, y: 0.7354513226421056d), new NpgsqlTypes.NpgsqlPoint(x: 0.9388363046058118d, y: 0.752537033270206d), new NpgsqlTypes.NpgsqlPoint(x: 0.46757178040411207d, y: 0.479498392116918d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06444031702739528d, y: 0.7832504386910076d), new NpgsqlTypes.NpgsqlPoint(x: 0.40957031632655816d, y: 0.34960612823188275d), new NpgsqlTypes.NpgsqlPoint(x: 0.05957379934788909d, y: 0.0801667862850548d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7021247589800542d, y: 0.8874040211695333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559892841724172d, y: 0.42865173135490897d), new NpgsqlTypes.NpgsqlPoint(x: 0.2355879935760895d, y: 0.1761019698358688d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06965777195825085d, y: 0.5167916941802914d), new NpgsqlTypes.NpgsqlPoint(x: 0.43623186723080265d, y: 0.08585068788835826d), new NpgsqlTypes.NpgsqlPoint(x: 0.582804545027723d, y: 0.9714990907757844d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.036234057761873606d, y: 0.823943577651665d), new NpgsqlTypes.NpgsqlPoint(x: 7.620972008259841E-05d, y: 0.5422758233867484d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022170303517761d, y: 0.931494254298222d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6796258880641826d, y: 0.9397700685875471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149689313934509d, y: 0.320099548300538d), new NpgsqlTypes.NpgsqlPoint(x: 0.4447997521208211d, y: 0.3752297105817993d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2075334524387612d, y: 0.7875473231454222d), new NpgsqlTypes.NpgsqlPoint(x: 0.8742359257772223d, y: 0.8353762053893685d), new NpgsqlTypes.NpgsqlPoint(x: 0.17393027160865882d, y: 0.27180175070248347d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6867203688288304d, y: 0.5376401973044176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882659432123009d, y: 0.3998535651377615d), new NpgsqlTypes.NpgsqlPoint(x: 0.21359966470757397d, y: 0.19080937840732104d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15245320099381865d, y: 0.8407321740752267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521760530528479d, y: 0.8176419553453235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330775847181625d, y: 0.9127440298866282d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4449498106539128d, y: 0.9669425778530919d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726312496331194d, y: 0.8213056862648512d), new NpgsqlTypes.NpgsqlPoint(x: 0.17666811694224938d, y: 0.394834172187036d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02968703235734671d, y: 0.5318004732443565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701180577996875d, y: 0.5933244799456187d), new NpgsqlTypes.NpgsqlPoint(x: 0.2022302365240638d, y: 0.806291347899914d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13251387624196476d, y: 0.4807116512306845d), new NpgsqlTypes.NpgsqlPoint(x: 0.1165187693756028d, y: 0.8204511517443287d), new NpgsqlTypes.NpgsqlPoint(x: 0.24331189158748967d, y: 0.36761655551874517d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5335180605525794d, y: 0.1345276678081656d), new NpgsqlTypes.NpgsqlPoint(x: 0.7490037855136072d, y: 0.5937123192105801d), new NpgsqlTypes.NpgsqlPoint(x: 0.1268452464523382d, y: 0.9514190987636544d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3735360228351555d, y: 0.21046189043588848d), new NpgsqlTypes.NpgsqlPoint(x: 0.48373037142542774d, y: 0.955842360789375d), new NpgsqlTypes.NpgsqlPoint(x: 0.790074292470509d, y: 0.7094315523282876d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03392316722188404d, y: 0.0572705141740798d), new NpgsqlTypes.NpgsqlPoint(x: 0.11256827057765617d, y: 0.8394455741197399d), new NpgsqlTypes.NpgsqlPoint(x: 0.523218115550269d, y: 0.7580111066195091d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31578081558547666d, y: 0.4007977509763089d), new NpgsqlTypes.NpgsqlPoint(x: 0.39638592338215706d, y: 0.7705489842767723d), new NpgsqlTypes.NpgsqlPoint(x: 0.904004886726212d, y: 0.12231248818292284d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6275470022641112d, y: 0.9321024462605688d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508538424645403d, y: 0.6899927229911794d), new NpgsqlTypes.NpgsqlPoint(x: 0.025942585263339257d, y: 0.6716059401516865d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02923972169208744d, y: 0.5118963926095836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4541002633459017d, y: 0.9797691093904142d), new NpgsqlTypes.NpgsqlPoint(x: 0.2338016016032024d, y: 0.6531237809005518d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5349049193213036d, y: 0.3502130446373869d), new NpgsqlTypes.NpgsqlPoint(x: 0.21375626724019903d, y: 0.5083072562400799d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400664521557094d, y: 0.6432102018513763d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4620238841504397d, y: 0.7575532956584901d), new NpgsqlTypes.NpgsqlPoint(x: 0.4897428171696958d, y: 0.6657979113981624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5107187748695078d, y: 0.23550400518040338d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4238905895695406d, y: 0.05977064733083037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5923198908667949d, y: 0.980816921520826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730604354361988d, y: 0.1303313313015163d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8885336999318858d, y: 0.09932421175341766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868870076634258d, y: 0.1296253108534391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4020385676875866d, y: 0.9013855245130767d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42543581709880673d, y: 0.47179766206420526d), new NpgsqlTypes.NpgsqlPoint(x: 0.41247432580251564d, y: 0.4125294771978858d), new NpgsqlTypes.NpgsqlPoint(x: 0.570361941090321d, y: 0.42952209479718995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6801056065337214d, y: 0.018250860552251114d), new NpgsqlTypes.NpgsqlPoint(x: 0.45064201926633163d, y: 0.3779725613898365d), new NpgsqlTypes.NpgsqlPoint(x: 0.6692810285465377d, y: 0.4861190653118441d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.610685881716074d, y: 0.6507352453154771d), new NpgsqlTypes.NpgsqlPoint(x: 0.9981012891374037d, y: 0.2731085727895932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7632169809304783d, y: 0.5775306697894428d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06336777863140486d, y: 0.7812441028226185d), new NpgsqlTypes.NpgsqlPoint(x: 0.26719279882313873d, y: 0.3193139063960527d), new NpgsqlTypes.NpgsqlPoint(x: 0.4659135376228082d, y: 0.012230841306831497d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.733885095887471d, y: 0.5453633432609979d), new NpgsqlTypes.NpgsqlPoint(x: 0.20692400960863533d, y: 0.5126975402635251d), new NpgsqlTypes.NpgsqlPoint(x: 0.005074924077314913d, y: 0.7778689928598683d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5399819675890736d, y: 0.9154236263829908d), new NpgsqlTypes.NpgsqlPoint(x: 0.11293829517211373d, y: 0.9474190801026525d), new NpgsqlTypes.NpgsqlPoint(x: 0.03074840607557716d, y: 0.5635168489140095d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8436976594501314d, y: 0.9626437604895973d), new NpgsqlTypes.NpgsqlPoint(x: 0.12158071419394512d, y: 0.8787899911260536d), new NpgsqlTypes.NpgsqlPoint(x: 0.3373197027424254d, y: 0.8004737652000218d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9820598747909057d, y: 0.6758846966650947d), new NpgsqlTypes.NpgsqlPoint(x: 0.6725128294242306d, y: 0.05285295890161068d), new NpgsqlTypes.NpgsqlPoint(x: 0.7634787308176184d, y: 0.02831072875864904d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19926719259844283d, y: 0.29996864667560597d), new NpgsqlTypes.NpgsqlPoint(x: 0.6551064245403633d, y: 0.5609268018983216d), new NpgsqlTypes.NpgsqlPoint(x: 0.09241094043336262d, y: 0.5438802033237309d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3786098411390886d, y: 0.3221462036064223d), new NpgsqlTypes.NpgsqlPoint(x: 0.5099760862278536d, y: 0.7799253062698737d), new NpgsqlTypes.NpgsqlPoint(x: 0.03570253192472839d, y: 0.4000777654870502d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5302681791556337d, y: 0.6334809173719576d), new NpgsqlTypes.NpgsqlPoint(x: 0.23542383689100665d, y: 0.08424067730175278d), new NpgsqlTypes.NpgsqlPoint(x: 0.22096927175726433d, y: 0.051100454735660716d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32864450754741026d, y: 0.10725031146481956d), new NpgsqlTypes.NpgsqlPoint(x: 0.1045586685080252d, y: 0.3152449477023952d), new NpgsqlTypes.NpgsqlPoint(x: 0.14918991105013601d, y: 0.8482903987151158d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0323910420433694d, y: 0.3583583431724987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8084413206413347d, y: 0.5329305634125661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6527246583024501d, y: 0.0322338552471636d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04272900925653489d, y: 0.22310970641207095d), new NpgsqlTypes.NpgsqlPoint(x: 0.07788726849055572d, y: 0.6693703195388897d), new NpgsqlTypes.NpgsqlPoint(x: 0.4096428232514203d, y: 0.6974476694632997d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6373151318454767d, y: 0.8904884834104451d), new NpgsqlTypes.NpgsqlPoint(x: 0.23122722987792876d, y: 0.4439679198634513d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324586755669807d, y: 0.7315409336313465d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16566260510105046d, y: 0.574963176516062d), new NpgsqlTypes.NpgsqlPoint(x: 0.6717807222735444d, y: 0.08482548650910804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3672045852113325d, y: 0.733858933310814d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.048193089876596096d, y: 0.8399683020020237d), new NpgsqlTypes.NpgsqlPoint(x: 0.40467720859202827d, y: 0.03187844620871527d), new NpgsqlTypes.NpgsqlPoint(x: 0.19617967089464705d, y: 0.651067399058936d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2561772054891238d, y: 0.27247353845025135d), new NpgsqlTypes.NpgsqlPoint(x: 0.307743073844126d, y: 0.8530960598397986d), new NpgsqlTypes.NpgsqlPoint(x: 0.2837782645617284d, y: 0.1009172384041801d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2086945876912022d, y: 0.5419479558707935d), new NpgsqlTypes.NpgsqlPoint(x: 0.7454733782794895d, y: 0.5022571156350067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206679978740803d, y: 0.6715026998085039d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20597841519181792d, y: 0.35178982131876546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7383618185118125d, y: 0.6119390828530649d), new NpgsqlTypes.NpgsqlPoint(x: 0.7867274433930661d, y: 0.17533187601808886d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5479976666174416d, y: 0.36884354656663876d), new NpgsqlTypes.NpgsqlPoint(x: 0.1310781207049747d, y: 0.22408757574592142d), new NpgsqlTypes.NpgsqlPoint(x: 0.5156867587029843d, y: 0.8667253440172521d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3616432803064963d, y: 0.6097795679875336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249152146573351d, y: 0.4457226863671532d), new NpgsqlTypes.NpgsqlPoint(x: 0.36842139789499995d, y: 0.7591425916795684d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.001150150861786714d, y: 0.6174850146462673d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011649470124032169d, y: 0.3312226177367076d), new NpgsqlTypes.NpgsqlPoint(x: 0.911982020983607d, y: 0.05688931264021424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8144763402894731d, y: 0.40263322327648143d), new NpgsqlTypes.NpgsqlPoint(x: 0.778923854980393d, y: 0.17745419529942696d), new NpgsqlTypes.NpgsqlPoint(x: 0.08289283264461544d, y: 0.7676001868154375d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4938785567609285d, y: 0.9393780259582813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7652587081113263d, y: 0.6726766485722301d), new NpgsqlTypes.NpgsqlPoint(x: 0.534696649079304d, y: 0.980534172248995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7629600438917785d, y: 0.6904760767511323d), new NpgsqlTypes.NpgsqlPoint(x: 0.4303041741197561d, y: 0.21499931768660707d), new NpgsqlTypes.NpgsqlPoint(x: 0.46607674932224163d, y: 0.25417547113363725d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14353445167493484d, y: 0.6758546748603022d), new NpgsqlTypes.NpgsqlPoint(x: 0.7590855454603657d, y: 0.7629023368678328d), new NpgsqlTypes.NpgsqlPoint(x: 0.7190988169240099d, y: 0.2500452590130453d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7390141498607589d, y: 0.06949107197702586d), new NpgsqlTypes.NpgsqlPoint(x: 0.49805166786876187d, y: 0.4897858553566322d), new NpgsqlTypes.NpgsqlPoint(x: 0.3077206763894619d, y: 0.28674026895618354d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08276785293749378d, y: 0.8410154649912986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030788151840926d, y: 0.20313003089911197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9990127076168533d, y: 0.8305166517432623d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38159440164000424d, y: 0.39529722160364333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8067007173937168d, y: 0.5624760189034215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141477376742056d, y: 0.5160847895495844d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6890688266097417d, y: 0.2486142482933924d), new NpgsqlTypes.NpgsqlPoint(x: 0.19721617224596566d, y: 0.4596765038699555d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507138502438637d, y: 0.6338497443202554d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.051912610783148905d, y: 0.14372108647333293d), new NpgsqlTypes.NpgsqlPoint(x: 0.34794545431045965d, y: 0.30042964766311064d), new NpgsqlTypes.NpgsqlPoint(x: 0.11475044955796831d, y: 0.7541047642658933d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19028891044080753d, y: 0.9842133809277012d), new NpgsqlTypes.NpgsqlPoint(x: 0.15530735611688717d, y: 0.22779762927588543d), new NpgsqlTypes.NpgsqlPoint(x: 0.23794173217258285d, y: 0.7672243466124528d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47601899068254505d, y: 0.01657824992175494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840637038059372d, y: 0.4783386379780752d), new NpgsqlTypes.NpgsqlPoint(x: 0.199497892510074d, y: 0.09254755973877282d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7322270898552079d, y: 0.4285415607371108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6351468680788269d, y: 0.30451141744262356d), new NpgsqlTypes.NpgsqlPoint(x: 0.10586924690844324d, y: 0.31074280199437243d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6355750485187941d, y: 0.8275948171132325d), new NpgsqlTypes.NpgsqlPoint(x: 0.006877466899578133d, y: 0.09864622222065422d), new NpgsqlTypes.NpgsqlPoint(x: 0.7099607915831386d, y: 0.08141234572790002d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5646008027785857d, y: 0.39035474974903295d), new NpgsqlTypes.NpgsqlPoint(x: 0.020335214541242652d, y: 0.2611849564703136d), new NpgsqlTypes.NpgsqlPoint(x: 0.901413798778821d, y: 0.7724123822128615d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4512854596852459d, y: 0.6382969895065507d), new NpgsqlTypes.NpgsqlPoint(x: 0.2166475747072153d, y: 0.6736664586475115d), new NpgsqlTypes.NpgsqlPoint(x: 0.9733354389306312d, y: 0.6031428266663851d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6283131730120625d, y: 0.264028715377696d), new NpgsqlTypes.NpgsqlPoint(x: 0.5339086259381468d, y: 0.617602005072186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8015011495786084d, y: 0.05186060176018514d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3800252278145264d, y: 0.22284652036806563d), new NpgsqlTypes.NpgsqlPoint(x: 0.006427937565927744d, y: 0.3955407996365832d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138130988853822d, y: 0.3979040346665198d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6857998894583783d, y: 0.5577177442710903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5554889902292036d, y: 0.4822371888331991d), new NpgsqlTypes.NpgsqlPoint(x: 0.23127117160117083d, y: 0.9348867268852912d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7957490862722748d, y: 0.49222113089162756d), new NpgsqlTypes.NpgsqlPoint(x: 0.9153002024696276d, y: 0.6292167103381815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6837816123383245d, y: 0.9678261050643207d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729939203714636d, y: 0.9625038467609978d), new NpgsqlTypes.NpgsqlPoint(x: 0.5382400125026626d, y: 0.13884600243171563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8418084203525609d, y: 0.12011648926565599d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7760295277909668d, y: 0.18096550556724644d), new NpgsqlTypes.NpgsqlPoint(x: 0.2896921410474249d, y: 0.2542374819821137d), new NpgsqlTypes.NpgsqlPoint(x: 0.4501155984032996d, y: 0.28856579161730134d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13978732217853318d, y: 0.964408722533661d), new NpgsqlTypes.NpgsqlPoint(x: 0.36568221730303263d, y: 0.5638731348826317d), new NpgsqlTypes.NpgsqlPoint(x: 0.3549477025976565d, y: 0.38289985977867125d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43711484995909244d, y: 0.7117276693270784d), new NpgsqlTypes.NpgsqlPoint(x: 0.037874910295274455d, y: 0.8422762493550147d), new NpgsqlTypes.NpgsqlPoint(x: 0.4178778135704827d, y: 0.26441568685907624d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.986854264857727d, y: 0.881940951610448d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537638414438664d, y: 0.3528405910225424d), new NpgsqlTypes.NpgsqlPoint(x: 0.708172914326827d, y: 0.9892540316804288d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4580894410183407d, y: 0.816745615721056d), new NpgsqlTypes.NpgsqlPoint(x: 0.43478928807449757d, y: 0.39753098105802287d), new NpgsqlTypes.NpgsqlPoint(x: 0.05302704995466734d, y: 0.007027887889760054d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1301220381563537d, y: 0.10692666889980051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8743731069350312d, y: 0.8541977447366136d), new NpgsqlTypes.NpgsqlPoint(x: 0.05728577384868028d, y: 0.8813571436959051d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.785125039903161d, y: 0.5810537640741396d), new NpgsqlTypes.NpgsqlPoint(x: 0.9051563724335278d, y: 0.4202025645681293d), new NpgsqlTypes.NpgsqlPoint(x: 0.20323300007865064d, y: 0.21586342094159416d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5890661912843143d, y: 0.7366354435086749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3240685952128215d, y: 0.5706822866027889d), new NpgsqlTypes.NpgsqlPoint(x: 0.12379400984752731d, y: 0.3031972250023436d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4319443025218457d, y: 0.2658231489949302d), new NpgsqlTypes.NpgsqlPoint(x: 0.4479928416120331d, y: 0.6855010005109058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8207108727190265d, y: 0.9752229643267913d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3351279649932256d, y: 0.6707984629946755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3180002820506994d, y: 0.6107458633320673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545858483411103d, y: 0.1431878416943717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7845590836952477d, y: 0.014646817148438296d), new NpgsqlTypes.NpgsqlPoint(x: 0.6698735509296723d, y: 0.9128187697404307d), new NpgsqlTypes.NpgsqlPoint(x: 0.1992723754357416d, y: 0.009609566967082483d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904647560720811d, y: 0.5000781353452163d), new NpgsqlTypes.NpgsqlPoint(x: 0.8762896796207605d, y: 0.9507380689979544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3572468405419884d, y: 0.5543663949687717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6931995463874744d, y: 0.8985428656593708d), new NpgsqlTypes.NpgsqlPoint(x: 0.6392171085528128d, y: 0.7427840909488137d), new NpgsqlTypes.NpgsqlPoint(x: 0.37007245460735516d, y: 0.3744272411959534d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7187520586884151d, y: 0.18106010115159066d), new NpgsqlTypes.NpgsqlPoint(x: 0.3017186698718336d, y: 0.6359590355047069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5218496817100133d, y: 0.6257779283969264d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4860538468767205d, y: 0.5310521519841361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995571316478012d, y: 0.35505661955104795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850664716127378d, y: 0.9507325725767785d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2079093947324221d, y: 0.575980289659272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6997847808659947d, y: 0.8652175279869043d), new NpgsqlTypes.NpgsqlPoint(x: 0.8048550308993296d, y: 0.698318088236845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27955066559225805d, y: 0.8567750243933887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7276403866062681d, y: 0.20452095765020617d), new NpgsqlTypes.NpgsqlPoint(x: 0.84210023173626d, y: 0.1915701801136117d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0899772487090379d, y: 0.7830388013839571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5341506953023527d, y: 0.9034218328242387d), new NpgsqlTypes.NpgsqlPoint(x: 0.1423086563970155d, y: 0.8893934384733795d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34616670089048307d, y: 0.6489555308040936d), new NpgsqlTypes.NpgsqlPoint(x: 0.8205939644418553d, y: 0.3074956344044981d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638554408713844d, y: 0.879533423046685d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10633175295895203d, y: 0.6689773986688375d), new NpgsqlTypes.NpgsqlPoint(x: 0.717090494449457d, y: 0.06056300210367904d), new NpgsqlTypes.NpgsqlPoint(x: 0.972411968964999d, y: 0.07211349892100749d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6309630083448022d, y: 0.9295717111382661d), new NpgsqlTypes.NpgsqlPoint(x: 0.8003469085863422d, y: 0.1473684368078949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8144420321782865d, y: 0.008613929577733992d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33122771244263216d, y: 0.14771423808993966d), new NpgsqlTypes.NpgsqlPoint(x: 0.25808712391282385d, y: 0.22635476155863632d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815926843031542d, y: 0.44003361147915365d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4209583073564086d, y: 0.9161552658620427d), new NpgsqlTypes.NpgsqlPoint(x: 0.265620554400675d, y: 0.8429325246765385d), new NpgsqlTypes.NpgsqlPoint(x: 0.002495385007313833d, y: 0.12095196912670314d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36836492422215994d, y: 0.1903155929851298d), new NpgsqlTypes.NpgsqlPoint(x: 0.745172914331691d, y: 0.4674881208630822d), new NpgsqlTypes.NpgsqlPoint(x: 0.751906599739636d, y: 0.47841618262961105d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6306244496536457d, y: 0.34350627511519116d), new NpgsqlTypes.NpgsqlPoint(x: 0.04237715135512343d, y: 0.7599595923608238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9973449106158163d, y: 0.5135020941118797d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3824841051681259d, y: 0.08972848806583278d), new NpgsqlTypes.NpgsqlPoint(x: 0.3148357012502737d, y: 0.0007144407527952534d), new NpgsqlTypes.NpgsqlPoint(x: 0.7036964416469313d, y: 0.5528447968258909d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23150939121383118d, y: 0.7955694026711229d), new NpgsqlTypes.NpgsqlPoint(x: 0.8221505950780379d, y: 0.8634537437362815d), new NpgsqlTypes.NpgsqlPoint(x: 0.03852452769876369d, y: 0.5605050132910903d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8006980492991469d, y: 0.8718662928574509d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590859797729772d, y: 0.2585511100107504d), new NpgsqlTypes.NpgsqlPoint(x: 0.7995598585463372d, y: 0.155697028859761d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022183648752675977d, y: 0.24830024455416666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231612416274965d, y: 0.33956281021833545d), new NpgsqlTypes.NpgsqlPoint(x: 0.8099519758128324d, y: 0.046568930314925816d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06391746106724949d, y: 0.9066806975341972d), new NpgsqlTypes.NpgsqlPoint(x: 0.20317128296348208d, y: 0.3619733033271899d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335024669590098d, y: 0.21019140943961978d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5502105791144399d, y: 0.19623201986032235d), new NpgsqlTypes.NpgsqlPoint(x: 0.76307567032402d, y: 0.12088100880850239d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374152896039553d, y: 0.947408124513077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05725678794830691d, y: 0.0485180993552462d), new NpgsqlTypes.NpgsqlPoint(x: 0.3766922380378589d, y: 0.14839140916031734d), new NpgsqlTypes.NpgsqlPoint(x: 0.901176073301318d, y: 0.06381720460592932d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4586759583363875d, y: 0.22775231744934077d), new NpgsqlTypes.NpgsqlPoint(x: 0.4619341087549531d, y: 0.32458442413150335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6433498674277588d, y: 0.5530577266165808d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20906080748597167d, y: 0.4899660276158987d), new NpgsqlTypes.NpgsqlPoint(x: 0.24805106212575634d, y: 0.23767269442595906d), new NpgsqlTypes.NpgsqlPoint(x: 0.21791904896096082d, y: 0.702874467233616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5552245968559614d, y: 0.032752299264886875d), new NpgsqlTypes.NpgsqlPoint(x: 0.9204725185658832d, y: 0.874093349685774d), new NpgsqlTypes.NpgsqlPoint(x: 0.7061932861991167d, y: 0.337889145899269d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8822096483242383d, y: 0.6842569783054954d), new NpgsqlTypes.NpgsqlPoint(x: 0.2597899589800101d, y: 0.03321043792469758d), new NpgsqlTypes.NpgsqlPoint(x: 0.6953550249993469d, y: 0.7912563615143987d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759615343485692d, y: 0.47023652040027464d), new NpgsqlTypes.NpgsqlPoint(x: 0.8468104259790332d, y: 0.01972613457995076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6792079920796057d, y: 0.3989318657576396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08006256779461518d, y: 0.6274030530825224d), new NpgsqlTypes.NpgsqlPoint(x: 0.7735298880955872d, y: 0.49934463980647803d), new NpgsqlTypes.NpgsqlPoint(x: 0.8252962572565847d, y: 0.00831518030603573d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.885218561424365d, y: 0.8202890057879428d), new NpgsqlTypes.NpgsqlPoint(x: 0.626761167183143d, y: 0.5811056615112397d), new NpgsqlTypes.NpgsqlPoint(x: 0.789633040684314d, y: 0.5678859832295007d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08307935471084571d, y: 0.43156513605263225d), new NpgsqlTypes.NpgsqlPoint(x: 0.1756656843580956d, y: 0.5210952889754091d), new NpgsqlTypes.NpgsqlPoint(x: 0.9002954907892834d, y: 0.7780782653523648d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20383434005141754d, y: 0.7204670412175294d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026823800821388d, y: 0.6432037915976158d), new NpgsqlTypes.NpgsqlPoint(x: 0.49515853928945786d, y: 0.9919138513155379d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12507060412117854d, y: 0.9916599576862993d), new NpgsqlTypes.NpgsqlPoint(x: 0.9923116657386698d, y: 0.9848772978104405d), new NpgsqlTypes.NpgsqlPoint(x: 0.6889891242917134d, y: 0.8529368603373512d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0819742257677667d, y: 0.43856194047693897d), new NpgsqlTypes.NpgsqlPoint(x: 0.1777090059786105d, y: 0.3173682823591001d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290159905440177d, y: 0.48969310781761843d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5677286218402909d, y: 0.08306594505120601d), new NpgsqlTypes.NpgsqlPoint(x: 0.9994648433424625d, y: 0.2621402258810417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9735618814660622d, y: 0.3622411073611821d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07477495897296493d, y: 0.47400702257675564d), new NpgsqlTypes.NpgsqlPoint(x: 0.8324850258442681d, y: 0.8029529740091281d), new NpgsqlTypes.NpgsqlPoint(x: 0.496548008702447d, y: 0.7897240851224007d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162496422858931d, y: 0.050536197923811255d), new NpgsqlTypes.NpgsqlPoint(x: 0.17107282917883815d, y: 0.3215202607518014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9818478192068645d, y: 0.938256767049115d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17598824813249958d, y: 0.7931404739764399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274928705167937d, y: 0.9982203338331194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5635947488115663d, y: 0.5118850218096861d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5171301860806098d, y: 0.6040554538628926d), new NpgsqlTypes.NpgsqlPoint(x: 0.34662987775250464d, y: 0.19342096283859922d), new NpgsqlTypes.NpgsqlPoint(x: 0.9941200344530027d, y: 0.6455820602805041d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.595525502301644d, y: 0.5062472098327229d), new NpgsqlTypes.NpgsqlPoint(x: 0.6177332566301901d, y: 0.4951408587517223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361034653608577d, y: 0.8473013113710071d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20680076910157785d, y: 0.002811155355276984d), new NpgsqlTypes.NpgsqlPoint(x: 0.31015701036621457d, y: 0.6665009361477624d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034803686336358d, y: 0.5736466837671309d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18697100248449738d, y: 0.6699795435310347d), new NpgsqlTypes.NpgsqlPoint(x: 0.2769403687415246d, y: 0.4085859650729382d), new NpgsqlTypes.NpgsqlPoint(x: 0.2175182849136995d, y: 0.2559292730201361d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10333063585879265d, y: 0.654953321648854d), new NpgsqlTypes.NpgsqlPoint(x: 0.27602663120115944d, y: 0.78363557251785d), new NpgsqlTypes.NpgsqlPoint(x: 0.802223664943308d, y: 0.8336916574105762d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3253554962393701d, y: 0.5139396685800314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6946912746050765d, y: 0.9947004219506997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853646175708959d, y: 0.7824915491847916d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9716273180686947d, y: 0.48433734483531365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3724020256744589d, y: 0.7200774829568157d), new NpgsqlTypes.NpgsqlPoint(x: 0.4301437471952655d, y: 0.07680163734323608d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9882290553935476d, y: 0.08454956341129827d), new NpgsqlTypes.NpgsqlPoint(x: 0.26043781592076753d, y: 0.07154309863569819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486327640918313d, y: 0.2849623571065333d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5201493581576168d, y: 0.46870007608512676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8062773405739971d, y: 0.10868146371412457d), new NpgsqlTypes.NpgsqlPoint(x: 0.0812287269169012d, y: 0.9961492317746645d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7826470488969162d, y: 0.5998985988037467d), new NpgsqlTypes.NpgsqlPoint(x: 0.5726502501448093d, y: 0.9180560996307042d), new NpgsqlTypes.NpgsqlPoint(x: 0.8756569663522833d, y: 0.0795863409324562d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6839669714260915d, y: 0.32316254849850756d), new NpgsqlTypes.NpgsqlPoint(x: 0.1984236151051253d, y: 0.7826245412625723d), new NpgsqlTypes.NpgsqlPoint(x: 0.26802969582074654d, y: 0.059480207032716725d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8141579315287412d, y: 0.0005697943588974796d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624923616891264d, y: 0.23402406184919533d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049703755933354d, y: 0.17928800971086734d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4174863359622233d, y: 0.7486437845216121d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746071840683463d, y: 0.77137744221979d), new NpgsqlTypes.NpgsqlPoint(x: 0.35570426132558297d, y: 0.54935786671708d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5044738927669339d, y: 0.44136516918358837d), new NpgsqlTypes.NpgsqlPoint(x: 0.15247699696488448d, y: 0.4719426740101299d), new NpgsqlTypes.NpgsqlPoint(x: 0.21911400201660303d, y: 0.770102110112791d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3112807847221418d, y: 0.3485018230534682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5103725025230674d, y: 0.9304606783979812d), new NpgsqlTypes.NpgsqlPoint(x: 0.7031685060477706d, y: 0.7740557831450926d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28149523262677945d, y: 0.2611615738980331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3141064049158291d, y: 0.5327054960937995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770540597924931d, y: 0.05721961772014228d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1162514773091512d, y: 0.44395407678628906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123118249077875d, y: 0.7387397520238652d), new NpgsqlTypes.NpgsqlPoint(x: 0.14871639316169805d, y: 0.6182479476777268d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8933332144498088d, y: 0.5935149514751048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851396517527562d, y: 0.048285888388460596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140479858670382d, y: 0.174407560214644d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6058148983080862d, y: 0.4860955742282217d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648273195942095d, y: 0.32909570767642293d), new NpgsqlTypes.NpgsqlPoint(x: 0.09143801656488604d, y: 0.5587832262339449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15908406425952182d, y: 0.5841187231486092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6421567297037615d, y: 0.7960989121796693d), new NpgsqlTypes.NpgsqlPoint(x: 0.33257634508862466d, y: 0.8738554082941771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7481258974211369d, y: 0.6587658421840616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955856730076821d, y: 0.17324881682723636d), new NpgsqlTypes.NpgsqlPoint(x: 0.27985032224260875d, y: 0.18897572274973107d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6013457612769821d, y: 0.8229956714438526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102049488970589d, y: 0.47991876144977885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5088047490131674d, y: 0.0291649595830894d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20842591502855545d, y: 0.6772076731521213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261730225428016d, y: 0.22184449171198317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654848776698838d, y: 0.06567547510000493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4070928405383093d, y: 0.9325540410999752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2370039919380421d, y: 0.13173570104248078d), new NpgsqlTypes.NpgsqlPoint(x: 0.16923545985491317d, y: 0.8546111612861906d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06972767619456444d, y: 0.8115939197791587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519724985817096d, y: 0.7017846556640157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624861708685672d, y: 0.7439716118613776d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33339712777932506d, y: 0.8445702036116319d), new NpgsqlTypes.NpgsqlPoint(x: 0.0726768828255584d, y: 0.23630353747366528d), new NpgsqlTypes.NpgsqlPoint(x: 0.0867351286873731d, y: 0.9905880760888339d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5685448533171873d, y: 0.7189313961734414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356187575865189d, y: 0.6972399295284224d), new NpgsqlTypes.NpgsqlPoint(x: 0.40359929139905004d, y: 0.5502186885373096d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.043344996662584956d, y: 0.8166189445435629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793423233657491d, y: 0.3530875831505351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009980606961932d, y: 0.6419430905931576d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11120516781769163d, y: 0.9494686476191485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196614689793354d, y: 0.022226542857682108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514353405621402d, y: 0.8493756455165197d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48131484775719646d, y: 0.9279174697748446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6161580354293893d, y: 0.39176176487027825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556599357340424d, y: 0.30284553617278387d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.918961909933779d, y: 0.6849905696653014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359173733637151d, y: 0.7291257267488543d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728215769520907d, y: 0.8244023981181222d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7026492365899973d, y: 0.18628674398614709d), new NpgsqlTypes.NpgsqlPoint(x: 0.24098818196186678d, y: 0.9352945486414308d), new NpgsqlTypes.NpgsqlPoint(x: 0.48557261806657637d, y: 0.9126989611955785d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.993966817439379d, y: 0.35309756775153434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330013553591662d, y: 0.05493248435348064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7483838497794003d, y: 0.012237785626435738d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32470675609455524d, y: 0.09342350660928755d), new NpgsqlTypes.NpgsqlPoint(x: 0.058783018015928334d, y: 0.34523155109152803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5604783955190177d, y: 0.1773704259456701d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9962658175881501d, y: 0.6017509869487973d), new NpgsqlTypes.NpgsqlPoint(x: 0.15202629132762424d, y: 0.16329393905860268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734814552594547d, y: 0.6568311927256949d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003881931897095292d, y: 0.4134906822266834d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868785847301423d, y: 0.5338951989072598d), new NpgsqlTypes.NpgsqlPoint(x: 0.12474215563942925d, y: 0.304209320102117d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1281474052523215d, y: 0.8797009679846516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185622394868785d, y: 0.9841363710042176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6109907235431385d, y: 0.8146461189617621d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8823006178034026d, y: 0.3348968777596729d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601256727153275d, y: 0.7424498357130359d), new NpgsqlTypes.NpgsqlPoint(x: 0.22630967727152118d, y: 0.9559574535455634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142875554534182d, y: 0.34596497325216646d), new NpgsqlTypes.NpgsqlPoint(x: 0.16989825071241837d, y: 0.46160870266168674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154237154687717d, y: 0.6193342448314135d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4037252687849805d, y: 0.3059101444756065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056450501510903d, y: 0.6026271079345238d), new NpgsqlTypes.NpgsqlPoint(x: 0.890795829054644d, y: 0.21167748049654356d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5069670229381147d, y: 0.23052702113107715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083852330450704d, y: 0.5765318843242012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141058062991144d, y: 0.9032258527283863d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9850901217437645d, y: 0.27959641935020585d), new NpgsqlTypes.NpgsqlPoint(x: 0.07567136460282509d, y: 0.7148471514177572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3531913596542542d, y: 0.6641029798330683d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3930719130426016d, y: 0.6359752802242947d), new NpgsqlTypes.NpgsqlPoint(x: 0.1925907824723585d, y: 0.9036788538811334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3146237747381384d, y: 0.05223224402616666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6686386034490258d, y: 0.06173110086745581d), new NpgsqlTypes.NpgsqlPoint(x: 0.07082457159709499d, y: 0.7539522245543178d), new NpgsqlTypes.NpgsqlPoint(x: 0.4051713810263815d, y: 0.1870312788775842d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16496951626212353d, y: 0.47965560651616523d), new NpgsqlTypes.NpgsqlPoint(x: 0.40587490009699156d, y: 0.6188945591375656d), new NpgsqlTypes.NpgsqlPoint(x: 0.672270739744904d, y: 0.1690772447473018d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7031075030679466d, y: 0.9961601533298599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879198339664177d, y: 0.11745937793015238d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813436491152588d, y: 0.6307938283440419d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5206108593570811d, y: 0.5883113462664712d), new NpgsqlTypes.NpgsqlPoint(x: 0.4361704040322256d, y: 0.408625602882819d), new NpgsqlTypes.NpgsqlPoint(x: 0.3572334179389587d, y: 0.3724434633453322d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3570522676761161d, y: 0.06870032313591468d), new NpgsqlTypes.NpgsqlPoint(x: 0.026271249154645404d, y: 0.31638922846991924d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315570316719231d, y: 0.2837402144803717d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37557085773668253d, y: 0.9407739334481353d), new NpgsqlTypes.NpgsqlPoint(x: 0.412460409277866d, y: 0.7897671458092866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517231397822851d, y: 0.09887930370199094d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08185403474090447d, y: 0.8387753894481319d), new NpgsqlTypes.NpgsqlPoint(x: 0.45279058507638303d, y: 0.3261449860146084d), new NpgsqlTypes.NpgsqlPoint(x: 0.6856098385748968d, y: 0.3963329958495472d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9071795333386048d, y: 0.6912244061952285d), new NpgsqlTypes.NpgsqlPoint(x: 0.06033874422333152d, y: 0.8485940910391093d), new NpgsqlTypes.NpgsqlPoint(x: 0.533666144475545d, y: 0.39538693127034985d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23989606263791896d, y: 0.7509649654208141d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061739936165655d, y: 0.7026656048332386d), new NpgsqlTypes.NpgsqlPoint(x: 0.943219594017973d, y: 0.03453830613161679d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5702828651689363d, y: 0.11346917510094845d), new NpgsqlTypes.NpgsqlPoint(x: 0.5221510952228015d, y: 0.09097498840311691d), new NpgsqlTypes.NpgsqlPoint(x: 0.1289216911535893d, y: 0.8030880679975086d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49650393657066827d, y: 0.7739959000346873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8632479127239002d, y: 0.36737449518129717d), new NpgsqlTypes.NpgsqlPoint(x: 0.5172508370281154d, y: 0.9651275102749654d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4455706421092094d, y: 0.19887855480843486d), new NpgsqlTypes.NpgsqlPoint(x: 0.080725065961193d, y: 0.7900119916718514d), new NpgsqlTypes.NpgsqlPoint(x: 0.4913588991138682d, y: 0.3340708692917509d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9178902869276758d, y: 0.08806858950777752d), new NpgsqlTypes.NpgsqlPoint(x: 0.7447323990897403d, y: 0.40802046803685776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195055932850158d, y: 0.6291755523794974d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7604219094556937d, y: 0.20825527335307892d), new NpgsqlTypes.NpgsqlPoint(x: 0.5286409377426607d, y: 0.45749756989364077d), new NpgsqlTypes.NpgsqlPoint(x: 0.47325126918057614d, y: 0.5893248991118936d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45378263505232874d, y: 0.5130715837897251d), new NpgsqlTypes.NpgsqlPoint(x: 0.1316676791394087d, y: 0.17955845422572858d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544986373533039d, y: 0.832942339898366d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7531427862477273d, y: 0.42153953652011333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513097338980703d, y: 0.8179217999573754d), new NpgsqlTypes.NpgsqlPoint(x: 0.5250523577529871d, y: 0.049947404238604d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21866448652725956d, y: 0.7205804554818125d), new NpgsqlTypes.NpgsqlPoint(x: 0.14432991853129207d, y: 0.989980296183113d), new NpgsqlTypes.NpgsqlPoint(x: 0.9379557262935507d, y: 0.5460465557153693d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0779985476002435d, y: 0.9794614847387718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8327713381815337d, y: 0.6480032548754917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5894652274798238d, y: 0.5963320897281305d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16924897763239444d, y: 0.22557822259667282d), new NpgsqlTypes.NpgsqlPoint(x: 0.3372424578190787d, y: 0.7595428031122167d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832159543437659d, y: 0.8330918937614715d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3025978821460704d, y: 0.24092329980976768d), new NpgsqlTypes.NpgsqlPoint(x: 0.13307292071796706d, y: 0.5155580552492653d), new NpgsqlTypes.NpgsqlPoint(x: 0.19283689553073313d, y: 0.9202723608696372d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02772172210998547d, y: 0.20261128251362603d), new NpgsqlTypes.NpgsqlPoint(x: 0.6245595791603201d, y: 0.33218346042729086d), new NpgsqlTypes.NpgsqlPoint(x: 0.5531704313189572d, y: 0.5565102989296697d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4328268159101214d, y: 0.7944607358569588d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967436332427314d, y: 0.955194252332437d), new NpgsqlTypes.NpgsqlPoint(x: 0.9813209969592578d, y: 0.1001868170019915d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5507752926253411d, y: 0.3334755496204589d), new NpgsqlTypes.NpgsqlPoint(x: 0.8223980388315129d, y: 0.9933260525984607d), new NpgsqlTypes.NpgsqlPoint(x: 0.5617585739948799d, y: 0.4995668030196474d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27286375148918673d, y: 0.9371535870794906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4992289837233904d, y: 0.8058721345639629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6166649491321249d, y: 0.11517030855612143d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7890557109560863d, y: 0.9554234176304015d), new NpgsqlTypes.NpgsqlPoint(x: 0.4776109279927686d, y: 0.829821369476161d), new NpgsqlTypes.NpgsqlPoint(x: 0.36431605332981987d, y: 0.9308452944574707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9727812603906847d, y: 0.30618283442478667d), new NpgsqlTypes.NpgsqlPoint(x: 0.48067239482508606d, y: 0.07755573709446595d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733921948641432d, y: 0.25840829303003054d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05469353728842119d, y: 0.7357616972480122d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906913676197349d, y: 0.27574744773046245d), new NpgsqlTypes.NpgsqlPoint(x: 0.34475386603665326d, y: 0.42260955146307533d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4354590916646389d, y: 0.5494478777484625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5463508425318238d, y: 0.6768439097748705d), new NpgsqlTypes.NpgsqlPoint(x: 0.14354058367338662d, y: 0.07762078099772995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42568564961484834d, y: 0.765308766950632d), new NpgsqlTypes.NpgsqlPoint(x: 0.015996158476087152d, y: 0.9316495888886844d), new NpgsqlTypes.NpgsqlPoint(x: 0.20297037020829845d, y: 0.15013917618497175d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8460076861182679d, y: 0.2912364566742911d), new NpgsqlTypes.NpgsqlPoint(x: 0.47024493974961756d, y: 0.8776734249983035d), new NpgsqlTypes.NpgsqlPoint(x: 0.08735042061076814d, y: 0.705249417511133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5977897940910957d, y: 0.15372458154167423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7813197576391444d, y: 0.4389482097226355d), new NpgsqlTypes.NpgsqlPoint(x: 0.47629096391874504d, y: 0.8387773556942971d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04946850576703565d, y: 0.43661060379656247d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534226423301582d, y: 0.2584004490706462d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759837799683849d, y: 0.6448547917134673d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.658174936850068d, y: 0.8049213207871403d), new NpgsqlTypes.NpgsqlPoint(x: 0.44126777393020744d, y: 0.5921948869055629d), new NpgsqlTypes.NpgsqlPoint(x: 0.9303208552506339d, y: 0.10736078253457337d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3444181222110436d, y: 0.9766556689845408d), new NpgsqlTypes.NpgsqlPoint(x: 0.44021631019914254d, y: 0.6867190026540678d), new NpgsqlTypes.NpgsqlPoint(x: 0.32885089163101167d, y: 0.3870710162574369d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24492534361283913d, y: 0.3504221992540807d), new NpgsqlTypes.NpgsqlPoint(x: 0.33033053544402535d, y: 0.6486788099464881d), new NpgsqlTypes.NpgsqlPoint(x: 0.11902135046495066d, y: 0.5735368718753854d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8063098582333217d, y: 0.6003260753796936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864886746950964d, y: 0.5767046203444095d), new NpgsqlTypes.NpgsqlPoint(x: 0.6958191462594647d, y: 0.2120181224017771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4461299580932394d, y: 0.36716249113619603d), new NpgsqlTypes.NpgsqlPoint(x: 0.03016615723179339d, y: 0.4894374171691611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7150829028678772d, y: 0.10679094680480816d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5645862787817805d, y: 0.7282157595693732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5145161302227643d, y: 0.8306673356705891d), new NpgsqlTypes.NpgsqlPoint(x: 0.3461811940759254d, y: 0.9428838294988656d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2766655031372284d, y: 0.2994346731331924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7350875841296035d, y: 0.21618754348777947d), new NpgsqlTypes.NpgsqlPoint(x: 0.37970327265855974d, y: 0.6486260906810728d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8263175442804698d, y: 0.4974304692038032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6015082253954845d, y: 0.08907704003826211d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388174111398713d, y: 0.6356695464787956d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8316520506221876d, y: 0.852557373642815d), new NpgsqlTypes.NpgsqlPoint(x: 0.9127335563449037d, y: 0.9259383464660845d), new NpgsqlTypes.NpgsqlPoint(x: 0.2858146873425661d, y: 0.5926211981737443d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2644808647441632d, y: 0.5327712393985017d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797400033788843d, y: 0.8642617378724666d), new NpgsqlTypes.NpgsqlPoint(x: 0.04801840425380144d, y: 0.4378982537238354d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5408767422276612d, y: 0.8456252457385259d), new NpgsqlTypes.NpgsqlPoint(x: 0.7592697375292615d, y: 0.07752167935976972d), new NpgsqlTypes.NpgsqlPoint(x: 0.4931253376363568d, y: 0.7287870777244155d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20838023382052095d, y: 0.49531950393341617d), new NpgsqlTypes.NpgsqlPoint(x: 0.20816075333315087d, y: 0.4020695759856471d), new NpgsqlTypes.NpgsqlPoint(x: 0.6479537971931333d, y: 0.4429424047050402d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2923841747474817d, y: 0.7113362457571785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5927632912505475d, y: 0.6665872780952422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747881535306265d, y: 0.4038604095202134d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1472948067152644d, y: 0.015691593329281384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6246595392203779d, y: 0.03509274867193157d), new NpgsqlTypes.NpgsqlPoint(x: 0.2882779763876626d, y: 0.990006004387558d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7976116049926016d, y: 0.1108700625444543d), new NpgsqlTypes.NpgsqlPoint(x: 0.510039563330708d, y: 0.3311216271128701d), new NpgsqlTypes.NpgsqlPoint(x: 0.9294462813499167d, y: 0.6828701334569781d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26788801281584196d, y: 0.0033504510809471144d), new NpgsqlTypes.NpgsqlPoint(x: 0.951989786351431d, y: 0.1964388499183709d), new NpgsqlTypes.NpgsqlPoint(x: 0.09766686587019302d, y: 0.9138861032061065d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4996412657447793d, y: 0.35153806201639926d), new NpgsqlTypes.NpgsqlPoint(x: 0.3156825495982798d, y: 0.903834288026859d), new NpgsqlTypes.NpgsqlPoint(x: 0.627813951380607d, y: 0.6480475082611836d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8864241781820639d, y: 0.6803045634026667d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194978410296321d, y: 0.7309947176536371d), new NpgsqlTypes.NpgsqlPoint(x: 0.7975758713244796d, y: 0.8193079600986216d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4743088245513859d, y: 0.31084464066941087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180509170148216d, y: 0.46740171071893555d), new NpgsqlTypes.NpgsqlPoint(x: 0.4039303013173625d, y: 0.26312977330744514d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32904332440693695d, y: 0.6154724269152384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5353077057479859d, y: 0.39368042763381306d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261857061159637d, y: 0.9556865565480989d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8433020696086073d, y: 0.9856548392473862d), new NpgsqlTypes.NpgsqlPoint(x: 0.4208046371783678d, y: 0.7067410019417826d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034344869387848d, y: 0.5033229093791526d)), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7927904824518932d, y: 0.4866414072525618d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559224708064995d, y: 0.5230000623917379d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221433819096561d, y: 0.8474170470046822d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32441558330078923d, y: 0.4616289348654794d), new NpgsqlTypes.NpgsqlPoint(x: 0.62795108728066d, y: 0.9186721589388173d), new NpgsqlTypes.NpgsqlPoint(x: 0.339073184087636d, y: 0.7090921653350845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7973538041775338d, y: 0.22360759400069397d), new NpgsqlTypes.NpgsqlPoint(x: 0.376138350730736d, y: 0.8346608041815241d), new NpgsqlTypes.NpgsqlPoint(x: 0.484411170179911d, y: 0.9068009862191206d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.552278845058782d, y: 0.10954875134420783d), new NpgsqlTypes.NpgsqlPoint(x: 0.46413497135659854d, y: 0.517176629014531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883536923544525d, y: 0.7566968251897754d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535563138076291d, y: 0.8058872940802629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6165684129313839d, y: 0.7980383627870145d), new NpgsqlTypes.NpgsqlPoint(x: 0.968518390715218d, y: 0.16081264868008105d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27678606210858936d, y: 0.14569510282918552d), new NpgsqlTypes.NpgsqlPoint(x: 0.15692124186676182d, y: 0.5579867530629995d), new NpgsqlTypes.NpgsqlPoint(x: 0.22292768719812306d, y: 0.42043414169689286d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.67694377962968d, y: 0.2116910315969769d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909683127097089d, y: 0.9253892686740997d), new NpgsqlTypes.NpgsqlPoint(x: 0.30830751723581196d, y: 0.054897713198824416d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7579452203939777d, y: 0.3358420884244966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414445924858167d, y: 0.8722272186443775d), new NpgsqlTypes.NpgsqlPoint(x: 0.35263652222244546d, y: 0.46439600523373736d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241037969398508d, y: 0.5350915447545751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799953076836457d, y: 0.8582840784913012d), new NpgsqlTypes.NpgsqlPoint(x: 0.09654894245065015d, y: 0.9072052235696698d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054684200873565736d, y: 0.6252854867033939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633110409391359d, y: 0.023981805589453065d), new NpgsqlTypes.NpgsqlPoint(x: 0.00505349545361089d, y: 0.7247448751480784d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15667929456448648d, y: 0.776780459888739d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481374649203832d, y: 0.03565233228040321d), new NpgsqlTypes.NpgsqlPoint(x: 0.2710319366991485d, y: 0.959760755116182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9497722236502487d, y: 0.14969230632801434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9220023443596198d, y: 0.0665743780569985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284015613926299d, y: 0.8596731026335015d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5665974077478546d, y: 0.22746286180125608d), new NpgsqlTypes.NpgsqlPoint(x: 0.04744326288103229d, y: 0.2314823600863668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7131669109232621d, y: 0.279522239133286d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44510358345764955d, y: 0.7816056241473726d), new NpgsqlTypes.NpgsqlPoint(x: 0.941242105630743d, y: 0.45682638030781d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625996736802874d, y: 0.4804667295413837d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9230648790854552d, y: 0.07586538957837374d), new NpgsqlTypes.NpgsqlPoint(x: 0.977364091820531d, y: 0.19839369132746953d), new NpgsqlTypes.NpgsqlPoint(x: 0.03874172224426431d, y: 0.4020234562599835d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49847915518724595d, y: 0.11737991942238657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008986161696853d, y: 0.2768134635209114d), new NpgsqlTypes.NpgsqlPoint(x: 0.3997399178611394d, y: 0.20341873101823127d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12982264965885937d, y: 0.6456600094335071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348253719457172d, y: 0.5132135778235016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421402940578181d, y: 0.013411840919710705d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09210882462537917d, y: 0.8432353178901406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211483951018572d, y: 0.28463579322845123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178134163507972d, y: 0.8958345892142646d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7146583603508534d, y: 0.7538704502612154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540021988125398d, y: 0.6818493412957476d), new NpgsqlTypes.NpgsqlPoint(x: 0.05663835233620096d, y: 0.43984576972695977d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2769770775851813d, y: 0.216915843023756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716429985271579d, y: 0.6905184064840056d), new NpgsqlTypes.NpgsqlPoint(x: 0.1846888208110986d, y: 0.07963014666992407d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125547160865581d, y: 0.3515898955320548d), new NpgsqlTypes.NpgsqlPoint(x: 0.34530467714221036d, y: 0.4353487918740341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421036517823781d, y: 0.04363423552107493d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13819126412958604d, y: 0.1856321410142302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073356670130821d, y: 0.5182364987043948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269589043873803d, y: 0.21902251440391296d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8547275026871815d, y: 0.4370074971051382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394499994249323d, y: 0.14994919297859532d), new NpgsqlTypes.NpgsqlPoint(x: 0.3068318804142649d, y: 0.8765131798995567d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27017907127302565d, y: 0.02919818019833431d), new NpgsqlTypes.NpgsqlPoint(x: 0.20003357629011798d, y: 0.7185652067000733d), new NpgsqlTypes.NpgsqlPoint(x: 0.0911806984518132d, y: 0.622765233691191d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9335916582851987d, y: 0.3970662825717448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104871599318256d, y: 0.867771633145169d), new NpgsqlTypes.NpgsqlPoint(x: 0.42076019792424535d, y: 0.06689631457518219d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.991441234432373d, y: 0.24998120089652232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815061549323451d, y: 0.9860430400707312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2013789576841316d, y: 0.49050260071039553d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7966072212188355d, y: 0.37898236956217957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08524711250120864d, y: 0.46536971887857725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340542503336302d, y: 0.9356738262377673d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 52,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22085847430918915d, y: 0.0776926441295237d), new NpgsqlTypes.NpgsqlPoint(x: 0.7677453596296475d, y: 0.49812011981898663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2230564598516246d, y: 0.8710400152840475d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9272386191373809d, y: 0.8973937711953244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8147163798790389d, y: 0.5247987777235394d), new NpgsqlTypes.NpgsqlPoint(x: 0.058782490729709314d, y: 0.9758234002564002d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5937446114988925d, y: 0.3961664714638903d), new NpgsqlTypes.NpgsqlPoint(x: 0.5152843935775183d, y: 0.1418544575830839d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934803965571473d, y: 0.5751819581608785d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7645994736860281d, y: 0.9794985157666484d), new NpgsqlTypes.NpgsqlPoint(x: 0.1348634528499988d, y: 0.2943834942750855d), new NpgsqlTypes.NpgsqlPoint(x: 0.6237968161496117d, y: 0.05782101763586467d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35303207747177123d, y: 0.25702499451895133d), new NpgsqlTypes.NpgsqlPoint(x: 0.06724553678264544d, y: 0.005069703987860108d), new NpgsqlTypes.NpgsqlPoint(x: 0.2028535268208762d, y: 0.5969162530459856d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23682510462171535d, y: 0.5073507529931144d), new NpgsqlTypes.NpgsqlPoint(x: 0.28817526068412247d, y: 0.10755915906046476d), new NpgsqlTypes.NpgsqlPoint(x: 0.19530006584743198d, y: 0.47268853373982844d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6277618269401312d, y: 0.5519996576319537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8476332520257231d, y: 0.9505533742352094d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160757870815461d, y: 0.17748790193051733d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5192543718373281d, y: 0.29383662360437957d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245366708489738d, y: 0.7348627982959044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4454465540556881d, y: 0.7837751648551078d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9812852553677398d, y: 0.4109803489616747d), new NpgsqlTypes.NpgsqlPoint(x: 0.2555517757718909d, y: 0.6792276125333363d), new NpgsqlTypes.NpgsqlPoint(x: 0.26776206746268494d, y: 0.4760441841135724d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9269913927996088d, y: 0.5948474193311442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5148720603449046d, y: 0.27711965446072906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4223826216559007d, y: 0.4125072799497509d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15362163011886787d, y: 0.6607536468224018d), new NpgsqlTypes.NpgsqlPoint(x: 0.07685911501875564d, y: 0.40260485931000545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7135944725188147d, y: 0.7195736942501058d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6973700095372234d, y: 0.810923503246877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5430714474802438d, y: 0.5146090052869533d), new NpgsqlTypes.NpgsqlPoint(x: 0.16817428263933532d, y: 0.7238651890311671d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.68708124000211d, y: 0.29392775764469836d), new NpgsqlTypes.NpgsqlPoint(x: 0.3164100702362612d, y: 0.5859231454319778d), new NpgsqlTypes.NpgsqlPoint(x: 0.38092328507945217d, y: 0.6462926474413165d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32818234743610153d, y: 0.8499997813556748d), new NpgsqlTypes.NpgsqlPoint(x: 0.13704203256088288d, y: 0.2584196996290058d), new NpgsqlTypes.NpgsqlPoint(x: 0.787113793601267d, y: 0.9433393100968122d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6008968059360424d, y: 0.8604220285019527d), new NpgsqlTypes.NpgsqlPoint(x: 0.9814726497339907d, y: 0.4601992797319069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7234126017697434d, y: 0.5783026588929899d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012726634595083386d, y: 0.21035065406683906d), new NpgsqlTypes.NpgsqlPoint(x: 0.3948352112081005d, y: 0.9967990770506086d), new NpgsqlTypes.NpgsqlPoint(x: 0.2581228050316653d, y: 0.7935093012230866d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8500575738512658d, y: 0.4156275207683733d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302096309648867d, y: 0.32984139637673826d), new NpgsqlTypes.NpgsqlPoint(x: 0.11358588494273503d, y: 0.30621649121141736d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7867409509794085d, y: 0.5319679850951036d), new NpgsqlTypes.NpgsqlPoint(x: 0.26002654851937435d, y: 0.3413349883358171d), new NpgsqlTypes.NpgsqlPoint(x: 0.3122512186281391d, y: 0.0745198551734384d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3764186371943493d, y: 0.94359328222641d), new NpgsqlTypes.NpgsqlPoint(x: 0.9329209823293367d, y: 0.8779875599358498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029387095335114d, y: 0.08434930493507131d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8094560505304635d, y: 0.7896967174204979d), new NpgsqlTypes.NpgsqlPoint(x: 0.13334862388615232d, y: 0.09764589235944154d), new NpgsqlTypes.NpgsqlPoint(x: 0.5553207176980091d, y: 0.7499480521095271d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142739621337327d, y: 0.9174550839166601d), new NpgsqlTypes.NpgsqlPoint(x: 0.4394815918354168d, y: 0.007192495834062784d), new NpgsqlTypes.NpgsqlPoint(x: 0.49955959815643103d, y: 0.03168840639621806d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35431927008583497d, y: 0.6488643772298444d), new NpgsqlTypes.NpgsqlPoint(x: 0.14185479134929402d, y: 0.5993079038266589d), new NpgsqlTypes.NpgsqlPoint(x: 0.6277111216003499d, y: 0.7017995863863827d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1997932346542446d, y: 0.43200730249734187d), new NpgsqlTypes.NpgsqlPoint(x: 0.3771677076267824d, y: 0.5672902857553727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719917294254051d, y: 0.5740619062074043d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8380171818380163d, y: 0.23911704288612945d), new NpgsqlTypes.NpgsqlPoint(x: 0.37726283512311953d, y: 0.1128004525768892d), new NpgsqlTypes.NpgsqlPoint(x: 0.04408444709493298d, y: 0.2082962161754871d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9859440663850241d, y: 0.4934007440417445d), new NpgsqlTypes.NpgsqlPoint(x: 0.6809972360159618d, y: 0.3499855293506795d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285674489439182d, y: 0.7183836388952439d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9540831022078685d, y: 0.7414200529227093d), new NpgsqlTypes.NpgsqlPoint(x: 0.14941513264587059d, y: 0.9298592676230829d), new NpgsqlTypes.NpgsqlPoint(x: 0.19329731064247535d, y: 0.7839751098623972d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33401279614672763d, y: 0.13598307758267159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9402356349785772d, y: 0.8468836674177053d), new NpgsqlTypes.NpgsqlPoint(x: 0.0195190830009927d, y: 0.20809486933419785d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3468396102918736d, y: 0.36008903615430066d), new NpgsqlTypes.NpgsqlPoint(x: 0.08674521114302602d, y: 0.17655676275547183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3303376839889264d, y: 0.712622749072469d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772366948009105d, y: 0.8773088608183488d), new NpgsqlTypes.NpgsqlPoint(x: 0.964176988193821d, y: 0.7684514557305798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953778381529362d, y: 0.7953091932254874d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8958395450704458d, y: 0.28372496720871687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074666371626377d, y: 0.3106626474399201d), new NpgsqlTypes.NpgsqlPoint(x: 0.33408932477563036d, y: 0.6520146208342708d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25344923456469814d, y: 0.2596168353647673d), new NpgsqlTypes.NpgsqlPoint(x: 0.012000227706786992d, y: 0.20549551757718199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161387687085951d, y: 0.3510146252744172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580986822248571d, y: 0.19369354314126097d), new NpgsqlTypes.NpgsqlPoint(x: 0.22007961156155498d, y: 0.8798573820249509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7440119749678913d, y: 0.22123123248422882d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4087556774578395d, y: 0.40362806809140717d), new NpgsqlTypes.NpgsqlPoint(x: 0.16299329424403053d, y: 0.5479910333885055d), new NpgsqlTypes.NpgsqlPoint(x: 0.19563509127934875d, y: 0.2005033038810684d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6739018625235681d, y: 0.06558057107021409d), new NpgsqlTypes.NpgsqlPoint(x: 0.527019334097142d, y: 0.9830965751778519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504791870846985d, y: 0.3709189163001019d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9261717752603201d, y: 0.23551197483148778d), new NpgsqlTypes.NpgsqlPoint(x: 0.10881557595641256d, y: 0.1753022301941436d), new NpgsqlTypes.NpgsqlPoint(x: 0.06636810273890992d, y: 0.7402230936450311d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1843732913355518d, y: 0.6531812799730992d), new NpgsqlTypes.NpgsqlPoint(x: 0.42443289601128165d, y: 0.13524304445719348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563369229701387d, y: 0.6962237890318209d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4515334974749863d, y: 0.27850425275948143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334752547497915d, y: 0.9964398462998006d), new NpgsqlTypes.NpgsqlPoint(x: 0.08314277698157757d, y: 0.7290182097240396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3981292053954736d, y: 0.9091339825118441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262726344826159d, y: 0.3788892605633086d), new NpgsqlTypes.NpgsqlPoint(x: 0.579488505008708d, y: 0.4285469659904966d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09023399995337489d, y: 0.22065021688180386d), new NpgsqlTypes.NpgsqlPoint(x: 0.36893590484709093d, y: 0.13457769278144016d), new NpgsqlTypes.NpgsqlPoint(x: 0.35270930022545044d, y: 0.1727855637347928d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6891785395572725d, y: 0.2392600133369549d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694302144388916d, y: 0.6100145734981725d), new NpgsqlTypes.NpgsqlPoint(x: 0.35803498703650904d, y: 0.8552315432136854d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20058517351228045d, y: 0.5980124113886842d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228765029479014d, y: 0.2909694501834732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530007285884047d, y: 0.2427092127017667d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5451611534427652d, y: 0.6112108905936895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082199484319321d, y: 0.623338051288113d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303349833697354d, y: 0.9839760898696475d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8802222226403383d, y: 0.5600657852541001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678882286241143d, y: 0.5153670753615661d), new NpgsqlTypes.NpgsqlPoint(x: 0.13043156902329955d, y: 0.18565716033560842d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11701313973400973d, y: 0.26290595770831604d), new NpgsqlTypes.NpgsqlPoint(x: 0.1190315846029042d, y: 0.4013207282696767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615169830831194d, y: 0.8288462405803025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8944182572958486d, y: 0.9509683208332228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039784575660578d, y: 0.24296605430842821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5773511011055764d, y: 0.7051031176296852d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04962353065705416d, y: 0.19043129076085563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255328590465286d, y: 0.8525846345471334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927394862094674d, y: 0.8294637467889429d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5043810493997918d, y: 0.14850491535322707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818303035046584d, y: 0.6075771625052805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890085989078456d, y: 0.6235820284737914d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6765712868694139d, y: 0.7953822430266484d), new NpgsqlTypes.NpgsqlPoint(x: 0.41739165866324146d, y: 0.51020303505353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789256166211765d, y: 0.26930208573975434d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881381860070802d, y: 0.14284454897055798d), new NpgsqlTypes.NpgsqlPoint(x: 0.11262202248617581d, y: 0.28324668595830105d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234404158285592d, y: 0.7008659974936893d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.746623421658198d, y: 0.915070751357965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162367045440502d, y: 0.20925493662917238d), new NpgsqlTypes.NpgsqlPoint(x: 0.08834307456771306d, y: 0.7724950876044766d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38833475708496135d, y: 0.2720909813551884d), new NpgsqlTypes.NpgsqlPoint(x: 0.24399881663052192d, y: 0.1397233078553557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708496629756845d, y: 0.8783840306168936d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8196571359940893d, y: 0.0339287808515194d), new NpgsqlTypes.NpgsqlPoint(x: 0.423994574296674d, y: 0.5617108501584647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694362539586518d, y: 0.8089964361469405d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9458403239895411d, y: 0.9245527027224049d), new NpgsqlTypes.NpgsqlPoint(x: 0.07100762570001307d, y: 0.05789413121830467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458008611877688d, y: 0.34628722612499485d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5620108198656704d, y: 0.2157562627898365d), new NpgsqlTypes.NpgsqlPoint(x: 0.017278903865691975d, y: 0.8337444330926806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788357945118157d, y: 0.2359683354846217d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 61,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13574033783278494d, y: 0.15335537243438357d), new NpgsqlTypes.NpgsqlPoint(x: 0.8376158194130998d, y: 0.714691861101349d), new NpgsqlTypes.NpgsqlPoint(x: 0.538398019120268d, y: 0.10769522282464628d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.704504496473965d, y: 0.9543283102036125d), new NpgsqlTypes.NpgsqlPoint(x: 0.19417742460111642d, y: 0.22498754204200033d), new NpgsqlTypes.NpgsqlPoint(x: 0.49032763133810264d, y: 0.32336373335066393d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7819412248550274d, y: 0.3059581761047345d), new NpgsqlTypes.NpgsqlPoint(x: 0.7759101147979939d, y: 0.3096866049165563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8166935447158724d, y: 0.9550385990948471d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8968601698141243d, y: 0.5656394279598671d), new NpgsqlTypes.NpgsqlPoint(x: 0.16989211234185042d, y: 0.8481531771170117d), new NpgsqlTypes.NpgsqlPoint(x: 0.3180535689860857d, y: 0.9922636250101751d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4294638721210602d, y: 0.27415179228986175d), new NpgsqlTypes.NpgsqlPoint(x: 0.2126765851231205d, y: 0.9922148848968957d), new NpgsqlTypes.NpgsqlPoint(x: 0.001385564407561879d, y: 0.3973867198109906d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7274133417434918d, y: 0.6982771077061913d), new NpgsqlTypes.NpgsqlPoint(x: 0.37621847885057424d, y: 0.3505629681701471d), new NpgsqlTypes.NpgsqlPoint(x: 0.1274540825516789d, y: 0.8979516240961307d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2656247189735328d, y: 0.2504146543144574d), new NpgsqlTypes.NpgsqlPoint(x: 0.2336589328777946d, y: 0.9962225680720244d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346913487275486d, y: 0.9424661444170906d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3554806734243088d, y: 0.6176383629401473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319940968137628d, y: 0.09196022689328931d), new NpgsqlTypes.NpgsqlPoint(x: 0.9267587957189208d, y: 0.8099712301555261d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28674409068214957d, y: 0.3222234148326273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7883302377090826d, y: 0.8847071636311379d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785814686066086d, y: 0.07892264170263119d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9958219605056448d, y: 0.6367960646679293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646653089114281d, y: 0.43614492641669567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7133716800377206d, y: 0.9138222549267293d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10653740871551443d, y: 0.15567234241167538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882378048022234d, y: 0.5831129697529313d), new NpgsqlTypes.NpgsqlPoint(x: 0.018285991899290366d, y: 0.9534308076395924d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33997712482317555d, y: 0.15979748747545497d), new NpgsqlTypes.NpgsqlPoint(x: 0.02966029167480755d, y: 0.3680575123027855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7803013612593921d, y: 0.45231324943652695d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6122078417126265d, y: 0.8400170651191543d), new NpgsqlTypes.NpgsqlPoint(x: 0.1806227978054401d, y: 0.8386747408397407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135376004065658d, y: 0.6136705424136328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143590699256597d, y: 0.7046071034970777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6971723406780951d, y: 0.4830444014186308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3985739239133369d, y: 0.7672223418464906d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5860025722637761d, y: 0.20293745756813775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7949553808421275d, y: 0.9596635459935853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5503772833244874d, y: 0.7083147382234537d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2815409622487397d, y: 0.22194135362990963d), new NpgsqlTypes.NpgsqlPoint(x: 0.33368241761069906d, y: 0.49227195348223707d), new NpgsqlTypes.NpgsqlPoint(x: 0.10202721124131842d, y: 0.8831554233059762d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8785368190225408d, y: 0.9939012200424333d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497799749385581d, y: 0.24163191581631283d), new NpgsqlTypes.NpgsqlPoint(x: 0.09026820773535271d, y: 0.0428992042835058d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1645898563709527d, y: 0.1466418638668886d), new NpgsqlTypes.NpgsqlPoint(x: 0.7236989543438139d, y: 0.9787718840214192d), new NpgsqlTypes.NpgsqlPoint(x: 0.5868566598004558d, y: 0.8652807709831657d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7681632672473275d, y: 0.43317875541923034d), new NpgsqlTypes.NpgsqlPoint(x: 0.3253878755232523d, y: 0.8780826459346603d), new NpgsqlTypes.NpgsqlPoint(x: 0.29141325574457677d, y: 0.35524686616573387d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9329266161170315d, y: 0.6564697359590235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6218916463981858d, y: 0.8051719661992653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228441340743384d, y: 0.46718967056225336d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04700038852351185d, y: 0.6048279114314513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2551841559468432d, y: 0.8418746487812341d), new NpgsqlTypes.NpgsqlPoint(x: 0.008995588026997625d, y: 0.04016956950735129d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07519444309496892d, y: 0.05305806721327888d), new NpgsqlTypes.NpgsqlPoint(x: 0.8944486688981261d, y: 0.17732678315973527d), new NpgsqlTypes.NpgsqlPoint(x: 0.3428770186036596d, y: 0.5232050305131295d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9871790426103327d, y: 0.5047084984418313d), new NpgsqlTypes.NpgsqlPoint(x: 0.4151590630441736d, y: 0.839529334244372d), new NpgsqlTypes.NpgsqlPoint(x: 0.16595079504292343d, y: 0.7472215856463786d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22401403714721402d, y: 0.32621104460289096d), new NpgsqlTypes.NpgsqlPoint(x: 0.997519191915696d, y: 0.33448623767705676d), new NpgsqlTypes.NpgsqlPoint(x: 0.255672490476355d, y: 0.7441397688448093d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28218117502887163d, y: 0.6325865836803487d), new NpgsqlTypes.NpgsqlPoint(x: 0.14838604572492387d, y: 0.7989503088779324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442301824747961d, y: 0.8009669112284828d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29406721042654416d, y: 0.0544457131533419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3536007600498542d, y: 0.426460998759997d), new NpgsqlTypes.NpgsqlPoint(x: 0.41815469615853307d, y: 0.08780913986438788d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7866762510114896d, y: 0.9651459199969943d), new NpgsqlTypes.NpgsqlPoint(x: 0.9195845722419362d, y: 0.2349515117614951d), new NpgsqlTypes.NpgsqlPoint(x: 0.5679584462039616d, y: 0.2071549669556001d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5196976911872828d, y: 0.5099219615974834d), new NpgsqlTypes.NpgsqlPoint(x: 0.16402589529191425d, y: 0.32961365924915664d), new NpgsqlTypes.NpgsqlPoint(x: 0.4636516545643541d, y: 0.5133846493327591d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01607445180949918d, y: 0.9073268832497549d), new NpgsqlTypes.NpgsqlPoint(x: 0.6806029945581354d, y: 0.3803944603276116d), new NpgsqlTypes.NpgsqlPoint(x: 0.3748961317980579d, y: 0.9621856292470403d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38645095739642354d, y: 0.07345981797992573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8731378357147767d, y: 0.6200193034258139d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563322523289835d, y: 0.6168162436295982d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02395769278054416d, y: 0.06592599022353118d), new NpgsqlTypes.NpgsqlPoint(x: 0.02349549112624616d, y: 0.8098416214706974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335584146780355d, y: 0.7509704869307506d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6460955256088344d, y: 0.9568952579903565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5746585399308312d, y: 0.14441769774606128d), new NpgsqlTypes.NpgsqlPoint(x: 0.22242195793422515d, y: 0.5568380303083459d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35978186626234376d, y: 0.6484109143079364d), new NpgsqlTypes.NpgsqlPoint(x: 0.5816239807348091d, y: 0.3065427856784787d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180335810609139d, y: 0.6924764349851433d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25354586794655654d, y: 0.3643577092801987d), new NpgsqlTypes.NpgsqlPoint(x: 0.10592579744863828d, y: 0.10224721682591942d), new NpgsqlTypes.NpgsqlPoint(x: 0.13289759287851233d, y: 0.8981462290218454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.760615750719749d, y: 0.10655392656497498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5464466803320931d, y: 0.8568657652511703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8250699415831193d, y: 0.5646286368112496d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21592174711613454d, y: 0.7750150969563119d), new NpgsqlTypes.NpgsqlPoint(x: 0.33871404962489715d, y: 0.763640770827922d), new NpgsqlTypes.NpgsqlPoint(x: 0.15006976165814756d, y: 0.2361542845476896d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6447483069336216d, y: 0.05604780129961817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733394202661846d, y: 0.9942184078373104d), new NpgsqlTypes.NpgsqlPoint(x: 0.21335201783182267d, y: 0.048957872309282724d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29048346757761656d, y: 0.634956029108954d), new NpgsqlTypes.NpgsqlPoint(x: 0.38701943646716086d, y: 0.47280413622607986d), new NpgsqlTypes.NpgsqlPoint(x: 0.46559476845910397d, y: 0.9673842430046199d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6297379292686384d, y: 0.952797712524403d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179330085479883d, y: 0.7908476381039203d), new NpgsqlTypes.NpgsqlPoint(x: 0.2728346792543024d, y: 0.14838745421701272d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9296211523523279d, y: 0.2973026892665831d), new NpgsqlTypes.NpgsqlPoint(x: 0.833687259534561d, y: 0.08582563460215487d), new NpgsqlTypes.NpgsqlPoint(x: 0.1017025118228625d, y: 0.2779498093557472d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38868285804223746d, y: 0.9993802900800834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6859064011424885d, y: 0.8031913481137154d), new NpgsqlTypes.NpgsqlPoint(x: 0.2473559077111237d, y: 0.4112217494048267d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7213517249435835d, y: 0.886094959965184d), new NpgsqlTypes.NpgsqlPoint(x: 0.71053493379522d, y: 0.9583728843501632d), new NpgsqlTypes.NpgsqlPoint(x: 0.17821829644852583d, y: 0.8068833879098953d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7664818050900681d, y: 0.00921836520783259d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335870555707857d, y: 0.2520794902759874d), new NpgsqlTypes.NpgsqlPoint(x: 0.09461631873769816d, y: 0.7381204920423509d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9632696026696499d, y: 0.36725106040356315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7485640002564345d, y: 0.18801120758396506d), new NpgsqlTypes.NpgsqlPoint(x: 0.7217532667977778d, y: 0.002542608059644791d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6332042284578753d, y: 0.0785279311798237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8040745202449197d, y: 0.4429394806311512d), new NpgsqlTypes.NpgsqlPoint(x: 0.1637354352589807d, y: 0.6074142076574487d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003987785164334401d, y: 0.5587073355248668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7248583576665135d, y: 0.1816766117483557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9235960114490066d, y: 0.873725204879175d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22853062031265525d, y: 0.8892284476076668d), new NpgsqlTypes.NpgsqlPoint(x: 0.16655865400328773d, y: 0.7817158699802518d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623265861176086d, y: 0.9781044382839984d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.193210144317009d, y: 0.40578949259659247d), new NpgsqlTypes.NpgsqlPoint(x: 0.24120681199453764d, y: 0.955857582910278d), new NpgsqlTypes.NpgsqlPoint(x: 0.13794828068283405d, y: 0.6289809215663168d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6508481125083001d, y: 0.9803261854892403d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331451035348515d, y: 0.3822143841224819d), new NpgsqlTypes.NpgsqlPoint(x: 0.8011135345661684d, y: 0.24844552165796097d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03760444021762477d, y: 0.935352206696898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3991688009406319d, y: 0.8038605789886163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111776789617829d, y: 0.35847269708198326d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14219020965946327d, y: 0.5084457595888243d), new NpgsqlTypes.NpgsqlPoint(x: 0.42652190163979775d, y: 0.3337074110101441d), new NpgsqlTypes.NpgsqlPoint(x: 0.3069164680218106d, y: 0.3934380536510509d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3054366461718846d, y: 0.49026482684884576d), new NpgsqlTypes.NpgsqlPoint(x: 0.12623498774102926d, y: 0.4396495733621817d), new NpgsqlTypes.NpgsqlPoint(x: 0.8660963815803082d, y: 0.7927641489051911d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8064474080315887d, y: 0.7914036369142785d), new NpgsqlTypes.NpgsqlPoint(x: 0.07304431210815943d, y: 0.1560522965115605d), new NpgsqlTypes.NpgsqlPoint(x: 0.28884280710643806d, y: 0.5542133563383717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6419642429313813d, y: 0.2394972039762674d), new NpgsqlTypes.NpgsqlPoint(x: 0.2288298473517555d, y: 0.09842667911520275d), new NpgsqlTypes.NpgsqlPoint(x: 0.3560387606032972d, y: 0.3804434119815756d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06733238711280798d, y: 0.9384724743666123d), new NpgsqlTypes.NpgsqlPoint(x: 0.8677554057279443d, y: 0.9952681466999417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6343536828281016d, y: 0.8441088150765367d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2119689471293429d, y: 0.8124233767853513d), new NpgsqlTypes.NpgsqlPoint(x: 0.21657718062692466d, y: 0.4525064302355144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7482575792355912d, y: 0.37888243651752695d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2723944677191902d, y: 0.02926361862080029d), new NpgsqlTypes.NpgsqlPoint(x: 0.08828040753185584d, y: 0.6176660141466942d), new NpgsqlTypes.NpgsqlPoint(x: 0.17950544009310243d, y: 0.3405969443043654d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30590307538282413d, y: 0.23688005602878015d), new NpgsqlTypes.NpgsqlPoint(x: 0.3825033127821844d, y: 0.44234045748859196d), new NpgsqlTypes.NpgsqlPoint(x: 0.7615317062464356d, y: 0.0554086162251467d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7237014823650624d, y: 0.6981263128265298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6248505309021217d, y: 0.8889975214316274d), new NpgsqlTypes.NpgsqlPoint(x: 0.7458304148043843d, y: 0.4347712264447807d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8311871006663479d, y: 0.3515886306761027d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781816799833619d, y: 0.3795818477119701d), new NpgsqlTypes.NpgsqlPoint(x: 0.12953939450857088d, y: 0.03108401728670629d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9036807202836501d, y: 0.39617285294448745d), new NpgsqlTypes.NpgsqlPoint(x: 0.4645588242465858d, y: 0.055418714266022184d), new NpgsqlTypes.NpgsqlPoint(x: 0.45578558931380697d, y: 0.33530597112346594d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1030524382335739d, y: 0.734761869263414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675844148694562d, y: 0.32531819316424615d), new NpgsqlTypes.NpgsqlPoint(x: 0.16566752083062264d, y: 0.5797810060760937d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3192043286117978d, y: 0.17381585570072045d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769270310337792d, y: 0.7287397283757143d), new NpgsqlTypes.NpgsqlPoint(x: 0.5913729929125481d, y: 0.821130049656058d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20713156775047026d, y: 0.8705754590987727d), new NpgsqlTypes.NpgsqlPoint(x: 0.8684603020007603d, y: 0.030797739227155896d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959016186317753d, y: 0.10590318875986648d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14132029588568817d, y: 0.8541825031811643d), new NpgsqlTypes.NpgsqlPoint(x: 0.02014132077765063d, y: 0.3332521440298104d), new NpgsqlTypes.NpgsqlPoint(x: 0.13036544197490219d, y: 0.1635339257490196d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7872768212335849d, y: 0.7974014298557541d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789855444611617d, y: 0.7481659968616954d), new NpgsqlTypes.NpgsqlPoint(x: 0.23168823340595435d, y: 0.22762429959912134d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18071548019467953d, y: 0.9722526736771967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908957997914946d, y: 0.8577750923799017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449660477172286d, y: 0.26412548362684285d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9571604867308331d, y: 0.005385388472531005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374965075423396d, y: 0.6347671135986088d), new NpgsqlTypes.NpgsqlPoint(x: 0.7200786440865409d, y: 0.28643956467919707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8503821072863194d, y: 0.6041446085898661d), new NpgsqlTypes.NpgsqlPoint(x: 0.89066695784534d, y: 0.2728029842420622d), new NpgsqlTypes.NpgsqlPoint(x: 0.482364042641902d, y: 0.35504063737665426d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4091577166565049d, y: 0.6390653273449426d), new NpgsqlTypes.NpgsqlPoint(x: 0.8272792288425626d, y: 0.8596029820405215d), new NpgsqlTypes.NpgsqlPoint(x: 0.33200149566036463d, y: 0.3515833838434861d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15473375194916006d, y: 0.12780784242425858d), new NpgsqlTypes.NpgsqlPoint(x: 0.7285902535289853d, y: 0.22602159474320338d), new NpgsqlTypes.NpgsqlPoint(x: 0.845572718223108d, y: 0.748304608324136d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10048641324245233d, y: 0.29842667946440526d), new NpgsqlTypes.NpgsqlPoint(x: 0.24087549082521498d, y: 0.718516567776743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7469245069611757d, y: 0.03388106598715568d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9634532730736292d, y: 0.08452551371488959d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635444271491449d, y: 0.7944588081954795d), new NpgsqlTypes.NpgsqlPoint(x: 0.20574951118312346d, y: 0.3780653817231404d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4297787588161206d, y: 0.7383139267106954d), new NpgsqlTypes.NpgsqlPoint(x: 0.6845043475454065d, y: 0.1153489578475646d), new NpgsqlTypes.NpgsqlPoint(x: 0.2129388110119007d, y: 0.07186450212086815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5771806611944784d, y: 0.5142940736678709d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852754114279113d, y: 0.6644019011422502d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535113472424359d, y: 0.7034168436395523d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5858762930264452d, y: 0.9971017290949357d), new NpgsqlTypes.NpgsqlPoint(x: 0.3717423231719138d, y: 0.771546308797394d), new NpgsqlTypes.NpgsqlPoint(x: 0.97138461707717d, y: 0.7147513466816446d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.637703506363554d, y: 0.766585192001898d), new NpgsqlTypes.NpgsqlPoint(x: 0.25748488141215053d, y: 0.7214807084589232d), new NpgsqlTypes.NpgsqlPoint(x: 0.11764132880903788d, y: 0.9219556084968361d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6494013359745572d, y: 0.8257398605396682d), new NpgsqlTypes.NpgsqlPoint(x: 0.5866137859741831d, y: 0.4540527130152776d), new NpgsqlTypes.NpgsqlPoint(x: 0.13382731759190813d, y: 0.7649902708374393d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29817993062312886d, y: 0.1767791866871059d), new NpgsqlTypes.NpgsqlPoint(x: 0.616546113025856d, y: 0.16789353760138315d), new NpgsqlTypes.NpgsqlPoint(x: 0.12317512352194582d, y: 0.6379448730050987d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08729972250811446d, y: 0.10983411526389397d), new NpgsqlTypes.NpgsqlPoint(x: 0.6513281145980253d, y: 0.9322915526402646d), new NpgsqlTypes.NpgsqlPoint(x: 0.7890474301718271d, y: 0.8596146040678557d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8834331834777641d, y: 0.5051206543206072d), new NpgsqlTypes.NpgsqlPoint(x: 0.013006980723459627d, y: 0.9066611398207453d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636685374792875d, y: 0.6497636542822465d)), }, }, },
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15895894854304204d, y: 0.09643604911379933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571797565474392d, y: 0.14976408684918463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374349346745785d, y: 0.4570430717795073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0983950548722381d, y: 0.8851679431091618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114573266470696d, y: 0.7639024852925637d), new NpgsqlTypes.NpgsqlPoint(x: 0.05641377347229726d, y: 0.44935826490919306d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7413403658237143d, y: 0.7844501180946131d), new NpgsqlTypes.NpgsqlPoint(x: 0.16937315231713068d, y: 0.3333475789335988d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061302340060414d, y: 0.5125323969023977d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8208469393954895d, y: 0.515420678007642d), new NpgsqlTypes.NpgsqlPoint(x: 0.409120952763403d, y: 0.9208467273199898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596632632785126d, y: 0.1543898162267815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.584566516911086d, y: 0.6735577050899192d), new NpgsqlTypes.NpgsqlPoint(x: 0.1463387137560771d, y: 0.2018454371800943d), new NpgsqlTypes.NpgsqlPoint(x: 0.55614798380937d, y: 0.18349482346318935d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2714126311212792d, y: 0.9105041097330552d), new NpgsqlTypes.NpgsqlPoint(x: 0.1683564199176859d, y: 0.5852482792763976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062344278386819d, y: 0.7438341053719554d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14726784736937049d, y: 0.611766041430563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993461083995724d, y: 0.6837294904649474d), new NpgsqlTypes.NpgsqlPoint(x: 0.17375849079525996d, y: 0.04510485600471792d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.261359519392224d, y: 0.016565308758121455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671332596309431d, y: 0.27448133063283986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642158642991719d, y: 0.17505582949149556d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24860552639217404d, y: 0.2289353474669753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404356997653368d, y: 0.1970274183601738d), new NpgsqlTypes.NpgsqlPoint(x: 0.42022268685593256d, y: 0.8878143692258528d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.413032357977978d, y: 0.5445429857065078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923216141123826d, y: 0.746183786461051d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047184458456122d, y: 0.6534134590725519d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9042460707285569d, y: 0.5117001698729517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911800377752054d, y: 0.007731614714429513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628195539512137d, y: 0.40370780040000964d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6125377023278743d, y: 0.6755158621973697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432643232291227d, y: 0.8855787597756314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361467492096968d, y: 0.2631444705537451d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7882488375976935d, y: 0.21528943525955002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943329130106775d, y: 0.635785048249836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9870453538803993d, y: 0.022063797782747918d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8724674947228913d, y: 0.9078130036330297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068016117587857d, y: 0.13367575921165653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989613085760376d, y: 0.3354785238957989d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23061599601775762d, y: 0.9499004960944285d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513084099201589d, y: 0.37904087335886927d), new NpgsqlTypes.NpgsqlPoint(x: 0.245338563933436d, y: 0.5211208983642203d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48787047733898714d, y: 0.7527201839401471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8456846600939504d, y: 0.8995552513032239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479278791643027d, y: 0.20801870570792713d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.638657209422146d, y: 0.39875807757617776d), new NpgsqlTypes.NpgsqlPoint(x: 0.18062655486849577d, y: 0.8585465426429884d), new NpgsqlTypes.NpgsqlPoint(x: 0.79351613645907d, y: 0.25252880078717077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.130537387175097d, y: 0.583624734355457d), new NpgsqlTypes.NpgsqlPoint(x: 0.07883484965441079d, y: 0.7214524263316177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8741525948536755d, y: 0.7720434916686548d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48224357540561413d, y: 0.7148250048845746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425063829095176d, y: 0.11297212571544235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4611660322171449d, y: 0.08836012084686762d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21357472124357457d, y: 0.7000472220277993d), new NpgsqlTypes.NpgsqlPoint(x: 0.005772125496326552d, y: 0.4780794445526262d), new NpgsqlTypes.NpgsqlPoint(x: 0.33664488352049027d, y: 0.1548332256293249d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246866582836531d, y: 0.33551448006310747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409599797466118d, y: 0.3164677476949087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472793860247438d, y: 0.1459080648197728d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42960394414301417d, y: 0.6069171244888895d), new NpgsqlTypes.NpgsqlPoint(x: 0.914535333113757d, y: 0.38212999818887916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769421065034312d, y: 0.32185596511061065d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1258775154209537d, y: 0.029964700137215305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413279428968144d, y: 0.2598516239551183d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152184908063464d, y: 0.540844315121079d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.288084027842888d, y: 0.400796031391045d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009382709250984611d, y: 0.8402178282838093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6338477158755785d, y: 0.7442276344227493d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33840193719804823d, y: 0.46955568269631276d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877548248866592d, y: 0.561773975500597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927639811586779d, y: 0.5386740310488769d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990846499806087d, y: 0.04490692598297852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519129763982093d, y: 0.5933632852470766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564427767214957d, y: 0.09295456886177156d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4452530985226977d, y: 0.6381620467637389d), new NpgsqlTypes.NpgsqlPoint(x: 0.31544583944343774d, y: 0.9673530423512233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836498006971921d, y: 0.9594312031457402d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 69,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6501184444910801d, y: 0.10235295392316812d), new NpgsqlTypes.NpgsqlPoint(x: 0.17258469899342654d, y: 0.7370198618657612d), new NpgsqlTypes.NpgsqlPoint(x: 0.1038295301103187d, y: 0.6817838217529985d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2999090101873997d, y: 0.8703328480267924d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636771193367557d, y: 0.8844696106159311d), new NpgsqlTypes.NpgsqlPoint(x: 0.025837115349258144d, y: 0.817543682315906d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8341928166834385d, y: 0.9170661538912472d), new NpgsqlTypes.NpgsqlPoint(x: 0.6721153899552513d, y: 0.11393703764975949d), new NpgsqlTypes.NpgsqlPoint(x: 0.7177767915703027d, y: 0.19848907581044384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2954675845011081d, y: 0.2203001195767903d), new NpgsqlTypes.NpgsqlPoint(x: 0.13415782013385547d, y: 0.5978615598505466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7745287615945355d, y: 0.7564579983398424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4844447386219076d, y: 0.8425391093914634d), new NpgsqlTypes.NpgsqlPoint(x: 0.82156279502612d, y: 0.8547962938828302d), new NpgsqlTypes.NpgsqlPoint(x: 0.80174514222855d, y: 0.5652161212807363d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31865413460060377d, y: 0.114515128054138d), new NpgsqlTypes.NpgsqlPoint(x: 0.8343589806266439d, y: 0.9166415115398278d), new NpgsqlTypes.NpgsqlPoint(x: 0.049284686040328096d, y: 0.666792491952857d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39497578430840985d, y: 0.13789701518100206d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571701344333439d, y: 0.4852052370678335d), new NpgsqlTypes.NpgsqlPoint(x: 0.7678172656868955d, y: 0.6401031078668776d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6408381366485872d, y: 0.4267652803547688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954789693060806d, y: 0.05036740182020272d), new NpgsqlTypes.NpgsqlPoint(x: 0.44901986999555776d, y: 0.21666229049851438d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19410135421182573d, y: 0.3091245527548999d), new NpgsqlTypes.NpgsqlPoint(x: 0.42559482661387593d, y: 0.3278707293792916d), new NpgsqlTypes.NpgsqlPoint(x: 0.22822657826214043d, y: 0.5290223334104271d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.569695685331628d, y: 0.3390157076475676d), new NpgsqlTypes.NpgsqlPoint(x: 0.8073017625948816d, y: 0.48442309120519544d), new NpgsqlTypes.NpgsqlPoint(x: 0.18448241469101467d, y: 0.2440450877390673d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4568111619864966d, y: 0.43251020953865704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620959140040806d, y: 0.1793988779384369d), new NpgsqlTypes.NpgsqlPoint(x: 0.8686915274349841d, y: 0.2528531266944887d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13896331287836172d, y: 0.7338320558777481d), new NpgsqlTypes.NpgsqlPoint(x: 0.37074158003938784d, y: 0.3337876686313678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3584576744091844d, y: 0.8689844464970423d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6174379784467482d, y: 0.10579381760914186d), new NpgsqlTypes.NpgsqlPoint(x: 0.7588986964728686d, y: 0.2646624914553708d), new NpgsqlTypes.NpgsqlPoint(x: 0.17767890135890418d, y: 0.5788665135052652d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9210887061851719d, y: 0.5432884185777874d), new NpgsqlTypes.NpgsqlPoint(x: 0.44679815679898605d, y: 0.8040382254819612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6265768004917883d, y: 0.5045958345445586d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02564682459901757d, y: 0.36565213529081786d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930311728196038d, y: 0.8560551847686491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7679592087550478d, y: 0.2564935482611962d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9741280418363433d, y: 0.891104245445911d), new NpgsqlTypes.NpgsqlPoint(x: 0.31165539278169396d, y: 0.8583598227407d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657391190937014d, y: 0.7786009413448889d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4237856376315483d, y: 0.21187672544784375d), new NpgsqlTypes.NpgsqlPoint(x: 0.6163783700681558d, y: 0.07465051388041022d), new NpgsqlTypes.NpgsqlPoint(x: 0.8972652761511036d, y: 0.14527459191937564d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6346300342988562d, y: 0.3756938806112008d), new NpgsqlTypes.NpgsqlPoint(x: 0.31313224856777544d, y: 0.8247435539330947d), new NpgsqlTypes.NpgsqlPoint(x: 0.987040736793396d, y: 0.439980407597494d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34243073281890335d, y: 0.2017104190426695d), new NpgsqlTypes.NpgsqlPoint(x: 0.18046957290190924d, y: 0.37417813514800213d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071192829345674d, y: 0.3379004208728482d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7733328126031627d, y: 0.024990128614787d), new NpgsqlTypes.NpgsqlPoint(x: 0.14758283521022753d, y: 0.7946501713401986d), new NpgsqlTypes.NpgsqlPoint(x: 0.4035773420315789d, y: 0.9725141815235082d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09711207373921815d, y: 0.06818834758392744d), new NpgsqlTypes.NpgsqlPoint(x: 0.36536249737469695d, y: 0.32302000509026874d), new NpgsqlTypes.NpgsqlPoint(x: 0.09665340767411867d, y: 0.28762937459614335d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18957222701685295d, y: 0.15063637151151865d), new NpgsqlTypes.NpgsqlPoint(x: 0.30524331847495745d, y: 0.4511204146949799d), new NpgsqlTypes.NpgsqlPoint(x: 0.18953503086906986d, y: 0.8412699209965675d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07304848644106177d, y: 0.7273618479348973d), new NpgsqlTypes.NpgsqlPoint(x: 0.038659246345669196d, y: 0.4126433603409313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6592320827354143d, y: 0.5952984743637384d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3015384699178616d, y: 0.42244482431092734d), new NpgsqlTypes.NpgsqlPoint(x: 0.3949857232324283d, y: 0.7876544968695266d), new NpgsqlTypes.NpgsqlPoint(x: 0.8982304179153321d, y: 0.11531584501399761d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07312444521410022d, y: 0.5799306885257262d), new NpgsqlTypes.NpgsqlPoint(x: 0.19902687624125903d, y: 0.6504595527780724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3197841056243165d, y: 0.31337871432649667d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27866834238130356d, y: 0.3523371292397548d), new NpgsqlTypes.NpgsqlPoint(x: 0.28337165877725523d, y: 0.5603799409644014d), new NpgsqlTypes.NpgsqlPoint(x: 0.007047156512253849d, y: 0.3264367096547538d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07946194564887354d, y: 0.15113279328783913d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665185160904284d, y: 0.25237482154357593d), new NpgsqlTypes.NpgsqlPoint(x: 0.7365042919391513d, y: 0.7168579649710277d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5494665432307924d, y: 0.2276961346397236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621076096408752d, y: 0.32909132909920535d), new NpgsqlTypes.NpgsqlPoint(x: 0.1897857618942329d, y: 0.3587025879702215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8640839886304413d, y: 0.44083599424444886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861667241093549d, y: 0.04642044968628267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014057778157437d, y: 0.21933944163723174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8838672219701025d, y: 0.06834125167656535d), new NpgsqlTypes.NpgsqlPoint(x: 0.35076009255638996d, y: 0.834766181846957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1797392644563518d, y: 0.7330552429382783d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29923491232927735d, y: 0.4012593668699036d), new NpgsqlTypes.NpgsqlPoint(x: 0.869798533366184d, y: 0.42437626746249923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261842925702635d, y: 0.8766663966003809d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1730120534337769d, y: 0.6052832027576895d), new NpgsqlTypes.NpgsqlPoint(x: 0.691361425076422d, y: 0.8184019512606939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180130523316721d, y: 0.1161944863052723d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928617321381306d, y: 0.028664255917955295d), new NpgsqlTypes.NpgsqlPoint(x: 0.32805898485785634d, y: 0.3810626906388178d), new NpgsqlTypes.NpgsqlPoint(x: 0.483588507982576d, y: 0.747332575393742d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6885838333264724d, y: 0.516237290798267d), new NpgsqlTypes.NpgsqlPoint(x: 0.32305860343997816d, y: 0.47046446437770817d), new NpgsqlTypes.NpgsqlPoint(x: 0.33742729261751225d, y: 0.04420282011367449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9874262868183853d, y: 0.5554747591125155d), new NpgsqlTypes.NpgsqlPoint(x: 0.32203962809627573d, y: 0.5909907017563222d), new NpgsqlTypes.NpgsqlPoint(x: 0.974360920848199d, y: 0.35966551578733263d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846986640948791d, y: 0.48979840146519926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641888770441159d, y: 0.9873640777175492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888896173862706d, y: 0.9931804360537996d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19832644022824475d, y: 0.8024664378622459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583133428448645d, y: 0.7146241113459261d), new NpgsqlTypes.NpgsqlPoint(x: 0.18641599351413685d, y: 0.3921966810737634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108517901331513d, y: 0.483203088984418d), new NpgsqlTypes.NpgsqlPoint(x: 0.45092378460509275d, y: 0.47094530111280375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181732836739153d, y: 0.7922418339037093d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5558757238758791d, y: 0.3048935010666196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386431529944397d, y: 0.3426287737528283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930611396344113d, y: 0.13692312924267291d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5269751651907735d, y: 0.5298151842119826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299958090420752d, y: 0.28272398508282637d), new NpgsqlTypes.NpgsqlPoint(x: 0.12232508766555927d, y: 0.935490394618687d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6291112268211394d, y: 0.34538105214097303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6066948903906098d, y: 0.39557288073875563d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827531440597758d, y: 0.32124017881188616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19120767485431012d, y: 0.22977255423780896d), new NpgsqlTypes.NpgsqlPoint(x: 0.538136922170614d, y: 0.0735153018177025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5258217531418499d, y: 0.41549690697453423d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.845765579916767d, y: 0.8005064737082458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24892320711286742d, y: 0.645840187414522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360367982862785d, y: 0.5766835809252571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8505949039920833d, y: 0.42143058183319304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010826808818395d, y: 0.7685929017118318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413737780947246d, y: 0.33493876404962497d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8543641005183189d, y: 0.6198900651092704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329442929138926d, y: 0.2432623228218006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933209802088622d, y: 0.9576365902631463d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48557340785857284d, y: 0.9121887148062355d), new NpgsqlTypes.NpgsqlPoint(x: 0.18907245769053038d, y: 0.9752483895888279d), new NpgsqlTypes.NpgsqlPoint(x: 0.43056913221624027d, y: 0.4015102112761806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1647295311259952d, y: 0.6185307926763822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1840468945745669d, y: 0.7810745276766988d), new NpgsqlTypes.NpgsqlPoint(x: 0.47514708355228397d, y: 0.8033949125849338d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0700868653748079d, y: 0.0005248439606311273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851732630040823d, y: 0.8796060540695634d), new NpgsqlTypes.NpgsqlPoint(x: 0.03564151741733956d, y: 0.7369323075462048d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18368439718969154d, y: 0.3968471704217228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194675042252895d, y: 0.4875126326416419d), new NpgsqlTypes.NpgsqlPoint(x: 0.14180687641266132d, y: 0.25474494681340365d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9160497921870692d, y: 0.6160293108627121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315349781583092d, y: 0.8166112177593751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654297717207796d, y: 0.6309750938073301d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.931933505009048d, y: 0.4368077857443754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9596289044272868d, y: 0.9158488202531236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144857774789523d, y: 0.8890621678652095d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5511084884624287d, y: 0.12813263173858724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662143090746334d, y: 0.06975044235878025d), new NpgsqlTypes.NpgsqlPoint(x: 0.39128109810581646d, y: 0.9786624630872023d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5243546674972187d, y: 0.5493979496732835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147899915835284d, y: 0.49631247563275294d), new NpgsqlTypes.NpgsqlPoint(x: 0.058375715282291796d, y: 0.6690879671155405d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45092668945975645d, y: 0.8892441145932385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3181342584309794d, y: 0.7899799069069556d), new NpgsqlTypes.NpgsqlPoint(x: 0.824211156885547d, y: 0.5357820456218592d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7570893569522247d, y: 0.27166261365366184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541880198185346d, y: 0.9583547335003747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8675243098415251d, y: 0.9839885313814634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5307617176967622d, y: 0.24591584281649836d), new NpgsqlTypes.NpgsqlPoint(x: 0.6837022714006661d, y: 0.9545500467903261d), new NpgsqlTypes.NpgsqlPoint(x: 0.18654255225202354d, y: 0.4020663921067048d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5491788578414266d, y: 0.07003025660422824d), new NpgsqlTypes.NpgsqlPoint(x: 0.1210527672642937d, y: 0.7325325858326172d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465692976647587d, y: 0.7787526628676035d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5337901263553465d, y: 0.3965716142224055d), new NpgsqlTypes.NpgsqlPoint(x: 0.13690948480895315d, y: 0.9541407740252011d), new NpgsqlTypes.NpgsqlPoint(x: 0.005724627594465903d, y: 0.5647475578948603d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7064516750099641d, y: 0.8313791156168335d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444387580130595d, y: 0.9687563341955415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5089354032641098d, y: 0.11058880764463064d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016333345000839716d, y: 0.4088505520288922d), new NpgsqlTypes.NpgsqlPoint(x: 0.7959869272601227d, y: 0.4553714691676699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7683875777284701d, y: 0.5110498479367087d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23466274380104635d, y: 0.02163681755365854d), new NpgsqlTypes.NpgsqlPoint(x: 0.364756900297699d, y: 0.4779929786040813d), new NpgsqlTypes.NpgsqlPoint(x: 0.46595076780443745d, y: 0.6442904727645042d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08293842145448282d, y: 0.5154429941746607d), new NpgsqlTypes.NpgsqlPoint(x: 0.35018343693752474d, y: 0.3955042353505518d), new NpgsqlTypes.NpgsqlPoint(x: 0.47294552850032967d, y: 0.3640847508782581d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9429113780276753d, y: 0.2876550518066856d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596675776845067d, y: 0.2448086110065636d), new NpgsqlTypes.NpgsqlPoint(x: 0.9141866059828546d, y: 0.28839834382364415d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8470066148517954d, y: 0.6042951407858879d), new NpgsqlTypes.NpgsqlPoint(x: 0.18865328764423994d, y: 0.8379957332281289d), new NpgsqlTypes.NpgsqlPoint(x: 0.10175602025412012d, y: 0.2560133783093874d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6222996544261986d, y: 0.2676370165648908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9158013970791767d, y: 0.5668154492342501d), new NpgsqlTypes.NpgsqlPoint(x: 0.5492211703964847d, y: 0.7407415821493069d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7100364930844001d, y: 0.6361038219268734d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157520421623863d, y: 0.09547267277633753d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281494099106598d, y: 0.21879098559900834d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8392039182196444d, y: 0.01350615863386917d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705743822856703d, y: 0.85384802669391d), new NpgsqlTypes.NpgsqlPoint(x: 0.3120807987249139d, y: 0.5667502880182174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9260516957695099d, y: 0.6665285595636441d), new NpgsqlTypes.NpgsqlPoint(x: 0.3619436615590661d, y: 0.10595099797733765d), new NpgsqlTypes.NpgsqlPoint(x: 0.5777731979291949d, y: 0.48733709966444017d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9414291453767518d, y: 0.6025709548260972d), new NpgsqlTypes.NpgsqlPoint(x: 0.05385279006929011d, y: 0.1500654260183163d), new NpgsqlTypes.NpgsqlPoint(x: 0.7156691945732798d, y: 0.6039732373734059d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.740273075654497d, y: 0.5588714192888248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8282572741052909d, y: 0.7706240821530856d), new NpgsqlTypes.NpgsqlPoint(x: 0.36895046773108464d, y: 0.4293173900363275d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03639906134704951d, y: 0.4768329392510827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5214691892728543d, y: 0.6081765196261796d), new NpgsqlTypes.NpgsqlPoint(x: 0.3218231962679108d, y: 0.2946699354872714d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 6.96628986175396E-05d, y: 0.319834458094032d), new NpgsqlTypes.NpgsqlPoint(x: 0.44824740839678556d, y: 0.36925620373377344d), new NpgsqlTypes.NpgsqlPoint(x: 0.005782002330186664d, y: 0.15299408778999313d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10664417765491696d, y: 0.8432722899696697d), new NpgsqlTypes.NpgsqlPoint(x: 0.5310999904040621d, y: 0.6927400462100436d), new NpgsqlTypes.NpgsqlPoint(x: 0.31348342573665344d, y: 0.21082644348399282d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.633094790288658d, y: 0.42243758381845997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6143317559587506d, y: 0.5252592498132123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7209399174436736d, y: 0.9882134033956457d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10590550728147086d, y: 0.6105340909977766d), new NpgsqlTypes.NpgsqlPoint(x: 0.7828334141126009d, y: 0.6840661553139563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9945921566886953d, y: 0.6006111071277876d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2146830741177168d, y: 0.3286225475744651d), new NpgsqlTypes.NpgsqlPoint(x: 0.862277736061286d, y: 0.9072686460733306d), new NpgsqlTypes.NpgsqlPoint(x: 0.42634090818565085d, y: 0.0590488814449478d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3211007287241323d, y: 0.042798153961043695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7212045556807065d, y: 0.4710114100426782d), new NpgsqlTypes.NpgsqlPoint(x: 0.30084300361694005d, y: 0.13560853325346856d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8425841864791612d, y: 0.35071086602712676d), new NpgsqlTypes.NpgsqlPoint(x: 0.0795111311183444d, y: 0.3488137172336474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5665954450802259d, y: 0.4340393142557655d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3818171020861959d, y: 0.4584409164786052d), new NpgsqlTypes.NpgsqlPoint(x: 0.02256983412172464d, y: 0.14645115156668542d), new NpgsqlTypes.NpgsqlPoint(x: 0.22898790846034056d, y: 0.7192201158124992d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13551152481182316d, y: 0.5121134599833231d), new NpgsqlTypes.NpgsqlPoint(x: 0.74402275063915d, y: 0.6369776073161006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8187115113757286d, y: 0.5185632796717093d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9072825893609375d, y: 0.5964397507129526d), new NpgsqlTypes.NpgsqlPoint(x: 0.3695055051146743d, y: 0.9332625845235984d), new NpgsqlTypes.NpgsqlPoint(x: 0.7556633832773079d, y: 0.23206360307347684d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4116057675958352d, y: 0.6663401796560882d), new NpgsqlTypes.NpgsqlPoint(x: 0.023477939378461987d, y: 0.5985270854593965d), new NpgsqlTypes.NpgsqlPoint(x: 0.7709241556299896d, y: 0.9174200486316214d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12251809690148752d, y: 0.7989061909490233d), new NpgsqlTypes.NpgsqlPoint(x: 0.4571660900280735d, y: 0.29111618674966333d), new NpgsqlTypes.NpgsqlPoint(x: 0.7004535142028829d, y: 0.8196361648035513d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3914350433173477d, y: 0.0807607861577998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673468156294153d, y: 0.5533126867990247d), new NpgsqlTypes.NpgsqlPoint(x: 0.33193223235510205d, y: 0.01466059360704397d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3686269349521294d, y: 0.7766559620071247d), new NpgsqlTypes.NpgsqlPoint(x: 0.2809181326685577d, y: 0.14009011125143866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5515022729137434d, y: 0.972377781447424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8504877693456349d, y: 0.8362729909839293d), new NpgsqlTypes.NpgsqlPoint(x: 0.96022540013163d, y: 0.8375725777806226d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859043787782704d, y: 0.2788980632689041d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10120794356771357d, y: 0.8237363837174331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3438603480477531d, y: 0.24946396300771434d), new NpgsqlTypes.NpgsqlPoint(x: 0.24153689170831516d, y: 0.7351094226711485d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13990323094896628d, y: 0.12733025964612543d), new NpgsqlTypes.NpgsqlPoint(x: 0.5613399159631137d, y: 0.39570641419921826d), new NpgsqlTypes.NpgsqlPoint(x: 0.604941845959089d, y: 0.9050545827511588d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33517691608992217d, y: 0.28491688530178816d), new NpgsqlTypes.NpgsqlPoint(x: 0.19245234209003692d, y: 0.8947403179665728d), new NpgsqlTypes.NpgsqlPoint(x: 0.11848150959991233d, y: 0.08058093158370883d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4129047240499988d, y: 0.04789443950706984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5121551758585993d, y: 0.9782777728649614d), new NpgsqlTypes.NpgsqlPoint(x: 0.29789017404982d, y: 0.16993697685539966d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.994670252776335d, y: 0.010618387155959197d), new NpgsqlTypes.NpgsqlPoint(x: 0.2998217755438448d, y: 0.09820195934097675d), new NpgsqlTypes.NpgsqlPoint(x: 0.11003206908862306d, y: 0.9394134405899134d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9790699604082799d, y: 0.8662679214713555d), new NpgsqlTypes.NpgsqlPoint(x: 0.3090961232087863d, y: 0.619818981878676d), new NpgsqlTypes.NpgsqlPoint(x: 0.604036784826744d, y: 0.4118791021450594d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.047682012824285525d, y: 0.9952290736216264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407531940484852d, y: 0.31918342179827675d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904171437785998d, y: 0.32639233815987223d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.429449308217452d, y: 0.8408943461820937d), new NpgsqlTypes.NpgsqlPoint(x: 0.771233188652301d, y: 0.5385382883056641d), new NpgsqlTypes.NpgsqlPoint(x: 0.3441927604688251d, y: 0.5048419925927962d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8155172736965826d, y: 0.45750675224551873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139316747001731d, y: 0.7866972362029692d), new NpgsqlTypes.NpgsqlPoint(x: 0.11154085050593188d, y: 0.017971428972240466d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.933581134537852d, y: 0.2454343202337398d), new NpgsqlTypes.NpgsqlPoint(x: 0.36590288470810994d, y: 0.9214118489678523d), new NpgsqlTypes.NpgsqlPoint(x: 0.3522865170218915d, y: 0.2434296518536162d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3763199792502423d, y: 0.9419914719455379d), new NpgsqlTypes.NpgsqlPoint(x: 0.142386807903917d, y: 0.30553874221774124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7460201875023792d, y: 0.7255569076317636d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9477220359959732d, y: 0.6653484387148003d), new NpgsqlTypes.NpgsqlPoint(x: 0.6639333279953201d, y: 0.138450329624346d), new NpgsqlTypes.NpgsqlPoint(x: 0.21484023905270788d, y: 0.20278664343195707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19224542997857208d, y: 0.19807341077814622d), new NpgsqlTypes.NpgsqlPoint(x: 0.779915616840402d, y: 0.5222950440335504d), new NpgsqlTypes.NpgsqlPoint(x: 0.12907119954427293d, y: 0.5368751137274296d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9913625817920092d, y: 0.8291083324532009d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974317954319632d, y: 0.06295835358602275d), new NpgsqlTypes.NpgsqlPoint(x: 0.3160956786782273d, y: 0.46644708513212596d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6722616153474035d, y: 0.6615829975695069d), new NpgsqlTypes.NpgsqlPoint(x: 0.5494853553308481d, y: 0.233595430735538d), new NpgsqlTypes.NpgsqlPoint(x: 0.34315313820280613d, y: 0.9681795445687419d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7725855496385331d, y: 0.750785000134622d), new NpgsqlTypes.NpgsqlPoint(x: 0.15223043979719142d, y: 0.746455122762538d), new NpgsqlTypes.NpgsqlPoint(x: 0.10267373857059348d, y: 0.14291310153986203d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9624103974368589d, y: 0.332681363375682d), new NpgsqlTypes.NpgsqlPoint(x: 0.4673016411920399d, y: 0.5682117814883343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9499898411935964d, y: 0.9181830741101814d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472669195003087d, y: 0.4756010185297064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673132365906798d, y: 0.5178321264718713d), new NpgsqlTypes.NpgsqlPoint(x: 0.4807669816882222d, y: 0.5648299927820806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5950250064497887d, y: 0.27774832697968d), new NpgsqlTypes.NpgsqlPoint(x: 0.8600114255984044d, y: 0.12028305860821664d), new NpgsqlTypes.NpgsqlPoint(x: 0.4693515594707407d, y: 0.18700137791387295d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8192472923629763d, y: 0.28234709393193735d), new NpgsqlTypes.NpgsqlPoint(x: 0.16626058601289062d, y: 0.6003886450046165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9988328222972829d, y: 0.2552619605791846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09909234856110083d, y: 0.9070085483465566d), new NpgsqlTypes.NpgsqlPoint(x: 0.5154450377814872d, y: 0.20946864771466445d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940913530643287d, y: 0.3567776258783797d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2829582222372371d, y: 0.38001149520109445d), new NpgsqlTypes.NpgsqlPoint(x: 0.12371950874817894d, y: 0.6681640491905696d), new NpgsqlTypes.NpgsqlPoint(x: 0.3351944816165544d, y: 0.6870591071482814d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3531760001610771d, y: 0.3932140899416571d), new NpgsqlTypes.NpgsqlPoint(x: 0.5600441332672578d, y: 0.5922006254083905d), new NpgsqlTypes.NpgsqlPoint(x: 0.25084218714686424d, y: 0.10484545291101088d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8488248570533431d, y: 0.6862026916495975d), new NpgsqlTypes.NpgsqlPoint(x: 0.09504843958033038d, y: 0.18928300554526245d), new NpgsqlTypes.NpgsqlPoint(x: 0.5529631793532903d, y: 0.025911867736302385d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7685848313394419d, y: 0.4659619668903823d), new NpgsqlTypes.NpgsqlPoint(x: 0.3758390930596084d, y: 0.29402113222623816d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662895300461768d, y: 0.6774994012195152d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6768751200286314d, y: 0.8405607848778056d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739052796389668d, y: 0.7812515851466579d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198082067180844d, y: 0.6456964057239131d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12958191160255317d, y: 0.19779333222325746d), new NpgsqlTypes.NpgsqlPoint(x: 0.359437032713415d, y: 0.5300321912119782d), new NpgsqlTypes.NpgsqlPoint(x: 0.13527190619870877d, y: 0.7348150039039721d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23770977758738332d, y: 0.4172320424731313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6204839058152818d, y: 0.16410161617019337d), new NpgsqlTypes.NpgsqlPoint(x: 0.5271615160326923d, y: 0.7527663588252567d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1505174568605392d, y: 0.5683007983509522d), new NpgsqlTypes.NpgsqlPoint(x: 0.47751177687953306d, y: 0.3292932523522678d), new NpgsqlTypes.NpgsqlPoint(x: 0.4680862105840441d, y: 0.9950034095191502d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17194337124357628d, y: 0.17162612502184993d), new NpgsqlTypes.NpgsqlPoint(x: 0.37089842431630515d, y: 0.12428216442841289d), new NpgsqlTypes.NpgsqlPoint(x: 0.3214404735020656d, y: 0.6088611000374374d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9000847836302135d, y: 0.4908246708560847d), new NpgsqlTypes.NpgsqlPoint(x: 0.09036093134741552d, y: 0.5347165841008183d), new NpgsqlTypes.NpgsqlPoint(x: 0.27902979467202316d, y: 0.3132275785133013d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9467749995273517d, y: 0.16953009282139453d), new NpgsqlTypes.NpgsqlPoint(x: 0.3218680161580214d, y: 0.2721780893245038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5038486040031183d, y: 0.04434518502520046d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7024970227931093d, y: 0.6580498556247454d), new NpgsqlTypes.NpgsqlPoint(x: 0.611566156739781d, y: 0.5555779757025298d), new NpgsqlTypes.NpgsqlPoint(x: 0.16573869391626506d, y: 0.011356179562558522d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34365833384592315d, y: 0.11416952063780461d), new NpgsqlTypes.NpgsqlPoint(x: 0.473586442118629d, y: 0.6736856558045656d), new NpgsqlTypes.NpgsqlPoint(x: 0.5124287438313275d, y: 0.21513818801980156d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17621770596421038d, y: 0.7364061024129076d), new NpgsqlTypes.NpgsqlPoint(x: 0.2892611243611054d, y: 0.023582735637575514d), new NpgsqlTypes.NpgsqlPoint(x: 0.2794117807303438d, y: 0.40010945715241175d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041080925754260034d, y: 0.9573067820588587d), new NpgsqlTypes.NpgsqlPoint(x: 0.9501607918715881d, y: 0.1896492362883d), new NpgsqlTypes.NpgsqlPoint(x: 0.9925178884123255d, y: 0.7457103645450488d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7083381379865074d, y: 0.4866717135272458d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233849816052569d, y: 0.05077514699476127d), new NpgsqlTypes.NpgsqlPoint(x: 0.2626432807117959d, y: 0.5602445740357062d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7574711549484205d, y: 0.42624374421915323d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094002318376661d, y: 0.0028147464819151535d), new NpgsqlTypes.NpgsqlPoint(x: 0.6822783415792886d, y: 0.0693054366477227d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7610463698695827d, y: 0.704492494693965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6389549986673129d, y: 0.9156686267774827d), new NpgsqlTypes.NpgsqlPoint(x: 0.6149105573618773d, y: 0.937821899608182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3548001895250914d, y: 0.0809877533016754d), new NpgsqlTypes.NpgsqlPoint(x: 0.07143416942505165d, y: 0.8534334869735279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4284059802982223d, y: 0.1591136396366446d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7192162300831986d, y: 0.7439303742931473d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536333285112136d, y: 0.16273744054797723d), new NpgsqlTypes.NpgsqlPoint(x: 0.797514916400026d, y: 0.8301790046233142d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32030293494064166d, y: 0.7256426731404871d), new NpgsqlTypes.NpgsqlPoint(x: 0.3604080536920239d, y: 0.05269376267400627d), new NpgsqlTypes.NpgsqlPoint(x: 0.6360503855277063d, y: 0.8528618587512607d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5678880450911792d, y: 0.9340137420732444d), new NpgsqlTypes.NpgsqlPoint(x: 0.10116705171358609d, y: 0.0678766434322664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388140243847415d, y: 0.6844360666859094d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7161959376869312d, y: 0.3188353942339024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341992484241336d, y: 0.6746347131698287d), new NpgsqlTypes.NpgsqlPoint(x: 0.3162351284464957d, y: 0.6188442759445261d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5851073545341946d, y: 0.5012836640279645d), new NpgsqlTypes.NpgsqlPoint(x: 0.09953680928231523d, y: 0.7874680583805562d), new NpgsqlTypes.NpgsqlPoint(x: 0.8342816892693473d, y: 0.6610419970585176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2563279322998374d, y: 0.2852867599350517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9125089982674132d, y: 0.5462796063492081d), new NpgsqlTypes.NpgsqlPoint(x: 0.1190301232420845d, y: 0.2415264198778817d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.887376376516359d, y: 0.19277517831917967d), new NpgsqlTypes.NpgsqlPoint(x: 0.03552223652831954d, y: 0.9828395328035298d), new NpgsqlTypes.NpgsqlPoint(x: 0.28124145521582256d, y: 0.2529627312355225d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.988568644163635d, y: 0.1450129577664908d), new NpgsqlTypes.NpgsqlPoint(x: 0.5729195914096316d, y: 0.9641184806071182d), new NpgsqlTypes.NpgsqlPoint(x: 0.09282141644222797d, y: 0.2516447182774847d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2166706541895954d, y: 0.9418321249104058d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309818894202027d, y: 0.5986979879850323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533119861876861d, y: 0.9018727104761376d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005370002772008831d, y: 0.6261129903445932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701808246426088d, y: 0.31914073049982195d), new NpgsqlTypes.NpgsqlPoint(x: 0.1777764630014167d, y: 0.399606656038091d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42216967735095257d, y: 0.09839563926142048d), new NpgsqlTypes.NpgsqlPoint(x: 0.93458966160099d, y: 0.8109982128467174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739726533909684d, y: 0.2994251013073892d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15506240476471111d, y: 0.28836989823156856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7700803412158472d, y: 0.4877428968997146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140251787916533d, y: 0.07734538748804776d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39494169542784363d, y: 0.7648817805950382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223587752028736d, y: 0.22747154703991967d), new NpgsqlTypes.NpgsqlPoint(x: 0.41502247342532883d, y: 0.16541120884234772d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.590154837014903d, y: 0.06125921556373115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258454130392894d, y: 0.11884729240650493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036459542169533d, y: 0.36173583532775033d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07061014694615608d, y: 0.633063402320581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4504169736521215d, y: 0.4126419349629047d), new NpgsqlTypes.NpgsqlPoint(x: 0.04305602915366369d, y: 0.39707772152493004d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04345714017981195d, y: 0.28550565487240864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040443719168952d, y: 0.6801340609407566d), new NpgsqlTypes.NpgsqlPoint(x: 0.1771846986485489d, y: 0.17007938248330934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21818061065431316d, y: 0.9823968577342654d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141299413532092d, y: 0.2414535345021338d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533762960121463d, y: 0.19023430768658722d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25692567688724555d, y: 0.47565690841589825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065273210447248d, y: 0.5178327842097221d), new NpgsqlTypes.NpgsqlPoint(x: 0.41483628497891667d, y: 0.5368125591529488d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8032642779511756d, y: 0.3309631000144957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966538902008057d, y: 0.4436853060156406d), new NpgsqlTypes.NpgsqlPoint(x: 0.0681551136524412d, y: 0.8782616481738328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6185880625680611d, y: 0.31632251137686906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464316089390589d, y: 0.02273735478211525d), new NpgsqlTypes.NpgsqlPoint(x: 0.1364432585863382d, y: 0.6783246728784011d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9959031354559927d, y: 0.7204825794615085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440636927794242d, y: 0.33357876082886506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6562114966706034d, y: 0.28812034654999574d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2432641456304946d, y: 0.7426728290381744d), new NpgsqlTypes.NpgsqlPoint(x: 0.059197114234514014d, y: 0.5290552464619949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152731530834603d, y: 0.37499356520054106d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7473553933211549d, y: 0.5622966130190776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006006805471254d, y: 0.8947061904389458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516796498692914d, y: 0.9905461497156388d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06172616481396609d, y: 0.7107645932402976d), new NpgsqlTypes.NpgsqlPoint(x: 0.46853609885779723d, y: 0.4290410311402877d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899376805197755d, y: 0.04785188507429594d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8694498352731092d, y: 0.001061363506871138d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367702565839289d, y: 0.7798017017030173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764791916513851d, y: 0.8495488451018173d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06252408664973497d, y: 0.5425766149633985d), new NpgsqlTypes.NpgsqlPoint(x: 0.20173871029628654d, y: 0.8630944075970179d), new NpgsqlTypes.NpgsqlPoint(x: 0.11776559950259136d, y: 0.5457835331334526d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8810057441616632d, y: 0.4874986374167687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3112997448513819d, y: 0.9391920630911605d), new NpgsqlTypes.NpgsqlPoint(x: 0.29597837244177205d, y: 0.7634772540385759d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20364171598143377d, y: 0.0255925537217363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8754451864099629d, y: 0.5816833817592786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7435770233716602d, y: 0.19338550128454768d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0142442723473436d, y: 0.20732759111893806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827308471180114d, y: 0.71546131847681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299291186574077d, y: 0.5174025165802169d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9402859374077043d, y: 0.497829868811568d), new NpgsqlTypes.NpgsqlPoint(x: 0.0788954924213745d, y: 0.26712311660765764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903046731742554d, y: 0.24770766380317322d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7922974810206228d, y: 0.2743497643572621d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095239110795726d, y: 0.6607575257715999d), new NpgsqlTypes.NpgsqlPoint(x: 0.02323924732994531d, y: 0.7310383408680825d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.82898726990358d, y: 0.8937610079261136d), new NpgsqlTypes.NpgsqlPoint(x: 0.829884945078936d, y: 0.8548219248159643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100382028150468d, y: 0.4898361174853406d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6710231629668396d, y: 0.9877956197075785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722154175317929d, y: 0.3510899262912993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174171528990833d, y: 0.33543711130945464d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39589000853844636d, y: 0.01091126220959926d), new NpgsqlTypes.NpgsqlPoint(x: 0.19217039416070203d, y: 0.6058106658448082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865850133460105d, y: 0.3475460449165414d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19381977971938635d, y: 0.3624659712132652d), new NpgsqlTypes.NpgsqlPoint(x: 0.10441115489170127d, y: 0.4815853451878026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07469332315749433d, y: 0.2567728291372723d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7303382774227188d, y: 0.31838098198942366d), new NpgsqlTypes.NpgsqlPoint(x: 0.00029231491491710226d, y: 0.5691123142047617d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057031772826475d, y: 0.27243436664123877d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8574251328095868d, y: 0.9205012616797239d), new NpgsqlTypes.NpgsqlPoint(x: 0.7671530115734299d, y: 0.15933185430633467d), new NpgsqlTypes.NpgsqlPoint(x: 0.4010991191046295d, y: 0.815749591002817d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40197093930110017d, y: 0.5428442134708454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3206134087889434d, y: 0.5427837109246642d), new NpgsqlTypes.NpgsqlPoint(x: 0.03273365514967286d, y: 0.6283565985643678d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8562837229666983d, y: 0.3089553544307727d), new NpgsqlTypes.NpgsqlPoint(x: 0.7372703953488285d, y: 0.9934155354979768d), new NpgsqlTypes.NpgsqlPoint(x: 0.28431058665344533d, y: 0.55592624260392d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40013001163845974d, y: 0.9817384297118945d), new NpgsqlTypes.NpgsqlPoint(x: 0.4266308355189493d, y: 0.455180456255766d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290185407345287d, y: 0.23196073516539895d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.887409717939386d, y: 0.5191093790926478d), new NpgsqlTypes.NpgsqlPoint(x: 0.4919665801611509d, y: 0.06652844257307833d), new NpgsqlTypes.NpgsqlPoint(x: 0.23014122526237724d, y: 0.9823928241662827d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6598105567743399d, y: 0.7378525556420618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402300836312182d, y: 0.5626742629172863d), new NpgsqlTypes.NpgsqlPoint(x: 0.40161581751709363d, y: 0.07698331608258469d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12176150529933538d, y: 0.6618931904921294d), new NpgsqlTypes.NpgsqlPoint(x: 0.282606670001308d, y: 0.30983735253767286d), new NpgsqlTypes.NpgsqlPoint(x: 0.45914552858522006d, y: 0.9233845061664602d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8598884438104059d, y: 0.08079324008433653d), new NpgsqlTypes.NpgsqlPoint(x: 0.46689314351845823d, y: 0.3470388856894884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4181995485383585d, y: 0.17870395519700133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6117261744636134d, y: 0.6497706157281776d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537975714183903d, y: 0.9432782060299266d), new NpgsqlTypes.NpgsqlPoint(x: 0.584579235844943d, y: 0.9648971970097048d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.330824795008847d, y: 0.6484935131579423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7215282030817258d, y: 0.7107039053612849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5197433538401318d, y: 0.6403576950383167d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29518440376093236d, y: 0.09369855629115376d), new NpgsqlTypes.NpgsqlPoint(x: 0.37369764855581d, y: 0.1976199396061844d), new NpgsqlTypes.NpgsqlPoint(x: 0.22761992720266921d, y: 0.8226256128815823d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5228074361434785d, y: 0.4239906279646187d), new NpgsqlTypes.NpgsqlPoint(x: 0.7442162280068099d, y: 0.4110910579664714d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633900594262818d, y: 0.025702770771218186d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42920822942590775d, y: 0.17264766494440387d), new NpgsqlTypes.NpgsqlPoint(x: 0.22616232132433334d, y: 0.5636371202010338d), new NpgsqlTypes.NpgsqlPoint(x: 0.5798984090819651d, y: 0.7604571179295293d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9416238486561478d, y: 0.17043377428677553d), new NpgsqlTypes.NpgsqlPoint(x: 0.6226394375544012d, y: 0.34625579325990996d), new NpgsqlTypes.NpgsqlPoint(x: 0.4384728918260955d, y: 0.6411465357009329d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6691383483333475d, y: 0.307900284459637d), new NpgsqlTypes.NpgsqlPoint(x: 0.47732130710238196d, y: 0.6977434019507455d), new NpgsqlTypes.NpgsqlPoint(x: 0.1747161948075875d, y: 0.141883472037724d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5405155796002296d, y: 0.8715226060382154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223901254311828d, y: 0.5398661136450159d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245203827566987d, y: 0.032160278028000255d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9904203391824485d, y: 0.935112146179837d), new NpgsqlTypes.NpgsqlPoint(x: 0.06996705593914798d, y: 0.4018965569503208d), new NpgsqlTypes.NpgsqlPoint(x: 0.2783366526962785d, y: 0.1937236374299639d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9324312327064223d, y: 0.7271344371344153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2602906924772017d, y: 0.42249044633212096d), new NpgsqlTypes.NpgsqlPoint(x: 0.9082808757405514d, y: 0.11110831696703316d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07672649047458968d, y: 0.3527293467557703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8133824942838155d, y: 0.6649699149725596d), new NpgsqlTypes.NpgsqlPoint(x: 0.043916807601090846d, y: 0.3237298260253275d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23396809012345055d, y: 0.8703928324667539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367664556831782d, y: 0.1887995287414893d), new NpgsqlTypes.NpgsqlPoint(x: 0.09179543827482028d, y: 0.6719356644992642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9529079626039928d, y: 0.2933592434226284d), new NpgsqlTypes.NpgsqlPoint(x: 0.9600277734558091d, y: 0.8873644592847976d), new NpgsqlTypes.NpgsqlPoint(x: 0.30150641772665265d, y: 0.023200727105866514d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5656725757191524d, y: 0.128644652225818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6815331761863022d, y: 0.5263486254853101d), new NpgsqlTypes.NpgsqlPoint(x: 0.637462297453491d, y: 0.6349711831636677d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8570480267022869d, y: 0.7363165474532054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8985552242325411d, y: 0.9753283785847887d), new NpgsqlTypes.NpgsqlPoint(x: 0.7061419448087134d, y: 0.6596779686474658d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4002480379904022d, y: 0.45920884817728547d), new NpgsqlTypes.NpgsqlPoint(x: 0.2035279186677943d, y: 0.9351640721047455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4246953617115119d, y: 0.10232280269702931d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6660654603411188d, y: 0.8739071984807366d), new NpgsqlTypes.NpgsqlPoint(x: 0.14653300668258573d, y: 0.2699400492181614d), new NpgsqlTypes.NpgsqlPoint(x: 0.02320121915806095d, y: 0.6197930474846868d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46003753311648565d, y: 0.6010743672500148d), new NpgsqlTypes.NpgsqlPoint(x: 0.287809146680559d, y: 0.23416758784824176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9241016803635685d, y: 0.28776653826651954d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9659752872874648d, y: 0.5613734460302531d), new NpgsqlTypes.NpgsqlPoint(x: 0.03516630659986719d, y: 0.47972020523885106d), new NpgsqlTypes.NpgsqlPoint(x: 0.22458859801137487d, y: 0.7279822503983775d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.009133701940375438d, y: 0.7458219399431893d), new NpgsqlTypes.NpgsqlPoint(x: 0.8821306368472471d, y: 0.7123330345684721d), new NpgsqlTypes.NpgsqlPoint(x: 0.1593492811446684d, y: 0.1456076366608008d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42560603685329657d, y: 0.8031898466421308d), new NpgsqlTypes.NpgsqlPoint(x: 0.7969236459192276d, y: 0.6913722458038133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111105180985686d, y: 0.25715663401359257d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6835706153229193d, y: 0.3295442952872669d), new NpgsqlTypes.NpgsqlPoint(x: 0.642114213878723d, y: 0.5699211875394478d), new NpgsqlTypes.NpgsqlPoint(x: 0.19565786613711045d, y: 0.9807581572992816d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8499203848624661d, y: 0.885840547017019d), new NpgsqlTypes.NpgsqlPoint(x: 0.9604559613630431d, y: 0.29796505751988134d), new NpgsqlTypes.NpgsqlPoint(x: 0.42078900057722124d, y: 0.7405746630383022d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4107110111370458d, y: 0.5159212030029868d), new NpgsqlTypes.NpgsqlPoint(x: 0.827550678575198d, y: 0.8061512555915069d), new NpgsqlTypes.NpgsqlPoint(x: 0.021987918929326833d, y: 0.03189835653145845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007012305118453743d, y: 0.22425470148904625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6686090088220884d, y: 0.4489287768916702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5486766707118363d, y: 0.7190298591718081d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.276951060448387d, y: 0.36867854528515454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4194719224899618d, y: 0.08877606182807152d), new NpgsqlTypes.NpgsqlPoint(x: 0.35349746907993196d, y: 0.30818838117529934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04549248107525694d, y: 0.3603502285065394d), new NpgsqlTypes.NpgsqlPoint(x: 0.5730005339417216d, y: 0.2976777503141663d), new NpgsqlTypes.NpgsqlPoint(x: 0.006832216690270787d, y: 0.5249183494772357d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5847552423819041d, y: 0.5179768277764571d), new NpgsqlTypes.NpgsqlPoint(x: 0.6194469313773499d, y: 0.7857898133577953d), new NpgsqlTypes.NpgsqlPoint(x: 0.08147522337832769d, y: 0.3278037209327269d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9285350105398243d, y: 0.7129164978972874d), new NpgsqlTypes.NpgsqlPoint(x: 0.11301090174472417d, y: 0.14765176240505684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9841841514569607d, y: 0.8036854328770733d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37182124658036186d, y: 0.6019521911478858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5224652274835484d, y: 0.2774585067611479d), new NpgsqlTypes.NpgsqlPoint(x: 0.26082162851588886d, y: 0.5790379451106241d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34148592333017136d, y: 0.5705587346581589d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421823431969845d, y: 0.8369186760811281d), new NpgsqlTypes.NpgsqlPoint(x: 0.9342143298320762d, y: 0.8071326506590945d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7396981617722507d, y: 0.9624429961117905d), new NpgsqlTypes.NpgsqlPoint(x: 0.019955378454747708d, y: 0.11633394894959814d), new NpgsqlTypes.NpgsqlPoint(x: 0.464998072136089d, y: 0.2827482077289858d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054212617615696956d, y: 0.8893918403182942d), new NpgsqlTypes.NpgsqlPoint(x: 0.7472846966997925d, y: 0.2838767891922239d), new NpgsqlTypes.NpgsqlPoint(x: 0.028465882331662584d, y: 0.44945206447952446d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24622508574809587d, y: 0.6551803591136642d), new NpgsqlTypes.NpgsqlPoint(x: 0.3430901377900425d, y: 0.37391350693188474d), new NpgsqlTypes.NpgsqlPoint(x: 0.0934125472402545d, y: 0.9364761651556213d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22649225306804854d, y: 0.43181676976249117d), new NpgsqlTypes.NpgsqlPoint(x: 0.49947183590582167d, y: 0.017041914561076177d), new NpgsqlTypes.NpgsqlPoint(x: 0.2645437956944159d, y: 0.23609240074620763d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6887827369355657d, y: 0.511645822373419d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162286351693078d, y: 0.5067843075303557d), new NpgsqlTypes.NpgsqlPoint(x: 0.05668873518987083d, y: 0.4633790880552925d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.235309906788558d, y: 0.7872135225932299d), new NpgsqlTypes.NpgsqlPoint(x: 0.33086103663826116d, y: 0.7919273288728751d), new NpgsqlTypes.NpgsqlPoint(x: 0.5840704580187103d, y: 0.33519751932305497d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5738637749345427d, y: 0.3073049676606342d), new NpgsqlTypes.NpgsqlPoint(x: 0.18565255610188935d, y: 0.4476649085598552d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859890822290669d, y: 0.4727313498037693d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2694027540899342d, y: 0.2720084352096551d), new NpgsqlTypes.NpgsqlPoint(x: 0.8798924217367726d, y: 0.14026267103644618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5864296884130139d, y: 0.8075705114297682d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41037234534221156d, y: 0.5517786206663043d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541085730601252d, y: 0.8197090916028126d), new NpgsqlTypes.NpgsqlPoint(x: 0.10261307293440969d, y: 0.11079623679658246d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3009405648814679d, y: 0.10969316781230642d), new NpgsqlTypes.NpgsqlPoint(x: 0.06098329699118887d, y: 0.028295600721624403d), new NpgsqlTypes.NpgsqlPoint(x: 0.7565114723108513d, y: 0.3370898542866345d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8264268096251417d, y: 0.6883917904266666d), new NpgsqlTypes.NpgsqlPoint(x: 0.2343826704293115d, y: 0.5839210970222407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8156361383384619d, y: 0.3885688453089955d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6602150216112668d, y: 0.9652782773816128d), new NpgsqlTypes.NpgsqlPoint(x: 0.29510489634462955d, y: 0.30519270884802296d), new NpgsqlTypes.NpgsqlPoint(x: 0.5538794124828978d, y: 0.8955296689770433d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4105467834621862d, y: 0.8371805903431434d), new NpgsqlTypes.NpgsqlPoint(x: 0.21873024530154117d, y: 0.5813956767450867d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395154239366452d, y: 0.6421864482723175d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8238129699063358d, y: 0.2092066076309843d), new NpgsqlTypes.NpgsqlPoint(x: 0.009717146510171304d, y: 0.6707220126127162d), new NpgsqlTypes.NpgsqlPoint(x: 0.3290293173943045d, y: 0.23847908223105507d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49822495468543415d, y: 0.28045879600257884d), new NpgsqlTypes.NpgsqlPoint(x: 0.48878977120336997d, y: 0.1712389294714154d), new NpgsqlTypes.NpgsqlPoint(x: 0.8254459701141013d, y: 0.8456344403540491d)), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9230736083009765d, y: 0.8250020282106626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070939805057305d, y: 0.6992299828889761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536210141052123d, y: 0.7835942626828954d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9051573823848943d, y: 0.1561710078023666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4072264333686524d, y: 0.1590465012420338d), new NpgsqlTypes.NpgsqlPoint(x: 0.04989551164575634d, y: 0.7038126299789151d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6860380972986079d, y: 0.24108370707515914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916009142514967d, y: 0.4361579488604306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559622835848822d, y: 0.4213978542735384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5345318005429025d, y: 0.37710899221078387d), new NpgsqlTypes.NpgsqlPoint(x: 0.43666212277861516d, y: 0.9733805653809641d), new NpgsqlTypes.NpgsqlPoint(x: 0.22727774481379026d, y: 0.05231869876705242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6603834530355827d, y: 0.8589156074359212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397366571668489d, y: 0.5182045819257209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028515313035706d, y: 0.6439142188849855d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03895816264470486d, y: 0.3994055455718858d), new NpgsqlTypes.NpgsqlPoint(x: 0.2491877785452017d, y: 0.3386505713629211d), new NpgsqlTypes.NpgsqlPoint(x: 0.36246678643966046d, y: 0.5849129483638835d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3617694202516827d, y: 0.8112377423144868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075016079976086d, y: 0.43171622321552616d), new NpgsqlTypes.NpgsqlPoint(x: 0.803051362250414d, y: 0.30868852581446493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39159677323289355d, y: 0.12158901560356383d), new NpgsqlTypes.NpgsqlPoint(x: 0.17888703745560908d, y: 0.11901415858859765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974894011482513d, y: 0.4581348876809598d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6358084343612207d, y: 0.0952737147059568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147906690033821d, y: 0.03431356517428952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709230521684719d, y: 0.812474143057176d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17223358977097203d, y: 0.2659019732078687d), new NpgsqlTypes.NpgsqlPoint(x: 0.06921330570238748d, y: 0.42088472789036324d), new NpgsqlTypes.NpgsqlPoint(x: 0.24650524318805955d, y: 0.32169338929252533d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9313424668747489d, y: 0.22151305764794416d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618501130442437d, y: 0.26848719997969894d), new NpgsqlTypes.NpgsqlPoint(x: 0.49966368420374085d, y: 0.5921410393276112d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3865473656884095d, y: 0.4790472587313016d), new NpgsqlTypes.NpgsqlPoint(x: 0.48370306062686363d, y: 0.7184082323655561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641829266734766d, y: 0.7519154636760681d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33681437256369007d, y: 0.839240974392767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3618081691704311d, y: 0.9481527572882877d), new NpgsqlTypes.NpgsqlPoint(x: 0.449129737940434d, y: 0.14686358706847957d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3835508185903691d, y: 0.42956763921674523d), new NpgsqlTypes.NpgsqlPoint(x: 0.45858897516306496d, y: 0.011028856097184625d), new NpgsqlTypes.NpgsqlPoint(x: 0.08693699150627121d, y: 0.8902067355382763d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3867015570905906d, y: 0.16844100344120683d), new NpgsqlTypes.NpgsqlPoint(x: 0.36057508838264685d, y: 0.3758796864145926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5127029445060294d, y: 0.6665689491378765d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6494544516934546d, y: 0.5070796986054376d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773886139736236d, y: 0.32244185843978934d), new NpgsqlTypes.NpgsqlPoint(x: 0.023084183830398453d, y: 0.123108395386472d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8929193222144625d, y: 0.18942310717820166d), new NpgsqlTypes.NpgsqlPoint(x: 0.23069104995057288d, y: 0.30287105426637917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937380871374536d, y: 0.45143704932417306d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44228192692280077d, y: 0.5273426259260731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790956533196377d, y: 0.2358128565629375d), new NpgsqlTypes.NpgsqlPoint(x: 0.38928970554033593d, y: 0.44844280824850524d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45455167492768356d, y: 0.2854673687236218d), new NpgsqlTypes.NpgsqlPoint(x: 0.21085859880732793d, y: 0.511958305614753d), new NpgsqlTypes.NpgsqlPoint(x: 0.19893073856529597d, y: 0.15815652789986623d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2381022260847252d, y: 0.24690158789911598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999845792614259d, y: 0.297823761151097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047612554976012d, y: 0.5808948416511404d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47509983744125783d, y: 0.9840509595677618d), new NpgsqlTypes.NpgsqlPoint(x: 0.10498832865743124d, y: 0.46594540734445455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8452107327898718d, y: 0.6313250303309774d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8485504890328099d, y: 0.7955466416563929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39410125617109426d, y: 0.6029535195891854d), new NpgsqlTypes.NpgsqlPoint(x: 0.1534241728574146d, y: 0.45685642335048204d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47806240540888867d, y: 0.2841565337530394d), new NpgsqlTypes.NpgsqlPoint(x: 0.4175737899542923d, y: 0.8968793525043603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666945703437325d, y: 0.634757108760444d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26317874021689336d, y: 0.04006449916379906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4423035947905737d, y: 0.5431937715271509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162727550697535d, y: 0.5092550755040816d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0036071017941964323d, y: 0.38890440913297486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672886984725767d, y: 0.8753386404222888d), new NpgsqlTypes.NpgsqlPoint(x: 0.394903543761456d, y: 0.7518394570970748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8762613364779077d, y: 0.6503529208451658d), new NpgsqlTypes.NpgsqlPoint(x: 0.12939448501544215d, y: 0.713623633994171d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281758845210881d, y: 0.4815638514649103d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8588985344620383d, y: 0.960064850118143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4349196460942737d, y: 0.2900857667483986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382685467473623d, y: 0.5456749077928614d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.987548550742152d, y: 0.7246287904209547d), new NpgsqlTypes.NpgsqlPoint(x: 0.29118604387620795d, y: 0.13590704875307358d), new NpgsqlTypes.NpgsqlPoint(x: 0.7086634193060041d, y: 0.22414044785754916d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3052149389335659d, y: 0.31789662695619936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5615325227042107d, y: 0.9828840707404474d), new NpgsqlTypes.NpgsqlPoint(x: 0.5682628012203141d, y: 0.7395252279270449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44875421763222756d, y: 0.5293684221257599d), new NpgsqlTypes.NpgsqlPoint(x: 0.9917990112625609d, y: 0.43202567113416324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3767256074834541d, y: 0.5520621032407993d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22147053196893562d, y: 0.8997069699807336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797217192265193d, y: 0.12278502628323551d), new NpgsqlTypes.NpgsqlPoint(x: 0.484501806543143d, y: 0.9902450547443411d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5021426518988108d, y: 0.09643245056688887d), new NpgsqlTypes.NpgsqlPoint(x: 0.4281387308078416d, y: 0.6418121530268238d), new NpgsqlTypes.NpgsqlPoint(x: 0.7440532822856197d, y: 0.8197764076544393d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5084734500230238d, y: 0.855341142483749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6719252094753269d, y: 0.4589405326793602d), new NpgsqlTypes.NpgsqlPoint(x: 0.49941103551198196d, y: 0.21874290740250213d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7991942285522122d, y: 0.9185266763461949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8109023080500813d, y: 0.566083761959823d), new NpgsqlTypes.NpgsqlPoint(x: 0.05530825616255719d, y: 0.026097053402336035d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07094779103424942d, y: 0.9403333316618381d), new NpgsqlTypes.NpgsqlPoint(x: 0.683340876403729d, y: 0.34271522876417226d), new NpgsqlTypes.NpgsqlPoint(x: 0.22176899827220664d, y: 0.8705557350968695d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36040893822523756d, y: 0.06429644637398102d), new NpgsqlTypes.NpgsqlPoint(x: 0.29936039391957414d, y: 0.6590120771197455d), new NpgsqlTypes.NpgsqlPoint(x: 0.4981655336097106d, y: 0.9694095889991732d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.666435075942439d, y: 0.6240286015392175d), new NpgsqlTypes.NpgsqlPoint(x: 0.6897721467665826d, y: 0.964208579513425d), new NpgsqlTypes.NpgsqlPoint(x: 0.7095717425577386d, y: 0.30246322149917115d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.117761504467365d, y: 0.12937319932644697d), new NpgsqlTypes.NpgsqlPoint(x: 0.46760812489204717d, y: 0.3093548226661007d), new NpgsqlTypes.NpgsqlPoint(x: 0.20088668423515044d, y: 0.27996805591510265d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7141023254734659d, y: 0.4421451873643437d), new NpgsqlTypes.NpgsqlPoint(x: 0.42131052855822426d, y: 0.503911267785298d), new NpgsqlTypes.NpgsqlPoint(x: 0.36212779137691764d, y: 0.05264660563870194d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6737341061970341d, y: 0.6308811617526917d), new NpgsqlTypes.NpgsqlPoint(x: 0.3378245622976165d, y: 0.3245934581044423d), new NpgsqlTypes.NpgsqlPoint(x: 0.08616107005140383d, y: 0.12523350573316616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5646229596982725d, y: 0.830633537789648d), new NpgsqlTypes.NpgsqlPoint(x: 0.02773744005778911d, y: 0.5350112500661683d), new NpgsqlTypes.NpgsqlPoint(x: 0.6404485118064164d, y: 0.06668530787053328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4761454747219964d, y: 0.013464713032445785d), new NpgsqlTypes.NpgsqlPoint(x: 0.044893524912065996d, y: 0.04491649418064858d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931233499056335d, y: 0.6144233561010942d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08475374785249046d, y: 0.5307882002557652d), new NpgsqlTypes.NpgsqlPoint(x: 0.8134115251703593d, y: 0.05462777274732045d), new NpgsqlTypes.NpgsqlPoint(x: 0.500286407567102d, y: 0.25578656841343117d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.931210937599217d, y: 0.3308110168953532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101579364756128d, y: 0.3916677441531826d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911437231542277d, y: 0.6233247416177474d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9061765414869531d, y: 0.14439556005775134d), new NpgsqlTypes.NpgsqlPoint(x: 0.9660965972365713d, y: 0.15052858310615447d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426749560966581d, y: 0.6491328303290419d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1961757895206926d, y: 0.8754142120328389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5044431660190797d, y: 0.9351718064564463d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449927987347114d, y: 0.7109869553045939d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0729914934162047d, y: 0.2180367216140635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952402774208319d, y: 0.8846844055159928d), new NpgsqlTypes.NpgsqlPoint(x: 0.6814707478890072d, y: 0.8307370044520793d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2837478020436752d, y: 0.278582999720683d), new NpgsqlTypes.NpgsqlPoint(x: 0.1041411061023898d, y: 0.8161805186465567d), new NpgsqlTypes.NpgsqlPoint(x: 0.07442704751717721d, y: 0.43644527797205135d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9342183505658265d, y: 0.9397735951178142d), new NpgsqlTypes.NpgsqlPoint(x: 0.2997998984377682d, y: 0.7959631143596418d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908068230962833d, y: 0.7586416022135261d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9724190406940647d, y: 0.42946216544853444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6463519863373482d, y: 0.6497361353642314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9986078515319854d, y: 0.22669770004222378d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5929713885019349d, y: 0.4728808731983518d), new NpgsqlTypes.NpgsqlPoint(x: 0.8215320557004182d, y: 0.3776612976235796d), new NpgsqlTypes.NpgsqlPoint(x: 0.7956464820555708d, y: 0.9943346684782601d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16220312333905595d, y: 0.2780710439163425d), new NpgsqlTypes.NpgsqlPoint(x: 0.039780060350692814d, y: 0.5370949985267949d), new NpgsqlTypes.NpgsqlPoint(x: 0.235308529077895d, y: 0.41904272520171026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7632996972059305d, y: 0.1591002603293018d), new NpgsqlTypes.NpgsqlPoint(x: 0.855251904693175d, y: 0.04852321402812221d), new NpgsqlTypes.NpgsqlPoint(x: 0.3056958047843943d, y: 0.6483084039718637d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7442747667685636d, y: 0.017109669605875788d), new NpgsqlTypes.NpgsqlPoint(x: 0.30781982620924087d, y: 0.9539554863503882d), new NpgsqlTypes.NpgsqlPoint(x: 0.3698230739317937d, y: 0.1937206436547858d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8704861017592157d, y: 0.8404649240615591d), new NpgsqlTypes.NpgsqlPoint(x: 0.43917362817044636d, y: 0.3600355915988006d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644683514007213d, y: 0.770440499361172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7844696125735622d, y: 0.14706272880803462d), new NpgsqlTypes.NpgsqlPoint(x: 0.20741126051243342d, y: 0.5589957899758622d), new NpgsqlTypes.NpgsqlPoint(x: 0.07837420614241852d, y: 0.21759173534513643d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21062004097416098d, y: 0.47587759028135357d), new NpgsqlTypes.NpgsqlPoint(x: 0.6101919637001127d, y: 0.9067767345769933d), new NpgsqlTypes.NpgsqlPoint(x: 0.20025324727060434d, y: 0.9209991187238861d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45960437822364275d, y: 0.9565244241276287d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514747660728446d, y: 0.29795524576242716d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581107926169412d, y: 0.8519949759557666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5034273381284923d, y: 0.0075100112731602d), new NpgsqlTypes.NpgsqlPoint(x: 0.5578654593657051d, y: 0.2876939500392087d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960286345138644d, y: 0.5454777475287476d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1176923555768361d, y: 0.3074761246240437d), new NpgsqlTypes.NpgsqlPoint(x: 0.5970907142352035d, y: 0.21639718739819902d), new NpgsqlTypes.NpgsqlPoint(x: 0.8163190692750858d, y: 0.43374653954059317d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3746523918781953d, y: 0.8623640211984629d), new NpgsqlTypes.NpgsqlPoint(x: 0.5432822055926888d, y: 0.0008180091442354653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996485457225011d, y: 0.14238798136126152d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20439646111957765d, y: 0.4563881157434744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7123066750046833d, y: 0.392705469033671d), new NpgsqlTypes.NpgsqlPoint(x: 0.942017934196322d, y: 0.9257820114814442d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3649071768286435d, y: 0.03652767414894864d), new NpgsqlTypes.NpgsqlPoint(x: 0.1704344335974839d, y: 0.013147079167645015d), new NpgsqlTypes.NpgsqlPoint(x: 0.6153240544945576d, y: 0.9803449072473411d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18584951447450448d, y: 0.06921667521441888d), new NpgsqlTypes.NpgsqlPoint(x: 0.04253478135924016d, y: 0.9800317107385575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9791316255535183d, y: 0.13719421940955978d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8209811507457401d, y: 0.08315734359256977d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141661930257572d, y: 0.5717337762205299d), new NpgsqlTypes.NpgsqlPoint(x: 0.34794808714272674d, y: 0.5827746738025688d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.539741871596147d, y: 0.5337705549454314d), new NpgsqlTypes.NpgsqlPoint(x: 0.8813535173957535d, y: 0.713144063502483d), new NpgsqlTypes.NpgsqlPoint(x: 0.24653213877705038d, y: 0.7812999398645738d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07923216228068741d, y: 0.8809258089277768d), new NpgsqlTypes.NpgsqlPoint(x: 0.301417483402897d, y: 0.2209093495975012d), new NpgsqlTypes.NpgsqlPoint(x: 0.09222121487595158d, y: 0.5736127831859555d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24819397603120075d, y: 0.058978985704332354d), new NpgsqlTypes.NpgsqlPoint(x: 0.24923418692126076d, y: 0.23270691093799223d), new NpgsqlTypes.NpgsqlPoint(x: 0.45595949470365293d, y: 0.8478588105944409d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48961904289528657d, y: 0.4537079200706322d), new NpgsqlTypes.NpgsqlPoint(x: 0.4520437566945883d, y: 0.9494638023172174d), new NpgsqlTypes.NpgsqlPoint(x: 0.8238039976542832d, y: 0.5368525431540255d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2551585886537471d, y: 0.6854899431911338d), new NpgsqlTypes.NpgsqlPoint(x: 0.7090456403720481d, y: 0.8020483589469393d), new NpgsqlTypes.NpgsqlPoint(x: 0.7842398135068496d, y: 0.693315518900979d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.52300623853372d, y: 0.2952473451515544d), new NpgsqlTypes.NpgsqlPoint(x: 0.04259641955047533d, y: 0.14294541684054396d), new NpgsqlTypes.NpgsqlPoint(x: 0.07565331210873705d, y: 0.22720720475805845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.508890510340342d, y: 0.7578556659212835d), new NpgsqlTypes.NpgsqlPoint(x: 0.30364165818179534d, y: 0.5552749628473639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5537655400443754d, y: 0.4288973903400636d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9424526009173201d, y: 0.2883804199902641d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084379392312406d, y: 0.5697853257760438d), new NpgsqlTypes.NpgsqlPoint(x: 0.6037750232696554d, y: 0.07811407849377627d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.812426092409462d, y: 0.8170075881103237d), new NpgsqlTypes.NpgsqlPoint(x: 0.46295225132463547d, y: 0.37824523258264287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5438508907845365d, y: 0.7873314271003696d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8342434475379187d, y: 0.05228133639537924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185377770572748d, y: 0.6617907614200387d), new NpgsqlTypes.NpgsqlPoint(x: 0.4247015465552165d, y: 0.29317005697660337d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8566218613149d, y: 0.5689651387414387d), new NpgsqlTypes.NpgsqlPoint(x: 0.9372934874915826d, y: 0.3802162288906301d), new NpgsqlTypes.NpgsqlPoint(x: 0.443747077808446d, y: 0.7314466639246416d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35566112917369075d, y: 0.6843258080394848d), new NpgsqlTypes.NpgsqlPoint(x: 0.46798328193693606d, y: 0.2191444293458945d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176658289102543d, y: 0.0633899775211415d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6266261380859516d, y: 0.6767141261305784d), new NpgsqlTypes.NpgsqlPoint(x: 0.12099620670212297d, y: 0.4091097483564322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8612774539435892d, y: 0.46979443134093124d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6270106955877239d, y: 0.1214171529111635d), new NpgsqlTypes.NpgsqlPoint(x: 0.5351038912900616d, y: 0.2869407697568127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5182067980903149d, y: 0.07940537409574211d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7606851819492325d, y: 0.13234817152927425d), new NpgsqlTypes.NpgsqlPoint(x: 0.664020113102326d, y: 0.7838398799747697d), new NpgsqlTypes.NpgsqlPoint(x: 0.712876253550179d, y: 0.6726750085684998d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6219895772574145d, y: 0.09979851428434894d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392062627217801d, y: 0.8483783204580141d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905083876642173d, y: 0.2811598174988448d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45322717447423344d, y: 0.8912724112991288d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234700253463171d, y: 0.45152450514679554d), new NpgsqlTypes.NpgsqlPoint(x: 0.0032073935017759014d, y: 0.461052577874164d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08689942028161024d, y: 0.5679425395085325d), new NpgsqlTypes.NpgsqlPoint(x: 0.9460854820935402d, y: 0.23135684534102152d), new NpgsqlTypes.NpgsqlPoint(x: 0.042277441928304293d, y: 0.1895039131913091d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9626640197896584d, y: 0.9060256910188103d), new NpgsqlTypes.NpgsqlPoint(x: 0.949926535154821d, y: 0.8102609599790139d), new NpgsqlTypes.NpgsqlPoint(x: 0.2775799815292368d, y: 0.17727321592463074d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3361841837914471d, y: 0.7198082493471298d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050924484789592d, y: 0.8007961989821507d), new NpgsqlTypes.NpgsqlPoint(x: 0.1471207425280031d, y: 0.5877594009067653d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08882214801143684d, y: 0.8321974530664634d), new NpgsqlTypes.NpgsqlPoint(x: 0.4626493293431754d, y: 0.639404809750635d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875588351872899d, y: 0.3579111284776647d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4490122609860904d, y: 0.34611553414356344d), new NpgsqlTypes.NpgsqlPoint(x: 0.1432518898135534d, y: 0.8446129319110968d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721800218097201d, y: 0.7934861130075324d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08075962834738504d, y: 0.3615496721587659d), new NpgsqlTypes.NpgsqlPoint(x: 0.762097061086362d, y: 0.12485111121857495d), new NpgsqlTypes.NpgsqlPoint(x: 0.39965512551427906d, y: 0.9075544570443639d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8240065496076565d, y: 0.5354116508538963d), new NpgsqlTypes.NpgsqlPoint(x: 0.8191408363176524d, y: 0.9889833274873069d), new NpgsqlTypes.NpgsqlPoint(x: 0.10729412094859236d, y: 0.7260385733119662d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5222216909684233d, y: 0.8739304782296227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6932300485600298d, y: 0.8737218671818366d), new NpgsqlTypes.NpgsqlPoint(x: 0.5984822403834308d, y: 0.8058691748269137d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.525531652141214d, y: 0.9694925187863461d), new NpgsqlTypes.NpgsqlPoint(x: 0.22220658439218854d, y: 0.02889691405144612d), new NpgsqlTypes.NpgsqlPoint(x: 0.5536887983151831d, y: 0.961089913105955d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2259699782457818d, y: 0.9016028167484093d), new NpgsqlTypes.NpgsqlPoint(x: 0.03784949577483554d, y: 0.5546390321791723d), new NpgsqlTypes.NpgsqlPoint(x: 0.7469800982562699d, y: 0.44012752894250384d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9919839542931477d, y: 0.4760263766545738d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424914775229076d, y: 0.07680269842659493d), new NpgsqlTypes.NpgsqlPoint(x: 0.8959917090066699d, y: 0.3349859872091058d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7462778925051762d, y: 0.7137841587018025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034251202769458d, y: 0.5116212257386218d), new NpgsqlTypes.NpgsqlPoint(x: 0.18968089734987037d, y: 0.15820058697938277d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05579162471312116d, y: 0.24841250922195246d), new NpgsqlTypes.NpgsqlPoint(x: 0.08969682460106121d, y: 0.8701877043821755d), new NpgsqlTypes.NpgsqlPoint(x: 0.32985151704031435d, y: 0.18118008813588382d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6978436286091492d, y: 0.9936121865281915d), new NpgsqlTypes.NpgsqlPoint(x: 0.7134748579598084d, y: 0.6422654044836433d), new NpgsqlTypes.NpgsqlPoint(x: 0.11267243024380025d, y: 0.2681879582108323d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8107147660366306d, y: 0.8418426191058936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5343735269864501d, y: 0.3609895680856924d), new NpgsqlTypes.NpgsqlPoint(x: 0.33358169170476304d, y: 0.5569948393804293d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8801762427033687d, y: 0.9931613461157032d), new NpgsqlTypes.NpgsqlPoint(x: 0.3883527182779294d, y: 0.16967766722026423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7330934238901845d, y: 0.8817701200613105d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6734407257677519d, y: 0.6574526233139151d), new NpgsqlTypes.NpgsqlPoint(x: 0.4102336842475709d, y: 0.9985165489317862d), new NpgsqlTypes.NpgsqlPoint(x: 0.061118348006964474d, y: 0.951999282884407d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9249799570361228d, y: 0.8369137356356198d), new NpgsqlTypes.NpgsqlPoint(x: 0.59768702437922d, y: 0.08582603637137032d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606481473900572d, y: 0.5205153076992571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.978441123530436d, y: 0.0865666503182907d), new NpgsqlTypes.NpgsqlPoint(x: 0.045560489048268815d, y: 0.4718953788765312d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822646557067968d, y: 0.48900714316902216d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7407843923100658d, y: 0.28557813105845986d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809413260537711d, y: 0.7016490111883059d), new NpgsqlTypes.NpgsqlPoint(x: 0.10083647629374837d, y: 0.10417577503748365d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3719296949531138d, y: 0.17075643018380238d), new NpgsqlTypes.NpgsqlPoint(x: 0.533159858592238d, y: 0.7203665124897346d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739373280672046d, y: 0.7150270313209393d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7009929141965796d, y: 0.38705874676555907d), new NpgsqlTypes.NpgsqlPoint(x: 0.25757547724624963d, y: 0.5579390148758587d), new NpgsqlTypes.NpgsqlPoint(x: 0.3262444945172668d, y: 0.16785151369002127d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9453024730375811d, y: 0.007495315398983404d), new NpgsqlTypes.NpgsqlPoint(x: 0.6200765779623225d, y: 0.12998931282171022d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793282086437924d, y: 0.5919433352924159d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8611380764994699d, y: 0.92985032128567d), new NpgsqlTypes.NpgsqlPoint(x: 0.41985853430308406d, y: 0.013095199409961178d), new NpgsqlTypes.NpgsqlPoint(x: 0.23430848338874988d, y: 0.06975271417089912d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04748918215690623d, y: 0.0729688932363477d), new NpgsqlTypes.NpgsqlPoint(x: 0.4011918253014555d, y: 0.6963541996045963d), new NpgsqlTypes.NpgsqlPoint(x: 0.5624191331235762d, y: 0.9695738326543947d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2464316170826759d, y: 0.09743053102484078d), new NpgsqlTypes.NpgsqlPoint(x: 0.451835377106245d, y: 0.7178781094919615d), new NpgsqlTypes.NpgsqlPoint(x: 0.3470260921846734d, y: 0.574144711630914d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5276615800926815d, y: 0.13693157867846173d), new NpgsqlTypes.NpgsqlPoint(x: 0.18780509020161462d, y: 0.09615548011352004d), new NpgsqlTypes.NpgsqlPoint(x: 0.39592069061610613d, y: 0.6606887053351616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4365265074435234d, y: 0.915717428085859d), new NpgsqlTypes.NpgsqlPoint(x: 0.579449265420738d, y: 0.1295487709861639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5049006271139097d, y: 0.42556788079704566d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6638677486515754d, y: 0.5400052477956204d), new NpgsqlTypes.NpgsqlPoint(x: 0.6315405046639926d, y: 0.6229239637270121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9429513147647776d, y: 0.05840802803798595d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8185018795041101d, y: 0.6853196195341287d), new NpgsqlTypes.NpgsqlPoint(x: 0.011303407088284256d, y: 0.4019335382379149d), new NpgsqlTypes.NpgsqlPoint(x: 0.9556161056125514d, y: 0.17934861564770788d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5071157178436635d, y: 0.32480413296421917d), new NpgsqlTypes.NpgsqlPoint(x: 0.2212461068341096d, y: 0.1592092535396522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4180996157713315d, y: 0.8684015744266947d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23495535519824817d, y: 0.10855278959727566d), new NpgsqlTypes.NpgsqlPoint(x: 0.04725249304855084d, y: 0.3720479932463986d), new NpgsqlTypes.NpgsqlPoint(x: 0.49909632140101734d, y: 0.4431879716448506d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40012828679238455d, y: 0.7683107109327821d), new NpgsqlTypes.NpgsqlPoint(x: 0.4684786447491581d, y: 0.8110234742519573d), new NpgsqlTypes.NpgsqlPoint(x: 0.26311741946242717d, y: 0.4729162036827623d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49749220966770524d, y: 0.6385507570680313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922296241265599d, y: 0.10806936085825292d), new NpgsqlTypes.NpgsqlPoint(x: 0.4106076728395026d, y: 0.7823560053268668d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3377374862041229d, y: 0.6748595687352876d), new NpgsqlTypes.NpgsqlPoint(x: 0.19090636931547322d, y: 0.595553009522299d), new NpgsqlTypes.NpgsqlPoint(x: 0.590120243577418d, y: 0.20180549404933568d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3279473184057692d, y: 0.7323612255557979d), new NpgsqlTypes.NpgsqlPoint(x: 0.8522084388303732d, y: 0.15289012247981848d), new NpgsqlTypes.NpgsqlPoint(x: 0.326896794800992d, y: 0.3577003698257323d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.536969260011375d, y: 0.9497921028800538d), new NpgsqlTypes.NpgsqlPoint(x: 0.8718257292932755d, y: 0.22209747835030902d), new NpgsqlTypes.NpgsqlPoint(x: 0.04081616390937215d, y: 0.6812883916060963d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23979660991302143d, y: 0.6893308546255333d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922702462794868d, y: 0.9750633590233451d), new NpgsqlTypes.NpgsqlPoint(x: 0.6390135483712553d, y: 0.3270826792148237d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4506832249499718d, y: 0.11488368765406809d), new NpgsqlTypes.NpgsqlPoint(x: 0.6080027848859224d, y: 0.39175095560683304d), new NpgsqlTypes.NpgsqlPoint(x: 0.1503776764452317d, y: 0.9437000588811694d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20764142367821303d, y: 0.17660177004787048d), new NpgsqlTypes.NpgsqlPoint(x: 0.6629336298554022d, y: 0.8988071939808467d), new NpgsqlTypes.NpgsqlPoint(x: 0.4264256936675671d, y: 0.9400236554553992d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2570376339145558d, y: 0.8129860855517388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3288434458342744d, y: 0.045783396846180935d), new NpgsqlTypes.NpgsqlPoint(x: 0.25357119921370297d, y: 0.32281850850438243d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6784293412498248d, y: 0.07387434349134325d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008150577837419d, y: 0.34976598166643025d), new NpgsqlTypes.NpgsqlPoint(x: 0.6510914282859053d, y: 0.82369243363505d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7586023230921034d, y: 0.3898082878864163d), new NpgsqlTypes.NpgsqlPoint(x: 0.10281048186620045d, y: 0.9310878601832574d), new NpgsqlTypes.NpgsqlPoint(x: 0.3266978169446525d, y: 0.1814039318751003d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1694048835406301d, y: 0.40355767271868304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197039036329624d, y: 0.008925235817260013d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713536783297321d, y: 0.3848516730531779d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8864254960294558d, y: 0.43981235412028097d), new NpgsqlTypes.NpgsqlPoint(x: 0.5060203413878657d, y: 0.31725120647648153d), new NpgsqlTypes.NpgsqlPoint(x: 0.3032995014832488d, y: 0.4463563090289753d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5254348245776849d, y: 0.9979689481573829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781981045277165d, y: 0.7227629778351932d), new NpgsqlTypes.NpgsqlPoint(x: 0.41063193096534545d, y: 0.8945121670501165d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5182574941709536d, y: 0.9687113809781881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5020708150019646d, y: 0.40714814144962264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5124834063037359d, y: 0.11755091423069086d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5994158553480456d, y: 0.5859994641467371d), new NpgsqlTypes.NpgsqlPoint(x: 0.858966565624382d, y: 0.34971802624518067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966856105298388d, y: 0.39724475253328073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4983911604507405d, y: 0.10272903309519443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3101860149956084d, y: 0.6548402428587426d), new NpgsqlTypes.NpgsqlPoint(x: 0.46343476248153537d, y: 0.9879833538640126d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3606556492642118d, y: 0.46631617420850624d), new NpgsqlTypes.NpgsqlPoint(x: 0.2377643563084263d, y: 0.919949146429397d), new NpgsqlTypes.NpgsqlPoint(x: 0.3583255988531002d, y: 0.23930429392453623d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23328362309835815d, y: 0.29931305733652047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5543946050794288d, y: 0.9278865542335828d), new NpgsqlTypes.NpgsqlPoint(x: 0.026437387280496272d, y: 0.11079795628530054d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.041737862129034964d, y: 0.05709501205411116d), new NpgsqlTypes.NpgsqlPoint(x: 0.006302013061537104d, y: 0.7481847921287333d), new NpgsqlTypes.NpgsqlPoint(x: 0.3416762802165111d, y: 0.07305699634852791d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6489654939702509d, y: 0.46546035057395374d), new NpgsqlTypes.NpgsqlPoint(x: 0.8625844282893185d, y: 0.9221305463385935d), new NpgsqlTypes.NpgsqlPoint(x: 0.12408738904521399d, y: 0.5771476026767682d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6225595904785214d, y: 0.7696876046094175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9042862013046226d, y: 0.3757648657026442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5445564957123027d, y: 0.024995426283451083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8411219784087042d, y: 0.4137621587803554d), new NpgsqlTypes.NpgsqlPoint(x: 0.48195567240585024d, y: 0.9248555286942415d), new NpgsqlTypes.NpgsqlPoint(x: 0.27834178445344315d, y: 0.4130729683386708d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6701131817529563d, y: 0.5124271392558517d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449512751297993d, y: 0.8831283224450666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4472005934400801d, y: 0.9848106379404982d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7743561771583075d, y: 0.5989621140526885d), new NpgsqlTypes.NpgsqlPoint(x: 0.2962205459811704d, y: 0.40420588372974575d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030567350163289d, y: 0.5275458396494948d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.173715911793496d, y: 0.49587755026474434d), new NpgsqlTypes.NpgsqlPoint(x: 0.8353679923605593d, y: 0.30741942245920284d), new NpgsqlTypes.NpgsqlPoint(x: 0.39406249071978805d, y: 0.0822855723473146d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8632726277836734d, y: 0.7649141306037215d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973808198166777d, y: 0.6511226383043794d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000193021009796d, y: 0.3546851561520329d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8109174850076393d, y: 0.6289213672532566d), new NpgsqlTypes.NpgsqlPoint(x: 0.35847701242869834d, y: 0.18900700849104135d), new NpgsqlTypes.NpgsqlPoint(x: 0.09568251371264747d, y: 0.8731107307331079d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02198285349521556d, y: 0.31575161154876363d), new NpgsqlTypes.NpgsqlPoint(x: 0.768646976557467d, y: 0.4803996436274749d), new NpgsqlTypes.NpgsqlPoint(x: 0.2922580565557843d, y: 0.9012173125967684d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09756172213833247d, y: 0.7556477534689784d), new NpgsqlTypes.NpgsqlPoint(x: 0.8808167604295949d, y: 0.7770095674421984d), new NpgsqlTypes.NpgsqlPoint(x: 0.44543508405803456d, y: 0.2705709561927637d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6247604109942244d, y: 0.7023510140193482d), new NpgsqlTypes.NpgsqlPoint(x: 0.4472687785569729d, y: 0.29191922893782163d), new NpgsqlTypes.NpgsqlPoint(x: 0.39466298592583704d, y: 0.23753669258292964d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9881890592027488d, y: 0.7297175625269645d), new NpgsqlTypes.NpgsqlPoint(x: 0.17350998972187626d, y: 0.5996545786450913d), new NpgsqlTypes.NpgsqlPoint(x: 0.12724791668970925d, y: 0.2650257495116072d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41949548330204234d, y: 0.6093361598642361d), new NpgsqlTypes.NpgsqlPoint(x: 0.5585546014488245d, y: 0.30433149451209185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5154245500251519d, y: 0.9638094887242918d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8344092206980771d, y: 0.05636265263616336d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592800770135572d, y: 0.4550224031239982d), new NpgsqlTypes.NpgsqlPoint(x: 0.554970542215704d, y: 0.5165204372145011d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2626559626441185d, y: 0.40706477112309714d), new NpgsqlTypes.NpgsqlPoint(x: 0.12995724479313242d, y: 0.30771551748366255d), new NpgsqlTypes.NpgsqlPoint(x: 0.9652599679529628d, y: 0.31880137354349924d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9140216982790345d, y: 0.5159743858323776d), new NpgsqlTypes.NpgsqlPoint(x: 0.23197112411339438d, y: 0.7131915757608074d), new NpgsqlTypes.NpgsqlPoint(x: 0.6198091262105865d, y: 0.169475703938874d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09464761411592315d, y: 0.9977324887448776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8006216752073239d, y: 0.46068328789575597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5565771915318093d, y: 0.886779987644133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1291137471938114d, y: 0.06158480036019964d), new NpgsqlTypes.NpgsqlPoint(x: 0.7425060569884391d, y: 0.270196770705339d), new NpgsqlTypes.NpgsqlPoint(x: 0.8491938472853573d, y: 0.5937166103909902d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5805577703586493d, y: 0.46318011856904184d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402252953550247d, y: 0.780020797096593d), new NpgsqlTypes.NpgsqlPoint(x: 0.803261504793614d, y: 0.44841064251210383d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17135496192359367d, y: 0.4111622165579466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5639874678639445d, y: 0.829419398824933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986111297976908d, y: 0.7736510076504818d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8856836179235924d, y: 0.9359378502284558d), new NpgsqlTypes.NpgsqlPoint(x: 0.890319648377275d, y: 0.14062705839861267d), new NpgsqlTypes.NpgsqlPoint(x: 0.9524241582395347d, y: 0.1532831330923491d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6255168325910372d, y: 0.1578769828533524d), new NpgsqlTypes.NpgsqlPoint(x: 0.9450347060862759d, y: 0.09454721184014003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5032075077055165d, y: 0.058484632933498926d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.844396120616371d, y: 0.7613905090292034d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161585747590492d, y: 0.49532073521557785d), new NpgsqlTypes.NpgsqlPoint(x: 0.5673842130103972d, y: 0.6982619396241617d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7360302351621417d, y: 0.2589262033966332d), new NpgsqlTypes.NpgsqlPoint(x: 0.5744780366452634d, y: 0.8372581801624109d), new NpgsqlTypes.NpgsqlPoint(x: 0.34202746103489745d, y: 0.6012421895972064d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6962532658687942d, y: 0.9713616235150749d), new NpgsqlTypes.NpgsqlPoint(x: 0.19194722784132767d, y: 0.1406572463774849d), new NpgsqlTypes.NpgsqlPoint(x: 0.03354220708982203d, y: 0.17681199631385525d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5190231339940617d, y: 0.8945518237375099d), new NpgsqlTypes.NpgsqlPoint(x: 0.042859345322122544d, y: 0.8263692011326743d), new NpgsqlTypes.NpgsqlPoint(x: 0.36124381561608854d, y: 0.13671797126547247d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1918654552201895d, y: 0.09540792613327764d), new NpgsqlTypes.NpgsqlPoint(x: 0.2537082309356967d, y: 0.37842435162633514d), new NpgsqlTypes.NpgsqlPoint(x: 0.16905475740999076d, y: 0.05765897965107025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4532117152419559d, y: 0.294481241938915d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391300551568042d, y: 0.3954007101597735d), new NpgsqlTypes.NpgsqlPoint(x: 0.11836230161775474d, y: 0.4220664145508979d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6564379312599918d, y: 0.9629694304720159d), new NpgsqlTypes.NpgsqlPoint(x: 0.2358826963454269d, y: 0.8701093662903728d), new NpgsqlTypes.NpgsqlPoint(x: 0.6634697384201428d, y: 0.6371421553057907d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9131600011692597d, y: 0.851465612934149d), new NpgsqlTypes.NpgsqlPoint(x: 0.5764804025744705d, y: 0.1742601461486284d), new NpgsqlTypes.NpgsqlPoint(x: 0.34073960036079165d, y: 0.26580472563844704d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48058342579852575d, y: 0.21176931371512364d), new NpgsqlTypes.NpgsqlPoint(x: 0.9107481299683474d, y: 0.17529866153643237d), new NpgsqlTypes.NpgsqlPoint(x: 0.17613468980954172d, y: 0.9454500700229419d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27530245025763267d, y: 0.36823022775855374d), new NpgsqlTypes.NpgsqlPoint(x: 0.1040696593797924d, y: 0.9253508455354987d), new NpgsqlTypes.NpgsqlPoint(x: 0.6275187653617956d, y: 0.974614461115504d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37313180550225633d, y: 0.8584922856929439d), new NpgsqlTypes.NpgsqlPoint(x: 0.780163620405524d, y: 0.028378266005301245d), new NpgsqlTypes.NpgsqlPoint(x: 0.20591995943991304d, y: 0.10030931903559326d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2897953761195592d, y: 0.08280372559422555d), new NpgsqlTypes.NpgsqlPoint(x: 0.247271209544351d, y: 0.27249878323701604d), new NpgsqlTypes.NpgsqlPoint(x: 0.9651247388722606d, y: 0.3410551639184054d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2068055931374475d, y: 0.38319675247391927d), new NpgsqlTypes.NpgsqlPoint(x: 0.5782895529727836d, y: 0.03459408167807343d), new NpgsqlTypes.NpgsqlPoint(x: 0.9970004909758847d, y: 0.674974010148694d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1417011955244044d, y: 0.7211296866577368d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826754969429012d, y: 0.004203334304174522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4287205427639992d, y: 0.21560989716911672d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3660912746596393d, y: 0.1453489303001162d), new NpgsqlTypes.NpgsqlPoint(x: 0.08189340660403499d, y: 0.912137389482912d), new NpgsqlTypes.NpgsqlPoint(x: 0.2761856825704545d, y: 0.7920314201229967d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.566024180467693d, y: 0.3661559815667492d), new NpgsqlTypes.NpgsqlPoint(x: 0.09378301560147217d, y: 0.4355496405053333d), new NpgsqlTypes.NpgsqlPoint(x: 0.8684273005116631d, y: 0.2924514422809771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.912813528759698d, y: 0.2940197623434132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5713483272769885d, y: 0.26836994436935724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213698420672101d, y: 0.10401855418720918d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.002895079058481409d, y: 0.8230483525880941d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379748535023662d, y: 0.7373251469100636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7979015586472892d, y: 0.1440904828505396d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.251321068321668d, y: 0.824460937946581d), new NpgsqlTypes.NpgsqlPoint(x: 0.6039512020103643d, y: 0.4784706672196808d), new NpgsqlTypes.NpgsqlPoint(x: 0.3313126372269046d, y: 0.4332385962390898d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8696612009434942d, y: 0.4974107873987076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4383534821777516d, y: 0.5635685695223012d), new NpgsqlTypes.NpgsqlPoint(x: 0.4032063730274559d, y: 0.1660556142632974d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5800251411440908d, y: 0.2224412369231199d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856862015205554d, y: 0.4122125671859195d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628730013018201d, y: 0.2523044971788464d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8531643133355198d, y: 0.3775325756808503d), new NpgsqlTypes.NpgsqlPoint(x: 0.10815941181144373d, y: 0.5968315985958003d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151620526049181d, y: 0.13110505784693882d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28350453329535674d, y: 0.928075429008704d), new NpgsqlTypes.NpgsqlPoint(x: 0.21784428462138805d, y: 0.03506432084539157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9752326387816628d, y: 0.13783646282415207d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35129057437577704d, y: 0.02410527191311118d), new NpgsqlTypes.NpgsqlPoint(x: 0.864887446486655d, y: 0.02862277302184668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6059861124728724d, y: 0.5462633226628695d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2647876987335588d, y: 0.4723317262326121d), new NpgsqlTypes.NpgsqlPoint(x: 0.661605272918702d, y: 0.5994958880760713d), new NpgsqlTypes.NpgsqlPoint(x: 0.19203816450036826d, y: 0.9537762823277334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9423493148935586d, y: 0.13797648693848952d), new NpgsqlTypes.NpgsqlPoint(x: 0.7435303152032842d, y: 0.4577685226563498d), new NpgsqlTypes.NpgsqlPoint(x: 0.8012007588321306d, y: 0.9712587424585243d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6123155741006425d, y: 0.4722595022829088d), new NpgsqlTypes.NpgsqlPoint(x: 0.06629924306157797d, y: 0.8875124925792299d), new NpgsqlTypes.NpgsqlPoint(x: 0.8635010178858402d, y: 0.6789288865319699d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6351908691398027d, y: 0.9658782310833744d), new NpgsqlTypes.NpgsqlPoint(x: 0.7439971284382271d, y: 0.5290083780801137d), new NpgsqlTypes.NpgsqlPoint(x: 0.32933241019856185d, y: 0.0406485496122001d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46748537809505564d, y: 0.4848592368378801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9199372425493844d, y: 0.8934606531062653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4214160791646684d, y: 0.7932101968198996d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4203757034365325d, y: 0.6990357906042899d), new NpgsqlTypes.NpgsqlPoint(x: 0.48348847944895423d, y: 0.10557061564710002d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952522035089493d, y: 0.03753147414917801d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9221816326618288d, y: 0.13995526379813183d), new NpgsqlTypes.NpgsqlPoint(x: 0.4132296640497304d, y: 0.8092672647940374d), new NpgsqlTypes.NpgsqlPoint(x: 0.41465272569725475d, y: 0.5335411575377158d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7940657556593713d, y: 0.4852712263020744d), new NpgsqlTypes.NpgsqlPoint(x: 0.373529196626897d, y: 0.4404488506305678d), new NpgsqlTypes.NpgsqlPoint(x: 0.8202418480747287d, y: 0.27446787017770824d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9701867350521605d, y: 0.023040084517201298d), new NpgsqlTypes.NpgsqlPoint(x: 0.24262059050277984d, y: 0.6915619281521972d), new NpgsqlTypes.NpgsqlPoint(x: 0.8423111667691892d, y: 0.3456451488939789d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 92,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.885980989017879d, y: 0.9684615171726666d), new NpgsqlTypes.NpgsqlPoint(x: 0.09084496225358452d, y: 0.05528954608643366d), new NpgsqlTypes.NpgsqlPoint(x: 0.4967743230592304d, y: 0.8116250838676651d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30475256486221924d, y: 0.6297040191328915d), new NpgsqlTypes.NpgsqlPoint(x: 0.809077420723452d, y: 0.35233356851575803d), new NpgsqlTypes.NpgsqlPoint(x: 0.4204127269827955d, y: 0.29967495910611364d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9768255804393555d, y: 0.4094704984615545d), new NpgsqlTypes.NpgsqlPoint(x: 0.5070227572814402d, y: 0.10628421922274778d), new NpgsqlTypes.NpgsqlPoint(x: 0.43144695151556234d, y: 0.3197251936211635d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6394585202943809d, y: 0.9376695294726478d), new NpgsqlTypes.NpgsqlPoint(x: 0.6148362250515829d, y: 0.3918626400404981d), new NpgsqlTypes.NpgsqlPoint(x: 0.01867641584760471d, y: 0.42701864768150155d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6227794912666214d, y: 0.9419924768833849d), new NpgsqlTypes.NpgsqlPoint(x: 0.8662298508922466d, y: 0.5404518009487221d), new NpgsqlTypes.NpgsqlPoint(x: 0.619096303006988d, y: 0.6735412688424887d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7477615449663406d, y: 0.9774120269716365d), new NpgsqlTypes.NpgsqlPoint(x: 0.803467183484387d, y: 0.27085034830875465d), new NpgsqlTypes.NpgsqlPoint(x: 0.6619198590942973d, y: 0.5484799759499261d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5655571327464031d, y: 0.8115443829805942d), new NpgsqlTypes.NpgsqlPoint(x: 0.775110519707368d, y: 0.7312240902281608d), new NpgsqlTypes.NpgsqlPoint(x: 0.11532268702022896d, y: 0.6544883564115342d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4280431078498447d, y: 0.8794891378107399d), new NpgsqlTypes.NpgsqlPoint(x: 0.4044064185682823d, y: 0.9395069162448885d), new NpgsqlTypes.NpgsqlPoint(x: 0.13458537013418814d, y: 0.7912205893656401d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19424557846952561d, y: 0.7139804916043776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9412318232584875d, y: 0.07608555584103749d), new NpgsqlTypes.NpgsqlPoint(x: 0.6354759937407892d, y: 0.8788781163296633d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6262849598041037d, y: 0.418697304173847d), new NpgsqlTypes.NpgsqlPoint(x: 0.2988470671767641d, y: 0.23840209069253815d), new NpgsqlTypes.NpgsqlPoint(x: 0.10317101243127491d, y: 0.24839539773338626d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49756521960659406d, y: 0.7938322202501953d), new NpgsqlTypes.NpgsqlPoint(x: 0.8086884536003692d, y: 0.2510469038504596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189370336653177d, y: 0.524679451596709d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6982458623278419d, y: 0.28925557241549715d), new NpgsqlTypes.NpgsqlPoint(x: 0.520659239336383d, y: 0.22322917843332457d), new NpgsqlTypes.NpgsqlPoint(x: 0.14934464072224096d, y: 0.6601288088578489d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9480115869304452d, y: 0.30979622434818666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455701401831397d, y: 0.5252734984654305d), new NpgsqlTypes.NpgsqlPoint(x: 0.8361420946071672d, y: 0.3964945863889998d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26847119430997024d, y: 0.6902943048451251d), new NpgsqlTypes.NpgsqlPoint(x: 0.4195936763764204d, y: 0.7235640203393982d), new NpgsqlTypes.NpgsqlPoint(x: 0.9485435874673752d, y: 0.11355919616241217d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08871741579062542d, y: 0.3652939121740596d), new NpgsqlTypes.NpgsqlPoint(x: 0.507514043819193d, y: 0.9373000820155252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8557014630588123d, y: 0.12579335844709594d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.548387750199988d, y: 0.989675116805535d), new NpgsqlTypes.NpgsqlPoint(x: 0.9109716827908625d, y: 0.7825939291853468d), new NpgsqlTypes.NpgsqlPoint(x: 0.056107503249041235d, y: 0.7395758687666348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07065302142783592d, y: 0.5093491631702102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8667148505907383d, y: 0.4974012621352918d), new NpgsqlTypes.NpgsqlPoint(x: 0.5785621194672327d, y: 0.4057667944365615d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0711483862192751d, y: 0.12193512759997871d), new NpgsqlTypes.NpgsqlPoint(x: 0.28157784516106654d, y: 0.6453796687007617d), new NpgsqlTypes.NpgsqlPoint(x: 0.714462045276982d, y: 0.9157769482710025d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5539592170469854d, y: 0.41652313114144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7606432775706827d, y: 0.8551204264444742d), new NpgsqlTypes.NpgsqlPoint(x: 0.13116312297453536d, y: 0.8542494799248903d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3843843289270842d, y: 0.2988372147581686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0503124779735753d, y: 0.8344417372217103d), new NpgsqlTypes.NpgsqlPoint(x: 0.04384160952286886d, y: 0.29540331893114113d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6781409230335583d, y: 0.41548568401648645d), new NpgsqlTypes.NpgsqlPoint(x: 0.36808788032201645d, y: 0.3220560701882037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178062178770397d, y: 0.5725469325032063d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48716403139991116d, y: 0.30675686258040646d), new NpgsqlTypes.NpgsqlPoint(x: 0.21981159471692147d, y: 0.7419849324654532d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739014614724259d, y: 0.2667683896086608d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2687655702615154d, y: 0.609524021449585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6868831767231838d, y: 0.6262685766076965d), new NpgsqlTypes.NpgsqlPoint(x: 0.8938127355019062d, y: 0.3940942872632338d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11905975663750523d, y: 0.36290274417308643d), new NpgsqlTypes.NpgsqlPoint(x: 0.12503714454797987d, y: 0.5383584067473386d), new NpgsqlTypes.NpgsqlPoint(x: 0.23095807997591167d, y: 0.023248467287860453d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5508320445263281d, y: 0.9011648064865411d), new NpgsqlTypes.NpgsqlPoint(x: 0.39601172182672395d, y: 0.35441745317518525d), new NpgsqlTypes.NpgsqlPoint(x: 0.4867670949523458d, y: 0.14958453469468447d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2347732402874314d, y: 0.2132118546777304d), new NpgsqlTypes.NpgsqlPoint(x: 0.049077325318690246d, y: 0.13076317262269577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4065302363374965d, y: 0.1918611717289036d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8829023837689104d, y: 0.014899778424710353d), new NpgsqlTypes.NpgsqlPoint(x: 0.4521424620569747d, y: 0.03033112894074752d), new NpgsqlTypes.NpgsqlPoint(x: 0.963601004074542d, y: 0.8209021752811191d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8580399631619313d, y: 0.20730828486766306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6381193762529636d, y: 0.6786254766632914d), new NpgsqlTypes.NpgsqlPoint(x: 0.716956273350733d, y: 0.7425341365826005d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1489977615777991d, y: 0.0866301047344159d), new NpgsqlTypes.NpgsqlPoint(x: 0.1758143825870696d, y: 0.8067768066797699d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142328778160524d, y: 0.751513061331081d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49448225960561876d, y: 0.20793804540775196d), new NpgsqlTypes.NpgsqlPoint(x: 0.23440738767891867d, y: 0.8970411859949637d), new NpgsqlTypes.NpgsqlPoint(x: 0.11231372649854632d, y: 0.6696058748577325d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.714604192789441d, y: 0.6873852433984985d), new NpgsqlTypes.NpgsqlPoint(x: 0.21069341651696405d, y: 0.47585744007780695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5239626363316144d, y: 0.8801085951118685d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9021655154577306d, y: 0.15192165855128792d), new NpgsqlTypes.NpgsqlPoint(x: 0.18908635356099768d, y: 0.6633336720731731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7255535865181157d, y: 0.38091883218970246d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19543504939532141d, y: 0.38675551359012694d), new NpgsqlTypes.NpgsqlPoint(x: 0.8940437958989744d, y: 0.7564334472229994d), new NpgsqlTypes.NpgsqlPoint(x: 0.20455429534637604d, y: 0.1997181325673053d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5305482071947869d, y: 0.6588527513960867d), new NpgsqlTypes.NpgsqlPoint(x: 0.5709660261775751d, y: 0.630859935649508d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956513278421564d, y: 0.6964668682033717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.018147622837167865d, y: 0.8930099359632857d), new NpgsqlTypes.NpgsqlPoint(x: 0.36969502511162333d, y: 0.3862857060806941d), new NpgsqlTypes.NpgsqlPoint(x: 0.8524075387985588d, y: 0.7822831941606697d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8502379062139095d, y: 0.35671777891062806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934309559188646d, y: 0.9342585350810105d), new NpgsqlTypes.NpgsqlPoint(x: 0.21096816554733133d, y: 0.2380551999251278d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46213697942563037d, y: 0.08468596156702668d), new NpgsqlTypes.NpgsqlPoint(x: 0.2917698342113695d, y: 0.03544034110428995d), new NpgsqlTypes.NpgsqlPoint(x: 0.23788845032428363d, y: 0.8201290958500662d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.983428211603828d, y: 0.5595204483167207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6189248584899713d, y: 0.9414612524885781d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227651915110362d, y: 0.08584744934105892d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9526870951994195d, y: 0.7207986276047764d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566139660704283d, y: 0.32015339065728854d), new NpgsqlTypes.NpgsqlPoint(x: 0.2447660440572128d, y: 0.7929050609599784d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3616670267402702d, y: 0.07966738544518326d), new NpgsqlTypes.NpgsqlPoint(x: 0.2823885008570969d, y: 0.6890856247980901d), new NpgsqlTypes.NpgsqlPoint(x: 0.03551818542625329d, y: 0.9412500429157546d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2660959916369303d, y: 0.3555014413006732d), new NpgsqlTypes.NpgsqlPoint(x: 0.5461890592806521d, y: 0.21440778873479294d), new NpgsqlTypes.NpgsqlPoint(x: 0.16985500638746243d, y: 0.436178164194129d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1306154629194226d, y: 0.3633697705045228d), new NpgsqlTypes.NpgsqlPoint(x: 0.1152930932951527d, y: 0.6984937836431858d), new NpgsqlTypes.NpgsqlPoint(x: 0.33137463355682284d, y: 0.06814788850595965d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6766578272836518d, y: 0.567033553938473d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112369304432382d, y: 0.7094272158903275d), new NpgsqlTypes.NpgsqlPoint(x: 0.910605703869418d, y: 0.3568025838023474d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4314640354146593d, y: 0.07642304673198663d), new NpgsqlTypes.NpgsqlPoint(x: 0.01366729055730409d, y: 0.5661918257556345d), new NpgsqlTypes.NpgsqlPoint(x: 0.027543511091651318d, y: 0.4553700957901965d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7245294448272586d, y: 0.518383910062374d), new NpgsqlTypes.NpgsqlPoint(x: 0.25682457133688275d, y: 0.30721690112645705d), new NpgsqlTypes.NpgsqlPoint(x: 0.5437441518354096d, y: 0.441744104237799d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06247549271671449d, y: 0.0942495018751015d), new NpgsqlTypes.NpgsqlPoint(x: 0.46725357683407986d, y: 0.7050287927856387d), new NpgsqlTypes.NpgsqlPoint(x: 0.37954424073506343d, y: 0.5172626933257028d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4542505252426595d, y: 0.370791500179523d), new NpgsqlTypes.NpgsqlPoint(x: 0.039052421343176436d, y: 0.9327656764968708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8212937859558793d, y: 0.5966486919641231d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.232739028476315d, y: 0.49287421063628434d), new NpgsqlTypes.NpgsqlPoint(x: 0.0269014564858141d, y: 0.506794546687899d), new NpgsqlTypes.NpgsqlPoint(x: 0.5663031529900834d, y: 0.6750948227991757d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6464763371476223d, y: 0.4042317423611361d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103570467390358d, y: 0.011005224973164474d), new NpgsqlTypes.NpgsqlPoint(x: 0.706486233553967d, y: 0.8313547168283294d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3183929783900663d, y: 0.2157582624403912d), new NpgsqlTypes.NpgsqlPoint(x: 0.49590171866135135d, y: 0.9989805456003318d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759636194900768d, y: 0.1211130409176836d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40519049865295975d, y: 0.31675280472014544d), new NpgsqlTypes.NpgsqlPoint(x: 0.08996382808656112d, y: 0.09565155042807438d), new NpgsqlTypes.NpgsqlPoint(x: 0.0889734864765116d, y: 0.958793528224978d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8806078277347019d, y: 0.2502612718757705d), new NpgsqlTypes.NpgsqlPoint(x: 0.8495126612610195d, y: 0.5338203518109299d), new NpgsqlTypes.NpgsqlPoint(x: 0.10099049139507532d, y: 0.5565770799520106d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15410646455326626d, y: 0.2698869769771737d), new NpgsqlTypes.NpgsqlPoint(x: 0.28074849650758193d, y: 0.23367474778284825d), new NpgsqlTypes.NpgsqlPoint(x: 0.036908116389335555d, y: 0.002635141851337397d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4369205743420618d, y: 0.9540505093825636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325884032713512d, y: 0.5659584907807906d), new NpgsqlTypes.NpgsqlPoint(x: 0.47545077818211934d, y: 0.7939396907325607d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 100,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22594184141526008d, y: 0.16680506934061268d), new NpgsqlTypes.NpgsqlPoint(x: 0.7935555569862479d, y: 0.9347185184894372d), new NpgsqlTypes.NpgsqlPoint(x: 0.989063573672594d, y: 0.8610666733734204d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.635490219741397d, y: 0.4563575312348599d), new NpgsqlTypes.NpgsqlPoint(x: 0.28020586194260566d, y: 0.4468340458766419d), new NpgsqlTypes.NpgsqlPoint(x: 0.7714108781629462d, y: 0.8610772741669852d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.761464501240164d, y: 0.9763680444320518d), new NpgsqlTypes.NpgsqlPoint(x: 0.9623728076339005d, y: 0.6458832966538998d), new NpgsqlTypes.NpgsqlPoint(x: 0.24591913388787434d, y: 0.214634891319753d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25561269146014576d, y: 0.873607955537916d), new NpgsqlTypes.NpgsqlPoint(x: 0.3188690670771245d, y: 0.5963607906123348d), new NpgsqlTypes.NpgsqlPoint(x: 0.362399629209312d, y: 0.6872623506187495d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9311336954388884d, y: 0.06970412251478508d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196828570544593d, y: 0.01526320406059023d), new NpgsqlTypes.NpgsqlPoint(x: 0.639261537238551d, y: 0.8375559202853383d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29953705406450426d, y: 0.0580539206480295d), new NpgsqlTypes.NpgsqlPoint(x: 0.13573943719490855d, y: 0.5301522599637687d), new NpgsqlTypes.NpgsqlPoint(x: 0.19717167953974524d, y: 0.40064905364713d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008279772643070893d, y: 0.25320990358887685d), new NpgsqlTypes.NpgsqlPoint(x: 0.19882897760237017d, y: 0.07646811257986119d), new NpgsqlTypes.NpgsqlPoint(x: 0.17781638681180068d, y: 0.9663268250339069d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22884337908341512d, y: 0.49844512864150736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129698959533133d, y: 0.5079917157094234d), new NpgsqlTypes.NpgsqlPoint(x: 0.1594046427869411d, y: 0.03612818469868739d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8483298061570776d, y: 0.6754473001584909d), new NpgsqlTypes.NpgsqlPoint(x: 0.11464428139343874d, y: 0.9684016241698178d), new NpgsqlTypes.NpgsqlPoint(x: 0.6756007780369295d, y: 0.7629487553780411d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5417597730190968d, y: 0.2826661166829898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3652692894721665d, y: 0.5755565808849469d), new NpgsqlTypes.NpgsqlPoint(x: 0.025492054776064088d, y: 0.605535734528328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8953106708491575d, y: 0.39273245727662065d), new NpgsqlTypes.NpgsqlPoint(x: 0.15903143875206383d, y: 0.026485643772576895d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497904299035636d, y: 0.8596808210173901d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3600689627822644d, y: 0.29855815143014d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368466144657786d, y: 0.7219133179315026d), new NpgsqlTypes.NpgsqlPoint(x: 0.3705698946217394d, y: 0.7487624128118926d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.524793982920497d, y: 0.18855007005308366d), new NpgsqlTypes.NpgsqlPoint(x: 0.028008496280389927d, y: 0.008057703877917266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280266373947176d, y: 0.6289013939873576d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.785687088779337d, y: 0.6954144557303478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5903265160501613d, y: 0.3830926510318191d), new NpgsqlTypes.NpgsqlPoint(x: 0.43337671818683077d, y: 0.44284911143226224d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24388746588903853d, y: 0.6299103756443795d), new NpgsqlTypes.NpgsqlPoint(x: 0.34272854488530935d, y: 0.44508413609721276d), new NpgsqlTypes.NpgsqlPoint(x: 0.21138235605086586d, y: 0.478251912494546d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3563151259344176d, y: 0.04792877021417641d), new NpgsqlTypes.NpgsqlPoint(x: 0.1945093714722239d, y: 0.7207788379991453d), new NpgsqlTypes.NpgsqlPoint(x: 0.1006818756810347d, y: 0.2292076514742888d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9246051543373947d, y: 0.872926838412737d), new NpgsqlTypes.NpgsqlPoint(x: 0.518181887306226d, y: 0.610508477024459d), new NpgsqlTypes.NpgsqlPoint(x: 0.2079352851352687d, y: 0.019316738490068097d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47666726354671063d, y: 0.9179078641787395d), new NpgsqlTypes.NpgsqlPoint(x: 0.656508059402376d, y: 0.9426903316381179d), new NpgsqlTypes.NpgsqlPoint(x: 0.35546227643289663d, y: 0.0803099571756537d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3454761670783404d, y: 0.631148003540276d), new NpgsqlTypes.NpgsqlPoint(x: 0.9190375332122891d, y: 0.00951900754442947d), new NpgsqlTypes.NpgsqlPoint(x: 0.7850567630893507d, y: 0.37200916005206297d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.964506175247136d, y: 0.22934732963560445d), new NpgsqlTypes.NpgsqlPoint(x: 0.706057498206374d, y: 0.33064078192450563d), new NpgsqlTypes.NpgsqlPoint(x: 0.87869305942296d, y: 0.9438449058635258d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9207757459759647d, y: 0.13554466160838785d), new NpgsqlTypes.NpgsqlPoint(x: 0.17360404162256826d, y: 0.12151946107065081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905856048412987d, y: 0.6124826034343218d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12847792490184196d, y: 0.22338959838873051d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035460032885282d, y: 0.7111099552218946d), new NpgsqlTypes.NpgsqlPoint(x: 0.09675379647090643d, y: 0.1512122466582817d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.950586725653926d, y: 0.07760614725652493d), new NpgsqlTypes.NpgsqlPoint(x: 0.5646016527350565d, y: 0.11736692331842613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2969126529037499d, y: 0.23023218762616726d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3463432181040871d, y: 0.47418043674754573d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364166054286557d, y: 0.5392667206292407d), new NpgsqlTypes.NpgsqlPoint(x: 0.07501445111240312d, y: 0.69323394427371d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5026979046572644d, y: 0.4886357730034755d), new NpgsqlTypes.NpgsqlPoint(x: 0.3754365895860604d, y: 0.8705869387030003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690097763526796d, y: 0.14896084187267877d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6641723898901468d, y: 0.3093524495053497d), new NpgsqlTypes.NpgsqlPoint(x: 0.20376301537071384d, y: 0.12467079776018719d), new NpgsqlTypes.NpgsqlPoint(x: 0.529378749084261d, y: 0.5083046070164496d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.699215580597116d, y: 0.2333450441050151d), new NpgsqlTypes.NpgsqlPoint(x: 0.16058011216573365d, y: 0.2564140550474412d), new NpgsqlTypes.NpgsqlPoint(x: 0.6335181221866858d, y: 0.7420996620642307d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4550396592540339d, y: 0.3657952629119139d), new NpgsqlTypes.NpgsqlPoint(x: 0.03731224787218024d, y: 0.7238034497217075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9707085698957238d, y: 0.9662041512569833d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4343528988346683d, y: 0.4041407406222287d), new NpgsqlTypes.NpgsqlPoint(x: 0.9364297574275335d, y: 0.32356453389955975d), new NpgsqlTypes.NpgsqlPoint(x: 0.14651539721955065d, y: 0.35877025788285466d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19343397682704766d, y: 0.4379346612565429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6574933224585436d, y: 0.8221337925419064d), new NpgsqlTypes.NpgsqlPoint(x: 0.537249715969001d, y: 0.3073505509987762d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1648645900896606d, y: 0.27280676374974644d), new NpgsqlTypes.NpgsqlPoint(x: 0.3832538518608125d, y: 0.8546011336760136d), new NpgsqlTypes.NpgsqlPoint(x: 0.15670736525748774d, y: 0.8450406176000512d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07835735390763365d, y: 0.9183606392866551d), new NpgsqlTypes.NpgsqlPoint(x: 0.22884430093061114d, y: 0.48623918517735365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412194597673922d, y: 0.2923954139150068d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5716785852248425d, y: 0.62116881479977d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760889328841871d, y: 0.6210209300934985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2906862067270608d, y: 0.15299760742097734d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5543932537261275d, y: 0.10467477118085522d), new NpgsqlTypes.NpgsqlPoint(x: 0.4931354803970648d, y: 0.983013322040061d), new NpgsqlTypes.NpgsqlPoint(x: 0.1390106008868811d, y: 0.2234589659833368d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48123826679248893d, y: 0.9597971977992966d), new NpgsqlTypes.NpgsqlPoint(x: 0.08461664041674988d, y: 0.46543431219669507d), new NpgsqlTypes.NpgsqlPoint(x: 0.16079492521764138d, y: 0.7855805331963325d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34715586819774047d, y: 0.0690682838514084d), new NpgsqlTypes.NpgsqlPoint(x: 0.9134654822438865d, y: 0.31172316483821616d), new NpgsqlTypes.NpgsqlPoint(x: 0.2030594119139535d, y: 0.7388428138290517d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10816238815026957d, y: 0.33906168053926533d), new NpgsqlTypes.NpgsqlPoint(x: 0.23758370253887307d, y: 0.9169341705544197d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666933241580861d, y: 0.250579319545988d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6718711434133324d, y: 0.5128620112313024d), new NpgsqlTypes.NpgsqlPoint(x: 0.38437636697085986d, y: 0.7989824335570235d), new NpgsqlTypes.NpgsqlPoint(x: 0.2038560016813662d, y: 0.7695273806087602d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6212600705996723d, y: 0.2962510784686839d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441119648919838d, y: 0.8263511214528015d), new NpgsqlTypes.NpgsqlPoint(x: 0.29001924616660446d, y: 0.9637205626764054d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12368207981221546d, y: 0.8708877103588253d), new NpgsqlTypes.NpgsqlPoint(x: 0.403053175157707d, y: 0.13474511496735508d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177762925578684d, y: 0.06322662493581566d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5988947026845978d, y: 0.7207068089235097d), new NpgsqlTypes.NpgsqlPoint(x: 0.574903718515873d, y: 0.2749922855490643d), new NpgsqlTypes.NpgsqlPoint(x: 0.6282590396527613d, y: 0.8047610746589152d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2978261820521463d, y: 0.5521844201097827d), new NpgsqlTypes.NpgsqlPoint(x: 0.11485969712631983d, y: 0.723382287938574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5826024955858317d, y: 0.5565268924062775d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6221365955412888d, y: 0.43569246718448695d), new NpgsqlTypes.NpgsqlPoint(x: 0.167519358255122d, y: 0.8998037277207027d), new NpgsqlTypes.NpgsqlPoint(x: 0.29051982980025326d, y: 0.8386982245093374d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37957476267964796d, y: 0.5899716243355495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6673405560466539d, y: 0.16380619704784638d), new NpgsqlTypes.NpgsqlPoint(x: 0.9694126673929272d, y: 0.886202511561994d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7186453698893447d, y: 0.14566053894189657d), new NpgsqlTypes.NpgsqlPoint(x: 0.481098251454527d, y: 0.9322260498469871d), new NpgsqlTypes.NpgsqlPoint(x: 0.540611466517755d, y: 0.10054452897840238d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29383423562878774d, y: 0.14282491599857738d), new NpgsqlTypes.NpgsqlPoint(x: 0.8726037926413287d, y: 0.04757853874404483d), new NpgsqlTypes.NpgsqlPoint(x: 0.18923526554728276d, y: 0.27034205613624385d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9094437560732054d, y: 0.674653093766635d), new NpgsqlTypes.NpgsqlPoint(x: 0.48186459695513084d, y: 0.7673108087623699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8564284400673452d, y: 0.25993411388803334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5966082133175843d, y: 0.07572509578554298d), new NpgsqlTypes.NpgsqlPoint(x: 0.12387339449641954d, y: 0.2709851383212929d), new NpgsqlTypes.NpgsqlPoint(x: 0.4236166469150453d, y: 0.7896772437221161d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024412631368916027d, y: 0.46685562800124425d), new NpgsqlTypes.NpgsqlPoint(x: 0.22106439687776647d, y: 0.6867566096353759d), new NpgsqlTypes.NpgsqlPoint(x: 0.22535467718919233d, y: 0.013276478788160295d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07398405066834646d, y: 0.5523854449522048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4514801321927089d, y: 0.6103451661723193d), new NpgsqlTypes.NpgsqlPoint(x: 0.41041645700725493d, y: 0.9988102213868907d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8565982718209009d, y: 0.09039235038751792d), new NpgsqlTypes.NpgsqlPoint(x: 0.65151643939508d, y: 0.8985488869388613d), new NpgsqlTypes.NpgsqlPoint(x: 0.831236561991173d, y: 0.8787613287238977d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2698043407828764d, y: 0.998236665932072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5369868610638241d, y: 0.04582703331654858d), new NpgsqlTypes.NpgsqlPoint(x: 0.29329851496556014d, y: 0.8804907236418171d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3034653064815598d, y: 0.7787664850719489d), new NpgsqlTypes.NpgsqlPoint(x: 0.7996597223917957d, y: 0.15417138788814344d), new NpgsqlTypes.NpgsqlPoint(x: 0.31955725959123726d, y: 0.8815911150780273d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.698380416391438d, y: 0.6670797805330242d), new NpgsqlTypes.NpgsqlPoint(x: 0.44713298423971604d, y: 0.9704781967336247d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407935630017247d, y: 0.19032697663781428d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 105,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6336442154309944d, y: 0.5738641713835254d), new NpgsqlTypes.NpgsqlPoint(x: 0.101276049170819d, y: 0.6347907865440594d), new NpgsqlTypes.NpgsqlPoint(x: 0.33984413199665897d, y: 0.8003004502259913d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6279183871980446d, y: 0.6694321775103752d), new NpgsqlTypes.NpgsqlPoint(x: 0.10394372321559164d, y: 0.0899087141045598d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035624724490410653d, y: 0.8120875519452098d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.513752757702674d, y: 0.544943560559689d), new NpgsqlTypes.NpgsqlPoint(x: 0.32207452758537525d, y: 0.8330672203434731d), new NpgsqlTypes.NpgsqlPoint(x: 0.7077682179732018d, y: 0.030148524554210465d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7004171575906991d, y: 0.5721874629142732d), new NpgsqlTypes.NpgsqlPoint(x: 0.908702011538383d, y: 0.026861488235049302d), new NpgsqlTypes.NpgsqlPoint(x: 0.14752539856690683d, y: 0.16887219437381829d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7129590520501636d, y: 0.3736188507707042d), new NpgsqlTypes.NpgsqlPoint(x: 0.4350033511131337d, y: 0.6595536518583612d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376239448521731d, y: 0.08062633302403188d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9422819317702071d, y: 0.2973254745846703d), new NpgsqlTypes.NpgsqlPoint(x: 0.8336349479351631d, y: 0.9739918339580864d), new NpgsqlTypes.NpgsqlPoint(x: 0.22662240185201643d, y: 0.7337398278189776d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6536258812976692d, y: 0.4522372524710496d), new NpgsqlTypes.NpgsqlPoint(x: 0.6276667820554481d, y: 0.7282158431201905d), new NpgsqlTypes.NpgsqlPoint(x: 0.8438754513608129d, y: 0.6782062656349619d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0736545960956001d, y: 0.325543675806509d), new NpgsqlTypes.NpgsqlPoint(x: 0.44526287130364794d, y: 0.5914219569892765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8481632057268831d, y: 0.6828094483980404d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6547636050502819d, y: 0.5704348476245746d), new NpgsqlTypes.NpgsqlPoint(x: 0.7853164336388893d, y: 0.46980391547558054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8885802899718472d, y: 0.8137001448899126d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24437405578196492d, y: 0.25289000976788667d), new NpgsqlTypes.NpgsqlPoint(x: 0.051417500224378965d, y: 0.7537771752162646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147850337488443d, y: 0.6775551166126281d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25197975612201373d, y: 0.28290277157127575d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298089142501311d, y: 0.2938505113280482d), new NpgsqlTypes.NpgsqlPoint(x: 0.3895809746710862d, y: 0.5453028496553838d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27390489728114875d, y: 0.2411146675726319d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705165138656675d, y: 0.36802699762025004d), new NpgsqlTypes.NpgsqlPoint(x: 0.38794451972095834d, y: 0.8319412157693213d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8659072291344972d, y: 0.5987685734364995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7589154560777343d, y: 0.38336974825651904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5208593344248715d, y: 0.7009270445965549d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1404967055458496d, y: 0.748103240501037d), new NpgsqlTypes.NpgsqlPoint(x: 0.6470665205289694d, y: 0.2773354872070919d), new NpgsqlTypes.NpgsqlPoint(x: 0.9030295597801364d, y: 0.42865518021525106d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5266339135730618d, y: 0.03614520167380986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6441912990620269d, y: 0.3552396325548963d), new NpgsqlTypes.NpgsqlPoint(x: 0.22337241082878356d, y: 0.6483728673174362d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1996759949794923d, y: 0.2771166883096219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7668512517792025d, y: 0.1739153505082387d), new NpgsqlTypes.NpgsqlPoint(x: 0.13363573139593743d, y: 0.03862104128638322d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6033173782027793d, y: 0.3481858895211841d), new NpgsqlTypes.NpgsqlPoint(x: 0.3129900589655499d, y: 0.40829278344314024d), new NpgsqlTypes.NpgsqlPoint(x: 0.23865998551197176d, y: 0.8670473233431784d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21716552603695705d, y: 0.32379641521979774d), new NpgsqlTypes.NpgsqlPoint(x: 0.49258471644113666d, y: 0.26513725545753886d), new NpgsqlTypes.NpgsqlPoint(x: 0.09306622709401158d, y: 0.8655683882265737d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6030656691005136d, y: 0.2667747821020805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5733115037346813d, y: 0.12244666051685182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7864649398127818d, y: 0.9387503689548728d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7620182563967176d, y: 0.9427239455515866d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652103716969323d, y: 0.6600687372350491d), new NpgsqlTypes.NpgsqlPoint(x: 0.7604944467886285d, y: 0.9856521817039314d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5052884048414522d, y: 0.446808037608705d), new NpgsqlTypes.NpgsqlPoint(x: 0.43242799631355655d, y: 0.8363087562574594d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007864984542302d, y: 0.7344446414685976d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3233284978408506d, y: 0.1250125048910502d), new NpgsqlTypes.NpgsqlPoint(x: 0.10888393302673083d, y: 0.01945699324220984d), new NpgsqlTypes.NpgsqlPoint(x: 0.2299508837479307d, y: 0.3428318551056363d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.060794453187090314d, y: 0.7778676425098613d), new NpgsqlTypes.NpgsqlPoint(x: 0.002414346343576068d, y: 0.987860125658087d), new NpgsqlTypes.NpgsqlPoint(x: 0.01929266820921105d, y: 0.15252713230823212d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.932483055537495d, y: 0.42677430272194916d), new NpgsqlTypes.NpgsqlPoint(x: 0.11394859223493281d, y: 0.3539675622509273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7937487687954506d, y: 0.42255640738540545d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3058470462490116d, y: 0.05941196992495368d), new NpgsqlTypes.NpgsqlPoint(x: 0.37172877593134057d, y: 0.9227405852921715d), new NpgsqlTypes.NpgsqlPoint(x: 0.3588941405076146d, y: 0.206894907516892d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9125451436125418d, y: 0.5893214647845697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8533433719944289d, y: 0.41795507675838894d), new NpgsqlTypes.NpgsqlPoint(x: 0.8076484250516391d, y: 0.06235499665594735d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9731933241538325d, y: 0.744237035548322d), new NpgsqlTypes.NpgsqlPoint(x: 0.48156550612433646d, y: 0.96406259236702d), new NpgsqlTypes.NpgsqlPoint(x: 0.8989521923772067d, y: 0.2344554976911356d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4358608860800063d, y: 0.6874420555120929d), new NpgsqlTypes.NpgsqlPoint(x: 0.5658728017275269d, y: 0.3981333562037903d), new NpgsqlTypes.NpgsqlPoint(x: 0.21121218619963766d, y: 0.4374855891952729d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8136156202066128d, y: 0.6363693526193379d), new NpgsqlTypes.NpgsqlPoint(x: 0.028401657787042622d, y: 0.7667858229506793d), new NpgsqlTypes.NpgsqlPoint(x: 0.57376691932791d, y: 0.4752626430189991d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0015958609593316186d, y: 0.23087198698724976d), new NpgsqlTypes.NpgsqlPoint(x: 0.19139660459256957d, y: 0.4648612275965076d), new NpgsqlTypes.NpgsqlPoint(x: 0.9197289239098969d, y: 0.8198601877014032d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36096063335573714d, y: 0.2655306350166381d), new NpgsqlTypes.NpgsqlPoint(x: 0.3203523595549873d, y: 0.2920727261244832d), new NpgsqlTypes.NpgsqlPoint(x: 0.9832649385069299d, y: 0.3698460761264015d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9537873931834429d, y: 0.49558972752064945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8494048309711024d, y: 0.8768074326022488d), new NpgsqlTypes.NpgsqlPoint(x: 0.08314335069401058d, y: 0.48617243594286885d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16964553432766905d, y: 0.4662443594065253d), new NpgsqlTypes.NpgsqlPoint(x: 0.21975545267702612d, y: 0.09675785895434275d), new NpgsqlTypes.NpgsqlPoint(x: 0.8513790226932952d, y: 0.22869971804198497d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27478356100214685d, y: 0.9634074954984865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6493803427862647d, y: 0.16221353950749673d), new NpgsqlTypes.NpgsqlPoint(x: 0.8616441776510234d, y: 0.8229784013410909d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26830471289708346d, y: 0.19448062163377688d), new NpgsqlTypes.NpgsqlPoint(x: 0.13535025059436823d, y: 0.7310586258924656d), new NpgsqlTypes.NpgsqlPoint(x: 0.606207687868476d, y: 0.19167808815536025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5678013819220596d, y: 0.8612825087856809d), new NpgsqlTypes.NpgsqlPoint(x: 0.4271624773359445d, y: 0.30505876674644994d), new NpgsqlTypes.NpgsqlPoint(x: 0.6232150528296594d, y: 0.12456399452483402d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34183292002457566d, y: 0.7031467496344342d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094218353526262d, y: 0.4648411712363256d), new NpgsqlTypes.NpgsqlPoint(x: 0.607938285057289d, y: 0.22939235746787368d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7249894645452215d, y: 0.4592983436191729d), new NpgsqlTypes.NpgsqlPoint(x: 0.4209490021866381d, y: 0.9383570446434286d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631487937850585d, y: 0.08070452847028686d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45555255166835573d, y: 0.10311779201305193d), new NpgsqlTypes.NpgsqlPoint(x: 0.18361526955474794d, y: 0.8865762745727213d), new NpgsqlTypes.NpgsqlPoint(x: 0.301224582216726d, y: 0.7013378520478362d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.032790810248760405d, y: 0.32718386991385084d), new NpgsqlTypes.NpgsqlPoint(x: 0.26327578592253065d, y: 0.4443230304958823d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439297535211658d, y: 0.5362140229898368d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9661436376583399d, y: 0.6594198511805054d), new NpgsqlTypes.NpgsqlPoint(x: 0.9840082563734616d, y: 0.3837760432081577d), new NpgsqlTypes.NpgsqlPoint(x: 0.43666550897678535d, y: 0.6389326196666091d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027585368302998736d, y: 0.8143501448892821d), new NpgsqlTypes.NpgsqlPoint(x: 0.7644277373664875d, y: 0.9887959070829981d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167018689097167d, y: 0.9467922178548364d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8131055037812409d, y: 0.22805429441871883d), new NpgsqlTypes.NpgsqlPoint(x: 0.3756397510812698d, y: 0.9291308812807006d), new NpgsqlTypes.NpgsqlPoint(x: 0.5146383814083751d, y: 0.1352680236892181d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054281491287974326d, y: 0.9713626482705592d), new NpgsqlTypes.NpgsqlPoint(x: 0.578088910593246d, y: 0.015495954810569201d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326104776777466d, y: 0.8680543981169675d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29592189134139835d, y: 0.4679377267209409d), new NpgsqlTypes.NpgsqlPoint(x: 0.40111298543052754d, y: 0.5847215282764003d), new NpgsqlTypes.NpgsqlPoint(x: 0.10371209239614987d, y: 0.892625968777263d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8550751239701684d, y: 0.10898373958209695d), new NpgsqlTypes.NpgsqlPoint(x: 0.17825924427539375d, y: 0.08706274459979257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7231309728716592d, y: 0.2457576021152561d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013840745633800333d, y: 0.3429583334570626d), new NpgsqlTypes.NpgsqlPoint(x: 0.38079048096149515d, y: 0.8517304659714932d), new NpgsqlTypes.NpgsqlPoint(x: 0.7636132340934302d, y: 0.5586288578250348d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5221220192771335d, y: 0.9848014759077129d), new NpgsqlTypes.NpgsqlPoint(x: 0.2062098873244259d, y: 0.967053113615157d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210425107282285d, y: 0.16348555159680567d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.178094405661255d, y: 0.25334042395770706d), new NpgsqlTypes.NpgsqlPoint(x: 0.5307052293085327d, y: 0.2644044513068061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9509537478317517d, y: 0.31476783973794187d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4236623155274125d, y: 0.44324542140649126d), new NpgsqlTypes.NpgsqlPoint(x: 0.24515402410595954d, y: 0.6045048709630967d), new NpgsqlTypes.NpgsqlPoint(x: 0.3071131434826493d, y: 0.19661526168422117d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7725620642314023d, y: 0.07352431452890729d), new NpgsqlTypes.NpgsqlPoint(x: 0.8222713582385546d, y: 0.28113958319885635d), new NpgsqlTypes.NpgsqlPoint(x: 0.46505345436736445d, y: 0.5567670969541229d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8477469328744122d, y: 0.016570133376719087d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883125622692437d, y: 0.5166133098291962d), new NpgsqlTypes.NpgsqlPoint(x: 0.07407352304194059d, y: 0.6976660239873602d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6659251994953531d, y: 0.833754997996549d), new NpgsqlTypes.NpgsqlPoint(x: 0.07230832727460457d, y: 0.35387435963271774d), new NpgsqlTypes.NpgsqlPoint(x: 0.39775414859970937d, y: 0.9516939004205722d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43016813476925253d, y: 0.6174988105292235d), new NpgsqlTypes.NpgsqlPoint(x: 0.535025516651309d, y: 0.8386471400587073d), new NpgsqlTypes.NpgsqlPoint(x: 0.19697140582797268d, y: 0.9845361144930936d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7666614703923917d, y: 0.7036782480263952d), new NpgsqlTypes.NpgsqlPoint(x: 0.6161626108387983d, y: 0.40668842663422056d), new NpgsqlTypes.NpgsqlPoint(x: 0.35579235290090605d, y: 0.9202782096027219d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43745699552176d, y: 0.7012044820826554d), new NpgsqlTypes.NpgsqlPoint(x: 0.45560114403100416d, y: 0.3223262066462049d), new NpgsqlTypes.NpgsqlPoint(x: 0.28457896451402054d, y: 0.21243930660835864d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3540370352520027d, y: 0.634198458177116d), new NpgsqlTypes.NpgsqlPoint(x: 0.23213142511907803d, y: 0.5620055097436091d), new NpgsqlTypes.NpgsqlPoint(x: 0.6401675253666494d, y: 0.4633953055727965d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5706003637520778d, y: 0.9245593999186937d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368447065224836d, y: 0.4632885099595727d), new NpgsqlTypes.NpgsqlPoint(x: 0.900123286177906d, y: 0.4877993447428133d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19084616623162476d, y: 0.38039824862537597d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352994803016153d, y: 0.2043869119006212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8701865496890434d, y: 0.3094877855856977d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5863338054720013d, y: 0.11354886600523728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2123422157548588d, y: 0.3540406754955949d), new NpgsqlTypes.NpgsqlPoint(x: 0.30637941152075443d, y: 0.18277623296422263d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8113401369421643d, y: 0.39622376628344724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9550616968874599d, y: 0.4170186362352485d), new NpgsqlTypes.NpgsqlPoint(x: 0.7356301614390166d, y: 0.46608518963938217d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6620891754793139d, y: 0.7648210849388767d), new NpgsqlTypes.NpgsqlPoint(x: 0.4411312795356095d, y: 0.7332238797063423d), new NpgsqlTypes.NpgsqlPoint(x: 0.9658708055291566d, y: 0.5408148474344077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36414965013276057d, y: 0.157835634969257d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325884081582548d, y: 0.38429506152673376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7933216363402711d, y: 0.6301116557206209d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39724367639669045d, y: 0.14548270962026544d), new NpgsqlTypes.NpgsqlPoint(x: 0.9857831150278354d, y: 0.608916040201549d), new NpgsqlTypes.NpgsqlPoint(x: 0.17953780877529035d, y: 0.07438721554510119d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7758591454276353d, y: 0.020657162532625284d), new NpgsqlTypes.NpgsqlPoint(x: 0.7158169753505815d, y: 0.5914399033464961d), new NpgsqlTypes.NpgsqlPoint(x: 0.7634407406771715d, y: 0.7146990574665142d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3734650790918951d, y: 0.08272564313211905d), new NpgsqlTypes.NpgsqlPoint(x: 0.1822485213070547d, y: 0.9705196857243481d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253321137825952d, y: 0.2432927911339131d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3163982138031646d, y: 0.9202802624976466d), new NpgsqlTypes.NpgsqlPoint(x: 0.49897913633833213d, y: 0.11413248119346342d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937410870369559d, y: 0.5369397588684519d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13936409708957698d, y: 0.6904912781778072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395520561451148d, y: 0.6252464302831162d), new NpgsqlTypes.NpgsqlPoint(x: 0.87358008138629d, y: 0.6847455214762658d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26105520424435924d, y: 0.17186960664812578d), new NpgsqlTypes.NpgsqlPoint(x: 0.18570992745854065d, y: 0.6787639220249829d), new NpgsqlTypes.NpgsqlPoint(x: 0.28401959016844647d, y: 0.47950218572992964d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9370793564941182d, y: 0.8840615159779127d), new NpgsqlTypes.NpgsqlPoint(x: 0.23165895262374692d, y: 0.7796539803935021d), new NpgsqlTypes.NpgsqlPoint(x: 0.4235556900511075d, y: 0.3103061941558102d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.649407560706994d, y: 0.015213256149833265d), new NpgsqlTypes.NpgsqlPoint(x: 0.9111521510315672d, y: 0.938577880498063d), new NpgsqlTypes.NpgsqlPoint(x: 0.05468232887044011d, y: 0.18412839005884074d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22809137982487704d, y: 0.19712471484421956d), new NpgsqlTypes.NpgsqlPoint(x: 0.7037026004577033d, y: 0.29267536055096943d), new NpgsqlTypes.NpgsqlPoint(x: 0.2603408199484343d, y: 0.19819228499386354d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4353495378560154d, y: 0.12564174594016653d), new NpgsqlTypes.NpgsqlPoint(x: 0.017503073251815104d, y: 0.8673777720289733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4327459143697938d, y: 0.6334848930382927d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8316098527763803d, y: 0.5735436289746247d), new NpgsqlTypes.NpgsqlPoint(x: 0.49690752152681184d, y: 0.1797275617823847d), new NpgsqlTypes.NpgsqlPoint(x: 0.46998889070745964d, y: 0.12391230976363787d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7645823108955535d, y: 0.7771353456093258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624329618954021d, y: 0.4720957325127303d), new NpgsqlTypes.NpgsqlPoint(x: 0.4578712247158542d, y: 0.8723664969117709d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9904616215951311d, y: 0.9634949503168008d), new NpgsqlTypes.NpgsqlPoint(x: 0.25720499938120367d, y: 0.10108171949824651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8651866109040641d, y: 0.18025542885757462d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0019038707321769044d, y: 0.10440165402772028d), new NpgsqlTypes.NpgsqlPoint(x: 0.701230821170893d, y: 0.20473077831208508d), new NpgsqlTypes.NpgsqlPoint(x: 0.14872541665470074d, y: 0.37715188673328803d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11748999773301738d, y: 0.1746393974640712d), new NpgsqlTypes.NpgsqlPoint(x: 0.5029561380288385d, y: 0.7556101196693923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5161642295090472d, y: 0.7423362902212574d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46216555647522284d, y: 0.9495823743165303d), new NpgsqlTypes.NpgsqlPoint(x: 0.3462012239596184d, y: 0.7853654983686207d), new NpgsqlTypes.NpgsqlPoint(x: 0.27266997101192214d, y: 0.8271172093721461d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4185918476349646d, y: 0.11849266208811926d), new NpgsqlTypes.NpgsqlPoint(x: 0.39597192702477735d, y: 0.07597875018713074d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207661072525d, y: 0.8697460429836893d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9148601265748098d, y: 0.5493246733894236d), new NpgsqlTypes.NpgsqlPoint(x: 0.2945679024877387d, y: 0.31579355904747164d), new NpgsqlTypes.NpgsqlPoint(x: 0.2359822413974617d, y: 0.09853041739231905d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2939000627886361d, y: 0.8189743678975631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8644072034720213d, y: 0.4843049277775492d), new NpgsqlTypes.NpgsqlPoint(x: 0.22048381916126691d, y: 0.9475730939653624d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41496825437260454d, y: 0.5728073477522186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8737913431181815d, y: 0.26734025937394423d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057146863886103d, y: 0.21172495595473717d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5268327970856276d, y: 0.5894238402412965d), new NpgsqlTypes.NpgsqlPoint(x: 0.6298113074202568d, y: 0.20596964894217074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3051861707930733d, y: 0.8849635604660513d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7303294323410902d, y: 0.6970423021674466d), new NpgsqlTypes.NpgsqlPoint(x: 0.5322592284307455d, y: 0.14274301510057819d), new NpgsqlTypes.NpgsqlPoint(x: 0.6893026648805128d, y: 0.586065422638063d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42259779483416493d, y: 0.40388089785308046d), new NpgsqlTypes.NpgsqlPoint(x: 0.6858595757640766d, y: 0.8275669851996412d), new NpgsqlTypes.NpgsqlPoint(x: 0.16445535230310293d, y: 0.5178478869840089d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033578833297570054d, y: 0.1828714633762044d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624634550374177d, y: 0.41049982924848116d), new NpgsqlTypes.NpgsqlPoint(x: 0.2290233020944864d, y: 0.7203084152376705d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6355918627434828d, y: 0.5812336309227037d), new NpgsqlTypes.NpgsqlPoint(x: 0.07907380627300542d, y: 0.05621958775802305d), new NpgsqlTypes.NpgsqlPoint(x: 0.44700946129148755d, y: 0.4366633332489166d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2263519753159503d, y: 0.3311693018465246d), new NpgsqlTypes.NpgsqlPoint(x: 0.008156451274367038d, y: 0.01242841205296119d), new NpgsqlTypes.NpgsqlPoint(x: 0.38336766643087694d, y: 0.09322698098078908d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03389306264328984d, y: 0.08310627009926241d), new NpgsqlTypes.NpgsqlPoint(x: 0.3065532420756478d, y: 0.7849725303816341d), new NpgsqlTypes.NpgsqlPoint(x: 0.5280040984033393d, y: 0.2719460625166822d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9058303831588314d, y: 0.757723617081323d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363986775420653d, y: 0.3634438417949549d), new NpgsqlTypes.NpgsqlPoint(x: 0.8950311578278665d, y: 0.029059880421263173d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9916686923906749d, y: 0.012556356451788542d), new NpgsqlTypes.NpgsqlPoint(x: 0.8823094659875466d, y: 0.7240730924952059d), new NpgsqlTypes.NpgsqlPoint(x: 0.9240022434394961d, y: 0.8402437389673016d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8619774837870764d, y: 0.8020383804798047d), new NpgsqlTypes.NpgsqlPoint(x: 0.11902217911986812d, y: 0.10495672796008448d), new NpgsqlTypes.NpgsqlPoint(x: 0.22810838984489568d, y: 0.7176214916335314d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8518725324071624d, y: 0.33468704550006545d), new NpgsqlTypes.NpgsqlPoint(x: 0.47322376803652577d, y: 0.14563211152204136d), new NpgsqlTypes.NpgsqlPoint(x: 0.6260867156866006d, y: 0.5836156047912194d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4067753504401095d, y: 0.7884502075690905d), new NpgsqlTypes.NpgsqlPoint(x: 0.17254800066971698d, y: 0.030895226661209585d), new NpgsqlTypes.NpgsqlPoint(x: 0.08490458469517614d, y: 0.6063837487825565d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3840473334896928d, y: 0.7880368510011703d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922400558509456d, y: 0.22645812933215403d), new NpgsqlTypes.NpgsqlPoint(x: 0.16932056629158654d, y: 0.09874373139764259d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46680865104174785d, y: 0.8948017446004374d), new NpgsqlTypes.NpgsqlPoint(x: 0.15647380431978153d, y: 0.7866044210444d), new NpgsqlTypes.NpgsqlPoint(x: 0.9369607316163d, y: 0.04779773794220232d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1436914755790787d, y: 0.006956806769645052d), new NpgsqlTypes.NpgsqlPoint(x: 0.19295548650732441d, y: 0.8049417707107852d), new NpgsqlTypes.NpgsqlPoint(x: 0.12282582671122744d, y: 0.5602581565743997d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.614360839188596d, y: 0.09797003946014293d), new NpgsqlTypes.NpgsqlPoint(x: 0.4238171586873455d, y: 0.9629851555333159d), new NpgsqlTypes.NpgsqlPoint(x: 0.01714596282960612d, y: 0.8489370156948793d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5383596256134227d, y: 0.6106095170379203d), new NpgsqlTypes.NpgsqlPoint(x: 0.12051733378958795d, y: 0.2882476368926514d), new NpgsqlTypes.NpgsqlPoint(x: 0.00910390783229953d, y: 0.7141034194760202d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3843159807058498d, y: 0.6064077029842089d), new NpgsqlTypes.NpgsqlPoint(x: 0.09448938554368358d, y: 0.7323459820071183d), new NpgsqlTypes.NpgsqlPoint(x: 0.1950320814104417d, y: 0.016729349016622597d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11705058755748188d, y: 0.3628915047341408d), new NpgsqlTypes.NpgsqlPoint(x: 0.7347780955497706d, y: 0.2967811116241784d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932420059823629d, y: 0.4853285783400767d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6048440791485828d, y: 0.6573232965719733d), new NpgsqlTypes.NpgsqlPoint(x: 0.35167257812159414d, y: 0.37119759529071805d), new NpgsqlTypes.NpgsqlPoint(x: 0.70428663602567d, y: 0.38641756674483596d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.428345896141186d, y: 0.2033210676799988d), new NpgsqlTypes.NpgsqlPoint(x: 0.10748853112192724d, y: 0.6544137188600166d), new NpgsqlTypes.NpgsqlPoint(x: 0.25564309526955287d, y: 0.251561453945651d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3665108280895324d, y: 0.5967596876626072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9847686901255475d, y: 0.3077534255674259d), new NpgsqlTypes.NpgsqlPoint(x: 0.20875809859330474d, y: 0.5313750897212524d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7609514958475833d, y: 0.8649779638493913d), new NpgsqlTypes.NpgsqlPoint(x: 0.052715591034069975d, y: 0.6609370284775752d), new NpgsqlTypes.NpgsqlPoint(x: 0.6538819766735375d, y: 0.22116241330476227d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2555626706807177d, y: 0.32949146744870383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122774519860926d, y: 0.6568398685450528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8768271673745504d, y: 0.6545209256464696d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.732748430979529d, y: 0.623679878051511d), new NpgsqlTypes.NpgsqlPoint(x: 0.2150503426459871d, y: 0.5434368331179072d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199427798230255d, y: 0.8057008392043488d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5926173292216542d, y: 0.4103254974436832d), new NpgsqlTypes.NpgsqlPoint(x: 0.3611604729693523d, y: 0.1165197360525283d), new NpgsqlTypes.NpgsqlPoint(x: 0.5413807930649568d, y: 0.15496383338880781d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1750486684255793d, y: 0.6470039075580727d), new NpgsqlTypes.NpgsqlPoint(x: 0.6306059161327585d, y: 0.5246251992719112d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633048263579166d, y: 0.20829398701351276d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8509004778579335d, y: 0.34059339406963907d), new NpgsqlTypes.NpgsqlPoint(x: 0.25287331633122756d, y: 0.24505570759551487d), new NpgsqlTypes.NpgsqlPoint(x: 0.19486711013725977d, y: 0.945004233039194d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3876203855338167d, y: 0.006382411488165873d), new NpgsqlTypes.NpgsqlPoint(x: 0.15513217441215466d, y: 0.2507636023838137d), new NpgsqlTypes.NpgsqlPoint(x: 0.8842138507745068d, y: 0.5510505300420303d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3733520779818691d, y: 0.0029590838001110065d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327712307793746d, y: 0.9538825515627162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5116305331623444d, y: 0.6285748749918284d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43092176377610936d, y: 0.4204732267417193d), new NpgsqlTypes.NpgsqlPoint(x: 0.18372760522814546d, y: 0.3782131067824148d), new NpgsqlTypes.NpgsqlPoint(x: 0.701251950212084d, y: 0.6882483880812694d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6792923046842338d, y: 0.7841890384900072d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704071788229426d, y: 0.6037341992801332d), new NpgsqlTypes.NpgsqlPoint(x: 0.43019729910023363d, y: 0.9847124808875966d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6047456001650706d, y: 0.14311846884925328d), new NpgsqlTypes.NpgsqlPoint(x: 0.16679542724128016d, y: 0.733238230862084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266934600871036d, y: 0.2648628050455547d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.619612919533396d, y: 0.4180116064231564d), new NpgsqlTypes.NpgsqlPoint(x: 0.4911808599296037d, y: 0.431052192548929d), new NpgsqlTypes.NpgsqlPoint(x: 0.7704047486064638d, y: 0.7478458723952275d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6085838829002279d, y: 0.13485548027256633d), new NpgsqlTypes.NpgsqlPoint(x: 0.08081449450503952d, y: 0.31464063195502867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7583343805604857d, y: 0.5710549581453207d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15981129145293094d, y: 0.11526642155427691d), new NpgsqlTypes.NpgsqlPoint(x: 0.9477159228216743d, y: 0.4970037158715105d), new NpgsqlTypes.NpgsqlPoint(x: 0.9316659681711255d, y: 0.9514322530207652d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19457869412159168d, y: 0.8263231080905318d), new NpgsqlTypes.NpgsqlPoint(x: 0.9405422385150088d, y: 0.39602830442948334d), new NpgsqlTypes.NpgsqlPoint(x: 0.763321414737864d, y: 0.03091802823058354d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6669248502050924d, y: 0.10210416942302014d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203918399547858d, y: 0.8512288375517107d), new NpgsqlTypes.NpgsqlPoint(x: 0.11973655060397226d, y: 0.5314261003115704d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14869362191848945d, y: 0.41069463316500465d), new NpgsqlTypes.NpgsqlPoint(x: 0.20636888065081338d, y: 0.2559033963700462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6446449396513836d, y: 0.6839064445115536d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7943908819557748d, y: 0.12888011849619485d), new NpgsqlTypes.NpgsqlPoint(x: 0.9277762729725209d, y: 0.8348107112483875d), new NpgsqlTypes.NpgsqlPoint(x: 0.14378888677118928d, y: 0.7619263128424152d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6961556094159124d, y: 0.5587941590324739d), new NpgsqlTypes.NpgsqlPoint(x: 0.05128293156713459d, y: 0.695961595964088d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880493869976667d, y: 0.9999519378519578d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4958264677655291d, y: 0.2592858676066553d), new NpgsqlTypes.NpgsqlPoint(x: 0.9486208618551925d, y: 0.002880083512479925d), new NpgsqlTypes.NpgsqlPoint(x: 0.36332409107985153d, y: 0.9004982609786549d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1203207002087815d, y: 0.9305805378540607d), new NpgsqlTypes.NpgsqlPoint(x: 0.2534552709243333d, y: 0.3003471478667964d), new NpgsqlTypes.NpgsqlPoint(x: 0.2693743252052313d, y: 0.7012360646564685d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22626917963336046d, y: 0.7662305131772069d), new NpgsqlTypes.NpgsqlPoint(x: 0.44717014726879245d, y: 0.6603683894397969d), new NpgsqlTypes.NpgsqlPoint(x: 0.2480522609774375d, y: 0.5385751669954378d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12653358088814004d, y: 0.7186111480997668d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417244160844275d, y: 0.9084147974841221d), new NpgsqlTypes.NpgsqlPoint(x: 0.5595536422491888d, y: 0.40659329903553176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019420566097753333d, y: 0.25074947623355237d), new NpgsqlTypes.NpgsqlPoint(x: 0.4490505172381509d, y: 0.23424203691969425d), new NpgsqlTypes.NpgsqlPoint(x: 0.664166583587746d, y: 0.19385342494076874d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13862376494986084d, y: 0.38875929437364276d), new NpgsqlTypes.NpgsqlPoint(x: 0.32014115512082864d, y: 0.6825012419528398d), new NpgsqlTypes.NpgsqlPoint(x: 0.5241888629116683d, y: 0.5844831075820811d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30474003810174244d, y: 0.1808668232094487d), new NpgsqlTypes.NpgsqlPoint(x: 0.02193134341970715d, y: 0.6928629668226003d), new NpgsqlTypes.NpgsqlPoint(x: 0.8234331780092705d, y: 0.1294584438602634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.008053461867671197d, y: 0.24114357976886414d), new NpgsqlTypes.NpgsqlPoint(x: 0.0943099053637072d, y: 0.7865990186868685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570274163990513d, y: 0.5297107630303018d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8146329973811505d, y: 0.1069197320518438d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736479398913003d, y: 0.5639419500287476d), new NpgsqlTypes.NpgsqlPoint(x: 0.3162115923953288d, y: 0.2438298396248073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6552334411443634d, y: 0.7036976503977335d), new NpgsqlTypes.NpgsqlPoint(x: 0.9023506490566442d, y: 0.7303540085514908d), new NpgsqlTypes.NpgsqlPoint(x: 0.4100579719230454d, y: 0.5346524509291238d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5239671222128408d, y: 0.2615455694276032d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484102477325878d, y: 0.8250853458874773d), new NpgsqlTypes.NpgsqlPoint(x: 0.9382491491600209d, y: 0.5762137441603504d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 117,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3249465658960109d, y: 0.9532021252491688d), new NpgsqlTypes.NpgsqlPoint(x: 0.22220514211159603d, y: 0.41485858972486844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9514913038457693d, y: 0.14729870751738072d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5140329426934132d, y: 0.6144546415678384d), new NpgsqlTypes.NpgsqlPoint(x: 0.8543090530093955d, y: 0.23151880949885506d), new NpgsqlTypes.NpgsqlPoint(x: 0.2730807985588164d, y: 0.9998417060211445d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6239476970164355d, y: 0.3181973956401314d), new NpgsqlTypes.NpgsqlPoint(x: 0.04054404148101676d, y: 0.20850999570802664d), new NpgsqlTypes.NpgsqlPoint(x: 0.9452016001613344d, y: 0.9885241075548866d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8729605560234508d, y: 0.0502810330203971d), new NpgsqlTypes.NpgsqlPoint(x: 0.32106572971849323d, y: 0.3655928141299267d), new NpgsqlTypes.NpgsqlPoint(x: 0.49772664132761046d, y: 0.34621467283253216d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3479383706818605d, y: 0.864769077904246d), new NpgsqlTypes.NpgsqlPoint(x: 0.2437966812800053d, y: 0.3135680624234155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388127146625868d, y: 0.43362925683503684d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5253106189181787d, y: 0.3642792512168995d), new NpgsqlTypes.NpgsqlPoint(x: 0.39719000397238835d, y: 0.5788173637218882d), new NpgsqlTypes.NpgsqlPoint(x: 0.45340018837772555d, y: 0.3772665016433453d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7209597033941959d, y: 0.44487556762528135d), new NpgsqlTypes.NpgsqlPoint(x: 0.037700544754222576d, y: 0.6823999692522363d), new NpgsqlTypes.NpgsqlPoint(x: 0.3707943556197897d, y: 0.02028832367559119d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5106774858712994d, y: 0.9462597058456758d), new NpgsqlTypes.NpgsqlPoint(x: 0.8809808777390566d, y: 0.6838945006079078d), new NpgsqlTypes.NpgsqlPoint(x: 0.31140526895131804d, y: 0.07946059842649733d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7648072359975056d, y: 0.19162104231640031d), new NpgsqlTypes.NpgsqlPoint(x: 0.7844319362413535d, y: 0.7131313566316023d), new NpgsqlTypes.NpgsqlPoint(x: 0.759107479658994d, y: 0.14301742788835115d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24217242617891688d, y: 0.7942571332688639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533461610673463d, y: 0.11557211877104434d), new NpgsqlTypes.NpgsqlPoint(x: 0.14923822173163415d, y: 0.498993247589262d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5496320390287557d, y: 0.717073405876194d), new NpgsqlTypes.NpgsqlPoint(x: 0.86048911586225d, y: 0.7017430969750477d), new NpgsqlTypes.NpgsqlPoint(x: 0.41777525774028734d, y: 0.5050849707721242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09225693601141083d, y: 0.9344710589566324d), new NpgsqlTypes.NpgsqlPoint(x: 0.520762279587015d, y: 0.6125885274577881d), new NpgsqlTypes.NpgsqlPoint(x: 0.48089455246908963d, y: 0.6451394192481501d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05449194437612104d, y: 0.44335292490553146d), new NpgsqlTypes.NpgsqlPoint(x: 0.9567848171762354d, y: 0.44964646440892253d), new NpgsqlTypes.NpgsqlPoint(x: 0.03939785425399989d, y: 0.25084351954608286d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13767569255267642d, y: 0.6440288740944177d), new NpgsqlTypes.NpgsqlPoint(x: 0.6045093958649557d, y: 0.36540020486585123d), new NpgsqlTypes.NpgsqlPoint(x: 0.40192888951270533d, y: 0.17794685610273586d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9121368696902244d, y: 0.4674230480168383d), new NpgsqlTypes.NpgsqlPoint(x: 0.749347122078655d, y: 0.6281782690273315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8856126232055779d, y: 0.45136729767936157d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.619023888345341d, y: 0.9629015400036838d), new NpgsqlTypes.NpgsqlPoint(x: 0.13426195303031563d, y: 0.7656904469415464d), new NpgsqlTypes.NpgsqlPoint(x: 0.44246238734047094d, y: 0.9646205107157116d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13489750160171066d, y: 0.8641400271318072d), new NpgsqlTypes.NpgsqlPoint(x: 0.1971623745109402d, y: 0.23624153634325773d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996298365028531d, y: 0.31239914022032134d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7308669960136791d, y: 0.2654914877345853d), new NpgsqlTypes.NpgsqlPoint(x: 0.2654252852240503d, y: 0.23204933483238643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5619113996349949d, y: 0.6872783604364137d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7031333808495894d, y: 0.6639926130891592d), new NpgsqlTypes.NpgsqlPoint(x: 0.05465235623512721d, y: 0.38608859935027096d), new NpgsqlTypes.NpgsqlPoint(x: 0.44407459745629796d, y: 0.2690143392128639d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6856387334844246d, y: 0.6868028982260594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4677482770383642d, y: 0.8369582108846594d), new NpgsqlTypes.NpgsqlPoint(x: 0.4051822312543708d, y: 0.6778531062649944d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38675773357659715d, y: 0.21009588856224504d), new NpgsqlTypes.NpgsqlPoint(x: 0.6524003691196347d, y: 0.527673900632444d), new NpgsqlTypes.NpgsqlPoint(x: 0.20780803579055473d, y: 0.8682692482877536d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46006029118225444d, y: 0.23286534168412376d), new NpgsqlTypes.NpgsqlPoint(x: 0.7216808233120334d, y: 0.3947538913753287d), new NpgsqlTypes.NpgsqlPoint(x: 0.17521110151739017d, y: 0.036434157969895575d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.023228108248510515d, y: 0.9876302371188708d), new NpgsqlTypes.NpgsqlPoint(x: 0.9884128786015545d, y: 0.8382503863654649d), new NpgsqlTypes.NpgsqlPoint(x: 0.7274636973335834d, y: 0.42796268438133056d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21540089939760243d, y: 0.8956861591201295d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637228866128346d, y: 0.7012577521010883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759495971996243d, y: 0.4023244391639519d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7166092347966215d, y: 0.18460815521556106d), new NpgsqlTypes.NpgsqlPoint(x: 0.4292941054705326d, y: 0.24354007240480635d), new NpgsqlTypes.NpgsqlPoint(x: 0.3362768262333007d, y: 0.7515618546121758d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2685958860138147d, y: 0.3318937145242963d), new NpgsqlTypes.NpgsqlPoint(x: 0.14352160159474614d, y: 0.5847541522416994d), new NpgsqlTypes.NpgsqlPoint(x: 0.7672741212555769d, y: 0.029186357574596755d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.986931736402641d, y: 0.3455520298601361d), new NpgsqlTypes.NpgsqlPoint(x: 0.9129931805306761d, y: 0.5108403924360706d), new NpgsqlTypes.NpgsqlPoint(x: 0.43460132563028775d, y: 0.081519981613274d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36430241385986295d, y: 0.267915082668971d), new NpgsqlTypes.NpgsqlPoint(x: 0.27032089502576906d, y: 0.09177401784580819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5924348346261317d, y: 0.45957512589332716d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017661450732972317d, y: 0.28126842668386454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6444341255515833d, y: 0.9379765297064087d), new NpgsqlTypes.NpgsqlPoint(x: 0.9201028262994728d, y: 0.5414165559299332d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6714792665983202d, y: 0.6616923441679355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9341605200913469d, y: 0.6744197651823085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9538950798715252d, y: 0.2167735894990659d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5225578559580962d, y: 0.8450802461408451d), new NpgsqlTypes.NpgsqlPoint(x: 0.14095534118401054d, y: 0.03210858705432984d), new NpgsqlTypes.NpgsqlPoint(x: 0.37049761728522546d, y: 0.8924765575026634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4860963531646928d, y: 0.1640558808758109d), new NpgsqlTypes.NpgsqlPoint(x: 0.9291612117642357d, y: 0.6573253208234048d), new NpgsqlTypes.NpgsqlPoint(x: 0.9262982941866864d, y: 0.39312654116269297d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00965007190513989d, y: 0.9345257417878096d), new NpgsqlTypes.NpgsqlPoint(x: 0.3000948220196643d, y: 0.1968791716850261d), new NpgsqlTypes.NpgsqlPoint(x: 0.05160322765140901d, y: 0.68190531128974d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16578806225937148d, y: 0.8466774645245755d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085629747841172d, y: 0.8445451958752491d), new NpgsqlTypes.NpgsqlPoint(x: 0.8964478669736711d, y: 0.5590283752128246d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29920781449669676d, y: 0.6710446604851441d), new NpgsqlTypes.NpgsqlPoint(x: 0.683152368730095d, y: 0.4521823475321912d), new NpgsqlTypes.NpgsqlPoint(x: 0.06921620955044783d, y: 0.649709030349434d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7506679133641289d, y: 0.8344654128668658d), new NpgsqlTypes.NpgsqlPoint(x: 0.6002846463953082d, y: 0.6272605668925378d), new NpgsqlTypes.NpgsqlPoint(x: 0.32096171809471197d, y: 0.12143642519401143d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9799796293952117d, y: 0.43096890839395874d), new NpgsqlTypes.NpgsqlPoint(x: 0.4269363164273082d, y: 0.6101638620873945d), new NpgsqlTypes.NpgsqlPoint(x: 0.20478753619725398d, y: 0.6763084042736456d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3507467444710308d, y: 0.675852112254769d), new NpgsqlTypes.NpgsqlPoint(x: 0.777723363343565d, y: 0.9909328761609724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3805052691430313d, y: 0.8816307050131936d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8591378991487383d, y: 0.9608512944171026d), new NpgsqlTypes.NpgsqlPoint(x: 0.08683672708428547d, y: 0.750642496430148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8949325994163795d, y: 0.1619439475169856d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7465789867992864d, y: 0.52807882983117d), new NpgsqlTypes.NpgsqlPoint(x: 0.8197864117087965d, y: 0.780550918237166d), new NpgsqlTypes.NpgsqlPoint(x: 0.8391174081527549d, y: 0.5678005744987045d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5996106400215964d, y: 0.2299720583877206d), new NpgsqlTypes.NpgsqlPoint(x: 0.21270972162480073d, y: 0.5634180706175181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537469256512934d, y: 0.9814879493770055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26637502272508984d, y: 0.7973474429931736d), new NpgsqlTypes.NpgsqlPoint(x: 0.015371771521027311d, y: 0.08634873646312213d), new NpgsqlTypes.NpgsqlPoint(x: 0.6906211440583755d, y: 0.537508438051305d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3628136703500837d, y: 0.9566619203082818d), new NpgsqlTypes.NpgsqlPoint(x: 0.018763298163598896d, y: 0.9647475115416421d), new NpgsqlTypes.NpgsqlPoint(x: 0.6055088396357483d, y: 0.3866088396379641d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6138841273997564d, y: 0.34173158033852546d), new NpgsqlTypes.NpgsqlPoint(x: 0.632495296621063d, y: 0.18086083954884558d), new NpgsqlTypes.NpgsqlPoint(x: 0.3178105229125663d, y: 0.7937848816201425d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41149985154212354d, y: 0.4849706429296945d), new NpgsqlTypes.NpgsqlPoint(x: 0.42257618588122126d, y: 0.9842212870464301d), new NpgsqlTypes.NpgsqlPoint(x: 0.5346382123189131d, y: 0.12136211073377756d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3050206344727504d, y: 0.6217894287179081d), new NpgsqlTypes.NpgsqlPoint(x: 0.017853438113938247d, y: 0.051218036561378355d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508815884851514d, y: 0.42590489560744105d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2104858306552615d, y: 0.708364421915244d), new NpgsqlTypes.NpgsqlPoint(x: 0.48945421245977283d, y: 0.3991901511381314d), new NpgsqlTypes.NpgsqlPoint(x: 0.10422672255948728d, y: 0.0919897239680535d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7330699547117346d, y: 0.9055093613789444d), new NpgsqlTypes.NpgsqlPoint(x: 0.034317245434258625d, y: 0.9421205689300556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9678708048759358d, y: 0.9632638823555495d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4647068658594903d, y: 0.21590495212928085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3858733705894646d, y: 0.8624294591891072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5872823552007663d, y: 0.6874859605924314d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7241723726696572d, y: 0.02829903272768386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5695245233871861d, y: 0.11006124979155707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4485390804644138d, y: 0.294024284825808d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.043986807436203534d, y: 0.28439360995854923d), new NpgsqlTypes.NpgsqlPoint(x: 0.17665121736280875d, y: 0.8884769436243314d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735549050335765d, y: 0.8015815535949062d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7320937393112387d, y: 0.48074066822827877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708431382846378d, y: 0.45623651381143304d), new NpgsqlTypes.NpgsqlPoint(x: 0.17559965366357255d, y: 0.21009906730661942d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9834487459174309d, y: 0.16404039229225242d), new NpgsqlTypes.NpgsqlPoint(x: 0.94831959850516d, y: 0.06521584737076536d), new NpgsqlTypes.NpgsqlPoint(x: 0.24080893873514497d, y: 0.9445485103353961d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4352801073731226d, y: 0.19781485639169372d), new NpgsqlTypes.NpgsqlPoint(x: 0.9927349460466359d, y: 0.4257536705679875d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172191071089112d, y: 0.8821074571006889d)), }, }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.669532880777034d, y: 0.8864925092281797d), new NpgsqlTypes.NpgsqlPoint(x: 0.837953727820688d, y: 0.9418006854787653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5835178305428366d, y: 0.4276326550416055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.589544017659606d, y: 0.15256336597046416d), new NpgsqlTypes.NpgsqlPoint(x: 0.5477922058961885d, y: 0.6532863235357518d), new NpgsqlTypes.NpgsqlPoint(x: 0.733113381092835d, y: 0.983587901643002d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05840719759738522d, y: 0.529738032772732d), new NpgsqlTypes.NpgsqlPoint(x: 0.40916400886125714d, y: 0.799271392857457d), new NpgsqlTypes.NpgsqlPoint(x: 0.4073563959347781d, y: 0.8505754562641114d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8026025076480612d, y: 0.7329104801523088d), new NpgsqlTypes.NpgsqlPoint(x: 0.03714281723095403d, y: 0.8732383417631845d), new NpgsqlTypes.NpgsqlPoint(x: 0.945300094614156d, y: 0.2776236928292046d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2972365710387228d, y: 0.828293496612785d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686778188293673d, y: 0.091073673593275d), new NpgsqlTypes.NpgsqlPoint(x: 0.5340984053375566d, y: 0.3538356467924175d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3967946046985892d, y: 0.42279854022726837d), new NpgsqlTypes.NpgsqlPoint(x: 0.14968562493027948d, y: 0.02867058137211964d), new NpgsqlTypes.NpgsqlPoint(x: 0.2958785615522532d, y: 0.372809443590265d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7969222290932471d, y: 0.1499716907547639d), new NpgsqlTypes.NpgsqlPoint(x: 0.5607496513851117d, y: 0.3837690825546338d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916716136707307d, y: 0.8739815266591158d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15668488394944458d, y: 0.4779297724110326d), new NpgsqlTypes.NpgsqlPoint(x: 0.6110100026698454d, y: 0.858491154997545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7199316715188943d, y: 0.7718067869128259d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6893559368669344d, y: 0.9531648222934553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5801550587741654d, y: 0.11338972015863902d), new NpgsqlTypes.NpgsqlPoint(x: 0.7121589459214595d, y: 0.9148741445209947d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18739022104390912d, y: 0.589856363308652d), new NpgsqlTypes.NpgsqlPoint(x: 0.11332917748329718d, y: 0.020862696254418722d), new NpgsqlTypes.NpgsqlPoint(x: 0.1101762763124533d, y: 0.5402462581689293d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16038887104906174d, y: 0.46126675707482734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9541261475178451d, y: 0.20091725978944908d), new NpgsqlTypes.NpgsqlPoint(x: 0.29707469506506823d, y: 0.7815838516842865d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05113519673031608d, y: 0.5967967591894054d), new NpgsqlTypes.NpgsqlPoint(x: 0.010396444110100544d, y: 0.9118095521126812d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114823172072837d, y: 0.08218402997968244d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25937846594046754d, y: 0.17050517698966017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506430420361266d, y: 0.5829399006836419d), new NpgsqlTypes.NpgsqlPoint(x: 0.3458223002147588d, y: 0.2530207759448766d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.692884859436764d, y: 0.9984315222413706d), new NpgsqlTypes.NpgsqlPoint(x: 0.7223917035592765d, y: 0.46432727495487613d), new NpgsqlTypes.NpgsqlPoint(x: 0.401740509183494d, y: 0.07436261855676929d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35841283435200555d, y: 0.3887774370137027d), new NpgsqlTypes.NpgsqlPoint(x: 0.676795785272714d, y: 0.12592418116289428d), new NpgsqlTypes.NpgsqlPoint(x: 0.635143923451426d, y: 0.4304350335146463d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4816094631111898d, y: 0.7556916564675166d), new NpgsqlTypes.NpgsqlPoint(x: 0.36848062863292075d, y: 0.4639857769875929d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728056304688114d, y: 0.28040557274937883d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05566790529444554d, y: 0.8451737323541475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6587615653512869d, y: 0.3829090738026898d), new NpgsqlTypes.NpgsqlPoint(x: 0.7492824859324948d, y: 0.29467996942016517d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42633649894642645d, y: 0.7453154099331327d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747739409260703d, y: 0.02665008382125711d), new NpgsqlTypes.NpgsqlPoint(x: 0.6264793098949708d, y: 0.330966026433854d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9668980297272337d, y: 0.7046509727722632d), new NpgsqlTypes.NpgsqlPoint(x: 0.711186854634686d, y: 0.8826897567905782d), new NpgsqlTypes.NpgsqlPoint(x: 0.36630198992186136d, y: 0.9739861909715277d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6985443524827095d, y: 0.2087864237956114d), new NpgsqlTypes.NpgsqlPoint(x: 0.7891958683951953d, y: 0.7146310333784345d), new NpgsqlTypes.NpgsqlPoint(x: 0.6052203244682388d, y: 0.6815950761585311d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8624010272980546d, y: 0.5479804310465801d), new NpgsqlTypes.NpgsqlPoint(x: 0.8999217273291937d, y: 0.8740748461988311d), new NpgsqlTypes.NpgsqlPoint(x: 0.7301270004222652d, y: 0.855012355855716d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7545412203295153d, y: 0.9590583018591766d), new NpgsqlTypes.NpgsqlPoint(x: 0.11465009098117185d, y: 0.6082219148256182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7612099718318112d, y: 0.4599292611187361d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.004820050514223295d, y: 0.6872035177194722d), new NpgsqlTypes.NpgsqlPoint(x: 0.3792932409510277d, y: 0.7292231153283064d), new NpgsqlTypes.NpgsqlPoint(x: 0.5450646444444481d, y: 0.12264594158803344d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6392532250300709d, y: 0.4539863477441042d), new NpgsqlTypes.NpgsqlPoint(x: 0.7643091458868808d, y: 0.07904135663574308d), new NpgsqlTypes.NpgsqlPoint(x: 0.3782273130920384d, y: 0.2009871007824543d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03211243693070587d, y: 0.4745083439107344d), new NpgsqlTypes.NpgsqlPoint(x: 0.075228752265593d, y: 0.021559951832671898d), new NpgsqlTypes.NpgsqlPoint(x: 0.17886896467777302d, y: 0.10927602451081098d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5572848873533304d, y: 0.18052222658099937d), new NpgsqlTypes.NpgsqlPoint(x: 0.278108533444962d, y: 0.23143775815094325d), new NpgsqlTypes.NpgsqlPoint(x: 0.2571039888437613d, y: 0.3619371995514351d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6131014817525925d, y: 0.1570985184877528d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111373495821692d, y: 0.050140475641789806d), new NpgsqlTypes.NpgsqlPoint(x: 0.3215782186150594d, y: 0.6294471173801927d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 125,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4859465773577195d, y: 0.3912388421431562d), new NpgsqlTypes.NpgsqlPoint(x: 0.1250200573917023d, y: 0.04178532235599208d), new NpgsqlTypes.NpgsqlPoint(x: 0.6085850431455637d, y: 0.8402440578952052d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10675072922914774d, y: 0.2770980015895096d), new NpgsqlTypes.NpgsqlPoint(x: 0.23812997585561269d, y: 0.8968258358340223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9044943671118945d, y: 0.25299022527707127d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5967847502748944d, y: 0.0875571350449903d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238696977867747d, y: 0.31465426242965866d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337562872341209d, y: 0.044200404706004726d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9522721884601748d, y: 0.3095769376947495d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639820310297305d, y: 0.42680753814278305d), new NpgsqlTypes.NpgsqlPoint(x: 0.1171836733971705d, y: 0.4751292391172225d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4552505823494506d, y: 0.7991111509111238d), new NpgsqlTypes.NpgsqlPoint(x: 0.2184832610466082d, y: 0.5268175682984825d), new NpgsqlTypes.NpgsqlPoint(x: 0.4726834274260737d, y: 0.1456851437649218d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7989497039395989d, y: 0.8580285366662147d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307192421531059d, y: 0.16093398560813d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379193547081011d, y: 0.9691787787204672d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3873187178323365d, y: 0.9365088895060018d), new NpgsqlTypes.NpgsqlPoint(x: 0.27347649899093673d, y: 0.4900754552754756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6086616132691526d, y: 0.11478967823686392d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7314469143921213d, y: 0.7672096461945953d), new NpgsqlTypes.NpgsqlPoint(x: 0.30622834983509206d, y: 0.6631869834308713d), new NpgsqlTypes.NpgsqlPoint(x: 0.6386191726997916d, y: 0.9395857853486597d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17711442400709432d, y: 0.08145862224054923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20848326747043844d, y: 0.931370160224412d), new NpgsqlTypes.NpgsqlPoint(x: 0.3736907419012513d, y: 0.8242721451368592d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3532873637585646d, y: 0.7734051567923205d), new NpgsqlTypes.NpgsqlPoint(x: 0.1664063908299609d, y: 0.7547015804025496d), new NpgsqlTypes.NpgsqlPoint(x: 0.327768017595771d, y: 0.35285125774451653d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2693628018139431d, y: 0.484455517379084d), new NpgsqlTypes.NpgsqlPoint(x: 0.01156584397518412d, y: 0.5506537149456836d), new NpgsqlTypes.NpgsqlPoint(x: 0.661631379063761d, y: 0.9125051792248933d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34285204308436634d, y: 0.005919653509206979d), new NpgsqlTypes.NpgsqlPoint(x: 0.3454899549313333d, y: 0.10737952911727222d), new NpgsqlTypes.NpgsqlPoint(x: 0.335216193675242d, y: 0.3231468446441077d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.903650878729846d, y: 0.31989791297500436d), new NpgsqlTypes.NpgsqlPoint(x: 0.9334129009629376d, y: 0.3320255400179939d), new NpgsqlTypes.NpgsqlPoint(x: 0.8055172960611834d, y: 0.009061417476681877d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7729544971747276d, y: 0.2712146524386454d), new NpgsqlTypes.NpgsqlPoint(x: 0.16637694731875752d, y: 0.5524159340410584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9268973408427722d, y: 0.2389403798738684d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3545159537166809d, y: 0.04657369429865843d), new NpgsqlTypes.NpgsqlPoint(x: 0.5002065549329762d, y: 0.8278484669407458d), new NpgsqlTypes.NpgsqlPoint(x: 0.4798273030251671d, y: 0.755699980654506d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8476067421987038d, y: 0.5583239514043555d), new NpgsqlTypes.NpgsqlPoint(x: 0.5815928788356055d, y: 0.3926466414882779d), new NpgsqlTypes.NpgsqlPoint(x: 0.02187789119714656d, y: 0.5093998701223371d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3413091568605715d, y: 0.20556006701053953d), new NpgsqlTypes.NpgsqlPoint(x: 0.18890899499842972d, y: 0.36398122371572184d), new NpgsqlTypes.NpgsqlPoint(x: 0.4054010876415868d, y: 0.8486021063669918d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37356311715991297d, y: 0.18176544180098253d), new NpgsqlTypes.NpgsqlPoint(x: 0.940521418089693d, y: 0.004346492555696524d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882888826833113d, y: 0.6914478540966545d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14780101566667658d, y: 0.0023094148345437215d), new NpgsqlTypes.NpgsqlPoint(x: 0.9998921033758614d, y: 0.22381180388849986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6073237776323768d, y: 0.8986945093981081d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3462010598556877d, y: 0.1796014563755275d), new NpgsqlTypes.NpgsqlPoint(x: 0.23158957520487944d, y: 0.9896000793889169d), new NpgsqlTypes.NpgsqlPoint(x: 0.3530729906630711d, y: 0.8953727490742571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3752326352263299d, y: 0.9669627448536178d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457213305551575d, y: 0.5507202905069555d), new NpgsqlTypes.NpgsqlPoint(x: 0.0675436638509942d, y: 0.0633719691422705d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6168779941187774d, y: 0.9002600532806173d), new NpgsqlTypes.NpgsqlPoint(x: 0.6484581819337918d, y: 0.40771155697907757d), new NpgsqlTypes.NpgsqlPoint(x: 0.41047033855565895d, y: 0.02312208118538439d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6345114251037319d, y: 0.05986000226591848d), new NpgsqlTypes.NpgsqlPoint(x: 0.6836596765932712d, y: 0.11801501996443409d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394239117845717d, y: 0.8287147733790183d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8904487298263155d, y: 0.01956519216290864d), new NpgsqlTypes.NpgsqlPoint(x: 0.34914375259918196d, y: 0.2610036760898974d), new NpgsqlTypes.NpgsqlPoint(x: 0.43093053974122675d, y: 0.7006112310003363d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3010528669165847d, y: 0.06412155241943152d), new NpgsqlTypes.NpgsqlPoint(x: 0.6560285992140036d, y: 0.6331996696064576d), new NpgsqlTypes.NpgsqlPoint(x: 0.832955939119022d, y: 0.2785335559791787d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2555139861895728d, y: 0.5113201483460474d), new NpgsqlTypes.NpgsqlPoint(x: 0.1907535480905338d, y: 0.8100101906418586d), new NpgsqlTypes.NpgsqlPoint(x: 0.495826196100115d, y: 0.050166165211816716d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7957024759766913d, y: 0.9611332784389167d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620339956632631d, y: 0.4285036619483136d), new NpgsqlTypes.NpgsqlPoint(x: 0.20208813575690754d, y: 0.9642102656621984d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14797196207070562d, y: 0.6093180095864988d), new NpgsqlTypes.NpgsqlPoint(x: 0.04472268003336566d, y: 0.8129816422651895d), new NpgsqlTypes.NpgsqlPoint(x: 0.9424570917472133d, y: 0.9600522769108176d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6124155556219387d, y: 0.9919764420714106d), new NpgsqlTypes.NpgsqlPoint(x: 0.21876634090327174d, y: 0.7883851420814157d), new NpgsqlTypes.NpgsqlPoint(x: 0.29013800443865434d, y: 0.41080477574286556d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24752608832928846d, y: 0.32958825352609733d), new NpgsqlTypes.NpgsqlPoint(x: 0.15123794880116326d, y: 0.5555556266534277d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183432243711823d, y: 0.045265008515337546d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49958538387505336d, y: 0.43205122112252026d), new NpgsqlTypes.NpgsqlPoint(x: 0.626513355223525d, y: 0.928889111397371d), new NpgsqlTypes.NpgsqlPoint(x: 0.07146594695158726d, y: 0.86523295511018d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9862785862264768d, y: 0.7397858586709062d), new NpgsqlTypes.NpgsqlPoint(x: 0.04698608503712154d, y: 0.6312715904327788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7710628208688687d, y: 0.2738202802168982d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2908926725109521d, y: 0.35986694789931684d), new NpgsqlTypes.NpgsqlPoint(x: 0.9447591713704387d, y: 0.026667045846692772d), new NpgsqlTypes.NpgsqlPoint(x: 0.37244451307903437d, y: 0.08951744383245741d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18711238871479674d, y: 0.5342085918507592d), new NpgsqlTypes.NpgsqlPoint(x: 0.36973632302867787d, y: 0.6886929485490496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9503930479218899d, y: 0.924768521553002d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6212383760269059d, y: 0.5483939791248573d), new NpgsqlTypes.NpgsqlPoint(x: 0.3403248932783486d, y: 0.18794165257009765d), new NpgsqlTypes.NpgsqlPoint(x: 0.9203382507526784d, y: 0.5797738041047984d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08205144346080995d, y: 0.6140786643700822d), new NpgsqlTypes.NpgsqlPoint(x: 0.872112065346167d, y: 0.7579147424967029d), new NpgsqlTypes.NpgsqlPoint(x: 0.6302762547376578d, y: 0.4166082051101394d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3501256799409769d, y: 0.4832889312517157d), new NpgsqlTypes.NpgsqlPoint(x: 0.8975429295537051d, y: 0.37735919104540483d), new NpgsqlTypes.NpgsqlPoint(x: 0.41982004483142266d, y: 0.7858926933703917d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5294217224509761d, y: 0.6800753715137254d), new NpgsqlTypes.NpgsqlPoint(x: 0.928052247684599d, y: 0.07911930449502613d), new NpgsqlTypes.NpgsqlPoint(x: 0.03690054336069226d, y: 0.00859973414985471d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.020652953781326366d, y: 0.09007748117120407d), new NpgsqlTypes.NpgsqlPoint(x: 0.0166267196596267d, y: 0.0735881957497293d), new NpgsqlTypes.NpgsqlPoint(x: 0.6290341004939574d, y: 0.8977460193482732d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07888794328146165d, y: 0.0745588854855711d), new NpgsqlTypes.NpgsqlPoint(x: 0.28813448067645986d, y: 0.44763436337185425d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428394162021048d, y: 0.9116627168509627d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143485894299004d, y: 0.9597853772167303d), new NpgsqlTypes.NpgsqlPoint(x: 0.39699692100098816d, y: 0.08764002473724175d), new NpgsqlTypes.NpgsqlPoint(x: 0.643963271759896d, y: 0.4995538408217569d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054488542703091336d, y: 0.4719224729421392d), new NpgsqlTypes.NpgsqlPoint(x: 0.11929933662955894d, y: 0.32153981964524847d), new NpgsqlTypes.NpgsqlPoint(x: 0.027973032137892817d, y: 0.07337074293132784d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3376263412937073d, y: 0.7773145658732193d), new NpgsqlTypes.NpgsqlPoint(x: 0.12449868384584795d, y: 0.2458517586550526d), new NpgsqlTypes.NpgsqlPoint(x: 0.05701772088324575d, y: 0.15224342352975306d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7952310926086881d, y: 0.3784367330780738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6005491076736403d, y: 0.23164000687971842d), new NpgsqlTypes.NpgsqlPoint(x: 0.24177440235270065d, y: 0.8387292318911034d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6019268586421628d, y: 0.1506490719793876d), new NpgsqlTypes.NpgsqlPoint(x: 0.3344451120433105d, y: 0.5471738585366162d), new NpgsqlTypes.NpgsqlPoint(x: 0.5762049628590007d, y: 0.5352694100696216d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47803795128175997d, y: 0.6990353615898038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9279303014905693d, y: 0.752068736424478d), new NpgsqlTypes.NpgsqlPoint(x: 0.45888793254387383d, y: 0.6136268798151212d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.631036885507709d, y: 0.7602013449988017d), new NpgsqlTypes.NpgsqlPoint(x: 0.3304975493012656d, y: 0.8375215875087816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827060068355928d, y: 0.9598958967444978d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11325884251227925d, y: 0.014647807064811613d), new NpgsqlTypes.NpgsqlPoint(x: 0.48481843981831063d, y: 0.468951436255457d), new NpgsqlTypes.NpgsqlPoint(x: 0.6000516754045826d, y: 0.8625985012364543d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37702980393325713d, y: 0.9171988456244169d), new NpgsqlTypes.NpgsqlPoint(x: 0.9184471144658973d, y: 0.7136975464243689d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392095953111353d, y: 0.58411179700245d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3860060995682508d, y: 0.4980775922641658d), new NpgsqlTypes.NpgsqlPoint(x: 0.9393984359663485d, y: 0.7510083337001452d), new NpgsqlTypes.NpgsqlPoint(x: 0.9836769101695367d, y: 0.5985939080816375d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6453515297733967d, y: 0.8327525496449665d), new NpgsqlTypes.NpgsqlPoint(x: 0.203787292244633d, y: 0.28461977887505696d), new NpgsqlTypes.NpgsqlPoint(x: 0.011879696738406276d, y: 0.9644583579623986d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0547591720518642d, y: 0.4338017081272336d), new NpgsqlTypes.NpgsqlPoint(x: 0.31794158792236604d, y: 0.1652684159025849d), new NpgsqlTypes.NpgsqlPoint(x: 0.3243294128772535d, y: 0.2373663854173782d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9426812442517192d, y: 0.8032363290150061d), new NpgsqlTypes.NpgsqlPoint(x: 0.6118252094661376d, y: 0.49394717184178816d), new NpgsqlTypes.NpgsqlPoint(x: 0.49701355719612605d, y: 0.7425932260721415d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6682763836159454d, y: 0.2653650146488862d), new NpgsqlTypes.NpgsqlPoint(x: 0.6136465367884033d, y: 0.11956804414028532d), new NpgsqlTypes.NpgsqlPoint(x: 0.27323174394092953d, y: 0.03693046390568244d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7684431945863832d, y: 0.04502534854695028d), new NpgsqlTypes.NpgsqlPoint(x: 0.0665334991090788d, y: 0.726849496239489d), new NpgsqlTypes.NpgsqlPoint(x: 0.6050726824462255d, y: 0.7356878628376253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7650162224319226d, y: 0.09882664740142488d), new NpgsqlTypes.NpgsqlPoint(x: 0.2878308324050076d, y: 0.08227030855890505d), new NpgsqlTypes.NpgsqlPoint(x: 0.8304374766229787d, y: 0.2705322668755644d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8847569652158942d, y: 0.9656307659960105d), new NpgsqlTypes.NpgsqlPoint(x: 0.4279894510798722d, y: 0.8010305072127687d), new NpgsqlTypes.NpgsqlPoint(x: 0.12794110128412162d, y: 0.3384202499253287d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17118328685347983d, y: 0.9295264222501775d), new NpgsqlTypes.NpgsqlPoint(x: 0.7530644851422316d, y: 0.6511055062110719d), new NpgsqlTypes.NpgsqlPoint(x: 0.31925955265156325d, y: 0.4743138831051862d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.335192139753818d, y: 0.5599295578671254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5880644056521726d, y: 0.21439347031889522d), new NpgsqlTypes.NpgsqlPoint(x: 0.054306758005839395d, y: 0.9355949341131446d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5385334748688594d, y: 0.8459126740860163d), new NpgsqlTypes.NpgsqlPoint(x: 0.04258246970691881d, y: 0.1625180599225906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9640315591545691d, y: 0.5920038386426753d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17105079491070863d, y: 0.894263862447595d), new NpgsqlTypes.NpgsqlPoint(x: 0.0011142025961077273d, y: 0.6702744303151157d), new NpgsqlTypes.NpgsqlPoint(x: 0.9166944542595169d, y: 0.2554123504299771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5162878071811214d, y: 0.287791402957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2806020385578297d, y: 0.0841763752870125d), new NpgsqlTypes.NpgsqlPoint(x: 0.23597678354725737d, y: 0.7745318842028748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5962061349236305d, y: 0.09364890453956698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6543134371502051d, y: 0.37903244937648417d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135368236353459d, y: 0.20434485826496307d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6406767267892632d, y: 0.09553765378148671d), new NpgsqlTypes.NpgsqlPoint(x: 0.010508302874027042d, y: 0.5380945846839833d), new NpgsqlTypes.NpgsqlPoint(x: 0.2442090160037057d, y: 0.22837290251453235d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3062575147545319d, y: 0.4099502775078242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9420751251515227d, y: 0.6612800614181095d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486773192871141d, y: 0.6504988389667851d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43976225968545446d, y: 0.8043039676127235d), new NpgsqlTypes.NpgsqlPoint(x: 0.5363795835872575d, y: 0.5109511721816579d), new NpgsqlTypes.NpgsqlPoint(x: 0.11311783082867011d, y: 0.6265704099615083d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5988506811131261d, y: 0.529267861454043d), new NpgsqlTypes.NpgsqlPoint(x: 0.0642189751089779d, y: 0.5925846638744094d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139679070698453d, y: 0.6793399512289443d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17084289179972645d, y: 0.640238416989343d), new NpgsqlTypes.NpgsqlPoint(x: 0.8460957155853941d, y: 0.6567738319050618d), new NpgsqlTypes.NpgsqlPoint(x: 0.5080026157408187d, y: 0.13479976817146877d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.597826555935264d, y: 0.9189405710001234d), new NpgsqlTypes.NpgsqlPoint(x: 0.7241825840590651d, y: 0.4737160064636958d), new NpgsqlTypes.NpgsqlPoint(x: 0.7081932956495165d, y: 0.1832665142667027d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16402417612507858d, y: 0.1380422001346524d), new NpgsqlTypes.NpgsqlPoint(x: 0.6129286101666382d, y: 0.11758540364387626d), new NpgsqlTypes.NpgsqlPoint(x: 0.7298616307314798d, y: 0.25093334757117536d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.640476293503039d, y: 0.2588818276497087d), new NpgsqlTypes.NpgsqlPoint(x: 0.7934511850398733d, y: 0.43809001061780517d), new NpgsqlTypes.NpgsqlPoint(x: 0.118217012822595d, y: 0.09429056756580168d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9615849326897435d, y: 0.9978660960240906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7999920557501843d, y: 0.3919482283164538d), new NpgsqlTypes.NpgsqlPoint(x: 0.06765800142014866d, y: 0.1408155924461404d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.749607617649355d, y: 0.7780951430144708d), new NpgsqlTypes.NpgsqlPoint(x: 0.946512368819509d, y: 0.4125944925170032d), new NpgsqlTypes.NpgsqlPoint(x: 0.12258833053889773d, y: 0.4372112290982141d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3175279302734636d, y: 0.05784426970239587d), new NpgsqlTypes.NpgsqlPoint(x: 0.8217856290025752d, y: 0.7540441612777732d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976920026296929d, y: 0.5931030927197724d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3506562619527267d, y: 0.519696172895071d), new NpgsqlTypes.NpgsqlPoint(x: 0.002625821000759032d, y: 0.4579556343889777d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486744275075204d, y: 0.834567731343532d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3717021456150418d, y: 0.8683721815898124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8503599764898937d, y: 0.3095647512116535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8449474500354212d, y: 0.08808356466546863d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5440283908861026d, y: 0.16312051716651688d), new NpgsqlTypes.NpgsqlPoint(x: 0.6895685108697297d, y: 0.2439075592994313d), new NpgsqlTypes.NpgsqlPoint(x: 0.9849616157315503d, y: 0.10044073389958486d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6320684511082303d, y: 0.8490387424633865d), new NpgsqlTypes.NpgsqlPoint(x: 0.657212231717978d, y: 0.05576180761708949d), new NpgsqlTypes.NpgsqlPoint(x: 0.962949070646807d, y: 0.460324573444704d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9193552139694197d, y: 0.7993631904376717d), new NpgsqlTypes.NpgsqlPoint(x: 0.8486915948002893d, y: 0.06305903505151733d), new NpgsqlTypes.NpgsqlPoint(x: 0.6813175157659259d, y: 0.6671385897777353d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0765292425008155d, y: 0.37496744229928924d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649262298317579d, y: 0.138624394077696d), new NpgsqlTypes.NpgsqlPoint(x: 0.32747173991645295d, y: 0.5615506253637129d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5426074367918345d, y: 0.5803939674468702d), new NpgsqlTypes.NpgsqlPoint(x: 0.13660463883714968d, y: 0.7137299531775d), new NpgsqlTypes.NpgsqlPoint(x: 0.769972787484368d, y: 0.14656483567538792d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 126,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2622984773453654d, y: 0.6441223156822466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6785699022698292d, y: 0.2066185950972892d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293919085794449d, y: 0.43484591793824734d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21420644422990376d, y: 0.8815728421746557d), new NpgsqlTypes.NpgsqlPoint(x: 0.539423800273334d, y: 0.701260909617853d), new NpgsqlTypes.NpgsqlPoint(x: 0.1772175687368902d, y: 0.7273345219187244d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7205311761560784d, y: 0.9647062055119723d), new NpgsqlTypes.NpgsqlPoint(x: 0.713325308721537d, y: 0.8103724501037493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6257520515471707d, y: 0.3467826308168216d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8473376286069702d, y: 0.3276294907389369d), new NpgsqlTypes.NpgsqlPoint(x: 0.9238099501430221d, y: 0.10477778971882279d), new NpgsqlTypes.NpgsqlPoint(x: 0.4990381297144817d, y: 0.1487586950792581d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5932853732798277d, y: 0.5880619763020132d), new NpgsqlTypes.NpgsqlPoint(x: 0.5850642847255957d, y: 0.5183290960805444d), new NpgsqlTypes.NpgsqlPoint(x: 0.04571455678014236d, y: 0.09716732768137948d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726526707814961d, y: 0.7281526128694996d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019790214039694d, y: 0.2960760054054713d), new NpgsqlTypes.NpgsqlPoint(x: 0.29740136837877174d, y: 0.9189141630667407d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12997141734735174d, y: 0.12049794398714275d), new NpgsqlTypes.NpgsqlPoint(x: 0.6632173406603717d, y: 0.3578299366711044d), new NpgsqlTypes.NpgsqlPoint(x: 0.06619057335351375d, y: 0.19223553981692443d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7147844993174455d, y: 0.38583037896768957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6180324585259834d, y: 0.05872395499417915d), new NpgsqlTypes.NpgsqlPoint(x: 0.02186378792208843d, y: 0.39025736562279467d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2704538437461006d, y: 0.016175244329177274d), new NpgsqlTypes.NpgsqlPoint(x: 0.733479997899127d, y: 0.3909198984292126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5542515359399649d, y: 0.5393723543640411d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35912703521456535d, y: 0.2391146398759253d), new NpgsqlTypes.NpgsqlPoint(x: 0.22418617623735237d, y: 0.9973410148439299d), new NpgsqlTypes.NpgsqlPoint(x: 0.1599730654325331d, y: 0.0081463049182251d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6186538424332759d, y: 0.12580386669565657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7290359939080614d, y: 0.3856663536321234d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697898173798431d, y: 0.566253452874015d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4833702167648217d, y: 0.28518855062162995d), new NpgsqlTypes.NpgsqlPoint(x: 0.967183708755114d, y: 0.7089180635958017d), new NpgsqlTypes.NpgsqlPoint(x: 0.26924381291087973d, y: 0.37546345818777993d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36397737564952215d, y: 0.1685265040982381d), new NpgsqlTypes.NpgsqlPoint(x: 0.7424278672256435d, y: 0.3531909453130756d), new NpgsqlTypes.NpgsqlPoint(x: 0.18920828992029826d, y: 0.5659938658460335d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28371639243200997d, y: 0.093219314321204d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213978562465365d, y: 0.0996473826909633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8392040231493947d, y: 0.3004125180798468d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6815286255021524d, y: 0.5349433030114186d), new NpgsqlTypes.NpgsqlPoint(x: 0.5547533440721415d, y: 0.9342846542375437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6284281265557932d, y: 0.781436882260862d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3544207488961332d, y: 0.48434560849299435d), new NpgsqlTypes.NpgsqlPoint(x: 0.3777462680374626d, y: 0.7741772961232077d), new NpgsqlTypes.NpgsqlPoint(x: 0.22248312420894045d, y: 0.04015845406893759d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6010775758034601d, y: 0.05298408988218961d), new NpgsqlTypes.NpgsqlPoint(x: 0.27596265709435785d, y: 0.28214671238224553d), new NpgsqlTypes.NpgsqlPoint(x: 0.2397771928020942d, y: 0.5030864575238202d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7503737947960386d, y: 0.06884776354024058d), new NpgsqlTypes.NpgsqlPoint(x: 0.050013952229758574d, y: 0.3435048689660294d), new NpgsqlTypes.NpgsqlPoint(x: 0.5566931965079618d, y: 0.5315936354553656d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9245996778719098d, y: 0.7043860609932575d), new NpgsqlTypes.NpgsqlPoint(x: 0.3651345325149047d, y: 0.21091633359944095d), new NpgsqlTypes.NpgsqlPoint(x: 0.45070098030411543d, y: 0.6741400891934042d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43748920500787347d, y: 0.08960568806093416d), new NpgsqlTypes.NpgsqlPoint(x: 0.2912578359509741d, y: 0.10654394520558375d), new NpgsqlTypes.NpgsqlPoint(x: 0.3988608819884166d, y: 0.25332746758551017d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6294383032142226d, y: 0.7365039456185455d), new NpgsqlTypes.NpgsqlPoint(x: 0.16864382115380105d, y: 0.4479095329677951d), new NpgsqlTypes.NpgsqlPoint(x: 0.3644357872996904d, y: 0.06876785614832392d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.577480432130632d, y: 0.9477755090869673d), new NpgsqlTypes.NpgsqlPoint(x: 0.10203673541772773d, y: 0.10384171070314474d), new NpgsqlTypes.NpgsqlPoint(x: 0.16677717520506008d, y: 0.33705353333003063d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4276374376107983d, y: 0.976236429997085d), new NpgsqlTypes.NpgsqlPoint(x: 0.7157310182804612d, y: 0.9441009666670557d), new NpgsqlTypes.NpgsqlPoint(x: 0.9046029293449847d, y: 0.8206517085594374d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.560049110036153d, y: 0.3550064514416691d), new NpgsqlTypes.NpgsqlPoint(x: 0.5837417668995235d, y: 0.28803906540272106d), new NpgsqlTypes.NpgsqlPoint(x: 0.8378362096309296d, y: 0.2888603141121171d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5448964881803139d, y: 0.8676425809649021d), new NpgsqlTypes.NpgsqlPoint(x: 0.1585457647978571d, y: 0.916691012567501d), new NpgsqlTypes.NpgsqlPoint(x: 0.2259359291548355d, y: 0.03601054862557174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16238962785634892d, y: 0.1889593548991545d), new NpgsqlTypes.NpgsqlPoint(x: 0.7712075571314114d, y: 0.7470319531154069d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686040583634686d, y: 0.4143180658380424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5675864825979162d, y: 0.8611813641015118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9360153399154107d, y: 0.9664759469430533d), new NpgsqlTypes.NpgsqlPoint(x: 0.8307945527305411d, y: 0.8222899607739418d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2532799064791035d, y: 0.545730298670215d), new NpgsqlTypes.NpgsqlPoint(x: 0.951295987142806d, y: 0.7335934823139625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671889513542269d, y: 0.7843806748007223d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7248320672533703d, y: 0.286652976418308d), new NpgsqlTypes.NpgsqlPoint(x: 0.747012940604343d, y: 0.4591618570173235d), new NpgsqlTypes.NpgsqlPoint(x: 0.13877530435297447d, y: 0.3207541193033635d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28981585097721985d, y: 0.39692833913965553d), new NpgsqlTypes.NpgsqlPoint(x: 0.7141418935229411d, y: 0.32500827501642726d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002515748222307d, y: 0.3633551480252758d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16356620809859113d, y: 0.9418795957475353d), new NpgsqlTypes.NpgsqlPoint(x: 0.39338314325432644d, y: 0.3417529555487778d), new NpgsqlTypes.NpgsqlPoint(x: 0.658836546009838d, y: 0.3895164340547336d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1839478056702314d, y: 0.14705486452281935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708251050874772d, y: 0.8250773346957788d), new NpgsqlTypes.NpgsqlPoint(x: 0.016204909503523268d, y: 0.5627281707079819d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9098704871338938d, y: 0.6706520627075188d), new NpgsqlTypes.NpgsqlPoint(x: 0.25184344167677153d, y: 0.19701509551380714d), new NpgsqlTypes.NpgsqlPoint(x: 0.07514272142875367d, y: 0.2865159919753415d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.033639841241225765d, y: 0.2726979009231748d), new NpgsqlTypes.NpgsqlPoint(x: 0.042970326977747275d, y: 0.08260644171963161d), new NpgsqlTypes.NpgsqlPoint(x: 0.288841954035165d, y: 0.4280339077081077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48852125869350416d, y: 0.6997611138061364d), new NpgsqlTypes.NpgsqlPoint(x: 0.43198130075979d, y: 0.32583673372732147d), new NpgsqlTypes.NpgsqlPoint(x: 0.37636998123666987d, y: 0.38357814516365885d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16533455819276144d, y: 0.8320878274833285d), new NpgsqlTypes.NpgsqlPoint(x: 0.1471082609311024d, y: 0.6171670148963042d), new NpgsqlTypes.NpgsqlPoint(x: 0.6221888113267764d, y: 0.867867627165048d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7477196344388389d, y: 0.9044239270677019d), new NpgsqlTypes.NpgsqlPoint(x: 0.7726816536931979d, y: 0.3156521496408007d), new NpgsqlTypes.NpgsqlPoint(x: 0.048098461752911104d, y: 0.2712075030149266d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17485262917159816d, y: 0.032122961686629536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5952324153778604d, y: 0.7705173867233289d), new NpgsqlTypes.NpgsqlPoint(x: 0.12337352229155907d, y: 0.024682988808168993d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19983340318074494d, y: 0.8462448002180091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8880072304802542d, y: 0.29029990531074445d), new NpgsqlTypes.NpgsqlPoint(x: 0.04841193438223723d, y: 0.3757756889627367d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6180218811521917d, y: 0.7342375840332476d), new NpgsqlTypes.NpgsqlPoint(x: 0.8363136217708038d, y: 0.26070274788331715d), new NpgsqlTypes.NpgsqlPoint(x: 0.015812384871785823d, y: 0.5527833004785776d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3734849057963483d, y: 0.5949909836841166d), new NpgsqlTypes.NpgsqlPoint(x: 0.10382137707866057d, y: 0.44446286759253495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3510637743771229d, y: 0.8738006728430813d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9233922710414194d, y: 0.9134657257980734d), new NpgsqlTypes.NpgsqlPoint(x: 0.992294794906339d, y: 0.8647750745390668d), new NpgsqlTypes.NpgsqlPoint(x: 0.28255234919175176d, y: 0.304552070011733d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10915205063024425d, y: 0.8416184678923255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8968043144539136d, y: 0.28602987102222976d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746787902627983d, y: 0.8135986297416432d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9198360379897267d, y: 0.2741029561004713d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205171931863844d, y: 0.11700947084878865d), new NpgsqlTypes.NpgsqlPoint(x: 0.11399106926622848d, y: 0.2967375428929351d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8681032487846562d, y: 0.08922426580979193d), new NpgsqlTypes.NpgsqlPoint(x: 0.8403345109999774d, y: 0.2832664351374573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6732877251127043d, y: 0.08065554806991482d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4367216085808313d, y: 0.43324626978253045d), new NpgsqlTypes.NpgsqlPoint(x: 0.39307075235322664d, y: 0.01588674430354431d), new NpgsqlTypes.NpgsqlPoint(x: 0.7401087621606699d, y: 0.4129652303785448d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7213244321841632d, y: 0.8818062378642818d), new NpgsqlTypes.NpgsqlPoint(x: 0.5210033080928649d, y: 0.232714988061837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850586373490627d, y: 0.8919811779714052d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5919437315986753d, y: 0.8890365332739093d), new NpgsqlTypes.NpgsqlPoint(x: 0.3634251910984716d, y: 0.7442038840490173d), new NpgsqlTypes.NpgsqlPoint(x: 0.9755435192632701d, y: 0.4867105078593936d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4923270572642726d, y: 0.5157927669612831d), new NpgsqlTypes.NpgsqlPoint(x: 0.21435751601654474d, y: 0.6853754723924073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3231556914058521d, y: 0.7144264187046911d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7295483878916851d, y: 0.23121734292990093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6083337545781543d, y: 0.24166795700134447d), new NpgsqlTypes.NpgsqlPoint(x: 0.1918685681819643d, y: 0.999168788933198d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022863550204915706d, y: 0.9717162916781548d), new NpgsqlTypes.NpgsqlPoint(x: 0.924223771852966d, y: 0.34857268444049616d), new NpgsqlTypes.NpgsqlPoint(x: 0.48360247536440104d, y: 0.5028689405128225d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37056383721208697d, y: 0.4910114251793608d), new NpgsqlTypes.NpgsqlPoint(x: 0.10354605999224054d, y: 0.9205870834136699d), new NpgsqlTypes.NpgsqlPoint(x: 0.997233275628314d, y: 0.12584557344711245d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15722283309407237d, y: 0.8740524988530062d), new NpgsqlTypes.NpgsqlPoint(x: 0.36026701733435906d, y: 0.516983723914934d), new NpgsqlTypes.NpgsqlPoint(x: 0.6537991997507113d, y: 0.6526049825750022d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9042097973175849d, y: 0.004662009275417822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1710921249444286d, y: 0.13925532108650718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8312472915331772d, y: 0.4570231479090985d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3303336440685086d, y: 0.26083042869213513d), new NpgsqlTypes.NpgsqlPoint(x: 0.03880259526426366d, y: 0.6390922205507301d), new NpgsqlTypes.NpgsqlPoint(x: 0.09802376208357344d, y: 0.9359803338236168d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0296911540977719d, y: 0.1821339867673336d), new NpgsqlTypes.NpgsqlPoint(x: 0.0365348742873689d, y: 0.03072398077118854d), new NpgsqlTypes.NpgsqlPoint(x: 0.7839980795935594d, y: 0.04000813451515317d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9685611762946089d, y: 0.44602862830728407d), new NpgsqlTypes.NpgsqlPoint(x: 0.2330129693811709d, y: 0.48131731978699466d), new NpgsqlTypes.NpgsqlPoint(x: 0.3986691827623091d, y: 0.8693077014244184d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07083256412646577d, y: 0.6183222641160172d), new NpgsqlTypes.NpgsqlPoint(x: 0.34957904873908807d, y: 0.14454292983175976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9935439104408031d, y: 0.05056175509519112d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5721999597123419d, y: 0.3900466615590731d), new NpgsqlTypes.NpgsqlPoint(x: 0.14161543095575713d, y: 0.3809459169155407d), new NpgsqlTypes.NpgsqlPoint(x: 0.3969913109022257d, y: 0.6174588742668735d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7216399587631068d, y: 0.15606513844040204d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916387295153786d, y: 0.5124589502473431d), new NpgsqlTypes.NpgsqlPoint(x: 0.7256992082118002d, y: 0.7160196321130025d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4232589788946829d, y: 0.3964931326007064d), new NpgsqlTypes.NpgsqlPoint(x: 0.9726028496446704d, y: 0.05059031775077438d), new NpgsqlTypes.NpgsqlPoint(x: 0.26108856781049716d, y: 0.5016109888080094d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19563777913630742d, y: 0.8642079951793209d), new NpgsqlTypes.NpgsqlPoint(x: 0.6521790594765791d, y: 0.5037512477117746d), new NpgsqlTypes.NpgsqlPoint(x: 0.8308625271810566d, y: 0.349032282857728d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39009559649332903d, y: 0.08655182424636565d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087845907111738d, y: 0.28903388244058237d), new NpgsqlTypes.NpgsqlPoint(x: 0.03969746482192538d, y: 0.8209976396901635d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28039628340287437d, y: 0.9419237055201998d), new NpgsqlTypes.NpgsqlPoint(x: 0.9815879319611783d, y: 0.9977638378581466d), new NpgsqlTypes.NpgsqlPoint(x: 0.23718889788850162d, y: 0.8324104947265422d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34454444263040407d, y: 0.06792485050729691d), new NpgsqlTypes.NpgsqlPoint(x: 0.26404934462073126d, y: 0.49955303288945596d), new NpgsqlTypes.NpgsqlPoint(x: 0.06283430407939672d, y: 0.101226961838778d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7092400613566245d, y: 0.2030158245069107d), new NpgsqlTypes.NpgsqlPoint(x: 0.2590956284017605d, y: 0.6922650741775225d), new NpgsqlTypes.NpgsqlPoint(x: 0.1821899204891927d, y: 0.5948343018421566d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5889854237622291d, y: 0.661412767214621d), new NpgsqlTypes.NpgsqlPoint(x: 0.10169070674788094d, y: 0.6936000155677856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844494848924178d, y: 0.3422103742987198d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8654437028835138d, y: 0.7580169727723861d), new NpgsqlTypes.NpgsqlPoint(x: 0.8928331623030683d, y: 0.19827993790329002d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766214913443312d, y: 0.9089483221435234d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1099714270495501d, y: 0.29954253906671513d), new NpgsqlTypes.NpgsqlPoint(x: 0.1748930879281706d, y: 0.8500914441468148d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822716149299437d, y: 0.8072621774528869d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4467702827981733d, y: 0.16331609590331198d), new NpgsqlTypes.NpgsqlPoint(x: 0.21976442804875362d, y: 0.05442714869696896d), new NpgsqlTypes.NpgsqlPoint(x: 0.6676908136344694d, y: 0.4046875705487224d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8786350248964393d, y: 0.497304050556317d), new NpgsqlTypes.NpgsqlPoint(x: 0.31843281675218915d, y: 0.19928581083128438d), new NpgsqlTypes.NpgsqlPoint(x: 0.02248317124631316d, y: 0.9583288736809707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23852165858057284d, y: 0.046390120153894765d), new NpgsqlTypes.NpgsqlPoint(x: 0.3004797634746724d, y: 0.31079490947626076d), new NpgsqlTypes.NpgsqlPoint(x: 0.6540524522186419d, y: 0.1941689569834315d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2322962309115274d, y: 0.6699199981871742d), new NpgsqlTypes.NpgsqlPoint(x: 0.0996828262267726d, y: 0.33097924190285544d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816250956169528d, y: 0.4274720192731185d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7309036953931686d, y: 0.37692959620712907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8126341741005213d, y: 0.6025055387079d), new NpgsqlTypes.NpgsqlPoint(x: 0.16273723811222718d, y: 0.41011803878815756d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7579572718579469d, y: 0.14865652696161924d), new NpgsqlTypes.NpgsqlPoint(x: 0.011369181625737301d, y: 0.14293595573668283d), new NpgsqlTypes.NpgsqlPoint(x: 0.050188171785285784d, y: 0.6474779618386947d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14724195486975022d, y: 0.1800479325524985d), new NpgsqlTypes.NpgsqlPoint(x: 0.2538134348895663d, y: 0.6114246000206481d), new NpgsqlTypes.NpgsqlPoint(x: 0.3814344330509174d, y: 0.5540719970829543d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3143075936535793d, y: 0.5995541610937707d), new NpgsqlTypes.NpgsqlPoint(x: 0.5380639572251922d, y: 0.017572212824917832d), new NpgsqlTypes.NpgsqlPoint(x: 0.33966461410178583d, y: 0.15047308089071054d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41090506063511634d, y: 0.9608106982547288d), new NpgsqlTypes.NpgsqlPoint(x: 0.09215502181417157d, y: 0.914925004386622d), new NpgsqlTypes.NpgsqlPoint(x: 0.3335623307978628d, y: 0.973041844568539d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1521768615150273d, y: 0.7470138833935585d), new NpgsqlTypes.NpgsqlPoint(x: 0.4957136967277488d, y: 0.4758061455550958d), new NpgsqlTypes.NpgsqlPoint(x: 0.6973588201247689d, y: 0.30445568269261014d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7042020987075663d, y: 0.7065154872392235d), new NpgsqlTypes.NpgsqlPoint(x: 0.20298967477360275d, y: 0.1375634005381441d), new NpgsqlTypes.NpgsqlPoint(x: 0.12933541381259506d, y: 0.58759559441725d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44834935226838424d, y: 0.20002696611886472d), new NpgsqlTypes.NpgsqlPoint(x: 0.7788362522838691d, y: 0.7652999570666722d), new NpgsqlTypes.NpgsqlPoint(x: 0.8589495105208957d, y: 0.9496647693927385d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13166312989367435d, y: 0.6451293339947823d), new NpgsqlTypes.NpgsqlPoint(x: 0.7665656589151248d, y: 0.4825922712151336d), new NpgsqlTypes.NpgsqlPoint(x: 0.19742563286905424d, y: 0.04657225298918155d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6913776095111953d, y: 0.5866178615880858d), new NpgsqlTypes.NpgsqlPoint(x: 0.08759392956694156d, y: 0.9186831445694311d), new NpgsqlTypes.NpgsqlPoint(x: 0.3423119578099807d, y: 0.12463266507812143d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3397143529254093d, y: 0.7104207135709276d), new NpgsqlTypes.NpgsqlPoint(x: 0.2791052890373281d, y: 0.2660306312141051d), new NpgsqlTypes.NpgsqlPoint(x: 0.5753571099764123d, y: 0.17195817555747217d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06121935604908746d, y: 0.5462988499322966d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801647456717186d, y: 0.6876034123998154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9747208311855075d, y: 0.8998530021829012d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31308554148726897d, y: 0.4804923402933853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8356309664300887d, y: 0.8757867159299921d), new NpgsqlTypes.NpgsqlPoint(x: 0.003945657289394888d, y: 0.9464626268427564d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45701855858410767d, y: 0.676238507760154d), new NpgsqlTypes.NpgsqlPoint(x: 0.7793104342022328d, y: 0.34555637563462316d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343129332633853d, y: 0.476694079815959d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27305875364127874d, y: 0.8044295727609185d), new NpgsqlTypes.NpgsqlPoint(x: 0.2925394753056908d, y: 0.3559244036691793d), new NpgsqlTypes.NpgsqlPoint(x: 0.18256833403919726d, y: 0.8552303996015718d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5741618422840415d, y: 0.6434476609521763d), new NpgsqlTypes.NpgsqlPoint(x: 0.13051519516757093d, y: 0.963917470333857d), new NpgsqlTypes.NpgsqlPoint(x: 0.1489140626005836d, y: 0.9196479024803904d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3864308389454344d, y: 0.8303374136513267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4111930363650338d, y: 0.5644726257227481d), new NpgsqlTypes.NpgsqlPoint(x: 0.4222020373037504d, y: 0.49165929269020325d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08475850558452602d, y: 0.26606476661260625d), new NpgsqlTypes.NpgsqlPoint(x: 0.41825056204662325d, y: 0.23320874804698344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2112531097548509d, y: 0.7617790531086835d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6497496404934359d, y: 0.904699369554356d), new NpgsqlTypes.NpgsqlPoint(x: 0.19676562215314464d, y: 0.09004674093935727d), new NpgsqlTypes.NpgsqlPoint(x: 0.39490663729247666d, y: 0.1138541269835478d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5913681502613005d, y: 0.2720389629983848d), new NpgsqlTypes.NpgsqlPoint(x: 0.4841699189574453d, y: 0.9195537345717038d), new NpgsqlTypes.NpgsqlPoint(x: 0.17555546078064455d, y: 0.5922156855167573d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42815241151921357d, y: 0.4469699599022442d), new NpgsqlTypes.NpgsqlPoint(x: 0.5219836379992578d, y: 0.5008675567575649d), new NpgsqlTypes.NpgsqlPoint(x: 0.18133202927629755d, y: 0.7159350080181155d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9669288062854469d, y: 0.6673630706287801d), new NpgsqlTypes.NpgsqlPoint(x: 0.287260667561399d, y: 0.4200928802134668d), new NpgsqlTypes.NpgsqlPoint(x: 0.14693316586830774d, y: 0.20504160283452144d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9295857450974357d, y: 0.4892923579315873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9338205711769098d, y: 0.9730422721691353d), new NpgsqlTypes.NpgsqlPoint(x: 0.6330665335806274d, y: 0.6985907955899119d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9263626044293811d, y: 0.5371971381822549d), new NpgsqlTypes.NpgsqlPoint(x: 0.10388410067618015d, y: 0.7869171114267551d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969987281964585d, y: 0.17049856186529222d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3142377324789958d, y: 0.15750200583049678d), new NpgsqlTypes.NpgsqlPoint(x: 0.021587938628398917d, y: 0.36231522844358244d), new NpgsqlTypes.NpgsqlPoint(x: 0.39547251801503636d, y: 0.5160421079477159d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12150483034952653d, y: 0.46746809892518804d), new NpgsqlTypes.NpgsqlPoint(x: 0.5331725026080228d, y: 0.04901212923121645d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298191639320247d, y: 0.16644393991209094d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5242343115456016d, y: 0.675904707475708d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889665833495654d, y: 0.6812529946705767d), new NpgsqlTypes.NpgsqlPoint(x: 0.4442184571291875d, y: 0.07749876176187342d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4494409198214254d, y: 0.9231823695870918d), new NpgsqlTypes.NpgsqlPoint(x: 0.10476153423818535d, y: 0.20544663916112138d), new NpgsqlTypes.NpgsqlPoint(x: 0.4875311237299925d, y: 0.67347922085128d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7335257304867484d, y: 0.11853297172454158d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594490525888171d, y: 0.2457741897052026d), new NpgsqlTypes.NpgsqlPoint(x: 0.11790842125172452d, y: 0.884429207452108d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07688973349799721d, y: 0.5156849559120588d), new NpgsqlTypes.NpgsqlPoint(x: 0.14125578623023782d, y: 0.3480674558441984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9326994950403071d, y: 0.6209658837514908d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8848246699206925d, y: 0.12055660316157546d), new NpgsqlTypes.NpgsqlPoint(x: 0.7562429249362651d, y: 0.9542341227979594d), new NpgsqlTypes.NpgsqlPoint(x: 0.009615137777980176d, y: 0.8231691083716688d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15408909240827584d, y: 0.01447897602997128d), new NpgsqlTypes.NpgsqlPoint(x: 0.1329746683623818d, y: 0.9797377388671585d), new NpgsqlTypes.NpgsqlPoint(x: 0.46691852525943556d, y: 0.07544031589364952d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.658152630989711d, y: 0.7625702883109076d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970640928079485d, y: 0.4888296542206718d), new NpgsqlTypes.NpgsqlPoint(x: 0.09840675093269835d, y: 0.8188543445947274d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8801491146385038d, y: 0.5765484778040119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536743676497886d, y: 0.9856566901708107d), new NpgsqlTypes.NpgsqlPoint(x: 0.43364244448229805d, y: 0.2933875596567951d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07281225627224586d, y: 0.41020370041988785d), new NpgsqlTypes.NpgsqlPoint(x: 0.849911274794422d, y: 0.6382229593920128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8484220651280205d, y: 0.6682376209076054d)), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4789332662403991d, y: 0.10441813167385394d), new NpgsqlTypes.NpgsqlPoint(x: 0.5990084218316178d, y: 0.47258707512255627d), new NpgsqlTypes.NpgsqlPoint(x: 0.7427713789219851d, y: 0.5782568043925107d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8515402786179525d, y: 0.6292676794005748d), new NpgsqlTypes.NpgsqlPoint(x: 0.7807839218763017d, y: 0.4748758674444904d), new NpgsqlTypes.NpgsqlPoint(x: 0.5700961478484684d, y: 0.48681858039932235d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4102568505980676d, y: 0.5052423742070264d), new NpgsqlTypes.NpgsqlPoint(x: 0.6738643039839637d, y: 0.4728418375845278d), new NpgsqlTypes.NpgsqlPoint(x: 0.6514679865994286d, y: 0.43461232207056233d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.53603026705147d, y: 0.6897284301936426d), new NpgsqlTypes.NpgsqlPoint(x: 0.4675737571658427d, y: 0.49790604104285563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9810269126839428d, y: 0.3026062128636253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5787626704640321d, y: 0.48243312267146066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8480154684743223d, y: 0.5117633760857833d), new NpgsqlTypes.NpgsqlPoint(x: 0.43139416338738346d, y: 0.09647179146088036d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7280946199017001d, y: 0.926797945641538d), new NpgsqlTypes.NpgsqlPoint(x: 0.3374304436881277d, y: 0.9068504997111528d), new NpgsqlTypes.NpgsqlPoint(x: 0.072369970875367d, y: 0.7163548530746072d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3399415686654451d, y: 0.012284319890429551d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796167733283609d, y: 0.3570273816948387d), new NpgsqlTypes.NpgsqlPoint(x: 0.412302456276903d, y: 0.8068782665051798d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20376100854720347d, y: 0.4387713552047512d), new NpgsqlTypes.NpgsqlPoint(x: 0.025545630945147946d, y: 0.5284328937232928d), new NpgsqlTypes.NpgsqlPoint(x: 0.7017626341210657d, y: 0.719088865546264d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7761660321122433d, y: 0.8169279038151293d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281292980575466d, y: 0.11325972877087354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129524286811798d, y: 0.4423199474934242d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7313733447844083d, y: 0.11994369521415582d), new NpgsqlTypes.NpgsqlPoint(x: 0.925535182963008d, y: 0.7237586966291d), new NpgsqlTypes.NpgsqlPoint(x: 0.6477531857684463d, y: 0.8084575257561347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3627868990725138d, y: 0.00031559216465903983d), new NpgsqlTypes.NpgsqlPoint(x: 0.33621286353661406d, y: 0.2153737274575479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7366625594844881d, y: 0.294646140927897d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09025358450469978d, y: 0.6387726866449763d), new NpgsqlTypes.NpgsqlPoint(x: 0.3865505862556142d, y: 0.23581111761959272d), new NpgsqlTypes.NpgsqlPoint(x: 0.6681880475277346d, y: 0.34152981742469923d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2941341943925141d, y: 0.9237325054562852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9878963563782875d, y: 0.8212514489280048d), new NpgsqlTypes.NpgsqlPoint(x: 0.7148859007182332d, y: 0.7466705325492689d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8973565786921937d, y: 0.15083202460435707d), new NpgsqlTypes.NpgsqlPoint(x: 0.24511641427307396d, y: 0.5627799536627184d), new NpgsqlTypes.NpgsqlPoint(x: 0.9523859048156739d, y: 0.480350111877035d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13463955554459706d, y: 0.8883865055480883d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694384039285569d, y: 0.5882068515991666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9465311220402937d, y: 0.08188915399813002d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7273285581574312d, y: 0.39817055584856065d), new NpgsqlTypes.NpgsqlPoint(x: 0.09902156707839094d, y: 0.01693587184176082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9115844855003165d, y: 0.8360321211747905d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9716340458566007d, y: 0.4995371036576758d), new NpgsqlTypes.NpgsqlPoint(x: 0.79855544435109d, y: 0.01290378371357681d), new NpgsqlTypes.NpgsqlPoint(x: 0.37039727093873887d, y: 0.9756562489568307d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9602441995538091d, y: 0.16506098611238817d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961024654359896d, y: 0.6837154333400712d), new NpgsqlTypes.NpgsqlPoint(x: 0.7100032767130303d, y: 0.09997835258430454d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9069568565733007d, y: 0.10148417492310347d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797246309965478d, y: 0.0741053150013663d), new NpgsqlTypes.NpgsqlPoint(x: 0.7412848996971441d, y: 0.17693623446124662d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3100221782390905d, y: 0.7616360354808097d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271434968866296d, y: 0.15787413178616394d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722918216544642d, y: 0.044413995067776546d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35946543142638876d, y: 0.11350593510455576d), new NpgsqlTypes.NpgsqlPoint(x: 0.47063222316136055d, y: 0.7630908627903722d), new NpgsqlTypes.NpgsqlPoint(x: 0.37577566897305525d, y: 0.673534218367391d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1113950399752639d, y: 0.7722897871697113d), new NpgsqlTypes.NpgsqlPoint(x: 0.4682746848043531d, y: 0.9279418690821672d), new NpgsqlTypes.NpgsqlPoint(x: 0.01022393557701129d, y: 0.6353444149141213d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5171890247347039d, y: 0.6424626197187118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8695646781379235d, y: 0.9212137482603022d), new NpgsqlTypes.NpgsqlPoint(x: 0.05091501491267725d, y: 0.5683699769242558d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8866030820442272d, y: 0.273424422567209d), new NpgsqlTypes.NpgsqlPoint(x: 0.29146785789156715d, y: 0.19009711438280608d), new NpgsqlTypes.NpgsqlPoint(x: 0.3755982850089763d, y: 0.8119145015341453d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5055747383489416d, y: 0.6991856766840363d), new NpgsqlTypes.NpgsqlPoint(x: 0.5180336921420994d, y: 0.6542690163200614d), new NpgsqlTypes.NpgsqlPoint(x: 0.43090362758456424d, y: 0.13883214313128922d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7687995901914587d, y: 0.5076155551998248d), new NpgsqlTypes.NpgsqlPoint(x: 0.8720090002189204d, y: 0.13356616906358254d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332619014169448d, y: 0.2951882670610366d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8967865060620989d, y: 0.4445369814323997d), new NpgsqlTypes.NpgsqlPoint(x: 0.9724820344006444d, y: 0.6032402868577256d), new NpgsqlTypes.NpgsqlPoint(x: 0.1422378331006d, y: 0.935819194410573d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9351473678812564d, y: 0.36170246930185357d), new NpgsqlTypes.NpgsqlPoint(x: 0.1704937471194361d, y: 0.8087885726195827d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543038407128041d, y: 0.5382209885347145d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4426010899142394d, y: 0.6960537266902957d), new NpgsqlTypes.NpgsqlPoint(x: 0.7559160219486463d, y: 0.9540538567938397d), new NpgsqlTypes.NpgsqlPoint(x: 0.34915384654353465d, y: 0.41967729743886617d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6368329790435253d, y: 0.6430609563394577d), new NpgsqlTypes.NpgsqlPoint(x: 0.5824244071740012d, y: 0.07699099867022663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2519735575110892d, y: 0.1881320525413792d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4210207134463064d, y: 0.4425633453183958d), new NpgsqlTypes.NpgsqlPoint(x: 0.020147457330052854d, y: 0.20318795130136358d), new NpgsqlTypes.NpgsqlPoint(x: 0.10644552329337398d, y: 0.1112888077058436d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7279624582355197d, y: 0.455697046699406d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616732132820761d, y: 0.32415956103775767d), new NpgsqlTypes.NpgsqlPoint(x: 0.410750506457113d, y: 0.5186985124523175d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24492346410451493d, y: 0.5272366414312132d), new NpgsqlTypes.NpgsqlPoint(x: 0.6682637769442777d, y: 0.018029972790933102d), new NpgsqlTypes.NpgsqlPoint(x: 0.8138152402983484d, y: 0.514566231112036d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8095629091634667d, y: 0.2941935839100742d), new NpgsqlTypes.NpgsqlPoint(x: 0.38574370675917036d, y: 0.03562685562747914d), new NpgsqlTypes.NpgsqlPoint(x: 0.9321327069913241d, y: 0.19988098317902603d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7571046455792804d, y: 0.034290955644591725d), new NpgsqlTypes.NpgsqlPoint(x: 0.4052356989744227d, y: 0.7077824472049634d), new NpgsqlTypes.NpgsqlPoint(x: 0.37284531020306066d, y: 0.5246033805173442d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08559277629419004d, y: 0.47107218923908056d), new NpgsqlTypes.NpgsqlPoint(x: 0.19930146146940908d, y: 0.8822386610821804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3603951956181145d, y: 0.4254777283468133d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17120232109169609d, y: 0.4640612250642653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6271160200185122d, y: 0.062075285297802596d), new NpgsqlTypes.NpgsqlPoint(x: 0.5601849753576715d, y: 0.4414287112866341d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10414355745272597d, y: 0.40080920637033535d), new NpgsqlTypes.NpgsqlPoint(x: 0.8463147157627678d, y: 0.4667580386391976d), new NpgsqlTypes.NpgsqlPoint(x: 0.22986302911586887d, y: 0.32419618554028373d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9145747153218998d, y: 0.5640215643835081d), new NpgsqlTypes.NpgsqlPoint(x: 0.7075446540680763d, y: 0.8209037038631442d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687865161610888d, y: 0.6773554711690637d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2551584491831519d, y: 0.702525715977812d), new NpgsqlTypes.NpgsqlPoint(x: 0.24079022982385823d, y: 0.8527438471814165d), new NpgsqlTypes.NpgsqlPoint(x: 0.7521176833410705d, y: 0.5172404649144051d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4378811465816842d, y: 0.12276999194563587d), new NpgsqlTypes.NpgsqlPoint(x: 0.03993789089825661d, y: 0.599056731524053d), new NpgsqlTypes.NpgsqlPoint(x: 0.9384030823847601d, y: 0.09609454287641517d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27157095479629556d, y: 0.571913009052516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610925584582438d, y: 0.8258794040790551d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699045739116185d, y: 0.6699738658181941d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5146566321221441d, y: 0.7898349219636907d), new NpgsqlTypes.NpgsqlPoint(x: 0.8236346774538122d, y: 0.2926344283961717d), new NpgsqlTypes.NpgsqlPoint(x: 0.3715979460967169d, y: 0.5404372574131429d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2680055701663092d, y: 0.8893513859116624d), new NpgsqlTypes.NpgsqlPoint(x: 0.9904461676649965d, y: 0.01069027208106732d), new NpgsqlTypes.NpgsqlPoint(x: 0.3305821572111053d, y: 0.8942638249912179d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4045949605684962d, y: 0.043751955482379645d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616166139187792d, y: 0.1468699305770924d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207885255597372d, y: 0.47173031479993965d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5191432172360243d, y: 0.8024917476625386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5166260004915224d, y: 0.6525236872606394d), new NpgsqlTypes.NpgsqlPoint(x: 0.027078129643185567d, y: 0.7305053174434715d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19248520047829598d, y: 0.2175072752167666d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020000376521467d, y: 0.6227937940977006d), new NpgsqlTypes.NpgsqlPoint(x: 0.976366435755465d, y: 0.22535077928636782d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11867644791038512d, y: 0.7876277553966792d), new NpgsqlTypes.NpgsqlPoint(x: 0.5844099174616281d, y: 0.3664928259053415d), new NpgsqlTypes.NpgsqlPoint(x: 0.8335576101370457d, y: 0.991953438861327d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43381593242548255d, y: 0.03185913827895104d), new NpgsqlTypes.NpgsqlPoint(x: 0.19044060343444302d, y: 0.35556443589985187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662884801475105d, y: 0.6799632692711874d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6833885039367723d, y: 0.9052395927080669d), new NpgsqlTypes.NpgsqlPoint(x: 0.9040762798102396d, y: 0.7361553833929474d), new NpgsqlTypes.NpgsqlPoint(x: 0.20771065505757114d, y: 0.6552029907792075d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25908228248840603d, y: 0.49955449210084624d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394537702734766d, y: 0.9869146286945488d), new NpgsqlTypes.NpgsqlPoint(x: 0.08299573848282571d, y: 0.4011048538070995d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1415684141110588d, y: 0.2602853777473142d), new NpgsqlTypes.NpgsqlPoint(x: 0.33627305974617927d, y: 0.3200428852367414d), new NpgsqlTypes.NpgsqlPoint(x: 0.8504017030199004d, y: 0.7601702503353265d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30956937514575245d, y: 0.6478852245694137d), new NpgsqlTypes.NpgsqlPoint(x: 0.3542467328205856d, y: 0.3210556502546019d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942717432260051d, y: 0.23783573809761083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9965861548736149d, y: 0.5375722608777915d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290477488446229d, y: 0.07681680582481032d), new NpgsqlTypes.NpgsqlPoint(x: 0.8934631514169475d, y: 0.671865555957302d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7055067658784108d, y: 0.6518900537470421d), new NpgsqlTypes.NpgsqlPoint(x: 0.3352129254161108d, y: 0.40511524910643515d), new NpgsqlTypes.NpgsqlPoint(x: 0.03832662280457033d, y: 0.3540554530633532d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17709115205166936d, y: 0.2738581262146321d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534756285362597d, y: 0.0774084743557667d), new NpgsqlTypes.NpgsqlPoint(x: 0.2800615912429998d, y: 0.15046785575313903d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6886834955029391d, y: 0.21815066916989478d), new NpgsqlTypes.NpgsqlPoint(x: 0.571212738764374d, y: 0.7570512585666495d), new NpgsqlTypes.NpgsqlPoint(x: 0.6162587206813961d, y: 0.075192308887153d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.650945167078339d, y: 0.6078554453187857d), new NpgsqlTypes.NpgsqlPoint(x: 0.5104275975733031d, y: 0.46854359245230937d), new NpgsqlTypes.NpgsqlPoint(x: 0.4177311755456642d, y: 0.4536902129136705d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5440603314612119d, y: 0.13483882285917348d), new NpgsqlTypes.NpgsqlPoint(x: 0.8812791951055328d, y: 0.6572401061949633d), new NpgsqlTypes.NpgsqlPoint(x: 0.009525640933412127d, y: 0.9573646068675582d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37682630476097356d, y: 0.9979277592234073d), new NpgsqlTypes.NpgsqlPoint(x: 0.18042448265333522d, y: 0.6725602521429409d), new NpgsqlTypes.NpgsqlPoint(x: 0.08577871613802224d, y: 0.7862865540468504d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08216644933210593d, y: 0.05668345558005572d), new NpgsqlTypes.NpgsqlPoint(x: 0.6645091884053282d, y: 0.7830182788878521d), new NpgsqlTypes.NpgsqlPoint(x: 0.7637778140372545d, y: 0.5631130091236215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.006684457919052478d, y: 0.670239503032728d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552886597243931d, y: 0.46823355200283145d), new NpgsqlTypes.NpgsqlPoint(x: 0.28868646168509726d, y: 0.9141593157833182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4237589195986372d, y: 0.5528031335255391d), new NpgsqlTypes.NpgsqlPoint(x: 0.37903250296044744d, y: 0.04037574045909964d), new NpgsqlTypes.NpgsqlPoint(x: 0.3022813433232303d, y: 0.8565491657965947d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02187731645122515d, y: 0.363425736392578d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416972950161902d, y: 0.3828898082963067d), new NpgsqlTypes.NpgsqlPoint(x: 0.21542831338646162d, y: 0.6568699420587413d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7927046705329988d, y: 0.5191003495105415d), new NpgsqlTypes.NpgsqlPoint(x: 0.5817245916367443d, y: 0.7204514281495159d), new NpgsqlTypes.NpgsqlPoint(x: 0.8646792483989979d, y: 0.40147352729023167d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12345991568141501d, y: 0.8284047188473751d), new NpgsqlTypes.NpgsqlPoint(x: 0.014975702005572633d, y: 0.9254161193999896d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648443435352317d, y: 0.7095669826199605d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2092783200967253d, y: 0.6673913877129917d), new NpgsqlTypes.NpgsqlPoint(x: 0.9246803820998517d, y: 0.9033647679387278d), new NpgsqlTypes.NpgsqlPoint(x: 0.1833292442421195d, y: 0.11805125638482328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4363801623640605d, y: 0.1411148973565105d), new NpgsqlTypes.NpgsqlPoint(x: 0.7391364628621464d, y: 0.6938800358934807d), new NpgsqlTypes.NpgsqlPoint(x: 0.1976956055718717d, y: 0.7014416017541707d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9512462857566361d, y: 0.3468414517168552d), new NpgsqlTypes.NpgsqlPoint(x: 0.36317177635644426d, y: 0.25163010927994545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6296752682836155d, y: 0.4718822979898485d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6187343215708324d, y: 0.9480324103125978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4670223545297285d, y: 0.14331963699095962d), new NpgsqlTypes.NpgsqlPoint(x: 0.8976986033747706d, y: 0.008960387507021661d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3646914458627476d, y: 0.48386538378171495d), new NpgsqlTypes.NpgsqlPoint(x: 0.3106949955477435d, y: 0.6596872772170337d), new NpgsqlTypes.NpgsqlPoint(x: 0.88470822125678d, y: 0.9761485846664928d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8481270789259295d, y: 0.6644693117585754d), new NpgsqlTypes.NpgsqlPoint(x: 0.73449544068989d, y: 0.20071769952730922d), new NpgsqlTypes.NpgsqlPoint(x: 0.027612410901469042d, y: 0.8657093991679281d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11968317095031489d, y: 0.022442393920280912d), new NpgsqlTypes.NpgsqlPoint(x: 0.8784201839378517d, y: 0.14892471245285466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7416311095158089d, y: 0.46921535015868066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9841839326225107d, y: 0.001447260378492854d), new NpgsqlTypes.NpgsqlPoint(x: 0.4363812576127677d, y: 0.014657528291124211d), new NpgsqlTypes.NpgsqlPoint(x: 0.39447728569723906d, y: 0.5724882854303381d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8807019983488964d, y: 0.6060118240619089d), new NpgsqlTypes.NpgsqlPoint(x: 0.16521896175911843d, y: 0.9712154299943727d), new NpgsqlTypes.NpgsqlPoint(x: 0.20557809386247183d, y: 0.6759277580341504d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3944332644629932d, y: 0.011649819221377866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4242972330023217d, y: 0.6261542505060576d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623341451153506d, y: 0.180045805568266d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4188672423724825d, y: 0.8992861097852388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4657749949174035d, y: 0.48685823864810884d), new NpgsqlTypes.NpgsqlPoint(x: 0.7873127389907053d, y: 0.07192153242041233d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9893510649550715d, y: 0.7035168100714642d), new NpgsqlTypes.NpgsqlPoint(x: 0.28108006782725325d, y: 0.22796545186607153d), new NpgsqlTypes.NpgsqlPoint(x: 0.4740835364507673d, y: 0.7127038163269527d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08236009477036366d, y: 0.3447483064615001d), new NpgsqlTypes.NpgsqlPoint(x: 0.06301038173220108d, y: 0.3173457486383927d), new NpgsqlTypes.NpgsqlPoint(x: 0.01829181843196792d, y: 0.04918968676310942d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8479181466595821d, y: 0.5094072548021978d), new NpgsqlTypes.NpgsqlPoint(x: 0.3838391355382963d, y: 0.29507543769661104d), new NpgsqlTypes.NpgsqlPoint(x: 0.6117896888038864d, y: 0.805280434162871d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7341890153750756d, y: 0.2357317927060466d), new NpgsqlTypes.NpgsqlPoint(x: 0.6597235888514295d, y: 0.301020356062365d), new NpgsqlTypes.NpgsqlPoint(x: 0.16348906032225918d, y: 0.94700078427627d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9456934065941501d, y: 0.6133836748963655d), new NpgsqlTypes.NpgsqlPoint(x: 0.8838934312227128d, y: 0.5167144799721557d), new NpgsqlTypes.NpgsqlPoint(x: 0.10571585601456801d, y: 0.7951979568147065d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2641862829788667d, y: 0.010264792258572797d), new NpgsqlTypes.NpgsqlPoint(x: 0.4997314935601601d, y: 0.907815966223508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6687041383852341d, y: 0.3369433336878612d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36537861136554306d, y: 0.1349767089028081d), new NpgsqlTypes.NpgsqlPoint(x: 0.6048107078343934d, y: 0.3859736323075642d), new NpgsqlTypes.NpgsqlPoint(x: 0.03872650138611977d, y: 0.18348318630612703d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013947087528240254d, y: 0.5443974658279198d), new NpgsqlTypes.NpgsqlPoint(x: 0.3618191357060171d, y: 0.47443294088549304d), new NpgsqlTypes.NpgsqlPoint(x: 0.6363704185415924d, y: 0.6733295380604869d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7614680307222101d, y: 0.17693390492513383d), new NpgsqlTypes.NpgsqlPoint(x: 0.2558508396815806d, y: 0.5845952411571085d), new NpgsqlTypes.NpgsqlPoint(x: 0.18935321716773212d, y: 0.4685885432235123d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26160694578652943d, y: 0.6649748394878118d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728724155258776d, y: 0.14955316028136634d), new NpgsqlTypes.NpgsqlPoint(x: 0.588576589230522d, y: 0.29418003169256735d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4745042620767216d, y: 0.8405417889714122d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917429404909653d, y: 0.16496506428689195d), new NpgsqlTypes.NpgsqlPoint(x: 0.41563783330242277d, y: 0.5906952692967391d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4474718752456499d, y: 0.7641789345481993d), new NpgsqlTypes.NpgsqlPoint(x: 0.868217246532718d, y: 0.7869453857512795d), new NpgsqlTypes.NpgsqlPoint(x: 0.6705350635433256d, y: 0.25907668536109507d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7554370315761949d, y: 0.3528579166922047d), new NpgsqlTypes.NpgsqlPoint(x: 0.9930683477121732d, y: 0.8932479270541418d), new NpgsqlTypes.NpgsqlPoint(x: 0.8550777645201785d, y: 0.4907646535575374d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8258539888471763d, y: 0.38907698069280816d), new NpgsqlTypes.NpgsqlPoint(x: 0.4836276479444842d, y: 0.45015089302553724d), new NpgsqlTypes.NpgsqlPoint(x: 0.778612639538525d, y: 0.6882653712420626d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.384561554240338d, y: 0.10834023284561078d), new NpgsqlTypes.NpgsqlPoint(x: 0.03737733665846976d, y: 0.5104059490108139d), new NpgsqlTypes.NpgsqlPoint(x: 0.21414154131643226d, y: 0.09225088744100474d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7929647362845617d, y: 0.9451682889499103d), new NpgsqlTypes.NpgsqlPoint(x: 0.029172042581945834d, y: 0.9174999906292178d), new NpgsqlTypes.NpgsqlPoint(x: 0.5570643479160482d, y: 0.346369005649512d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.826696554512569d, y: 0.9773175785219789d), new NpgsqlTypes.NpgsqlPoint(x: 0.519998815811839d, y: 0.12044382638616913d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749030329038868d, y: 0.9583181997941227d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6821067995384662d, y: 0.3937066452133059d), new NpgsqlTypes.NpgsqlPoint(x: 0.3721418513258272d, y: 0.4239997446330459d), new NpgsqlTypes.NpgsqlPoint(x: 0.20306461936981868d, y: 0.8727668587098666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43241735205045273d, y: 0.321355300250435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9282563252245446d, y: 0.0070141236497165416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6322380851742182d, y: 0.5853951928265564d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.921268087179153d, y: 0.28558119293351314d), new NpgsqlTypes.NpgsqlPoint(x: 0.9085537440512769d, y: 0.5393373094402477d), new NpgsqlTypes.NpgsqlPoint(x: 0.12681814162933358d, y: 0.060345931583319246d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35172558084434813d, y: 0.3311351750390983d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800459959016959d, y: 0.602672035448291d), new NpgsqlTypes.NpgsqlPoint(x: 0.5335788790169265d, y: 0.4343933143087625d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8493158795065981d, y: 0.05238970106866092d), new NpgsqlTypes.NpgsqlPoint(x: 0.47451473591791515d, y: 0.34276214589316567d), new NpgsqlTypes.NpgsqlPoint(x: 0.9100951276721709d, y: 0.8731863775305346d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1693566373606391d, y: 0.44383538476067474d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356838236560806d, y: 0.8256150661408282d), new NpgsqlTypes.NpgsqlPoint(x: 0.2807129107574937d, y: 0.08911939667821689d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.837815370384665d, y: 0.310434904360571d), new NpgsqlTypes.NpgsqlPoint(x: 0.8642567875512697d, y: 0.913430035221201d), new NpgsqlTypes.NpgsqlPoint(x: 0.018343816503819665d, y: 0.5845618970256552d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5255475031196397d, y: 0.7688715716654042d), new NpgsqlTypes.NpgsqlPoint(x: 0.25900479011903377d, y: 0.5411035222287489d), new NpgsqlTypes.NpgsqlPoint(x: 0.10242377882482989d, y: 0.15341542030301691d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6786168610002606d, y: 0.8248968345334298d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048785161840747d, y: 0.5411945823318985d), new NpgsqlTypes.NpgsqlPoint(x: 0.4537027139509492d, y: 0.46395470608990796d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6998002210691555d, y: 0.9710044966101068d), new NpgsqlTypes.NpgsqlPoint(x: 0.30385156803895486d, y: 0.35674360512164793d), new NpgsqlTypes.NpgsqlPoint(x: 0.3650748689416843d, y: 0.8486872335051805d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6926913188249169d, y: 0.73507631450738d), new NpgsqlTypes.NpgsqlPoint(x: 0.7835217905281715d, y: 0.7586140365436712d), new NpgsqlTypes.NpgsqlPoint(x: 0.511264998908997d, y: 0.542249484956743d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9752414196867208d, y: 0.99103349768292d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686835194640686d, y: 0.9973460890834462d), new NpgsqlTypes.NpgsqlPoint(x: 0.0877035472641372d, y: 0.1709181510848955d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6662670875078871d, y: 0.047116323285186446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6797224107723426d, y: 0.09183926325418934d), new NpgsqlTypes.NpgsqlPoint(x: 0.5454141268456995d, y: 0.740060757326172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3588423974650745d, y: 0.13648635566893075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4256021633245147d, y: 0.29965490245595483d), new NpgsqlTypes.NpgsqlPoint(x: 0.06972489379401048d, y: 0.8909754629810773d)), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11751485792046357d, y: 0.3716589453652286d), new NpgsqlTypes.NpgsqlPoint(x: 0.7097748547009151d, y: 0.14643948966173637d), new NpgsqlTypes.NpgsqlPoint(x: 0.0402832001516068d, y: 0.6297098554293781d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39819349517579916d, y: 0.8384025972369208d), new NpgsqlTypes.NpgsqlPoint(x: 0.5696399634254181d, y: 0.9616803282062499d), new NpgsqlTypes.NpgsqlPoint(x: 0.5652880691277765d, y: 0.15542257859452746d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5956240647109771d, y: 0.5207552044069674d), new NpgsqlTypes.NpgsqlPoint(x: 0.6523141291004925d, y: 0.8417854832529627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446629531892094d, y: 0.668327797689975d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4496013909337174d, y: 0.06269658547149604d), new NpgsqlTypes.NpgsqlPoint(x: 0.15501899552297094d, y: 0.19849710958744105d), new NpgsqlTypes.NpgsqlPoint(x: 0.28422595899271563d, y: 0.561736233502269d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42830827174484765d, y: 0.07381079823820025d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898370489115773d, y: 0.4458183478085527d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993050811187194d, y: 0.8766685281092174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6553115380622632d, y: 0.831972502949809d), new NpgsqlTypes.NpgsqlPoint(x: 0.41940610486294994d, y: 0.6935740376079627d), new NpgsqlTypes.NpgsqlPoint(x: 0.16977976718822607d, y: 0.5932571223128278d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18177484724083215d, y: 0.05000314164970343d), new NpgsqlTypes.NpgsqlPoint(x: 0.5991076324167048d, y: 0.5437563033659388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5017466914100234d, y: 0.9021972668595007d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5190849165089948d, y: 0.30065069509895004d), new NpgsqlTypes.NpgsqlPoint(x: 0.4443529423073185d, y: 0.4388913058140297d), new NpgsqlTypes.NpgsqlPoint(x: 0.6764312200666911d, y: 0.28121058845846525d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5702816408810749d, y: 0.07783861958921223d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253801632952847d, y: 0.6011490875036274d), new NpgsqlTypes.NpgsqlPoint(x: 0.48256826895087523d, y: 0.5683374484584371d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4664749410553175d, y: 0.7360537154759901d), new NpgsqlTypes.NpgsqlPoint(x: 0.23611944740586743d, y: 0.06985920648507515d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157273908003752d, y: 0.006068023651485621d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46190968626895523d, y: 0.49997189166231315d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877137360709961d, y: 0.321283772782449d), new NpgsqlTypes.NpgsqlPoint(x: 0.1979853441774142d, y: 0.07456159413221097d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3744681596754843d, y: 0.9578958092844255d), new NpgsqlTypes.NpgsqlPoint(x: 0.8545167653620181d, y: 0.33407572887299486d), new NpgsqlTypes.NpgsqlPoint(x: 0.8273811816129596d, y: 0.19059831221441503d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4967461337396525d, y: 0.09398917290213338d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915456495389041d, y: 0.398738483450904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8101796467242143d, y: 0.2686468293688483d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021902408608180268d, y: 0.6925751879388796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4592979446374972d, y: 0.30385229281800263d), new NpgsqlTypes.NpgsqlPoint(x: 0.37314520744532953d, y: 0.32339071057238455d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8615650354049963d, y: 0.42171336072618126d), new NpgsqlTypes.NpgsqlPoint(x: 0.09957102062220413d, y: 0.2828268261554573d), new NpgsqlTypes.NpgsqlPoint(x: 0.39071441835508314d, y: 0.31775448029633535d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1542648010541272d, y: 0.5364596513945633d), new NpgsqlTypes.NpgsqlPoint(x: 0.18811324839206456d, y: 0.21567091865072252d), new NpgsqlTypes.NpgsqlPoint(x: 0.6584572565410577d, y: 0.1415556892965396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9659868276229298d, y: 0.06456975551733857d), new NpgsqlTypes.NpgsqlPoint(x: 0.18710515623755808d, y: 0.4282143260295922d), new NpgsqlTypes.NpgsqlPoint(x: 0.8420430304508272d, y: 0.849785017267741d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6920124105365969d, y: 0.6139787402851401d), new NpgsqlTypes.NpgsqlPoint(x: 0.3816223364926814d, y: 0.3724211240984052d), new NpgsqlTypes.NpgsqlPoint(x: 0.45043384574054157d, y: 0.32219493758211926d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9608468889864039d, y: 0.26222466197638705d), new NpgsqlTypes.NpgsqlPoint(x: 0.33586603229218814d, y: 0.14930986636898058d), new NpgsqlTypes.NpgsqlPoint(x: 0.7897012084142595d, y: 0.34992919734320815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7909201298183848d, y: 0.032177380157465074d), new NpgsqlTypes.NpgsqlPoint(x: 0.3419594003579438d, y: 0.7708997695241518d), new NpgsqlTypes.NpgsqlPoint(x: 0.15119550460242304d, y: 0.003372896117759261d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07827290415672938d, y: 0.1861382451546677d), new NpgsqlTypes.NpgsqlPoint(x: 0.03573360472408904d, y: 0.1864294390602621d), new NpgsqlTypes.NpgsqlPoint(x: 0.6661316326160105d, y: 0.6097588423181328d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5247212430270078d, y: 0.6038413353363385d), new NpgsqlTypes.NpgsqlPoint(x: 0.015256938614615079d, y: 0.8526587002641531d), new NpgsqlTypes.NpgsqlPoint(x: 0.5218215522997528d, y: 0.5363200050729857d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9817695045455409d, y: 0.060378693930290606d), new NpgsqlTypes.NpgsqlPoint(x: 0.5772667019151972d, y: 0.8549504857409767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9753790966955346d, y: 0.1212008111026116d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6977863522570545d, y: 0.2997777935689603d), new NpgsqlTypes.NpgsqlPoint(x: 0.35189951533523034d, y: 0.0063987189659237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8228887311241881d, y: 0.9723805682109247d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.906113536881539d, y: 0.7183683785785371d), new NpgsqlTypes.NpgsqlPoint(x: 0.4905226235781839d, y: 0.44516152210743454d), new NpgsqlTypes.NpgsqlPoint(x: 0.20944755905445345d, y: 0.6092026954205514d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35052381124731014d, y: 0.24176261730837845d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864724887862892d, y: 0.12597419984617653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828425013229875d, y: 0.48447102450897395d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3662671020791832d, y: 0.8107916778554679d), new NpgsqlTypes.NpgsqlPoint(x: 0.3735941044821047d, y: 0.5105188600162378d), new NpgsqlTypes.NpgsqlPoint(x: 0.05727019500988095d, y: 0.9499029417751722d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36213598893579046d, y: 0.8589043862246384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6063937223708069d, y: 0.0506471232834127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7887790093697927d, y: 0.2660104926740796d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05413370535276463d, y: 0.7602052098432028d), new NpgsqlTypes.NpgsqlPoint(x: 0.5917355580107819d, y: 0.5375969855217169d), new NpgsqlTypes.NpgsqlPoint(x: 0.11145865626177587d, y: 0.06871288438488066d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.66772701007675d, y: 0.9306713043557401d), new NpgsqlTypes.NpgsqlPoint(x: 0.47414905781713856d, y: 0.12178807440165818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6233285801730558d, y: 0.20573025553246294d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46720091235463335d, y: 0.10921371358478849d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249973760134573d, y: 0.8062424510009262d), new NpgsqlTypes.NpgsqlPoint(x: 0.07547486248609891d, y: 0.9506449690346389d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.001274278416045771d, y: 0.6062208897513248d), new NpgsqlTypes.NpgsqlPoint(x: 0.21784941889712883d, y: 0.5492413830636363d), new NpgsqlTypes.NpgsqlPoint(x: 0.03028135324163861d, y: 0.823917294173591d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10813642764155385d, y: 0.8083333332143655d), new NpgsqlTypes.NpgsqlPoint(x: 0.21753599481731423d, y: 0.5505520610706032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6488166927966841d, y: 0.9147803535371338d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9280533182400271d, y: 0.6597704571691647d), new NpgsqlTypes.NpgsqlPoint(x: 0.2279427873740606d, y: 0.10653816339352873d), new NpgsqlTypes.NpgsqlPoint(x: 0.35635972239009794d, y: 0.8207877602076534d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0643511516337385d, y: 0.9482614717129147d), new NpgsqlTypes.NpgsqlPoint(x: 0.07427334309019873d, y: 0.591437911732761d), new NpgsqlTypes.NpgsqlPoint(x: 0.37395794636872526d, y: 0.22599240862578296d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9219239017160485d, y: 0.5337752106271128d), new NpgsqlTypes.NpgsqlPoint(x: 0.8071352368226987d, y: 0.9738405442264405d), new NpgsqlTypes.NpgsqlPoint(x: 0.5996934727453117d, y: 0.6216861869435037d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3950022833858087d, y: 0.550818142561228d), new NpgsqlTypes.NpgsqlPoint(x: 0.964006978715793d, y: 0.3336315940678499d), new NpgsqlTypes.NpgsqlPoint(x: 0.20434925249254432d, y: 0.5272916194560218d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8556656161461696d, y: 0.13577428190528573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6753854754985218d, y: 0.166030446425113d), new NpgsqlTypes.NpgsqlPoint(x: 0.895882089731087d, y: 0.4754483533163376d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7591010272565485d, y: 0.7605730778815791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8001820729434641d, y: 0.16841271154056525d), new NpgsqlTypes.NpgsqlPoint(x: 0.9007946689481852d, y: 0.9666984551368549d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6237940503538923d, y: 0.13907060573771324d), new NpgsqlTypes.NpgsqlPoint(x: 0.3187599118512777d, y: 0.7340554668486934d), new NpgsqlTypes.NpgsqlPoint(x: 0.17819690495999418d, y: 0.34589065502840555d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3626419829434575d, y: 0.23139465659108216d), new NpgsqlTypes.NpgsqlPoint(x: 0.6183834753828065d, y: 0.22402777056897827d), new NpgsqlTypes.NpgsqlPoint(x: 0.9951539421108242d, y: 0.159361429431931d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5824436798526028d, y: 0.1073157802844269d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741696162572604d, y: 0.7254274080521393d), new NpgsqlTypes.NpgsqlPoint(x: 0.2665809826405454d, y: 0.8863540860216648d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07405899319548082d, y: 0.3543726736855253d), new NpgsqlTypes.NpgsqlPoint(x: 0.03110551115585769d, y: 0.9835805235391577d), new NpgsqlTypes.NpgsqlPoint(x: 0.506348821629844d, y: 0.11907628078513299d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47743553194729393d, y: 0.1526859636421264d), new NpgsqlTypes.NpgsqlPoint(x: 0.2011852669747599d, y: 0.9552222729003753d), new NpgsqlTypes.NpgsqlPoint(x: 0.4829187939514422d, y: 0.4045274020471009d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17613649747443116d, y: 0.33465064016766455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6525923917755607d, y: 0.2544960339024652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5329005253751384d, y: 0.9296679891291725d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.062153008828536804d, y: 0.4352227383969678d), new NpgsqlTypes.NpgsqlPoint(x: 0.6311809759215102d, y: 0.2684399782928085d), new NpgsqlTypes.NpgsqlPoint(x: 0.49703846844318267d, y: 0.06146035750189671d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13841452307199276d, y: 0.09675698413165901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3905411427513472d, y: 0.8688255488846239d), new NpgsqlTypes.NpgsqlPoint(x: 0.09047007800321016d, y: 0.5773103186114235d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38316847430958745d, y: 0.21256780738176395d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827522759301784d, y: 0.5815114130698487d), new NpgsqlTypes.NpgsqlPoint(x: 0.35963403630903845d, y: 0.7799044056541549d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7633721642124431d, y: 0.7377438913994406d), new NpgsqlTypes.NpgsqlPoint(x: 0.2005379950155649d, y: 0.24230357946659264d), new NpgsqlTypes.NpgsqlPoint(x: 0.7752378772524083d, y: 0.8508256273299147d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18659840657482818d, y: 0.13498428368962256d), new NpgsqlTypes.NpgsqlPoint(x: 0.04231407002025456d, y: 0.37797510032062465d), new NpgsqlTypes.NpgsqlPoint(x: 0.38098563690304765d, y: 0.09067730800507401d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.288171885520928d, y: 0.7510837423581206d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374110220159364d, y: 0.3651245822176714d), new NpgsqlTypes.NpgsqlPoint(x: 0.7765613664455389d, y: 0.36098801067752095d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18802530420168817d, y: 0.8618186090038695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6990228982500344d, y: 0.1994960783466897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8782472844130758d, y: 0.9574682991913881d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8108509674622748d, y: 0.20681656630164125d), new NpgsqlTypes.NpgsqlPoint(x: 0.344563799703142d, y: 0.1272665754023239d), new NpgsqlTypes.NpgsqlPoint(x: 0.42472416916116373d, y: 0.48891531489812157d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.627651632815941d, y: 0.5174504301215146d), new NpgsqlTypes.NpgsqlPoint(x: 0.28624046521148594d, y: 0.05071395832950565d), new NpgsqlTypes.NpgsqlPoint(x: 0.3526650991587126d, y: 0.9535286071124301d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.291964796061728d, y: 0.899589134585317d), new NpgsqlTypes.NpgsqlPoint(x: 0.7852799376269654d, y: 0.26693537402135625d), new NpgsqlTypes.NpgsqlPoint(x: 0.6493593032502534d, y: 0.31525108197980045d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8479871002372721d, y: 0.4257631481916798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7825585023542678d, y: 0.689771439582791d), new NpgsqlTypes.NpgsqlPoint(x: 0.6131519676018263d, y: 0.5552803733908909d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8585757787088443d, y: 0.25359877140713993d), new NpgsqlTypes.NpgsqlPoint(x: 0.35502241238025667d, y: 0.5433796695267064d), new NpgsqlTypes.NpgsqlPoint(x: 0.2694697210251429d, y: 0.536990537057061d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9988143489991246d, y: 0.051096339723955775d), new NpgsqlTypes.NpgsqlPoint(x: 0.6266395887872431d, y: 0.7933318132758655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6279761275557716d, y: 0.646694237528545d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28964095372769083d, y: 0.4462833901277622d), new NpgsqlTypes.NpgsqlPoint(x: 0.2679716866931683d, y: 0.785686145640101d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547546129956785d, y: 0.47311888177345673d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16759024899380826d, y: 0.9574298787228935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5142646937416648d, y: 0.5962062058922037d), new NpgsqlTypes.NpgsqlPoint(x: 0.08546549846256657d, y: 0.5550241854536337d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7056484802636023d, y: 0.5963092823874613d), new NpgsqlTypes.NpgsqlPoint(x: 0.10327293723974218d, y: 0.15676812856232658d), new NpgsqlTypes.NpgsqlPoint(x: 0.4488069363726581d, y: 0.4646009981932846d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47174417486694764d, y: 0.5838921607995199d), new NpgsqlTypes.NpgsqlPoint(x: 0.5011566156670367d, y: 0.08675463570577502d), new NpgsqlTypes.NpgsqlPoint(x: 0.028196302359037806d, y: 0.6918886063515669d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21433530356327735d, y: 0.9863128015555219d), new NpgsqlTypes.NpgsqlPoint(x: 0.8549350306373568d, y: 0.24764991470823128d), new NpgsqlTypes.NpgsqlPoint(x: 0.5518256127225294d, y: 0.7862495110557551d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8886798563414654d, y: 0.21763942712335627d), new NpgsqlTypes.NpgsqlPoint(x: 0.13746450075989736d, y: 0.9848116478814353d), new NpgsqlTypes.NpgsqlPoint(x: 0.9258772722015767d, y: 0.5515736520300067d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7343944520754381d, y: 0.6370784985202952d), new NpgsqlTypes.NpgsqlPoint(x: 0.2759119932586128d, y: 0.13549109061935327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5860013749788222d, y: 0.1274137282729182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6436015671850615d, y: 0.04643295220348653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6049092789770368d, y: 0.7556206998510846d), new NpgsqlTypes.NpgsqlPoint(x: 0.3661079695949929d, y: 0.3796151470724124d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8171792014849061d, y: 0.8177065663050299d), new NpgsqlTypes.NpgsqlPoint(x: 0.7610526240926088d, y: 0.7220535344568234d), new NpgsqlTypes.NpgsqlPoint(x: 0.593955837383539d, y: 0.5198049954615827d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9384721314990524d, y: 0.6826511248348461d), new NpgsqlTypes.NpgsqlPoint(x: 0.03466092134153287d, y: 0.4466108010828299d), new NpgsqlTypes.NpgsqlPoint(x: 0.36174808908994927d, y: 0.23977173039055d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.879473600739056d, y: 0.007233271726452051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8367415602267646d, y: 0.47626532129339727d), new NpgsqlTypes.NpgsqlPoint(x: 0.702240993656959d, y: 0.8241629699117973d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10652322814663773d, y: 0.7432455185636956d), new NpgsqlTypes.NpgsqlPoint(x: 0.618836707236667d, y: 0.7203956236294173d), new NpgsqlTypes.NpgsqlPoint(x: 0.21938243149313685d, y: 0.9536564456552474d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49897494089055117d, y: 0.5207846127213124d), new NpgsqlTypes.NpgsqlPoint(x: 0.06714568324025028d, y: 0.9503592598924404d), new NpgsqlTypes.NpgsqlPoint(x: 0.5446851535571609d, y: 0.33856336889219896d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.630100335385899d, y: 0.3193782916376209d), new NpgsqlTypes.NpgsqlPoint(x: 0.6339424913858864d, y: 0.20930200777191355d), new NpgsqlTypes.NpgsqlPoint(x: 0.020745517168936245d, y: 0.551920152426266d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22526801518678485d, y: 0.8700622211720871d), new NpgsqlTypes.NpgsqlPoint(x: 0.6922620021492382d, y: 0.9918513882627973d), new NpgsqlTypes.NpgsqlPoint(x: 0.9494352406448586d, y: 0.012193352298654703d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1404810997532846d, y: 0.6982669172080731d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675751222247599d, y: 0.2839413518952103d), new NpgsqlTypes.NpgsqlPoint(x: 0.5931799456438729d, y: 0.6480072172916531d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5482280579067836d, y: 0.9915648468957801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6758460702415843d, y: 0.15103823650367298d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565192313161003d, y: 0.3767305422666172d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8620093362444994d, y: 0.9693825081970475d), new NpgsqlTypes.NpgsqlPoint(x: 0.6715591175906932d, y: 0.24715633954042693d), new NpgsqlTypes.NpgsqlPoint(x: 0.3470678169612428d, y: 0.4509377552778291d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30058386626248845d, y: 0.8409494218423545d), new NpgsqlTypes.NpgsqlPoint(x: 0.1009486177526927d, y: 0.5738614186860258d), new NpgsqlTypes.NpgsqlPoint(x: 0.568773883371475d, y: 0.5428747106461254d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6838836440594384d, y: 0.7835793413311432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085442027548301d, y: 0.8557199361696988d), new NpgsqlTypes.NpgsqlPoint(x: 0.8039076755956692d, y: 0.06192594987392608d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.421691079823723d, y: 0.027154043571873898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5013681156707904d, y: 0.5508237303116678d), new NpgsqlTypes.NpgsqlPoint(x: 0.20918319378644545d, y: 0.6424105672789852d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.36744365520644506d, y: 0.15380777794868083d), new NpgsqlTypes.NpgsqlPoint(x: 0.06733958338406643d, y: 0.22586644643486753d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154085540020646d, y: 0.6493690073492857d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9689692832562289d, y: 0.273188516856372d), new NpgsqlTypes.NpgsqlPoint(x: 0.23468161381612873d, y: 0.6476558190078311d), new NpgsqlTypes.NpgsqlPoint(x: 0.6864234100337709d, y: 0.978575569520752d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15343009662359608d, y: 0.3773823543298215d), new NpgsqlTypes.NpgsqlPoint(x: 0.8472267220864108d, y: 0.7576528098779862d), new NpgsqlTypes.NpgsqlPoint(x: 0.16502399905168097d, y: 0.889353529249083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3782066487461755d, y: 0.643601669474524d), new NpgsqlTypes.NpgsqlPoint(x: 0.5294577485341273d, y: 0.7199356934770663d), new NpgsqlTypes.NpgsqlPoint(x: 0.021038100068296095d, y: 0.2964231260443536d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4823468167718844d, y: 0.8548771100929852d), new NpgsqlTypes.NpgsqlPoint(x: 0.18850500519696534d, y: 0.2907954193267386d), new NpgsqlTypes.NpgsqlPoint(x: 0.1804312866918213d, y: 0.3903234730812999d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24509901855890082d, y: 0.00078050430734522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5980243787084857d, y: 0.3307432904465486d), new NpgsqlTypes.NpgsqlPoint(x: 0.913689757856143d, y: 0.4650143900992373d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02295205413932022d, y: 0.647344921132454d), new NpgsqlTypes.NpgsqlPoint(x: 0.3648825298720768d, y: 0.6938652388768237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993501933045743d, y: 0.49271757112045234d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.425682424877847d, y: 0.7868063967896455d), new NpgsqlTypes.NpgsqlPoint(x: 0.6069743631044534d, y: 0.5518046963668072d), new NpgsqlTypes.NpgsqlPoint(x: 0.8364540314264752d, y: 0.9642442085781667d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09204553315587194d, y: 0.6700843331259576d), new NpgsqlTypes.NpgsqlPoint(x: 0.42647623865826756d, y: 0.6185787836831989d), new NpgsqlTypes.NpgsqlPoint(x: 0.7663439932756749d, y: 0.059571728300302995d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3157440569459522d, y: 0.690415820642085d), new NpgsqlTypes.NpgsqlPoint(x: 0.45852565078617913d, y: 0.24192870401327238d), new NpgsqlTypes.NpgsqlPoint(x: 0.47932941692021536d, y: 0.29126928358030624d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3968966503175887d, y: 0.2460412125117981d), new NpgsqlTypes.NpgsqlPoint(x: 0.4941907950334391d, y: 0.46640390321371694d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969660159274951d, y: 0.0684332097393574d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4616846884127205d, y: 0.17808964043729403d), new NpgsqlTypes.NpgsqlPoint(x: 0.9064120183698233d, y: 0.5131420909461816d), new NpgsqlTypes.NpgsqlPoint(x: 0.5782635642116698d, y: 0.6826968116103068d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8615156989224618d, y: 0.5866522586371669d), new NpgsqlTypes.NpgsqlPoint(x: 0.4286131302165095d, y: 0.524364074450446d), new NpgsqlTypes.NpgsqlPoint(x: 0.25757063233597877d, y: 0.6154308509360942d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.527928535286682d, y: 0.435479043674321d), new NpgsqlTypes.NpgsqlPoint(x: 0.1457348039536971d, y: 0.2406582041453691d), new NpgsqlTypes.NpgsqlPoint(x: 0.603376976603662d, y: 0.630889676446483d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.847563737307762d, y: 0.0617470526502516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7397050086554484d, y: 0.38093705984958814d), new NpgsqlTypes.NpgsqlPoint(x: 0.27136775457530193d, y: 0.0036302530592906557d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6387945760583595d, y: 0.50126789939368d), new NpgsqlTypes.NpgsqlPoint(x: 0.044159884462543486d, y: 0.7537341994520005d), new NpgsqlTypes.NpgsqlPoint(x: 0.7488993070049706d, y: 0.8139374993749287d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9236030768029071d, y: 0.1292883932616704d), new NpgsqlTypes.NpgsqlPoint(x: 0.9343143731683109d, y: 0.8893735236815316d), new NpgsqlTypes.NpgsqlPoint(x: 0.5656987670350215d, y: 0.7850639431971536d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7542900999990464d, y: 0.739018697288813d), new NpgsqlTypes.NpgsqlPoint(x: 0.0755641377384152d, y: 0.3066261856360233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7774210159387006d, y: 0.2457753637423381d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7762163478993944d, y: 0.4890641589051986d), new NpgsqlTypes.NpgsqlPoint(x: 0.612737986277341d, y: 0.025508009578743107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7721844880188207d, y: 0.014774124523219023d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21285164973657633d, y: 0.723841802346971d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266052297122395d, y: 0.35946189174905785d), new NpgsqlTypes.NpgsqlPoint(x: 0.359725329524026d, y: 0.43743659510708754d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13615678128135356d, y: 0.920373156333439d), new NpgsqlTypes.NpgsqlPoint(x: 0.38203693952041884d, y: 0.5774901999675851d), new NpgsqlTypes.NpgsqlPoint(x: 0.6855496574558269d, y: 0.019437885643486474d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6027154067903476d, y: 0.7503455236168339d), new NpgsqlTypes.NpgsqlPoint(x: 0.816376043513227d, y: 0.1707919267945308d), new NpgsqlTypes.NpgsqlPoint(x: 0.4067276442428024d, y: 0.17739394861578905d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7581090176508692d, y: 0.24475506233960875d), new NpgsqlTypes.NpgsqlPoint(x: 0.6192860585379242d, y: 0.2523468716014665d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624784743472218d, y: 0.22140070483761687d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1561134061151569d, y: 0.9694857382423716d), new NpgsqlTypes.NpgsqlPoint(x: 0.3326735751674703d, y: 0.014302726141537714d), new NpgsqlTypes.NpgsqlPoint(x: 0.718980146782323d, y: 0.6217278110778838d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5379137592432258d, y: 0.0034052725636786185d), new NpgsqlTypes.NpgsqlPoint(x: 0.3256781520935811d, y: 0.42002279798188447d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793324821504276d, y: 0.09400290326780614d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4747136575044363d, y: 0.7477029706767714d), new NpgsqlTypes.NpgsqlPoint(x: 0.003245748048516961d, y: 0.23381539612000313d), new NpgsqlTypes.NpgsqlPoint(x: 0.48074600269475487d, y: 0.996794286656472d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3918936364133162d, y: 0.10781039005726256d), new NpgsqlTypes.NpgsqlPoint(x: 0.1517362259492333d, y: 0.7260570449440474d), new NpgsqlTypes.NpgsqlPoint(x: 0.13092496872344017d, y: 0.29003766476327797d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5498090725532737d, y: 0.8776633654101148d), new NpgsqlTypes.NpgsqlPoint(x: 0.07734719538936896d, y: 0.004862604034192031d), new NpgsqlTypes.NpgsqlPoint(x: 0.05256215421542543d, y: 0.5108924591902203d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7475352542405028d, y: 0.23940318374209835d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188802884691601d, y: 0.4788131121545276d), new NpgsqlTypes.NpgsqlPoint(x: 0.20193826164717377d, y: 0.7119157483392606d)), }, }, },
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4501185524287228d, y: 0.8751698743398024d), new NpgsqlTypes.NpgsqlPoint(x: 0.11197032441819288d, y: 0.12250280828233506d), new NpgsqlTypes.NpgsqlPoint(x: 0.9439366743684033d, y: 0.17683633800851428d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7721550883651035d, y: 0.8452039049831568d), new NpgsqlTypes.NpgsqlPoint(x: 0.06262852626948956d, y: 0.9400837869805211d), new NpgsqlTypes.NpgsqlPoint(x: 0.31344543586819784d, y: 0.6687661645702077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.947811285608826d, y: 0.3770304892278793d), new NpgsqlTypes.NpgsqlPoint(x: 0.45346567073492894d, y: 0.8441519501360158d), new NpgsqlTypes.NpgsqlPoint(x: 0.6127576917814854d, y: 0.5915352953878591d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34166571172022275d, y: 0.7003976693849073d), new NpgsqlTypes.NpgsqlPoint(x: 0.5781400255477599d, y: 0.5452526926691563d), new NpgsqlTypes.NpgsqlPoint(x: 0.045638775446632196d, y: 0.38348311179533345d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2999392411582681d, y: 0.5375478675725683d), new NpgsqlTypes.NpgsqlPoint(x: 0.7266804386517773d, y: 0.9080086003392766d), new NpgsqlTypes.NpgsqlPoint(x: 0.13469018252748188d, y: 0.5608188028802376d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.408385074318694d, y: 0.08988109532992894d), new NpgsqlTypes.NpgsqlPoint(x: 0.05753689880443602d, y: 0.384236151586574d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332797167722223d, y: 0.7410238305361538d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8744188811663107d, y: 0.19784462898692534d), new NpgsqlTypes.NpgsqlPoint(x: 0.35473913479658414d, y: 0.07251945800438353d), new NpgsqlTypes.NpgsqlPoint(x: 0.07738425139763472d, y: 0.825449902837242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.469109711877039d, y: 0.8496240218128984d), new NpgsqlTypes.NpgsqlPoint(x: 0.5708566400995434d, y: 0.22817359315151076d), new NpgsqlTypes.NpgsqlPoint(x: 0.8812498811629841d, y: 0.7376273499735108d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2041178738206918d, y: 0.9660721357958744d), new NpgsqlTypes.NpgsqlPoint(x: 0.41416880455968597d, y: 0.8374195812272879d), new NpgsqlTypes.NpgsqlPoint(x: 0.895434001582859d, y: 0.5093386819773453d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06819817397176409d, y: 0.29702216141948956d), new NpgsqlTypes.NpgsqlPoint(x: 0.17156233355309514d, y: 0.31608482120441816d), new NpgsqlTypes.NpgsqlPoint(x: 0.24952060551853406d, y: 0.393575773840672d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07056584678467237d, y: 0.9697424338910429d), new NpgsqlTypes.NpgsqlPoint(x: 0.6566395310629606d, y: 0.7304264210181703d), new NpgsqlTypes.NpgsqlPoint(x: 0.17876896966599887d, y: 0.9449652820460793d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46707096885485233d, y: 0.5124074127485085d), new NpgsqlTypes.NpgsqlPoint(x: 0.45502424682721265d, y: 0.6761884293294471d), new NpgsqlTypes.NpgsqlPoint(x: 0.3733472607466969d, y: 0.6570573838437687d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5208854922267158d, y: 0.7623867309685242d), new NpgsqlTypes.NpgsqlPoint(x: 0.4640182960396605d, y: 0.45887313217513437d), new NpgsqlTypes.NpgsqlPoint(x: 0.6506187992377711d, y: 0.9938636653540337d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5987474977137665d, y: 0.3365620918210577d), new NpgsqlTypes.NpgsqlPoint(x: 0.1952516241120592d, y: 0.32764112170414916d), new NpgsqlTypes.NpgsqlPoint(x: 0.8519401450690336d, y: 0.25875905634341656d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9808911156673623d, y: 0.8409122552550047d), new NpgsqlTypes.NpgsqlPoint(x: 0.5167034039886046d, y: 0.5100660209946397d), new NpgsqlTypes.NpgsqlPoint(x: 0.756861612211157d, y: 0.19274314920248992d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8515580126199729d, y: 0.11714445625218184d), new NpgsqlTypes.NpgsqlPoint(x: 0.7313125845595034d, y: 0.05499542288971626d), new NpgsqlTypes.NpgsqlPoint(x: 0.35747452649743217d, y: 0.4384884994220455d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5500540046632378d, y: 0.5628544330345185d), new NpgsqlTypes.NpgsqlPoint(x: 0.5101780495694622d, y: 0.6446054069508865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6379103843470487d, y: 0.9918897777546642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28952833035152525d, y: 0.9151388215208155d), new NpgsqlTypes.NpgsqlPoint(x: 0.05505654524204939d, y: 0.7120009717829625d), new NpgsqlTypes.NpgsqlPoint(x: 0.039669674433864155d, y: 0.27730148913338926d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9903169757594836d, y: 0.8711536929693047d), new NpgsqlTypes.NpgsqlPoint(x: 0.39213903726811083d, y: 0.2580155685841192d), new NpgsqlTypes.NpgsqlPoint(x: 0.10107309031286438d, y: 0.8200547042361577d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21093286689478563d, y: 0.9599595928870874d), new NpgsqlTypes.NpgsqlPoint(x: 0.06572777485943149d, y: 0.6200558322608871d), new NpgsqlTypes.NpgsqlPoint(x: 0.692272866871038d, y: 0.4263894210935436d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9430030347864328d, y: 0.28606499316835854d), new NpgsqlTypes.NpgsqlPoint(x: 0.047692901487568995d, y: 0.7462739015925409d), new NpgsqlTypes.NpgsqlPoint(x: 0.3045116182094695d, y: 0.7796723245613503d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.016056985563117188d, y: 0.5995029274327265d), new NpgsqlTypes.NpgsqlPoint(x: 0.25006980065868756d, y: 0.4678752876640213d), new NpgsqlTypes.NpgsqlPoint(x: 0.36774165067627496d, y: 0.42878595451027357d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5300254541304376d, y: 0.027656207499398455d), new NpgsqlTypes.NpgsqlPoint(x: 0.19680573862414008d, y: 0.021408725821828622d), new NpgsqlTypes.NpgsqlPoint(x: 0.1469306556524661d, y: 0.648450985441279d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5427072526531352d, y: 0.8217884978179525d), new NpgsqlTypes.NpgsqlPoint(x: 0.8682677440455274d, y: 0.5356054059043507d), new NpgsqlTypes.NpgsqlPoint(x: 0.33167042354236675d, y: 0.5935994243023028d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.911662141742121d, y: 0.6561498969330904d), new NpgsqlTypes.NpgsqlPoint(x: 0.1619827689806217d, y: 0.7976456371662545d), new NpgsqlTypes.NpgsqlPoint(x: 0.26348792865629456d, y: 0.4370811685032976d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30104379022336414d, y: 0.8022957055526253d), new NpgsqlTypes.NpgsqlPoint(x: 0.29585709121368076d, y: 0.9285342598409961d), new NpgsqlTypes.NpgsqlPoint(x: 0.796931739173994d, y: 0.012536560210300363d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09214825281166283d, y: 0.9529089538404288d), new NpgsqlTypes.NpgsqlPoint(x: 0.37829019956005316d, y: 0.45936063577176645d), new NpgsqlTypes.NpgsqlPoint(x: 0.7549990076288107d, y: 0.07422098359179585d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 154,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6230291690935659d, y: 0.9001561859098868d), new NpgsqlTypes.NpgsqlPoint(x: 0.09404883397099717d, y: 0.41966319970362653d), new NpgsqlTypes.NpgsqlPoint(x: 0.4072600891935334d, y: 0.8739078569381222d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8106527889066029d, y: 0.7949141497599417d), new NpgsqlTypes.NpgsqlPoint(x: 0.19933283949281966d, y: 0.10019074688943064d), new NpgsqlTypes.NpgsqlPoint(x: 0.06349027071561453d, y: 0.24540798358393412d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4167444135736088d, y: 0.5944986906683368d), new NpgsqlTypes.NpgsqlPoint(x: 0.07876990759953861d, y: 0.019120086037686113d), new NpgsqlTypes.NpgsqlPoint(x: 0.7653799475950467d, y: 0.25894582703771396d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49567424900687107d, y: 0.3058328977258108d), new NpgsqlTypes.NpgsqlPoint(x: 0.01561297419506591d, y: 0.7139542347719052d), new NpgsqlTypes.NpgsqlPoint(x: 0.489358544820821d, y: 0.2015964228256658d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6777501437275125d, y: 0.9186607829171608d), new NpgsqlTypes.NpgsqlPoint(x: 0.2266313295474055d, y: 0.13192550209473186d), new NpgsqlTypes.NpgsqlPoint(x: 0.728679358607961d, y: 0.9214592275208454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46233816107368464d, y: 0.7815746001223828d), new NpgsqlTypes.NpgsqlPoint(x: 0.27348907032331715d, y: 0.2114323047644372d), new NpgsqlTypes.NpgsqlPoint(x: 0.21061001043668748d, y: 0.2878857768613433d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14704331790819336d, y: 0.7826956198828582d), new NpgsqlTypes.NpgsqlPoint(x: 0.6589171252823544d, y: 0.8284756368416227d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416765986645146d, y: 0.06406104954247893d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6402331856902965d, y: 0.03467803853292861d), new NpgsqlTypes.NpgsqlPoint(x: 0.4989480098299991d, y: 0.9625266220650174d), new NpgsqlTypes.NpgsqlPoint(x: 0.035191918772532915d, y: 0.11982906331460974d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.925049455178122d, y: 0.9723182776682109d), new NpgsqlTypes.NpgsqlPoint(x: 0.6789057418180003d, y: 0.682168110813453d), new NpgsqlTypes.NpgsqlPoint(x: 0.15896599699362202d, y: 0.06835498099359782d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33515505120834777d, y: 0.047846128872552685d), new NpgsqlTypes.NpgsqlPoint(x: 0.834840330222129d, y: 0.246414199589703d), new NpgsqlTypes.NpgsqlPoint(x: 0.5693830139217687d, y: 0.8745760147440887d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3992321631306348d, y: 0.6068017181353574d), new NpgsqlTypes.NpgsqlPoint(x: 0.5300052876783619d, y: 0.26779023760279985d), new NpgsqlTypes.NpgsqlPoint(x: 0.32126122521298706d, y: 0.9799552977808166d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9982810467081883d, y: 0.3945592009128627d), new NpgsqlTypes.NpgsqlPoint(x: 0.657951116052553d, y: 0.6776006700355317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5312557801023636d, y: 0.013074764627391877d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7696867784149757d, y: 0.5455067759082479d), new NpgsqlTypes.NpgsqlPoint(x: 0.9159538783201631d, y: 0.513041317366547d), new NpgsqlTypes.NpgsqlPoint(x: 0.47511671808317346d, y: 0.023846793885084594d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8170797374801039d, y: 0.40589254513445716d), new NpgsqlTypes.NpgsqlPoint(x: 0.49797199093638245d, y: 0.1200441850092614d), new NpgsqlTypes.NpgsqlPoint(x: 0.0023958566398992742d, y: 0.39903878094510326d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6855658287928068d, y: 0.8235631370160101d), new NpgsqlTypes.NpgsqlPoint(x: 0.04928193809024184d, y: 0.6924486950010761d), new NpgsqlTypes.NpgsqlPoint(x: 0.8594299786494669d, y: 0.29053091224203154d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9637093889240421d, y: 0.850055902240743d), new NpgsqlTypes.NpgsqlPoint(x: 0.24435695334926433d, y: 0.07923200934441943d), new NpgsqlTypes.NpgsqlPoint(x: 0.04903884954135662d, y: 0.06308376649099123d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8389710326458727d, y: 0.19390321104866803d), new NpgsqlTypes.NpgsqlPoint(x: 0.2431089402996479d, y: 0.6614181108146261d), new NpgsqlTypes.NpgsqlPoint(x: 0.38274331904578396d, y: 0.01411516601321594d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31315671750013596d, y: 0.6751020329846438d), new NpgsqlTypes.NpgsqlPoint(x: 0.49718092107905576d, y: 0.15893708790906835d), new NpgsqlTypes.NpgsqlPoint(x: 0.1218807999929794d, y: 0.15490219972638308d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20837840283574283d, y: 0.5587617621297231d), new NpgsqlTypes.NpgsqlPoint(x: 0.6203268042108091d, y: 0.5628075095945976d), new NpgsqlTypes.NpgsqlPoint(x: 0.011888554081767255d, y: 0.8568538784674156d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9033733036696894d, y: 0.4068428615233528d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855653230000193d, y: 0.07430310537602636d), new NpgsqlTypes.NpgsqlPoint(x: 0.7626504312626164d, y: 0.06995366160757999d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12268354195257725d, y: 0.46035933445356736d), new NpgsqlTypes.NpgsqlPoint(x: 0.1686267806318391d, y: 0.8724147467599301d), new NpgsqlTypes.NpgsqlPoint(x: 0.9155278623865788d, y: 0.021108958419412294d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4301769503427092d, y: 0.6655928473484344d), new NpgsqlTypes.NpgsqlPoint(x: 0.3076972149150947d, y: 0.3438767490139182d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832743526256793d, y: 0.7063616109617206d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21004153760775224d, y: 0.9837413980833567d), new NpgsqlTypes.NpgsqlPoint(x: 0.3974464439679769d, y: 0.9570482498671405d), new NpgsqlTypes.NpgsqlPoint(x: 0.9610873036637675d, y: 0.5858838724230859d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8742272991244863d, y: 0.346564502309474d), new NpgsqlTypes.NpgsqlPoint(x: 0.15496885176497854d, y: 0.044095628305695356d), new NpgsqlTypes.NpgsqlPoint(x: 0.05337188566270412d, y: 0.09545567547011669d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5730392778050517d, y: 0.30777770073256205d), new NpgsqlTypes.NpgsqlPoint(x: 0.1468516439842784d, y: 0.3729677566238224d), new NpgsqlTypes.NpgsqlPoint(x: 0.8017858527472159d, y: 0.3063373962171734d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6781662238537275d, y: 0.5872582682566287d), new NpgsqlTypes.NpgsqlPoint(x: 0.7382513003477952d, y: 0.8441012178109182d), new NpgsqlTypes.NpgsqlPoint(x: 0.15556895117164726d, y: 0.8630266332564565d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5074181921921198d, y: 0.308315990255576d), new NpgsqlTypes.NpgsqlPoint(x: 0.8661772744425671d, y: 0.9084423716778927d), new NpgsqlTypes.NpgsqlPoint(x: 0.3258724973620647d, y: 0.5020194188082064d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 162,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3702323228096218d, y: 0.14287530398590942d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555808882574124d, y: 0.015253689851911001d), new NpgsqlTypes.NpgsqlPoint(x: 0.8408163651393578d, y: 0.041046923446750094d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3428060919746241d, y: 0.8789793764940704d), new NpgsqlTypes.NpgsqlPoint(x: 0.6940977078061431d, y: 0.8667027113376804d), new NpgsqlTypes.NpgsqlPoint(x: 0.9288110205983278d, y: 0.8547918573315254d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4316054002648292d, y: 0.7492436483242384d), new NpgsqlTypes.NpgsqlPoint(x: 0.2049949472990985d, y: 0.9930169853588995d), new NpgsqlTypes.NpgsqlPoint(x: 0.048960926006646255d, y: 0.9538080950649985d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3509835462132712d, y: 0.32195749926992767d), new NpgsqlTypes.NpgsqlPoint(x: 0.2340542717522135d, y: 0.44525429546284334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3555720201931616d, y: 0.9951484015411483d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06632131728340096d, y: 0.1784205852899191d), new NpgsqlTypes.NpgsqlPoint(x: 0.11363705570205151d, y: 0.0786695149360288d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098208676815664d, y: 0.9032679924305315d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9039446161196173d, y: 0.29665519934245554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9713416245233224d, y: 0.1697472106684842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8709183501921552d, y: 0.38161565059767766d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3843774829922434d, y: 0.08037432208389172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763716272039687d, y: 0.21976218803979286d), new NpgsqlTypes.NpgsqlPoint(x: 0.5014478129473756d, y: 0.9854105964502884d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04794152798410778d, y: 0.2688776999765409d), new NpgsqlTypes.NpgsqlPoint(x: 0.5895164478602234d, y: 0.15061599947193394d), new NpgsqlTypes.NpgsqlPoint(x: 0.3422366980977056d, y: 0.7456818222300399d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6753351899599334d, y: 0.5991212206403144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7639893253650561d, y: 0.9437196461629651d), new NpgsqlTypes.NpgsqlPoint(x: 0.23910840564220415d, y: 0.7119756387617501d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811496862667039d, y: 0.8079441868881896d), new NpgsqlTypes.NpgsqlPoint(x: 0.24427592175815938d, y: 0.9571334803029037d), new NpgsqlTypes.NpgsqlPoint(x: 0.3474329113718193d, y: 0.5748440687496429d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9062487284083465d, y: 0.9276699430698581d), new NpgsqlTypes.NpgsqlPoint(x: 0.8175662605474041d, y: 0.9743637667822969d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582416106961765d, y: 0.04392255570223058d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2705734670029186d, y: 0.14151526836049d), new NpgsqlTypes.NpgsqlPoint(x: 0.1628436930829168d, y: 0.6372029310975693d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237563987008796d, y: 0.26734688136430196d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9410790728086857d, y: 0.2681611638973145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9355056866095015d, y: 0.9441048986640499d), new NpgsqlTypes.NpgsqlPoint(x: 0.6701991337808798d, y: 0.5583061701252889d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.040213778157266566d, y: 0.7797941500032175d), new NpgsqlTypes.NpgsqlPoint(x: 0.7369533213108838d, y: 0.6973494777818436d), new NpgsqlTypes.NpgsqlPoint(x: 0.6417134739928179d, y: 0.5778440413071423d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5726908079781214d, y: 0.491378956544539d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617831913093063d, y: 0.16477935951720457d), new NpgsqlTypes.NpgsqlPoint(x: 0.7817398924227559d, y: 0.5811548984533139d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21884303060426125d, y: 0.6722218223904075d), new NpgsqlTypes.NpgsqlPoint(x: 0.4573558720601325d, y: 0.9145798634973593d), new NpgsqlTypes.NpgsqlPoint(x: 0.28613418788844225d, y: 0.9852306592091711d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7255395595583318d, y: 0.41027246962478936d), new NpgsqlTypes.NpgsqlPoint(x: 0.22869515185201894d, y: 0.8333700249994905d), new NpgsqlTypes.NpgsqlPoint(x: 0.33415985997365527d, y: 0.10647756060340186d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9900942770188049d, y: 0.5802584418928631d), new NpgsqlTypes.NpgsqlPoint(x: 0.8558594861127308d, y: 0.5340938467262338d), new NpgsqlTypes.NpgsqlPoint(x: 0.07207726971999284d, y: 0.45139727435886245d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1640219555091823d, y: 0.5838234961408366d), new NpgsqlTypes.NpgsqlPoint(x: 0.11804958138419552d, y: 0.8012535071904614d), new NpgsqlTypes.NpgsqlPoint(x: 0.6010857171504186d, y: 0.25662692503251083d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3839110021412606d, y: 0.9208944628709086d), new NpgsqlTypes.NpgsqlPoint(x: 0.9285304979863366d, y: 0.17585152866684772d), new NpgsqlTypes.NpgsqlPoint(x: 0.10879311070698428d, y: 0.8618573605876102d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9014857762706133d, y: 0.6871271230801065d), new NpgsqlTypes.NpgsqlPoint(x: 0.09323566720973941d, y: 0.4870989843937136d), new NpgsqlTypes.NpgsqlPoint(x: 0.5610391697512801d, y: 0.7035442361190969d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13837779613049817d, y: 0.07940821967434719d), new NpgsqlTypes.NpgsqlPoint(x: 0.33392834358196677d, y: 0.4866396777515909d), new NpgsqlTypes.NpgsqlPoint(x: 0.9948956730663505d, y: 0.8980976172498232d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7620724880168125d, y: 0.33400824168473897d), new NpgsqlTypes.NpgsqlPoint(x: 0.0034098060400964414d, y: 0.060158349062629735d), new NpgsqlTypes.NpgsqlPoint(x: 0.09721854874089464d, y: 0.42742330344882806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.602289210445976d, y: 0.8562981283658644d), new NpgsqlTypes.NpgsqlPoint(x: 0.7782184861671148d, y: 0.6868224313858949d), new NpgsqlTypes.NpgsqlPoint(x: 0.17876533268271255d, y: 0.08861995572389259d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2576248931989894d, y: 0.18444602497973084d), new NpgsqlTypes.NpgsqlPoint(x: 0.8426119108874255d, y: 0.2920440552799506d), new NpgsqlTypes.NpgsqlPoint(x: 0.4315062701144843d, y: 0.9693677506848979d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40484861526588156d, y: 0.7365569775016172d), new NpgsqlTypes.NpgsqlPoint(x: 0.5118869674225268d, y: 0.3997041280928597d), new NpgsqlTypes.NpgsqlPoint(x: 0.12156829747592979d, y: 0.8131997280740744d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.614984198365066d, y: 0.5761070239720583d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953444771616154d, y: 0.06920986398217344d), new NpgsqlTypes.NpgsqlPoint(x: 0.01161425529218063d, y: 0.7058246067187428d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5531261713237601d, y: 0.7537631001824118d), new NpgsqlTypes.NpgsqlPoint(x: 0.9797746450112378d, y: 0.9256611273143227d), new NpgsqlTypes.NpgsqlPoint(x: 0.3878838617302962d, y: 0.883152948398424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6598174194443679d, y: 0.9907500974495327d), new NpgsqlTypes.NpgsqlPoint(x: 0.8855939413761238d, y: 0.21615250056055868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4084087205756839d, y: 0.20772125988593737d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06425602958117904d, y: 0.5966936617922681d), new NpgsqlTypes.NpgsqlPoint(x: 0.811863681204838d, y: 0.3032206281590625d), new NpgsqlTypes.NpgsqlPoint(x: 0.37198761792722124d, y: 0.19997107401532177d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.448799682608374d, y: 0.1307166675518865d), new NpgsqlTypes.NpgsqlPoint(x: 0.36253262666577823d, y: 0.24736193012343033d), new NpgsqlTypes.NpgsqlPoint(x: 0.30003353587263404d, y: 0.3241634519691141d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11680727171222183d, y: 0.7404129737175448d), new NpgsqlTypes.NpgsqlPoint(x: 0.4077924558079671d, y: 0.20395681551319256d), new NpgsqlTypes.NpgsqlPoint(x: 0.4859123643763643d, y: 0.267230684364008d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6244340467753915d, y: 0.7837241651875726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9019195766556224d, y: 0.25022578691104636d), new NpgsqlTypes.NpgsqlPoint(x: 0.4988376219542403d, y: 0.003825385701856754d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37538662819926816d, y: 0.8725989716632778d), new NpgsqlTypes.NpgsqlPoint(x: 0.9754241731664265d, y: 0.7188938009462513d), new NpgsqlTypes.NpgsqlPoint(x: 0.2713186359358343d, y: 0.03039613505667682d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8362178372085416d, y: 0.12387788190386195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5247035568198971d, y: 0.4839324501172666d), new NpgsqlTypes.NpgsqlPoint(x: 0.3581048251465162d, y: 0.4275806680920765d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.703220345389055d, y: 0.31237324510053344d), new NpgsqlTypes.NpgsqlPoint(x: 0.4624532543724035d, y: 0.6813976731802742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4099105674213487d, y: 0.13414329538708314d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5076453490896661d, y: 0.08742308166350155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225269347642242d, y: 0.5329735236702816d), new NpgsqlTypes.NpgsqlPoint(x: 0.6986326800774255d, y: 0.29936353331052756d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4773729750038319d, y: 0.4523569734875911d), new NpgsqlTypes.NpgsqlPoint(x: 0.5580581976841219d, y: 0.6566998281026465d), new NpgsqlTypes.NpgsqlPoint(x: 0.9392178341229384d, y: 0.18929744521958958d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5052413646300836d, y: 0.5256323597703423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7002607998176367d, y: 0.9194847635847733d), new NpgsqlTypes.NpgsqlPoint(x: 0.7773701464509276d, y: 0.2833800683893293d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40883811827858596d, y: 0.4853772825366698d), new NpgsqlTypes.NpgsqlPoint(x: 0.6609375846214028d, y: 0.9341142020476931d), new NpgsqlTypes.NpgsqlPoint(x: 0.6171765068097339d, y: 0.824430446469541d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01562241005306042d, y: 0.9607116724522938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9775731713246152d, y: 0.054322504820552786d), new NpgsqlTypes.NpgsqlPoint(x: 0.3849375753798109d, y: 0.48287726461072955d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08453697062266075d, y: 0.7614560125010271d), new NpgsqlTypes.NpgsqlPoint(x: 0.7094836516438588d, y: 0.21870794771968416d), new NpgsqlTypes.NpgsqlPoint(x: 0.714318367853537d, y: 0.7875225754631469d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3827367434007791d, y: 0.7529039525457399d), new NpgsqlTypes.NpgsqlPoint(x: 0.07381529584020752d, y: 0.5784385584108428d), new NpgsqlTypes.NpgsqlPoint(x: 0.1316889813015234d, y: 0.5307038449188715d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9341451895913536d, y: 0.6862901389239171d), new NpgsqlTypes.NpgsqlPoint(x: 0.20180652305839475d, y: 0.9578802105575479d), new NpgsqlTypes.NpgsqlPoint(x: 0.1558289764947638d, y: 0.9543463411137751d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6844353754025844d, y: 0.08945267002710866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8889604883006967d, y: 0.13152317688958315d), new NpgsqlTypes.NpgsqlPoint(x: 0.7059772769337697d, y: 0.3997608362681867d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8948658370738646d, y: 0.24087754786103444d), new NpgsqlTypes.NpgsqlPoint(x: 0.5723173805985661d, y: 0.010424216851407153d), new NpgsqlTypes.NpgsqlPoint(x: 0.7400717487941684d, y: 0.768655863250391d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25641343532513805d, y: 0.4898591386606014d), new NpgsqlTypes.NpgsqlPoint(x: 0.4031497375825247d, y: 0.9797396618228207d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969901584731931d, y: 0.9590537334529273d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06199818266724588d, y: 0.22052747072630052d), new NpgsqlTypes.NpgsqlPoint(x: 0.5282375845077008d, y: 0.5328780354460598d), new NpgsqlTypes.NpgsqlPoint(x: 0.8825946732224523d, y: 0.8998200197355554d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.566517769452221d, y: 0.7386951947123304d), new NpgsqlTypes.NpgsqlPoint(x: 0.8866715629457679d, y: 0.9899974283074148d), new NpgsqlTypes.NpgsqlPoint(x: 0.0863327186233176d, y: 0.6019003279675982d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025725827977399973d, y: 0.6119442894026842d), new NpgsqlTypes.NpgsqlPoint(x: 0.06359350512562367d, y: 0.404557271838736d), new NpgsqlTypes.NpgsqlPoint(x: 0.7332549686873344d, y: 0.6073103119462888d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12015117405652065d, y: 0.4704443886394789d), new NpgsqlTypes.NpgsqlPoint(x: 0.252960392714515d, y: 0.7058803868419932d), new NpgsqlTypes.NpgsqlPoint(x: 0.31913523816787404d, y: 0.6370931494433414d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6085718571784031d, y: 0.2175720932542774d), new NpgsqlTypes.NpgsqlPoint(x: 0.6620947552123193d, y: 0.16260909267422652d), new NpgsqlTypes.NpgsqlPoint(x: 0.8649235271145592d, y: 0.8049513862542216d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44382286373999524d, y: 0.588320187755527d), new NpgsqlTypes.NpgsqlPoint(x: 0.3666444260098345d, y: 0.5980364383199153d), new NpgsqlTypes.NpgsqlPoint(x: 0.2896341916479951d, y: 0.5645306995575253d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12775442223097744d, y: 0.18689561985657344d), new NpgsqlTypes.NpgsqlPoint(x: 0.8643456349192015d, y: 0.6519713123782349d), new NpgsqlTypes.NpgsqlPoint(x: 0.044701984163526d, y: 0.45607971189062746d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8836532042394647d, y: 0.16733533783386745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5855572539706927d, y: 0.7626991652404733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4706074010686142d, y: 0.8815436402325457d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4046056350207563d, y: 0.017564724433279277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5441256169086393d, y: 0.23193939520019213d), new NpgsqlTypes.NpgsqlPoint(x: 0.7674635127799103d, y: 0.09113670828940301d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8445802362025687d, y: 0.07854691245611922d), new NpgsqlTypes.NpgsqlPoint(x: 0.4998319404463619d, y: 0.7050486800901217d), new NpgsqlTypes.NpgsqlPoint(x: 0.9183798726365037d, y: 0.6510389785341729d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30627033732706743d, y: 0.6032543132310354d), new NpgsqlTypes.NpgsqlPoint(x: 0.7833276954363646d, y: 0.931850511001201d), new NpgsqlTypes.NpgsqlPoint(x: 0.6486163209193627d, y: 0.5662360365311552d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47701232926467374d, y: 0.45364993038213375d), new NpgsqlTypes.NpgsqlPoint(x: 0.7035949181009835d, y: 0.9452954457976614d), new NpgsqlTypes.NpgsqlPoint(x: 0.4056961028209657d, y: 0.9744348802757358d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5718138684305322d, y: 0.3670022151874005d), new NpgsqlTypes.NpgsqlPoint(x: 0.29174740445582836d, y: 0.7919543108592975d), new NpgsqlTypes.NpgsqlPoint(x: 0.9616536275746171d, y: 0.8677155890785331d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7506370314192342d, y: 0.29231626631430097d), new NpgsqlTypes.NpgsqlPoint(x: 0.69813780546083d, y: 0.0033687776449405904d), new NpgsqlTypes.NpgsqlPoint(x: 0.6565408500233421d, y: 0.25843975772190886d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2240033544673281d, y: 0.7688843551010952d), new NpgsqlTypes.NpgsqlPoint(x: 0.2259962141282178d, y: 0.9174552707104658d), new NpgsqlTypes.NpgsqlPoint(x: 0.4500125651072824d, y: 0.022883080746392115d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30586535051322217d, y: 0.9222728330962043d), new NpgsqlTypes.NpgsqlPoint(x: 0.31985541293650943d, y: 0.6434543302982678d), new NpgsqlTypes.NpgsqlPoint(x: 0.613680890112809d, y: 0.779571511549614d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6096421532786204d, y: 0.24087633822818055d), new NpgsqlTypes.NpgsqlPoint(x: 0.9497612760042142d, y: 0.6060729193578978d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234774248181197d, y: 0.09579095436791019d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38291004853239574d, y: 0.7713588615515922d), new NpgsqlTypes.NpgsqlPoint(x: 0.7695170093201366d, y: 0.9625181992633063d), new NpgsqlTypes.NpgsqlPoint(x: 0.365881953174398d, y: 0.18082561912938433d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5597235651026237d, y: 0.7330046240841298d), new NpgsqlTypes.NpgsqlPoint(x: 0.18535820953364612d, y: 0.29517332489675707d), new NpgsqlTypes.NpgsqlPoint(x: 0.0493316351921439d, y: 0.5967584646172077d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881409525610793d, y: 0.9918154242217184d), new NpgsqlTypes.NpgsqlPoint(x: 0.0018120070024130186d, y: 0.6458589074143728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7050368815260595d, y: 0.9318618334564095d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9134828122748867d, y: 0.882831850233844d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489477310204387d, y: 0.41094993493057297d), new NpgsqlTypes.NpgsqlPoint(x: 0.17548128099173566d, y: 0.039518044465885915d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6955269960173023d, y: 0.7277477742715845d), new NpgsqlTypes.NpgsqlPoint(x: 0.47464627038572105d, y: 0.6359562738273874d), new NpgsqlTypes.NpgsqlPoint(x: 0.830529672469642d, y: 0.5107099933729118d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04001867669693382d, y: 0.14993391159049474d), new NpgsqlTypes.NpgsqlPoint(x: 0.2899951518537228d, y: 0.9029466652792977d), new NpgsqlTypes.NpgsqlPoint(x: 0.31844306790870625d, y: 0.5086406640078277d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.825095398915879d, y: 0.9542602282607285d), new NpgsqlTypes.NpgsqlPoint(x: 0.28606295862214315d, y: 0.4613232907078221d), new NpgsqlTypes.NpgsqlPoint(x: 0.22134719332959274d, y: 0.7794431406204257d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3108376125464103d, y: 0.1077063927108508d), new NpgsqlTypes.NpgsqlPoint(x: 0.7390170723414028d, y: 0.5979740589130927d), new NpgsqlTypes.NpgsqlPoint(x: 0.11776724834790586d, y: 0.035159843535599866d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7274865219896626d, y: 0.16109088634252178d), new NpgsqlTypes.NpgsqlPoint(x: 0.2650545408988144d, y: 0.7327008349940627d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441261237688368d, y: 0.7227904262981182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9858714353774636d, y: 0.716333785294294d), new NpgsqlTypes.NpgsqlPoint(x: 0.4006764821801402d, y: 0.5812547959766221d), new NpgsqlTypes.NpgsqlPoint(x: 0.6760354437861369d, y: 0.04107252317886556d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8237111333254754d, y: 0.8282567640212279d), new NpgsqlTypes.NpgsqlPoint(x: 0.9620091100669906d, y: 0.9538311298664168d), new NpgsqlTypes.NpgsqlPoint(x: 0.26419484677671523d, y: 0.9511854127384858d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05957731328165361d, y: 0.9557532070361549d), new NpgsqlTypes.NpgsqlPoint(x: 0.5473017892507859d, y: 0.5320634828900649d), new NpgsqlTypes.NpgsqlPoint(x: 0.002506962902678933d, y: 0.7129853959341813d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3699441598413571d, y: 0.6973266744685359d), new NpgsqlTypes.NpgsqlPoint(x: 0.01590339314027822d, y: 0.5706365874764388d), new NpgsqlTypes.NpgsqlPoint(x: 0.21220838225919036d, y: 0.9498155077129562d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18152624943497575d, y: 0.5196182778936078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8269450479981276d, y: 0.5520901720647364d), new NpgsqlTypes.NpgsqlPoint(x: 0.32001746840696854d, y: 0.42150267282007414d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27948805436077084d, y: 0.07905635022472923d), new NpgsqlTypes.NpgsqlPoint(x: 0.9395791020967568d, y: 0.43948605638176885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7340863967920661d, y: 0.6296975089202171d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8961588877954957d, y: 0.6214839403156918d), new NpgsqlTypes.NpgsqlPoint(x: 0.8032820918830469d, y: 0.4269367831384725d), new NpgsqlTypes.NpgsqlPoint(x: 0.47567255549949783d, y: 0.7084641893568482d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2924535607774935d, y: 0.5526613527578498d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433985582949106d, y: 0.0627542820826611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7895096027879978d, y: 0.9118030819239487d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 171,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.73408802974685d, y: 0.998937827359273d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943755854482051d, y: 0.23606347056906618d), new NpgsqlTypes.NpgsqlPoint(x: 0.9239538695374515d, y: 0.5116523488728696d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4362412565398128d, y: 0.8589428321947921d), new NpgsqlTypes.NpgsqlPoint(x: 0.7790094279882167d, y: 0.803910679314944d), new NpgsqlTypes.NpgsqlPoint(x: 0.25455043101670205d, y: 0.286345289915346d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5546440600420226d, y: 0.39956721340261536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5177501706208342d, y: 0.6497096797858876d), new NpgsqlTypes.NpgsqlPoint(x: 0.09276308671624622d, y: 0.7769780235000149d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3025465302149689d, y: 0.8108376865319559d), new NpgsqlTypes.NpgsqlPoint(x: 0.7942536291203417d, y: 0.20301626838354725d), new NpgsqlTypes.NpgsqlPoint(x: 0.7550493027137132d, y: 0.7229821587915976d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19312414924677168d, y: 0.9965750292582797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9220810237501043d, y: 0.49421226620806946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5718356741217563d, y: 0.655354333200188d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5541463978382768d, y: 0.5313298845171105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794053638993987d, y: 0.32732597313626044d), new NpgsqlTypes.NpgsqlPoint(x: 0.22107242421134787d, y: 0.7725568613589198d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6894380358843049d, y: 0.8752840921982421d), new NpgsqlTypes.NpgsqlPoint(x: 0.859003273757603d, y: 0.5751684392450849d), new NpgsqlTypes.NpgsqlPoint(x: 0.21722772951923575d, y: 0.531865370450334d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9440688590147754d, y: 0.2731628497751529d), new NpgsqlTypes.NpgsqlPoint(x: 0.9287862622977918d, y: 0.6313088545707028d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426459234309029d, y: 0.1729205832104742d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9936536578027453d, y: 0.8527118625887923d), new NpgsqlTypes.NpgsqlPoint(x: 0.6667838617353525d, y: 0.8332998980454345d), new NpgsqlTypes.NpgsqlPoint(x: 0.4600733177491737d, y: 0.017329737662101774d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20012758846514178d, y: 0.408291972163088d), new NpgsqlTypes.NpgsqlPoint(x: 0.30126210053457436d, y: 0.7980924764110858d), new NpgsqlTypes.NpgsqlPoint(x: 0.2167330525488802d, y: 0.6486057232029852d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6243847455278861d, y: 0.8888602990751282d), new NpgsqlTypes.NpgsqlPoint(x: 0.12487701489710212d, y: 0.6989061100004679d), new NpgsqlTypes.NpgsqlPoint(x: 0.47065880679585326d, y: 0.47302160056048004d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1699640087159623d, y: 0.7439712808984661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6111150132784456d, y: 0.09927823085736776d), new NpgsqlTypes.NpgsqlPoint(x: 0.26725512058258916d, y: 0.15993695931326468d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4882208745465946d, y: 0.32341932763757053d), new NpgsqlTypes.NpgsqlPoint(x: 0.24156160296716322d, y: 0.2636030336477224d), new NpgsqlTypes.NpgsqlPoint(x: 0.21430772931922049d, y: 0.2338690737404805d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.890501105014759d, y: 0.5030993136471463d), new NpgsqlTypes.NpgsqlPoint(x: 0.7748950432235918d, y: 0.11196142382517404d), new NpgsqlTypes.NpgsqlPoint(x: 0.43264291208709316d, y: 0.3840268401499465d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2531600758967548d, y: 0.6058759963529717d), new NpgsqlTypes.NpgsqlPoint(x: 0.6684214077981968d, y: 0.8786614803211368d), new NpgsqlTypes.NpgsqlPoint(x: 0.532274780364264d, y: 0.14970655645013076d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0305583279511642d, y: 0.741707075212234d), new NpgsqlTypes.NpgsqlPoint(x: 0.30492720326498945d, y: 0.5870134297106715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2848851254740491d, y: 0.8738120705348531d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7402903734340909d, y: 0.5669257410241941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227455079595058d, y: 0.5038246095169521d), new NpgsqlTypes.NpgsqlPoint(x: 0.012161185795597884d, y: 0.9464855792899839d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35141469275909865d, y: 0.8188831199719395d), new NpgsqlTypes.NpgsqlPoint(x: 0.09351039739700062d, y: 0.8578336270433908d), new NpgsqlTypes.NpgsqlPoint(x: 0.9130680036410668d, y: 0.7590388402556818d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38744633229983927d, y: 0.05387844987015489d), new NpgsqlTypes.NpgsqlPoint(x: 0.5249350499252824d, y: 0.43369170051047856d), new NpgsqlTypes.NpgsqlPoint(x: 0.9225288090405456d, y: 0.37583739767990487d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9650853128576085d, y: 0.7373919995763647d), new NpgsqlTypes.NpgsqlPoint(x: 0.4456481889353231d, y: 0.0673802599815938d), new NpgsqlTypes.NpgsqlPoint(x: 0.5934353466338976d, y: 0.9833545412098287d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9316287241959806d, y: 0.5780371074169978d), new NpgsqlTypes.NpgsqlPoint(x: 0.6757761342041988d, y: 0.8071312586013566d), new NpgsqlTypes.NpgsqlPoint(x: 0.16964439530226372d, y: 0.06556480143015042d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5488340360252868d, y: 0.7254056086068237d), new NpgsqlTypes.NpgsqlPoint(x: 0.2088894297149817d, y: 0.9596967706746963d), new NpgsqlTypes.NpgsqlPoint(x: 0.557754173067975d, y: 0.6210549878673637d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8978687701512021d, y: 0.3769479606492887d), new NpgsqlTypes.NpgsqlPoint(x: 0.15649385428224483d, y: 0.6279154311205626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4470332161339211d, y: 0.440796877075062d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3631864706901926d, y: 0.9750377041411663d), new NpgsqlTypes.NpgsqlPoint(x: 0.2263276503870626d, y: 0.2344447654408126d), new NpgsqlTypes.NpgsqlPoint(x: 0.05582047235087573d, y: 0.598174513718448d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2015410144232832d, y: 0.9571307372439057d), new NpgsqlTypes.NpgsqlPoint(x: 0.3456275534834228d, y: 0.8731194036550125d), new NpgsqlTypes.NpgsqlPoint(x: 0.22531612407843926d, y: 0.8426953427503754d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7860436642107343d, y: 0.3583280843847597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8890766625300679d, y: 0.807890551135174d), new NpgsqlTypes.NpgsqlPoint(x: 0.2192949728539485d, y: 0.7174802980558214d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8542155627928208d, y: 0.6902558551520885d), new NpgsqlTypes.NpgsqlPoint(x: 0.9787279269525253d, y: 0.751808227621777d), new NpgsqlTypes.NpgsqlPoint(x: 0.18758181666382812d, y: 0.40183165919857333d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5472804807000238d, y: 0.31490384710959696d), new NpgsqlTypes.NpgsqlPoint(x: 0.13599012427561064d, y: 0.21378969033694672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5062323449582002d, y: 0.7435806550893019d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1536953004051389d, y: 0.7317018787400887d), new NpgsqlTypes.NpgsqlPoint(x: 0.5759716322291382d, y: 0.5200637511943399d), new NpgsqlTypes.NpgsqlPoint(x: 0.9714936325385908d, y: 0.0891329994789607d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970755633129043d, y: 0.32508589434326685d), new NpgsqlTypes.NpgsqlPoint(x: 0.5824029891502847d, y: 0.8032504785842864d), new NpgsqlTypes.NpgsqlPoint(x: 0.4786617755512559d, y: 0.26421743645495976d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09121742001209909d, y: 0.5135868668865405d), new NpgsqlTypes.NpgsqlPoint(x: 0.3835565938619089d, y: 0.7872072799558117d), new NpgsqlTypes.NpgsqlPoint(x: 0.08146043191499364d, y: 0.38899473822603003d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5104582256953923d, y: 0.7436496051599091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8916173802325774d, y: 0.9983698570125665d), new NpgsqlTypes.NpgsqlPoint(x: 0.7801367918921448d, y: 0.17959054210339487d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8814719680826457d, y: 0.6176742991575612d), new NpgsqlTypes.NpgsqlPoint(x: 0.10196874586267002d, y: 0.6608459681672771d), new NpgsqlTypes.NpgsqlPoint(x: 0.43610987054615946d, y: 0.8158101791588658d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6989455672437876d, y: 0.0914140235825307d), new NpgsqlTypes.NpgsqlPoint(x: 0.7388624953979104d, y: 0.05808234428800596d), new NpgsqlTypes.NpgsqlPoint(x: 0.044405471503093485d, y: 0.7319217266638347d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.649797974069546d, y: 0.4966325504711602d), new NpgsqlTypes.NpgsqlPoint(x: 0.9609991033475161d, y: 0.13053075721520246d), new NpgsqlTypes.NpgsqlPoint(x: 0.49239773993955094d, y: 0.4462377001144292d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5573867970295686d, y: 0.46048262440880183d), new NpgsqlTypes.NpgsqlPoint(x: 0.16149244845628663d, y: 0.07643975928026137d), new NpgsqlTypes.NpgsqlPoint(x: 0.4419667696135169d, y: 0.5007898567374248d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11285217675070602d, y: 0.7050031516428228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5846747604852148d, y: 0.6020664614307902d), new NpgsqlTypes.NpgsqlPoint(x: 0.10925029591815338d, y: 0.8239957140380321d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9652811623685346d, y: 0.43598684170999524d), new NpgsqlTypes.NpgsqlPoint(x: 0.4735851273715247d, y: 0.4668453748820367d), new NpgsqlTypes.NpgsqlPoint(x: 0.22537941633153546d, y: 0.19170379176034413d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6205399245909318d, y: 0.4543958278244732d), new NpgsqlTypes.NpgsqlPoint(x: 0.40194008504257306d, y: 0.6961073583538622d), new NpgsqlTypes.NpgsqlPoint(x: 0.6309168161998779d, y: 0.17639124209461698d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3563027620154001d, y: 0.6115552609423106d), new NpgsqlTypes.NpgsqlPoint(x: 0.11380977906270018d, y: 0.48665927633485606d), new NpgsqlTypes.NpgsqlPoint(x: 0.9213019838080911d, y: 0.4178279006672936d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2971260351994912d, y: 0.6604388781247493d), new NpgsqlTypes.NpgsqlPoint(x: 0.6507000893947014d, y: 0.49762033368351377d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995026942750944d, y: 0.3847548591946981d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19732853000265793d, y: 0.7910724769855194d), new NpgsqlTypes.NpgsqlPoint(x: 0.797209411056286d, y: 0.7345254326935674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8414554440170394d, y: 0.6444196651533344d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4975054337061353d, y: 0.7950659570539873d), new NpgsqlTypes.NpgsqlPoint(x: 0.9088225261882464d, y: 0.04510781773429995d), new NpgsqlTypes.NpgsqlPoint(x: 0.7122493582526109d, y: 0.996593802837628d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6510363987008577d, y: 0.29431287753683844d), new NpgsqlTypes.NpgsqlPoint(x: 0.7140068043661852d, y: 0.4655424091461676d), new NpgsqlTypes.NpgsqlPoint(x: 0.3449768900946335d, y: 0.2042719608746888d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3745614496223886d, y: 0.8030209830714103d), new NpgsqlTypes.NpgsqlPoint(x: 0.08950542512065351d, y: 0.714097721795144d), new NpgsqlTypes.NpgsqlPoint(x: 0.916948683530025d, y: 0.8024963628928311d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3192462259875136d, y: 0.8660397508973393d), new NpgsqlTypes.NpgsqlPoint(x: 0.2499001228357981d, y: 0.6668219846797443d), new NpgsqlTypes.NpgsqlPoint(x: 0.74734018888312d, y: 0.7085298517849822d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.683166790256369d, y: 0.6732042027256935d), new NpgsqlTypes.NpgsqlPoint(x: 0.29252807527863367d, y: 0.6705945314054943d), new NpgsqlTypes.NpgsqlPoint(x: 0.6862507808670867d, y: 0.5856546425193065d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6648264369491863d, y: 0.1618844132530507d), new NpgsqlTypes.NpgsqlPoint(x: 0.6008742883106507d, y: 0.5948871717090749d), new NpgsqlTypes.NpgsqlPoint(x: 0.3748613237274918d, y: 0.06360108413052501d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17652431278912173d, y: 0.7383847285576248d), new NpgsqlTypes.NpgsqlPoint(x: 0.22099627592774418d, y: 0.6105488498607251d), new NpgsqlTypes.NpgsqlPoint(x: 0.15649199894436905d, y: 0.5955835041009554d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5839684549678565d, y: 0.6147645628374638d), new NpgsqlTypes.NpgsqlPoint(x: 0.608827392937253d, y: 0.14392457788397284d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150795971128346d, y: 0.5789808538334237d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12809765196609302d, y: 0.4523286019569597d), new NpgsqlTypes.NpgsqlPoint(x: 0.8807448210937463d, y: 0.9106152758731902d), new NpgsqlTypes.NpgsqlPoint(x: 0.3196864615419077d, y: 0.588061620130434d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7461693943563765d, y: 0.901598628878318d), new NpgsqlTypes.NpgsqlPoint(x: 0.47768034310962815d, y: 0.5034378059049195d), new NpgsqlTypes.NpgsqlPoint(x: 0.5112708971738366d, y: 0.11196539194406285d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9650682464074977d, y: 0.8182742528614287d), new NpgsqlTypes.NpgsqlPoint(x: 0.4415689643854599d, y: 0.1651331509747722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9729665034298907d, y: 0.29895372342088145d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5760714689975126d, y: 0.5721800009910024d), new NpgsqlTypes.NpgsqlPoint(x: 0.17738348616238564d, y: 0.2799726881033572d), new NpgsqlTypes.NpgsqlPoint(x: 0.8087750654381243d, y: 0.8181296355557017d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 91,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5105906727504372d, y: 0.033861178051843965d), new NpgsqlTypes.NpgsqlPoint(x: 0.036437019583726915d, y: 0.3629148520448269d), new NpgsqlTypes.NpgsqlPoint(x: 0.5014100218742236d, y: 0.03168521518427847d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11084171710462187d, y: 0.3062576723777938d), new NpgsqlTypes.NpgsqlPoint(x: 0.9638438098923005d, y: 0.8326052480446626d), new NpgsqlTypes.NpgsqlPoint(x: 0.4977257212027828d, y: 0.31013378366366706d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7594334312974307d, y: 0.83302070892091d), new NpgsqlTypes.NpgsqlPoint(x: 0.8389931146538886d, y: 0.40969328314118325d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898737129227939d, y: 0.7495647446646146d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5880522286503742d, y: 0.49540272384156137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9956325006716016d, y: 0.47076411160698184d), new NpgsqlTypes.NpgsqlPoint(x: 0.027527558546162845d, y: 0.803779669787392d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13922865933927941d, y: 0.3044697463182253d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945860165386108d, y: 0.4612481164812723d), new NpgsqlTypes.NpgsqlPoint(x: 0.9598592519000535d, y: 0.05411238102824345d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4939915682730034d, y: 0.09277050508683793d), new NpgsqlTypes.NpgsqlPoint(x: 0.4569905592604494d, y: 0.03732497933761758d), new NpgsqlTypes.NpgsqlPoint(x: 0.30125815602644435d, y: 0.9814302034722984d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25423342558799433d, y: 0.9121467454038881d), new NpgsqlTypes.NpgsqlPoint(x: 0.5052553408177728d, y: 0.010962414787826114d), new NpgsqlTypes.NpgsqlPoint(x: 0.5749337869157998d, y: 0.4460671206825595d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5285937312991303d, y: 0.06756231943483038d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176718920368986d, y: 0.0440122412957229d), new NpgsqlTypes.NpgsqlPoint(x: 0.893341037469173d, y: 0.14309734563176013d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37480190398019286d, y: 0.23923451748461277d), new NpgsqlTypes.NpgsqlPoint(x: 0.8341151481746006d, y: 0.3563473011614575d), new NpgsqlTypes.NpgsqlPoint(x: 0.20357982342410352d, y: 0.3803323739544734d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25417400267343204d, y: 0.662383855948913d), new NpgsqlTypes.NpgsqlPoint(x: 0.293382359949632d, y: 0.6735274793423202d), new NpgsqlTypes.NpgsqlPoint(x: 0.4896685979011133d, y: 0.7448428364509073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18337282346287032d, y: 0.4872639971208007d), new NpgsqlTypes.NpgsqlPoint(x: 0.7545598335090159d, y: 0.24084304281177227d), new NpgsqlTypes.NpgsqlPoint(x: 0.6408844858499506d, y: 0.04987776258191845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46691709821149474d, y: 0.38102746456146797d), new NpgsqlTypes.NpgsqlPoint(x: 0.8882159014246922d, y: 0.48671032005974746d), new NpgsqlTypes.NpgsqlPoint(x: 0.111757837759212d, y: 0.7994339899259799d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22092477419460743d, y: 0.30736282779504365d), new NpgsqlTypes.NpgsqlPoint(x: 0.5158755907020562d, y: 0.7235300614560212d), new NpgsqlTypes.NpgsqlPoint(x: 0.6385621116413441d, y: 0.40200463737282044d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5344127164831263d, y: 0.6922564806137858d), new NpgsqlTypes.NpgsqlPoint(x: 0.0010350021807636889d, y: 0.2798510391215817d), new NpgsqlTypes.NpgsqlPoint(x: 0.550519189880796d, y: 0.233004634877499d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7991520442384846d, y: 0.676032422585994d), new NpgsqlTypes.NpgsqlPoint(x: 0.9117662107533424d, y: 0.389727707356897d), new NpgsqlTypes.NpgsqlPoint(x: 0.8830417967047103d, y: 0.8368656880338204d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5740632664829209d, y: 0.4220168614228068d), new NpgsqlTypes.NpgsqlPoint(x: 0.4369855778436632d, y: 0.49685630004100234d), new NpgsqlTypes.NpgsqlPoint(x: 0.03203077422400258d, y: 0.0034166894744018794d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17503349810228763d, y: 0.47844492217216417d), new NpgsqlTypes.NpgsqlPoint(x: 0.9595048917286978d, y: 0.3609847018905503d), new NpgsqlTypes.NpgsqlPoint(x: 0.6496820475713546d, y: 0.17842496872712454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8576900685714001d, y: 0.55430067652581d), new NpgsqlTypes.NpgsqlPoint(x: 0.22278299317079842d, y: 0.7113263693096596d), new NpgsqlTypes.NpgsqlPoint(x: 0.532624329179726d, y: 0.46473618312422926d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7632718093748752d, y: 0.41394327642846906d), new NpgsqlTypes.NpgsqlPoint(x: 0.7604932254872153d, y: 0.027315952654875075d), new NpgsqlTypes.NpgsqlPoint(x: 0.9147648718194672d, y: 0.38037805525308466d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9702460603719444d, y: 0.1812273108038186d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516712433937222d, y: 0.3605919259948376d), new NpgsqlTypes.NpgsqlPoint(x: 0.13657051910881624d, y: 0.4576759808694061d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19767766044110713d, y: 0.048446429066118624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5084717172485755d, y: 0.19136599028372836d), new NpgsqlTypes.NpgsqlPoint(x: 0.09455380569448257d, y: 0.41891929207926015d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27252602609738885d, y: 0.22556699017382897d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794136785988261d, y: 0.653711453657624d), new NpgsqlTypes.NpgsqlPoint(x: 0.36069519135265016d, y: 0.05986811848981366d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6173095072217639d, y: 0.6442104935414482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8736767964884965d, y: 0.613445294793457d), new NpgsqlTypes.NpgsqlPoint(x: 0.9449808986431867d, y: 0.7610966493165632d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7970798874498922d, y: 0.5631958870390825d), new NpgsqlTypes.NpgsqlPoint(x: 0.9038567321233261d, y: 0.8052319584228754d), new NpgsqlTypes.NpgsqlPoint(x: 0.30464083124270047d, y: 0.9097843635455098d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34136218445020916d, y: 0.4676521912258125d), new NpgsqlTypes.NpgsqlPoint(x: 0.5489959656635498d, y: 0.9746086270234101d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674845122595556d, y: 0.1117922610180564d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8730467912450286d, y: 0.858216110354319d), new NpgsqlTypes.NpgsqlPoint(x: 0.24963760303204696d, y: 0.9807827294027852d), new NpgsqlTypes.NpgsqlPoint(x: 0.5973858083242427d, y: 0.6310568868206242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8418079813515227d, y: 0.2309743025621378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7878340533227015d, y: 0.004339119019455606d), new NpgsqlTypes.NpgsqlPoint(x: 0.8277648564726369d, y: 0.5879576144413171d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08429970538797871d, y: 0.49625759069292585d), new NpgsqlTypes.NpgsqlPoint(x: 0.6021487750034977d, y: 0.9955145058057874d), new NpgsqlTypes.NpgsqlPoint(x: 0.3350861457331952d, y: 0.09823769813235406d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10675508946784518d, y: 0.284315210169092d), new NpgsqlTypes.NpgsqlPoint(x: 0.18579104821385706d, y: 0.008857740749565801d), new NpgsqlTypes.NpgsqlPoint(x: 0.5995632392288843d, y: 0.5458419502215233d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3636203418778019d, y: 0.27785253202609883d), new NpgsqlTypes.NpgsqlPoint(x: 0.01885386055238114d, y: 0.23085576967679833d), new NpgsqlTypes.NpgsqlPoint(x: 0.06261441957594993d, y: 0.25127009687512225d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7691362721371573d, y: 0.6040548182497264d), new NpgsqlTypes.NpgsqlPoint(x: 0.5800821807396619d, y: 0.5451775540758195d), new NpgsqlTypes.NpgsqlPoint(x: 0.053657175896915765d, y: 0.5042786659972472d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7240824857662291d, y: 0.5683828799219934d), new NpgsqlTypes.NpgsqlPoint(x: 0.09945748832381762d, y: 0.18041919267976603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5368694167549811d, y: 0.361353223295254d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.736836589926062d, y: 0.005162886948069656d), new NpgsqlTypes.NpgsqlPoint(x: 0.6613690188672257d, y: 0.8102052636644638d), new NpgsqlTypes.NpgsqlPoint(x: 0.22687533555128903d, y: 0.8991355766195657d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48189712593356215d, y: 0.6918825258910908d), new NpgsqlTypes.NpgsqlPoint(x: 0.022685224036080642d, y: 0.4846130876371123d), new NpgsqlTypes.NpgsqlPoint(x: 0.7603126791158934d, y: 0.9802984168687154d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5420941195626245d, y: 0.18193983305154593d), new NpgsqlTypes.NpgsqlPoint(x: 0.24989427152220323d, y: 0.7649758817241871d), new NpgsqlTypes.NpgsqlPoint(x: 0.377426669672299d, y: 0.8954207567797754d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25843701517928985d, y: 0.3749952248415097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9301211419997597d, y: 0.9688966955807319d), new NpgsqlTypes.NpgsqlPoint(x: 0.7078264486813776d, y: 0.8181907073287511d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43564852353068795d, y: 0.03509610028784271d), new NpgsqlTypes.NpgsqlPoint(x: 0.4676615560470859d, y: 0.07899094913610383d), new NpgsqlTypes.NpgsqlPoint(x: 0.012028176916440203d, y: 0.5086101160614579d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8591420487373022d, y: 0.40327782771468346d), new NpgsqlTypes.NpgsqlPoint(x: 0.838180305245746d, y: 0.21532260765462718d), new NpgsqlTypes.NpgsqlPoint(x: 0.6098505599644398d, y: 0.6816313571863339d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8496206106295732d, y: 0.7972675952869187d), new NpgsqlTypes.NpgsqlPoint(x: 0.34794489364124215d, y: 0.6385199396456496d), new NpgsqlTypes.NpgsqlPoint(x: 0.7325610486107789d, y: 0.4390392853790317d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.013116583341600485d, y: 0.8167080285957157d), new NpgsqlTypes.NpgsqlPoint(x: 0.2699210256345027d, y: 0.3507286732688085d), new NpgsqlTypes.NpgsqlPoint(x: 0.9853171446958626d, y: 0.0703965045403161d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3011755409810891d, y: 0.7981618243357474d), new NpgsqlTypes.NpgsqlPoint(x: 0.08792644364183166d, y: 0.4570192327905571d), new NpgsqlTypes.NpgsqlPoint(x: 0.1496696880426419d, y: 0.7608760129440928d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48524207156063603d, y: 0.9380508267998142d), new NpgsqlTypes.NpgsqlPoint(x: 0.09221217557452432d, y: 0.16330630467255147d), new NpgsqlTypes.NpgsqlPoint(x: 0.35740073119512894d, y: 0.07495993437003523d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5027304745968268d, y: 0.9721284907603841d), new NpgsqlTypes.NpgsqlPoint(x: 0.8067709161053969d, y: 0.5032545702621749d), new NpgsqlTypes.NpgsqlPoint(x: 0.5863989735047218d, y: 0.6885199136272494d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3588841689698584d, y: 0.6697891101080707d), new NpgsqlTypes.NpgsqlPoint(x: 0.059497457895247186d, y: 0.8960493110841432d), new NpgsqlTypes.NpgsqlPoint(x: 0.5541025078497742d, y: 0.08169286655703223d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24238423836142442d, y: 0.18632975269747654d), new NpgsqlTypes.NpgsqlPoint(x: 0.8592450456981059d, y: 0.6694843360369002d), new NpgsqlTypes.NpgsqlPoint(x: 0.42154195684929285d, y: 0.770377482984824d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9362855990686849d, y: 0.5588653166498433d), new NpgsqlTypes.NpgsqlPoint(x: 0.650403780448439d, y: 0.12484677723065063d), new NpgsqlTypes.NpgsqlPoint(x: 0.854854041683577d, y: 0.04159479646177955d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.723525753244552d, y: 0.8108582646657322d), new NpgsqlTypes.NpgsqlPoint(x: 0.8274324453985714d, y: 0.2055711145187633d), new NpgsqlTypes.NpgsqlPoint(x: 0.4320545241753272d, y: 0.03816253818922455d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6526102321732595d, y: 0.8846368813000841d), new NpgsqlTypes.NpgsqlPoint(x: 0.10688761964581006d, y: 0.9221525766922494d), new NpgsqlTypes.NpgsqlPoint(x: 0.6157269275323405d, y: 0.3265976883993146d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8174116175908331d, y: 0.5966039209130368d), new NpgsqlTypes.NpgsqlPoint(x: 0.48541728305464826d, y: 0.4790525243113801d), new NpgsqlTypes.NpgsqlPoint(x: 0.31768129099512776d, y: 0.30957371230864994d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39781387264354584d, y: 0.06436530971657739d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205027511858216d, y: 0.5281536062077743d), new NpgsqlTypes.NpgsqlPoint(x: 0.4042245963134061d, y: 0.6488699464819098d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8576120958810104d, y: 0.8001150124828174d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266872707921732d, y: 0.8485050459254577d), new NpgsqlTypes.NpgsqlPoint(x: 0.020641707920154295d, y: 0.9367931780368818d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.707389666040361d, y: 0.3154826251789521d), new NpgsqlTypes.NpgsqlPoint(x: 0.6657427580653357d, y: 0.4829757486152425d), new NpgsqlTypes.NpgsqlPoint(x: 0.04808531960471274d, y: 0.246154884941008d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5394872015003509d, y: 0.37583570270524014d), new NpgsqlTypes.NpgsqlPoint(x: 0.05079420240976584d, y: 0.011391807821851674d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629610441472903d, y: 0.7748760214324437d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9049216549474057d, y: 0.051138488171326935d), new NpgsqlTypes.NpgsqlPoint(x: 0.2892046854360011d, y: 0.3092770207464365d), new NpgsqlTypes.NpgsqlPoint(x: 0.3534862937544464d, y: 0.9395789444182789d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 179,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8573525617909092d, y: 0.48514383966239305d), new NpgsqlTypes.NpgsqlPoint(x: 0.9105930952280202d, y: 0.7718444776385772d), new NpgsqlTypes.NpgsqlPoint(x: 0.06909432305570817d, y: 0.23304177061448317d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6167994889386536d, y: 0.11507410107962635d), new NpgsqlTypes.NpgsqlPoint(x: 0.517996146878757d, y: 0.44797735031607133d), new NpgsqlTypes.NpgsqlPoint(x: 0.6570827810235282d, y: 0.8652697228964124d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4743498509160997d, y: 0.7358181497507019d), new NpgsqlTypes.NpgsqlPoint(x: 0.10199294811499993d, y: 0.5656558549267369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2064484968635536d, y: 0.32812156193662434d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9472111671661507d, y: 0.126903111016322d), new NpgsqlTypes.NpgsqlPoint(x: 0.018926849998935458d, y: 0.11628848939668157d), new NpgsqlTypes.NpgsqlPoint(x: 0.3352656244204879d, y: 0.012707651161673827d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0019371376531222007d, y: 0.5075878658619002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7056517899458239d, y: 0.06783700613010357d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082088883225752d, y: 0.4013376829095663d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11054423461580476d, y: 0.5548487770826931d), new NpgsqlTypes.NpgsqlPoint(x: 0.9741823486702132d, y: 0.6252357244095996d), new NpgsqlTypes.NpgsqlPoint(x: 0.6428964724681399d, y: 0.21617713878219502d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4001982835406366d, y: 0.8338814316864398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4230957992761193d, y: 0.5486375425060994d), new NpgsqlTypes.NpgsqlPoint(x: 0.4049113228691268d, y: 0.9909555329165444d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6317278501632306d, y: 0.42470137014816345d), new NpgsqlTypes.NpgsqlPoint(x: 0.014622851780793145d, y: 0.8490913934390006d), new NpgsqlTypes.NpgsqlPoint(x: 0.38942976871089796d, y: 0.10088998688803807d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8178352233124662d, y: 0.021293548665371143d), new NpgsqlTypes.NpgsqlPoint(x: 0.49161628442902483d, y: 0.3501482250419373d), new NpgsqlTypes.NpgsqlPoint(x: 0.36830831746305503d, y: 0.4989167444938719d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9776022793147908d, y: 0.8029308646622239d), new NpgsqlTypes.NpgsqlPoint(x: 0.1933781652893346d, y: 0.8725416050906666d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959911643899646d, y: 0.8041134077330392d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31825329697602045d, y: 0.007625179805774374d), new NpgsqlTypes.NpgsqlPoint(x: 0.2332125191164247d, y: 0.36526528272297987d), new NpgsqlTypes.NpgsqlPoint(x: 0.8188170986739292d, y: 0.33093890951430216d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8169312950493686d, y: 0.8319407574662603d), new NpgsqlTypes.NpgsqlPoint(x: 0.19287651531043237d, y: 0.16201087364494726d), new NpgsqlTypes.NpgsqlPoint(x: 0.8164802864411319d, y: 0.1314504542390953d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3822685657994529d, y: 0.750106831689945d), new NpgsqlTypes.NpgsqlPoint(x: 0.7690513615414649d, y: 0.6808632743046856d), new NpgsqlTypes.NpgsqlPoint(x: 0.8047169351048227d, y: 0.4324188354637635d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5287992054317369d, y: 0.030687319241649913d), new NpgsqlTypes.NpgsqlPoint(x: 0.9178615226625084d, y: 0.0619653741684405d), new NpgsqlTypes.NpgsqlPoint(x: 0.09616641902271006d, y: 0.12563798401195425d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8913893860525033d, y: 0.6530837766486105d), new NpgsqlTypes.NpgsqlPoint(x: 0.21724818086110642d, y: 0.8693711983681117d), new NpgsqlTypes.NpgsqlPoint(x: 0.37022663363667396d, y: 0.21852825486441685d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4851188547683576d, y: 0.0322315793124458d), new NpgsqlTypes.NpgsqlPoint(x: 0.3532111015041274d, y: 0.8131851728090941d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535020632603765d, y: 0.0954878293669622d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4657800900334381d, y: 0.305748677825605d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621897457760749d, y: 0.8896404520444362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327986919974835d, y: 0.6561902359558771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6325958949261059d, y: 0.43916223886804095d), new NpgsqlTypes.NpgsqlPoint(x: 0.2902671996654268d, y: 0.5762615835566302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9163104140454204d, y: 0.9065323773661244d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7223139556463628d, y: 0.21723481301813397d), new NpgsqlTypes.NpgsqlPoint(x: 0.9525971487797741d, y: 0.1294197920091873d), new NpgsqlTypes.NpgsqlPoint(x: 0.8957367449595849d, y: 0.3873507038035898d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027494725926293206d, y: 0.8288214375250922d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065501643448469d, y: 0.7435764078603347d), new NpgsqlTypes.NpgsqlPoint(x: 0.969672998071988d, y: 0.46888559212859304d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19277829915276723d, y: 0.6885567019437361d), new NpgsqlTypes.NpgsqlPoint(x: 0.6003967750572501d, y: 0.9745292073017366d), new NpgsqlTypes.NpgsqlPoint(x: 0.8553190550479531d, y: 0.13058845452602763d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8432092615540261d, y: 0.47568050076471335d), new NpgsqlTypes.NpgsqlPoint(x: 0.6467876375330339d, y: 0.23007176023749176d), new NpgsqlTypes.NpgsqlPoint(x: 0.8103818348672079d, y: 0.16958975209288318d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5581002387725092d, y: 0.04662401748513867d), new NpgsqlTypes.NpgsqlPoint(x: 0.8689334501044974d, y: 0.9223587882491763d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374284582293671d, y: 0.30660604047578033d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3277650697320833d, y: 0.8757819327787486d), new NpgsqlTypes.NpgsqlPoint(x: 0.0090864113273601d, y: 0.6900046044229553d), new NpgsqlTypes.NpgsqlPoint(x: 0.24596944297648882d, y: 0.6445417885165722d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.732961634241257d, y: 0.2958884250407404d), new NpgsqlTypes.NpgsqlPoint(x: 0.05146087716738246d, y: 0.8801394137748445d), new NpgsqlTypes.NpgsqlPoint(x: 0.7071546909246708d, y: 0.8122482224802748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13342941662189456d, y: 0.32801814178230937d), new NpgsqlTypes.NpgsqlPoint(x: 0.5906312260071659d, y: 0.08935846510973244d), new NpgsqlTypes.NpgsqlPoint(x: 0.12779771372400517d, y: 0.2741999021980984d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8517782283045174d, y: 0.4010972610623811d), new NpgsqlTypes.NpgsqlPoint(x: 0.6754101668891747d, y: 0.80798619862244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6160499287072353d, y: 0.04636535867793001d)), }, }, },
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9095612174700052d, y: 0.15136298941565185d), new NpgsqlTypes.NpgsqlPoint(x: 0.4638810758368792d, y: 0.9082329275047291d), new NpgsqlTypes.NpgsqlPoint(x: 0.4794406699097411d, y: 0.07679954461750793d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35455743889053337d, y: 0.6503881991712431d), new NpgsqlTypes.NpgsqlPoint(x: 0.3735572615217826d, y: 0.16269349727442084d), new NpgsqlTypes.NpgsqlPoint(x: 0.1758022652461475d, y: 0.6449509425619234d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7759741986945418d, y: 0.45236145088788604d), new NpgsqlTypes.NpgsqlPoint(x: 0.23113661103522498d, y: 0.1809710039135235d), new NpgsqlTypes.NpgsqlPoint(x: 0.6151702426756673d, y: 0.37188718002809396d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7076758513279392d, y: 0.6371295696722883d), new NpgsqlTypes.NpgsqlPoint(x: 0.08862356119164239d, y: 0.13959153221738074d), new NpgsqlTypes.NpgsqlPoint(x: 0.7769706283062713d, y: 0.06232952017807036d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6023866840936463d, y: 0.36443397323255067d), new NpgsqlTypes.NpgsqlPoint(x: 0.698857304907336d, y: 0.8282562360655558d), new NpgsqlTypes.NpgsqlPoint(x: 0.14415755156094545d, y: 0.7972640255050937d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8891189895784511d, y: 0.3412430554870327d), new NpgsqlTypes.NpgsqlPoint(x: 0.255787423423832d, y: 0.36896137556820807d), new NpgsqlTypes.NpgsqlPoint(x: 0.09232685731877177d, y: 0.2132349411810015d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06399477547884569d, y: 0.7554832969508453d), new NpgsqlTypes.NpgsqlPoint(x: 0.6362086770718945d, y: 0.6761029183399918d), new NpgsqlTypes.NpgsqlPoint(x: 0.93487241664376d, y: 0.8714762067362327d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9970401620306d, y: 0.17277558562948037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5198839562221106d, y: 0.7656702179428622d), new NpgsqlTypes.NpgsqlPoint(x: 0.04428539239114848d, y: 0.20029105008439663d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02204607178422413d, y: 0.01945437257606253d), new NpgsqlTypes.NpgsqlPoint(x: 0.7205229366543664d, y: 0.2642974182921072d), new NpgsqlTypes.NpgsqlPoint(x: 0.5797520166023953d, y: 0.6019622528669677d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.826839938474123d, y: 0.6171676197992951d), new NpgsqlTypes.NpgsqlPoint(x: 0.8772830973104946d, y: 0.8102259652180847d), new NpgsqlTypes.NpgsqlPoint(x: 0.8268082374813823d, y: 0.014892162032846601d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7355697461022198d, y: 0.4291447742880189d), new NpgsqlTypes.NpgsqlPoint(x: 0.44940993272266705d, y: 0.32335131564482666d), new NpgsqlTypes.NpgsqlPoint(x: 0.5786526028801651d, y: 0.8740171999866642d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6916889438440441d, y: 0.37926470866434026d), new NpgsqlTypes.NpgsqlPoint(x: 0.16253069435816203d, y: 0.15698141052589676d), new NpgsqlTypes.NpgsqlPoint(x: 0.23620920274689716d, y: 0.5295919849421563d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37329064326739825d, y: 0.7427151855646688d), new NpgsqlTypes.NpgsqlPoint(x: 0.4259457862087538d, y: 0.318020107184102d), new NpgsqlTypes.NpgsqlPoint(x: 0.5069745152504828d, y: 0.03371160365032666d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05029413332455157d, y: 0.577167113329633d), new NpgsqlTypes.NpgsqlPoint(x: 0.32933730427011165d, y: 0.6260045615329554d), new NpgsqlTypes.NpgsqlPoint(x: 0.03962754723337558d, y: 0.06549356537962503d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.161087840105962d, y: 0.11027800261979448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8409986255473496d, y: 0.34550021619206384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315287644973893d, y: 0.22142484796725315d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6013706410086084d, y: 0.41873931794368624d), new NpgsqlTypes.NpgsqlPoint(x: 0.1901698600664128d, y: 0.18719038045337089d), new NpgsqlTypes.NpgsqlPoint(x: 0.4962425994589511d, y: 0.8199568185822169d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.014994166482262705d, y: 0.5776035103352831d), new NpgsqlTypes.NpgsqlPoint(x: 0.9300130503094814d, y: 0.3892391519995946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5022425965698902d, y: 0.23855720842257777d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16496917082110107d, y: 0.3542009232943243d), new NpgsqlTypes.NpgsqlPoint(x: 0.016898448179373804d, y: 0.8160769437785824d), new NpgsqlTypes.NpgsqlPoint(x: 0.22037365620224136d, y: 0.8782930681599996d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9478130691164105d, y: 0.5183344699464089d), new NpgsqlTypes.NpgsqlPoint(x: 0.19135126279671777d, y: 0.7464696779123051d), new NpgsqlTypes.NpgsqlPoint(x: 0.1176619918935159d, y: 0.829531906053897d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.336865648288575d, y: 0.8934087735296132d), new NpgsqlTypes.NpgsqlPoint(x: 0.260739698633326d, y: 0.3760043247295972d), new NpgsqlTypes.NpgsqlPoint(x: 0.00082406423497694d, y: 0.3024144716068706d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7023690942006178d, y: 0.519245160099872d), new NpgsqlTypes.NpgsqlPoint(x: 0.1793486520645181d, y: 0.016920938287898646d), new NpgsqlTypes.NpgsqlPoint(x: 0.6912727716814162d, y: 0.38672462199003277d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9575311051108141d, y: 0.989064214240827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349669179557348d, y: 0.5697784427554389d), new NpgsqlTypes.NpgsqlPoint(x: 0.1558896622646101d, y: 0.7257166608743668d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5033490876485269d, y: 0.5125599486579843d), new NpgsqlTypes.NpgsqlPoint(x: 0.9138365723949432d, y: 0.3903081780915706d), new NpgsqlTypes.NpgsqlPoint(x: 0.11640882146871911d, y: 0.6195037195082954d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5696613988416303d, y: 0.4353711079100735d), new NpgsqlTypes.NpgsqlPoint(x: 0.5988759477571981d, y: 0.4742488775454623d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318458292102125d, y: 0.2461530663108067d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29595396361375126d, y: 0.1446929525909777d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275875646882247d, y: 0.3452976304965254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5251004174618507d, y: 0.31215549933899245d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.178038611662644d, y: 0.14041628297530895d), new NpgsqlTypes.NpgsqlPoint(x: 0.645582060139624d, y: 0.6474967308474744d), new NpgsqlTypes.NpgsqlPoint(x: 0.5402898482485441d, y: 0.9439951261945309d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20200646750334894d, y: 0.8278379370905073d), new NpgsqlTypes.NpgsqlPoint(x: 0.3319820549638043d, y: 0.74460188651038d), new NpgsqlTypes.NpgsqlPoint(x: 0.09314937726588557d, y: 0.3393111400586012d)), }, }, },
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 182,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07245842345292486d, y: 0.16887943949254547d), new NpgsqlTypes.NpgsqlPoint(x: 0.21975897328646443d, y: 0.47761827069915397d), new NpgsqlTypes.NpgsqlPoint(x: 0.01759045386886371d, y: 0.4337642180569917d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6453604488694898d, y: 0.720659738916312d), new NpgsqlTypes.NpgsqlPoint(x: 0.12822590161784375d, y: 0.5417282850362952d), new NpgsqlTypes.NpgsqlPoint(x: 0.3372123368400515d, y: 0.42304466235090443d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9160898308999725d, y: 0.46890590526980735d), new NpgsqlTypes.NpgsqlPoint(x: 0.3983728652679678d, y: 0.7716767230696424d), new NpgsqlTypes.NpgsqlPoint(x: 0.7188827307167633d, y: 0.9594809476661436d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9581550461137505d, y: 0.007991517336824017d), new NpgsqlTypes.NpgsqlPoint(x: 0.36976288890155473d, y: 0.06461957039556199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4163942783956659d, y: 0.8622257686930688d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7935100357640091d, y: 0.16705633709798473d), new NpgsqlTypes.NpgsqlPoint(x: 0.6103274077306905d, y: 0.0015314983967872342d), new NpgsqlTypes.NpgsqlPoint(x: 0.38556633704742793d, y: 0.5480420381559818d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19808994754132858d, y: 0.5613623009649067d), new NpgsqlTypes.NpgsqlPoint(x: 0.3930875073818205d, y: 0.6116686831124067d), new NpgsqlTypes.NpgsqlPoint(x: 0.6337201507848838d, y: 0.8694033811987336d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40849468535853184d, y: 0.5382245920395776d), new NpgsqlTypes.NpgsqlPoint(x: 0.8211531725997054d, y: 0.6224944415716841d), new NpgsqlTypes.NpgsqlPoint(x: 0.41369366272495034d, y: 0.3318498030406821d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09778002242789263d, y: 0.9494724727038085d), new NpgsqlTypes.NpgsqlPoint(x: 0.3265774038628423d, y: 0.6585973045329399d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121472879594138d, y: 0.898035749171887d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5718030959143294d, y: 0.9701783961844906d), new NpgsqlTypes.NpgsqlPoint(x: 0.6225504974308965d, y: 0.22492954954577715d), new NpgsqlTypes.NpgsqlPoint(x: 0.012999360819403227d, y: 0.7438577271284624d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.00953854626598738d, y: 0.15388463791413864d), new NpgsqlTypes.NpgsqlPoint(x: 0.388112647743334d, y: 0.08868765646455479d), new NpgsqlTypes.NpgsqlPoint(x: 0.7597803121171036d, y: 0.4606399894628317d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8830917338912063d, y: 0.4796505044884807d), new NpgsqlTypes.NpgsqlPoint(x: 0.3968778604699319d, y: 0.9433184139025798d), new NpgsqlTypes.NpgsqlPoint(x: 0.7009762874466016d, y: 0.14592621497616343d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.82124173900732d, y: 0.5266929002520251d), new NpgsqlTypes.NpgsqlPoint(x: 0.5908679655514169d, y: 0.46206432829220934d), new NpgsqlTypes.NpgsqlPoint(x: 0.04205158840667855d, y: 0.2807561084123382d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6329515495514674d, y: 0.954541300388474d), new NpgsqlTypes.NpgsqlPoint(x: 0.21537910412948402d, y: 0.05864604497295267d), new NpgsqlTypes.NpgsqlPoint(x: 0.4597905291017206d, y: 0.9857940511285654d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8630053465083699d, y: 0.9521667758063389d), new NpgsqlTypes.NpgsqlPoint(x: 0.5838056925970986d, y: 0.41065004504212066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7005217015056228d, y: 0.3790164962481247d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5761266480917402d, y: 0.02414124900729009d), new NpgsqlTypes.NpgsqlPoint(x: 0.7635464516232549d, y: 0.6790036323074558d), new NpgsqlTypes.NpgsqlPoint(x: 0.3892528767846847d, y: 0.023894974691663462d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9437823099355244d, y: 0.9976967005364611d), new NpgsqlTypes.NpgsqlPoint(x: 0.1283547908819388d, y: 0.0307467831712801d), new NpgsqlTypes.NpgsqlPoint(x: 0.6029032733993639d, y: 0.07349356901493198d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3615929114105988d, y: 0.34033205827513857d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123806172924859d, y: 0.38841694351033473d), new NpgsqlTypes.NpgsqlPoint(x: 0.06821055070289295d, y: 0.9139299160899034d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28647198865841894d, y: 0.16553244815712143d), new NpgsqlTypes.NpgsqlPoint(x: 0.7396210844029094d, y: 0.3367488605877119d), new NpgsqlTypes.NpgsqlPoint(x: 0.9530864656100595d, y: 0.04064743404145077d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6753347085972669d, y: 0.8162438535630836d), new NpgsqlTypes.NpgsqlPoint(x: 0.993240201149017d, y: 0.564343841683901d), new NpgsqlTypes.NpgsqlPoint(x: 0.7722428953629389d, y: 0.6909580271404491d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18136842407974307d, y: 0.04039183202930163d), new NpgsqlTypes.NpgsqlPoint(x: 0.18119830043205687d, y: 0.6152013526481912d), new NpgsqlTypes.NpgsqlPoint(x: 0.616488891490253d, y: 0.6215018182961493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3881609643506647d, y: 0.8546038550359225d), new NpgsqlTypes.NpgsqlPoint(x: 0.5136290580087308d, y: 0.7164915896096111d), new NpgsqlTypes.NpgsqlPoint(x: 0.27029190196304576d, y: 0.11115756962154033d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4487325325667031d, y: 0.24389135884396296d), new NpgsqlTypes.NpgsqlPoint(x: 0.08195339690438175d, y: 0.7849697641086109d), new NpgsqlTypes.NpgsqlPoint(x: 0.7557964948284961d, y: 0.3622232403775747d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2203440842834784d, y: 0.8830699986982181d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978146245071031d, y: 0.09070614913691688d), new NpgsqlTypes.NpgsqlPoint(x: 0.349534108971849d, y: 0.9085006591014113d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34955654065980435d, y: 0.4562630242063934d), new NpgsqlTypes.NpgsqlPoint(x: 0.931065673907538d, y: 0.02653698743959998d), new NpgsqlTypes.NpgsqlPoint(x: 0.691138906616501d, y: 0.21861839829251395d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4990986229993013d, y: 0.7383989620995783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5581942751627124d, y: 0.20683450360756017d), new NpgsqlTypes.NpgsqlPoint(x: 0.8826709063374858d, y: 0.09742115912882088d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9720457820356688d, y: 0.4064869582617804d), new NpgsqlTypes.NpgsqlPoint(x: 0.40107339890199445d, y: 0.7228356553334643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8645527472578032d, y: 0.096489934482612d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5899813294606452d, y: 0.8995499632986078d), new NpgsqlTypes.NpgsqlPoint(x: 0.31387400342503335d, y: 0.3587894934409116d), new NpgsqlTypes.NpgsqlPoint(x: 0.18946592192033396d, y: 0.012456592095051677d)), }, }, },
    ModelInner = new NpgsqlPolygonpolygonMMArrayD3E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06571786307972172d, y: 0.4697235465974319d), new NpgsqlTypes.NpgsqlPoint(x: 0.0041227670208648926d, y: 0.12038692206971613d), new NpgsqlTypes.NpgsqlPoint(x: 0.4759563316079488d, y: 0.3950535709691264d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03012451638366065d, y: 0.9353365752021342d), new NpgsqlTypes.NpgsqlPoint(x: 0.11897791410024061d, y: 0.27984245619624537d), new NpgsqlTypes.NpgsqlPoint(x: 0.8342914308553101d, y: 0.3746426556227834d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3515381704090632d, y: 0.6459287331128087d), new NpgsqlTypes.NpgsqlPoint(x: 0.22147424517254477d, y: 0.7344220402720176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9200695912892827d, y: 0.5808474899164335d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.522749754549514d, y: 0.30237511386937865d), new NpgsqlTypes.NpgsqlPoint(x: 0.3377498532197266d, y: 0.29157020082894336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9318286019810965d, y: 0.30667280793096807d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8581157836394918d, y: 0.250669176573041d), new NpgsqlTypes.NpgsqlPoint(x: 0.8714401676759961d, y: 0.24001739695954427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5763100747036517d, y: 0.668099298984881d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7579737544028272d, y: 0.5029562519087037d), new NpgsqlTypes.NpgsqlPoint(x: 0.17672461082828284d, y: 0.7003536645883102d), new NpgsqlTypes.NpgsqlPoint(x: 0.7435140036009599d, y: 0.6186899407114683d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8209129258354985d, y: 0.3786226895476369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2570742149066404d, y: 0.3978025420504282d), new NpgsqlTypes.NpgsqlPoint(x: 0.9428429182834005d, y: 0.19875980676667226d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5676458439352805d, y: 0.7168100646744928d), new NpgsqlTypes.NpgsqlPoint(x: 0.5478409554889908d, y: 0.963357055724415d), new NpgsqlTypes.NpgsqlPoint(x: 0.2830475445344506d, y: 0.8499202495932026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39523825831712067d, y: 0.45659718156851115d), new NpgsqlTypes.NpgsqlPoint(x: 0.17713598170978573d, y: 0.7868307337932362d), new NpgsqlTypes.NpgsqlPoint(x: 0.16304887490326014d, y: 0.34918126849125597d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1600803580902137d, y: 0.28001545238096504d), new NpgsqlTypes.NpgsqlPoint(x: 0.42741470599343134d, y: 0.14383943426640633d), new NpgsqlTypes.NpgsqlPoint(x: 0.8320229801549226d, y: 0.053849426513209786d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43500241978065357d, y: 0.8176291622048496d), new NpgsqlTypes.NpgsqlPoint(x: 0.9766917934604049d, y: 0.6966757466628652d), new NpgsqlTypes.NpgsqlPoint(x: 0.5292305809507116d, y: 0.009737756108361473d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1855533447613278d, y: 0.0077748878552788d), new NpgsqlTypes.NpgsqlPoint(x: 0.2860440127672349d, y: 0.20372948649416378d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522904851938106d, y: 0.7295688918154105d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.751657739596308d, y: 0.5542948213254423d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068364815521523d, y: 0.5088092949456521d), new NpgsqlTypes.NpgsqlPoint(x: 0.8282214807340683d, y: 0.8262984782065214d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40165846646201353d, y: 0.3519305878970106d), new NpgsqlTypes.NpgsqlPoint(x: 0.08062022546387637d, y: 0.6198185257292061d), new NpgsqlTypes.NpgsqlPoint(x: 0.22860768893335193d, y: 0.4513029570392153d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4476589223425145d, y: 0.040835185488736436d), new NpgsqlTypes.NpgsqlPoint(x: 0.5877940766163472d, y: 0.7729130706192525d), new NpgsqlTypes.NpgsqlPoint(x: 0.010102113087825604d, y: 0.4494808867207173d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5229661057678311d, y: 0.4285397166675867d), new NpgsqlTypes.NpgsqlPoint(x: 0.20531284433029495d, y: 0.9128365820956079d), new NpgsqlTypes.NpgsqlPoint(x: 0.7226517285897194d, y: 0.951534803521859d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7702869317077652d, y: 0.18185100869640736d), new NpgsqlTypes.NpgsqlPoint(x: 0.5881064645868463d, y: 0.4782166887105258d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535098378139556d, y: 0.06901715168836275d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2260537218744313d, y: 0.40751709519806456d), new NpgsqlTypes.NpgsqlPoint(x: 0.09572938312624801d, y: 0.43516865754152945d), new NpgsqlTypes.NpgsqlPoint(x: 0.23663315432990661d, y: 0.20657940169641797d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38177510450458796d, y: 0.13422044376787834d), new NpgsqlTypes.NpgsqlPoint(x: 0.9489249435937939d, y: 0.30487668394498324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7994470540171618d, y: 0.6891779605984929d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15978432802248133d, y: 0.5103746992017554d), new NpgsqlTypes.NpgsqlPoint(x: 0.6939843542193997d, y: 0.7220549561438951d), new NpgsqlTypes.NpgsqlPoint(x: 0.4881335632037528d, y: 0.03586938161125641d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.680744009931836d, y: 0.7688301134385889d), new NpgsqlTypes.NpgsqlPoint(x: 0.5535228185085562d, y: 0.3515730747488517d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688550069539178d, y: 0.20945433678849923d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5738705390391611d, y: 0.5271058819416903d), new NpgsqlTypes.NpgsqlPoint(x: 0.2817983240301354d, y: 0.5050225805634735d), new NpgsqlTypes.NpgsqlPoint(x: 0.7832852039861701d, y: 0.9997870290789305d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9363918409232489d, y: 0.256453578727474d), new NpgsqlTypes.NpgsqlPoint(x: 0.2729372372840868d, y: 0.9734829437164773d), new NpgsqlTypes.NpgsqlPoint(x: 0.8459708249920668d, y: 0.2905532543387328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6910076738908659d, y: 0.5140663169065266d), new NpgsqlTypes.NpgsqlPoint(x: 0.45077310429390316d, y: 0.6012007306001763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8622960126249238d, y: 0.308160199391743d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.737667784745065d, y: 0.27539009265133785d), new NpgsqlTypes.NpgsqlPoint(x: 0.05116523328282496d, y: 0.15845196790473415d), new NpgsqlTypes.NpgsqlPoint(x: 0.06774610336701836d, y: 0.9523421180049095d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.41573530481513443d, y: 0.9381386234475891d), new NpgsqlTypes.NpgsqlPoint(x: 0.3686546064526697d, y: 0.3791502153151316d), new NpgsqlTypes.NpgsqlPoint(x: 0.05636029732928216d, y: 0.3444446623229165d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9055587567284428d, y: 0.11437476188169848d), new NpgsqlTypes.NpgsqlPoint(x: 0.05905909507414253d, y: 0.19432317478064576d), new NpgsqlTypes.NpgsqlPoint(x: 0.6683150172163438d, y: 0.1671367997825236d)), }, }, },
    NullableValue = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2735857535350198d, y: 0.5501269392948034d), new NpgsqlTypes.NpgsqlPoint(x: 0.6861101813445805d, y: 0.0846397336196667d), new NpgsqlTypes.NpgsqlPoint(x: 0.24928437494102795d, y: 0.374257486003191d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5502708995631052d, y: 0.3534691937816198d), new NpgsqlTypes.NpgsqlPoint(x: 0.4295792533187044d, y: 0.7038469485090675d), new NpgsqlTypes.NpgsqlPoint(x: 0.009436270479880271d, y: 0.6336660449889489d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27732953649714864d, y: 0.9216704441888772d), new NpgsqlTypes.NpgsqlPoint(x: 0.7633105213349066d, y: 0.08777095522908918d), new NpgsqlTypes.NpgsqlPoint(x: 0.11478473703872161d, y: 0.49691557130027875d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2873608473260393d, y: 0.8595465142205468d), new NpgsqlTypes.NpgsqlPoint(x: 0.17621901028922882d, y: 0.8253623423825868d), new NpgsqlTypes.NpgsqlPoint(x: 0.25556207796130803d, y: 0.7816370245359417d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.822752049494405d, y: 0.07965424876277982d), new NpgsqlTypes.NpgsqlPoint(x: 0.1105061876777137d, y: 0.8345916766517483d), new NpgsqlTypes.NpgsqlPoint(x: 0.774322375281068d, y: 0.9340268061114531d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5016341030158359d, y: 0.8910438022467518d), new NpgsqlTypes.NpgsqlPoint(x: 0.17427333539653678d, y: 0.042948138673196246d), new NpgsqlTypes.NpgsqlPoint(x: 0.40902748938255284d, y: 0.2747096395265678d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9297270655056049d, y: 0.20882937503182297d), new NpgsqlTypes.NpgsqlPoint(x: 0.476246422450339d, y: 0.02572945912292357d), new NpgsqlTypes.NpgsqlPoint(x: 0.9406699447192669d, y: 0.27876735740822d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1369102882391432d, y: 0.433886455097398d), new NpgsqlTypes.NpgsqlPoint(x: 0.4458916647555661d, y: 0.657025026015822d), new NpgsqlTypes.NpgsqlPoint(x: 0.0788701703687017d, y: 0.5643988311839765d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26550711848505737d, y: 0.4829649375438059d), new NpgsqlTypes.NpgsqlPoint(x: 0.7226404207063105d, y: 0.8852666717298873d), new NpgsqlTypes.NpgsqlPoint(x: 0.4603297924895846d, y: 0.1291500751808643d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.473379847454655d, y: 0.0035595887691901584d), new NpgsqlTypes.NpgsqlPoint(x: 0.9433422250417837d, y: 0.36765075856695284d), new NpgsqlTypes.NpgsqlPoint(x: 0.589387338095515d, y: 0.7869929062989619d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.987929373529895d, y: 0.5607161851477931d), new NpgsqlTypes.NpgsqlPoint(x: 0.6478928282467427d, y: 0.8819293332002394d), new NpgsqlTypes.NpgsqlPoint(x: 0.8257365111243729d, y: 0.16126325117503448d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2696328769080293d, y: 0.17711130759435367d), new NpgsqlTypes.NpgsqlPoint(x: 0.7010232852251473d, y: 0.4398832386936472d), new NpgsqlTypes.NpgsqlPoint(x: 0.9571739559467829d, y: 0.2685784597423886d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18237925586422388d, y: 0.2540516073325745d), new NpgsqlTypes.NpgsqlPoint(x: 0.5766126676677819d, y: 0.5855072218637788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7043447616615873d, y: 0.3228156467417478d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6396768989877165d, y: 0.4258461972101132d), new NpgsqlTypes.NpgsqlPoint(x: 0.10006931440862021d, y: 0.5584940802038153d), new NpgsqlTypes.NpgsqlPoint(x: 0.20777723350012411d, y: 0.8003746301085163d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9581516652982569d, y: 0.6839403383479803d), new NpgsqlTypes.NpgsqlPoint(x: 0.15654768314164724d, y: 0.7155911567505957d), new NpgsqlTypes.NpgsqlPoint(x: 0.6534229541431597d, y: 0.3667325715261357d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5811271616899482d, y: 0.9227061422273346d), new NpgsqlTypes.NpgsqlPoint(x: 0.25104588393938965d, y: 0.6866738833295829d), new NpgsqlTypes.NpgsqlPoint(x: 0.8091815509141647d, y: 0.5988878431803528d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8774869650642515d, y: 0.9583205954940542d), new NpgsqlTypes.NpgsqlPoint(x: 0.9248361753567143d, y: 0.5429951469972362d), new NpgsqlTypes.NpgsqlPoint(x: 0.49679540580858805d, y: 0.7552914852261396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.860703660038253d, y: 0.28232510454667914d), new NpgsqlTypes.NpgsqlPoint(x: 0.5229242528476086d, y: 0.016254813865710926d), new NpgsqlTypes.NpgsqlPoint(x: 0.32902584359069265d, y: 0.12436142860229071d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09494783007228424d, y: 0.39195969423414356d), new NpgsqlTypes.NpgsqlPoint(x: 0.0002753356473570445d, y: 0.5313572204613982d), new NpgsqlTypes.NpgsqlPoint(x: 0.46550208883915145d, y: 0.7672916350183911d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5193712335199853d, y: 0.9252936240684008d), new NpgsqlTypes.NpgsqlPoint(x: 0.5582556642983735d, y: 0.8312199671554424d), new NpgsqlTypes.NpgsqlPoint(x: 0.616705386070708d, y: 0.36001558434874115d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8441821882408812d, y: 0.701593080360014d), new NpgsqlTypes.NpgsqlPoint(x: 0.839183892976105d, y: 0.6117329235115219d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124090265823921d, y: 0.9754949702467185d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5619103674931613d, y: 0.9499017248490214d), new NpgsqlTypes.NpgsqlPoint(x: 0.9850884435141949d, y: 0.7091724408897827d), new NpgsqlTypes.NpgsqlPoint(x: 0.31255588011736013d, y: 0.8478933788465424d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7105964269796129d, y: 0.08218422362571598d), new NpgsqlTypes.NpgsqlPoint(x: 0.2241279168484388d, y: 0.3338503113232453d), new NpgsqlTypes.NpgsqlPoint(x: 0.357388605518174d, y: 0.13839957534704328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07851429515095365d, y: 0.4017966425760825d), new NpgsqlTypes.NpgsqlPoint(x: 0.02191189930914994d, y: 0.37667701395715814d), new NpgsqlTypes.NpgsqlPoint(x: 0.6741966235574836d, y: 0.5088465790842098d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15386966839709149d, y: 0.8612436987027671d), new NpgsqlTypes.NpgsqlPoint(x: 0.2931119710217511d, y: 0.37013376249842633d), new NpgsqlTypes.NpgsqlPoint(x: 0.0474635670658029d, y: 0.8288238612003814d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5143419494254173d, y: 0.27572940117438516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7317334263306874d, y: 0.5799722068119784d), new NpgsqlTypes.NpgsqlPoint(x: 0.16620454561674192d, y: 0.7880443503650475d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4328831461398259d, y: 0.9338511690052461d), new NpgsqlTypes.NpgsqlPoint(x: 0.406708169733179d, y: 0.7608292046476456d), new NpgsqlTypes.NpgsqlPoint(x: 0.715976509151337d, y: 0.7085722231627126d)), }, }, },
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonMMArrayD3E1M
{
    Id = 184,
    Value = 
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42353803956106795d, y: 0.726227736860816d), new NpgsqlTypes.NpgsqlPoint(x: 0.76795272202421d, y: 0.5661198576444118d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354007566380682d, y: 0.6140341550654796d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15978440443548914d, y: 0.36676817021661057d), new NpgsqlTypes.NpgsqlPoint(x: 0.625155798072619d, y: 0.3998504056175508d), new NpgsqlTypes.NpgsqlPoint(x: 0.35856322472485247d, y: 0.9880357444864721d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42423485476321166d, y: 0.11572429397409378d), new NpgsqlTypes.NpgsqlPoint(x: 0.4748411159990281d, y: 0.9122574256673444d), new NpgsqlTypes.NpgsqlPoint(x: 0.36352624829248903d, y: 0.21990807921230004d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9705837721729302d, y: 0.3147912820415677d), new NpgsqlTypes.NpgsqlPoint(x: 0.5426290648158157d, y: 0.379581371865501d), new NpgsqlTypes.NpgsqlPoint(x: 0.9431720321271369d, y: 0.9780778606476463d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6166458029103414d, y: 0.22907733847695189d), new NpgsqlTypes.NpgsqlPoint(x: 0.07180354050195181d, y: 0.6856146388497161d), new NpgsqlTypes.NpgsqlPoint(x: 0.015375439908310806d, y: 0.30746691745494026d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15710192320856486d, y: 0.7767488559934537d), new NpgsqlTypes.NpgsqlPoint(x: 0.7098019059217563d, y: 0.18062381073480827d), new NpgsqlTypes.NpgsqlPoint(x: 0.4313073275441741d, y: 0.6727339643372875d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7107443999319447d, y: 0.8549760836855383d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305543460554271d, y: 0.8755748987178019d), new NpgsqlTypes.NpgsqlPoint(x: 0.12518445296665182d, y: 0.8750749898783485d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.024952536219440935d, y: 0.95069734988334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3535556162613178d, y: 0.5637118901122182d), new NpgsqlTypes.NpgsqlPoint(x: 0.998673484081764d, y: 0.5654744799379193d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8673542140900684d, y: 0.6480449247935504d), new NpgsqlTypes.NpgsqlPoint(x: 0.02106318542738239d, y: 0.9555318119383273d), new NpgsqlTypes.NpgsqlPoint(x: 0.8137120879092566d, y: 0.11911448347814269d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42479978655801476d, y: 0.7653526212110918d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847736298097228d, y: 0.5760113283554532d), new NpgsqlTypes.NpgsqlPoint(x: 0.5719566060670833d, y: 0.11509426572533454d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022894336513276103d, y: 0.7415731835761444d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991168415864676d, y: 0.6213627018795107d), new NpgsqlTypes.NpgsqlPoint(x: 0.7621879899049042d, y: 0.9324951477039869d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2555190219166463d, y: 0.8203070675386201d), new NpgsqlTypes.NpgsqlPoint(x: 0.1720822284992326d, y: 0.1727339417353737d), new NpgsqlTypes.NpgsqlPoint(x: 0.36980338224743803d, y: 0.6667209416520261d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30698609155813805d, y: 0.0580163858802305d), new NpgsqlTypes.NpgsqlPoint(x: 0.13628863300857041d, y: 0.8182048205629997d), new NpgsqlTypes.NpgsqlPoint(x: 0.6739736362805022d, y: 0.6692021562474092d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7508824253955204d, y: 0.48925116543663427d), new NpgsqlTypes.NpgsqlPoint(x: 0.0035094629889843576d, y: 0.6619001561240309d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003739628378457d, y: 0.6405294813659526d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2097762639637366d, y: 0.0855056897360772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8009857297522022d, y: 0.9739549874063559d), new NpgsqlTypes.NpgsqlPoint(x: 0.535667685456061d, y: 0.6699372858706849d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8291467721090877d, y: 0.49631666598153834d), new NpgsqlTypes.NpgsqlPoint(x: 0.6297837061630951d, y: 0.9979930837711325d), new NpgsqlTypes.NpgsqlPoint(x: 0.4665277301314342d, y: 0.04093760492294751d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11360177220565593d, y: 0.9315946498287427d), new NpgsqlTypes.NpgsqlPoint(x: 0.9563370713164109d, y: 0.6886134061513466d), new NpgsqlTypes.NpgsqlPoint(x: 0.7300676738497133d, y: 0.08334118701209214d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16294100370467035d, y: 0.36555777966974146d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502458218850598d, y: 0.5986046144618682d), new NpgsqlTypes.NpgsqlPoint(x: 0.7471153324588337d, y: 0.14081298266506437d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03065512430035988d, y: 0.5491199587962644d), new NpgsqlTypes.NpgsqlPoint(x: 0.8420501917845771d, y: 0.9745077871899406d), new NpgsqlTypes.NpgsqlPoint(x: 0.03952591661034699d, y: 0.5026167452502907d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47136775000701925d, y: 0.09499316049582374d), new NpgsqlTypes.NpgsqlPoint(x: 0.038614519345781306d, y: 0.012470174118830002d), new NpgsqlTypes.NpgsqlPoint(x: 0.19846345319604775d, y: 0.17185510514345437d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1683317529558237d, y: 0.05030019459312851d), new NpgsqlTypes.NpgsqlPoint(x: 0.9441492492244102d, y: 0.3957137032927984d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844791898672593d, y: 0.8966271292699948d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21505069651152497d, y: 0.4709094536528792d), new NpgsqlTypes.NpgsqlPoint(x: 0.717968301777528d, y: 0.2957184353198077d), new NpgsqlTypes.NpgsqlPoint(x: 0.636330592685902d, y: 0.5458524270493373d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.964046310353221d, y: 0.8904563991769108d), new NpgsqlTypes.NpgsqlPoint(x: 0.10061594459271905d, y: 0.06195836108464481d), new NpgsqlTypes.NpgsqlPoint(x: 0.35985326710252374d, y: 0.739515248782878d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8330056583938802d, y: 0.5687773567154066d), new NpgsqlTypes.NpgsqlPoint(x: 0.7327151065051036d, y: 0.9994773377336127d), new NpgsqlTypes.NpgsqlPoint(x: 0.7379029045350354d, y: 0.6247111153722268d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30499939552891353d, y: 0.3923693905601131d), new NpgsqlTypes.NpgsqlPoint(x: 0.6735203519609787d, y: 0.43627552447890705d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128826621957226d, y: 0.3324009521702196d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42827169068982185d, y: 0.30519858460933846d), new NpgsqlTypes.NpgsqlPoint(x: 0.7057333921237372d, y: 0.9978668651967803d), new NpgsqlTypes.NpgsqlPoint(x: 0.6796273438627628d, y: 0.2752913283566426d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6995778293298809d, y: 0.17843899511926753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5845813982986354d, y: 0.03179980223683454d), new NpgsqlTypes.NpgsqlPoint(x: 0.4126328191371459d, y: 0.7942155785055451d)), }, }, },
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd3e1mi(
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd3e1mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]), 
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

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd3e1mi_id
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd3e1mi_id", 
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
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd3e1mi_id
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
    npgsqlpolygonpolygonmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
                NpgsqlTypes.NpgsqlPolygon[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).TypedValue = _testData[4].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28149523262677945d, y: 0.2611615738980331d), new NpgsqlTypes.NpgsqlPoint(x: 0.3141064049158291d, y: 0.5327054960937995d), new NpgsqlTypes.NpgsqlPoint(x: 0.6770540597924931d, y: 0.05721961772014228d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1162514773091512d, y: 0.44395407678628906d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123118249077875d, y: 0.7387397520238652d), new NpgsqlTypes.NpgsqlPoint(x: 0.14871639316169805d, y: 0.6182479476777268d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8933332144498088d, y: 0.5935149514751048d), new NpgsqlTypes.NpgsqlPoint(x: 0.4851396517527562d, y: 0.048285888388460596d), new NpgsqlTypes.NpgsqlPoint(x: 0.6140479858670382d, y: 0.174407560214644d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6058148983080862d, y: 0.4860955742282217d), new NpgsqlTypes.NpgsqlPoint(x: 0.1648273195942095d, y: 0.32909570767642293d), new NpgsqlTypes.NpgsqlPoint(x: 0.09143801656488604d, y: 0.5587832262339449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15908406425952182d, y: 0.5841187231486092d), new NpgsqlTypes.NpgsqlPoint(x: 0.6421567297037615d, y: 0.7960989121796693d), new NpgsqlTypes.NpgsqlPoint(x: 0.33257634508862466d, y: 0.8738554082941771d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7481258974211369d, y: 0.6587658421840616d), new NpgsqlTypes.NpgsqlPoint(x: 0.7955856730076821d, y: 0.17324881682723636d), new NpgsqlTypes.NpgsqlPoint(x: 0.27985032224260875d, y: 0.18897572274973107d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6013457612769821d, y: 0.8229956714438526d), new NpgsqlTypes.NpgsqlPoint(x: 0.7102049488970589d, y: 0.47991876144977885d), new NpgsqlTypes.NpgsqlPoint(x: 0.5088047490131674d, y: 0.0291649595830894d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20842591502855545d, y: 0.6772076731521213d), new NpgsqlTypes.NpgsqlPoint(x: 0.5261730225428016d, y: 0.22184449171198317d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654848776698838d, y: 0.06567547510000493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4070928405383093d, y: 0.9325540410999752d), new NpgsqlTypes.NpgsqlPoint(x: 0.2370039919380421d, y: 0.13173570104248078d), new NpgsqlTypes.NpgsqlPoint(x: 0.16923545985491317d, y: 0.8546111612861906d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06972767619456444d, y: 0.8115939197791587d), new NpgsqlTypes.NpgsqlPoint(x: 0.6519724985817096d, y: 0.7017846556640157d), new NpgsqlTypes.NpgsqlPoint(x: 0.6624861708685672d, y: 0.7439716118613776d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33339712777932506d, y: 0.8445702036116319d), new NpgsqlTypes.NpgsqlPoint(x: 0.0726768828255584d, y: 0.23630353747366528d), new NpgsqlTypes.NpgsqlPoint(x: 0.0867351286873731d, y: 0.9905880760888339d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5685448533171873d, y: 0.7189313961734414d), new NpgsqlTypes.NpgsqlPoint(x: 0.4356187575865189d, y: 0.6972399295284224d), new NpgsqlTypes.NpgsqlPoint(x: 0.40359929139905004d, y: 0.5502186885373096d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.043344996662584956d, y: 0.8166189445435629d), new NpgsqlTypes.NpgsqlPoint(x: 0.8793423233657491d, y: 0.3530875831505351d), new NpgsqlTypes.NpgsqlPoint(x: 0.5009980606961932d, y: 0.6419430905931576d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11120516781769163d, y: 0.9494686476191485d), new NpgsqlTypes.NpgsqlPoint(x: 0.6196614689793354d, y: 0.022226542857682108d), new NpgsqlTypes.NpgsqlPoint(x: 0.5514353405621402d, y: 0.8493756455165197d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48131484775719646d, y: 0.9279174697748446d), new NpgsqlTypes.NpgsqlPoint(x: 0.6161580354293893d, y: 0.39176176487027825d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556599357340424d, y: 0.30284553617278387d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.918961909933779d, y: 0.6849905696653014d), new NpgsqlTypes.NpgsqlPoint(x: 0.6359173733637151d, y: 0.7291257267488543d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728215769520907d, y: 0.8244023981181222d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7026492365899973d, y: 0.18628674398614709d), new NpgsqlTypes.NpgsqlPoint(x: 0.24098818196186678d, y: 0.9352945486414308d), new NpgsqlTypes.NpgsqlPoint(x: 0.48557261806657637d, y: 0.9126989611955785d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.993966817439379d, y: 0.35309756775153434d), new NpgsqlTypes.NpgsqlPoint(x: 0.4330013553591662d, y: 0.05493248435348064d), new NpgsqlTypes.NpgsqlPoint(x: 0.7483838497794003d, y: 0.012237785626435738d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32470675609455524d, y: 0.09342350660928755d), new NpgsqlTypes.NpgsqlPoint(x: 0.058783018015928334d, y: 0.34523155109152803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5604783955190177d, y: 0.1773704259456701d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9962658175881501d, y: 0.6017509869487973d), new NpgsqlTypes.NpgsqlPoint(x: 0.15202629132762424d, y: 0.16329393905860268d), new NpgsqlTypes.NpgsqlPoint(x: 0.6734814552594547d, y: 0.6568311927256949d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.003881931897095292d, y: 0.4134906822266834d), new NpgsqlTypes.NpgsqlPoint(x: 0.1868785847301423d, y: 0.5338951989072598d), new NpgsqlTypes.NpgsqlPoint(x: 0.12474215563942925d, y: 0.304209320102117d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1281474052523215d, y: 0.8797009679846516d), new NpgsqlTypes.NpgsqlPoint(x: 0.7185622394868785d, y: 0.9841363710042176d), new NpgsqlTypes.NpgsqlPoint(x: 0.6109907235431385d, y: 0.8146461189617621d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8823006178034026d, y: 0.3348968777596729d), new NpgsqlTypes.NpgsqlPoint(x: 0.2601256727153275d, y: 0.7424498357130359d), new NpgsqlTypes.NpgsqlPoint(x: 0.22630967727152118d, y: 0.9559574535455634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8142875554534182d, y: 0.34596497325216646d), new NpgsqlTypes.NpgsqlPoint(x: 0.16989825071241837d, y: 0.46160870266168674d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154237154687717d, y: 0.6193342448314135d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4037252687849805d, y: 0.3059101444756065d), new NpgsqlTypes.NpgsqlPoint(x: 0.9056450501510903d, y: 0.6026271079345238d), new NpgsqlTypes.NpgsqlPoint(x: 0.890795829054644d, y: 0.21167748049654356d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5069670229381147d, y: 0.23052702113107715d), new NpgsqlTypes.NpgsqlPoint(x: 0.7083852330450704d, y: 0.5765318843242012d), new NpgsqlTypes.NpgsqlPoint(x: 0.8141058062991144d, y: 0.9032258527283863d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9850901217437645d, y: 0.27959641935020585d), new NpgsqlTypes.NpgsqlPoint(x: 0.07567136460282509d, y: 0.7148471514177572d), new NpgsqlTypes.NpgsqlPoint(x: 0.3531913596542542d, y: 0.6641029798330683d)), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).TypedValue = _testData[5].Value;

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

                    nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7927904824518932d, y: 0.4866414072525618d), new NpgsqlTypes.NpgsqlPoint(x: 0.9559224708064995d, y: 0.5230000623917379d), new NpgsqlTypes.NpgsqlPoint(x: 0.3221433819096561d, y: 0.8474170470046822d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32441558330078923d, y: 0.4616289348654794d), new NpgsqlTypes.NpgsqlPoint(x: 0.62795108728066d, y: 0.9186721589388173d), new NpgsqlTypes.NpgsqlPoint(x: 0.339073184087636d, y: 0.7090921653350845d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7973538041775338d, y: 0.22360759400069397d), new NpgsqlTypes.NpgsqlPoint(x: 0.376138350730736d, y: 0.8346608041815241d), new NpgsqlTypes.NpgsqlPoint(x: 0.484411170179911d, y: 0.9068009862191206d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.552278845058782d, y: 0.10954875134420783d), new NpgsqlTypes.NpgsqlPoint(x: 0.46413497135659854d, y: 0.517176629014531d), new NpgsqlTypes.NpgsqlPoint(x: 0.8883536923544525d, y: 0.7566968251897754d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3535563138076291d, y: 0.8058872940802629d), new NpgsqlTypes.NpgsqlPoint(x: 0.6165684129313839d, y: 0.7980383627870145d), new NpgsqlTypes.NpgsqlPoint(x: 0.968518390715218d, y: 0.16081264868008105d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27678606210858936d, y: 0.14569510282918552d), new NpgsqlTypes.NpgsqlPoint(x: 0.15692124186676182d, y: 0.5579867530629995d), new NpgsqlTypes.NpgsqlPoint(x: 0.22292768719812306d, y: 0.42043414169689286d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.67694377962968d, y: 0.2116910315969769d), new NpgsqlTypes.NpgsqlPoint(x: 0.2909683127097089d, y: 0.9253892686740997d), new NpgsqlTypes.NpgsqlPoint(x: 0.30830751723581196d, y: 0.054897713198824416d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7579452203939777d, y: 0.3358420884244966d), new NpgsqlTypes.NpgsqlPoint(x: 0.4414445924858167d, y: 0.8722272186443775d), new NpgsqlTypes.NpgsqlPoint(x: 0.35263652222244546d, y: 0.46439600523373736d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8241037969398508d, y: 0.5350915447545751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799953076836457d, y: 0.8582840784913012d), new NpgsqlTypes.NpgsqlPoint(x: 0.09654894245065015d, y: 0.9072052235696698d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.054684200873565736d, y: 0.6252854867033939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9633110409391359d, y: 0.023981805589453065d), new NpgsqlTypes.NpgsqlPoint(x: 0.00505349545361089d, y: 0.7247448751480784d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15667929456448648d, y: 0.776780459888739d), new NpgsqlTypes.NpgsqlPoint(x: 0.9481374649203832d, y: 0.03565233228040321d), new NpgsqlTypes.NpgsqlPoint(x: 0.2710319366991485d, y: 0.959760755116182d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9497722236502487d, y: 0.14969230632801434d), new NpgsqlTypes.NpgsqlPoint(x: 0.9220023443596198d, y: 0.0665743780569985d), new NpgsqlTypes.NpgsqlPoint(x: 0.9284015613926299d, y: 0.8596731026335015d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5665974077478546d, y: 0.22746286180125608d), new NpgsqlTypes.NpgsqlPoint(x: 0.04744326288103229d, y: 0.2314823600863668d), new NpgsqlTypes.NpgsqlPoint(x: 0.7131669109232621d, y: 0.279522239133286d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44510358345764955d, y: 0.7816056241473726d), new NpgsqlTypes.NpgsqlPoint(x: 0.941242105630743d, y: 0.45682638030781d), new NpgsqlTypes.NpgsqlPoint(x: 0.6625996736802874d, y: 0.4804667295413837d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9230648790854552d, y: 0.07586538957837374d), new NpgsqlTypes.NpgsqlPoint(x: 0.977364091820531d, y: 0.19839369132746953d), new NpgsqlTypes.NpgsqlPoint(x: 0.03874172224426431d, y: 0.4020234562599835d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49847915518724595d, y: 0.11737991942238657d), new NpgsqlTypes.NpgsqlPoint(x: 0.7008986161696853d, y: 0.2768134635209114d), new NpgsqlTypes.NpgsqlPoint(x: 0.3997399178611394d, y: 0.20341873101823127d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12982264965885937d, y: 0.6456600094335071d), new NpgsqlTypes.NpgsqlPoint(x: 0.8348253719457172d, y: 0.5132135778235016d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421402940578181d, y: 0.013411840919710705d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09210882462537917d, y: 0.8432353178901406d), new NpgsqlTypes.NpgsqlPoint(x: 0.3211483951018572d, y: 0.28463579322845123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6178134163507972d, y: 0.8958345892142646d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7146583603508534d, y: 0.7538704502612154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9540021988125398d, y: 0.6818493412957476d), new NpgsqlTypes.NpgsqlPoint(x: 0.05663835233620096d, y: 0.43984576972695977d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2769770775851813d, y: 0.216915843023756d), new NpgsqlTypes.NpgsqlPoint(x: 0.6716429985271579d, y: 0.6905184064840056d), new NpgsqlTypes.NpgsqlPoint(x: 0.1846888208110986d, y: 0.07963014666992407d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125547160865581d, y: 0.3515898955320548d), new NpgsqlTypes.NpgsqlPoint(x: 0.34530467714221036d, y: 0.4353487918740341d), new NpgsqlTypes.NpgsqlPoint(x: 0.7421036517823781d, y: 0.04363423552107493d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13819126412958604d, y: 0.1856321410142302d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073356670130821d, y: 0.5182364987043948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9269589043873803d, y: 0.21902251440391296d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8547275026871815d, y: 0.4370074971051382d), new NpgsqlTypes.NpgsqlPoint(x: 0.7394499994249323d, y: 0.14994919297859532d), new NpgsqlTypes.NpgsqlPoint(x: 0.3068318804142649d, y: 0.8765131798995567d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27017907127302565d, y: 0.02919818019833431d), new NpgsqlTypes.NpgsqlPoint(x: 0.20003357629011798d, y: 0.7185652067000733d), new NpgsqlTypes.NpgsqlPoint(x: 0.0911806984518132d, y: 0.622765233691191d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9335916582851987d, y: 0.3970662825717448d), new NpgsqlTypes.NpgsqlPoint(x: 0.8104871599318256d, y: 0.867771633145169d), new NpgsqlTypes.NpgsqlPoint(x: 0.42076019792424535d, y: 0.06689631457518219d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.991441234432373d, y: 0.24998120089652232d), new NpgsqlTypes.NpgsqlPoint(x: 0.2815061549323451d, y: 0.9860430400707312d), new NpgsqlTypes.NpgsqlPoint(x: 0.2013789576841316d, y: 0.49050260071039553d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7966072212188355d, y: 0.37898236956217957d), new NpgsqlTypes.NpgsqlPoint(x: 0.08524711250120864d, y: 0.46536971887857725d), new NpgsqlTypes.NpgsqlPoint(x: 0.9340542503336302d, y: 0.9356738262377673d)), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).TypedValue = _testData[6].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3468396102918736d, y: 0.36008903615430066d), new NpgsqlTypes.NpgsqlPoint(x: 0.08674521114302602d, y: 0.17655676275547183d), new NpgsqlTypes.NpgsqlPoint(x: 0.3303376839889264d, y: 0.712622749072469d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9772366948009105d, y: 0.8773088608183488d), new NpgsqlTypes.NpgsqlPoint(x: 0.964176988193821d, y: 0.7684514557305798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9953778381529362d, y: 0.7953091932254874d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8958395450704458d, y: 0.28372496720871687d), new NpgsqlTypes.NpgsqlPoint(x: 0.8074666371626377d, y: 0.3106626474399201d), new NpgsqlTypes.NpgsqlPoint(x: 0.33408932477563036d, y: 0.6520146208342708d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25344923456469814d, y: 0.2596168353647673d), new NpgsqlTypes.NpgsqlPoint(x: 0.012000227706786992d, y: 0.20549551757718199d), new NpgsqlTypes.NpgsqlPoint(x: 0.4161387687085951d, y: 0.3510146252744172d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7580986822248571d, y: 0.19369354314126097d), new NpgsqlTypes.NpgsqlPoint(x: 0.22007961156155498d, y: 0.8798573820249509d), new NpgsqlTypes.NpgsqlPoint(x: 0.7440119749678913d, y: 0.22123123248422882d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4087556774578395d, y: 0.40362806809140717d), new NpgsqlTypes.NpgsqlPoint(x: 0.16299329424403053d, y: 0.5479910333885055d), new NpgsqlTypes.NpgsqlPoint(x: 0.19563509127934875d, y: 0.2005033038810684d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6739018625235681d, y: 0.06558057107021409d), new NpgsqlTypes.NpgsqlPoint(x: 0.527019334097142d, y: 0.9830965751778519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9504791870846985d, y: 0.3709189163001019d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9261717752603201d, y: 0.23551197483148778d), new NpgsqlTypes.NpgsqlPoint(x: 0.10881557595641256d, y: 0.1753022301941436d), new NpgsqlTypes.NpgsqlPoint(x: 0.06636810273890992d, y: 0.7402230936450311d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1843732913355518d, y: 0.6531812799730992d), new NpgsqlTypes.NpgsqlPoint(x: 0.42443289601128165d, y: 0.13524304445719348d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563369229701387d, y: 0.6962237890318209d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4515334974749863d, y: 0.27850425275948143d), new NpgsqlTypes.NpgsqlPoint(x: 0.6334752547497915d, y: 0.9964398462998006d), new NpgsqlTypes.NpgsqlPoint(x: 0.08314277698157757d, y: 0.7290182097240396d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3981292053954736d, y: 0.9091339825118441d), new NpgsqlTypes.NpgsqlPoint(x: 0.7262726344826159d, y: 0.3788892605633086d), new NpgsqlTypes.NpgsqlPoint(x: 0.579488505008708d, y: 0.4285469659904966d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09023399995337489d, y: 0.22065021688180386d), new NpgsqlTypes.NpgsqlPoint(x: 0.36893590484709093d, y: 0.13457769278144016d), new NpgsqlTypes.NpgsqlPoint(x: 0.35270930022545044d, y: 0.1727855637347928d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6891785395572725d, y: 0.2392600133369549d), new NpgsqlTypes.NpgsqlPoint(x: 0.5694302144388916d, y: 0.6100145734981725d), new NpgsqlTypes.NpgsqlPoint(x: 0.35803498703650904d, y: 0.8552315432136854d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20058517351228045d, y: 0.5980124113886842d), new NpgsqlTypes.NpgsqlPoint(x: 0.9228765029479014d, y: 0.2909694501834732d), new NpgsqlTypes.NpgsqlPoint(x: 0.4530007285884047d, y: 0.2427092127017667d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5451611534427652d, y: 0.6112108905936895d), new NpgsqlTypes.NpgsqlPoint(x: 0.5082199484319321d, y: 0.623338051288113d), new NpgsqlTypes.NpgsqlPoint(x: 0.5303349833697354d, y: 0.9839760898696475d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8802222226403383d, y: 0.5600657852541001d), new NpgsqlTypes.NpgsqlPoint(x: 0.4678882286241143d, y: 0.5153670753615661d), new NpgsqlTypes.NpgsqlPoint(x: 0.13043156902329955d, y: 0.18565716033560842d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11701313973400973d, y: 0.26290595770831604d), new NpgsqlTypes.NpgsqlPoint(x: 0.1190315846029042d, y: 0.4013207282696767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9615169830831194d, y: 0.8288462405803025d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8944182572958486d, y: 0.9509683208332228d), new NpgsqlTypes.NpgsqlPoint(x: 0.7039784575660578d, y: 0.24296605430842821d), new NpgsqlTypes.NpgsqlPoint(x: 0.5773511011055764d, y: 0.7051031176296852d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04962353065705416d, y: 0.19043129076085563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255328590465286d, y: 0.8525846345471334d), new NpgsqlTypes.NpgsqlPoint(x: 0.3927394862094674d, y: 0.8294637467889429d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5043810493997918d, y: 0.14850491535322707d), new NpgsqlTypes.NpgsqlPoint(x: 0.4818303035046584d, y: 0.6075771625052805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5890085989078456d, y: 0.6235820284737914d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6765712868694139d, y: 0.7953822430266484d), new NpgsqlTypes.NpgsqlPoint(x: 0.41739165866324146d, y: 0.51020303505353d), new NpgsqlTypes.NpgsqlPoint(x: 0.8789256166211765d, y: 0.26930208573975434d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8881381860070802d, y: 0.14284454897055798d), new NpgsqlTypes.NpgsqlPoint(x: 0.11262202248617581d, y: 0.28324668595830105d), new NpgsqlTypes.NpgsqlPoint(x: 0.3234404158285592d, y: 0.7008659974936893d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.746623421658198d, y: 0.915070751357965d), new NpgsqlTypes.NpgsqlPoint(x: 0.5162367045440502d, y: 0.20925493662917238d), new NpgsqlTypes.NpgsqlPoint(x: 0.08834307456771306d, y: 0.7724950876044766d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38833475708496135d, y: 0.2720909813551884d), new NpgsqlTypes.NpgsqlPoint(x: 0.24399881663052192d, y: 0.1397233078553557d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708496629756845d, y: 0.8783840306168936d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8196571359940893d, y: 0.0339287808515194d), new NpgsqlTypes.NpgsqlPoint(x: 0.423994574296674d, y: 0.5617108501584647d), new NpgsqlTypes.NpgsqlPoint(x: 0.8694362539586518d, y: 0.8089964361469405d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9458403239895411d, y: 0.9245527027224049d), new NpgsqlTypes.NpgsqlPoint(x: 0.07100762570001307d, y: 0.05789413121830467d), new NpgsqlTypes.NpgsqlPoint(x: 0.6458008611877688d, y: 0.34628722612499485d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5620108198656704d, y: 0.2157562627898365d), new NpgsqlTypes.NpgsqlPoint(x: 0.017278903865691975d, y: 0.8337444330926806d), new NpgsqlTypes.NpgsqlPoint(x: 0.2788357945118157d, y: 0.2359683354846217d)), }, }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483632);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon[,,]>)parameters[1]).TypedValue = _testData[7].Value;

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

                    nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15895894854304204d, y: 0.09643604911379933d), new NpgsqlTypes.NpgsqlPoint(x: 0.6571797565474392d, y: 0.14976408684918463d), new NpgsqlTypes.NpgsqlPoint(x: 0.5374349346745785d, y: 0.4570430717795073d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0983950548722381d, y: 0.8851679431091618d), new NpgsqlTypes.NpgsqlPoint(x: 0.3114573266470696d, y: 0.7639024852925637d), new NpgsqlTypes.NpgsqlPoint(x: 0.05641377347229726d, y: 0.44935826490919306d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7413403658237143d, y: 0.7844501180946131d), new NpgsqlTypes.NpgsqlPoint(x: 0.16937315231713068d, y: 0.3333475789335988d), new NpgsqlTypes.NpgsqlPoint(x: 0.4061302340060414d, y: 0.5125323969023977d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8208469393954895d, y: 0.515420678007642d), new NpgsqlTypes.NpgsqlPoint(x: 0.409120952763403d, y: 0.9208467273199898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5596632632785126d, y: 0.1543898162267815d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.584566516911086d, y: 0.6735577050899192d), new NpgsqlTypes.NpgsqlPoint(x: 0.1463387137560771d, y: 0.2018454371800943d), new NpgsqlTypes.NpgsqlPoint(x: 0.55614798380937d, y: 0.18349482346318935d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2714126311212792d, y: 0.9105041097330552d), new NpgsqlTypes.NpgsqlPoint(x: 0.1683564199176859d, y: 0.5852482792763976d), new NpgsqlTypes.NpgsqlPoint(x: 0.9062344278386819d, y: 0.7438341053719554d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14726784736937049d, y: 0.611766041430563d), new NpgsqlTypes.NpgsqlPoint(x: 0.8993461083995724d, y: 0.6837294904649474d), new NpgsqlTypes.NpgsqlPoint(x: 0.17375849079525996d, y: 0.04510485600471792d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.261359519392224d, y: 0.016565308758121455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8671332596309431d, y: 0.27448133063283986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9642158642991719d, y: 0.17505582949149556d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24860552639217404d, y: 0.2289353474669753d), new NpgsqlTypes.NpgsqlPoint(x: 0.5404356997653368d, y: 0.1970274183601738d), new NpgsqlTypes.NpgsqlPoint(x: 0.42022268685593256d, y: 0.8878143692258528d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.413032357977978d, y: 0.5445429857065078d), new NpgsqlTypes.NpgsqlPoint(x: 0.8923216141123826d, y: 0.746183786461051d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047184458456122d, y: 0.6534134590725519d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9042460707285569d, y: 0.5117001698729517d), new NpgsqlTypes.NpgsqlPoint(x: 0.5911800377752054d, y: 0.007731614714429513d), new NpgsqlTypes.NpgsqlPoint(x: 0.6628195539512137d, y: 0.40370780040000964d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6125377023278743d, y: 0.6755158621973697d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432643232291227d, y: 0.8855787597756314d), new NpgsqlTypes.NpgsqlPoint(x: 0.7361467492096968d, y: 0.2631444705537451d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7882488375976935d, y: 0.21528943525955002d), new NpgsqlTypes.NpgsqlPoint(x: 0.7943329130106775d, y: 0.635785048249836d), new NpgsqlTypes.NpgsqlPoint(x: 0.9870453538803993d, y: 0.022063797782747918d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8724674947228913d, y: 0.9078130036330297d), new NpgsqlTypes.NpgsqlPoint(x: 0.8068016117587857d, y: 0.13367575921165653d), new NpgsqlTypes.NpgsqlPoint(x: 0.9989613085760376d, y: 0.3354785238957989d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23061599601775762d, y: 0.9499004960944285d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513084099201589d, y: 0.37904087335886927d), new NpgsqlTypes.NpgsqlPoint(x: 0.245338563933436d, y: 0.5211208983642203d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48787047733898714d, y: 0.7527201839401471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8456846600939504d, y: 0.8995552513032239d), new NpgsqlTypes.NpgsqlPoint(x: 0.8479278791643027d, y: 0.20801870570792713d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.638657209422146d, y: 0.39875807757617776d), new NpgsqlTypes.NpgsqlPoint(x: 0.18062655486849577d, y: 0.8585465426429884d), new NpgsqlTypes.NpgsqlPoint(x: 0.79351613645907d, y: 0.25252880078717077d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.130537387175097d, y: 0.583624734355457d), new NpgsqlTypes.NpgsqlPoint(x: 0.07883484965441079d, y: 0.7214524263316177d), new NpgsqlTypes.NpgsqlPoint(x: 0.8741525948536755d, y: 0.7720434916686548d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48224357540561413d, y: 0.7148250048845746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6425063829095176d, y: 0.11297212571544235d), new NpgsqlTypes.NpgsqlPoint(x: 0.4611660322171449d, y: 0.08836012084686762d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21357472124357457d, y: 0.7000472220277993d), new NpgsqlTypes.NpgsqlPoint(x: 0.005772125496326552d, y: 0.4780794445526262d), new NpgsqlTypes.NpgsqlPoint(x: 0.33664488352049027d, y: 0.1548332256293249d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6246866582836531d, y: 0.33551448006310747d), new NpgsqlTypes.NpgsqlPoint(x: 0.5409599797466118d, y: 0.3164677476949087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5472793860247438d, y: 0.1459080648197728d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42960394414301417d, y: 0.6069171244888895d), new NpgsqlTypes.NpgsqlPoint(x: 0.914535333113757d, y: 0.38212999818887916d), new NpgsqlTypes.NpgsqlPoint(x: 0.6769421065034312d, y: 0.32185596511061065d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1258775154209537d, y: 0.029964700137215305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413279428968144d, y: 0.2598516239551183d), new NpgsqlTypes.NpgsqlPoint(x: 0.32152184908063464d, y: 0.540844315121079d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.288084027842888d, y: 0.400796031391045d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009382709250984611d, y: 0.8402178282838093d), new NpgsqlTypes.NpgsqlPoint(x: 0.6338477158755785d, y: 0.7442276344227493d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33840193719804823d, y: 0.46955568269631276d), new NpgsqlTypes.NpgsqlPoint(x: 0.4877548248866592d, y: 0.561773975500597d), new NpgsqlTypes.NpgsqlPoint(x: 0.7927639811586779d, y: 0.5386740310488769d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.990846499806087d, y: 0.04490692598297852d), new NpgsqlTypes.NpgsqlPoint(x: 0.9519129763982093d, y: 0.5933632852470766d), new NpgsqlTypes.NpgsqlPoint(x: 0.5564427767214957d, y: 0.09295456886177156d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4452530985226977d, y: 0.6381620467637389d), new NpgsqlTypes.NpgsqlPoint(x: 0.31544583944343774d, y: 0.9673530423512233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5836498006971921d, y: 0.9594312031457402d)), }, }, }));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonmmarrayd3e1m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonmmarrayd3e1mi_id
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
    npgsqlpolygonpolygonmmarrayd3e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon[,,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonmmarrayd3e1mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon[,,] nullable = null;
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5494665432307924d, y: 0.2276961346397236d), new NpgsqlTypes.NpgsqlPoint(x: 0.3621076096408752d, y: 0.32909132909920535d), new NpgsqlTypes.NpgsqlPoint(x: 0.1897857618942329d, y: 0.3587025879702215d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8640839886304413d, y: 0.44083599424444886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9861667241093549d, y: 0.04642044968628267d), new NpgsqlTypes.NpgsqlPoint(x: 0.6014057778157437d, y: 0.21933944163723174d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8838672219701025d, y: 0.06834125167656535d), new NpgsqlTypes.NpgsqlPoint(x: 0.35076009255638996d, y: 0.834766181846957d), new NpgsqlTypes.NpgsqlPoint(x: 0.1797392644563518d, y: 0.7330552429382783d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29923491232927735d, y: 0.4012593668699036d), new NpgsqlTypes.NpgsqlPoint(x: 0.869798533366184d, y: 0.42437626746249923d), new NpgsqlTypes.NpgsqlPoint(x: 0.8261842925702635d, y: 0.8766663966003809d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1730120534337769d, y: 0.6052832027576895d), new NpgsqlTypes.NpgsqlPoint(x: 0.691361425076422d, y: 0.8184019512606939d), new NpgsqlTypes.NpgsqlPoint(x: 0.9180130523316721d, y: 0.1161944863052723d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3928617321381306d, y: 0.028664255917955295d), new NpgsqlTypes.NpgsqlPoint(x: 0.32805898485785634d, y: 0.3810626906388178d), new NpgsqlTypes.NpgsqlPoint(x: 0.483588507982576d, y: 0.747332575393742d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6885838333264724d, y: 0.516237290798267d), new NpgsqlTypes.NpgsqlPoint(x: 0.32305860343997816d, y: 0.47046446437770817d), new NpgsqlTypes.NpgsqlPoint(x: 0.33742729261751225d, y: 0.04420282011367449d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9874262868183853d, y: 0.5554747591125155d), new NpgsqlTypes.NpgsqlPoint(x: 0.32203962809627573d, y: 0.5909907017563222d), new NpgsqlTypes.NpgsqlPoint(x: 0.974360920848199d, y: 0.35966551578733263d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.846986640948791d, y: 0.48979840146519926d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641888770441159d, y: 0.9873640777175492d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888896173862706d, y: 0.9931804360537996d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19832644022824475d, y: 0.8024664378622459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6583133428448645d, y: 0.7146241113459261d), new NpgsqlTypes.NpgsqlPoint(x: 0.18641599351413685d, y: 0.3921966810737634d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9108517901331513d, y: 0.483203088984418d), new NpgsqlTypes.NpgsqlPoint(x: 0.45092378460509275d, y: 0.47094530111280375d), new NpgsqlTypes.NpgsqlPoint(x: 0.9181732836739153d, y: 0.7922418339037093d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5558757238758791d, y: 0.3048935010666196d), new NpgsqlTypes.NpgsqlPoint(x: 0.5386431529944397d, y: 0.3426287737528283d), new NpgsqlTypes.NpgsqlPoint(x: 0.6930611396344113d, y: 0.13692312924267291d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5269751651907735d, y: 0.5298151842119826d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299958090420752d, y: 0.28272398508282637d), new NpgsqlTypes.NpgsqlPoint(x: 0.12232508766555927d, y: 0.935490394618687d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6291112268211394d, y: 0.34538105214097303d), new NpgsqlTypes.NpgsqlPoint(x: 0.6066948903906098d, y: 0.39557288073875563d), new NpgsqlTypes.NpgsqlPoint(x: 0.3827531440597758d, y: 0.32124017881188616d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19120767485431012d, y: 0.22977255423780896d), new NpgsqlTypes.NpgsqlPoint(x: 0.538136922170614d, y: 0.0735153018177025d), new NpgsqlTypes.NpgsqlPoint(x: 0.5258217531418499d, y: 0.41549690697453423d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.845765579916767d, y: 0.8005064737082458d), new NpgsqlTypes.NpgsqlPoint(x: 0.24892320711286742d, y: 0.645840187414522d), new NpgsqlTypes.NpgsqlPoint(x: 0.5360367982862785d, y: 0.5766835809252571d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8505949039920833d, y: 0.42143058183319304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5010826808818395d, y: 0.7685929017118318d), new NpgsqlTypes.NpgsqlPoint(x: 0.7413737780947246d, y: 0.33493876404962497d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8543641005183189d, y: 0.6198900651092704d), new NpgsqlTypes.NpgsqlPoint(x: 0.8329442929138926d, y: 0.2432623228218006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8933209802088622d, y: 0.9576365902631463d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.48557340785857284d, y: 0.9121887148062355d), new NpgsqlTypes.NpgsqlPoint(x: 0.18907245769053038d, y: 0.9752483895888279d), new NpgsqlTypes.NpgsqlPoint(x: 0.43056913221624027d, y: 0.4015102112761806d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1647295311259952d, y: 0.6185307926763822d), new NpgsqlTypes.NpgsqlPoint(x: 0.1840468945745669d, y: 0.7810745276766988d), new NpgsqlTypes.NpgsqlPoint(x: 0.47514708355228397d, y: 0.8033949125849338d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0700868653748079d, y: 0.0005248439606311273d), new NpgsqlTypes.NpgsqlPoint(x: 0.5851732630040823d, y: 0.8796060540695634d), new NpgsqlTypes.NpgsqlPoint(x: 0.03564151741733956d, y: 0.7369323075462048d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18368439718969154d, y: 0.3968471704217228d), new NpgsqlTypes.NpgsqlPoint(x: 0.5194675042252895d, y: 0.4875126326416419d), new NpgsqlTypes.NpgsqlPoint(x: 0.14180687641266132d, y: 0.25474494681340365d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9160497921870692d, y: 0.6160293108627121d), new NpgsqlTypes.NpgsqlPoint(x: 0.8315349781583092d, y: 0.8166112177593751d), new NpgsqlTypes.NpgsqlPoint(x: 0.7654297717207796d, y: 0.6309750938073301d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.931933505009048d, y: 0.4368077857443754d), new NpgsqlTypes.NpgsqlPoint(x: 0.9596289044272868d, y: 0.9158488202531236d), new NpgsqlTypes.NpgsqlPoint(x: 0.7144857774789523d, y: 0.8890621678652095d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5511084884624287d, y: 0.12813263173858724d), new NpgsqlTypes.NpgsqlPoint(x: 0.6662143090746334d, y: 0.06975044235878025d), new NpgsqlTypes.NpgsqlPoint(x: 0.39128109810581646d, y: 0.9786624630872023d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5243546674972187d, y: 0.5493979496732835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3147899915835284d, y: 0.49631247563275294d), new NpgsqlTypes.NpgsqlPoint(x: 0.058375715282291796d, y: 0.6690879671155405d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45092668945975645d, y: 0.8892441145932385d), new NpgsqlTypes.NpgsqlPoint(x: 0.3181342584309794d, y: 0.7899799069069556d), new NpgsqlTypes.NpgsqlPoint(x: 0.824211156885547d, y: 0.5357820456218592d)), }, }, }));
                nullable =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon[,,] nullable = null;
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.005370002772008831d, y: 0.6261129903445932d), new NpgsqlTypes.NpgsqlPoint(x: 0.5701808246426088d, y: 0.31914073049982195d), new NpgsqlTypes.NpgsqlPoint(x: 0.1777764630014167d, y: 0.399606656038091d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42216967735095257d, y: 0.09839563926142048d), new NpgsqlTypes.NpgsqlPoint(x: 0.93458966160099d, y: 0.8109982128467174d), new NpgsqlTypes.NpgsqlPoint(x: 0.7739726533909684d, y: 0.2994251013073892d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.15506240476471111d, y: 0.28836989823156856d), new NpgsqlTypes.NpgsqlPoint(x: 0.7700803412158472d, y: 0.4877428968997146d), new NpgsqlTypes.NpgsqlPoint(x: 0.8140251787916533d, y: 0.07734538748804776d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39494169542784363d, y: 0.7648817805950382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223587752028736d, y: 0.22747154703991967d), new NpgsqlTypes.NpgsqlPoint(x: 0.41502247342532883d, y: 0.16541120884234772d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.590154837014903d, y: 0.06125921556373115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8258454130392894d, y: 0.11884729240650493d), new NpgsqlTypes.NpgsqlPoint(x: 0.9036459542169533d, y: 0.36173583532775033d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07061014694615608d, y: 0.633063402320581d), new NpgsqlTypes.NpgsqlPoint(x: 0.4504169736521215d, y: 0.4126419349629047d), new NpgsqlTypes.NpgsqlPoint(x: 0.04305602915366369d, y: 0.39707772152493004d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04345714017981195d, y: 0.28550565487240864d), new NpgsqlTypes.NpgsqlPoint(x: 0.5040443719168952d, y: 0.6801340609407566d), new NpgsqlTypes.NpgsqlPoint(x: 0.1771846986485489d, y: 0.17007938248330934d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21818061065431316d, y: 0.9823968577342654d), new NpgsqlTypes.NpgsqlPoint(x: 0.6141299413532092d, y: 0.2414535345021338d), new NpgsqlTypes.NpgsqlPoint(x: 0.23533762960121463d, y: 0.19023430768658722d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.25692567688724555d, y: 0.47565690841589825d), new NpgsqlTypes.NpgsqlPoint(x: 0.6065273210447248d, y: 0.5178327842097221d), new NpgsqlTypes.NpgsqlPoint(x: 0.41483628497891667d, y: 0.5368125591529488d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8032642779511756d, y: 0.3309631000144957d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966538902008057d, y: 0.4436853060156406d), new NpgsqlTypes.NpgsqlPoint(x: 0.0681551136524412d, y: 0.8782616481738328d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6185880625680611d, y: 0.31632251137686906d), new NpgsqlTypes.NpgsqlPoint(x: 0.9464316089390589d, y: 0.02273735478211525d), new NpgsqlTypes.NpgsqlPoint(x: 0.1364432585863382d, y: 0.6783246728784011d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9959031354559927d, y: 0.7204825794615085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8440636927794242d, y: 0.33357876082886506d), new NpgsqlTypes.NpgsqlPoint(x: 0.6562114966706034d, y: 0.28812034654999574d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2432641456304946d, y: 0.7426728290381744d), new NpgsqlTypes.NpgsqlPoint(x: 0.059197114234514014d, y: 0.5290552464619949d), new NpgsqlTypes.NpgsqlPoint(x: 0.8152731530834603d, y: 0.37499356520054106d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7473553933211549d, y: 0.5622966130190776d), new NpgsqlTypes.NpgsqlPoint(x: 0.5006006805471254d, y: 0.8947061904389458d), new NpgsqlTypes.NpgsqlPoint(x: 0.9516796498692914d, y: 0.9905461497156388d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06172616481396609d, y: 0.7107645932402976d), new NpgsqlTypes.NpgsqlPoint(x: 0.46853609885779723d, y: 0.4290410311402877d), new NpgsqlTypes.NpgsqlPoint(x: 0.4899376805197755d, y: 0.04785188507429594d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8694498352731092d, y: 0.001061363506871138d), new NpgsqlTypes.NpgsqlPoint(x: 0.9367702565839289d, y: 0.7798017017030173d), new NpgsqlTypes.NpgsqlPoint(x: 0.2764791916513851d, y: 0.8495488451018173d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06252408664973497d, y: 0.5425766149633985d), new NpgsqlTypes.NpgsqlPoint(x: 0.20173871029628654d, y: 0.8630944075970179d), new NpgsqlTypes.NpgsqlPoint(x: 0.11776559950259136d, y: 0.5457835331334526d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8810057441616632d, y: 0.4874986374167687d), new NpgsqlTypes.NpgsqlPoint(x: 0.3112997448513819d, y: 0.9391920630911605d), new NpgsqlTypes.NpgsqlPoint(x: 0.29597837244177205d, y: 0.7634772540385759d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20364171598143377d, y: 0.0255925537217363d), new NpgsqlTypes.NpgsqlPoint(x: 0.8754451864099629d, y: 0.5816833817592786d), new NpgsqlTypes.NpgsqlPoint(x: 0.7435770233716602d, y: 0.19338550128454768d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0142442723473436d, y: 0.20732759111893806d), new NpgsqlTypes.NpgsqlPoint(x: 0.6827308471180114d, y: 0.71546131847681d), new NpgsqlTypes.NpgsqlPoint(x: 0.7299291186574077d, y: 0.5174025165802169d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9402859374077043d, y: 0.497829868811568d), new NpgsqlTypes.NpgsqlPoint(x: 0.0788954924213745d, y: 0.26712311660765764d), new NpgsqlTypes.NpgsqlPoint(x: 0.9903046731742554d, y: 0.24770766380317322d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7922974810206228d, y: 0.2743497643572621d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095239110795726d, y: 0.6607575257715999d), new NpgsqlTypes.NpgsqlPoint(x: 0.02323924732994531d, y: 0.7310383408680825d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.82898726990358d, y: 0.8937610079261136d), new NpgsqlTypes.NpgsqlPoint(x: 0.829884945078936d, y: 0.8548219248159643d), new NpgsqlTypes.NpgsqlPoint(x: 0.8100382028150468d, y: 0.4898361174853406d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6710231629668396d, y: 0.9877956197075785d), new NpgsqlTypes.NpgsqlPoint(x: 0.8722154175317929d, y: 0.3510899262912993d), new NpgsqlTypes.NpgsqlPoint(x: 0.5174171528990833d, y: 0.33543711130945464d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39589000853844636d, y: 0.01091126220959926d), new NpgsqlTypes.NpgsqlPoint(x: 0.19217039416070203d, y: 0.6058106658448082d), new NpgsqlTypes.NpgsqlPoint(x: 0.9865850133460105d, y: 0.3475460449165414d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19381977971938635d, y: 0.3624659712132652d), new NpgsqlTypes.NpgsqlPoint(x: 0.10441115489170127d, y: 0.4815853451878026d), new NpgsqlTypes.NpgsqlPoint(x: 0.07469332315749433d, y: 0.2567728291372723d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7303382774227188d, y: 0.31838098198942366d), new NpgsqlTypes.NpgsqlPoint(x: 0.00029231491491710226d, y: 0.5691123142047617d), new NpgsqlTypes.NpgsqlPoint(x: 0.3057031772826475d, y: 0.27243436664123877d)), }, }, }));
                nullable = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlPolygon[,,] { { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9230736083009765d, y: 0.8250020282106626d), new NpgsqlTypes.NpgsqlPoint(x: 0.9070939805057305d, y: 0.6992299828889761d), new NpgsqlTypes.NpgsqlPoint(x: 0.7536210141052123d, y: 0.7835942626828954d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9051573823848943d, y: 0.1561710078023666d), new NpgsqlTypes.NpgsqlPoint(x: 0.4072264333686524d, y: 0.1590465012420338d), new NpgsqlTypes.NpgsqlPoint(x: 0.04989551164575634d, y: 0.7038126299789151d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6860380972986079d, y: 0.24108370707515914d), new NpgsqlTypes.NpgsqlPoint(x: 0.7916009142514967d, y: 0.4361579488604306d), new NpgsqlTypes.NpgsqlPoint(x: 0.8559622835848822d, y: 0.4213978542735384d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5345318005429025d, y: 0.37710899221078387d), new NpgsqlTypes.NpgsqlPoint(x: 0.43666212277861516d, y: 0.9733805653809641d), new NpgsqlTypes.NpgsqlPoint(x: 0.22727774481379026d, y: 0.05231869876705242d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6603834530355827d, y: 0.8589156074359212d), new NpgsqlTypes.NpgsqlPoint(x: 0.8397366571668489d, y: 0.5182045819257209d), new NpgsqlTypes.NpgsqlPoint(x: 0.5028515313035706d, y: 0.6439142188849855d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03895816264470486d, y: 0.3994055455718858d), new NpgsqlTypes.NpgsqlPoint(x: 0.2491877785452017d, y: 0.3386505713629211d), new NpgsqlTypes.NpgsqlPoint(x: 0.36246678643966046d, y: 0.5849129483638835d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3617694202516827d, y: 0.8112377423144868d), new NpgsqlTypes.NpgsqlPoint(x: 0.4075016079976086d, y: 0.43171622321552616d), new NpgsqlTypes.NpgsqlPoint(x: 0.803051362250414d, y: 0.30868852581446493d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39159677323289355d, y: 0.12158901560356383d), new NpgsqlTypes.NpgsqlPoint(x: 0.17888703745560908d, y: 0.11901415858859765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8974894011482513d, y: 0.4581348876809598d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6358084343612207d, y: 0.0952737147059568d), new NpgsqlTypes.NpgsqlPoint(x: 0.7147906690033821d, y: 0.03431356517428952d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709230521684719d, y: 0.812474143057176d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17223358977097203d, y: 0.2659019732078687d), new NpgsqlTypes.NpgsqlPoint(x: 0.06921330570238748d, y: 0.42088472789036324d), new NpgsqlTypes.NpgsqlPoint(x: 0.24650524318805955d, y: 0.32169338929252533d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9313424668747489d, y: 0.22151305764794416d), new NpgsqlTypes.NpgsqlPoint(x: 0.7618501130442437d, y: 0.26848719997969894d), new NpgsqlTypes.NpgsqlPoint(x: 0.49966368420374085d, y: 0.5921410393276112d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3865473656884095d, y: 0.4790472587313016d), new NpgsqlTypes.NpgsqlPoint(x: 0.48370306062686363d, y: 0.7184082323655561d), new NpgsqlTypes.NpgsqlPoint(x: 0.7641829266734766d, y: 0.7519154636760681d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33681437256369007d, y: 0.839240974392767d), new NpgsqlTypes.NpgsqlPoint(x: 0.3618081691704311d, y: 0.9481527572882877d), new NpgsqlTypes.NpgsqlPoint(x: 0.449129737940434d, y: 0.14686358706847957d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3835508185903691d, y: 0.42956763921674523d), new NpgsqlTypes.NpgsqlPoint(x: 0.45858897516306496d, y: 0.011028856097184625d), new NpgsqlTypes.NpgsqlPoint(x: 0.08693699150627121d, y: 0.8902067355382763d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3867015570905906d, y: 0.16844100344120683d), new NpgsqlTypes.NpgsqlPoint(x: 0.36057508838264685d, y: 0.3758796864145926d), new NpgsqlTypes.NpgsqlPoint(x: 0.5127029445060294d, y: 0.6665689491378765d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6494544516934546d, y: 0.5070796986054376d), new NpgsqlTypes.NpgsqlPoint(x: 0.2773886139736236d, y: 0.32244185843978934d), new NpgsqlTypes.NpgsqlPoint(x: 0.023084183830398453d, y: 0.123108395386472d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8929193222144625d, y: 0.18942310717820166d), new NpgsqlTypes.NpgsqlPoint(x: 0.23069104995057288d, y: 0.30287105426637917d), new NpgsqlTypes.NpgsqlPoint(x: 0.5937380871374536d, y: 0.45143704932417306d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44228192692280077d, y: 0.5273426259260731d), new NpgsqlTypes.NpgsqlPoint(x: 0.8790956533196377d, y: 0.2358128565629375d), new NpgsqlTypes.NpgsqlPoint(x: 0.38928970554033593d, y: 0.44844280824850524d)), }, }, { { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45455167492768356d, y: 0.2854673687236218d), new NpgsqlTypes.NpgsqlPoint(x: 0.21085859880732793d, y: 0.511958305614753d), new NpgsqlTypes.NpgsqlPoint(x: 0.19893073856529597d, y: 0.15815652789986623d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2381022260847252d, y: 0.24690158789911598d), new NpgsqlTypes.NpgsqlPoint(x: 0.9999845792614259d, y: 0.297823761151097d), new NpgsqlTypes.NpgsqlPoint(x: 0.9047612554976012d, y: 0.5808948416511404d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47509983744125783d, y: 0.9840509595677618d), new NpgsqlTypes.NpgsqlPoint(x: 0.10498832865743124d, y: 0.46594540734445455d), new NpgsqlTypes.NpgsqlPoint(x: 0.8452107327898718d, y: 0.6313250303309774d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8485504890328099d, y: 0.7955466416563929d), new NpgsqlTypes.NpgsqlPoint(x: 0.39410125617109426d, y: 0.6029535195891854d), new NpgsqlTypes.NpgsqlPoint(x: 0.1534241728574146d, y: 0.45685642335048204d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47806240540888867d, y: 0.2841565337530394d), new NpgsqlTypes.NpgsqlPoint(x: 0.4175737899542923d, y: 0.8968793525043603d), new NpgsqlTypes.NpgsqlPoint(x: 0.5666945703437325d, y: 0.634757108760444d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26317874021689336d, y: 0.04006449916379906d), new NpgsqlTypes.NpgsqlPoint(x: 0.4423035947905737d, y: 0.5431937715271509d), new NpgsqlTypes.NpgsqlPoint(x: 0.9162727550697535d, y: 0.5092550755040816d)), }, { new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0036071017941964323d, y: 0.38890440913297486d), new NpgsqlTypes.NpgsqlPoint(x: 0.9672886984725767d, y: 0.8753386404222888d), new NpgsqlTypes.NpgsqlPoint(x: 0.394903543761456d, y: 0.7518394570970748d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8762613364779077d, y: 0.6503529208451658d), new NpgsqlTypes.NpgsqlPoint(x: 0.12939448501544215d, y: 0.713623633994171d), new NpgsqlTypes.NpgsqlPoint(x: 0.6281758845210881d, y: 0.4815638514649103d)), new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8588985344620383d, y: 0.960064850118143d), new NpgsqlTypes.NpgsqlPoint(x: 0.4349196460942737d, y: 0.2900857667483986d), new NpgsqlTypes.NpgsqlPoint(x: 0.6382685467473623d, y: 0.5456749077928614d)), }, }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD3E1M> models = null;

                models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonMMArrayD3E1M> models = null;

                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd3e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd3e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd3e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 75;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 162;
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 80;
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[34], false);
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 91;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 91;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[30],_testData[34], false);
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
                parametr1.Value = 71;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 154;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd3e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 172;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 43;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 92;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M), typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 71, query1, 126, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 27, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 71, query1, 3, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionMMDynQuerySelectModelBatch(connection, 128, query1, 27, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[30],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 71, query1, 109, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 125, query1, 105, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTDynQuerySelectModelBatch(connection, 125, query1, 3, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonMMArrayD3E1M>();
                 ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionDynQuerySelectModelBatch(connection, 126, query1, 61, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonmmarrayd3e1m m
LEFT JOIN public.npgsqlpolygonpolygonmmarrayd3e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd3e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
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
                var models = await((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTSelectModelBatchAsync(connection, 83, 179))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[34], false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DbConnectionSTSelectModelBatch(connection, 71, 172))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[10], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[11], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[12], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[13], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[14], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[15], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[16], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[17], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[18], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[19], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[20], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[21], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[22], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[23], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[24], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[25], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[26], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[27], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[28], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[29], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[30], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[31], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 105);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));

                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SetDbConnectionSelectModelParametrs(cmd, 61);
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(27));

                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[0],_testData[8], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[1],_testData[9], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[2],_testData[10], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[3],_testData[11], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[4],_testData[12], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[5],_testData[13], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[6],_testData[14], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[7],_testData[15], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[8],_testData[16], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[9],_testData[17], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[10],_testData[18], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[11],_testData[19], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[12],_testData[20], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[13],_testData[21], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[14],_testData[22], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[15],_testData[23], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[16],_testData[24], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[17],_testData[25], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[18],_testData[26], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[19],_testData[27], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[20],_testData[28], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[21],_testData[29], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[22],_testData[30], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[23],_testData[31], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[24],_testData[32], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[25],_testData[33], false);
                NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(models[26],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD3E1MI),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonMMArrayD3E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonmmarrayd3e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonMMArrayD3E1M),
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
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
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
FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1m m
LEFT JOIN public.binary_npgsqlpolygonpolygonmmarrayd3e1mi mi ON mi.id = m.npgsqlpolygonpolygonmmarrayd3e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonMMArrayD3E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonmmarrayd3e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models =  ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonMMArrayD3E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
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
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
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
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
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
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
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
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MI), typeof(NpgsqlPolygonpolygonMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MI>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632),
                (NpgsqlTypes.NpgsqlDbType)(-2147483632)
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA), typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                var models2 = new List<NpgsqlPolygonpolygonMMArrayD3E1MIWA>();
                ((INpgsqlPolygonMArraypolygonMMArrayD3)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonmmarrayd3e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonMMArrayD3E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonMArraypolygonMMArrayD3))]
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
                var models = await ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPolygonMArraypolygonMMArrayD3)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonMMArrayD3E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

