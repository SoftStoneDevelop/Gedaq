

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
    internal partial interface INpgsqlPolygonSingleTypepolygon
    {
    }
    
    internal partial class NpgsqlPolygonSingleTypepolygon : INpgsqlPolygonSingleTypepolygon
    {


#region TestData

        private readonly NpgsqlPolygonpolygon0M[] _testData = new NpgsqlPolygonpolygon0M[]
        {
            new NpgsqlPolygonpolygon0M
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13949052982505428d, y: 0.8316729594495447d), new NpgsqlTypes.NpgsqlPoint(x: 0.09727789308467338d, y: 0.7133011574450183d), new NpgsqlTypes.NpgsqlPoint(x: 0.14928545624323386d, y: 0.9011088859233075d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1900915126860846d, y: 0.5722938807604119d), new NpgsqlTypes.NpgsqlPoint(x: 0.018283920076534343d, y: 0.9819963257931497d), new NpgsqlTypes.NpgsqlPoint(x: 0.15562194314101796d, y: 0.028370082436546817d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 16,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044289428225279d, y: 0.9586355760327908d), new NpgsqlTypes.NpgsqlPoint(x: 0.24788500084359733d, y: 0.35506055565108696d), new NpgsqlTypes.NpgsqlPoint(x: 0.14212101252181875d, y: 0.5117242585523684d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 1,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03474051788696475d, y: 0.22732422558029963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680381618273258d, y: 0.4127603294324459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541396905476525d, y: 0.5541943927435214d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6475863378390223d, y: 0.8441427060847819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687675317278074d, y: 0.549619034523498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207579827498771d, y: 0.6242026635747528d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6260067661445959d, y: 0.6521684978966303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341762236492624d, y: 0.14340775750960966d), new NpgsqlTypes.NpgsqlPoint(x: 0.46986421041391035d, y: 0.11004285823597793d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 21,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7855744927616516d, y: 0.6767326322875103d), new NpgsqlTypes.NpgsqlPoint(x: 0.534521578546904d, y: 0.7708051305598942d), new NpgsqlTypes.NpgsqlPoint(x: 0.831573529193279d, y: 0.07909428968247423d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 9,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5875181993134777d, y: 0.5830425848630651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121678280387997d, y: 0.4316308687707505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376423894256561d, y: 0.19998927871073435d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10289573541720687d, y: 0.6832557175621746d), new NpgsqlTypes.NpgsqlPoint(x: 0.505812318851322d, y: 0.06773358855515033d), new NpgsqlTypes.NpgsqlPoint(x: 0.16479609061432454d, y: 0.07930431421222939d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20948862450655115d, y: 0.15057757056748544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3946022773628469d, y: 0.6531776879861563d), new NpgsqlTypes.NpgsqlPoint(x: 0.672744256258672d, y: 0.016342245286615875d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3398193550929144d, y: 0.10559533950756883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09914033240096054d, y: 0.5755500164196112d), new NpgsqlTypes.NpgsqlPoint(x: 0.28271130979726156d, y: 0.8311967871253403d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 27,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.692797917860017d, y: 0.20492793091623962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960981668781152d, y: 0.9084347062673565d), new NpgsqlTypes.NpgsqlPoint(x: 0.20760770353976787d, y: 0.19124233330572105d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 11,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40106124483101746d, y: 0.622603590765568d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575653112024955d, y: 0.9125173345910114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4176841331403591d, y: 0.9500515155094085d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7140727726620388d, y: 0.40490845169754475d), new NpgsqlTypes.NpgsqlPoint(x: 0.40620591669495887d, y: 0.6301558070450236d), new NpgsqlTypes.NpgsqlPoint(x: 0.09545709170487715d, y: 0.10185679114262058d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37104235035093536d, y: 0.10290114442231468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071937356740703d, y: 0.32170114956753615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718746098058373d, y: 0.08819384695797072d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 31,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8583732917278295d, y: 0.2421764397204721d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513429582973874d, y: 0.33572581343145647d), new NpgsqlTypes.NpgsqlPoint(x: 0.08931695373753235d, y: 0.20685016476332807d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012772849429905753d, y: 0.9958133947460179d), new NpgsqlTypes.NpgsqlPoint(x: 0.27314897940262994d, y: 0.46152335176201464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350824833839916d, y: 0.5240802788669787d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07521938871022626d, y: 0.3680263075715664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279915300362114d, y: 0.9028460896939438d), new NpgsqlTypes.NpgsqlPoint(x: 0.639223590523989d, y: 0.5444391666020177d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9409248027048587d, y: 0.39029435343802354d), new NpgsqlTypes.NpgsqlPoint(x: 0.13523243696009157d, y: 0.24506432594388383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235198748825964d, y: 0.8343600296365101d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28935701068260666d, y: 0.09125820278752494d), new NpgsqlTypes.NpgsqlPoint(x: 0.05039700736661967d, y: 0.11765686701855627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236376195519149d, y: 0.20831184042803252d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10154346486458321d, y: 0.33438279428132034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502231483089312d, y: 0.36428495133400485d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914855322628924d, y: 0.6784628537221893d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 51,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007194021430960595d, y: 0.7654549261361637d), new NpgsqlTypes.NpgsqlPoint(x: 0.858505675761975d, y: 0.6431345389904515d), new NpgsqlTypes.NpgsqlPoint(x: 0.16672225778591954d, y: 0.42213081451841816d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 17,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18558797534755245d, y: 0.9984222761076977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069579517730773d, y: 0.9253277752384427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879872066165535d, y: 0.04249318296558535d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6440983409417519d, y: 0.8760626516574462d), new NpgsqlTypes.NpgsqlPoint(x: 0.916460354149361d, y: 0.8978841587510102d), new NpgsqlTypes.NpgsqlPoint(x: 0.12669381376476951d, y: 0.3048387611834852d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4505279625465102d, y: 0.9141760725772042d), new NpgsqlTypes.NpgsqlPoint(x: 0.08599271376805018d, y: 0.08355596268524101d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854946636432662d, y: 0.5936398938508127d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 59,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5490824974120472d, y: 0.7757018818754039d), new NpgsqlTypes.NpgsqlPoint(x: 0.35750288126238094d, y: 0.3868233156430363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841597478424308d, y: 0.8905967846067928d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6977275272872223d, y: 0.040483398236350276d), new NpgsqlTypes.NpgsqlPoint(x: 0.22414246155964557d, y: 0.4388610191661836d), new NpgsqlTypes.NpgsqlPoint(x: 0.37217606440118267d, y: 0.3378578672117539d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12863348601078028d, y: 0.8472424628655428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451986590222853d, y: 0.8476554865982009d), new NpgsqlTypes.NpgsqlPoint(x: 0.618162992007745d, y: 0.6898103365148964d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 64,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7247852998479728d, y: 0.7282519134956809d), new NpgsqlTypes.NpgsqlPoint(x: 0.11414461274745713d, y: 0.04346141458897268d), new NpgsqlTypes.NpgsqlPoint(x: 0.08987955648422574d, y: 0.9316456132476673d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2844418113137819d, y: 0.933205520324801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987930630979991d, y: 0.5456036182740831d), new NpgsqlTypes.NpgsqlPoint(x: 0.029914440517145535d, y: 0.7902346179050642d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 72,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0847389712977058d, y: 0.46364529651661945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465301304735893d, y: 0.059297330172374485d), new NpgsqlTypes.NpgsqlPoint(x: 0.09073909975034344d, y: 0.16967152435252209d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4814410115700871d, y: 0.7425900026927792d), new NpgsqlTypes.NpgsqlPoint(x: 0.03207853973584629d, y: 0.10454269403476923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827295808369034d, y: 0.9544924668919592d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6963801180245736d, y: 0.4920029965282673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922760466091155d, y: 0.3322101011199542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512771743211155d, y: 0.38998919972299584d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47920601354504166d, y: 0.858174589550253d), new NpgsqlTypes.NpgsqlPoint(x: 0.48822735000226314d, y: 0.37649982624606093d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974453744642498d, y: 0.5398160114931103d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35565739280006337d, y: 0.6642013198250464d), new NpgsqlTypes.NpgsqlPoint(x: 0.21519741915499702d, y: 0.014649521893966955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551087706813608d, y: 0.9394430846146411d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9248450736811556d, y: 0.8510398037268947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534957393292061d, y: 0.7548795540175716d), new NpgsqlTypes.NpgsqlPoint(x: 0.04675542459122595d, y: 0.2990269972365802d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 87,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09795190998665115d, y: 0.007027850513993683d), new NpgsqlTypes.NpgsqlPoint(x: 0.19730790165113188d, y: 0.5959231054573535d), new NpgsqlTypes.NpgsqlPoint(x: 0.24476630138449584d, y: 0.016084252258183107d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 34,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02492179999286437d, y: 0.5276989117682291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142266603496687d, y: 0.6284413352231422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290781395160405d, y: 0.20122391217253766d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7099143721992266d, y: 0.7624154384268791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078075402428725d, y: 0.3545508565267401d), new NpgsqlTypes.NpgsqlPoint(x: 0.13472767489661397d, y: 0.30542557309361584d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 90,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828342610485913d, y: 0.35894972314378837d), new NpgsqlTypes.NpgsqlPoint(x: 0.18671630648024484d, y: 0.10642131342041294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281913418287219d, y: 0.7834234093372068d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 99,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017605957186531795d, y: 0.3442293939464516d), new NpgsqlTypes.NpgsqlPoint(x: 0.008680738899271012d, y: 0.1674922120644483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125630091094613d, y: 0.9007165803951255d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 39,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5283562693379287d, y: 0.021653005485836707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638376679853174d, y: 0.931773267776191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991234015350517d, y: 0.12465927508742136d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158356406536191d, y: 0.8617391590545774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2903409023485183d, y: 0.3072963927290562d), new NpgsqlTypes.NpgsqlPoint(x: 0.010034982011303262d, y: 0.557494053912314d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 103,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28996068675913145d, y: 0.1683481994839494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253983876045988d, y: 0.200731234698186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125078685278567d, y: 0.4062194773160277d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43258063757810217d, y: 0.7801601204152567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185352660519374d, y: 0.15151146073832344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984292713141721d, y: 0.4836131367709715d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 106,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003713670825176d, y: 0.9550132356847105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353255059330499d, y: 0.24507909334281242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551541271644327d, y: 0.6948257004645267d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7742476744135292d, y: 0.6629180091109277d), new NpgsqlTypes.NpgsqlPoint(x: 0.320882784708043d, y: 0.7879585391804091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3966850901676139d, y: 0.3265180467390779d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 108,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2168586997071259d, y: 0.8857656129668058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260212478504196d, y: 0.4895136905976357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237101963161167d, y: 0.39724694064576305d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4021532921569092d, y: 0.03249740771315479d), new NpgsqlTypes.NpgsqlPoint(x: 0.11536761733861933d, y: 0.18374834586653088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417838199218243d, y: 0.059689704361092444d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 114,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13888661247845613d, y: 0.5923505746935978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923947709022858d, y: 0.5782095067915081d), new NpgsqlTypes.NpgsqlPoint(x: 0.042755677408186976d, y: 0.42906754645563183d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 50,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4085460168674604d, y: 0.09506590878058707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816863881287634d, y: 0.9060067405244742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942372707366425d, y: 0.6279395186540444d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9797344355997396d, y: 0.3531066837075181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910846291353184d, y: 0.009731375593061697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963122865750111d, y: 0.07249551675687715d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847837635735883d, y: 0.015850512497180724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271705582980773d, y: 0.38351499164702707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522186914083033d, y: 0.5630895263674637d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7519022676867221d, y: 0.2241768015596155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236476544883038d, y: 0.6124815932489757d), new NpgsqlTypes.NpgsqlPoint(x: 0.11292256208464513d, y: 0.8012598934074298d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 125,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2384966477935242d, y: 0.5283402542091672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629641328692447d, y: 0.2879481580107601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469117619676019d, y: 0.06300958808638235d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9971392975987112d, y: 0.23862294313129595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875425967374345d, y: 0.8337724884760607d), new NpgsqlTypes.NpgsqlPoint(x: 0.695802610740149d, y: 0.31383706934206734d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9879371492765553d, y: 0.9444107450891424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727571169191193d, y: 0.3188568492623126d), new NpgsqlTypes.NpgsqlPoint(x: 0.50493638196555d, y: 0.2115567881933047d)),
},
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4131864367253778d, y: 0.537073384960927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419231360208959d, y: 0.018193484632035517d), new NpgsqlTypes.NpgsqlPoint(x: 0.47271393157899455d, y: 0.29016397394842164d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPolygonpolygon0M
{
    Id = 133,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003801606540345d, y: 0.006281284262145581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978704942985369d, y: 0.010323621205669875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019154749194618d, y: 0.46812066724711976d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 60,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4918276473813339d, y: 0.4134294747754519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103774198313905d, y: 0.1606517004390361d), new NpgsqlTypes.NpgsqlPoint(x: 0.014652754770882792d, y: 0.6319784347918872d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06117501734095088d, y: 0.5639098256567878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323900800180023d, y: 0.9990194978647916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055447683848421d, y: 0.13179432856157003d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 139,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4039486281411715d, y: 0.25756672361986976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0822242662620537d, y: 0.21758807674573277d), new NpgsqlTypes.NpgsqlPoint(x: 0.209659671934184d, y: 0.5304173434473551d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4691462694667424d, y: 0.26433911301034885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138701329912259d, y: 0.6296422384148801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971945927188998d, y: 0.1463780447426959d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 148,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5291243279209641d, y: 0.8806249725072032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802508410986171d, y: 0.7598179044162063d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799841536010034d, y: 0.6658358034399477d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9455841769906906d, y: 0.4249311542721492d), new NpgsqlTypes.NpgsqlPoint(x: 0.39145027217078465d, y: 0.5356331218941792d), new NpgsqlTypes.NpgsqlPoint(x: 0.519559556803139d, y: 0.6844474820176674d)),
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29168703558468023d, y: 0.07415928006838535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142835900474519d, y: 0.3197476349651356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932606275562398d, y: 0.6421850713484679d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30221263978132396d, y: 0.12191502322451209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538976579663623d, y: 0.09006100412351936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261459304168896d, y: 0.6377251739359602d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 154,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125281735307426d, y: 0.5967235795116511d), new NpgsqlTypes.NpgsqlPoint(x: 0.02926367486342496d, y: 0.1236262851609703d), new NpgsqlTypes.NpgsqlPoint(x: 0.40738251175356055d, y: 0.07212061050293694d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015709396872523d, y: 0.14438585367493884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008100092271676d, y: 0.021330021839225943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422027909534742d, y: 0.6089725722738332d)),
},
            new NpgsqlPolygonpolygon0M
{
    Id = 157,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870989262575189d, y: 0.07145239733262487d), new NpgsqlTypes.NpgsqlPoint(x: 0.308794883845684d, y: 0.21571230520580154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629971580943295d, y: 0.14994562602431016d)),
    ModelInner = new NpgsqlPolygonpolygon0MI
{
    Id = 74,
    Value = new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7454680168524364d, y: 0.6748881049391418d), new NpgsqlTypes.NpgsqlPoint(x: 0.07253691309750154d, y: 0.9807912968357707d), new NpgsqlTypes.NpgsqlPoint(x: 0.37855112872609475d, y: 0.39711324372388546d)),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
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
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16))]
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

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0mi(
	id,
    value,
    nullablevalue
)
VALUES (
    @id,
    @value, 
    @nullablevalue
)
",
            methodName:"DbConnectionInsertInnerModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13), 
                nullable: true)]
        public void DbConnectionInsertInnerModelConfig()
        {
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task DbConnectionInsertInnerModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3398193550929144d, y: 0.10559533950756883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09914033240096054d, y: 0.5755500164196112d), new NpgsqlTypes.NpgsqlPoint(x: 0.28271130979726156d, y: 0.8311967871253403d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37104235035093536d, y: 0.10290114442231468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071937356740703d, y: 0.32170114956753615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718746098058373d, y: 0.08819384695797072d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012772849429905753d, y: 0.9958133947460179d), new NpgsqlTypes.NpgsqlPoint(x: 0.27314897940262994d, y: 0.46152335176201464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350824833839916d, y: 0.5240802788669787d))));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPolygon>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(16);
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

                    nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
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
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(16)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
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
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPolygon? nullable = null;
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPolygonSingleTypepolygon)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12863348601078028d, y: 0.8472424628655428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451986590222853d, y: 0.8476554865982009d), new NpgsqlTypes.NpgsqlPoint(x: 0.618162992007745d, y: 0.6898103365148964d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPolygonpolygon0M> models = null;

                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpolygonpolygon0m(
	id,
    value,
    nullablevalue,
    npgsqlpolygonpolygon0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpolygonpolygon0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPolygon), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPolygon?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpolygonpolygon0mi_id", 
                methodParametrName: "npgsqlpolygonpolygon0mi_id", 
                dbType: (System.Data.DbType)(11),
                nullable: true)]
        public void DbConnectionInsertModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task DbConnectionInsertModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int changedRows = 0;

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 133;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[2], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[3], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[4], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[5], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[6], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[7], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[8], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 148;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 39;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[8], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M), typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPolygonpolygon0M>();
                var models2 = new List<FlatNpgsqlPolygonpolygon0M>();
                ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 42, query1, 103, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpolygonpolygon0m m
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
FROM public.npgsqlpolygonpolygon0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionDynQuerySelectModelBatch(connection, 64, query1, 59, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[12], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[13], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[14], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[15], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[16], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[17], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[18], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[19], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[20], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[21], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[22], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[23], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[24], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[25], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[26], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[27], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[28], false);FlatNpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon)),
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
                var models = await((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatchAsync(connection, 72, 90))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[29], false);
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
                var models = ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPolygonpolygon0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelBatch(connection, 114, 42))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[9], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[10], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[11], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[12], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 64);
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[13], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[14], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[15], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[16], false);NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[17], false);NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[18], false);NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[19], false);NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[20], false);NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[21], false);NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[22], false);NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[23], false);NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[24], false);NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[25], false);NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPolygonSingleTypepolygon)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPolygonSingleTypepolygon)this).SetDbConnectionSelectModelParametrs(cmd, 133);
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(4));
NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[26], false);NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[27], false);NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[28], false);NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[29], false);
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
FROM public.npgsqlpolygonpolygon0m m
LEFT JOIN public.npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelToObjArr",
            queryMapTypes: [typeof(object[])],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13949052982505428d, y: 0.8316729594495447d), new NpgsqlTypes.NpgsqlPoint(x: 0.09727789308467338d, y: 0.7133011574450183d), new NpgsqlTypes.NpgsqlPoint(x: 0.14928545624323386d, y: 0.9011088859233075d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1900915126860846d, y: 0.5722938807604119d), new NpgsqlTypes.NpgsqlPoint(x: 0.018283920076534343d, y: 0.9819963257931497d), new NpgsqlTypes.NpgsqlPoint(x: 0.15562194314101796d, y: 0.028370082436546817d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044289428225279d, y: 0.9586355760327908d), new NpgsqlTypes.NpgsqlPoint(x: 0.24788500084359733d, y: 0.35506055565108696d), new NpgsqlTypes.NpgsqlPoint(x: 0.14212101252181875d, y: 0.5117242585523684d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03474051788696475d, y: 0.22732422558029963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680381618273258d, y: 0.4127603294324459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541396905476525d, y: 0.5541943927435214d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6475863378390223d, y: 0.8441427060847819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687675317278074d, y: 0.549619034523498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207579827498771d, y: 0.6242026635747528d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6260067661445959d, y: 0.6521684978966303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341762236492624d, y: 0.14340775750960966d), new NpgsqlTypes.NpgsqlPoint(x: 0.46986421041391035d, y: 0.11004285823597793d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7855744927616516d, y: 0.6767326322875103d), new NpgsqlTypes.NpgsqlPoint(x: 0.534521578546904d, y: 0.7708051305598942d), new NpgsqlTypes.NpgsqlPoint(x: 0.831573529193279d, y: 0.07909428968247423d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5875181993134777d, y: 0.5830425848630651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121678280387997d, y: 0.4316308687707505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376423894256561d, y: 0.19998927871073435d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10289573541720687d, y: 0.6832557175621746d), new NpgsqlTypes.NpgsqlPoint(x: 0.505812318851322d, y: 0.06773358855515033d), new NpgsqlTypes.NpgsqlPoint(x: 0.16479609061432454d, y: 0.07930431421222939d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20948862450655115d, y: 0.15057757056748544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3946022773628469d, y: 0.6531776879861563d), new NpgsqlTypes.NpgsqlPoint(x: 0.672744256258672d, y: 0.016342245286615875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3398193550929144d, y: 0.10559533950756883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09914033240096054d, y: 0.5755500164196112d), new NpgsqlTypes.NpgsqlPoint(x: 0.28271130979726156d, y: 0.8311967871253403d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.692797917860017d, y: 0.20492793091623962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960981668781152d, y: 0.9084347062673565d), new NpgsqlTypes.NpgsqlPoint(x: 0.20760770353976787d, y: 0.19124233330572105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40106124483101746d, y: 0.622603590765568d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575653112024955d, y: 0.9125173345910114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4176841331403591d, y: 0.9500515155094085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7140727726620388d, y: 0.40490845169754475d), new NpgsqlTypes.NpgsqlPoint(x: 0.40620591669495887d, y: 0.6301558070450236d), new NpgsqlTypes.NpgsqlPoint(x: 0.09545709170487715d, y: 0.10185679114262058d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37104235035093536d, y: 0.10290114442231468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071937356740703d, y: 0.32170114956753615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718746098058373d, y: 0.08819384695797072d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8583732917278295d, y: 0.2421764397204721d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513429582973874d, y: 0.33572581343145647d), new NpgsqlTypes.NpgsqlPoint(x: 0.08931695373753235d, y: 0.20685016476332807d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012772849429905753d, y: 0.9958133947460179d), new NpgsqlTypes.NpgsqlPoint(x: 0.27314897940262994d, y: 0.46152335176201464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350824833839916d, y: 0.5240802788669787d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07521938871022626d, y: 0.3680263075715664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279915300362114d, y: 0.9028460896939438d), new NpgsqlTypes.NpgsqlPoint(x: 0.639223590523989d, y: 0.5444391666020177d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9409248027048587d, y: 0.39029435343802354d), new NpgsqlTypes.NpgsqlPoint(x: 0.13523243696009157d, y: 0.24506432594388383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235198748825964d, y: 0.8343600296365101d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28935701068260666d, y: 0.09125820278752494d), new NpgsqlTypes.NpgsqlPoint(x: 0.05039700736661967d, y: 0.11765686701855627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236376195519149d, y: 0.20831184042803252d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10154346486458321d, y: 0.33438279428132034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502231483089312d, y: 0.36428495133400485d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914855322628924d, y: 0.6784628537221893d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007194021430960595d, y: 0.7654549261361637d), new NpgsqlTypes.NpgsqlPoint(x: 0.858505675761975d, y: 0.6431345389904515d), new NpgsqlTypes.NpgsqlPoint(x: 0.16672225778591954d, y: 0.42213081451841816d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18558797534755245d, y: 0.9984222761076977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069579517730773d, y: 0.9253277752384427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879872066165535d, y: 0.04249318296558535d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6440983409417519d, y: 0.8760626516574462d), new NpgsqlTypes.NpgsqlPoint(x: 0.916460354149361d, y: 0.8978841587510102d), new NpgsqlTypes.NpgsqlPoint(x: 0.12669381376476951d, y: 0.3048387611834852d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4505279625465102d, y: 0.9141760725772042d), new NpgsqlTypes.NpgsqlPoint(x: 0.08599271376805018d, y: 0.08355596268524101d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854946636432662d, y: 0.5936398938508127d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5490824974120472d, y: 0.7757018818754039d), new NpgsqlTypes.NpgsqlPoint(x: 0.35750288126238094d, y: 0.3868233156430363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841597478424308d, y: 0.8905967846067928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6977275272872223d, y: 0.040483398236350276d), new NpgsqlTypes.NpgsqlPoint(x: 0.22414246155964557d, y: 0.4388610191661836d), new NpgsqlTypes.NpgsqlPoint(x: 0.37217606440118267d, y: 0.3378578672117539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12863348601078028d, y: 0.8472424628655428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451986590222853d, y: 0.8476554865982009d), new NpgsqlTypes.NpgsqlPoint(x: 0.618162992007745d, y: 0.6898103365148964d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7247852998479728d, y: 0.7282519134956809d), new NpgsqlTypes.NpgsqlPoint(x: 0.11414461274745713d, y: 0.04346141458897268d), new NpgsqlTypes.NpgsqlPoint(x: 0.08987955648422574d, y: 0.9316456132476673d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2844418113137819d, y: 0.933205520324801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987930630979991d, y: 0.5456036182740831d), new NpgsqlTypes.NpgsqlPoint(x: 0.029914440517145535d, y: 0.7902346179050642d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0847389712977058d, y: 0.46364529651661945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465301304735893d, y: 0.059297330172374485d), new NpgsqlTypes.NpgsqlPoint(x: 0.09073909975034344d, y: 0.16967152435252209d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4814410115700871d, y: 0.7425900026927792d), new NpgsqlTypes.NpgsqlPoint(x: 0.03207853973584629d, y: 0.10454269403476923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827295808369034d, y: 0.9544924668919592d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6963801180245736d, y: 0.4920029965282673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922760466091155d, y: 0.3322101011199542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512771743211155d, y: 0.38998919972299584d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47920601354504166d, y: 0.858174589550253d), new NpgsqlTypes.NpgsqlPoint(x: 0.48822735000226314d, y: 0.37649982624606093d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974453744642498d, y: 0.5398160114931103d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35565739280006337d, y: 0.6642013198250464d), new NpgsqlTypes.NpgsqlPoint(x: 0.21519741915499702d, y: 0.014649521893966955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551087706813608d, y: 0.9394430846146411d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9248450736811556d, y: 0.8510398037268947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534957393292061d, y: 0.7548795540175716d), new NpgsqlTypes.NpgsqlPoint(x: 0.04675542459122595d, y: 0.2990269972365802d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09795190998665115d, y: 0.007027850513993683d), new NpgsqlTypes.NpgsqlPoint(x: 0.19730790165113188d, y: 0.5959231054573535d), new NpgsqlTypes.NpgsqlPoint(x: 0.24476630138449584d, y: 0.016084252258183107d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02492179999286437d, y: 0.5276989117682291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142266603496687d, y: 0.6284413352231422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290781395160405d, y: 0.20122391217253766d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7099143721992266d, y: 0.7624154384268791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078075402428725d, y: 0.3545508565267401d), new NpgsqlTypes.NpgsqlPoint(x: 0.13472767489661397d, y: 0.30542557309361584d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828342610485913d, y: 0.35894972314378837d), new NpgsqlTypes.NpgsqlPoint(x: 0.18671630648024484d, y: 0.10642131342041294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281913418287219d, y: 0.7834234093372068d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017605957186531795d, y: 0.3442293939464516d), new NpgsqlTypes.NpgsqlPoint(x: 0.008680738899271012d, y: 0.1674922120644483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125630091094613d, y: 0.9007165803951255d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5283562693379287d, y: 0.021653005485836707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638376679853174d, y: 0.931773267776191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991234015350517d, y: 0.12465927508742136d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158356406536191d, y: 0.8617391590545774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2903409023485183d, y: 0.3072963927290562d), new NpgsqlTypes.NpgsqlPoint(x: 0.010034982011303262d, y: 0.557494053912314d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28996068675913145d, y: 0.1683481994839494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253983876045988d, y: 0.200731234698186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125078685278567d, y: 0.4062194773160277d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43258063757810217d, y: 0.7801601204152567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185352660519374d, y: 0.15151146073832344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984292713141721d, y: 0.4836131367709715d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003713670825176d, y: 0.9550132356847105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353255059330499d, y: 0.24507909334281242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551541271644327d, y: 0.6948257004645267d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7742476744135292d, y: 0.6629180091109277d), new NpgsqlTypes.NpgsqlPoint(x: 0.320882784708043d, y: 0.7879585391804091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3966850901676139d, y: 0.3265180467390779d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2168586997071259d, y: 0.8857656129668058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260212478504196d, y: 0.4895136905976357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237101963161167d, y: 0.39724694064576305d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4021532921569092d, y: 0.03249740771315479d), new NpgsqlTypes.NpgsqlPoint(x: 0.11536761733861933d, y: 0.18374834586653088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417838199218243d, y: 0.059689704361092444d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13888661247845613d, y: 0.5923505746935978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923947709022858d, y: 0.5782095067915081d), new NpgsqlTypes.NpgsqlPoint(x: 0.042755677408186976d, y: 0.42906754645563183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4085460168674604d, y: 0.09506590878058707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816863881287634d, y: 0.9060067405244742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942372707366425d, y: 0.6279395186540444d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9797344355997396d, y: 0.3531066837075181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910846291353184d, y: 0.009731375593061697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963122865750111d, y: 0.07249551675687715d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847837635735883d, y: 0.015850512497180724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271705582980773d, y: 0.38351499164702707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522186914083033d, y: 0.5630895263674637d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7519022676867221d, y: 0.2241768015596155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236476544883038d, y: 0.6124815932489757d), new NpgsqlTypes.NpgsqlPoint(x: 0.11292256208464513d, y: 0.8012598934074298d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2384966477935242d, y: 0.5283402542091672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629641328692447d, y: 0.2879481580107601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469117619676019d, y: 0.06300958808638235d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9971392975987112d, y: 0.23862294313129595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875425967374345d, y: 0.8337724884760607d), new NpgsqlTypes.NpgsqlPoint(x: 0.695802610740149d, y: 0.31383706934206734d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9879371492765553d, y: 0.9444107450891424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727571169191193d, y: 0.3188568492623126d), new NpgsqlTypes.NpgsqlPoint(x: 0.50493638196555d, y: 0.2115567881933047d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4131864367253778d, y: 0.537073384960927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419231360208959d, y: 0.018193484632035517d), new NpgsqlTypes.NpgsqlPoint(x: 0.47271393157899455d, y: 0.29016397394842164d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003801606540345d, y: 0.006281284262145581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978704942985369d, y: 0.010323621205669875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019154749194618d, y: 0.46812066724711976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4918276473813339d, y: 0.4134294747754519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103774198313905d, y: 0.1606517004390361d), new NpgsqlTypes.NpgsqlPoint(x: 0.014652754770882792d, y: 0.6319784347918872d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06117501734095088d, y: 0.5639098256567878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323900800180023d, y: 0.9990194978647916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055447683848421d, y: 0.13179432856157003d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4039486281411715d, y: 0.25756672361986976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0822242662620537d, y: 0.21758807674573277d), new NpgsqlTypes.NpgsqlPoint(x: 0.209659671934184d, y: 0.5304173434473551d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4691462694667424d, y: 0.26433911301034885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138701329912259d, y: 0.6296422384148801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971945927188998d, y: 0.1463780447426959d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5291243279209641d, y: 0.8806249725072032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802508410986171d, y: 0.7598179044162063d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799841536010034d, y: 0.6658358034399477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9455841769906906d, y: 0.4249311542721492d), new NpgsqlTypes.NpgsqlPoint(x: 0.39145027217078465d, y: 0.5356331218941792d), new NpgsqlTypes.NpgsqlPoint(x: 0.519559556803139d, y: 0.6844474820176674d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29168703558468023d, y: 0.07415928006838535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142835900474519d, y: 0.3197476349651356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932606275562398d, y: 0.6421850713484679d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30221263978132396d, y: 0.12191502322451209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538976579663623d, y: 0.09006100412351936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261459304168896d, y: 0.6377251739359602d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125281735307426d, y: 0.5967235795116511d), new NpgsqlTypes.NpgsqlPoint(x: 0.02926367486342496d, y: 0.1236262851609703d), new NpgsqlTypes.NpgsqlPoint(x: 0.40738251175356055d, y: 0.07212061050293694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015709396872523d, y: 0.14438585367493884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008100092271676d, y: 0.021330021839225943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422027909534742d, y: 0.6089725722738332d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870989262575189d, y: 0.07145239733262487d), new NpgsqlTypes.NpgsqlPoint(x: 0.308794883845684d, y: 0.21571230520580154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629971580943295d, y: 0.14994562602431016d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7454680168524364d, y: 0.6748881049391418d), new NpgsqlTypes.NpgsqlPoint(x: 0.07253691309750154d, y: 0.9807912968357707d), new NpgsqlTypes.NpgsqlPoint(x: 0.37855112872609475d, y: 0.39711324372388546d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((7)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13949052982505428d, y: 0.8316729594495447d), new NpgsqlTypes.NpgsqlPoint(x: 0.09727789308467338d, y: 0.7133011574450183d), new NpgsqlTypes.NpgsqlPoint(x: 0.14928545624323386d, y: 0.9011088859233075d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.1900915126860846d, y: 0.5722938807604119d), new NpgsqlTypes.NpgsqlPoint(x: 0.018283920076534343d, y: 0.9819963257931497d), new NpgsqlTypes.NpgsqlPoint(x: 0.15562194314101796d, y: 0.028370082436546817d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((16)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6044289428225279d, y: 0.9586355760327908d), new NpgsqlTypes.NpgsqlPoint(x: 0.24788500084359733d, y: 0.35506055565108696d), new NpgsqlTypes.NpgsqlPoint(x: 0.14212101252181875d, y: 0.5117242585523684d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((1)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.03474051788696475d, y: 0.22732422558029963d), new NpgsqlTypes.NpgsqlPoint(x: 0.9680381618273258d, y: 0.4127603294324459d), new NpgsqlTypes.NpgsqlPoint(x: 0.6541396905476525d, y: 0.5541943927435214d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6475863378390223d, y: 0.8441427060847819d), new NpgsqlTypes.NpgsqlPoint(x: 0.5687675317278074d, y: 0.549619034523498d), new NpgsqlTypes.NpgsqlPoint(x: 0.5207579827498771d, y: 0.6242026635747528d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((18)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6260067661445959d, y: 0.6521684978966303d), new NpgsqlTypes.NpgsqlPoint(x: 0.7341762236492624d, y: 0.14340775750960966d), new NpgsqlTypes.NpgsqlPoint(x: 0.46986421041391035d, y: 0.11004285823597793d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((21)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7855744927616516d, y: 0.6767326322875103d), new NpgsqlTypes.NpgsqlPoint(x: 0.534521578546904d, y: 0.7708051305598942d), new NpgsqlTypes.NpgsqlPoint(x: 0.831573529193279d, y: 0.07909428968247423d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((9)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5875181993134777d, y: 0.5830425848630651d), new NpgsqlTypes.NpgsqlPoint(x: 0.8121678280387997d, y: 0.4316308687707505d), new NpgsqlTypes.NpgsqlPoint(x: 0.7376423894256561d, y: 0.19998927871073435d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10289573541720687d, y: 0.6832557175621746d), new NpgsqlTypes.NpgsqlPoint(x: 0.505812318851322d, y: 0.06773358855515033d), new NpgsqlTypes.NpgsqlPoint(x: 0.16479609061432454d, y: 0.07930431421222939d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.20948862450655115d, y: 0.15057757056748544d), new NpgsqlTypes.NpgsqlPoint(x: 0.3946022773628469d, y: 0.6531776879861563d), new NpgsqlTypes.NpgsqlPoint(x: 0.672744256258672d, y: 0.016342245286615875d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3398193550929144d, y: 0.10559533950756883d), new NpgsqlTypes.NpgsqlPoint(x: 0.09914033240096054d, y: 0.5755500164196112d), new NpgsqlTypes.NpgsqlPoint(x: 0.28271130979726156d, y: 0.8311967871253403d)))));

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((27)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.692797917860017d, y: 0.20492793091623962d), new NpgsqlTypes.NpgsqlPoint(x: 0.6960981668781152d, y: 0.9084347062673565d), new NpgsqlTypes.NpgsqlPoint(x: 0.20760770353976787d, y: 0.19124233330572105d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((11)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.40106124483101746d, y: 0.622603590765568d), new NpgsqlTypes.NpgsqlPoint(x: 0.8575653112024955d, y: 0.9125173345910114d), new NpgsqlTypes.NpgsqlPoint(x: 0.4176841331403591d, y: 0.9500515155094085d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7140727726620388d, y: 0.40490845169754475d), new NpgsqlTypes.NpgsqlPoint(x: 0.40620591669495887d, y: 0.6301558070450236d), new NpgsqlTypes.NpgsqlPoint(x: 0.09545709170487715d, y: 0.10185679114262058d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.37104235035093536d, y: 0.10290114442231468d), new NpgsqlTypes.NpgsqlPoint(x: 0.2071937356740703d, y: 0.32170114956753615d), new NpgsqlTypes.NpgsqlPoint(x: 0.9718746098058373d, y: 0.08819384695797072d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((31)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.8583732917278295d, y: 0.2421764397204721d), new NpgsqlTypes.NpgsqlPoint(x: 0.2513429582973874d, y: 0.33572581343145647d), new NpgsqlTypes.NpgsqlPoint(x: 0.08931695373753235d, y: 0.20685016476332807d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.012772849429905753d, y: 0.9958133947460179d), new NpgsqlTypes.NpgsqlPoint(x: 0.27314897940262994d, y: 0.46152335176201464d), new NpgsqlTypes.NpgsqlPoint(x: 0.6350824833839916d, y: 0.5240802788669787d)))));

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((39)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.07521938871022626d, y: 0.3680263075715664d), new NpgsqlTypes.NpgsqlPoint(x: 0.8279915300362114d, y: 0.9028460896939438d), new NpgsqlTypes.NpgsqlPoint(x: 0.639223590523989d, y: 0.5444391666020177d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((15)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9409248027048587d, y: 0.39029435343802354d), new NpgsqlTypes.NpgsqlPoint(x: 0.13523243696009157d, y: 0.24506432594388383d), new NpgsqlTypes.NpgsqlPoint(x: 0.7235198748825964d, y: 0.8343600296365101d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28935701068260666d, y: 0.09125820278752494d), new NpgsqlTypes.NpgsqlPoint(x: 0.05039700736661967d, y: 0.11765686701855627d), new NpgsqlTypes.NpgsqlPoint(x: 0.5236376195519149d, y: 0.20831184042803252d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((42)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.10154346486458321d, y: 0.33438279428132034d), new NpgsqlTypes.NpgsqlPoint(x: 0.8502231483089312d, y: 0.36428495133400485d), new NpgsqlTypes.NpgsqlPoint(x: 0.22914855322628924d, y: 0.6784628537221893d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((51)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.007194021430960595d, y: 0.7654549261361637d), new NpgsqlTypes.NpgsqlPoint(x: 0.858505675761975d, y: 0.6431345389904515d), new NpgsqlTypes.NpgsqlPoint(x: 0.16672225778591954d, y: 0.42213081451841816d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((17)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.18558797534755245d, y: 0.9984222761076977d), new NpgsqlTypes.NpgsqlPoint(x: 0.8069579517730773d, y: 0.9253277752384427d), new NpgsqlTypes.NpgsqlPoint(x: 0.5879872066165535d, y: 0.04249318296558535d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6440983409417519d, y: 0.8760626516574462d), new NpgsqlTypes.NpgsqlPoint(x: 0.916460354149361d, y: 0.8978841587510102d), new NpgsqlTypes.NpgsqlPoint(x: 0.12669381376476951d, y: 0.3048387611834852d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4505279625465102d, y: 0.9141760725772042d), new NpgsqlTypes.NpgsqlPoint(x: 0.08599271376805018d, y: 0.08355596268524101d), new NpgsqlTypes.NpgsqlPoint(x: 0.24854946636432662d, y: 0.5936398938508127d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((59)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5490824974120472d, y: 0.7757018818754039d), new NpgsqlTypes.NpgsqlPoint(x: 0.35750288126238094d, y: 0.3868233156430363d), new NpgsqlTypes.NpgsqlPoint(x: 0.2841597478424308d, y: 0.8905967846067928d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6977275272872223d, y: 0.040483398236350276d), new NpgsqlTypes.NpgsqlPoint(x: 0.22414246155964557d, y: 0.4388610191661836d), new NpgsqlTypes.NpgsqlPoint(x: 0.37217606440118267d, y: 0.3378578672117539d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.12863348601078028d, y: 0.8472424628655428d), new NpgsqlTypes.NpgsqlPoint(x: 0.5451986590222853d, y: 0.8476554865982009d), new NpgsqlTypes.NpgsqlPoint(x: 0.618162992007745d, y: 0.6898103365148964d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((64)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7247852998479728d, y: 0.7282519134956809d), new NpgsqlTypes.NpgsqlPoint(x: 0.11414461274745713d, y: 0.04346141458897268d), new NpgsqlTypes.NpgsqlPoint(x: 0.08987955648422574d, y: 0.9316456132476673d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2844418113137819d, y: 0.933205520324801d), new NpgsqlTypes.NpgsqlPoint(x: 0.7987930630979991d, y: 0.5456036182740831d), new NpgsqlTypes.NpgsqlPoint(x: 0.029914440517145535d, y: 0.7902346179050642d)))));

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((72)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.0847389712977058d, y: 0.46364529651661945d), new NpgsqlTypes.NpgsqlPoint(x: 0.6465301304735893d, y: 0.059297330172374485d), new NpgsqlTypes.NpgsqlPoint(x: 0.09073909975034344d, y: 0.16967152435252209d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4814410115700871d, y: 0.7425900026927792d), new NpgsqlTypes.NpgsqlPoint(x: 0.03207853973584629d, y: 0.10454269403476923d), new NpgsqlTypes.NpgsqlPoint(x: 0.5827295808369034d, y: 0.9544924668919592d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6963801180245736d, y: 0.4920029965282673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5922760466091155d, y: 0.3322101011199542d), new NpgsqlTypes.NpgsqlPoint(x: 0.3512771743211155d, y: 0.38998919972299584d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.47920601354504166d, y: 0.858174589550253d), new NpgsqlTypes.NpgsqlPoint(x: 0.48822735000226314d, y: 0.37649982624606093d), new NpgsqlTypes.NpgsqlPoint(x: 0.10974453744642498d, y: 0.5398160114931103d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((79)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.35565739280006337d, y: 0.6642013198250464d), new NpgsqlTypes.NpgsqlPoint(x: 0.21519741915499702d, y: 0.014649521893966955d), new NpgsqlTypes.NpgsqlPoint(x: 0.9551087706813608d, y: 0.9394430846146411d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9248450736811556d, y: 0.8510398037268947d), new NpgsqlTypes.NpgsqlPoint(x: 0.9534957393292061d, y: 0.7548795540175716d), new NpgsqlTypes.NpgsqlPoint(x: 0.04675542459122595d, y: 0.2990269972365802d)))));

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((87)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.09795190998665115d, y: 0.007027850513993683d), new NpgsqlTypes.NpgsqlPoint(x: 0.19730790165113188d, y: 0.5959231054573535d), new NpgsqlTypes.NpgsqlPoint(x: 0.24476630138449584d, y: 0.016084252258183107d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((34)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.02492179999286437d, y: 0.5276989117682291d), new NpgsqlTypes.NpgsqlPoint(x: 0.8142266603496687d, y: 0.6284413352231422d), new NpgsqlTypes.NpgsqlPoint(x: 0.9290781395160405d, y: 0.20122391217253766d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7099143721992266d, y: 0.7624154384268791d), new NpgsqlTypes.NpgsqlPoint(x: 0.8078075402428725d, y: 0.3545508565267401d), new NpgsqlTypes.NpgsqlPoint(x: 0.13472767489661397d, y: 0.30542557309361584d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((90)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.3828342610485913d, y: 0.35894972314378837d), new NpgsqlTypes.NpgsqlPoint(x: 0.18671630648024484d, y: 0.10642131342041294d), new NpgsqlTypes.NpgsqlPoint(x: 0.8281913418287219d, y: 0.7834234093372068d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((99)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.017605957186531795d, y: 0.3442293939464516d), new NpgsqlTypes.NpgsqlPoint(x: 0.008680738899271012d, y: 0.1674922120644483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8125630091094613d, y: 0.9007165803951255d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((39)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5283562693379287d, y: 0.021653005485836707d), new NpgsqlTypes.NpgsqlPoint(x: 0.6638376679853174d, y: 0.931773267776191d), new NpgsqlTypes.NpgsqlPoint(x: 0.7991234015350517d, y: 0.12465927508742136d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.6158356406536191d, y: 0.8617391590545774d), new NpgsqlTypes.NpgsqlPoint(x: 0.2903409023485183d, y: 0.3072963927290562d), new NpgsqlTypes.NpgsqlPoint(x: 0.010034982011303262d, y: 0.557494053912314d)))));

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((103)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.28996068675913145d, y: 0.1683481994839494d), new NpgsqlTypes.NpgsqlPoint(x: 0.5253983876045988d, y: 0.200731234698186d), new NpgsqlTypes.NpgsqlPoint(x: 0.3125078685278567d, y: 0.4062194773160277d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.43258063757810217d, y: 0.7801601204152567d), new NpgsqlTypes.NpgsqlPoint(x: 0.8185352660519374d, y: 0.15151146073832344d), new NpgsqlTypes.NpgsqlPoint(x: 0.2984292713141721d, y: 0.4836131367709715d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((106)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003713670825176d, y: 0.9550132356847105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6353255059330499d, y: 0.24507909334281242d), new NpgsqlTypes.NpgsqlPoint(x: 0.8551541271644327d, y: 0.6948257004645267d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((41)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7742476744135292d, y: 0.6629180091109277d), new NpgsqlTypes.NpgsqlPoint(x: 0.320882784708043d, y: 0.7879585391804091d), new NpgsqlTypes.NpgsqlPoint(x: 0.3966850901676139d, y: 0.3265180467390779d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((108)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2168586997071259d, y: 0.8857656129668058d), new NpgsqlTypes.NpgsqlPoint(x: 0.8260212478504196d, y: 0.4895136905976357d), new NpgsqlTypes.NpgsqlPoint(x: 0.7237101963161167d, y: 0.39724694064576305d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4021532921569092d, y: 0.03249740771315479d), new NpgsqlTypes.NpgsqlPoint(x: 0.11536761733861933d, y: 0.18374834586653088d), new NpgsqlTypes.NpgsqlPoint(x: 0.9417838199218243d, y: 0.059689704361092444d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((114)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.13888661247845613d, y: 0.5923505746935978d), new NpgsqlTypes.NpgsqlPoint(x: 0.7923947709022858d, y: 0.5782095067915081d), new NpgsqlTypes.NpgsqlPoint(x: 0.042755677408186976d, y: 0.42906754645563183d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((50)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4085460168674604d, y: 0.09506590878058707d), new NpgsqlTypes.NpgsqlPoint(x: 0.8816863881287634d, y: 0.9060067405244742d), new NpgsqlTypes.NpgsqlPoint(x: 0.5942372707366425d, y: 0.6279395186540444d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9797344355997396d, y: 0.3531066837075181d), new NpgsqlTypes.NpgsqlPoint(x: 0.6910846291353184d, y: 0.009731375593061697d), new NpgsqlTypes.NpgsqlPoint(x: 0.7963122865750111d, y: 0.07249551675687715d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9847837635735883d, y: 0.015850512497180724d), new NpgsqlTypes.NpgsqlPoint(x: 0.7271705582980773d, y: 0.38351499164702707d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522186914083033d, y: 0.5630895263674637d)))));

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7519022676867221d, y: 0.2241768015596155d), new NpgsqlTypes.NpgsqlPoint(x: 0.6236476544883038d, y: 0.6124815932489757d), new NpgsqlTypes.NpgsqlPoint(x: 0.11292256208464513d, y: 0.8012598934074298d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((125)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.2384966477935242d, y: 0.5283402542091672d), new NpgsqlTypes.NpgsqlPoint(x: 0.5629641328692447d, y: 0.2879481580107601d), new NpgsqlTypes.NpgsqlPoint(x: 0.6469117619676019d, y: 0.06300958808638235d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9971392975987112d, y: 0.23862294313129595d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875425967374345d, y: 0.8337724884760607d), new NpgsqlTypes.NpgsqlPoint(x: 0.695802610740149d, y: 0.31383706934206734d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9879371492765553d, y: 0.9444107450891424d), new NpgsqlTypes.NpgsqlPoint(x: 0.3727571169191193d, y: 0.3188568492623126d), new NpgsqlTypes.NpgsqlPoint(x: 0.50493638196555d, y: 0.2115567881933047d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4131864367253778d, y: 0.537073384960927d), new NpgsqlTypes.NpgsqlPoint(x: 0.8419231360208959d, y: 0.018193484632035517d), new NpgsqlTypes.NpgsqlPoint(x: 0.47271393157899455d, y: 0.29016397394842164d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((133)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7003801606540345d, y: 0.006281284262145581d), new NpgsqlTypes.NpgsqlPoint(x: 0.9978704942985369d, y: 0.010323621205669875d), new NpgsqlTypes.NpgsqlPoint(x: 0.5019154749194618d, y: 0.46812066724711976d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((60)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4918276473813339d, y: 0.4134294747754519d), new NpgsqlTypes.NpgsqlPoint(x: 0.9103774198313905d, y: 0.1606517004390361d), new NpgsqlTypes.NpgsqlPoint(x: 0.014652754770882792d, y: 0.6319784347918872d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.06117501734095088d, y: 0.5639098256567878d), new NpgsqlTypes.NpgsqlPoint(x: 0.8323900800180023d, y: 0.9990194978647916d), new NpgsqlTypes.NpgsqlPoint(x: 0.9055447683848421d, y: 0.13179432856157003d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((139)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4039486281411715d, y: 0.25756672361986976d), new NpgsqlTypes.NpgsqlPoint(x: 0.0822242662620537d, y: 0.21758807674573277d), new NpgsqlTypes.NpgsqlPoint(x: 0.209659671934184d, y: 0.5304173434473551d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.4691462694667424d, y: 0.26433911301034885d), new NpgsqlTypes.NpgsqlPoint(x: 0.7138701329912259d, y: 0.6296422384148801d), new NpgsqlTypes.NpgsqlPoint(x: 0.9971945927188998d, y: 0.1463780447426959d)))));

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((148)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.5291243279209641d, y: 0.8806249725072032d), new NpgsqlTypes.NpgsqlPoint(x: 0.6802508410986171d, y: 0.7598179044162063d), new NpgsqlTypes.NpgsqlPoint(x: 0.1799841536010034d, y: 0.6658358034399477d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9455841769906906d, y: 0.4249311542721492d), new NpgsqlTypes.NpgsqlPoint(x: 0.39145027217078465d, y: 0.5356331218941792d), new NpgsqlTypes.NpgsqlPoint(x: 0.519559556803139d, y: 0.6844474820176674d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.29168703558468023d, y: 0.07415928006838535d), new NpgsqlTypes.NpgsqlPoint(x: 0.7142835900474519d, y: 0.3197476349651356d), new NpgsqlTypes.NpgsqlPoint(x: 0.5932606275562398d, y: 0.6421850713484679d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.30221263978132396d, y: 0.12191502322451209d), new NpgsqlTypes.NpgsqlPoint(x: 0.8538976579663623d, y: 0.09006100412351936d), new NpgsqlTypes.NpgsqlPoint(x: 0.9261459304168896d, y: 0.6377251739359602d)))));

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((154)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7125281735307426d, y: 0.5967235795116511d), new NpgsqlTypes.NpgsqlPoint(x: 0.02926367486342496d, y: 0.1236262851609703d), new NpgsqlTypes.NpgsqlPoint(x: 0.40738251175356055d, y: 0.07212061050293694d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPolygon?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.9015709396872523d, y: 0.14438585367493884d), new NpgsqlTypes.NpgsqlPoint(x: 0.4008100092271676d, y: 0.021330021839225943d), new NpgsqlTypes.NpgsqlPoint(x: 0.8422027909534742d, y: 0.6089725722738332d)))));

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((157)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.870989262575189d, y: 0.07145239733262487d), new NpgsqlTypes.NpgsqlPoint(x: 0.308794883845684d, y: 0.21571230520580154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9629971580943295d, y: 0.14994562602431016d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((74)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPolygon)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPolygon(new NpgsqlTypes.NpgsqlPoint(x: 0.7454680168524364d, y: 0.6748881049391418d), new NpgsqlTypes.NpgsqlPoint(x: 0.07253691309750154d, y: 0.9807912968357707d), new NpgsqlTypes.NpgsqlPoint(x: 0.37855112872609475d, y: 0.39711324372388546d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
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
FROM public.binary_npgsqlpolygonpolygon0m m
LEFT JOIN public.binary_npgsqlpolygonpolygon0mi mi ON mi.id = m.npgsqlpolygonpolygon0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPolygonpolygon0M>(15);

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
                ((INpgsqlPolygonSingleTypepolygon)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPolygonSingleTypepolygon)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPolygonSingleTypepolygon)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPolygonpolygon0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPolygonpolygon0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpolygonpolygon0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPolygonpolygon0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpolygonpolygon0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPolygonpolygon0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(16),
                (NpgsqlTypes.NpgsqlDbType)(16)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPolygonSingleTypepolygon))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPolygonSingleTypepolygon)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPolygonpolygon0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

