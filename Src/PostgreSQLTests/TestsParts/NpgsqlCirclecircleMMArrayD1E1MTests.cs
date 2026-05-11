

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
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35610405886613705d, y: 0.2995034670869722d), radius: 0.6155368035756728d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10576258345664236d, y: 0.4847379539967225d), radius: 0.20058640607050449d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8840669477826066d, y: 0.2857011798145045d), radius: 0.14233811689504483d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 11,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1921755696156795d, y: 0.5472843060323608d), radius: 0.601305195119395d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426668605837705d, y: 0.2342158100420858d), radius: 0.6558610233636903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3563913687986051d, y: 0.1082863390841976d), radius: 0.22106131959179276d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7737238228427106d, y: 0.16727816089113223d), radius: 0.47308067329932413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8032573748628994d, y: 0.8420883272735207d), radius: 0.12909096885002358d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.040330510450468426d, y: 0.4717519045697579d), radius: 0.08365868075249006d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.249869299311417d, y: 0.05923891320237018d), radius: 0.12639708117201032d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6594939032392272d, y: 0.2309979295209954d), radius: 0.18258637565468594d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8264468389598424d, y: 0.28905637902043224d), radius: 0.43702194437842345d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04247924539532566d, y: 0.8826710983775545d), radius: 0.43328709692067924d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.042688940188501445d, y: 0.6042501955887658d), radius: 0.5067283593391375d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1028952114702939d, y: 0.29410860095466895d), radius: 0.05675352039758508d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.509022802905854d, y: 0.38233107862986826d), radius: 0.7786802612008384d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 21,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2940930044360218d, y: 0.27785845682635624d), radius: 0.3662611355636639d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7797982800629706d, y: 0.8853760917979048d), radius: 0.2424399816768068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7160933287981222d, y: 0.9604435909013457d), radius: 0.43569328752774505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5130623571109076d, y: 0.541590183321823d), radius: 0.8897783890572549d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 15,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33367574070097095d, y: 0.09474198874749806d), radius: 0.042213184035623796d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5264961895469935d, y: 0.827659140134013d), radius: 0.0552873048196294d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05616850107248539d, y: 0.3848728968502293d), radius: 0.7193657101569362d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.43780564470010974d, y: 0.015150993831295367d), radius: 0.9299016830835298d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1923985499568357d, y: 0.3765816485271105d), radius: 0.4251035868039611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5697555512286344d, y: 0.006368100313106639d), radius: 0.1823114796912204d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44639815864481747d, y: 0.28682581353743253d), radius: 0.8114727137272676d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41150628671803935d, y: 0.8305367596927156d), radius: 0.7790281863128875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309056507518901d, y: 0.2655849051384711d), radius: 0.9633309762241576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8059749024388332d, y: 0.10407491254724843d), radius: 0.47927121229338765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7843423578492541d, y: 0.39017528736704565d), radius: 0.9871294614906497d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7945195768840521d, y: 0.23305265667807773d), radius: 0.7317202693807052d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45782136899321957d, y: 0.6133302462808318d), radius: 0.9263124518440901d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18807745860071268d, y: 0.005178901622207355d), radius: 0.5936520012818315d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32918633439190403d, y: 0.5018943917016186d), radius: 0.8481383725774213d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.829913398549093d, y: 0.682775440952217d), radius: 0.023675400394506108d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6607407324806888d, y: 0.4296452025025972d), radius: 0.06351546518022866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24433085509786412d, y: 0.6898907376423098d), radius: 0.4138625627355633d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6150110513703846d, y: 0.635527019987991d), radius: 0.24510953158007465d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6224696404208677d, y: 0.9104123893085736d), radius: 0.3403876833080074d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8374500993493184d, y: 0.5376764840750845d), radius: 0.25599955824863496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.189574338236155d, y: 0.8528295794230086d), radius: 0.432538896638061d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9445767291928621d, y: 0.11464391263560902d), radius: 0.7803455057236982d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.857652462178753d, y: 0.9326578666937726d), radius: 0.09257744676482671d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3747178868657576d, y: 0.4622073093488034d), radius: 0.5987788400206319d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36575951614570135d, y: 0.1813119606561091d), radius: 0.6968679140273977d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.334075416162145d, y: 0.9975316733919968d), radius: 0.684456253473081d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3754329432719967d, y: 0.7512754236650475d), radius: 0.4610685341451166d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5748684085553584d, y: 0.3565234385801791d), radius: 0.716072362567111d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5171274201049667d, y: 0.7155129635715435d), radius: 0.28539701344118285d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 23,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1415846976941063d, y: 0.6386780515568816d), radius: 0.09454574400927873d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3446281176774265d, y: 0.4660748604232551d), radius: 0.9658388043887136d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37934028788257657d, y: 0.11900299569213768d), radius: 0.04907471283877907d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5939600997380283d, y: 0.8272737178309345d), radius: 0.9965731277382919d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.45806245648944677d, y: 0.8977373569227891d), radius: 0.28968759102866737d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40114329034818497d, y: 0.6968587527591851d), radius: 0.33686088068310505d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.720137982132656d, y: 0.20336838115205103d), radius: 0.43207429848664014d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17037232925424184d, y: 0.4810211639705886d), radius: 0.12061964050351448d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09448842458552098d, y: 0.649852536656404d), radius: 0.08414387534284073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46179676000098246d, y: 0.6282637090091059d), radius: 0.5934326733310464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4284194334754968d, y: 0.5717542054945055d), radius: 0.19016005199600694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6230695060856363d, y: 0.46735138320198044d), radius: 0.40403059804689356d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6311345312078485d, y: 0.39719172105827616d), radius: 0.22193922953819833d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9998360668464815d, y: 0.7259334466591233d), radius: 0.46268010831216544d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19370721224331344d, y: 0.12038340059272523d), radius: 0.8273439170360708d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 28,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3534715877839094d, y: 0.1524405410581865d), radius: 0.7024071654818553d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22696663257553085d, y: 0.5231499831986722d), radius: 0.7434869545815458d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9186567535100041d, y: 0.4464831442581789d), radius: 0.9157049083457113d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8283031312280449d, y: 0.9902513855713365d), radius: 0.2382412633866935d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2678602599773584d, y: 0.35611344599138894d), radius: 0.041155654640086414d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6546325171795756d, y: 0.4631006102448817d), radius: 0.027021440989227763d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03857593674465043d, y: 0.8386393820427097d), radius: 0.3911508585261555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5481820959280372d, y: 0.8065231626943073d), radius: 0.9513763726243558d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9042596473654536d, y: 0.6844635789148027d), radius: 0.48221943051093763d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13718264018087d, y: 0.7184003409234495d), radius: 0.619559228541543d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6992047477697789d, y: 0.7936526181516489d), radius: 0.7910715621531724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8204595689839439d, y: 0.7415935287945385d), radius: 0.45509896496873425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40101820965895574d, y: 0.601828588032754d), radius: 0.12257497953749108d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11930643287377696d, y: 0.512128039491594d), radius: 0.7152416495054884d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2520277734559776d, y: 0.3108941036986024d), radius: 0.28111561474583413d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9188612077338641d, y: 0.037738930818622785d), radius: 0.16515182129553097d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 34,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7891745688047566d, y: 0.7564585487184405d), radius: 0.8507991435962652d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14782651281564751d, y: 0.20762684419989252d), radius: 0.7956424394585886d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38179108069741363d, y: 0.612711594610911d), radius: 0.31836789076142535d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15150593962650205d, y: 0.5824043398589229d), radius: 0.07957188977229501d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24445294223750513d, y: 0.19924400061950287d), radius: 0.6232317242827046d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26762343386802956d, y: 0.9876930287804293d), radius: 0.22419290104738832d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2708037535213256d, y: 0.4715855355555544d), radius: 0.46370110801456577d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05196044626821228d, y: 0.3790869653976897d), radius: 0.6469530211212329d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7417004159712817d, y: 0.30149821043377634d), radius: 0.007397895540720567d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8772697365425267d, y: 0.7219893281108393d), radius: 0.8639683124430063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17761577975480236d, y: 0.6959824897618753d), radius: 0.4146264779886405d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12024503204933878d, y: 0.38559577613553275d), radius: 0.012352137117192297d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3812924988406098d, y: 0.9673133397780254d), radius: 0.6954182303029911d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2348144388447364d, y: 0.9734146646093326d), radius: 0.4009183716588106d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2532427406040997d, y: 0.880357495311298d), radius: 0.4385827171065797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7807400542008192d, y: 0.3120303464571156d), radius: 0.1447597887965273d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06826075798065756d, y: 0.36530550786784466d), radius: 0.10279392836972712d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 43,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6098000615646626d, y: 0.18671767979376763d), radius: 0.21795175988994042d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4853952804708149d, y: 0.49481535071730964d), radius: 0.5281391853250784d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7217976277892437d, y: 0.41120648986016706d), radius: 0.16080835624042444d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8844101229671856d, y: 0.8270783360218307d), radius: 0.9345804197432164d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.572163797765813d, y: 0.7642064619120239d), radius: 0.4085111962573261d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7153008835366149d, y: 0.7015653299060222d), radius: 0.462286383798967d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8199023121652862d, y: 0.7718128593872651d), radius: 0.988158821310634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16198361233445113d, y: 0.2490377007120882d), radius: 0.6765748308759808d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7110993146785453d, y: 0.39573264651561857d), radius: 0.2937280349860205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.259844398005202d, y: 0.04331249193318343d), radius: 0.5768117840924324d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2398474073107243d, y: 0.8238079955116127d), radius: 0.8540933141578029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6008008708507944d, y: 0.0696876358660431d), radius: 0.1937434870229684d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25785693824459377d, y: 0.5725566174272844d), radius: 0.2894986259635245d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3355873457678946d, y: 0.2987348861355317d), radius: 0.4368204178980697d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1639428238133397d, y: 0.6584776635019277d), radius: 0.6323719300684604d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.878156799572806d, y: 0.7111805623129649d), radius: 0.5267555007866088d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 79,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0353151172515902d, y: 0.45469142303620635d), radius: 0.34271215313785797d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28019156868433326d, y: 0.3887995185147515d), radius: 0.4045570549744866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3866388090212699d, y: 0.9106923007281853d), radius: 0.777061970334257d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 50,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.941790679775027d, y: 0.18397251444371754d), radius: 0.6644925815306738d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5140206126516692d, y: 0.2137087072478866d), radius: 0.9405869838842748d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09349359864092133d, y: 0.8521247316432279d), radius: 0.4907823647685897d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6939064188062859d, y: 0.8452150887948274d), radius: 0.138324156114213d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6377379691166637d, y: 0.8613763034381386d), radius: 0.7576484090894477d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7178597002715097d, y: 0.5341011609541894d), radius: 0.368685233560337d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.783497419431008d, y: 0.2770361857375805d), radius: 0.8087855279230411d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1354343708291451d, y: 0.9604947608278409d), radius: 0.4166085567073484d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 87,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3341871788810732d, y: 0.6646759420350876d), radius: 0.2524887770379125d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.168397644250892d, y: 0.5960233010944169d), radius: 0.6784515588114192d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9415540112836732d, y: 0.1376574800846474d), radius: 0.8337037677395706d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.35790003884289734d, y: 0.488048770967062d), radius: 0.9595644126243944d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1732689382766479d, y: 0.3091195233013453d), radius: 0.2432210070270555d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0451398788326286d, y: 0.31575102869515814d), radius: 0.6514165579192445d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.010311034218250748d, y: 0.09480480923073709d), radius: 0.7503204406162927d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32141124963320833d, y: 0.6371280979378536d), radius: 0.6556832162022642d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2224633741154345d, y: 0.968718611775455d), radius: 0.07571162999218162d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18630106847380545d, y: 0.9645709751477533d), radius: 0.22495325752280593d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3841391491921967d, y: 0.43848820183282067d), radius: 0.6850648303045108d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1819118932025945d, y: 0.795275486402446d), radius: 0.5896577299552866d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9721821943340926d, y: 0.7875903503700383d), radius: 0.6936763062338401d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40118223112222273d, y: 0.21599902018038242d), radius: 0.9040807392236576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8585775299792598d, y: 0.12996171302736548d), radius: 0.8145754393291029d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.00812757760382743d, y: 0.06085513898969397d), radius: 0.9000075765021117d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7803984529015952d, y: 0.30732463055116555d), radius: 0.1268131128906903d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8258383709830883d, y: 0.6894593444032742d), radius: 0.4023286587657119d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4022919631867049d, y: 0.9779763120636d), radius: 0.26848582990828507d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7041257699707526d, y: 0.8376996607389812d), radius: 0.21750297327819057d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36173727166540304d, y: 0.4433853424806631d), radius: 0.3321169904608434d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3146477115403058d, y: 0.816690555878898d), radius: 0.08718197994334687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7223491383694259d, y: 0.4008705709512289d), radius: 0.8679497415341346d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9447615614131456d, y: 0.7033041365426197d), radius: 0.43424310004956046d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10368941125197406d, y: 0.5726922069114087d), radius: 0.5282516212079152d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7048385108413762d, y: 0.06513950340774355d), radius: 0.1472880736857778d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07172959200732998d, y: 0.37149583230817207d), radius: 0.9435121242872238d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4002920691031835d, y: 0.14427619934118707d), radius: 0.34787577207435105d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6808508177229832d, y: 0.24958743202748357d), radius: 0.1706186811149849d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 67,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6717425424563003d, y: 0.924577641388055d), radius: 0.9967111385790687d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.531289905860695d, y: 0.9167602560629372d), radius: 0.9775596821141068d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8307044894073621d, y: 0.9292628161372012d), radius: 0.1738546270034489d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6059336676906717d, y: 0.4491147833649526d), radius: 0.5530354957160691d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9141759995137233d, y: 0.23709066545310842d), radius: 0.8526680766342108d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4933918937462919d, y: 0.39181278238249284d), radius: 0.43074615484657464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15637397640099004d, y: 0.0020327829517793328d), radius: 0.04953480434252955d),
},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 110,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5869609145547398d, y: 0.6693720168348403d), radius: 0.23743861325923632d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4528079461219041d, y: 0.9199797335221453d), radius: 0.3319224782661634d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5408651603110108d, y: 0.014038073894328429d), radius: 0.8030860364740415d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29348372200459405d, y: 0.12035634701211917d), radius: 0.059696338664623205d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8613877802644284d, y: 0.6271848623811421d), radius: 0.14978319339506718d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7956844176274008d, y: 0.5517970860004837d), radius: 0.9887814072147155d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9116960212059707d, y: 0.27632238645674967d), radius: 0.7468282914319594d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7995003882394736d, y: 0.004580518257347399d), radius: 0.8885441700605772d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 111,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6350216515583683d, y: 0.26554427986357865d), radius: 0.5005500253424545d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.33424339699817784d, y: 0.9506830001522026d), radius: 0.7123458695294739d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.005440660673215136d, y: 0.23994823884613792d), radius: 0.47864133428751066d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16528688089237797d, y: 0.501316409737107d), radius: 0.6417969269258103d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8677094726851854d, y: 0.04841204397986987d), radius: 0.06001284003157148d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2273438670433997d, y: 0.36304787795840876d), radius: 0.24854907902098d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5769965015129463d, y: 0.7522499424626236d), radius: 0.23157618407260117d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 118,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8483204095229921d, y: 0.7424909245301182d), radius: 0.47662702238547927d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20870389709281678d, y: 0.19645549990257538d), radius: 0.9018117110798725d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6966269177601505d, y: 0.9802189002747068d), radius: 0.19614557959579548d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8020887945859472d, y: 0.1121590493035467d), radius: 0.4030090193456044d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7273852359828434d, y: 0.2116886436756804d), radius: 0.9823524544984602d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3181742774043924d, y: 0.16029745983803811d), radius: 0.30054331517418786d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37760393725317654d, y: 0.3111766561879d), radius: 0.8878181221845932d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 121,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3049275522632737d, y: 0.36492812237661265d), radius: 0.40811846047783695d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06020586377831372d, y: 0.5407405016404401d), radius: 0.23037656892161018d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5955236881406889d, y: 0.1207077042245367d), radius: 0.0036609568319282415d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 75,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36894252121094684d, y: 0.5006235071489108d), radius: 0.2773467602009564d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23606531929665098d, y: 0.7492766618232629d), radius: 0.47074850259985823d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38244646548722927d, y: 0.35622708707444894d), radius: 0.41537331796015575d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4598200128672131d, y: 0.788833141006574d), radius: 0.5987468908974563d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6930574717493238d, y: 0.5274367240271545d), radius: 0.501836996144592d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5815567555047447d, y: 0.8306628038786101d), radius: 0.37973102141468507d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03377082097581552d, y: 0.7558203785170755d), radius: 0.7836317174926678d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29720579478335896d, y: 0.12799368793970745d), radius: 0.9531020343840706d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6425387498477898d, y: 0.02697633597872051d), radius: 0.08866270691260347d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3334487704556628d, y: 0.1265477539796871d), radius: 0.26714558157066315d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 128,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5331118197468264d, y: 0.8566505214766387d), radius: 0.3622531682245954d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8544104881261971d, y: 0.960874520427177d), radius: 0.3474652523187238d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7606172233140266d, y: 0.8340104858146214d), radius: 0.548807562517999d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.42380559418233543d, y: 0.12048983715729733d), radius: 0.36527088365340443d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.056695775335001586d, y: 0.1669715063387811d), radius: 0.39061479465521787d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4106133039375339d, y: 0.6600938706932354d), radius: 0.13094913401950836d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32803282718844384d, y: 0.11574581121771144d), radius: 0.5994537104633837d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 131,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6693365191043514d, y: 0.05827915272793949d), radius: 0.6338360484011949d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6792645400649157d, y: 0.6282360121269231d), radius: 0.25685479643242537d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1046729238606815d, y: 0.6752183717351135d), radius: 0.11424520176212549d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41709948534135666d, y: 0.4490759417782322d), radius: 0.16536963058236465d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5207290357212021d, y: 0.9825669594655572d), radius: 0.5799303944171958d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7479941350342485d, y: 0.09075163985978252d), radius: 0.0493662127009441d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9818309559217804d, y: 0.16810158353458415d), radius: 0.016165923643315483d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9689497711351136d, y: 0.12483144779436317d), radius: 0.16455164466917893d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8948445782345118d, y: 0.7106121488851509d), radius: 0.5359243851845972d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37847115645957485d, y: 0.20499480630671607d), radius: 0.9895382080957689d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22134373678592711d, y: 0.7427809933333058d), radius: 0.22329395074066205d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9438726406121882d, y: 0.5174591291040886d), radius: 0.8957201089045793d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8563697987789984d, y: 0.3661396768724373d), radius: 0.34529335470567357d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 137,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1803146322979735d, y: 0.9926148462584813d), radius: 0.6170293552093989d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.004878248744729419d, y: 0.08507771949444465d), radius: 0.6860392643327253d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2658527054358192d, y: 0.8430691244144265d), radius: 0.8847090523168505d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 145,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9924046733473039d, y: 0.36614337811332787d), radius: 0.5380879064219227d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8930175472556999d, y: 0.6260384388769682d), radius: 0.9746190843866266d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7910868105990958d, y: 0.6847516946154775d), radius: 0.816671349184196d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09587061889471027d, y: 0.6140505031110506d), radius: 0.8402065262468154d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 89,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.923578756955346d, y: 0.360434604534314d), radius: 0.7097117914334526d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4789371038176298d, y: 0.6393370094926308d), radius: 0.5426353413867722d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07485407527841093d, y: 0.10717379503583624d), radius: 0.3551858835297753d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6710755076716475d, y: 0.28817572531145075d), radius: 0.009327475331441293d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16539577895507718d, y: 0.09803914454742335d), radius: 0.9307587194553815d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.34971033300120413d, y: 0.7810679016577503d), radius: 0.7205059621554583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8257430326299303d, y: 0.9081022272514971d), radius: 0.5887910628728419d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21704715425097398d, y: 0.39414748172327463d), radius: 0.7093266503488583d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9829214882993818d, y: 0.66024266795186d), radius: 0.31864635012555154d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4144548326094363d, y: 0.9372497543008514d), radius: 0.4000701344834453d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9067806878418151d, y: 0.6406718196690532d), radius: 0.6975485748188145d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19896865765177651d, y: 0.5326015619758598d), radius: 0.9256718891971337d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6934027309144334d, y: 0.5002658077536725d), radius: 0.9040677584003475d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4393353256135045d, y: 0.8904542690700796d), radius: 0.6940469897807635d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8062621212180531d, y: 0.4796397066053678d), radius: 0.7601671357798611d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16396453015750656d, y: 0.19626909127104863d), radius: 0.20880545041809184d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6044227159023168d, y: 0.7811380388760591d), radius: 0.2352417725272039d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49685026354765416d, y: 0.41625736736243013d), radius: 0.7677005193465836d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15212847223734205d, y: 0.6397562972010582d), radius: 0.14159335796372619d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40331376365274796d, y: 0.048248545024199174d), radius: 0.4312300062855361d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 98,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23324691648547957d, y: 0.4837164939151588d), radius: 0.9418160415802389d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5836705005522583d, y: 0.3731504261889794d), radius: 0.7213240791576945d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7517721432151123d, y: 0.9174327878722423d), radius: 0.6086039449902071d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14746480019904362d, y: 0.25221735707906334d), radius: 0.8770127071915439d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17830761436931664d, y: 0.9178411994881143d), radius: 0.5473577168122755d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4245469715988226d, y: 0.01861113414280613d), radius: 0.13237047497738963d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8990749243333336d, y: 0.5066768145979791d), radius: 0.6412580791206273d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5248547311137931d, y: 0.28437542831006424d), radius: 0.41096670895241494d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2255379528146525d, y: 0.590358564033496d), radius: 0.5846110932199974d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3104171487589503d, y: 0.3673056785168427d), radius: 0.6026070240766429d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16502475015324147d, y: 0.4185951298813868d), radius: 0.1256993458362733d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5633945515466807d, y: 0.5236808620492827d), radius: 0.021784219669722438d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1830984813699058d, y: 0.6030562971617643d), radius: 0.9112512636217003d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5694610059811716d, y: 0.7004617144453542d), radius: 0.2594070401357522d),
},
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 166,
    Value = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8577164300821496d, y: 0.22104878061314837d), radius: 0.8664552822088437d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09107675730981124d, y: 0.29504921868899747d), radius: 0.5398680599201217d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06526022033597878d, y: 0.2601072109099253d), radius: 0.08852352922208617d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8714549533320781d, y: 0.3720103015547991d), radius: 0.9244685572652294d),
},
    ModelInner = new NpgsqlCirclecircleMMArrayD1E1MI
{
    Id = 99,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.78110267402695d, y: 0.2204187933155024d), radius: 0.2615433245927423d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2808056054883783d, y: 0.8756291508493572d), radius: 0.48697323887991306d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7181467838040201d, y: 0.6516005500181978d), radius: 0.8339757934001522d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleMMArrayD1E1M
{
    Id = 174,
    Value = 
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2414818159563037d, y: 0.2711112330636124d), radius: 0.30827145622698593d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3673469398126624d, y: 0.9299208443910585d), radius: 0.5572453040531863d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7620119104472489d, y: 0.1639676927051401d), radius: 0.7700794085801345d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48689248688652975d, y: 0.6167739531754339d), radius: 0.6042022913274732d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8582523381872094d, y: 0.6434630682831057d), radius: 0.0982188573109617d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7771801852084425d, y: 0.6294790255402569d), radius: 0.22361231063569764d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.750620162958154d, y: 0.6108272872386663d), radius: 0.3802379422590032d),
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
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.41150628671803935d, y: 0.8305367596927156d), radius: 0.7790281863128875d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5309056507518901d, y: 0.2655849051384711d), radius: 0.9633309762241576d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8059749024388332d, y: 0.10407491254724843d), radius: 0.47927121229338765d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7843423578492541d, y: 0.39017528736704565d), radius: 0.9871294614906497d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6224696404208677d, y: 0.9104123893085736d), radius: 0.3403876833080074d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8374500993493184d, y: 0.5376764840750845d), radius: 0.25599955824863496d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.189574338236155d, y: 0.8528295794230086d), radius: 0.432538896638061d),
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
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09448842458552098d, y: 0.649852536656404d), radius: 0.08414387534284073d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46179676000098246d, y: 0.6282637090091059d), radius: 0.5934326733310464d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4284194334754968d, y: 0.5717542054945055d), radius: 0.19016005199600694d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6230695060856363d, y: 0.46735138320198044d), radius: 0.40403059804689356d),
}));
                nullable =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[3]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8283031312280449d, y: 0.9902513855713365d), radius: 0.2382412633866935d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2678602599773584d, y: 0.35611344599138894d), radius: 0.041155654640086414d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6546325171795756d, y: 0.4631006102448817d), radius: 0.027021440989227763d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13718264018087d, y: 0.7184003409234495d), radius: 0.619559228541543d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6992047477697789d, y: 0.7936526181516489d), radius: 0.7910715621531724d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8204595689839439d, y: 0.7415935287945385d), radius: 0.45509896496873425d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40101820965895574d, y: 0.601828588032754d), radius: 0.12257497953749108d),
}));
                nullable = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlCircle[4]
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.05196044626821228d, y: 0.3790869653976897d), radius: 0.6469530211212329d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7417004159712817d, y: 0.30149821043377634d), radius: 0.007397895540720567d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8772697365425267d, y: 0.7219893281108393d), radius: 0.8639683124430063d),
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.17761577975480236d, y: 0.6959824897618753d), radius: 0.4146264779886405d),
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                Assert.That(firstItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 88;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
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
                        Assert.That(models, Has.Count.EqualTo(12));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 164;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 6;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[33],_testData[34], false);
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
                parametr1.Value = 98;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 50;
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
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[34], false);
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
                parametr1.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[34], false);
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
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 145;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[34], false);
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
                parametr1.Value = 42;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 57, query1, 137, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 89, query1, 57, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 11, query1, 35, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[27],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 87, query1, 54, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[24],_testData[34], false);
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 98, query1, 137, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[34], false);
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
                await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 155, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(secondItems2[17],_testData[34], false);
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 57, query1, 35, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[29], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[30], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[31], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[32], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[33], false);
                        FlatNpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[34], false);
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
                 ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionDynQuerySelectModelBatch(connection, 111, query1, 57, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                foreach(var batchResult in await ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatchAsync(connection, 21, 87))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[25],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[26],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[27],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[28],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[29],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                foreach(var batchResult in  ((INpgsqlCircleMArraycircleMMArrayD1)this).DbConnectionSTSelectModelBatch(connection, 118, 164))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[34], false);
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
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(22));

                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[0],_testData[13], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[1],_testData[14], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[2],_testData[15], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[3],_testData[16], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[4],_testData[17], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[5],_testData[18], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[6],_testData[19], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[7],_testData[20], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[8],_testData[21], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[9],_testData[22], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[10],_testData[23], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[11],_testData[24], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[12],_testData[25], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[13],_testData[26], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[14],_testData[27], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[15],_testData[28], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[16],_testData[29], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[17],_testData[30], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[18],_testData[31], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[19],_testData[32], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[20],_testData[33], false);
                NpgsqlCirclecircleMMArrayD1E1M.AssertModel(models[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleMArraycircleMMArrayD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleMArraycircleMMArrayD1)this).SetDbConnectionSelectModelParametrs(cmd, 110);
                var models =  ((INpgsqlCircleMArraycircleMMArrayD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

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

