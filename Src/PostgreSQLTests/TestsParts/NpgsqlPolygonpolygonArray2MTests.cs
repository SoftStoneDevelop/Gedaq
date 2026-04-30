

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
    internal partial interface INpgsqlPolygonListpolygonArray
    {
    }
    
    internal partial class NpgsqlPolygonListpolygonArray : INpgsqlPolygonListpolygonArray
    {


#region TestData

        private readonly NpgsqlPolygonpolygonArray2M[] _testData = new NpgsqlPolygonpolygonArray2M[]
        {
            new NpgsqlPolygonpolygonArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10206248979179167d, y: 0.8448682855063893d), new NpgsqlTypes.NpgsqlPoint(x: 0.6969606340268897d, y: 0.18946981414490205d), new NpgsqlTypes.NpgsqlPoint(x: 0.02785660620743391d, y: 0.9597380632655943d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5206260639067042d, y: 0.5883212146756442d), new NpgsqlTypes.NpgsqlPoint(x: 0.7952293423423586d, y: 0.7563188522325985d), new NpgsqlTypes.NpgsqlPoint(x: 0.26621124877599833d, y: 0.902859380586823d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7683878372938905d, y: 0.3459306531799188d), new NpgsqlTypes.NpgsqlPoint(x: 0.09049505630599841d, y: 0.17803689929125954d), new NpgsqlTypes.NpgsqlPoint(x: 0.9071985504332348d, y: 0.28843952414415286d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7648222821504196d, y: 0.00574588776436169d), new NpgsqlTypes.NpgsqlPoint(x: 0.38294925967994664d, y: 0.38314901450551664d), new NpgsqlTypes.NpgsqlPoint(x: 0.7558698102696522d, y: 0.6150968483671088d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26203093013464074d, y: 0.5970365365629721d), new NpgsqlTypes.NpgsqlPoint(x: 0.709412823212605d, y: 0.3264303895062233d), new NpgsqlTypes.NpgsqlPoint(x: 0.7695159410869962d, y: 0.5599027702361288d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0012025075202546365d, y: 0.5447661490943203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8582072692992531d, y: 0.8656651346205154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9358401005898335d, y: 0.6845551052251082d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.021792666336538313d, y: 0.8759142588418565d), new NpgsqlTypes.NpgsqlPoint(x: 0.5157184050815875d, y: 0.11669943407160521d), new NpgsqlTypes.NpgsqlPoint(x: 0.17036304070363106d, y: 0.30756961851454945d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7824488871442711d, y: 0.45249598436290883d), new NpgsqlTypes.NpgsqlPoint(x: 0.13893980480234513d, y: 0.7815676971582343d), new NpgsqlTypes.NpgsqlPoint(x: 0.757543775766426d, y: 0.9353243853474558d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27569322121408846d, y: 0.46882997336007914d), new NpgsqlTypes.NpgsqlPoint(x: 0.650833698905356d, y: 0.7620481524621725d), new NpgsqlTypes.NpgsqlPoint(x: 0.0185127465598256d, y: 0.4661612493850824d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9182742005034955d, y: 0.8882515954311531d), new NpgsqlTypes.NpgsqlPoint(x: 0.30388803983960355d, y: 0.7477395821890578d), new NpgsqlTypes.NpgsqlPoint(x: 0.3596591633413073d, y: 0.18465698323683877d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4104600536815336d, y: 0.22855244244205686d), new NpgsqlTypes.NpgsqlPoint(x: 0.5524656513540251d, y: 0.6616767006094242d), new NpgsqlTypes.NpgsqlPoint(x: 0.007438142925932478d, y: 0.9844793256266308d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5574465352594008d, y: 0.716501073033521d), new NpgsqlTypes.NpgsqlPoint(x: 0.3103921190275791d, y: 0.9150882747440493d), new NpgsqlTypes.NpgsqlPoint(x: 0.08853862972717286d, y: 0.49246889136373273d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4099572021167619d, y: 0.136956039069435d), new NpgsqlTypes.NpgsqlPoint(x: 0.4939153604400841d, y: 0.8193739380450983d), new NpgsqlTypes.NpgsqlPoint(x: 0.09453482289861836d, y: 0.4390009445947123d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5796214408239283d, y: 0.05841591039704386d), new NpgsqlTypes.NpgsqlPoint(x: 0.5151624670029893d, y: 0.09733307626485455d), new NpgsqlTypes.NpgsqlPoint(x: 0.39457089409718604d, y: 0.7174840758907537d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5299131812118604d, y: 0.1422679326456212d), new NpgsqlTypes.NpgsqlPoint(x: 0.10340366075363694d, y: 0.19318662102212547d), new NpgsqlTypes.NpgsqlPoint(x: 0.21515903084649024d, y: 0.5199361344292508d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9546618312313748d, y: 0.4924522937763658d), new NpgsqlTypes.NpgsqlPoint(x: 0.3589307455702929d, y: 0.17394560940623705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7920795762249853d, y: 0.038435623117642925d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44585827345766393d, y: 0.7721254679917293d), new NpgsqlTypes.NpgsqlPoint(x: 0.38873730862695355d, y: 0.7552539475349036d), new NpgsqlTypes.NpgsqlPoint(x: 0.36569228348863325d, y: 0.8035924354625771d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8689089955188476d, y: 0.3276802316100409d), new NpgsqlTypes.NpgsqlPoint(x: 0.25860348347650874d, y: 0.4891596829223923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3504189879208581d, y: 0.7717310156400521d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.959706719820674d, y: 0.1951445426378703d), new NpgsqlTypes.NpgsqlPoint(x: 0.7547019980242974d, y: 0.11760993342794845d), new NpgsqlTypes.NpgsqlPoint(x: 0.7699495402211232d, y: 0.7017799092934154d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6795672050358588d, y: 0.8968743691559147d), new NpgsqlTypes.NpgsqlPoint(x: 0.49941763978870723d, y: 0.2384378194955986d), new NpgsqlTypes.NpgsqlPoint(x: 0.3209988209997814d, y: 0.24717930700791002d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7968241390884874d, y: 0.46579717303737056d), new NpgsqlTypes.NpgsqlPoint(x: 0.38463728817253917d, y: 0.8134367534350931d), new NpgsqlTypes.NpgsqlPoint(x: 0.0010340622602524885d, y: 0.9004936708181002d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4086942784922464d, y: 0.0755776229426176d), new NpgsqlTypes.NpgsqlPoint(x: 0.9281079233006325d, y: 0.47487043109841576d), new NpgsqlTypes.NpgsqlPoint(x: 0.630898236976084d, y: 0.6190982167378614d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8408884809474044d, y: 0.10678010186853948d), new NpgsqlTypes.NpgsqlPoint(x: 0.6355267788955491d, y: 0.1182111162066245d), new NpgsqlTypes.NpgsqlPoint(x: 0.4987319710963609d, y: 0.4267705728862228d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2489357790179133d, y: 0.6555070648012433d), new NpgsqlTypes.NpgsqlPoint(x: 0.6530581017820828d, y: 0.5631006713169653d), new NpgsqlTypes.NpgsqlPoint(x: 0.04678774925620455d, y: 0.7461709245449426d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6987277822063295d, y: 0.8873293578293137d), new NpgsqlTypes.NpgsqlPoint(x: 0.9530429776985606d, y: 0.2540904123507274d), new NpgsqlTypes.NpgsqlPoint(x: 0.24687723987793475d, y: 0.45979443806497866d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4107377943118147d, y: 0.5324041336619288d), new NpgsqlTypes.NpgsqlPoint(x: 0.4282217767387191d, y: 0.6526802534452606d), new NpgsqlTypes.NpgsqlPoint(x: 0.2114902074691728d, y: 0.4549486345482604d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019560595315848306d, y: 0.6524547679392984d), new NpgsqlTypes.NpgsqlPoint(x: 0.805803557132604d, y: 0.7527800484344661d), new NpgsqlTypes.NpgsqlPoint(x: 0.6816319990325009d, y: 0.15685257529610974d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.027899830486096677d, y: 0.938957304420833d), new NpgsqlTypes.NpgsqlPoint(x: 0.09065069551976312d, y: 0.31428472434262755d), new NpgsqlTypes.NpgsqlPoint(x: 0.5468863435668281d, y: 0.820106551694081d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6521620134229472d, y: 0.6681145481264297d), new NpgsqlTypes.NpgsqlPoint(x: 0.005159923382968223d, y: 0.6863969228554608d), new NpgsqlTypes.NpgsqlPoint(x: 0.4898483124266275d, y: 0.025109136594414827d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03759374113470593d, y: 0.8080722509923728d), new NpgsqlTypes.NpgsqlPoint(x: 0.9169755023791352d, y: 0.33799167566877286d), new NpgsqlTypes.NpgsqlPoint(x: 0.14677729045335774d, y: 0.6544569154147112d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6238888437971039d, y: 0.797940757514598d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016239173757286d, y: 0.8729634301476883d), new NpgsqlTypes.NpgsqlPoint(x: 0.6728823531314871d, y: 0.07742902659621786d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3861170652961957d, y: 0.49653943710069914d), new NpgsqlTypes.NpgsqlPoint(x: 0.35659772004329915d, y: 0.06431173482456243d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725285760606335d, y: 0.42199646170582594d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29758271518845125d, y: 0.717352886432705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129495956181688d, y: 0.7565080136423096d), new NpgsqlTypes.NpgsqlPoint(x: 0.2919205246877701d, y: 0.4621680745399156d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4525373888300209d, y: 0.23146281163558702d), new NpgsqlTypes.NpgsqlPoint(x: 0.8357979182438422d, y: 0.7444466953778708d), new NpgsqlTypes.NpgsqlPoint(x: 0.4220674330819346d, y: 0.15930504812228774d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.031535033671676316d, y: 0.9584319439926776d), new NpgsqlTypes.NpgsqlPoint(x: 0.49396817307364294d, y: 0.6240302093985265d), new NpgsqlTypes.NpgsqlPoint(x: 0.7111956947350144d, y: 0.43578148605883194d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5158433056133199d, y: 0.22887937077057563d), new NpgsqlTypes.NpgsqlPoint(x: 0.2432821958797391d, y: 0.13030728214774567d), new NpgsqlTypes.NpgsqlPoint(x: 0.7375930443976466d, y: 0.1678310512027329d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5013536243437244d, y: 0.1174849005100661d), new NpgsqlTypes.NpgsqlPoint(x: 0.768581895119356d, y: 0.8691495377981975d), new NpgsqlTypes.NpgsqlPoint(x: 0.44103090258715605d, y: 0.3346805364754145d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32938634563878433d, y: 0.9069531681775408d), new NpgsqlTypes.NpgsqlPoint(x: 0.07580948457665082d, y: 0.11860826979725592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6995112589661229d, y: 0.844597752371662d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.038543528774630964d, y: 0.18564136851270108d), new NpgsqlTypes.NpgsqlPoint(x: 0.6567670543304103d, y: 0.23874832946723767d), new NpgsqlTypes.NpgsqlPoint(x: 0.9073861751123558d, y: 0.5347687740245899d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3225054315990088d, y: 0.44182245012820287d), new NpgsqlTypes.NpgsqlPoint(x: 0.5681992640335619d, y: 0.4850469275287992d), new NpgsqlTypes.NpgsqlPoint(x: 0.47680101283960474d, y: 0.6036608985967873d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3990860460700151d, y: 0.8734118019823882d), new NpgsqlTypes.NpgsqlPoint(x: 0.7314139094687524d, y: 0.1468307835809607d), new NpgsqlTypes.NpgsqlPoint(x: 0.20421698681789713d, y: 0.6369887128062297d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9786389293491468d, y: 0.5770245464108923d), new NpgsqlTypes.NpgsqlPoint(x: 0.3388952597469387d, y: 0.8797318267233203d), new NpgsqlTypes.NpgsqlPoint(x: 0.8900717170223756d, y: 0.41754382894737996d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9481347051928296d, y: 0.2854530687659397d), new NpgsqlTypes.NpgsqlPoint(x: 0.1656045601766165d, y: 0.5969525642351065d), new NpgsqlTypes.NpgsqlPoint(x: 0.5957826615197199d, y: 0.5450268845343798d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3414538417506179d, y: 0.5539050960868682d), new NpgsqlTypes.NpgsqlPoint(x: 0.3414556946681093d, y: 0.8784528210781016d), new NpgsqlTypes.NpgsqlPoint(x: 0.553436200937312d, y: 0.6383994243799332d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28857237139062064d, y: 0.9939816121751955d), new NpgsqlTypes.NpgsqlPoint(x: 0.14005810082085723d, y: 0.32486470605432816d), new NpgsqlTypes.NpgsqlPoint(x: 0.20934522994628701d, y: 0.2800557204837051d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.557648921013341d, y: 0.6973905893355636d), new NpgsqlTypes.NpgsqlPoint(x: 0.1528896196049654d, y: 0.38808505168929175d), new NpgsqlTypes.NpgsqlPoint(x: 0.5843465105490959d, y: 0.9503876718144908d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37535183143816264d, y: 0.4750701137673726d), new NpgsqlTypes.NpgsqlPoint(x: 0.6325355058729746d, y: 0.24536093169303685d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898375146636331d, y: 0.8800511411189915d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.022223674347412348d, y: 0.9963401023557336d), new NpgsqlTypes.NpgsqlPoint(x: 0.9533597434304844d, y: 0.6566602398728763d), new NpgsqlTypes.NpgsqlPoint(x: 0.7071591340466833d, y: 0.30973751058028165d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7904329622157947d, y: 0.6616478305518146d), new NpgsqlTypes.NpgsqlPoint(x: 0.5030202471970394d, y: 0.06383223253095538d), new NpgsqlTypes.NpgsqlPoint(x: 0.06835448603869387d, y: 0.3990790710468489d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012798337975558849d, y: 0.3448988757307796d), new NpgsqlTypes.NpgsqlPoint(x: 0.2821381109446025d, y: 0.4021668988521607d), new NpgsqlTypes.NpgsqlPoint(x: 0.2039873564328878d, y: 0.9483296875635941d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5637888062483009d, y: 0.8640950319237263d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637307413920475d, y: 0.4664317507766773d), new NpgsqlTypes.NpgsqlPoint(x: 0.6698806850474975d, y: 0.7244699867286342d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.972534656100957d, y: 0.31337701079486624d), new NpgsqlTypes.NpgsqlPoint(x: 0.527862450365567d, y: 0.7936389442184151d), new NpgsqlTypes.NpgsqlPoint(x: 0.8995996668547723d, y: 0.6133668262415095d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6369877517250945d, y: 0.13578333117723462d), new NpgsqlTypes.NpgsqlPoint(x: 0.7227671426330061d, y: 0.22300174161853104d), new NpgsqlTypes.NpgsqlPoint(x: 0.10522119558220566d, y: 0.4278852155072267d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8160924100948037d, y: 0.6911484743424886d), new NpgsqlTypes.NpgsqlPoint(x: 0.8298042905267456d, y: 0.7021636703620007d), new NpgsqlTypes.NpgsqlPoint(x: 0.8313266353669623d, y: 0.6589374062821606d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09772804511384092d, y: 0.8741559999849129d), new NpgsqlTypes.NpgsqlPoint(x: 0.6712019897486959d, y: 0.8737933567454121d), new NpgsqlTypes.NpgsqlPoint(x: 0.1827837033621057d, y: 0.5883234000490679d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22841852187916745d, y: 0.6200468367515741d), new NpgsqlTypes.NpgsqlPoint(x: 0.842942122235635d, y: 0.4863638587267689d), new NpgsqlTypes.NpgsqlPoint(x: 0.6905304247202787d, y: 0.06521320614767556d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5628745304657441d, y: 0.023601676484440337d), new NpgsqlTypes.NpgsqlPoint(x: 0.8827793625478307d, y: 0.5024802119530388d), new NpgsqlTypes.NpgsqlPoint(x: 0.5982239443738532d, y: 0.8805464978976932d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.42938833040816593d, y: 0.32339061352610554d), new NpgsqlTypes.NpgsqlPoint(x: 0.9032926030244169d, y: 0.7894240863705546d), new NpgsqlTypes.NpgsqlPoint(x: 0.031531241592384185d, y: 0.15019296652373526d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.902462587707968d, y: 0.42164138610520807d), new NpgsqlTypes.NpgsqlPoint(x: 0.5794572212497323d, y: 0.2542138018544423d), new NpgsqlTypes.NpgsqlPoint(x: 0.4820030896911912d, y: 0.8018653084413586d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8287847012627427d, y: 0.17455229594625865d), new NpgsqlTypes.NpgsqlPoint(x: 0.21518752341144876d, y: 0.22554987278967464d), new NpgsqlTypes.NpgsqlPoint(x: 0.1283879314235885d, y: 0.06315163370512744d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43985645314446575d, y: 0.45470998010001473d), new NpgsqlTypes.NpgsqlPoint(x: 0.17060090608119283d, y: 0.7885074906519683d), new NpgsqlTypes.NpgsqlPoint(x: 0.4767825209106107d, y: 0.6920821727668585d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6337594328975379d, y: 0.6377109545281371d), new NpgsqlTypes.NpgsqlPoint(x: 0.5941217126411743d, y: 0.6399641814344845d), new NpgsqlTypes.NpgsqlPoint(x: 0.8381899337671423d, y: 0.0351628486403508d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26503077517703144d, y: 0.13752818578059112d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489689797393894d, y: 0.45653722163988675d), new NpgsqlTypes.NpgsqlPoint(x: 0.23625937488980586d, y: 0.9335517204266791d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12726385409836205d, y: 0.9009068967061028d), new NpgsqlTypes.NpgsqlPoint(x: 0.20201628368092728d, y: 0.7131470349832238d), new NpgsqlTypes.NpgsqlPoint(x: 0.2069277654980909d, y: 0.4485853800727184d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4626790543506818d, y: 0.24278748046409304d), new NpgsqlTypes.NpgsqlPoint(x: 0.5699304105261899d, y: 0.30606600596904543d), new NpgsqlTypes.NpgsqlPoint(x: 0.11207269371876283d, y: 0.09195751329112489d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.01899555885306381d, y: 0.49788181530977105d), new NpgsqlTypes.NpgsqlPoint(x: 0.5691006604304548d, y: 0.047972716671743076d), new NpgsqlTypes.NpgsqlPoint(x: 0.4502403803720678d, y: 0.3591111427957733d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.49019938286340714d, y: 0.47972573983797273d), new NpgsqlTypes.NpgsqlPoint(x: 0.9074156848760726d, y: 0.3287833367321311d), new NpgsqlTypes.NpgsqlPoint(x: 0.43240465842628384d, y: 0.03738007859431003d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24640256285995799d, y: 0.7761098396495489d), new NpgsqlTypes.NpgsqlPoint(x: 0.447691024931414d, y: 0.046048510300180645d), new NpgsqlTypes.NpgsqlPoint(x: 0.31439410573247717d, y: 0.11839023456243325d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8471470614865942d, y: 0.3129754770815818d), new NpgsqlTypes.NpgsqlPoint(x: 0.4108224818973669d, y: 0.9710859603233364d), new NpgsqlTypes.NpgsqlPoint(x: 0.2003435864826102d, y: 0.44642953036992206d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2263220261231269d, y: 0.24084714247864636d), new NpgsqlTypes.NpgsqlPoint(x: 0.6909152638362912d, y: 0.8677090694847217d), new NpgsqlTypes.NpgsqlPoint(x: 0.7085265934995238d, y: 0.8763810070381062d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9613711316846361d, y: 0.012171182156568539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6415045411793281d, y: 0.5489409714047131d), new NpgsqlTypes.NpgsqlPoint(x: 0.3304775691772591d, y: 0.6283218135004011d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3568424407769416d, y: 0.5152287322115152d), new NpgsqlTypes.NpgsqlPoint(x: 0.8898473861956936d, y: 0.19480252863059022d), new NpgsqlTypes.NpgsqlPoint(x: 0.5187354614621054d, y: 0.48993069835186454d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9332410568657403d, y: 0.9354916846632216d), new NpgsqlTypes.NpgsqlPoint(x: 0.14475071854014343d, y: 0.42364711347833983d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466799390443284d, y: 0.04680510083921008d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8101190124984082d, y: 0.42444138133832143d), new NpgsqlTypes.NpgsqlPoint(x: 0.9249818509558141d, y: 0.3466337477823599d), new NpgsqlTypes.NpgsqlPoint(x: 0.5325701060583444d, y: 0.012170011074660536d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9877736548512317d, y: 0.271008338789975d), new NpgsqlTypes.NpgsqlPoint(x: 0.3916715035602869d, y: 0.29988474893030526d), new NpgsqlTypes.NpgsqlPoint(x: 0.4032817092993538d, y: 0.8149270684829808d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10468995656574409d, y: 0.2314042618925718d), new NpgsqlTypes.NpgsqlPoint(x: 0.7357682410977154d, y: 0.14077930986533715d), new NpgsqlTypes.NpgsqlPoint(x: 0.2543358937316562d, y: 0.5906701661052949d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7441946828177548d, y: 0.8345725376444401d), new NpgsqlTypes.NpgsqlPoint(x: 0.025630593419818437d, y: 0.9571301147144324d), new NpgsqlTypes.NpgsqlPoint(x: 0.7292083050796896d, y: 0.6601008439674197d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22698851601685233d, y: 0.11274470391374591d), new NpgsqlTypes.NpgsqlPoint(x: 0.153676577218817d, y: 0.046378889594258066d), new NpgsqlTypes.NpgsqlPoint(x: 0.8680540528032487d, y: 0.9807419647369533d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46689327072995257d, y: 0.15946693190276362d), new NpgsqlTypes.NpgsqlPoint(x: 0.7450498913806949d, y: 0.8489135050529832d), new NpgsqlTypes.NpgsqlPoint(x: 0.4955692154141065d, y: 0.855431126330558d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7215669568218258d, y: 0.7520113394442761d), new NpgsqlTypes.NpgsqlPoint(x: 0.002992613577878611d, y: 0.7810729172289131d), new NpgsqlTypes.NpgsqlPoint(x: 0.19507847832206338d, y: 0.35656108180497514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.708960401980181d, y: 0.9503837089640244d), new NpgsqlTypes.NpgsqlPoint(x: 0.4516717537034457d, y: 0.34997529579866227d), new NpgsqlTypes.NpgsqlPoint(x: 0.33032233145689893d, y: 0.5971784897753656d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.458368718050987d, y: 0.7033784482551306d), new NpgsqlTypes.NpgsqlPoint(x: 0.08425697817950883d, y: 0.5572286128079296d), new NpgsqlTypes.NpgsqlPoint(x: 0.20303874160329327d, y: 0.408395025657203d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12716331726259722d, y: 0.6152346596989302d), new NpgsqlTypes.NpgsqlPoint(x: 0.10474467125204268d, y: 0.7878341045408085d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198245926878578d, y: 0.9119630505597012d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8467050733709004d, y: 0.27761740174242033d), new NpgsqlTypes.NpgsqlPoint(x: 0.9536867969534742d, y: 0.17699000960883182d), new NpgsqlTypes.NpgsqlPoint(x: 0.5302067884406813d, y: 0.2519664289400423d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9999212228741186d, y: 0.16823789841452996d), new NpgsqlTypes.NpgsqlPoint(x: 0.30199352350951947d, y: 0.5576851053474149d), new NpgsqlTypes.NpgsqlPoint(x: 0.11425550688905428d, y: 0.5850218489376872d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14016344562064909d, y: 0.24026780823894311d), new NpgsqlTypes.NpgsqlPoint(x: 0.18281104212354105d, y: 0.49283359786989034d), new NpgsqlTypes.NpgsqlPoint(x: 0.47486403239340047d, y: 0.7347826343617334d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5813015288800344d, y: 0.5969209550586833d), new NpgsqlTypes.NpgsqlPoint(x: 0.6904560616478828d, y: 0.8970520657515495d), new NpgsqlTypes.NpgsqlPoint(x: 0.9231637970990187d, y: 0.8040129105356342d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9954439465648445d, y: 0.29928970656118037d), new NpgsqlTypes.NpgsqlPoint(x: 0.037165039813464196d, y: 0.543240062184802d), new NpgsqlTypes.NpgsqlPoint(x: 0.6549889180235908d, y: 0.898780901783977d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31809801804369153d, y: 0.09868433687820577d), new NpgsqlTypes.NpgsqlPoint(x: 0.530784888543209d, y: 0.04527262141495414d), new NpgsqlTypes.NpgsqlPoint(x: 0.6899363935213483d, y: 0.4721540801453189d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.039810848779136876d, y: 0.6048665706994454d), new NpgsqlTypes.NpgsqlPoint(x: 0.16310653255107854d, y: 0.6664992089083532d), new NpgsqlTypes.NpgsqlPoint(x: 0.05584164872518671d, y: 0.35959286278471514d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.060194586733335886d, y: 0.748474120733716d), new NpgsqlTypes.NpgsqlPoint(x: 0.6616416725298464d, y: 0.13664965672149154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9937830467574377d, y: 0.4490092845717155d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3044458959411317d, y: 0.05462354573019623d), new NpgsqlTypes.NpgsqlPoint(x: 0.02211327189660861d, y: 0.011836072738686254d), new NpgsqlTypes.NpgsqlPoint(x: 0.5623514608944278d, y: 0.9632028994215871d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056528500048043995d, y: 0.4650194821594952d), new NpgsqlTypes.NpgsqlPoint(x: 0.22367589010671818d, y: 0.25367254230227376d), new NpgsqlTypes.NpgsqlPoint(x: 0.22697241843308746d, y: 0.8136582756375975d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6597420164087546d, y: 0.6142783767979637d), new NpgsqlTypes.NpgsqlPoint(x: 0.36097618978804613d, y: 0.2915102584478684d), new NpgsqlTypes.NpgsqlPoint(x: 0.582038274450309d, y: 0.5108445716994771d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4588595845676967d, y: 0.7614159664741837d), new NpgsqlTypes.NpgsqlPoint(x: 0.8079095351345256d, y: 0.2879130079323624d), new NpgsqlTypes.NpgsqlPoint(x: 0.33473194528805217d, y: 0.14852814245920942d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8646094250685065d, y: 0.7567124356112823d), new NpgsqlTypes.NpgsqlPoint(x: 0.13701504766872985d, y: 0.02707187172924097d), new NpgsqlTypes.NpgsqlPoint(x: 0.3601298123233875d, y: 0.09742570454363642d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4015417161168138d, y: 0.36651905140527974d), new NpgsqlTypes.NpgsqlPoint(x: 0.36095272511673826d, y: 0.5431318960534746d), new NpgsqlTypes.NpgsqlPoint(x: 0.08214069017938597d, y: 0.13864108977910938d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7609372160947201d, y: 0.661395616103788d), new NpgsqlTypes.NpgsqlPoint(x: 0.18953712096756525d, y: 0.6333841805396687d), new NpgsqlTypes.NpgsqlPoint(x: 0.08918590291930384d, y: 0.2492649245933486d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5500788208922633d, y: 0.7496184300905978d), new NpgsqlTypes.NpgsqlPoint(x: 0.23956185034518684d, y: 0.035630208280262865d), new NpgsqlTypes.NpgsqlPoint(x: 0.6907584196749945d, y: 0.30726635821702875d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8893376091337447d, y: 0.6911567151853814d), new NpgsqlTypes.NpgsqlPoint(x: 0.11874182788658305d, y: 0.44549521881052456d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541241707426337d, y: 0.7178453375631434d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8852903146447458d, y: 0.6893083116653621d), new NpgsqlTypes.NpgsqlPoint(x: 0.26125050713346054d, y: 0.42562661147464054d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580646688035081d, y: 0.741657473232246d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21218954796340972d, y: 0.8537846589182033d), new NpgsqlTypes.NpgsqlPoint(x: 0.968306073423744d, y: 0.2386638480822464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6024137676547846d, y: 0.7859651788064099d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3887235352632411d, y: 0.7622275130428534d), new NpgsqlTypes.NpgsqlPoint(x: 0.01210622456722621d, y: 0.11429109901805268d), new NpgsqlTypes.NpgsqlPoint(x: 0.8179784956158833d, y: 0.05162855154354806d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3738860356532463d, y: 0.6431149398252475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5354572783844048d, y: 0.8589047086117996d), new NpgsqlTypes.NpgsqlPoint(x: 0.5025149208163834d, y: 0.4966703209798724d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9563563819786158d, y: 0.30970160387104195d), new NpgsqlTypes.NpgsqlPoint(x: 0.4591740247220084d, y: 0.8636163376176861d), new NpgsqlTypes.NpgsqlPoint(x: 0.4606089190056677d, y: 0.6934824098313822d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9346498481557375d, y: 0.7574501045082158d), new NpgsqlTypes.NpgsqlPoint(x: 0.40664898420618023d, y: 0.9226261828908222d), new NpgsqlTypes.NpgsqlPoint(x: 0.7466764781773603d, y: 0.732225710498081d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.019181287469427932d, y: 0.31376369068546817d), new NpgsqlTypes.NpgsqlPoint(x: 0.6251285876553754d, y: 0.037609929382146134d), new NpgsqlTypes.NpgsqlPoint(x: 0.7875790990660795d, y: 0.6786226428092548d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4135102839946381d, y: 0.2708235304169533d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231445416694297d, y: 0.4628311652013205d), new NpgsqlTypes.NpgsqlPoint(x: 0.16857690512195822d, y: 0.5881123111163753d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5639750313434946d, y: 0.0016561585603551698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5576887373651107d, y: 0.031579287929774935d), new NpgsqlTypes.NpgsqlPoint(x: 0.8751608852785063d, y: 0.36426996632874076d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20443567453110445d, y: 0.3465940696825067d), new NpgsqlTypes.NpgsqlPoint(x: 0.8630733449702623d, y: 0.3995187074280844d), new NpgsqlTypes.NpgsqlPoint(x: 0.8018245165032346d, y: 0.24951919919757837d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.912709227307854d, y: 0.5898073397992615d), new NpgsqlTypes.NpgsqlPoint(x: 0.16198693093187921d, y: 0.9741710509607061d), new NpgsqlTypes.NpgsqlPoint(x: 0.9773578799022274d, y: 0.5130506657350085d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4909052782332669d, y: 0.052714153317321544d), new NpgsqlTypes.NpgsqlPoint(x: 0.7798498604323795d, y: 0.1452924959847237d), new NpgsqlTypes.NpgsqlPoint(x: 0.2793866699300911d, y: 0.5905217757153206d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3933070323873471d, y: 0.6529676438519446d), new NpgsqlTypes.NpgsqlPoint(x: 0.1263080032639603d, y: 0.9518505220781568d), new NpgsqlTypes.NpgsqlPoint(x: 0.5614236133218312d, y: 0.14309279097281868d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.23488227455605104d, y: 0.3700754231606891d), new NpgsqlTypes.NpgsqlPoint(x: 0.09761488696035292d, y: 0.3573946032415021d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364145827416849d, y: 0.22328938534620613d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34549698359457026d, y: 0.5609125323307377d), new NpgsqlTypes.NpgsqlPoint(x: 0.0003503972989347126d, y: 0.5895252439663817d), new NpgsqlTypes.NpgsqlPoint(x: 0.46106268263244965d, y: 0.1425058033543709d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3095772055219872d, y: 0.826619962588108d), new NpgsqlTypes.NpgsqlPoint(x: 0.8067096909685048d, y: 0.18901535387688972d), new NpgsqlTypes.NpgsqlPoint(x: 0.6746382917896018d, y: 0.6943282359405956d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8597095298234465d, y: 0.21830616093735d), new NpgsqlTypes.NpgsqlPoint(x: 0.8624872011619759d, y: 0.261926148440051d), new NpgsqlTypes.NpgsqlPoint(x: 0.16979345387605937d, y: 0.1677998790373063d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6193444193567839d, y: 0.09302615810099824d), new NpgsqlTypes.NpgsqlPoint(x: 0.27254388428749865d, y: 0.519542220028078d), new NpgsqlTypes.NpgsqlPoint(x: 0.6977039617503353d, y: 0.7522710610460633d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7097009140410843d, y: 0.10473921581060974d), new NpgsqlTypes.NpgsqlPoint(x: 0.6095605711695122d, y: 0.6851769530812383d), new NpgsqlTypes.NpgsqlPoint(x: 0.20780710559164017d, y: 0.33734211946390635d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7231710029933618d, y: 0.5280192796898199d), new NpgsqlTypes.NpgsqlPoint(x: 0.9617526480034283d, y: 0.8590071263540551d), new NpgsqlTypes.NpgsqlPoint(x: 0.6706657286702785d, y: 0.06477775655921991d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10570939968168824d, y: 0.24406844694744145d), new NpgsqlTypes.NpgsqlPoint(x: 0.9532190470514211d, y: 0.4626471488126467d), new NpgsqlTypes.NpgsqlPoint(x: 0.04637631259072472d, y: 0.3799089269403476d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14842660742665903d, y: 0.7910310996172398d), new NpgsqlTypes.NpgsqlPoint(x: 0.16068455593893727d, y: 0.3977058207320575d), new NpgsqlTypes.NpgsqlPoint(x: 0.29510500980850696d, y: 0.9843097481795553d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12132236815289654d, y: 0.02888783863915223d), new NpgsqlTypes.NpgsqlPoint(x: 0.9020234553598594d, y: 0.27755339481570696d), new NpgsqlTypes.NpgsqlPoint(x: 0.2814637264795038d, y: 0.17907869620992167d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7187634628035483d, y: 0.6081951714803792d), new NpgsqlTypes.NpgsqlPoint(x: 0.12499978441505355d, y: 0.5051565666116722d), new NpgsqlTypes.NpgsqlPoint(x: 0.9518200769794585d, y: 0.5916140107129032d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5204909770691999d, y: 0.9107588691916931d), new NpgsqlTypes.NpgsqlPoint(x: 0.9590281346473063d, y: 0.2638469284992657d), new NpgsqlTypes.NpgsqlPoint(x: 0.1183170638781138d, y: 0.8290251954793981d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27381871821678194d, y: 0.2302401691725705d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543927145763923d, y: 0.3314120980466788d), new NpgsqlTypes.NpgsqlPoint(x: 0.965813382062584d, y: 0.05782280792250516d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7564221222803992d, y: 0.026954182294377294d), new NpgsqlTypes.NpgsqlPoint(x: 0.2272668099351567d, y: 0.7078954889275351d), new NpgsqlTypes.NpgsqlPoint(x: 0.923866632442889d, y: 0.6918617287054282d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10711034830996669d, y: 0.12114530897172449d), new NpgsqlTypes.NpgsqlPoint(x: 0.7014921071017651d, y: 0.8504307632787139d), new NpgsqlTypes.NpgsqlPoint(x: 0.8690134863591168d, y: 0.35802254888024276d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5278394384684458d, y: 0.11227449306373716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8905605041048748d, y: 0.2450773867770072d), new NpgsqlTypes.NpgsqlPoint(x: 0.31912318902656756d, y: 0.1454920633109229d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3985945890469891d, y: 0.45887032945853123d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544534770446323d, y: 0.772255977902672d), new NpgsqlTypes.NpgsqlPoint(x: 0.483363732578874d, y: 0.08494296559937375d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6659554164193509d, y: 0.2513006096308763d), new NpgsqlTypes.NpgsqlPoint(x: 0.8566265776381374d, y: 0.22362232187692788d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315362432687883d, y: 0.8951059151147108d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5334192867515624d, y: 0.5532236192767394d), new NpgsqlTypes.NpgsqlPoint(x: 0.9128943354575367d, y: 0.7808402792734589d), new NpgsqlTypes.NpgsqlPoint(x: 0.19873254751925762d, y: 0.5325621522322305d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.574132510853843d, y: 0.3428508962699781d), new NpgsqlTypes.NpgsqlPoint(x: 0.4778898084018275d, y: 0.9928040819422108d), new NpgsqlTypes.NpgsqlPoint(x: 0.7913483872388541d, y: 0.8448427598485734d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7976079428770729d, y: 0.2605306619512625d), new NpgsqlTypes.NpgsqlPoint(x: 0.5669270955153382d, y: 0.24966567032171538d), new NpgsqlTypes.NpgsqlPoint(x: 0.44613843166712663d, y: 0.5509712051445681d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6322606642712933d, y: 0.7569561543999394d), new NpgsqlTypes.NpgsqlPoint(x: 0.16639467186122203d, y: 0.3188916799726179d), new NpgsqlTypes.NpgsqlPoint(x: 0.14109516475857253d, y: 0.39700846714759985d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9625860952807229d, y: 0.8977744789506451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7973313942764387d, y: 0.9566028591593d), new NpgsqlTypes.NpgsqlPoint(x: 0.8799354067744077d, y: 0.07420239845742904d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02106023307106253d, y: 0.4295400902790033d), new NpgsqlTypes.NpgsqlPoint(x: 0.19625384914694688d, y: 0.057674015371227294d), new NpgsqlTypes.NpgsqlPoint(x: 0.7970577476405348d, y: 0.6151107849337974d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7831306200409445d, y: 0.5483207889132994d), new NpgsqlTypes.NpgsqlPoint(x: 0.01059847515745993d, y: 0.16967370897516032d), new NpgsqlTypes.NpgsqlPoint(x: 0.2719636583602344d, y: 0.3037594930519596d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3070083680801915d, y: 0.22578967136691352d), new NpgsqlTypes.NpgsqlPoint(x: 0.28866892324619886d, y: 0.6874244602147807d), new NpgsqlTypes.NpgsqlPoint(x: 0.12166952450157642d, y: 0.45384850695590273d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4460330891562192d, y: 0.07874427975615272d), new NpgsqlTypes.NpgsqlPoint(x: 0.5370339644282126d, y: 0.22855630586468934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8416727279976468d, y: 0.3973228008026053d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.44725521561701187d, y: 0.7936266996677978d), new NpgsqlTypes.NpgsqlPoint(x: 0.780486441604918d, y: 0.3621337117804424d), new NpgsqlTypes.NpgsqlPoint(x: 0.4033687710623336d, y: 0.6507674668633036d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20548761011167305d, y: 0.006265589987640263d), new NpgsqlTypes.NpgsqlPoint(x: 0.9654957067534294d, y: 0.5220834248819398d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417160237928378d, y: 0.7682540131447703d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5973645248931072d, y: 0.328050333409887d), new NpgsqlTypes.NpgsqlPoint(x: 0.8243845810186606d, y: 0.05254802504977607d), new NpgsqlTypes.NpgsqlPoint(x: 0.3873578695048886d, y: 0.7765120697822939d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3603089711845029d, y: 0.28357858921194545d), new NpgsqlTypes.NpgsqlPoint(x: 0.6637829212708369d, y: 0.5730272209752149d), new NpgsqlTypes.NpgsqlPoint(x: 0.2813496718549412d, y: 0.435744960773943d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.675256362171195d, y: 0.5644908661022765d), new NpgsqlTypes.NpgsqlPoint(x: 0.8448975911755882d, y: 0.4295152042515742d), new NpgsqlTypes.NpgsqlPoint(x: 0.4524586913084395d, y: 0.7424396463000049d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8267030629846442d, y: 0.5318484167720037d), new NpgsqlTypes.NpgsqlPoint(x: 0.5849242063835848d, y: 0.10953751781811549d), new NpgsqlTypes.NpgsqlPoint(x: 0.4908913206618365d, y: 0.3779204612171393d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.320246111869425d, y: 0.5895849456597103d), new NpgsqlTypes.NpgsqlPoint(x: 0.8489685853539151d, y: 0.472326109476643d), new NpgsqlTypes.NpgsqlPoint(x: 0.5661301749990896d, y: 0.12707710550253926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5864068310889835d, y: 0.6130019821873519d), new NpgsqlTypes.NpgsqlPoint(x: 0.3263080195184762d, y: 0.5269171029974898d), new NpgsqlTypes.NpgsqlPoint(x: 0.5176779415028243d, y: 0.658406307933023d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20256293882876275d, y: 0.5486844414978774d), new NpgsqlTypes.NpgsqlPoint(x: 0.019646600671381242d, y: 0.8163579694187202d), new NpgsqlTypes.NpgsqlPoint(x: 0.14315048677246256d, y: 0.9355285136331267d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2066257793712697d, y: 0.18934428499166855d), new NpgsqlTypes.NpgsqlPoint(x: 0.46590045996464324d, y: 0.033628445644544036d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905069038526889d, y: 0.7208464037535011d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9819395091518394d, y: 0.3755670224920582d), new NpgsqlTypes.NpgsqlPoint(x: 0.20196428039619663d, y: 0.4294351979222738d), new NpgsqlTypes.NpgsqlPoint(x: 0.28081009654231337d, y: 0.6316749290176926d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8785601040795534d, y: 0.9679579361444194d), new NpgsqlTypes.NpgsqlPoint(x: 0.8245280739910416d, y: 0.3007236957350642d), new NpgsqlTypes.NpgsqlPoint(x: 0.7019152865971939d, y: 0.23725132885331646d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22027773445259435d, y: 0.16954342335275374d), new NpgsqlTypes.NpgsqlPoint(x: 0.166804076912199d, y: 0.8553671524727916d), new NpgsqlTypes.NpgsqlPoint(x: 0.2677752588592349d, y: 0.9144536569483598d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.04819552486184442d, y: 0.22127904852255764d), new NpgsqlTypes.NpgsqlPoint(x: 0.37968625235136544d, y: 0.225165580674761d), new NpgsqlTypes.NpgsqlPoint(x: 0.39538074587633876d, y: 0.9488335160772561d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.38586063013795335d, y: 0.1741399529327582d), new NpgsqlTypes.NpgsqlPoint(x: 0.4312397213355108d, y: 0.900265270819369d), new NpgsqlTypes.NpgsqlPoint(x: 0.2324167719009247d, y: 0.8776116072209487d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.792520457248033d, y: 0.6354669045910445d), new NpgsqlTypes.NpgsqlPoint(x: 0.509397824084d, y: 0.659612364947175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9562611432092122d, y: 0.896776206577131d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7154783194220544d, y: 0.42086412532097783d), new NpgsqlTypes.NpgsqlPoint(x: 0.6084197350392819d, y: 0.49879796141598165d), new NpgsqlTypes.NpgsqlPoint(x: 0.6707463315264452d, y: 0.8057866546967467d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5277721527527107d, y: 0.8434514696023373d), new NpgsqlTypes.NpgsqlPoint(x: 0.25245296024741004d, y: 0.04287536074020504d), new NpgsqlTypes.NpgsqlPoint(x: 0.4983243037727376d, y: 0.5675788162410005d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6135506024944615d, y: 0.5041093455681691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6372896884486479d, y: 0.3251563588079901d), new NpgsqlTypes.NpgsqlPoint(x: 0.3741537909176488d, y: 0.6170753620877397d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2820125932286357d, y: 0.8983038331355602d), new NpgsqlTypes.NpgsqlPoint(x: 0.8267312784874884d, y: 0.3534095379774772d), new NpgsqlTypes.NpgsqlPoint(x: 0.24554173531743118d, y: 0.30983771496453916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2214546502063537d, y: 0.34821815981169535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7716060973086131d, y: 0.8972052646649747d), new NpgsqlTypes.NpgsqlPoint(x: 0.6135011853010236d, y: 0.4840946032254797d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6695620233651671d, y: 0.3912562738477715d), new NpgsqlTypes.NpgsqlPoint(x: 0.9048909513107664d, y: 0.45125552489713305d), new NpgsqlTypes.NpgsqlPoint(x: 0.7514547361538559d, y: 0.7292274739371617d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14434376316773956d, y: 0.4719154124362719d), new NpgsqlTypes.NpgsqlPoint(x: 0.2989354615896478d, y: 0.5509899950989186d), new NpgsqlTypes.NpgsqlPoint(x: 0.8458635564536731d, y: 0.8391806932505197d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8453959912149625d, y: 0.8051206422548659d), new NpgsqlTypes.NpgsqlPoint(x: 0.6375145818863339d, y: 0.7821623701492932d), new NpgsqlTypes.NpgsqlPoint(x: 0.08636339352351585d, y: 0.5018905533200516d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9096761485673175d, y: 0.7464062084134653d), new NpgsqlTypes.NpgsqlPoint(x: 0.6516575028880734d, y: 0.5352896529773107d), new NpgsqlTypes.NpgsqlPoint(x: 0.034245952613326525d, y: 0.4109528757927763d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6526983659577261d, y: 0.9272634544756072d), new NpgsqlTypes.NpgsqlPoint(x: 0.6669883826746132d, y: 0.26339140207792744d), new NpgsqlTypes.NpgsqlPoint(x: 0.08346337481315658d, y: 0.9474983256961933d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2914430360958068d, y: 0.456899827686277d), new NpgsqlTypes.NpgsqlPoint(x: 0.9091885409254926d, y: 0.6808790043448818d), new NpgsqlTypes.NpgsqlPoint(x: 0.25142208332694016d, y: 0.10192415005972144d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3014987952812572d, y: 0.8748020989696214d), new NpgsqlTypes.NpgsqlPoint(x: 0.83821216086493d, y: 0.46400269479728107d), new NpgsqlTypes.NpgsqlPoint(x: 0.286325334586771d, y: 0.4323121021095694d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9088661468723253d, y: 0.3855428464810451d), new NpgsqlTypes.NpgsqlPoint(x: 0.5036050009673336d, y: 0.6925933586779313d), new NpgsqlTypes.NpgsqlPoint(x: 0.12647398799940168d, y: 0.9800706981866785d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8572146607573098d, y: 0.05920557632091805d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034552433477997d, y: 0.21563009994970983d), new NpgsqlTypes.NpgsqlPoint(x: 0.5605960970556986d, y: 0.2810578740320241d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8200341027979617d, y: 0.20679665237386158d), new NpgsqlTypes.NpgsqlPoint(x: 0.14669448165305776d, y: 0.9579863694026691d), new NpgsqlTypes.NpgsqlPoint(x: 0.6399426582662411d, y: 0.6682650386203551d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05531249535859173d, y: 0.15211142052643367d), new NpgsqlTypes.NpgsqlPoint(x: 0.40137093599293583d, y: 0.13523678361667868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3329657282812142d, y: 0.4263792264719164d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.918590400014744d, y: 0.9074745755113296d), new NpgsqlTypes.NpgsqlPoint(x: 0.2658047501145415d, y: 0.7592926931517135d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709132792685485d, y: 0.8507060337773776d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9727931442162792d, y: 0.04253319453636384d), new NpgsqlTypes.NpgsqlPoint(x: 0.5631639111906751d, y: 0.19189021777362802d), new NpgsqlTypes.NpgsqlPoint(x: 0.28939003098773086d, y: 0.5716919591014231d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4761752921270622d, y: 0.10061836690861747d), new NpgsqlTypes.NpgsqlPoint(x: 0.37597456036423726d, y: 0.05150270460683137d), new NpgsqlTypes.NpgsqlPoint(x: 0.7749669357943463d, y: 0.5722526401261949d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6723595095276189d, y: 0.2946280002848388d), new NpgsqlTypes.NpgsqlPoint(x: 0.3783014998886651d, y: 0.296987864070162d), new NpgsqlTypes.NpgsqlPoint(x: 0.8554520171959503d, y: 0.2868532184215913d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.26424256243918687d, y: 0.27843611236593446d), new NpgsqlTypes.NpgsqlPoint(x: 0.34916620199416903d, y: 0.5120247735857344d), new NpgsqlTypes.NpgsqlPoint(x: 0.43569823064469904d, y: 0.5291036618653165d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.24956354214702803d, y: 0.4825919461759829d), new NpgsqlTypes.NpgsqlPoint(x: 0.9768299425224933d, y: 0.3866773408923091d), new NpgsqlTypes.NpgsqlPoint(x: 0.7764844999972867d, y: 0.5940170251881158d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9338649497209275d, y: 0.9830571233446713d), new NpgsqlTypes.NpgsqlPoint(x: 0.5090763451724252d, y: 0.9506811118195772d), new NpgsqlTypes.NpgsqlPoint(x: 0.8097144080493899d, y: 0.1395616406990331d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.17031274386584216d, y: 0.46180957385528854d), new NpgsqlTypes.NpgsqlPoint(x: 0.042591343003189785d, y: 0.9156883840680837d), new NpgsqlTypes.NpgsqlPoint(x: 0.627311985575848d, y: 0.936742934462817d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6561409785946652d, y: 0.9524849588516928d), new NpgsqlTypes.NpgsqlPoint(x: 0.9800684807543714d, y: 0.5924558638461169d), new NpgsqlTypes.NpgsqlPoint(x: 0.45334375146048966d, y: 0.841078584006548d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6330719389046046d, y: 0.19711682805716435d), new NpgsqlTypes.NpgsqlPoint(x: 0.9139923647716355d, y: 0.34177771345198005d), new NpgsqlTypes.NpgsqlPoint(x: 0.4466654134949156d, y: 0.1529385271163035d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3584918516732043d, y: 0.28838719582987793d), new NpgsqlTypes.NpgsqlPoint(x: 0.764686906734087d, y: 0.8293681775359992d), new NpgsqlTypes.NpgsqlPoint(x: 0.9926146029472669d, y: 0.38470538389420883d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.583543729159144d, y: 0.4344384256283026d), new NpgsqlTypes.NpgsqlPoint(x: 0.15899455457615652d, y: 0.34583042671930597d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429909427110412d, y: 0.8947721515599215d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5796969260429543d, y: 0.6936395644628184d), new NpgsqlTypes.NpgsqlPoint(x: 0.44692158956898986d, y: 0.7606233165201115d), new NpgsqlTypes.NpgsqlPoint(x: 0.47385940228117485d, y: 0.5973850846073674d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.025419007566421792d, y: 0.6623020738188599d), new NpgsqlTypes.NpgsqlPoint(x: 0.23650039302096126d, y: 0.440127746904605d), new NpgsqlTypes.NpgsqlPoint(x: 0.6028432272177074d, y: 0.7455493821507746d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.16457620529512995d, y: 0.8497974370186712d), new NpgsqlTypes.NpgsqlPoint(x: 0.869563693016541d, y: 0.08093148174321485d), new NpgsqlTypes.NpgsqlPoint(x: 0.3612776758085493d, y: 0.09281343349793947d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8240211836313801d, y: 0.601544385327148d), new NpgsqlTypes.NpgsqlPoint(x: 0.7269224526037763d, y: 0.3987799993346458d), new NpgsqlTypes.NpgsqlPoint(x: 0.8633721557942668d, y: 0.6304044663425709d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7564713988015135d, y: 0.15327065644942106d), new NpgsqlTypes.NpgsqlPoint(x: 0.24443627930576528d, y: 0.8113043593933879d), new NpgsqlTypes.NpgsqlPoint(x: 0.2313892367035626d, y: 0.37876998803095874d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1990077954722178d, y: 0.021908325202303125d), new NpgsqlTypes.NpgsqlPoint(x: 0.389210421168093d, y: 0.17998618020855506d), new NpgsqlTypes.NpgsqlPoint(x: 0.10838074549474719d, y: 0.10016324480506789d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06607355761465605d, y: 0.22020631441794458d), new NpgsqlTypes.NpgsqlPoint(x: 0.5534405495478907d, y: 0.040700965719739024d), new NpgsqlTypes.NpgsqlPoint(x: 0.0055870447822672364d, y: 0.3498321330065739d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7602979513771306d, y: 0.507729639108433d), new NpgsqlTypes.NpgsqlPoint(x: 0.1681018689205246d, y: 0.4764322813936792d), new NpgsqlTypes.NpgsqlPoint(x: 0.7785602276575345d, y: 0.6396466739585777d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.79786787904537d, y: 0.2706889845260948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9389484428620578d, y: 0.10397285578760929d), new NpgsqlTypes.NpgsqlPoint(x: 0.10093962733982675d, y: 0.7901356749654568d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9854120057628415d, y: 0.909542101752391d), new NpgsqlTypes.NpgsqlPoint(x: 0.4676587492370593d, y: 0.5317441170226233d), new NpgsqlTypes.NpgsqlPoint(x: 0.22652654523740978d, y: 0.4059849472436682d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06376090959592307d, y: 0.6618628045235834d), new NpgsqlTypes.NpgsqlPoint(x: 0.4344650317259261d, y: 0.08870607003685738d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722924719326825d, y: 0.7038989876240719d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6930564470109677d, y: 0.6963385860508697d), new NpgsqlTypes.NpgsqlPoint(x: 0.07912184128088628d, y: 0.011496667865369514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8715440366955711d, y: 0.2497054646821124d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8952042305675512d, y: 0.9111470536090305d), new NpgsqlTypes.NpgsqlPoint(x: 0.2338487241146351d, y: 0.1372945013443101d), new NpgsqlTypes.NpgsqlPoint(x: 0.93525032161367d, y: 0.6968659870902592d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.028929596565679838d, y: 0.14551485808969833d), new NpgsqlTypes.NpgsqlPoint(x: 0.044933977969182415d, y: 0.10288914688011974d), new NpgsqlTypes.NpgsqlPoint(x: 0.0027046575194693556d, y: 0.6494528562437729d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4977282034318743d, y: 0.38986028887996804d), new NpgsqlTypes.NpgsqlPoint(x: 0.3392547646739391d, y: 0.45809645747948313d), new NpgsqlTypes.NpgsqlPoint(x: 0.6187185802740343d, y: 0.5197240624629805d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8565062521049284d, y: 0.8332161945634959d), new NpgsqlTypes.NpgsqlPoint(x: 0.9419958765947016d, y: 0.24793734987662175d), new NpgsqlTypes.NpgsqlPoint(x: 0.9462226722911059d, y: 0.5820121237472955d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8055378918544867d, y: 0.7270195546338698d), new NpgsqlTypes.NpgsqlPoint(x: 0.03714600517494604d, y: 0.6058023459140803d), new NpgsqlTypes.NpgsqlPoint(x: 0.3338801969165678d, y: 0.8365600828247107d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32593993105872954d, y: 0.027672445367855292d), new NpgsqlTypes.NpgsqlPoint(x: 0.9218233092882986d, y: 0.36244851859083194d), new NpgsqlTypes.NpgsqlPoint(x: 0.031349249983771976d, y: 0.6092706298938293d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6215186617393118d, y: 0.07049574439588968d), new NpgsqlTypes.NpgsqlPoint(x: 0.1547943839991054d, y: 0.5671865216780921d), new NpgsqlTypes.NpgsqlPoint(x: 0.053465541764299296d, y: 0.1546739492259872d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.19188864619045387d, y: 0.5512800530728951d), new NpgsqlTypes.NpgsqlPoint(x: 0.929760392777592d, y: 0.41013550078812d), new NpgsqlTypes.NpgsqlPoint(x: 0.17201311412963516d, y: 0.3302335289145131d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.31455110044389933d, y: 0.46371807888958017d), new NpgsqlTypes.NpgsqlPoint(x: 0.13790664944995823d, y: 0.9067153277125832d), new NpgsqlTypes.NpgsqlPoint(x: 0.07681783306832501d, y: 0.10967109971546218d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6373872572981498d, y: 0.773979733502183d), new NpgsqlTypes.NpgsqlPoint(x: 0.9893014279302776d, y: 0.7449394451764443d), new NpgsqlTypes.NpgsqlPoint(x: 0.3815069552349126d, y: 0.5962655649982264d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9730096795707975d, y: 0.408194850160127d), new NpgsqlTypes.NpgsqlPoint(x: 0.5657331548611911d, y: 0.6188981892847947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9495895587848634d, y: 0.5065028609497108d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7920317638688342d, y: 0.9900563878364718d), new NpgsqlTypes.NpgsqlPoint(x: 0.19356571213079554d, y: 0.2545985420617968d), new NpgsqlTypes.NpgsqlPoint(x: 0.32967157485202125d, y: 0.7502303442037204d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8833077099767681d, y: 0.6739836063092144d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720671864663693d, y: 0.49937594195210344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5139817544072615d, y: 0.748580240705205d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0039460120003170784d, y: 0.24092675547984743d), new NpgsqlTypes.NpgsqlPoint(x: 0.8565908514286966d, y: 0.8811877853495252d), new NpgsqlTypes.NpgsqlPoint(x: 0.00830278127014139d, y: 0.7036987115827648d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9318899721640738d, y: 0.050710484724011295d), new NpgsqlTypes.NpgsqlPoint(x: 0.331702445261983d, y: 0.5620962174865534d), new NpgsqlTypes.NpgsqlPoint(x: 0.1110561909258585d, y: 0.856975377205833d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3978771642263744d, y: 0.6540113200888967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9557050828481716d, y: 0.7656541925947501d), new NpgsqlTypes.NpgsqlPoint(x: 0.3251080749797328d, y: 0.3564205913402033d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1376194056179908d, y: 0.5744180372847288d), new NpgsqlTypes.NpgsqlPoint(x: 0.9796501681858379d, y: 0.4372925748238935d), new NpgsqlTypes.NpgsqlPoint(x: 0.5255903488783964d, y: 0.43077334543794565d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5567082895090155d, y: 0.6794392627790563d), new NpgsqlTypes.NpgsqlPoint(x: 0.9214300899823902d, y: 0.9650211362203798d), new NpgsqlTypes.NpgsqlPoint(x: 0.9790131083656353d, y: 0.1872966130335717d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7050158087530157d, y: 0.6920372128544282d), new NpgsqlTypes.NpgsqlPoint(x: 0.2940217093135179d, y: 0.6741570240654846d), new NpgsqlTypes.NpgsqlPoint(x: 0.929158043298092d, y: 0.9930822345218958d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7305112921157683d, y: 0.9133572088909573d), new NpgsqlTypes.NpgsqlPoint(x: 0.22882315346627946d, y: 0.29666474354376626d), new NpgsqlTypes.NpgsqlPoint(x: 0.32201225512272d, y: 0.13880663730701948d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6248174543542475d, y: 0.4899195397465911d), new NpgsqlTypes.NpgsqlPoint(x: 0.47774387239134786d, y: 0.5173989869842327d), new NpgsqlTypes.NpgsqlPoint(x: 0.5378799886663211d, y: 0.6053421023855471d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.049610078044663664d, y: 0.8929465745530619d), new NpgsqlTypes.NpgsqlPoint(x: 0.5318231757401816d, y: 0.5861586592836123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6072072976181512d, y: 0.3730531225661179d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6910662461150524d, y: 0.47501586507031346d), new NpgsqlTypes.NpgsqlPoint(x: 0.27365823626874763d, y: 0.10110718906968752d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487712234371158d, y: 0.3747435210284542d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.823522553763403d, y: 0.8503761691015344d), new NpgsqlTypes.NpgsqlPoint(x: 0.7906726227692102d, y: 0.3440925139583373d), new NpgsqlTypes.NpgsqlPoint(x: 0.4890392791855591d, y: 0.6261490272340121d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6391175232504265d, y: 0.8581588654052443d), new NpgsqlTypes.NpgsqlPoint(x: 0.2961026288515701d, y: 0.39979681465227956d), new NpgsqlTypes.NpgsqlPoint(x: 0.25349440044644833d, y: 0.47932907369035693d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9133955086870095d, y: 0.676541828972668d), new NpgsqlTypes.NpgsqlPoint(x: 0.06689318528368027d, y: 0.5377122084315433d), new NpgsqlTypes.NpgsqlPoint(x: 0.7308835142003873d, y: 0.29057491145149306d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 142,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18565005900474962d, y: 0.5203084832566498d), new NpgsqlTypes.NpgsqlPoint(x: 0.31335109171792774d, y: 0.02233616405589456d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853382276697614d, y: 0.35501022544511285d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18221020811072053d, y: 0.30476865738067394d), new NpgsqlTypes.NpgsqlPoint(x: 0.09805252879421844d, y: 0.6735054104611499d), new NpgsqlTypes.NpgsqlPoint(x: 0.09062839151693192d, y: 0.5177233322521818d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13006647069625232d, y: 0.6309114985985244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7497791036377777d, y: 0.09725934132625136d), new NpgsqlTypes.NpgsqlPoint(x: 0.3592674336745558d, y: 0.08220665685561757d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5481271565695716d, y: 0.15082420681223618d), new NpgsqlTypes.NpgsqlPoint(x: 0.1659887583243388d, y: 0.19297008284208483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8506291840812845d, y: 0.43239817065949915d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.11664047794815557d, y: 0.17906081541829344d), new NpgsqlTypes.NpgsqlPoint(x: 0.5878044970015254d, y: 0.17588040030665908d), new NpgsqlTypes.NpgsqlPoint(x: 0.8497014914986581d, y: 0.26808385554874814d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8779345327470365d, y: 0.8413835308245019d), new NpgsqlTypes.NpgsqlPoint(x: 0.10700710497161636d, y: 0.55140830542688d), new NpgsqlTypes.NpgsqlPoint(x: 0.5173642455694095d, y: 0.8280438002035996d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5669542845778337d, y: 0.9564157303187485d), new NpgsqlTypes.NpgsqlPoint(x: 0.4043457630287963d, y: 0.6075083700277175d), new NpgsqlTypes.NpgsqlPoint(x: 0.12894936441907678d, y: 0.5594982120607536d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6180088007704541d, y: 0.8266218439119853d), new NpgsqlTypes.NpgsqlPoint(x: 0.16609668661626553d, y: 0.6296855286060321d), new NpgsqlTypes.NpgsqlPoint(x: 0.3822474579363482d, y: 0.22916424593790363d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4475717871250343d, y: 0.4974771038186073d), new NpgsqlTypes.NpgsqlPoint(x: 0.10411083053031722d, y: 0.33449309636760105d), new NpgsqlTypes.NpgsqlPoint(x: 0.19047283362869294d, y: 0.740342267015485d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.056013736209469034d, y: 0.3117999672617381d), new NpgsqlTypes.NpgsqlPoint(x: 0.48469083911030275d, y: 0.10168867507875501d), new NpgsqlTypes.NpgsqlPoint(x: 0.4487307123276314d, y: 0.5927202290441516d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1340187235706406d, y: 0.9207470622819519d), new NpgsqlTypes.NpgsqlPoint(x: 0.535247571659934d, y: 0.6082956190856837d), new NpgsqlTypes.NpgsqlPoint(x: 0.9577149424505169d, y: 0.4104200163758409d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7684474312770064d, y: 0.8592021376976885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7961947771635689d, y: 0.6140318908186226d), new NpgsqlTypes.NpgsqlPoint(x: 0.8275022146469859d, y: 0.5147974721666242d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4907568831943171d, y: 0.1784658436611416d), new NpgsqlTypes.NpgsqlPoint(x: 0.12223496316889304d, y: 0.7872114095737166d), new NpgsqlTypes.NpgsqlPoint(x: 0.3636983961883382d, y: 0.4293424237426716d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.05589085605517763d, y: 0.6071046345710579d), new NpgsqlTypes.NpgsqlPoint(x: 0.4548497848656309d, y: 0.9699674095644963d), new NpgsqlTypes.NpgsqlPoint(x: 0.16911771884510585d, y: 0.16100222346994209d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.32534203612159307d, y: 0.8120568209379445d), new NpgsqlTypes.NpgsqlPoint(x: 0.760477490642554d, y: 0.2802251045776124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476184129695203d, y: 0.7618138208226313d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.46864818645893946d, y: 0.30122260773833354d), new NpgsqlTypes.NpgsqlPoint(x: 0.8266688490880324d, y: 0.5779922107315812d), new NpgsqlTypes.NpgsqlPoint(x: 0.8945784310396527d, y: 0.307204162646064d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09153649912834894d, y: 0.27436802349391565d), new NpgsqlTypes.NpgsqlPoint(x: 0.41438214857826094d, y: 0.1264565375663128d), new NpgsqlTypes.NpgsqlPoint(x: 0.056285074108402d, y: 0.6236519954200391d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 149,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21767765300989528d, y: 0.2463587823138731d), new NpgsqlTypes.NpgsqlPoint(x: 0.31432014195359526d, y: 0.010709664565386467d), new NpgsqlTypes.NpgsqlPoint(x: 0.9403364799733731d, y: 0.45893598386202306d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45440659194167765d, y: 0.3958417335151039d), new NpgsqlTypes.NpgsqlPoint(x: 0.426958163430864d, y: 0.4266770006523315d), new NpgsqlTypes.NpgsqlPoint(x: 0.12992170552375903d, y: 0.6726927542112904d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14452045360876675d, y: 0.2034013878362625d), new NpgsqlTypes.NpgsqlPoint(x: 0.4587236599190583d, y: 0.07463430799148962d), new NpgsqlTypes.NpgsqlPoint(x: 0.41303392654196347d, y: 0.6309808232931285d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.27015641500158405d, y: 0.9001966960895911d), new NpgsqlTypes.NpgsqlPoint(x: 0.27245784046292343d, y: 0.1180078467404948d), new NpgsqlTypes.NpgsqlPoint(x: 0.8196599170746612d, y: 0.19107559059514911d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.14783984898949465d, y: 0.47813295048428706d), new NpgsqlTypes.NpgsqlPoint(x: 0.4496128064058157d, y: 0.07904369452657123d), new NpgsqlTypes.NpgsqlPoint(x: 0.5128784185572087d, y: 0.7130428572027142d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.592079481706626d, y: 0.33999348223741055d), new NpgsqlTypes.NpgsqlPoint(x: 0.6130264664182918d, y: 0.5077952638040093d), new NpgsqlTypes.NpgsqlPoint(x: 0.809004232418115d, y: 0.4978137994979437d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.842578821162008d, y: 0.4432918291225699d), new NpgsqlTypes.NpgsqlPoint(x: 0.2738132464056885d, y: 0.7714558277128764d), new NpgsqlTypes.NpgsqlPoint(x: 0.8368545922091974d, y: 0.0450861919474288d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7939702077313874d, y: 0.3282981281141272d), new NpgsqlTypes.NpgsqlPoint(x: 0.4432959349780373d, y: 0.39575760240875035d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632531721858506d, y: 0.05821207864437783d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9832221859676223d, y: 0.8291775511122276d), new NpgsqlTypes.NpgsqlPoint(x: 0.5237016419312289d, y: 0.9518365209122731d), new NpgsqlTypes.NpgsqlPoint(x: 0.43205143407259783d, y: 0.7616412904635922d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.21626498199707d, y: 0.9725420535007633d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743033368894844d, y: 0.10338814023137433d), new NpgsqlTypes.NpgsqlPoint(x: 0.37498164723719574d, y: 0.3631101131012876d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3610946638067526d, y: 0.7680067849179967d), new NpgsqlTypes.NpgsqlPoint(x: 0.9891990778474661d, y: 0.948582535163678d), new NpgsqlTypes.NpgsqlPoint(x: 0.18686205835755332d, y: 0.07360169612351253d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9250947705311814d, y: 0.5427465637069931d), new NpgsqlTypes.NpgsqlPoint(x: 0.44375987994787813d, y: 0.12919326440862322d), new NpgsqlTypes.NpgsqlPoint(x: 0.17144794280152775d, y: 0.5902589009005856d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7466150317153138d, y: 0.7496336842401568d), new NpgsqlTypes.NpgsqlPoint(x: 0.9940566766181756d, y: 0.4700140524161307d), new NpgsqlTypes.NpgsqlPoint(x: 0.513639169318637d, y: 0.5107269982685295d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.587036800471157d, y: 0.9192786157419205d), new NpgsqlTypes.NpgsqlPoint(x: 0.5525664520666423d, y: 0.25310516088336177d), new NpgsqlTypes.NpgsqlPoint(x: 0.5281750828005854d, y: 0.35914345342523d)),

},
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.33594602372889437d, y: 0.017710320954967385d), new NpgsqlTypes.NpgsqlPoint(x: 0.1592600360838845d, y: 0.6650362395698727d), new NpgsqlTypes.NpgsqlPoint(x: 0.9455403134775627d, y: 0.7302055237785492d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1787854612151336d, y: 0.842755475318829d), new NpgsqlTypes.NpgsqlPoint(x: 0.19585157548766285d, y: 0.19375326661509107d), new NpgsqlTypes.NpgsqlPoint(x: 0.979317449216961d, y: 0.3117960542400071d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.45124599061618387d, y: 0.7349728267250718d), new NpgsqlTypes.NpgsqlPoint(x: 0.8213456582083697d, y: 0.6481489261693884d), new NpgsqlTypes.NpgsqlPoint(x: 0.6370243686801381d, y: 0.5253563473412811d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09426098926500881d, y: 0.6978466883903319d), new NpgsqlTypes.NpgsqlPoint(x: 0.3481443100469148d, y: 0.7412844103825943d), new NpgsqlTypes.NpgsqlPoint(x: 0.06170723107875242d, y: 0.11497344543769328d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.373272335826098d, y: 0.40255262230879074d), new NpgsqlTypes.NpgsqlPoint(x: 0.8154390825224692d, y: 0.9086318218847828d), new NpgsqlTypes.NpgsqlPoint(x: 0.02453772682372457d, y: 0.48212699588732966d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.34551408263821837d, y: 0.332902568790337d), new NpgsqlTypes.NpgsqlPoint(x: 0.14703415904486428d, y: 0.221693475000717d), new NpgsqlTypes.NpgsqlPoint(x: 0.05723681305329309d, y: 0.3459042774628093d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 165,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6968022464657224d, y: 0.7732462467418127d), new NpgsqlTypes.NpgsqlPoint(x: 0.9148449807183876d, y: 0.344265468246291d), new NpgsqlTypes.NpgsqlPoint(x: 0.03777525908963986d, y: 0.7539714749172219d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7351267433629896d, y: 0.9214246458801344d), new NpgsqlTypes.NpgsqlPoint(x: 0.9024840844538176d, y: 0.4866438647606257d), new NpgsqlTypes.NpgsqlPoint(x: 0.031065543553465358d, y: 0.3725370135847422d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.54174400444475d, y: 0.4408539833389007d), new NpgsqlTypes.NpgsqlPoint(x: 0.9905636267859296d, y: 0.8143981512837177d), new NpgsqlTypes.NpgsqlPoint(x: 0.12343891130751672d, y: 0.6910592015485449d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6991779197985051d, y: 0.5645048994890529d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664177942958166d, y: 0.5329164264507298d), new NpgsqlTypes.NpgsqlPoint(x: 0.1261858092394622d, y: 0.1474824415865612d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3777711520640883d, y: 0.050822901766088835d), new NpgsqlTypes.NpgsqlPoint(x: 0.3706659399961264d, y: 0.7801415342335407d), new NpgsqlTypes.NpgsqlPoint(x: 0.8351126687803122d, y: 0.5586571447676173d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4401816510570341d, y: 0.7676282059535098d), new NpgsqlTypes.NpgsqlPoint(x: 0.8802836581929062d, y: 0.21855378482628562d), new NpgsqlTypes.NpgsqlPoint(x: 0.9407174978044737d, y: 0.11072134580484916d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9895525605136469d, y: 0.34375182332388055d), new NpgsqlTypes.NpgsqlPoint(x: 0.5034660996956238d, y: 0.9805598996500181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6743696644254042d, y: 0.6421328699427666d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5622762720737555d, y: 0.7375579763800416d), new NpgsqlTypes.NpgsqlPoint(x: 0.8879818780202772d, y: 0.9534025008864806d), new NpgsqlTypes.NpgsqlPoint(x: 0.8796391932760192d, y: 0.3202407651948981d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6092232441321408d, y: 0.49129115079403973d), new NpgsqlTypes.NpgsqlPoint(x: 0.16153672344919634d, y: 0.5848369015185088d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983513466065584d, y: 0.6791995647089278d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8526064813095553d, y: 0.7685247143068177d), new NpgsqlTypes.NpgsqlPoint(x: 0.7566820288316846d, y: 0.3850280215999625d), new NpgsqlTypes.NpgsqlPoint(x: 0.8065497235786745d, y: 0.6205727009661799d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8750637981128362d, y: 0.6754889700701693d), new NpgsqlTypes.NpgsqlPoint(x: 0.1660499896201293d, y: 0.9697279980115362d), new NpgsqlTypes.NpgsqlPoint(x: 0.3674537540981877d, y: 0.5573012970897966d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2741091961948219d, y: 0.4066276562299065d), new NpgsqlTypes.NpgsqlPoint(x: 0.8173759624408878d, y: 0.7571979670862716d), new NpgsqlTypes.NpgsqlPoint(x: 0.8034825362040112d, y: 0.5656732436030958d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4198788952784085d, y: 0.46863058529697277d), new NpgsqlTypes.NpgsqlPoint(x: 0.7253088246694083d, y: 0.05405218351607799d), new NpgsqlTypes.NpgsqlPoint(x: 0.7847175575838404d, y: 0.5453381556908666d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6884294475619749d, y: 0.5516343161120726d), new NpgsqlTypes.NpgsqlPoint(x: 0.9425076284704714d, y: 0.8657075894794919d), new NpgsqlTypes.NpgsqlPoint(x: 0.4099483343710403d, y: 0.3399119939545615d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5694097847816837d, y: 0.6493210911560121d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295738898152219d, y: 0.6931284534819665d), new NpgsqlTypes.NpgsqlPoint(x: 0.052344420099567524d, y: 0.3467537235252206d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 171,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.998726202561198d, y: 0.784090937707826d), new NpgsqlTypes.NpgsqlPoint(x: 0.06304496218847966d, y: 0.17128766441076682d), new NpgsqlTypes.NpgsqlPoint(x: 0.0760478744087032d, y: 0.1844443745569485d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8083732674973478d, y: 0.3407459144898547d), new NpgsqlTypes.NpgsqlPoint(x: 0.7720354920117415d, y: 0.5807802909146086d), new NpgsqlTypes.NpgsqlPoint(x: 0.6307440829100471d, y: 0.7275516626268806d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20328916383548956d, y: 0.7779618999263476d), new NpgsqlTypes.NpgsqlPoint(x: 0.6881958009645731d, y: 0.6236902603117569d), new NpgsqlTypes.NpgsqlPoint(x: 0.4080012301552486d, y: 0.27879456468465436d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09553316365282472d, y: 0.3738211155026261d), new NpgsqlTypes.NpgsqlPoint(x: 0.041604253632057775d, y: 0.6759735064100623d), new NpgsqlTypes.NpgsqlPoint(x: 0.03210988035888562d, y: 0.8166566884524805d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 179,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8452121772829209d, y: 0.8359947674424919d), new NpgsqlTypes.NpgsqlPoint(x: 0.385332393929272d, y: 0.004740450219424375d), new NpgsqlTypes.NpgsqlPoint(x: 0.40653904266457597d, y: 0.5605484673564372d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9529296763053132d, y: 0.7239709796889429d), new NpgsqlTypes.NpgsqlPoint(x: 0.7805331946782875d, y: 0.9529865951028922d), new NpgsqlTypes.NpgsqlPoint(x: 0.5625419185066586d, y: 0.8910870606694221d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4838810279230342d, y: 0.27939371843665806d), new NpgsqlTypes.NpgsqlPoint(x: 0.5315781807710926d, y: 0.6062650515302345d), new NpgsqlTypes.NpgsqlPoint(x: 0.2465878795632066d, y: 0.778622668222166d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9852925094516478d, y: 0.9759013988469719d), new NpgsqlTypes.NpgsqlPoint(x: 0.6009393067857172d, y: 0.6336546331765099d), new NpgsqlTypes.NpgsqlPoint(x: 0.06823121017270983d, y: 0.6368322793902924d)),

},
    ModelInner = new NpgsqlPolygonpolygonArray2MI
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06577173506531098d, y: 0.7277329794757573d), new NpgsqlTypes.NpgsqlPoint(x: 0.42408712925286784d, y: 0.2889989555630388d), new NpgsqlTypes.NpgsqlPoint(x: 0.4616263899814945d, y: 0.8751924430878688d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.22996917287309815d, y: 0.65213696220088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9852917926370798d, y: 0.06333537155678637d), new NpgsqlTypes.NpgsqlPoint(x: 0.41233494880005483d, y: 0.3875044594029413d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.334846817804744d, y: 0.8289779016285375d), new NpgsqlTypes.NpgsqlPoint(x: 0.5788803609412905d, y: 0.2520657563560479d), new NpgsqlTypes.NpgsqlPoint(x: 0.9827294075730099d, y: 0.6011083245092301d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(3)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.574723315173603d, y: 0.8483410128691904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8806174678612139d, y: 0.8446739094870555d), new NpgsqlTypes.NpgsqlPoint(x: 0.004788476285833121d, y: 0.7810961921713757d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.39407840570681185d, y: 0.46567622798288766d), new NpgsqlTypes.NpgsqlPoint(x: 0.042862200774725134d, y: 0.9550865803172742d), new NpgsqlTypes.NpgsqlPoint(x: 0.02211572214135027d, y: 0.15913471297552306d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09266193582315174d, y: 0.1256805382017605d), new NpgsqlTypes.NpgsqlPoint(x: 0.26715000501964004d, y: 0.02389940999106155d), new NpgsqlTypes.NpgsqlPoint(x: 0.2838682711227781d, y: 0.07116032929547988d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5496782075950961d, y: 0.5164486025453782d), new NpgsqlTypes.NpgsqlPoint(x: 0.14498498265383675d, y: 0.48491305198340984d), new NpgsqlTypes.NpgsqlPoint(x: 0.9687615128286644d, y: 0.8969501029797772d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0616596807645029d, y: 0.8133554872539523d), new NpgsqlTypes.NpgsqlPoint(x: 0.04526670140875588d, y: 0.5114380156615494d), new NpgsqlTypes.NpgsqlPoint(x: 0.8673629195086026d, y: 0.9769495875608274d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5297891423984497d, y: 0.5639366607673302d), new NpgsqlTypes.NpgsqlPoint(x: 0.29898951604084045d, y: 0.42474254819851165d), new NpgsqlTypes.NpgsqlPoint(x: 0.9716992835845976d, y: 0.1552300433364031d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.08836297013499672d, y: 0.5451293527074791d), new NpgsqlTypes.NpgsqlPoint(x: 0.317840943116513d, y: 0.2599389907728513d), new NpgsqlTypes.NpgsqlPoint(x: 0.4740176192699529d, y: 0.3639859525952721d)),

},
},
            new NpgsqlPolygonpolygonArray2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>(4)
{
new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.046987143069039394d, y: 0.8173460211925953d), new NpgsqlTypes.NpgsqlPoint(x: 0.1862393180195081d, y: 0.893126613647452d), new NpgsqlTypes.NpgsqlPoint(x: 0.342951521161287d, y: 0.023278132351537528d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9288893115028858d, y: 0.34519945494967175d), new NpgsqlTypes.NpgsqlPoint(x: 0.8787420558093793d, y: 0.7473483718355163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9418833344441445d, y: 0.22464906308039934d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5433140531054232d, y: 0.2496309042504522d), new NpgsqlTypes.NpgsqlPoint(x: 0.9581144226298978d, y: 0.8501506016554871d), new NpgsqlTypes.NpgsqlPoint(x: 0.0651031741484005d, y: 0.08950420051944674d)),

new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8431562438525294d, y: 0.2512854445242202d), new NpgsqlTypes.NpgsqlPoint(x: 0.5074685231794821d, y: 0.5955049474063479d), new NpgsqlTypes.NpgsqlPoint(x: 0.5317800790670204d, y: 0.9277451155827896d)),

},
    ModelInner = null,
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
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

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPolygonListpolygonArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonListpolygonArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonListpolygonArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygonarray2m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygonarray2mi_id
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
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPolygon>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483632)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygonarray2mi_id", 
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
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPolygonListpolygonArray)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygonArray2M> models = null;

                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPolygonListpolygonArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 146;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(7));
                Assert.That(firstItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                Assert.That(secondItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[31],_testData[34], false);
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
                parametr2.Value = 55;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                Assert.That(firstItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 146;
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[34], false);
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
                parametr1.Value = 86;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 165;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 11;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[30],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[31],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[34], false);
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
                parametr1.Value = 142;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M), typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 149, query1, 90, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(17));
                Assert.That(secondItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 18, query1, 55, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var models2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 103, query1, 171, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var firstItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 45, query1, 67, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 171, query1, 142, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                await ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 165, query1, 165, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
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
FROM public.npgsqlpolygonpolygonarray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems1 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                var secondItems2 = new List<FlatNpgsqlPolygonpolygonArray2M>();
                 ((INpgsqlPolygonListpolygonArray)this).DbConnectionDynQuerySelectModelBatch(connection, 86, query1, 6, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPolygonpolygonArray2M.AssertModel(secondItems2[33],_testData[34], false);
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
FROM public.npgsqlpolygonpolygonarray2m m
LEFT JOIN public.npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray)),
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
                var models = await((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatchAsync(connection, 114, 97))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[34], false);
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
                var models = ((INpgsqlPolygonListpolygonArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPolygonpolygonArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonListpolygonArray)this).DbConnectionSTSelectModelBatch(connection, 63, 45))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(31));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[4], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[5], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[6], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[7], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[8], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[9], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[10], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[7],_testData[11], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[8],_testData[12], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[9],_testData[13], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[10],_testData[14], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[11],_testData[15], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[12],_testData[16], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[13],_testData[17], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[14],_testData[18], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[15],_testData[19], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[16],_testData[20], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[17],_testData[21], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[18],_testData[22], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[19],_testData[23], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[20],_testData[24], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[21],_testData[25], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[22],_testData[26], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[23],_testData[27], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[24],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[25],_testData[29], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[26],_testData[30], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[27],_testData[31], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[28],_testData[32], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[29],_testData[33], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[30],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonListpolygonArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonListpolygonArray)this).SetDbConnectionSelectModelParametrs(cmd, 146);
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygonArray2M.AssertModel(models[0],_testData[28], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[1],_testData[29], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[2],_testData[30], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[3],_testData[31], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[4],_testData[32], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[5],_testData[33], false);NpgsqlPolygonpolygonArray2M.AssertModel(models[6],_testData[34], false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MIWA),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MI),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpolygonpolygonarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPolygonListpolygonArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPolygonpolygonArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPolygonListpolygonArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPolygonpolygonArray2M),
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
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
FROM public.binary_npgsqlpolygonpolygonarray2m m
LEFT JOIN public.binary_npgsqlpolygonpolygonarray2mi mi ON mi.id = m.npgsqlpolygonpolygonarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPolygonpolygonArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPolygonListpolygonArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPolygonListpolygonArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPolygonpolygonArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPolygonListpolygonArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonListpolygonArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygonarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2M)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonListpolygonArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygonArray2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MIWA)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
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
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonListpolygonArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
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
                    NpgsqlPolygonpolygonArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygonarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygonArray2MI)],
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
            asPartInterface: typeof(INpgsqlPolygonListpolygonArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonListpolygonArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var models = ((INpgsqlPolygonListpolygonArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygonArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

