

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
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9007797423433874d, b: 0.6855480154193034d, c: 0.645318090077876d),

new NpgsqlTypes.NpgsqlLine(a: 0.10614068574878965d, b: 0.015565462252797646d, c: 0.6035230080436413d),

new NpgsqlTypes.NpgsqlLine(a: 0.7825582690621548d, b: 0.6856426674865211d, c: 0.18445474047220956d),

new NpgsqlTypes.NpgsqlLine(a: 0.781815721388481d, b: 0.6754929857443273d, c: 0.7129299070014831d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5869063734682531d, b: 0.3433912883594963d, c: 0.9041442870146832d),

new NpgsqlTypes.NpgsqlLine(a: 0.9326716430168589d, b: 0.28667957155248336d, c: 0.911531310893417d),

new NpgsqlTypes.NpgsqlLine(a: 0.8461517006277302d, b: 0.8882119963085667d, c: 0.16987225017520036d),

new NpgsqlTypes.NpgsqlLine(a: 0.7453011039169734d, b: 0.5161153891588655d, c: 0.7161266975003483d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5537597688636656d, b: 0.7140876437367648d, c: 0.5872754887576824d),

new NpgsqlTypes.NpgsqlLine(a: 0.623675810291647d, b: 0.9198270538815941d, c: 0.3993768169664639d),

new NpgsqlTypes.NpgsqlLine(a: 0.18139362693301064d, b: 0.2848259510286162d, c: 0.3690201585852767d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.48096116794580634d, b: 0.9054473977388092d, c: 0.08356203268996398d),

new NpgsqlTypes.NpgsqlLine(a: 0.5322623851516046d, b: 0.6699264711825504d, c: 0.9754676758673951d),

new NpgsqlTypes.NpgsqlLine(a: 0.02943070195436659d, b: 0.4611768983062091d, c: 0.764803875511929d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6822068834467261d, b: 0.9342695980641087d, c: 0.8026294283682687d),

new NpgsqlTypes.NpgsqlLine(a: 0.3516641056346077d, b: 0.17119794808494782d, c: 0.7346665827323122d),

new NpgsqlTypes.NpgsqlLine(a: 0.9527415736177108d, b: 0.32948828998486623d, c: 0.8628694749852874d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6783598001890697d, b: 0.39095384174346637d, c: 0.4102453479654131d),

new NpgsqlTypes.NpgsqlLine(a: 0.8230240414153971d, b: 0.25649713374955585d, c: 0.6822787756286586d),

new NpgsqlTypes.NpgsqlLine(a: 0.8874918602672547d, b: 0.9287866393728321d, c: 0.6037853203535238d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31788224777513907d, b: 0.481895660166908d, c: 0.30069595398664983d),

new NpgsqlTypes.NpgsqlLine(a: 0.032268513163538626d, b: 0.6766756241667704d, c: 0.5464978876087354d),

new NpgsqlTypes.NpgsqlLine(a: 0.09665637999546828d, b: 0.621133919282133d, c: 0.7261210549576188d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.012470499283296244d, b: 0.2527760819895538d, c: 0.5744125675950745d),

new NpgsqlTypes.NpgsqlLine(a: 0.8661066082568122d, b: 0.8299051994320786d, c: 0.2326345700639082d),

new NpgsqlTypes.NpgsqlLine(a: 0.685491630991657d, b: 0.2645789720946903d, c: 0.20002394802965684d),

new NpgsqlTypes.NpgsqlLine(a: 0.9494969657148848d, b: 0.6558211861238259d, c: 0.8601604755163671d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3696869329137533d, b: 0.4567301064302477d, c: 0.9373571833450152d),

new NpgsqlTypes.NpgsqlLine(a: 0.38852021773726575d, b: 0.35848290968655405d, c: 0.16392980466811935d),

new NpgsqlTypes.NpgsqlLine(a: 0.038787510349552634d, b: 0.8920651283634106d, c: 0.2823385458907768d),

new NpgsqlTypes.NpgsqlLine(a: 0.4325262301073616d, b: 0.9423912838110037d, c: 0.033840587215758d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24346887162693553d, b: 0.564308039473466d, c: 0.6790641075039838d),

new NpgsqlTypes.NpgsqlLine(a: 0.7597219086951603d, b: 0.24002994699204738d, c: 0.5879094137955599d),

new NpgsqlTypes.NpgsqlLine(a: 0.5397824509780387d, b: 0.18700924234550542d, c: 0.5959661757444075d),

new NpgsqlTypes.NpgsqlLine(a: 0.9981918356677191d, b: 0.01807500707165688d, c: 0.5921336918629475d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8728164564408725d, b: 0.3509178384202797d, c: 0.3727257251905701d),

new NpgsqlTypes.NpgsqlLine(a: 0.6548402365084516d, b: 0.15523025270704338d, c: 0.5474464776131455d),

new NpgsqlTypes.NpgsqlLine(a: 0.7163087149079642d, b: 0.8509952122669464d, c: 0.08842962139481092d),

new NpgsqlTypes.NpgsqlLine(a: 0.8209220902317128d, b: 0.33112845596588114d, c: 0.8578951906593987d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.00032085062570774703d, b: 0.9602689392116495d, c: 0.050891573761503994d),

new NpgsqlTypes.NpgsqlLine(a: 0.9618805388094915d, b: 0.9908587775636469d, c: 0.31256931183277703d),

new NpgsqlTypes.NpgsqlLine(a: 0.836716554669501d, b: 0.7143033819654105d, c: 0.19211310354422684d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9716137940449372d, b: 0.5103613534867608d, c: 0.972136213263913d),

new NpgsqlTypes.NpgsqlLine(a: 0.8856132637990999d, b: 0.10733689072365371d, c: 0.6294769486561335d),

new NpgsqlTypes.NpgsqlLine(a: 0.2214392854040681d, b: 0.17730706836719257d, c: 0.5841539648221814d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3469515484325507d, b: 0.14530032457826403d, c: 0.26016505131530243d),

new NpgsqlTypes.NpgsqlLine(a: 0.5319202034174674d, b: 0.9570271069644218d, c: 0.3983063672309005d),

new NpgsqlTypes.NpgsqlLine(a: 0.6008274310935917d, b: 0.19798987336058527d, c: 0.7553464550696565d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4785385102621307d, b: 0.7877756594543329d, c: 0.6892621073745452d),

new NpgsqlTypes.NpgsqlLine(a: 0.8287796915040638d, b: 0.7075370227904898d, c: 0.17243717474758535d),

new NpgsqlTypes.NpgsqlLine(a: 0.7486544490091228d, b: 0.034495727012080146d, c: 0.6782228660939426d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3704024904611384d, b: 0.24071367504578878d, c: 0.9800422151355366d),

new NpgsqlTypes.NpgsqlLine(a: 0.7795317646802247d, b: 0.8185866299808039d, c: 0.5804372359562057d),

new NpgsqlTypes.NpgsqlLine(a: 0.38550154154028726d, b: 0.9478642899546278d, c: 0.28493701994251885d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16612762002263892d, b: 0.04471155841407015d, c: 0.7227442568276962d),

new NpgsqlTypes.NpgsqlLine(a: 0.16116911285924396d, b: 0.11925948963525501d, c: 0.5530346509716966d),

new NpgsqlTypes.NpgsqlLine(a: 0.12271508474227899d, b: 0.5429142175177387d, c: 0.842851465911375d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7916567650053191d, b: 0.4495485133242825d, c: 0.05562567289238329d),

new NpgsqlTypes.NpgsqlLine(a: 0.7439630613092645d, b: 0.003906770516639235d, c: 0.8815986289379132d),

new NpgsqlTypes.NpgsqlLine(a: 0.5065725885545815d, b: 0.7925249406759832d, c: 0.48549192915627637d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07093491418478015d, b: 0.11035700236453727d, c: 0.18992000358200134d),

new NpgsqlTypes.NpgsqlLine(a: 0.9071908471298086d, b: 0.5945546921708263d, c: 0.6257324891373818d),

new NpgsqlTypes.NpgsqlLine(a: 0.5709446971382608d, b: 0.9759725121734026d, c: 0.9223519739127053d),

new NpgsqlTypes.NpgsqlLine(a: 0.934888258365737d, b: 0.17123247755154447d, c: 0.7128304257520525d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.543067079702758d, b: 0.044290220829580784d, c: 0.056888097398737125d),

new NpgsqlTypes.NpgsqlLine(a: 0.2970852765776053d, b: 0.409055873429927d, c: 0.9750028906873168d),

new NpgsqlTypes.NpgsqlLine(a: 0.4979779616841091d, b: 0.2659642518546398d, c: 0.23065936493759953d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13800498130087102d, b: 0.035449020085870364d, c: 0.2679123554557207d),

new NpgsqlTypes.NpgsqlLine(a: 0.07832927990798966d, b: 0.13505170569120217d, c: 0.6768356792308304d),

new NpgsqlTypes.NpgsqlLine(a: 0.5001404935091737d, b: 0.3020390418767601d, c: 0.7532561620948842d),

new NpgsqlTypes.NpgsqlLine(a: 0.3597683251614924d, b: 0.10725715867769281d, c: 0.40180750944917754d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1387976337841197d, b: 0.3690969565750122d, c: 0.41281713292775213d),

new NpgsqlTypes.NpgsqlLine(a: 0.8078860772661421d, b: 0.2207408082304776d, c: 0.23853792340624091d),

new NpgsqlTypes.NpgsqlLine(a: 0.3849658262997524d, b: 0.5796422980079395d, c: 0.9739844548560211d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3828415048709731d, b: 0.7789186616287999d, c: 0.3973069711325279d),

new NpgsqlTypes.NpgsqlLine(a: 0.9536387004717448d, b: 0.6662281241708414d, c: 0.0658711801828652d),

new NpgsqlTypes.NpgsqlLine(a: 0.26632600437361065d, b: 0.5224421016181212d, c: 0.7774685111284189d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22793981028263366d, b: 0.2613825080791399d, c: 0.17160175485362583d),

new NpgsqlTypes.NpgsqlLine(a: 0.6132266525077452d, b: 0.796988353257263d, c: 0.3173366701684822d),

new NpgsqlTypes.NpgsqlLine(a: 0.804503112610985d, b: 0.6362765198996994d, c: 0.15924636462538033d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11284274768417357d, b: 0.25900510907252927d, c: 0.7732394899063726d),

new NpgsqlTypes.NpgsqlLine(a: 0.5455578293358194d, b: 0.5374801664765578d, c: 0.19090827667709598d),

new NpgsqlTypes.NpgsqlLine(a: 0.722604358066441d, b: 0.32347132553115654d, c: 0.7512590288286531d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.10882736699330664d, b: 0.25759716074391836d, c: 0.5154291606062361d),

new NpgsqlTypes.NpgsqlLine(a: 0.1367519459346216d, b: 0.2912096750770341d, c: 0.8361970094368105d),

new NpgsqlTypes.NpgsqlLine(a: 0.04972804775266404d, b: 0.5973770823957444d, c: 0.46012451312011426d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.01952806082599645d, b: 0.06945815958373747d, c: 0.3324107914608947d),

new NpgsqlTypes.NpgsqlLine(a: 0.40410334956492044d, b: 0.9521491882005916d, c: 0.891062722841474d),

new NpgsqlTypes.NpgsqlLine(a: 0.631885423509036d, b: 0.8968336179751342d, c: 0.10944370087309996d),

new NpgsqlTypes.NpgsqlLine(a: 0.2338610920103944d, b: 0.44659816080317727d, c: 0.019110187368685083d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5666875074004406d, b: 0.04795119002306325d, c: 0.019979954293638857d),

new NpgsqlTypes.NpgsqlLine(a: 0.4880900650185108d, b: 0.02592391450867182d, c: 0.2078500043186179d),

new NpgsqlTypes.NpgsqlLine(a: 0.39321041319897065d, b: 0.08546585267940643d, c: 0.8918069736438841d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7325073946134595d, b: 0.08525047943195108d, c: 0.4627786139687019d),

new NpgsqlTypes.NpgsqlLine(a: 0.1117148899472139d, b: 0.6969530092812719d, c: 0.13609451424110985d),

new NpgsqlTypes.NpgsqlLine(a: 0.42108390484887437d, b: 0.7752095743698647d, c: 0.3787624825186887d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49842401405143955d, b: 0.6207327611018084d, c: 0.8248452998894221d),

new NpgsqlTypes.NpgsqlLine(a: 0.9152491308209916d, b: 0.9529747414968829d, c: 0.3259598029681142d),

new NpgsqlTypes.NpgsqlLine(a: 0.6166927145397312d, b: 0.5664958887735518d, c: 0.1532899970042496d),

new NpgsqlTypes.NpgsqlLine(a: 0.9904560248492833d, b: 0.32090424362769376d, c: 0.3781028902792348d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6620286552814935d, b: 0.5786217796718952d, c: 0.9153260429546306d),

new NpgsqlTypes.NpgsqlLine(a: 0.312072764807688d, b: 0.7396620141549207d, c: 0.6519919734039459d),

new NpgsqlTypes.NpgsqlLine(a: 0.7384977403515605d, b: 0.871159813104258d, c: 0.34702975590331053d),

new NpgsqlTypes.NpgsqlLine(a: 0.1127412879760803d, b: 0.649236656107949d, c: 0.6176521553174003d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2412246657741931d, b: 0.4984797506602132d, c: 0.7109230429727594d),

new NpgsqlTypes.NpgsqlLine(a: 0.9140439372811567d, b: 0.5838492019735512d, c: 0.004156748168597235d),

new NpgsqlTypes.NpgsqlLine(a: 0.582079624753876d, b: 0.11868585807488308d, c: 0.6385739071287576d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.817778396902983d, b: 0.8033724463839472d, c: 0.17479924994127538d),

new NpgsqlTypes.NpgsqlLine(a: 0.027876608654616053d, b: 0.9705758865558834d, c: 0.11831662545845478d),

new NpgsqlTypes.NpgsqlLine(a: 0.9425673955073692d, b: 0.23239234129774988d, c: 0.2922250949419385d),

new NpgsqlTypes.NpgsqlLine(a: 0.5475162939621135d, b: 0.46229226985038296d, c: 0.9676258830700025d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24723300175467233d, b: 0.38703389187124015d, c: 0.859741901607078d),

new NpgsqlTypes.NpgsqlLine(a: 0.4267156470380076d, b: 0.299369248737533d, c: 0.9275000051607334d),

new NpgsqlTypes.NpgsqlLine(a: 0.29613454962352137d, b: 0.5640115680542116d, c: 0.15684776318046934d),

new NpgsqlTypes.NpgsqlLine(a: 0.1889930391259661d, b: 0.5069624476637585d, c: 0.7839535834706761d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 73,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.463650969330601d, b: 0.7789493986828048d, c: 0.6958401885979629d),

new NpgsqlTypes.NpgsqlLine(a: 0.2628262179843843d, b: 0.4149137662115444d, c: 0.31154045073712466d),

new NpgsqlTypes.NpgsqlLine(a: 0.6604625376117146d, b: 0.8419074139407081d, c: 0.3471461510696937d),

new NpgsqlTypes.NpgsqlLine(a: 0.4492166384743489d, b: 0.7207593701881713d, c: 0.21091856474296056d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.312732689542665d, b: 0.9644140776258859d, c: 0.10212330817541027d),

new NpgsqlTypes.NpgsqlLine(a: 0.03691509094190315d, b: 0.5759403462835503d, c: 0.7703451187252678d),

new NpgsqlTypes.NpgsqlLine(a: 0.4339469722443099d, b: 0.8753444595562244d, c: 0.13763628408783268d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31383814621082473d, b: 0.802277635130694d, c: 0.04155150517099482d),

new NpgsqlTypes.NpgsqlLine(a: 0.9271472932478032d, b: 0.2974736380838825d, c: 0.7627616708169641d),

new NpgsqlTypes.NpgsqlLine(a: 0.8182591712168487d, b: 0.22836957147122194d, c: 0.1916326548681262d),

new NpgsqlTypes.NpgsqlLine(a: 0.3973223118651954d, b: 0.586152654987284d, c: 0.7073602318806882d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30907310329448d, b: 0.1719494518892667d, c: 0.8160522079295542d),

new NpgsqlTypes.NpgsqlLine(a: 0.08082081452564893d, b: 0.9665391402735974d, c: 0.031497508137242614d),

new NpgsqlTypes.NpgsqlLine(a: 0.8254457716517026d, b: 0.22514050680917008d, c: 0.17354457577803262d),

new NpgsqlTypes.NpgsqlLine(a: 0.8289223429862493d, b: 0.8785306003504285d, c: 0.7621886453497093d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9084108106059219d, b: 0.7709971365351206d, c: 0.7392710269728803d),

new NpgsqlTypes.NpgsqlLine(a: 0.12289376125656926d, b: 0.8790297772068151d, c: 0.5966314793704707d),

new NpgsqlTypes.NpgsqlLine(a: 0.13031679170535881d, b: 0.8507279428952338d, c: 0.09866358350727633d),

new NpgsqlTypes.NpgsqlLine(a: 0.829920347694751d, b: 0.0313755249632095d, c: 0.35722501436911946d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23970616041948245d, b: 0.18689257512588275d, c: 0.32142748924681197d),

new NpgsqlTypes.NpgsqlLine(a: 0.9913907889306618d, b: 0.2714109679058264d, c: 0.40652848050855683d),

new NpgsqlTypes.NpgsqlLine(a: 0.5435877856968652d, b: 0.6165486111162262d, c: 0.9007284317043281d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3437795573099277d, b: 0.6281141868052563d, c: 0.49720455410266695d),

new NpgsqlTypes.NpgsqlLine(a: 0.2674191073429647d, b: 0.5942478181444458d, c: 0.41266144556297746d),

new NpgsqlTypes.NpgsqlLine(a: 0.5031433289545723d, b: 0.09036334069424123d, c: 0.7808529119476982d),

new NpgsqlTypes.NpgsqlLine(a: 0.4159688671915339d, b: 0.8664612939281784d, c: 0.13750468815399752d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6746091773340616d, b: 0.5830317500570699d, c: 0.5356230644766208d),

new NpgsqlTypes.NpgsqlLine(a: 0.398963445143555d, b: 0.8882243870726402d, c: 0.8331946934613137d),

new NpgsqlTypes.NpgsqlLine(a: 0.2814160826613361d, b: 0.5128858628493161d, c: 0.6835645976994722d),

new NpgsqlTypes.NpgsqlLine(a: 0.7862381272192124d, b: 0.6878289825458943d, c: 0.8607739381598885d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8139008717890419d, b: 0.6368484007927875d, c: 0.7124477122144762d),

new NpgsqlTypes.NpgsqlLine(a: 0.22346646434120432d, b: 0.9547185774206655d, c: 0.9094465131054109d),

new NpgsqlTypes.NpgsqlLine(a: 0.5053102018222376d, b: 0.9002473014632502d, c: 0.3887178883736162d),

new NpgsqlTypes.NpgsqlLine(a: 0.6410451279980468d, b: 0.5715601531299593d, c: 0.6768589961628366d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5458485306820803d, b: 0.9317552342559943d, c: 0.6502776601182289d),

new NpgsqlTypes.NpgsqlLine(a: 0.1813405576793654d, b: 0.14704761979902847d, c: 0.3568740754298583d),

new NpgsqlTypes.NpgsqlLine(a: 0.2763427265701045d, b: 0.7934902843041253d, c: 0.8017773179957777d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 104,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6259641010743394d, b: 0.1635214653164353d, c: 0.9505278726022571d),

new NpgsqlTypes.NpgsqlLine(a: 0.6238543369646163d, b: 0.39725130669047104d, c: 0.05842305582856999d),

new NpgsqlTypes.NpgsqlLine(a: 0.8108084295422987d, b: 0.6374055812444044d, c: 0.2867357957783563d),

new NpgsqlTypes.NpgsqlLine(a: 0.986420594680803d, b: 0.5463832951785816d, c: 0.44099173283676163d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8251335187368593d, b: 0.33311051829557115d, c: 0.12243811553583461d),

new NpgsqlTypes.NpgsqlLine(a: 0.37436419825903455d, b: 0.8672858952367783d, c: 0.6939734405726575d),

new NpgsqlTypes.NpgsqlLine(a: 0.37918363549433953d, b: 0.9105256207766362d, c: 0.9723550387675296d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 113,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32733217833809825d, b: 0.335318133364901d, c: 0.2517836683699094d),

new NpgsqlTypes.NpgsqlLine(a: 0.9136973152338366d, b: 0.9438676258256029d, c: 0.7358290254596411d),

new NpgsqlTypes.NpgsqlLine(a: 0.1626794226074333d, b: 0.34996076633060713d, c: 0.2151242982901509d),

new NpgsqlTypes.NpgsqlLine(a: 0.6114565298785051d, b: 0.21393147740093543d, c: 0.76793474601499d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5525547012130761d, b: 0.030389917130728694d, c: 0.9920527336881655d),

new NpgsqlTypes.NpgsqlLine(a: 0.9474206193945949d, b: 0.4580796110323129d, c: 0.43534636335514965d),

new NpgsqlTypes.NpgsqlLine(a: 0.0893299965503156d, b: 0.9054185443243995d, c: 0.7983717788956577d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6512551217817552d, b: 0.9969482472847427d, c: 0.7841392522214871d),

new NpgsqlTypes.NpgsqlLine(a: 0.44384979035247296d, b: 0.9835708500007727d, c: 0.32442577466708755d),

new NpgsqlTypes.NpgsqlLine(a: 0.5917843672522749d, b: 0.5138474572989717d, c: 0.7048073013121401d),

new NpgsqlTypes.NpgsqlLine(a: 0.5933271416921272d, b: 0.33869719293721046d, c: 0.9362039857538084d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2275221447078314d, b: 0.5274330516745649d, c: 0.8339229835518217d),

new NpgsqlTypes.NpgsqlLine(a: 0.9329868909015834d, b: 0.341385764778809d, c: 0.7227518205532464d),

new NpgsqlTypes.NpgsqlLine(a: 0.4982599628375505d, b: 0.9176195676431694d, c: 0.7949478080060876d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8322712032099143d, b: 0.9276005504305069d, c: 0.41514794800432353d),

new NpgsqlTypes.NpgsqlLine(a: 0.7746563247760375d, b: 0.6034947538059352d, c: 0.4273467892334397d),

new NpgsqlTypes.NpgsqlLine(a: 0.6941230534560211d, b: 0.00010670966062731324d, c: 0.31406027394796265d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3399968781026632d, b: 0.16733811001419363d, c: 0.6041612668455119d),

new NpgsqlTypes.NpgsqlLine(a: 0.17448447930678934d, b: 0.4776334465686304d, c: 0.6704829373804913d),

new NpgsqlTypes.NpgsqlLine(a: 0.4251207462266525d, b: 0.4449965465251796d, c: 0.15633811593078561d),

new NpgsqlTypes.NpgsqlLine(a: 0.7690749361734991d, b: 0.1936107112393891d, c: 0.24204227999240768d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5718015413361527d, b: 0.2709644778283202d, c: 0.9427575263830675d),

new NpgsqlTypes.NpgsqlLine(a: 0.8862154152661017d, b: 0.033784851290215356d, c: 0.7229899810957972d),

new NpgsqlTypes.NpgsqlLine(a: 0.1479626461375786d, b: 0.6822258957465037d, c: 0.7594974883503774d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7036864651528272d, b: 0.9582538260874437d, c: 0.5903935227004065d),

new NpgsqlTypes.NpgsqlLine(a: 0.9089849306701406d, b: 0.5466149910526197d, c: 0.8244372354395402d),

new NpgsqlTypes.NpgsqlLine(a: 0.12466860708807836d, b: 0.4115067424090971d, c: 0.44126311247003525d),

new NpgsqlTypes.NpgsqlLine(a: 0.5798313911861249d, b: 0.7908515980073161d, c: 0.950922541738392d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.30507424586224896d, b: 0.020709349680308353d, c: 0.9357895314530134d),

new NpgsqlTypes.NpgsqlLine(a: 0.7953985292698128d, b: 0.5551548680899377d, c: 0.8533807152366115d),

new NpgsqlTypes.NpgsqlLine(a: 0.5969508305281953d, b: 0.8185822905362387d, c: 0.9665519316346055d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8041164289475105d, b: 0.4421440913962911d, c: 0.9155734419349902d),

new NpgsqlTypes.NpgsqlLine(a: 0.5760413039801481d, b: 0.044471456367095374d, c: 0.7041181405926672d),

new NpgsqlTypes.NpgsqlLine(a: 0.8954100162492369d, b: 0.4639432765871959d, c: 0.8513073293601703d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47038173669894257d, b: 0.9688140768093665d, c: 0.2943608585054418d),

new NpgsqlTypes.NpgsqlLine(a: 0.8409674182568863d, b: 0.17460688281824444d, c: 0.1688613308796869d),

new NpgsqlTypes.NpgsqlLine(a: 0.30672563099776473d, b: 0.184088102625668d, c: 0.9506707421843921d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35266751415029196d, b: 0.026863770364868422d, c: 0.3081367808246085d),

new NpgsqlTypes.NpgsqlLine(a: 0.5508501206917037d, b: 0.546576580828669d, c: 0.1129002607964894d),

new NpgsqlTypes.NpgsqlLine(a: 0.22834293493360502d, b: 0.2486282692990831d, c: 0.9734059186818047d),

new NpgsqlTypes.NpgsqlLine(a: 0.701836866888252d, b: 0.057071687543865046d, c: 0.03504462647833284d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.928519624472745d, b: 0.4092884559607449d, c: 0.3138096932378137d),

new NpgsqlTypes.NpgsqlLine(a: 0.33986141637765455d, b: 0.5954328573274004d, c: 0.432958485627823d),

new NpgsqlTypes.NpgsqlLine(a: 0.2880273346701664d, b: 0.30394945876620394d, c: 0.943322725798303d),

new NpgsqlTypes.NpgsqlLine(a: 0.07307087299204895d, b: 0.7118851162574567d, c: 0.1817108626269961d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8885911065954066d, b: 0.9079410832044771d, c: 0.7033260411042601d),

new NpgsqlTypes.NpgsqlLine(a: 0.15137174631657657d, b: 0.41726896322081886d, c: 0.10301704690052704d),

new NpgsqlTypes.NpgsqlLine(a: 0.7652387158905082d, b: 0.7242050572010594d, c: 0.7272347839087719d),

new NpgsqlTypes.NpgsqlLine(a: 0.5139375968671661d, b: 0.7137631599602668d, c: 0.9078424245788883d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 133,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9915855820512804d, b: 0.4701096443523938d, c: 0.20442077700060501d),

new NpgsqlTypes.NpgsqlLine(a: 0.05157499746086003d, b: 0.785411650030928d, c: 0.21388656911117998d),

new NpgsqlTypes.NpgsqlLine(a: 0.5889328120235265d, b: 0.630723435977147d, c: 0.8088289854796812d),

new NpgsqlTypes.NpgsqlLine(a: 0.725186636130275d, b: 0.9820237365261926d, c: 0.8673705271596805d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7196353104072564d, b: 0.6464856023465484d, c: 0.6001150713625724d),

new NpgsqlTypes.NpgsqlLine(a: 0.4842603219711378d, b: 0.8839804795927999d, c: 0.27450547408738923d),

new NpgsqlTypes.NpgsqlLine(a: 0.5809348740821695d, b: 0.14096156778719138d, c: 0.7188299429319667d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9038134070496365d, b: 0.9041827416859314d, c: 0.4135265127106068d),

new NpgsqlTypes.NpgsqlLine(a: 0.9523084337105268d, b: 0.12873944645438373d, c: 0.770926072524878d),

new NpgsqlTypes.NpgsqlLine(a: 0.8383482133271556d, b: 0.8090776678432188d, c: 0.4938951065109045d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8376588271292957d, b: 0.6298570479743548d, c: 0.6984804307736635d),

new NpgsqlTypes.NpgsqlLine(a: 0.8357654486934555d, b: 0.755699055229897d, c: 0.6531681473917356d),

new NpgsqlTypes.NpgsqlLine(a: 0.4538114388559725d, b: 0.1867318628670791d, c: 0.224244366403615d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.34346587157565833d, b: 0.3827118569182959d, c: 0.7236086718928042d),

new NpgsqlTypes.NpgsqlLine(a: 0.5261676519414481d, b: 0.2864893217288833d, c: 0.8011417076742359d),

new NpgsqlTypes.NpgsqlLine(a: 0.392178105251351d, b: 0.5131144706868054d, c: 0.8500498519822285d),

new NpgsqlTypes.NpgsqlLine(a: 0.37353512156821256d, b: 0.013823251631794209d, c: 0.5394898837676084d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5233245550336033d, b: 0.539915487697494d, c: 0.9583708827932614d),

new NpgsqlTypes.NpgsqlLine(a: 0.7007325933444958d, b: 0.4392553979698399d, c: 0.08770461203354785d),

new NpgsqlTypes.NpgsqlLine(a: 0.063722483477345d, b: 0.27759104217042463d, c: 0.5034173125856605d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5663272381962811d, b: 0.7618980429408235d, c: 0.8984202392826026d),

new NpgsqlTypes.NpgsqlLine(a: 0.2712708725064862d, b: 0.5736865566939767d, c: 0.588038583651414d),

new NpgsqlTypes.NpgsqlLine(a: 0.10726456120566419d, b: 0.1869137674160758d, c: 0.5906287467469368d),

new NpgsqlTypes.NpgsqlLine(a: 0.17757021570257459d, b: 0.10998595856744897d, c: 0.05070510966531483d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7060827347450837d, b: 0.6319300257693705d, c: 0.04359379587354628d),

new NpgsqlTypes.NpgsqlLine(a: 0.17184922264281088d, b: 0.15454422957214464d, c: 0.221593963139885d),

new NpgsqlTypes.NpgsqlLine(a: 0.1823774745935579d, b: 0.3922930551113971d, c: 0.06410319830469491d),

new NpgsqlTypes.NpgsqlLine(a: 0.7238581574496601d, b: 0.38018477137177376d, c: 0.44449257596857294d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3022180529595827d, b: 0.6787402060246686d, c: 0.1604050076289305d),

new NpgsqlTypes.NpgsqlLine(a: 0.4350130143196608d, b: 0.4674805111640957d, c: 0.36239298024945676d),

new NpgsqlTypes.NpgsqlLine(a: 0.6589500024485037d, b: 0.23809435452172623d, c: 0.08509730550781347d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9397064083546828d, b: 0.6869150218816262d, c: 0.12607698201436557d),

new NpgsqlTypes.NpgsqlLine(a: 0.12780825722313882d, b: 0.5192713143472845d, c: 0.7657090914231371d),

new NpgsqlTypes.NpgsqlLine(a: 0.3642388951219534d, b: 0.8640265716677749d, c: 0.32577562859500553d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 156,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.26404623787068604d, b: 0.010717476487115962d, c: 0.12218120819782874d),

new NpgsqlTypes.NpgsqlLine(a: 0.5219619689946265d, b: 0.4231988393929099d, c: 0.006969350001002961d),

new NpgsqlTypes.NpgsqlLine(a: 0.7731594637209596d, b: 0.3535363448090343d, c: 0.5366671905144875d),

new NpgsqlTypes.NpgsqlLine(a: 0.6386004104108445d, b: 0.3176502269587499d, c: 0.942437872984907d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 83,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2525683990207651d, b: 0.5390143450148185d, c: 0.9093529627908278d),

new NpgsqlTypes.NpgsqlLine(a: 0.6047445978570736d, b: 0.5900761246082522d, c: 0.10239687113481477d),

new NpgsqlTypes.NpgsqlLine(a: 0.7777062434745498d, b: 0.12715224042691287d, c: 0.49958523239050434d),

new NpgsqlTypes.NpgsqlLine(a: 0.7889178801239182d, b: 0.3101256639634772d, c: 0.4254507412762619d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7110939981462852d, b: 0.13876606300469274d, c: 0.6420485612076556d),

new NpgsqlTypes.NpgsqlLine(a: 0.04371436942793938d, b: 0.8851805606000739d, c: 0.9438560168805369d),

new NpgsqlTypes.NpgsqlLine(a: 0.5237807506337175d, b: 0.1539206005110707d, c: 0.1117889701418141d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29292452194316343d, b: 0.4178216930752644d, c: 0.005786862481155897d),

new NpgsqlTypes.NpgsqlLine(a: 0.9545003581847427d, b: 0.3952760094157114d, c: 0.5540498146742652d),

new NpgsqlTypes.NpgsqlLine(a: 0.814532616484749d, b: 0.025578462392395918d, c: 0.4990003200223314d),

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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 66;
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 126;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 57;
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
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
            batchName: "DbConnectionSelectModelDynParBatch",
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 34;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 29;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 18;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 24;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
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
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineArray2M>();
                var models2 = new List<FlatNpgsqlLinelineArray2M>();
                ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models2[i],_testData[i], false);
                }
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
            batchName: "DbConnectionDynQuerySelectModelBatch",
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 51, query1, 104, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 10, query1, 97, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));
FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
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
            batchName: "DbConnectionSelectModelBatch",
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
        private void DbConnectionSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatchAsync(connection, 115, 6))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
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
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSelectModelBatch(connection, 57, 5))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 104);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 129);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
FROM public.binary_npgsqllinelinearray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2M)],
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

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlLinelineArray2M>(15);

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
                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[0], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[1], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[2], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[3], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[4], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[5], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[6], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[7], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[8], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[9], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[10], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[11], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[23],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[24],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[25],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[26],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[27],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[28],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[29],_testData[29], false);
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
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
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

        [Test, Order(2)]
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
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
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
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

