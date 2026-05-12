

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
    internal partial interface INpgsqlCircleListcircleListD1
    {
    }
    
    internal partial class NpgsqlCircleListcircleListD1 : INpgsqlCircleListcircleListD1
    {


#region TestData

        private readonly NpgsqlCirclecircleListD1E2M[] _testData = new NpgsqlCirclecircleListD1E2M[]
        {
            new NpgsqlCirclecircleListD1E2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7940422991521636d, y: 0.600651002527367d), radius: 0.5313186142845011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9148262561843473d, y: 0.7746709435319917d), radius: 0.7058147189953984d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.020218261356589107d, y: 0.11342874413769322d), radius: 0.6706563991301093d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5383115181527035d, y: 0.6262416095103666d), radius: 0.6393754062278926d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5476305815825974d, y: 0.3491344467425269d), radius: 0.3070797316146704d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8640771375368245d, y: 0.5069125103063903d), radius: 0.7608092718779553d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.062199109920577755d, y: 0.10825161346521872d), radius: 0.6501722506156432d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7787668101875459d, y: 0.6876853836863591d), radius: 0.47442178615891073d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07514926947832601d, y: 0.18465565742279388d), radius: 0.11610713998362421d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2631965805367603d, y: 0.0847997787930006d), radius: 0.19544862400150054d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23729130499740592d, y: 0.17942886128287383d), radius: 0.16630671964895816d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4417808134295713d, y: 0.7900931070900639d), radius: 0.060116438755052126d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8607209988333234d, y: 0.735946582231829d), radius: 0.9133448848827439d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.820836218452818d, y: 0.02400681547488126d), radius: 0.05319107361722619d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5168678414223451d, y: 0.578967771865593d), radius: 0.06275554616004819d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6292543583116343d, y: 0.5916680218740291d), radius: 0.09194741374548487d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9977299784091883d, y: 0.23039438738954043d), radius: 0.0021066048516267255d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.12792061695180923d, y: 0.10299607001204558d), radius: 0.0774992896491532d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19354024448413465d, y: 0.3640354358364192d), radius: 0.9803315547703222d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7800352398893147d, y: 0.7368889380911666d), radius: 0.4232275815390206d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11911247204188546d, y: 0.39755365467889425d), radius: 0.6556372267872034d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49358683756567556d, y: 0.719488741203825d), radius: 0.5496346437494903d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7137158914407654d, y: 0.09695231750784328d), radius: 0.8347881315245901d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38231622601743764d, y: 0.34726110156705214d), radius: 0.3293464177696155d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6256694106938487d, y: 0.1332373694927409d), radius: 0.13350251083753484d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6426383492832672d, y: 0.6190621150422381d), radius: 0.5141714459651913d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22420317119073296d, y: 0.18835465709417443d), radius: 0.0968106581779804d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1118455721699726d, y: 0.4910354546332669d), radius: 0.5343206188807943d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6455713466226044d, y: 0.0851930775166787d), radius: 0.9684531772119991d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13850732426903778d, y: 0.713037873857905d), radius: 0.18365406094462022d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5902624233081397d, y: 0.5317312922556862d), radius: 0.2299290547614521d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7921473831721221d, y: 0.07171469620760307d), radius: 0.24154126530983888d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8824874586100616d, y: 0.23980986212888433d), radius: 0.28554449034589646d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7391750605577184d, y: 0.6332946580284636d), radius: 0.4318281696730478d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4463643725126848d, y: 0.3863855860855757d), radius: 0.45853027343543973d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6789747849234266d, y: 0.7973766399811534d), radius: 0.017603946922291724d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6257633926446113d, y: 0.4779827098085834d), radius: 0.31247197256144243d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6997041476004726d, y: 0.10011610193897158d), radius: 0.5759814129933752d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6283390966639723d, y: 0.857634945012136d), radius: 0.2274038091203312d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5845336316230777d, y: 0.02238183253546d), radius: 0.23724390680577523d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6640934422590926d, y: 0.33009279048467777d), radius: 0.9937145727196253d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16365472188778674d, y: 0.8301933314944956d), radius: 0.4056473524288713d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7592223070668486d, y: 0.35872989176026293d), radius: 0.6285507803795723d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10587647438764514d, y: 0.43740073729560436d), radius: 0.04734328343909311d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5415304289990527d, y: 0.8307025593615628d), radius: 0.001720604451611596d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9566966614630649d, y: 0.8370368298137697d), radius: 0.15169319186574726d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.950969010988736d, y: 0.06975633881795829d), radius: 0.08561259068330174d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8609253096596905d, y: 0.46450014745351975d), radius: 0.10965031792868696d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9045328541605433d, y: 0.3597761508504731d), radius: 0.17251545953970204d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9119952261962191d, y: 0.7902537354815582d), radius: 0.5094945699777095d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10856194010886322d, y: 0.6657592269574986d), radius: 0.09756384674998997d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0808930845039062d, y: 0.8158194250750144d), radius: 0.11255715259009935d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03156494460762671d, y: 0.726924002860387d), radius: 0.9878049186024033d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.652840073523246d, y: 0.006109943283988284d), radius: 0.26287624964292655d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9000904883568662d, y: 0.6461661717980524d), radius: 0.9485430318406449d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9701481582524806d, y: 0.5682127809076785d), radius: 0.7530393098100839d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22607001796793658d, y: 0.6486677101023657d), radius: 0.6213483917986052d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.787618814045059d, y: 0.6669343077604664d), radius: 0.5444973796048901d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3027123660028018d, y: 0.5821880552611898d), radius: 0.506132735429275d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.618691879235081d, y: 0.6863330399235188d), radius: 0.5158391130503485d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5904939231340604d, y: 0.6952715866355104d), radius: 0.371252494734976d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6395872723861615d, y: 0.34995013115121854d), radius: 0.8972232261786695d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9593414954446958d, y: 0.5449117757592731d), radius: 0.678613553981025d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8608435011570714d, y: 0.6921843388928428d), radius: 0.48393234398000784d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9592276073893392d, y: 0.6458882539178944d), radius: 0.7267279503197358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5124422759083134d, y: 0.881662050979324d), radius: 0.8617781860714203d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.526130361423372d, y: 0.24264469323757387d), radius: 0.07502984585163763d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8897282050393014d, y: 0.6678230167615765d), radius: 0.9008917470739117d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.22442989785280876d, y: 0.9424242106208677d), radius: 0.18708239131384607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5392590485407329d, y: 0.9158272614826407d), radius: 0.27895295809545295d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4269904339543291d, y: 0.7178958162526168d), radius: 0.7930152377369832d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5069526767704811d, y: 0.1454654606893111d), radius: 0.9120170212245841d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8899009639830524d, y: 0.7901632053641492d), radius: 0.3368947242562791d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.677001902454254d, y: 0.013779283616610405d), radius: 0.6374857291363571d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26239700765804186d, y: 0.6248980915459855d), radius: 0.31949365636499993d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.36115542355619645d, y: 0.9723921480034187d), radius: 0.18549640198910522d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8237749584336995d, y: 0.2933948062428585d), radius: 0.7936712143579008d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48005647519848227d, y: 0.5965671674041735d), radius: 0.4493422428326752d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6423705070715493d, y: 0.9655268969091717d), radius: 0.8335561632773261d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0679523709697829d, y: 0.577029990197533d), radius: 0.08804989714875422d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7761099876413311d, y: 0.9747437894838238d), radius: 0.6405258721236421d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9238545998138362d, y: 0.16808828827583455d), radius: 0.504044598662032d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.045592118658868475d, y: 0.8971225276395632d), radius: 0.8821566842031449d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4193946937339982d, y: 0.1865625763612866d), radius: 0.13618595135752942d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9851448665831197d, y: 0.22230670816210973d), radius: 0.1295539102789125d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2049795950630331d, y: 0.5602556924986327d), radius: 0.8161216537864712d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18382432075900135d, y: 0.5375236037465927d), radius: 0.484046621382758d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5831685225429534d, y: 0.6227498100181066d), radius: 0.9836081832721667d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 48,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6010170026713726d, y: 0.5605381162299534d), radius: 0.4957156233261022d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.24247784382479654d, y: 0.055764057579051785d), radius: 0.6126471403399607d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16228434890616616d, y: 0.03362984446248862d), radius: 0.48346986249467017d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.23706603122433367d, y: 0.4380825012888142d), radius: 0.9114824001446091d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6370622855829442d, y: 0.10867738920440118d), radius: 0.8338635546720828d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19237836499804106d, y: 0.7283765683827474d), radius: 0.7446554559643198d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3127655524172347d, y: 0.7491832861262675d), radius: 0.6842138864324443d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1141438523189936d, y: 0.42398846266638346d), radius: 0.8198485994732723d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582506587296418d, y: 0.4654178203304016d), radius: 0.16203177403122748d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.159287287665817d, y: 0.24857874231751576d), radius: 0.5496477890188162d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6355111597437494d, y: 0.32643883804396556d), radius: 0.610517440793095d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2097603137357238d, y: 0.43548282551158557d), radius: 0.6476931763613996d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10584156027557257d, y: 0.653990810153648d), radius: 0.882448081244029d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.597297086702784d, y: 0.3230493288268096d), radius: 0.9511777271002262d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19014252166356016d, y: 0.6577370552039247d), radius: 0.2742979831347573d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9405110691528208d, y: 0.7795545427513971d), radius: 0.9694210765982741d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3979425245930076d, y: 0.8568213343579503d), radius: 0.8471516274425666d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.48297763437813035d, y: 0.08904324885370207d), radius: 0.41483685537152737d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.666523816002161d, y: 0.26301519072331225d), radius: 0.3621991188682826d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6264423236975305d, y: 0.18240307002007017d), radius: 0.45052592289642013d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7445784599464496d, y: 0.41106366355472834d), radius: 0.1031093920599917d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27477741350519524d, y: 0.8400772467632761d), radius: 0.3563360030504189d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3582538652706948d, y: 0.38303827884440855d), radius: 0.9223722582717703d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18146999758602855d, y: 0.44147271867252114d), radius: 0.49456354060866925d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6386148966443466d, y: 0.0467254309485835d), radius: 0.8625871508108343d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6350419814799625d, y: 0.5923606286735102d), radius: 0.12415147488425116d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2021083215391244d, y: 0.33153819815491403d), radius: 0.8449773660980081d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7752500306864204d, y: 0.23730668450889014d), radius: 0.9882141166611424d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6314097375436507d, y: 0.5947475467395182d), radius: 0.1808524126546618d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40802740343019017d, y: 0.8422622109557314d), radius: 0.2283979815954127d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5686343757666595d, y: 0.8909529374160086d), radius: 0.049745654743803214d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.37158815314752336d, y: 0.10325809706431621d), radius: 0.03809441782835188d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.20129575723799586d, y: 0.562438067758324d), radius: 0.6669402521528235d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04354698309545413d, y: 0.2582698182680976d), radius: 0.27471527103875626d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28845719692395844d, y: 0.24290109611821964d), radius: 0.8936652315333943d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18972928214406348d, y: 0.3832870530526048d), radius: 0.4925455026951464d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21024767755273077d, y: 0.9744831651599951d), radius: 0.42657362578884717d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.29645914675644935d, y: 0.5563354760040499d), radius: 0.839841963470571d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28136783381635255d, y: 0.3805926692826791d), radius: 0.8221460977105616d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27423877800142515d, y: 0.5639418525896004d), radius: 0.7575208808058881d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9791017528611841d, y: 0.2638282384860139d), radius: 0.2067987675206786d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8455202075721561d, y: 0.7211092049808753d), radius: 0.1700642201853062d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3493323004194604d, y: 0.40666829753169453d), radius: 0.10033520528266493d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.019039052066311624d, y: 0.16549788528940945d), radius: 0.37033862921371474d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3860169115861277d, y: 0.8586994660686424d), radius: 0.6839467776508479d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13905047319829122d, y: 0.9165613896390237d), radius: 0.005127908300524897d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1790696750572247d, y: 0.38399579163227304d), radius: 0.23454067029731507d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 85,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.977533508826906d, y: 0.1400959460011859d), radius: 0.7906717139375837d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5262335004718084d, y: 0.5640921765534466d), radius: 0.5888256582877357d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5838548842508371d, y: 0.9534796295093587d), radius: 0.23925208166296252d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6639447160425875d, y: 0.7889502951609476d), radius: 0.9652780212295454d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09937195689204703d, y: 0.7402960604631426d), radius: 0.9799531814620773d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6317766990973578d, y: 0.3479815045794472d), radius: 0.403807533575651d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6966801883608277d, y: 0.35125003404463073d), radius: 0.16962793956183586d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9583981966516493d, y: 0.5390146375855833d), radius: 0.2165606432995021d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4363461367254431d, y: 0.7304741286057609d), radius: 0.6733371046344796d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6238341553116045d, y: 0.7494298687346514d), radius: 0.21346480196980644d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5019040276591904d, y: 0.9181817257731472d), radius: 0.3365423441732249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2941371677580612d, y: 0.3718469666531252d), radius: 0.9206699170908847d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1601172521198273d, y: 0.067118043239216d), radius: 0.726237153850928d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08916790036841515d, y: 0.46882838650876135d), radius: 0.4607745263852775d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9922601981805017d, y: 0.41365615342454876d), radius: 0.38328847738054184d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5595480855952656d, y: 0.3218755908108233d), radius: 0.5701849228569811d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32809900892662525d, y: 0.7582965157172612d), radius: 0.42866566839462494d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8086990036241914d, y: 0.008819761962775674d), radius: 0.37688601257909204d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8073538292062538d, y: 0.8735227999495547d), radius: 0.2638893942520849d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21697769070938955d, y: 0.4465905356784946d), radius: 0.9472365249885119d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.945655881184784d, y: 0.4659055504165436d), radius: 0.17227437069266027d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13379854947768555d, y: 0.9597202495297289d), radius: 0.4035063823290651d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.015837109598428434d, y: 0.09737190459155842d), radius: 0.2585061662455872d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04705760730074904d, y: 0.6472635513412155d), radius: 0.11830428337740873d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8936366739545641d, y: 0.2850896860019446d), radius: 0.21020485640112951d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6879901863006528d, y: 0.6667376371442759d), radius: 0.18481067086125746d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4953901491641505d, y: 0.6837322067905471d), radius: 0.37151942500034085d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32215476762999473d, y: 0.4359936352681014d), radius: 0.14096049607831218d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5795604380521214d, y: 0.6788212744987139d), radius: 0.2572775052534011d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38040403151780056d, y: 0.3140647631554653d), radius: 0.5099350592590092d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7006326740692436d, y: 0.6676113887993306d), radius: 0.6266087179900133d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.674747549774237d, y: 0.8474084898509218d), radius: 0.3431490982894574d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 111,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5997309951344676d, y: 0.6424891060875885d), radius: 0.7674006858334539d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14483342886713446d, y: 0.484583331372226d), radius: 0.7106208281331534d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9751767745724661d, y: 0.4281680353570747d), radius: 0.04361614669070624d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4415378319881834d, y: 0.5013944212780042d), radius: 0.9090125840419615d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7228571709798379d, y: 0.18878948415682673d), radius: 0.36218234085869594d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3207299571275378d, y: 0.4592331202379487d), radius: 0.978073536230249d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8527964847927639d, y: 0.958504053001926d), radius: 0.24394151482035753d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8981086353894963d, y: 0.7889203456198047d), radius: 0.7161317390622823d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7886331184508016d, y: 0.26478423270556406d), radius: 0.5277553525561739d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4613726988524115d, y: 0.6456139119776984d), radius: 0.6553256046227959d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6459907671074306d, y: 0.1082345329770098d), radius: 0.7908635631479436d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9043506217992853d, y: 0.6188215114846083d), radius: 0.8395715418239162d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.15371771343725482d, y: 0.6616356351096021d), radius: 0.6128641892847446d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7538358630322693d, y: 0.17778525041413584d), radius: 0.6890955071385282d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.009722346578168839d, y: 0.4493169773763831d), radius: 0.06325444536460156d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.09293310591352d, y: 0.36571321371525767d), radius: 0.7057139651757054d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9330629220611864d, y: 0.48261205629271076d), radius: 0.9247223399773701d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8443997506383565d, y: 0.9891434821449715d), radius: 0.4186291509141725d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49719647294611746d, y: 0.3824263514158136d), radius: 0.7844036939288174d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18411526358686892d, y: 0.49609053429186045d), radius: 0.11058951332486466d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 50,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.32052412791644835d, y: 0.41210233299333243d), radius: 0.2323562552881323d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.06492009347668126d, y: 0.8595089066176125d), radius: 0.7157536903968862d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7107783493010241d, y: 0.884260248687973d), radius: 0.22168420640222386d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07404964960895244d, y: 0.7633987900305227d), radius: 0.9397802548517169d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.16441950795815674d, y: 0.6651017976814156d), radius: 0.9281523210497344d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21769561824430417d, y: 0.4512396913502478d), radius: 0.6071722325292352d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6842596235044334d, y: 0.6608888709998879d), radius: 0.07806669867805893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8372439566448765d, y: 0.15351462378252378d), radius: 0.31093273728466697d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9089179925586586d, y: 0.2316735020588363d), radius: 0.2560266727968773d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.924544811224254d, y: 0.5245303093093928d), radius: 0.5896681320206006d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.0650464821411072d, y: 0.2583877855887128d), radius: 0.8199281289061542d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.13019190153800753d, y: 0.9692124023413318d), radius: 0.9772598931315952d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2193191839930102d, y: 0.04370372479856144d), radius: 0.5129861315798891d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6171247222446234d, y: 0.7426340486312739d), radius: 0.4485524516104551d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1868373569207865d, y: 0.347440615567431d), radius: 0.6522695365711723d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.1961798678589337d, y: 0.7188639783130905d), radius: 0.41884309202225034d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5861207567064713d, y: 0.6348176805083766d), radius: 0.3103028663979276d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4929557492586406d, y: 0.3714869051032267d), radius: 0.7928371123874288d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.832439713753386d, y: 0.8727015911331514d), radius: 0.09667531653026329d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8268681777999827d, y: 0.9165651992078842d), radius: 0.8914985591556387d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7154041824676528d, y: 0.22817031606509952d), radius: 0.5407077865419396d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9425151964092087d, y: 0.7677253330668915d), radius: 0.744806982903914d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28463932672992465d, y: 0.5768489707737311d), radius: 0.8678501361651658d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.38186770994909613d, y: 0.21160507761448477d), radius: 0.6392409390303274d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.10032895005232656d, y: 0.3122390402589479d), radius: 0.14214059017847358d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21855911694697838d, y: 0.8186753265835892d), radius: 0.3399325903562038d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.08287514864661205d, y: 0.9402852245906926d), radius: 0.9380310685621793d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.18073422678587392d, y: 0.698788144345431d), radius: 0.9039671562356518d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9863557412171843d, y: 0.34553103837556853d), radius: 0.6809804178273026d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4186879626795278d, y: 0.05943238357465119d), radius: 0.05502086578370524d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3013872597504461d, y: 0.34678844678453924d), radius: 0.04963477252985071d),

},
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 139,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6905677488301768d, y: 0.7009532773250288d), radius: 0.8513466282773589d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7552250288942826d, y: 0.05067823629090584d), radius: 0.453478290810584d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.46727132127737325d, y: 0.844221801361967d), radius: 0.6723788379689198d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26611896984829353d, y: 0.21173724826333407d), radius: 0.7589557370275456d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27805440915381796d, y: 0.11765458535511586d), radius: 0.23915554312825316d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.19598099775389244d, y: 0.0076461124537064995d), radius: 0.45991906847734587d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.26386202153023597d, y: 0.6862069235011556d), radius: 0.7824488943862639d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2076217511045283d, y: 0.2777106711930719d), radius: 0.08818745479851398d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8519666944417035d, y: 0.547708151411031d), radius: 0.556169618278649d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5699851171419688d, y: 0.40734788917219245d), radius: 0.6511999836174243d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9065333040100481d, y: 0.6300119674363036d), radius: 0.740952699554566d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11676100546446422d, y: 0.8131153055937563d), radius: 0.17497958439581385d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8427913031308931d, y: 0.8506234970078708d), radius: 0.6710545543625246d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 154,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.40391069733608276d, y: 0.400323814212204d), radius: 0.5963779728294551d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6015266356914997d, y: 0.3251105945909083d), radius: 0.3479041452630951d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9238654604533484d, y: 0.1365309010430804d), radius: 0.19951430046821905d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7735052848369779d, y: 0.08874727421361384d), radius: 0.8471220118538249d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03806316238031393d, y: 0.33063452785544556d), radius: 0.684659669773824d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.5717972944060713d, y: 0.6796688641537274d), radius: 0.4138485865652125d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.03211911411960455d, y: 0.8455237970158692d), radius: 0.5353371106823516d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.3967253249777146d, y: 0.841482596408042d), radius: 0.7680844115609959d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.28436822697248576d, y: 0.5169773062127929d), radius: 0.9349734429990653d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.021685247434508392d, y: 0.7374785770080939d), radius: 0.6383108439421001d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.44822649105126433d, y: 0.24206592173190844d), radius: 0.5617077340030838d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.49530199799922203d, y: 0.0168312032859137d), radius: 0.5602336035477399d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.917866429649977d, y: 0.8390235287684876d), radius: 0.8292747528216955d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.7345211374901861d, y: 0.3933041106891836d), radius: 0.8447467828728095d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2584258039955849d, y: 0.8336950113007857d), radius: 0.9935228189149893d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.25664131684000413d, y: 0.8820284478784864d), radius: 0.6759238066255077d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.11726092180103986d, y: 0.07390418886765981d), radius: 0.5224761057293706d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.14977939291025766d, y: 0.31357676418932046d), radius: 0.07044617814772536d),

},
    ModelInner = new NpgsqlCirclecircleListD1E2MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8857569824170727d, y: 0.930180880865496d), radius: 0.24536830303068224d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21511351349493735d, y: 0.9460788020308851d), radius: 0.5444099902290315d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6179489401428019d, y: 0.9212667228687076d), radius: 0.4449914947794654d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8273305655782472d, y: 0.7774549333497855d), radius: 0.017131491629939433d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2686604650866702d, y: 0.4005016824472988d), radius: 0.728622433557342d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.666919529209043d, y: 0.41920307856631667d), radius: 0.9864783905362362d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.4884421567371474d, y: 0.8461899960199357d), radius: 0.22057273380372544d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.6582148643273641d, y: 0.548446725900417d), radius: 0.7495715748424651d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.21319229468246326d, y: 0.9055181202435182d), radius: 0.2455919645173793d),

},
},
            new NpgsqlCirclecircleListD1E2M
{
    Id = 163,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(3)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.8819733680018835d, y: 0.8446181624127302d), radius: 0.9828859403851484d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.2390513629595019d, y: 0.7611031338379801d), radius: 0.08966649932957294d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.022488473898176098d, y: 0.2879088253114206d), radius: 0.5997556749275977d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>(4)
{
new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.07968936881269428d, y: 0.06780317059436891d), radius: 0.8399110045142049d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.04843640401214988d, y: 0.43875975438617765d), radius: 0.1552836258585022d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.27017511170703234d, y: 0.4354615121433243d), radius: 0.6421645380863359d),

new NpgsqlTypes.NpgsqlCircle(center: new NpgsqlTypes.NpgsqlPoint(x: 0.9204144283968081d, y: 0.05384764291587496d), radius: 0.8148283811223332d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
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

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlCircleListcircleListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlCircleListcircleListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlCircleListcircleListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlcirclecirclelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlcirclecirclelistd1e2mi_id
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
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlCircle>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483643)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlcirclecirclelistd1e2mi_id", 
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
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlCircleListcircleListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlCirclecircleListD1E2M> models = null;

                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlCircleListcircleListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlCircleListcircleListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(31));
                Assert.That(firstItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[28],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[29],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[30],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[30],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(32));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[30],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[31],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 152;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 111;
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 152;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
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
                parametr1.Value = 154;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 51;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 6;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 43;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[34], false);
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
                parametr1.Value = 51;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 125;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[28],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[29],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[30],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[31],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 148;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M), typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 107, query1, 40, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                Assert.That(secondItems2, Has.Count.EqualTo(26));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 51, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var models2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 154, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[29],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 152, query1, 111, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[0],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[1],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[2],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems2[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 148, query1, 78, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                await ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 112, query1, 43, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[24],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 122, query1, 157, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
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
FROM public.npgsqlcirclecirclelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlCirclecircleListD1E2M>();
                 ((INpgsqlCircleListcircleListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 63, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatNpgsqlCirclecircleListD1E2M.AssertModel(secondItems2[19],_testData[34], false);
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
FROM public.npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 133, 26))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[27],_testData[34], false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlCirclecircleListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlCircleListcircleListD1)this).DbConnectionSTSelectModelBatch(connection, 122, 157))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[33], false);
                        NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[34], false);
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
                await using var cmd = await ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models = await ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(18));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[17], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[18], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[19], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[20], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[21], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[22], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[23], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[24], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[8],_testData[25], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[9],_testData[26], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[10],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[11],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[12],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[13],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[14],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[15],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[16],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlCircleListcircleListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlCircleListcircleListD1)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((INpgsqlCircleListcircleListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(8));

                NpgsqlCirclecircleListD1E2M.AssertModel(models[0],_testData[27], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[1],_testData[28], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[2],_testData[29], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[3],_testData[30], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[4],_testData[31], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[5],_testData[32], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[6],_testData[33], false);
                NpgsqlCirclecircleListD1E2M.AssertModel(models[7],_testData[34], false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlCircleListcircleListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MI),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlcirclecirclelistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlCirclecircleListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlCirclecircleListD1E2M),
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
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
FROM public.binary_npgsqlcirclecirclelistd1e2m m
LEFT JOIN public.binary_npgsqlcirclecirclelistd1e2mi mi ON mi.id = m.npgsqlcirclecirclelistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlCircleListcircleListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlCircleListcircleListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlCirclecircleListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlCircleListcircleListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlCircleListcircleListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlcirclecirclelistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models =  ((INpgsqlCircleListcircleListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlCirclecircleListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
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
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI), typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                await ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MI>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MI>();
                ((INpgsqlCircleListcircleListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1)),
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
                var models = await ((INpgsqlCircleListcircleListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlcirclecirclelistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA), typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                await ((INpgsqlCircleListcircleListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                var models2 = new List<NpgsqlCirclecircleListD1E2MIWA>();
                ((INpgsqlCircleListcircleListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlcirclecirclelistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlCirclecircleListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlCircleListcircleListD1))]
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
                var models = await ((INpgsqlCircleListcircleListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlCircleListcircleListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlCirclecircleListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

