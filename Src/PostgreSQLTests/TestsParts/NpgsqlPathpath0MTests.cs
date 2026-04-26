

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
    internal partial interface INpgsqlPathSingleTypepath
    {
    }
    
    internal partial class NpgsqlPathSingleTypepath : INpgsqlPathSingleTypepath
    {


#region TestData

        private readonly NpgsqlPathpath0M[] _testData = new NpgsqlPathpath0M[]
        {
            new NpgsqlPathpath0M
{
    Id = 5,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3292856400020443d, y: 0.7834266956029355d), new NpgsqlTypes.NpgsqlPoint(x: 0.39751827918086524d, y: 0.26662455162665655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564196477448137d, y: 0.8364134018700511d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43012782390254023d, y: 0.11663862073560194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469466230977724d, y: 0.9147467027044733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556360076288688d, y: 0.8499879961218593d)),
},
            new NpgsqlPathpath0M
{
    Id = 13,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7825394675633618d, y: 0.722276853899619d), new NpgsqlTypes.NpgsqlPoint(x: 0.26121370733138505d, y: 0.07258015997058065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4801593317757946d, y: 0.9437755039599571d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 7,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517478664536917d, y: 0.10446579799349653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150090092162484d, y: 0.977431532059657d), new NpgsqlTypes.NpgsqlPoint(x: 0.943755420967301d, y: 0.3058808653157784d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0970814073230486d, y: 0.8240621527320565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699515066016043d, y: 0.5922265625801978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4976948715329512d, y: 0.7125985467528595d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1840434649260244d, y: 0.760626416733506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571406007333563d, y: 0.3397837778019699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349998029914724d, y: 0.43397882057520276d)),
},
            new NpgsqlPathpath0M
{
    Id = 15,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02456463977520218d, y: 0.19665661839067683d), new NpgsqlTypes.NpgsqlPoint(x: 0.40222938365550287d, y: 0.3189722963125796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823563598767766d, y: 0.4043552334832662d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4447868442925701d, y: 0.8873528099797044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287987666241971d, y: 0.8214714860707643d), new NpgsqlTypes.NpgsqlPoint(x: 0.32809479145963427d, y: 0.9160806948771297d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 12,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057783353342745536d, y: 0.12443531964324839d), new NpgsqlTypes.NpgsqlPoint(x: 0.248065805916863d, y: 0.3356463374578891d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580624740225015d, y: 0.397868708128541d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9280628691777285d, y: 0.5089909524512031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420480581951024d, y: 0.18558275177265704d), new NpgsqlTypes.NpgsqlPoint(x: 0.27148160971407986d, y: 0.6254791499056457d)),
},
            new NpgsqlPathpath0M
{
    Id = 24,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06135378819497517d, y: 0.7688448030361005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728072410643656d, y: 0.5022608610543933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888110468445535d, y: 0.10643746290432343d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 26,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783639039340874d, y: 0.9640264091356728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368906312988153d, y: 0.5490476692515089d), new NpgsqlTypes.NpgsqlPoint(x: 0.752198538504357d, y: 0.8390496547803169d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 18,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753185912322491d, y: 0.8214928820297882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986381122100313d, y: 0.10174079613177733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352318554981762d, y: 0.6239829138553686d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9161618657467284d, y: 0.733947479570986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135255617842346d, y: 0.5224247923436788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733186728078489d, y: 0.24247113272491239d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7655404730870079d, y: 0.2842799054824314d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969457996896066d, y: 0.27760536211235776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264996755650999d, y: 0.16513896727235122d)),
},
            new NpgsqlPathpath0M
{
    Id = 28,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6380301140090119d, y: 0.5522644889948162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417243548568196d, y: 0.2886922357193079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14201377042487784d, y: 0.2062731802714124d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 33,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7007660060949499d, y: 0.13696950704621014d), new NpgsqlTypes.NpgsqlPoint(x: 0.35932373075111657d, y: 0.4485070388113874d), new NpgsqlTypes.NpgsqlPoint(x: 0.02989321645328169d, y: 0.7383303475207379d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 22,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8266783492150472d, y: 0.030216892654414407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274856984751379d, y: 0.6747111332437898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3812195119309725d, y: 0.9309274422194211d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.922889016592517d, y: 0.720605801759105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938050672025005d, y: 0.06533813426021462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804756683270009d, y: 0.9713057135734395d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 40,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003841836884311056d, y: 0.9927819233005057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592130172960172d, y: 0.7029948861773745d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697306770160859d, y: 0.16622397256185595d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24979512028469342d, y: 0.02158177405927797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959654844528018d, y: 0.32601993773838944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865450703744082d, y: 0.5274608293470339d)),
},
            new NpgsqlPathpath0M
{
    Id = 41,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018116653191622478d, y: 0.633501068748992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472217695826058d, y: 0.9972545948358646d), new NpgsqlTypes.NpgsqlPoint(x: 0.13145122598392556d, y: 0.5303152908755342d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 25,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20516465590008293d, y: 0.27830355955144126d), new NpgsqlTypes.NpgsqlPoint(x: 0.27011013861944977d, y: 0.8429434794321093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863334099394816d, y: 0.7220852072580415d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641317285203961d, y: 0.9909881339318382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801420459047511d, y: 0.9609867993197332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172413209302202d, y: 0.9299576590183372d)),
},
            new NpgsqlPathpath0M
{
    Id = 48,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03516227729369836d, y: 0.18194905310591447d), new NpgsqlTypes.NpgsqlPoint(x: 0.007474545158272172d, y: 0.01680248686444219d), new NpgsqlTypes.NpgsqlPoint(x: 0.29063840678998265d, y: 0.34036647249184104d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703938324931825d, y: 0.9205635017199921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2155664583594442d, y: 0.9314241543641066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966610123604352d, y: 0.01628411175070843d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 29,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010282007557104733d, y: 0.23513422863124867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151175655308231d, y: 0.47541558458138833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4280903431515034d, y: 0.8269901835428632d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2802132554986162d, y: 0.43020870128022126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457858377907623d, y: 0.3126707428314093d), new NpgsqlTypes.NpgsqlPoint(x: 0.43724598058492903d, y: 0.8839147224040789d)),
},
            new NpgsqlPathpath0M
{
    Id = 57,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984290092339268d, y: 0.7972046206651442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983543805584558d, y: 0.7647964747079927d), new NpgsqlTypes.NpgsqlPoint(x: 0.03429232051461362d, y: 0.7132054127998506d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 66,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2995198232933569d, y: 0.37852119006761065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828954353040199d, y: 0.6886924546569362d), new NpgsqlTypes.NpgsqlPoint(x: 0.08034540371518062d, y: 0.2770606179966226d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 37,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722960642179824d, y: 0.1686331584673998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664585072065633d, y: 0.04261291928118638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594616592599726d, y: 0.719799309998959d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7867682486972136d, y: 0.060631422011750535d), new NpgsqlTypes.NpgsqlPoint(x: 0.14211751276206364d, y: 0.842120805500853d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101682585593067d, y: 0.5096645002152559d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1740580697827856d, y: 0.7777378628680315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750146660918319d, y: 0.79945247561607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302779717254692d, y: 0.5524974272823255d)),
},
            new NpgsqlPathpath0M
{
    Id = 67,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028139238255005306d, y: 0.7304558331138609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779277512425606d, y: 0.08627417225677658d), new NpgsqlTypes.NpgsqlPoint(x: 0.719075901207238d, y: 0.9001931091908381d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 73,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09861069563304514d, y: 0.926643110851252d), new NpgsqlTypes.NpgsqlPoint(x: 0.81705611250255d, y: 0.18049760141534454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665132041109588d, y: 0.6665507827280642d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 42,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723408915367896d, y: 0.37797930107187516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082693346138074d, y: 0.06862616459680282d), new NpgsqlTypes.NpgsqlPoint(x: 0.12060501057739692d, y: 0.2041259001508562d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6079524946345273d, y: 0.11848982532285135d), new NpgsqlTypes.NpgsqlPoint(x: 0.0940577746467951d, y: 0.4488619091608229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22930921937124016d, y: 0.45934251422257966d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 82,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4346321008833087d, y: 0.5742897367045124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089398306437933d, y: 0.32595191154229175d), new NpgsqlTypes.NpgsqlPoint(x: 0.24946531584397535d, y: 0.5939976780547358d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 86,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8779051381951705d, y: 0.9027953988289968d), new NpgsqlTypes.NpgsqlPoint(x: 0.242689987256982d, y: 0.3582062443377628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404388405597184d, y: 0.46367638892695495d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 46,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8090879643147233d, y: 0.7406612063875315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8150610999443039d, y: 0.31651772548429247d), new NpgsqlTypes.NpgsqlPoint(x: 0.45606925063752835d, y: 0.6323935202505808d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.646395943083926d, y: 0.6081779526928225d), new NpgsqlTypes.NpgsqlPoint(x: 0.23565563446337034d, y: 0.9720166236165836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426959536193279d, y: 0.20167754526116577d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 94,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11414064449660954d, y: 0.9253451051836389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844010440827318d, y: 0.7275034158400411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5762684836903034d, y: 0.19839111852527724d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029501481943425d, y: 0.7415008429600072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253811043772456d, y: 0.18763550775209636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670163452790584d, y: 0.20003628704916d)),
},
            new NpgsqlPathpath0M
{
    Id = 100,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9880408991923262d, y: 0.062127201596095416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689179909790776d, y: 0.343252279401114d), new NpgsqlTypes.NpgsqlPoint(x: 0.41532875271518344d, y: 0.7889968833162772d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 55,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06728783219055878d, y: 0.9136917537191839d), new NpgsqlTypes.NpgsqlPoint(x: 0.18563776721195646d, y: 0.8535261412441429d), new NpgsqlTypes.NpgsqlPoint(x: 0.27884798808238265d, y: 0.34236867934565995d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210932337603007d, y: 0.8960253725156395d), new NpgsqlTypes.NpgsqlPoint(x: 0.27068102703605945d, y: 0.887315968318277d), new NpgsqlTypes.NpgsqlPoint(x: 0.4127681198137332d, y: 0.8593194357432524d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7213297332304242d, y: 0.9163952687847824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944583615702685d, y: 0.5774742305161411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688535284146399d, y: 0.8563168163734072d)),
},
            new NpgsqlPathpath0M
{
    Id = 105,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926550274577828d, y: 0.07871444047573106d), new NpgsqlTypes.NpgsqlPoint(x: 0.1508191856785952d, y: 0.9869401203526579d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226958061990163d, y: 0.6032296851797343d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17188592984994522d, y: 0.008267844328672114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974662372348756d, y: 0.3030651709719592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520235543970688d, y: 0.5203025800849637d)),
},
            new NpgsqlPathpath0M
{
    Id = 111,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7131364543158615d, y: 0.015913930953801003d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042162473484045d, y: 0.753647317771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815728618743461d, y: 0.1156953890170005d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 61,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39161751590776384d, y: 0.3458427640834033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939784080463104d, y: 0.7228176186409029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701849411234659d, y: 0.6238428959989903d)),
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 116,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31845190768704457d, y: 0.6591364150166965d), new NpgsqlTypes.NpgsqlPoint(x: 0.39993927752420055d, y: 0.549571199300039d), new NpgsqlTypes.NpgsqlPoint(x: 0.594859579676255d, y: 0.05330139227263775d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 117,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952762396443116d, y: 0.40455509874814244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917025209438345d, y: 0.3246328088200926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317850849913896d, y: 0.34083170803097607d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 68,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6054461657352848d, y: 0.7984205940789963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686804439776691d, y: 0.48086716410603936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434177394142178d, y: 0.801114249652069d)),
    NullableValue = null,
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754855352635207d, y: 0.8714146718035399d), new NpgsqlTypes.NpgsqlPoint(x: 0.012052215104391917d, y: 0.8509825104835889d), new NpgsqlTypes.NpgsqlPoint(x: 0.671528854824768d, y: 0.2960947809551142d)),
},
            new NpgsqlPathpath0M
{
    Id = 120,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10684241640151437d, y: 0.8354075587982448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769260236167366d, y: 0.308466803954318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05223912432493427d, y: 0.18926144256351596d)),
    ModelInner = null,
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618515774904812d, y: 0.6427156550252051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602785213669041d, y: 0.3358000724295498d), new NpgsqlTypes.NpgsqlPoint(x: 0.15275751045200225d, y: 0.8132609651245587d)),
},
            new NpgsqlPathpath0M
{
    Id = 121,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8299780067442987d, y: 0.038026794901783734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029443368037928d, y: 0.10807724759047466d), new NpgsqlTypes.NpgsqlPoint(x: 0.18215894113670006d, y: 0.9295732620179972d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 76,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4196274470656073d, y: 0.2688344662384464d), new NpgsqlTypes.NpgsqlPoint(x: 0.43503895400553017d, y: 0.8182363105997409d), new NpgsqlTypes.NpgsqlPoint(x: 0.16306147742140664d, y: 0.8672665143710804d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5539140443794243d, y: 0.5089076004571675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319878060863325d, y: 0.1439513208531632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230876456794517d, y: 0.8551589003462559d)),
},
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5928428151462136d, y: 0.143712319289644d), new NpgsqlTypes.NpgsqlPoint(x: 0.35374972846208563d, y: 0.15377817660930793d), new NpgsqlTypes.NpgsqlPoint(x: 0.42787050224017154d, y: 0.7905256015891807d)),
},
            new NpgsqlPathpath0M
{
    Id = 128,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.459841039868783d, y: 0.43465889677391556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742632462645036d, y: 0.5937513274141613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2572135844021183d, y: 0.8453131827575918d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 131,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16773370293750522d, y: 0.48203450630747047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870734346402569d, y: 0.2941133557909341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072813118544353d, y: 0.8937280279849329d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 79,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168704164339809d, y: 0.5664703853763325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557037544485046d, y: 0.967059482696494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067923626561591d, y: 0.4959852481831476d)),
    NullableValue = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7074935089568257d, y: 0.17042842405659042d), new NpgsqlTypes.NpgsqlPoint(x: 0.01131712124858042d, y: 0.49861465730000853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770087025989923d, y: 0.7107655206900781d)),
},
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 132,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6100517573990836d, y: 0.3908474811422321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744553571802866d, y: 0.06292647590584699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331046503345461d, y: 0.5689602623940927d)),
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpath0M
{
    Id = 141,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10541674509617105d, y: 0.9929963086301427d), new NpgsqlTypes.NpgsqlPoint(x: 0.2261228726621477d, y: 0.35397585661290343d), new NpgsqlTypes.NpgsqlPoint(x: 0.810761686262002d, y: 0.22837861810603532d)),
    ModelInner = new NpgsqlPathpath0MI
{
    Id = 83,
    Value = new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49598211223703204d, y: 0.40680544421993514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288458103979142d, y: 0.9625526460289237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535691145386921d, y: 0.3819133341466864d)),
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14))]
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathSingleTypepath)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0mi(
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "id", 
                methodParametrName: "id", 
                dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath), 
                parametrName: "value", 
                methodParametrName: "value", 
                dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModel(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertInnerModelAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathSingleTypepath)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathSingleTypepath)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7655404730870079d, y: 0.2842799054824314d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969457996896066d, y: 0.27760536211235776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264996755650999d, y: 0.16513896727235122d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlPath>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlPath>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(14);
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

                    nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
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
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(14)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpath0mi_id", 
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
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24979512028469342d, y: 0.02158177405927797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959654844528018d, y: 0.32601993773838944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865450703744082d, y: 0.5274608293470339d))));
                nullable =  ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641317285203961d, y: 0.9909881339318382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801420459047511d, y: 0.9609867993197332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172413209302202d, y: 0.9299576590183372d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlPath? nullable = null;
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((INpgsqlPathSingleTypepath)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2802132554986162d, y: 0.43020870128022126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457858377907623d, y: 0.3126707428314093d), new NpgsqlTypes.NpgsqlPoint(x: 0.43724598058492903d, y: 0.8839147224040789d))));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlPathSingleTypepath)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpath0M> models = null;

                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathSingleTypepath)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpath0M.AssertModel(models[0],_testData[19], true);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpath0m(
	id,
    value,
    nullablevalue,
    npgsqlpathpath0mi_id
)
VALUES (
    @id, 
    @value, 
    @nullablevalue,
    @npgsqlpathpath0mi_id
)
",
            methodName:"DbConnectionInsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)
            ), 
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(System.Int32), parametrName: "id", methodParametrName: "id", dbType: (System.Data.DbType)(11)),
            Gedaq.DbConnection.Attributes.Parametr(parametrType: typeof(NpgsqlTypes.NpgsqlPath), parametrName: "value", methodParametrName: "value", dbType: (System.Data.DbType)(13)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlPath?), 
                parametrName: "nullablevalue", 
                methodParametrName: "nullablevalue", 
                dbType: (System.Data.DbType)(13),
                nullable: true),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                parametrName: "npgsqlpathpath0mi_id", 
                methodParametrName: "npgsqlpathpath0mi_id", 
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

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModel(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
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

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathSingleTypepath)this).DbConnectionInsertModelAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathSingleTypepath)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await ((INpgsqlPathSingleTypepath)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathSingleTypepath)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 121;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 128;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 73;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));
NpgsqlPathpath0M.AssertModel(models[0],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));
NpgsqlPathpath0M.AssertModel(models[0],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 120;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 100;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));
NpgsqlPathpath0M.AssertModel(models[0],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));
NpgsqlPathpath0M.AssertModel(models[0],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M), typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                await((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpath0M>();
                var models2 = new List<FlatNpgsqlPathpath0M>();
                ((INpgsqlPathSingleTypepath)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 41, query1, 41, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpath0m m
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
FROM public.npgsqlpathpath0m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionDynQuerySelectModelBatch(connection, 26, query1, 5, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));
FlatNpgsqlPathpath0M.AssertModel(models[0],_testData[1], false);FlatNpgsqlPathpath0M.AssertModel(models[1],_testData[2], false);FlatNpgsqlPathpath0M.AssertModel(models[2],_testData[3], false);FlatNpgsqlPathpath0M.AssertModel(models[3],_testData[4], false);FlatNpgsqlPathpath0M.AssertModel(models[4],_testData[5], false);FlatNpgsqlPathpath0M.AssertModel(models[5],_testData[6], false);FlatNpgsqlPathpath0M.AssertModel(models[6],_testData[7], false);FlatNpgsqlPathpath0M.AssertModel(models[7],_testData[8], false);FlatNpgsqlPathpath0M.AssertModel(models[8],_testData[9], false);FlatNpgsqlPathpath0M.AssertModel(models[9],_testData[10], false);FlatNpgsqlPathpath0M.AssertModel(models[10],_testData[11], false);FlatNpgsqlPathpath0M.AssertModel(models[11],_testData[12], false);FlatNpgsqlPathpath0M.AssertModel(models[12],_testData[13], false);FlatNpgsqlPathpath0M.AssertModel(models[13],_testData[14], false);FlatNpgsqlPathpath0M.AssertModel(models[14],_testData[15], false);FlatNpgsqlPathpath0M.AssertModel(models[15],_testData[16], false);FlatNpgsqlPathpath0M.AssertModel(models[16],_testData[17], false);FlatNpgsqlPathpath0M.AssertModel(models[17],_testData[18], false);FlatNpgsqlPathpath0M.AssertModel(models[18],_testData[19], false);FlatNpgsqlPathpath0M.AssertModel(models[19],_testData[20], false);FlatNpgsqlPathpath0M.AssertModel(models[20],_testData[21], false);FlatNpgsqlPathpath0M.AssertModel(models[21],_testData[22], false);FlatNpgsqlPathpath0M.AssertModel(models[22],_testData[23], false);FlatNpgsqlPathpath0M.AssertModel(models[23],_testData[24], false);FlatNpgsqlPathpath0M.AssertModel(models[24],_testData[25], false);FlatNpgsqlPathpath0M.AssertModel(models[25],_testData[26], false);FlatNpgsqlPathpath0M.AssertModel(models[26],_testData[27], false);FlatNpgsqlPathpath0M.AssertModel(models[27],_testData[28], false);FlatNpgsqlPathpath0M.AssertModel(models[28],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath)),
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
                var models = await((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatchAsync(connection, 48, 55))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));
NpgsqlPathpath0M.AssertModel(models[0],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));
NpgsqlPathpath0M.AssertModel(models[0],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[29], false);
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
                var models = ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlPathpath0M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelBatch(connection, 22, 128))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));
NpgsqlPathpath0M.AssertModel(models[0],_testData[4], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[5], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[6], false);NpgsqlPathpath0M.AssertModel(models[3],_testData[7], false);NpgsqlPathpath0M.AssertModel(models[4],_testData[8], false);NpgsqlPathpath0M.AssertModel(models[5],_testData[9], false);NpgsqlPathpath0M.AssertModel(models[6],_testData[10], false);NpgsqlPathpath0M.AssertModel(models[7],_testData[11], false);NpgsqlPathpath0M.AssertModel(models[8],_testData[12], false);NpgsqlPathpath0M.AssertModel(models[9],_testData[13], false);NpgsqlPathpath0M.AssertModel(models[10],_testData[14], false);NpgsqlPathpath0M.AssertModel(models[11],_testData[15], false);NpgsqlPathpath0M.AssertModel(models[12],_testData[16], false);NpgsqlPathpath0M.AssertModel(models[13],_testData[17], false);NpgsqlPathpath0M.AssertModel(models[14],_testData[18], false);NpgsqlPathpath0M.AssertModel(models[15],_testData[19], false);NpgsqlPathpath0M.AssertModel(models[16],_testData[20], false);NpgsqlPathpath0M.AssertModel(models[17],_testData[21], false);NpgsqlPathpath0M.AssertModel(models[18],_testData[22], false);NpgsqlPathpath0M.AssertModel(models[19],_testData[23], false);NpgsqlPathpath0M.AssertModel(models[20],_testData[24], false);NpgsqlPathpath0M.AssertModel(models[21],_testData[25], false);NpgsqlPathpath0M.AssertModel(models[22],_testData[26], false);NpgsqlPathpath0M.AssertModel(models[23],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[24],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
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
                await using var cmd = await ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 131);
                var models = await ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(2));
NpgsqlPathpath0M.AssertModel(models[0],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathSingleTypepath)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathSingleTypepath)this).SetDbConnectionSelectModelParametrs(cmd, 128);
                var models =  ((INpgsqlPathSingleTypepath)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(3));
NpgsqlPathpath0M.AssertModel(models[0],_testData[27], false);NpgsqlPathpath0M.AssertModel(models[1],_testData[28], false);NpgsqlPathpath0M.AssertModel(models[2],_testData[29], false);
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
FROM public.npgsqlpathpath0m m
LEFT JOIN public.npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
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
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void DbConnectionSelectModelToObjArrConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelToObjArrTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArrAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3292856400020443d, y: 0.7834266956029355d), new NpgsqlTypes.NpgsqlPoint(x: 0.39751827918086524d, y: 0.26662455162665655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564196477448137d, y: 0.8364134018700511d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43012782390254023d, y: 0.11663862073560194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469466230977724d, y: 0.9147467027044733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556360076288688d, y: 0.8499879961218593d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7825394675633618d, y: 0.722276853899619d), new NpgsqlTypes.NpgsqlPoint(x: 0.26121370733138505d, y: 0.07258015997058065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4801593317757946d, y: 0.9437755039599571d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517478664536917d, y: 0.10446579799349653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150090092162484d, y: 0.977431532059657d), new NpgsqlTypes.NpgsqlPoint(x: 0.943755420967301d, y: 0.3058808653157784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0970814073230486d, y: 0.8240621527320565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699515066016043d, y: 0.5922265625801978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4976948715329512d, y: 0.7125985467528595d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1840434649260244d, y: 0.760626416733506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571406007333563d, y: 0.3397837778019699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349998029914724d, y: 0.43397882057520276d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02456463977520218d, y: 0.19665661839067683d), new NpgsqlTypes.NpgsqlPoint(x: 0.40222938365550287d, y: 0.3189722963125796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823563598767766d, y: 0.4043552334832662d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4447868442925701d, y: 0.8873528099797044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287987666241971d, y: 0.8214714860707643d), new NpgsqlTypes.NpgsqlPoint(x: 0.32809479145963427d, y: 0.9160806948771297d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057783353342745536d, y: 0.12443531964324839d), new NpgsqlTypes.NpgsqlPoint(x: 0.248065805916863d, y: 0.3356463374578891d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580624740225015d, y: 0.397868708128541d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9280628691777285d, y: 0.5089909524512031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420480581951024d, y: 0.18558275177265704d), new NpgsqlTypes.NpgsqlPoint(x: 0.27148160971407986d, y: 0.6254791499056457d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06135378819497517d, y: 0.7688448030361005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728072410643656d, y: 0.5022608610543933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888110468445535d, y: 0.10643746290432343d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783639039340874d, y: 0.9640264091356728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368906312988153d, y: 0.5490476692515089d), new NpgsqlTypes.NpgsqlPoint(x: 0.752198538504357d, y: 0.8390496547803169d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753185912322491d, y: 0.8214928820297882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986381122100313d, y: 0.10174079613177733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352318554981762d, y: 0.6239829138553686d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9161618657467284d, y: 0.733947479570986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135255617842346d, y: 0.5224247923436788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733186728078489d, y: 0.24247113272491239d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7655404730870079d, y: 0.2842799054824314d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969457996896066d, y: 0.27760536211235776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264996755650999d, y: 0.16513896727235122d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6380301140090119d, y: 0.5522644889948162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417243548568196d, y: 0.2886922357193079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14201377042487784d, y: 0.2062731802714124d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7007660060949499d, y: 0.13696950704621014d), new NpgsqlTypes.NpgsqlPoint(x: 0.35932373075111657d, y: 0.4485070388113874d), new NpgsqlTypes.NpgsqlPoint(x: 0.02989321645328169d, y: 0.7383303475207379d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8266783492150472d, y: 0.030216892654414407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274856984751379d, y: 0.6747111332437898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3812195119309725d, y: 0.9309274422194211d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.922889016592517d, y: 0.720605801759105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938050672025005d, y: 0.06533813426021462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804756683270009d, y: 0.9713057135734395d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003841836884311056d, y: 0.9927819233005057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592130172960172d, y: 0.7029948861773745d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697306770160859d, y: 0.16622397256185595d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24979512028469342d, y: 0.02158177405927797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959654844528018d, y: 0.32601993773838944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865450703744082d, y: 0.5274608293470339d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018116653191622478d, y: 0.633501068748992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472217695826058d, y: 0.9972545948358646d), new NpgsqlTypes.NpgsqlPoint(x: 0.13145122598392556d, y: 0.5303152908755342d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20516465590008293d, y: 0.27830355955144126d), new NpgsqlTypes.NpgsqlPoint(x: 0.27011013861944977d, y: 0.8429434794321093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863334099394816d, y: 0.7220852072580415d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641317285203961d, y: 0.9909881339318382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801420459047511d, y: 0.9609867993197332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172413209302202d, y: 0.9299576590183372d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03516227729369836d, y: 0.18194905310591447d), new NpgsqlTypes.NpgsqlPoint(x: 0.007474545158272172d, y: 0.01680248686444219d), new NpgsqlTypes.NpgsqlPoint(x: 0.29063840678998265d, y: 0.34036647249184104d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703938324931825d, y: 0.9205635017199921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2155664583594442d, y: 0.9314241543641066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966610123604352d, y: 0.01628411175070843d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010282007557104733d, y: 0.23513422863124867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151175655308231d, y: 0.47541558458138833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4280903431515034d, y: 0.8269901835428632d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2802132554986162d, y: 0.43020870128022126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457858377907623d, y: 0.3126707428314093d), new NpgsqlTypes.NpgsqlPoint(x: 0.43724598058492903d, y: 0.8839147224040789d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984290092339268d, y: 0.7972046206651442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983543805584558d, y: 0.7647964747079927d), new NpgsqlTypes.NpgsqlPoint(x: 0.03429232051461362d, y: 0.7132054127998506d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2995198232933569d, y: 0.37852119006761065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828954353040199d, y: 0.6886924546569362d), new NpgsqlTypes.NpgsqlPoint(x: 0.08034540371518062d, y: 0.2770606179966226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722960642179824d, y: 0.1686331584673998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664585072065633d, y: 0.04261291928118638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594616592599726d, y: 0.719799309998959d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7867682486972136d, y: 0.060631422011750535d), new NpgsqlTypes.NpgsqlPoint(x: 0.14211751276206364d, y: 0.842120805500853d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101682585593067d, y: 0.5096645002152559d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1740580697827856d, y: 0.7777378628680315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750146660918319d, y: 0.79945247561607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302779717254692d, y: 0.5524974272823255d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028139238255005306d, y: 0.7304558331138609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779277512425606d, y: 0.08627417225677658d), new NpgsqlTypes.NpgsqlPoint(x: 0.719075901207238d, y: 0.9001931091908381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09861069563304514d, y: 0.926643110851252d), new NpgsqlTypes.NpgsqlPoint(x: 0.81705611250255d, y: 0.18049760141534454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665132041109588d, y: 0.6665507827280642d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723408915367896d, y: 0.37797930107187516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082693346138074d, y: 0.06862616459680282d), new NpgsqlTypes.NpgsqlPoint(x: 0.12060501057739692d, y: 0.2041259001508562d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6079524946345273d, y: 0.11848982532285135d), new NpgsqlTypes.NpgsqlPoint(x: 0.0940577746467951d, y: 0.4488619091608229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22930921937124016d, y: 0.45934251422257966d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4346321008833087d, y: 0.5742897367045124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089398306437933d, y: 0.32595191154229175d), new NpgsqlTypes.NpgsqlPoint(x: 0.24946531584397535d, y: 0.5939976780547358d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8779051381951705d, y: 0.9027953988289968d), new NpgsqlTypes.NpgsqlPoint(x: 0.242689987256982d, y: 0.3582062443377628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404388405597184d, y: 0.46367638892695495d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8090879643147233d, y: 0.7406612063875315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8150610999443039d, y: 0.31651772548429247d), new NpgsqlTypes.NpgsqlPoint(x: 0.45606925063752835d, y: 0.6323935202505808d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.646395943083926d, y: 0.6081779526928225d), new NpgsqlTypes.NpgsqlPoint(x: 0.23565563446337034d, y: 0.9720166236165836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426959536193279d, y: 0.20167754526116577d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11414064449660954d, y: 0.9253451051836389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844010440827318d, y: 0.7275034158400411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5762684836903034d, y: 0.19839111852527724d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029501481943425d, y: 0.7415008429600072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253811043772456d, y: 0.18763550775209636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670163452790584d, y: 0.20003628704916d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9880408991923262d, y: 0.062127201596095416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689179909790776d, y: 0.343252279401114d), new NpgsqlTypes.NpgsqlPoint(x: 0.41532875271518344d, y: 0.7889968833162772d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06728783219055878d, y: 0.9136917537191839d), new NpgsqlTypes.NpgsqlPoint(x: 0.18563776721195646d, y: 0.8535261412441429d), new NpgsqlTypes.NpgsqlPoint(x: 0.27884798808238265d, y: 0.34236867934565995d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210932337603007d, y: 0.8960253725156395d), new NpgsqlTypes.NpgsqlPoint(x: 0.27068102703605945d, y: 0.887315968318277d), new NpgsqlTypes.NpgsqlPoint(x: 0.4127681198137332d, y: 0.8593194357432524d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7213297332304242d, y: 0.9163952687847824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944583615702685d, y: 0.5774742305161411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688535284146399d, y: 0.8563168163734072d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926550274577828d, y: 0.07871444047573106d), new NpgsqlTypes.NpgsqlPoint(x: 0.1508191856785952d, y: 0.9869401203526579d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226958061990163d, y: 0.6032296851797343d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17188592984994522d, y: 0.008267844328672114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974662372348756d, y: 0.3030651709719592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520235543970688d, y: 0.5203025800849637d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7131364543158615d, y: 0.015913930953801003d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042162473484045d, y: 0.753647317771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815728618743461d, y: 0.1156953890170005d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39161751590776384d, y: 0.3458427640834033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939784080463104d, y: 0.7228176186409029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701849411234659d, y: 0.6238428959989903d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31845190768704457d, y: 0.6591364150166965d), new NpgsqlTypes.NpgsqlPoint(x: 0.39993927752420055d, y: 0.549571199300039d), new NpgsqlTypes.NpgsqlPoint(x: 0.594859579676255d, y: 0.05330139227263775d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952762396443116d, y: 0.40455509874814244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917025209438345d, y: 0.3246328088200926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317850849913896d, y: 0.34083170803097607d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6054461657352848d, y: 0.7984205940789963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686804439776691d, y: 0.48086716410603936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434177394142178d, y: 0.801114249652069d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754855352635207d, y: 0.8714146718035399d), new NpgsqlTypes.NpgsqlPoint(x: 0.012052215104391917d, y: 0.8509825104835889d), new NpgsqlTypes.NpgsqlPoint(x: 0.671528854824768d, y: 0.2960947809551142d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10684241640151437d, y: 0.8354075587982448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769260236167366d, y: 0.308466803954318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05223912432493427d, y: 0.18926144256351596d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618515774904812d, y: 0.6427156550252051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602785213669041d, y: 0.3358000724295498d), new NpgsqlTypes.NpgsqlPoint(x: 0.15275751045200225d, y: 0.8132609651245587d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8299780067442987d, y: 0.038026794901783734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029443368037928d, y: 0.10807724759047466d), new NpgsqlTypes.NpgsqlPoint(x: 0.18215894113670006d, y: 0.9295732620179972d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4196274470656073d, y: 0.2688344662384464d), new NpgsqlTypes.NpgsqlPoint(x: 0.43503895400553017d, y: 0.8182363105997409d), new NpgsqlTypes.NpgsqlPoint(x: 0.16306147742140664d, y: 0.8672665143710804d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5539140443794243d, y: 0.5089076004571675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319878060863325d, y: 0.1439513208531632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230876456794517d, y: 0.8551589003462559d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5928428151462136d, y: 0.143712319289644d), new NpgsqlTypes.NpgsqlPoint(x: 0.35374972846208563d, y: 0.15377817660930793d), new NpgsqlTypes.NpgsqlPoint(x: 0.42787050224017154d, y: 0.7905256015891807d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.459841039868783d, y: 0.43465889677391556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742632462645036d, y: 0.5937513274141613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2572135844021183d, y: 0.8453131827575918d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16773370293750522d, y: 0.48203450630747047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870734346402569d, y: 0.2941133557909341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072813118544353d, y: 0.8937280279849329d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168704164339809d, y: 0.5664703853763325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557037544485046d, y: 0.967059482696494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067923626561591d, y: 0.4959852481831476d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7074935089568257d, y: 0.17042842405659042d), new NpgsqlTypes.NpgsqlPoint(x: 0.01131712124858042d, y: 0.49861465730000853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770087025989923d, y: 0.7107655206900781d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6100517573990836d, y: 0.3908474811422321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744553571802866d, y: 0.06292647590584699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331046503345461d, y: 0.5689602623940927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10541674509617105d, y: 0.9929963086301427d), new NpgsqlTypes.NpgsqlPoint(x: 0.2261228726621477d, y: 0.35397585661290343d), new NpgsqlTypes.NpgsqlPoint(x: 0.810761686262002d, y: 0.22837861810603532d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49598211223703204d, y: 0.40680544421993514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288458103979142d, y: 0.9625526460289237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535691145386921d, y: 0.3819133341466864d)))));//InnerModel.Value

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
                var models =  ((INpgsqlPathSingleTypepath)this).DbConnectionSelectModelToObjArr(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((5)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3292856400020443d, y: 0.7834266956029355d), new NpgsqlTypes.NpgsqlPoint(x: 0.39751827918086524d, y: 0.26662455162665655d), new NpgsqlTypes.NpgsqlPoint(x: 0.6564196477448137d, y: 0.8364134018700511d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43012782390254023d, y: 0.11663862073560194d), new NpgsqlTypes.NpgsqlPoint(x: 0.5469466230977724d, y: 0.9147467027044733d), new NpgsqlTypes.NpgsqlPoint(x: 0.3556360076288688d, y: 0.8499879961218593d)))));

                model = models[1];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((13)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7825394675633618d, y: 0.722276853899619d), new NpgsqlTypes.NpgsqlPoint(x: 0.26121370733138505d, y: 0.07258015997058065d), new NpgsqlTypes.NpgsqlPoint(x: 0.4801593317757946d, y: 0.9437755039599571d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((7)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7517478664536917d, y: 0.10446579799349653d), new NpgsqlTypes.NpgsqlPoint(x: 0.5150090092162484d, y: 0.977431532059657d), new NpgsqlTypes.NpgsqlPoint(x: 0.943755420967301d, y: 0.3058808653157784d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0970814073230486d, y: 0.8240621527320565d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699515066016043d, y: 0.5922265625801978d), new NpgsqlTypes.NpgsqlPoint(x: 0.4976948715329512d, y: 0.7125985467528595d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1840434649260244d, y: 0.760626416733506d), new NpgsqlTypes.NpgsqlPoint(x: 0.8571406007333563d, y: 0.3397837778019699d), new NpgsqlTypes.NpgsqlPoint(x: 0.5349998029914724d, y: 0.43397882057520276d)))));

                model = models[2];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((15)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.02456463977520218d, y: 0.19665661839067683d), new NpgsqlTypes.NpgsqlPoint(x: 0.40222938365550287d, y: 0.3189722963125796d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823563598767766d, y: 0.4043552334832662d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[3];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((22)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4447868442925701d, y: 0.8873528099797044d), new NpgsqlTypes.NpgsqlPoint(x: 0.5287987666241971d, y: 0.8214714860707643d), new NpgsqlTypes.NpgsqlPoint(x: 0.32809479145963427d, y: 0.9160806948771297d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((12)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.057783353342745536d, y: 0.12443531964324839d), new NpgsqlTypes.NpgsqlPoint(x: 0.248065805916863d, y: 0.3356463374578891d), new NpgsqlTypes.NpgsqlPoint(x: 0.2580624740225015d, y: 0.397868708128541d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9280628691777285d, y: 0.5089909524512031d), new NpgsqlTypes.NpgsqlPoint(x: 0.5420480581951024d, y: 0.18558275177265704d), new NpgsqlTypes.NpgsqlPoint(x: 0.27148160971407986d, y: 0.6254791499056457d)))));

                model = models[4];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((24)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06135378819497517d, y: 0.7688448030361005d), new NpgsqlTypes.NpgsqlPoint(x: 0.5728072410643656d, y: 0.5022608610543933d), new NpgsqlTypes.NpgsqlPoint(x: 0.9888110468445535d, y: 0.10643746290432343d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[5];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((26)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.783639039340874d, y: 0.9640264091356728d), new NpgsqlTypes.NpgsqlPoint(x: 0.7368906312988153d, y: 0.5490476692515089d), new NpgsqlTypes.NpgsqlPoint(x: 0.752198538504357d, y: 0.8390496547803169d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((18)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9753185912322491d, y: 0.8214928820297882d), new NpgsqlTypes.NpgsqlPoint(x: 0.4986381122100313d, y: 0.10174079613177733d), new NpgsqlTypes.NpgsqlPoint(x: 0.4352318554981762d, y: 0.6239829138553686d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9161618657467284d, y: 0.733947479570986d), new NpgsqlTypes.NpgsqlPoint(x: 0.9135255617842346d, y: 0.5224247923436788d), new NpgsqlTypes.NpgsqlPoint(x: 0.7733186728078489d, y: 0.24247113272491239d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7655404730870079d, y: 0.2842799054824314d), new NpgsqlTypes.NpgsqlPoint(x: 0.05969457996896066d, y: 0.27760536211235776d), new NpgsqlTypes.NpgsqlPoint(x: 0.9264996755650999d, y: 0.16513896727235122d)))));

                model = models[6];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((28)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6380301140090119d, y: 0.5522644889948162d), new NpgsqlTypes.NpgsqlPoint(x: 0.7417243548568196d, y: 0.2886922357193079d), new NpgsqlTypes.NpgsqlPoint(x: 0.14201377042487784d, y: 0.2062731802714124d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[7];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((33)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7007660060949499d, y: 0.13696950704621014d), new NpgsqlTypes.NpgsqlPoint(x: 0.35932373075111657d, y: 0.4485070388113874d), new NpgsqlTypes.NpgsqlPoint(x: 0.02989321645328169d, y: 0.7383303475207379d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((22)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8266783492150472d, y: 0.030216892654414407d), new NpgsqlTypes.NpgsqlPoint(x: 0.6274856984751379d, y: 0.6747111332437898d), new NpgsqlTypes.NpgsqlPoint(x: 0.3812195119309725d, y: 0.9309274422194211d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.922889016592517d, y: 0.720605801759105d), new NpgsqlTypes.NpgsqlPoint(x: 0.6938050672025005d, y: 0.06533813426021462d), new NpgsqlTypes.NpgsqlPoint(x: 0.6804756683270009d, y: 0.9713057135734395d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[8];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((40)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.003841836884311056d, y: 0.9927819233005057d), new NpgsqlTypes.NpgsqlPoint(x: 0.5592130172960172d, y: 0.7029948861773745d), new NpgsqlTypes.NpgsqlPoint(x: 0.1697306770160859d, y: 0.16622397256185595d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24979512028469342d, y: 0.02158177405927797d), new NpgsqlTypes.NpgsqlPoint(x: 0.9959654844528018d, y: 0.32601993773838944d), new NpgsqlTypes.NpgsqlPoint(x: 0.6865450703744082d, y: 0.5274608293470339d)))));

                model = models[9];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((41)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.018116653191622478d, y: 0.633501068748992d), new NpgsqlTypes.NpgsqlPoint(x: 0.6472217695826058d, y: 0.9972545948358646d), new NpgsqlTypes.NpgsqlPoint(x: 0.13145122598392556d, y: 0.5303152908755342d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((25)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20516465590008293d, y: 0.27830355955144126d), new NpgsqlTypes.NpgsqlPoint(x: 0.27011013861944977d, y: 0.8429434794321093d), new NpgsqlTypes.NpgsqlPoint(x: 0.4863334099394816d, y: 0.7220852072580415d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8641317285203961d, y: 0.9909881339318382d), new NpgsqlTypes.NpgsqlPoint(x: 0.9801420459047511d, y: 0.9609867993197332d), new NpgsqlTypes.NpgsqlPoint(x: 0.7172413209302202d, y: 0.9299576590183372d)))));

                model = models[10];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((48)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03516227729369836d, y: 0.18194905310591447d), new NpgsqlTypes.NpgsqlPoint(x: 0.007474545158272172d, y: 0.01680248686444219d), new NpgsqlTypes.NpgsqlPoint(x: 0.29063840678998265d, y: 0.34036647249184104d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[11];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((55)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.703938324931825d, y: 0.9205635017199921d), new NpgsqlTypes.NpgsqlPoint(x: 0.2155664583594442d, y: 0.9314241543641066d), new NpgsqlTypes.NpgsqlPoint(x: 0.2966610123604352d, y: 0.01628411175070843d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((29)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.010282007557104733d, y: 0.23513422863124867d), new NpgsqlTypes.NpgsqlPoint(x: 0.7151175655308231d, y: 0.47541558458138833d), new NpgsqlTypes.NpgsqlPoint(x: 0.4280903431515034d, y: 0.8269901835428632d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2802132554986162d, y: 0.43020870128022126d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457858377907623d, y: 0.3126707428314093d), new NpgsqlTypes.NpgsqlPoint(x: 0.43724598058492903d, y: 0.8839147224040789d)))));

                model = models[12];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((57)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5984290092339268d, y: 0.7972046206651442d), new NpgsqlTypes.NpgsqlPoint(x: 0.8983543805584558d, y: 0.7647964747079927d), new NpgsqlTypes.NpgsqlPoint(x: 0.03429232051461362d, y: 0.7132054127998506d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[13];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((66)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2995198232933569d, y: 0.37852119006761065d), new NpgsqlTypes.NpgsqlPoint(x: 0.6828954353040199d, y: 0.6886924546569362d), new NpgsqlTypes.NpgsqlPoint(x: 0.08034540371518062d, y: 0.2770606179966226d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((37)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9722960642179824d, y: 0.1686331584673998d), new NpgsqlTypes.NpgsqlPoint(x: 0.6664585072065633d, y: 0.04261291928118638d), new NpgsqlTypes.NpgsqlPoint(x: 0.7594616592599726d, y: 0.719799309998959d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7867682486972136d, y: 0.060631422011750535d), new NpgsqlTypes.NpgsqlPoint(x: 0.14211751276206364d, y: 0.842120805500853d), new NpgsqlTypes.NpgsqlPoint(x: 0.4101682585593067d, y: 0.5096645002152559d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1740580697827856d, y: 0.7777378628680315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8750146660918319d, y: 0.79945247561607d), new NpgsqlTypes.NpgsqlPoint(x: 0.9302779717254692d, y: 0.5524974272823255d)))));

                model = models[14];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((67)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.028139238255005306d, y: 0.7304558331138609d), new NpgsqlTypes.NpgsqlPoint(x: 0.9779277512425606d, y: 0.08627417225677658d), new NpgsqlTypes.NpgsqlPoint(x: 0.719075901207238d, y: 0.9001931091908381d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[15];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((73)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09861069563304514d, y: 0.926643110851252d), new NpgsqlTypes.NpgsqlPoint(x: 0.81705611250255d, y: 0.18049760141534454d), new NpgsqlTypes.NpgsqlPoint(x: 0.6665132041109588d, y: 0.6665507827280642d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((42)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8723408915367896d, y: 0.37797930107187516d), new NpgsqlTypes.NpgsqlPoint(x: 0.6082693346138074d, y: 0.06862616459680282d), new NpgsqlTypes.NpgsqlPoint(x: 0.12060501057739692d, y: 0.2041259001508562d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6079524946345273d, y: 0.11848982532285135d), new NpgsqlTypes.NpgsqlPoint(x: 0.0940577746467951d, y: 0.4488619091608229d), new NpgsqlTypes.NpgsqlPoint(x: 0.22930921937124016d, y: 0.45934251422257966d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[16];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((82)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4346321008833087d, y: 0.5742897367045124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7089398306437933d, y: 0.32595191154229175d), new NpgsqlTypes.NpgsqlPoint(x: 0.24946531584397535d, y: 0.5939976780547358d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[17];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((86)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8779051381951705d, y: 0.9027953988289968d), new NpgsqlTypes.NpgsqlPoint(x: 0.242689987256982d, y: 0.3582062443377628d), new NpgsqlTypes.NpgsqlPoint(x: 0.7404388405597184d, y: 0.46367638892695495d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((46)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8090879643147233d, y: 0.7406612063875315d), new NpgsqlTypes.NpgsqlPoint(x: 0.8150610999443039d, y: 0.31651772548429247d), new NpgsqlTypes.NpgsqlPoint(x: 0.45606925063752835d, y: 0.6323935202505808d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.646395943083926d, y: 0.6081779526928225d), new NpgsqlTypes.NpgsqlPoint(x: 0.23565563446337034d, y: 0.9720166236165836d), new NpgsqlTypes.NpgsqlPoint(x: 0.4426959536193279d, y: 0.20167754526116577d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[18];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((94)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11414064449660954d, y: 0.9253451051836389d), new NpgsqlTypes.NpgsqlPoint(x: 0.9844010440827318d, y: 0.7275034158400411d), new NpgsqlTypes.NpgsqlPoint(x: 0.5762684836903034d, y: 0.19839111852527724d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6029501481943425d, y: 0.7415008429600072d), new NpgsqlTypes.NpgsqlPoint(x: 0.9253811043772456d, y: 0.18763550775209636d), new NpgsqlTypes.NpgsqlPoint(x: 0.2670163452790584d, y: 0.20003628704916d)))));

                model = models[19];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((100)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9880408991923262d, y: 0.062127201596095416d), new NpgsqlTypes.NpgsqlPoint(x: 0.6689179909790776d, y: 0.343252279401114d), new NpgsqlTypes.NpgsqlPoint(x: 0.41532875271518344d, y: 0.7889968833162772d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((55)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06728783219055878d, y: 0.9136917537191839d), new NpgsqlTypes.NpgsqlPoint(x: 0.18563776721195646d, y: 0.8535261412441429d), new NpgsqlTypes.NpgsqlPoint(x: 0.27884798808238265d, y: 0.34236867934565995d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5210932337603007d, y: 0.8960253725156395d), new NpgsqlTypes.NpgsqlPoint(x: 0.27068102703605945d, y: 0.887315968318277d), new NpgsqlTypes.NpgsqlPoint(x: 0.4127681198137332d, y: 0.8593194357432524d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7213297332304242d, y: 0.9163952687847824d), new NpgsqlTypes.NpgsqlPoint(x: 0.7944583615702685d, y: 0.5774742305161411d), new NpgsqlTypes.NpgsqlPoint(x: 0.3688535284146399d, y: 0.8563168163734072d)))));

                model = models[20];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((105)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.926550274577828d, y: 0.07871444047573106d), new NpgsqlTypes.NpgsqlPoint(x: 0.1508191856785952d, y: 0.9869401203526579d), new NpgsqlTypes.NpgsqlPoint(x: 0.3226958061990163d, y: 0.6032296851797343d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17188592984994522d, y: 0.008267844328672114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9974662372348756d, y: 0.3030651709719592d), new NpgsqlTypes.NpgsqlPoint(x: 0.6520235543970688d, y: 0.5203025800849637d)))));

                model = models[21];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((111)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7131364543158615d, y: 0.015913930953801003d), new NpgsqlTypes.NpgsqlPoint(x: 0.28042162473484045d, y: 0.753647317771842d), new NpgsqlTypes.NpgsqlPoint(x: 0.4815728618743461d, y: 0.1156953890170005d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((61)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39161751590776384d, y: 0.3458427640834033d), new NpgsqlTypes.NpgsqlPoint(x: 0.5939784080463104d, y: 0.7228176186409029d), new NpgsqlTypes.NpgsqlPoint(x: 0.9701849411234659d, y: 0.6238428959989903d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[22];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((116)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31845190768704457d, y: 0.6591364150166965d), new NpgsqlTypes.NpgsqlPoint(x: 0.39993927752420055d, y: 0.549571199300039d), new NpgsqlTypes.NpgsqlPoint(x: 0.594859579676255d, y: 0.05330139227263775d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[23];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((117)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9952762396443116d, y: 0.40455509874814244d), new NpgsqlTypes.NpgsqlPoint(x: 0.8917025209438345d, y: 0.3246328088200926d), new NpgsqlTypes.NpgsqlPoint(x: 0.8317850849913896d, y: 0.34083170803097607d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((68)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6054461657352848d, y: 0.7984205940789963d), new NpgsqlTypes.NpgsqlPoint(x: 0.7686804439776691d, y: 0.48086716410603936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5434177394142178d, y: 0.801114249652069d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9754855352635207d, y: 0.8714146718035399d), new NpgsqlTypes.NpgsqlPoint(x: 0.012052215104391917d, y: 0.8509825104835889d), new NpgsqlTypes.NpgsqlPoint(x: 0.671528854824768d, y: 0.2960947809551142d)))));

                model = models[24];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((120)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10684241640151437d, y: 0.8354075587982448d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769260236167366d, y: 0.308466803954318d), new NpgsqlTypes.NpgsqlPoint(x: 0.05223912432493427d, y: 0.18926144256351596d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618515774904812d, y: 0.6427156550252051d), new NpgsqlTypes.NpgsqlPoint(x: 0.8602785213669041d, y: 0.3358000724295498d), new NpgsqlTypes.NpgsqlPoint(x: 0.15275751045200225d, y: 0.8132609651245587d)))));

                model = models[25];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((121)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8299780067442987d, y: 0.038026794901783734d), new NpgsqlTypes.NpgsqlPoint(x: 0.9029443368037928d, y: 0.10807724759047466d), new NpgsqlTypes.NpgsqlPoint(x: 0.18215894113670006d, y: 0.9295732620179972d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((76)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4196274470656073d, y: 0.2688344662384464d), new NpgsqlTypes.NpgsqlPoint(x: 0.43503895400553017d, y: 0.8182363105997409d), new NpgsqlTypes.NpgsqlPoint(x: 0.16306147742140664d, y: 0.8672665143710804d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5539140443794243d, y: 0.5089076004571675d), new NpgsqlTypes.NpgsqlPoint(x: 0.8319878060863325d, y: 0.1439513208531632d), new NpgsqlTypes.NpgsqlPoint(x: 0.7230876456794517d, y: 0.8551589003462559d)))));//InnerModel.NullableValue

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[5], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5928428151462136d, y: 0.143712319289644d), new NpgsqlTypes.NpgsqlPoint(x: 0.35374972846208563d, y: 0.15377817660930793d), new NpgsqlTypes.NpgsqlPoint(x: 0.42787050224017154d, y: 0.7905256015891807d)))));

                model = models[26];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((128)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.459841039868783d, y: 0.43465889677391556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9742632462645036d, y: 0.5937513274141613d), new NpgsqlTypes.NpgsqlPoint(x: 0.2572135844021183d, y: 0.8453131827575918d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[27];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((131)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16773370293750522d, y: 0.48203450630747047d), new NpgsqlTypes.NpgsqlPoint(x: 0.7870734346402569d, y: 0.2941133557909341d), new NpgsqlTypes.NpgsqlPoint(x: 0.8072813118544353d, y: 0.8937280279849329d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((79)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7168704164339809d, y: 0.5664703853763325d), new NpgsqlTypes.NpgsqlPoint(x: 0.5557037544485046d, y: 0.967059482696494d), new NpgsqlTypes.NpgsqlPoint(x: 0.7067923626561591d, y: 0.4959852481831476d)))));//InnerModel.Value

                Assert.That((NpgsqlTypes.NpgsqlPath?)model[4], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7074935089568257d, y: 0.17042842405659042d), new NpgsqlTypes.NpgsqlPoint(x: 0.01131712124858042d, y: 0.49861465730000853d), new NpgsqlTypes.NpgsqlPoint(x: 0.5770087025989923d, y: 0.7107655206900781d)))));//InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[28];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((132)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6100517573990836d, y: 0.3908474811422321d), new NpgsqlTypes.NpgsqlPoint(x: 0.9744553571802866d, y: 0.06292647590584699d), new NpgsqlTypes.NpgsqlPoint(x: 0.8331046503345461d, y: 0.5689602623940927d)))));//Value

                Assert.That((DBNull)model[2], Is.EqualTo(DBNull.Value)); // InnerModel.Id
                Assert.That((DBNull)model[3], Is.EqualTo(DBNull.Value)); // InnerModel.Value
                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value)); // InnerModel.NullableValue

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

                model = models[29];

                Assert.That(model, Has.Length.EqualTo(6));

                Assert.That(model, Is.Not.Null);
                Assert.That((System.Int32)model[0], Is.EqualTo((141)));//Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[1], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.10541674509617105d, y: 0.9929963086301427d), new NpgsqlTypes.NpgsqlPoint(x: 0.2261228726621477d, y: 0.35397585661290343d), new NpgsqlTypes.NpgsqlPoint(x: 0.810761686262002d, y: 0.22837861810603532d)))));//Value

                Assert.That((System.Int32)model[2], Is.EqualTo((83)));//InnerModel.Id
                Assert.That((NpgsqlTypes.NpgsqlPath)model[3], Is.EqualTo((new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.49598211223703204d, y: 0.40680544421993514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8288458103979142d, y: 0.9625526460289237d), new NpgsqlTypes.NpgsqlPoint(x: 0.8535691145386921d, y: 0.3819133341466864d)))));//InnerModel.Value

                Assert.That((DBNull)model[4], Is.EqualTo(DBNull.Value));//InnerModel.Value

                Assert.That((DBNull)model[5], Is.EqualTo(DBNull.Value));//NullableValue

            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlPathSingleTypepath)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpath0mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
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
FROM public.binary_npgsqlpathpath0m m
LEFT JOIN public.binary_npgsqlpathpath0mi mi ON mi.id = m.npgsqlpathpath0mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlPathpath0M>(15);

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
                ((INpgsqlPathSingleTypepath)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathSingleTypepath)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlPathSingleTypepath)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlPathSingleTypepath)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlPathpath0M.AssertModel(models[0],_testData[0], false);
                NpgsqlPathpath0M.AssertModel(models[1],_testData[1], false);
                NpgsqlPathpath0M.AssertModel(models[2],_testData[2], false);
                NpgsqlPathpath0M.AssertModel(models[3],_testData[3], false);
                NpgsqlPathpath0M.AssertModel(models[4],_testData[4], false);
                NpgsqlPathpath0M.AssertModel(models[5],_testData[5], false);
                NpgsqlPathpath0M.AssertModel(models[6],_testData[6], false);
                NpgsqlPathpath0M.AssertModel(models[7],_testData[7], false);
                NpgsqlPathpath0M.AssertModel(models[8],_testData[8], false);
                NpgsqlPathpath0M.AssertModel(models[9],_testData[9], false);
                NpgsqlPathpath0M.AssertModel(models[10],_testData[10], false);
                NpgsqlPathpath0M.AssertModel(models[11],_testData[11], false);
                NpgsqlPathpath0M.AssertModel(models[12],_testData[12], false);
                NpgsqlPathpath0M.AssertModel(models[13],_testData[13], false);
                NpgsqlPathpath0M.AssertModel(models[14],_testData[14], false);
                NpgsqlPathpath0M.AssertModel(models[15],_testData[15], false);
                NpgsqlPathpath0M.AssertModel(models[16],_testData[16], false);
                NpgsqlPathpath0M.AssertModel(models[17],_testData[17], false);
                NpgsqlPathpath0M.AssertModel(models[18],_testData[18], false);
                NpgsqlPathpath0M.AssertModel(models[19],_testData[19], false);
                NpgsqlPathpath0M.AssertModel(models[20],_testData[20], false);
                NpgsqlPathpath0M.AssertModel(models[21],_testData[21], false);
                NpgsqlPathpath0M.AssertModel(models[22],_testData[22], false);
                NpgsqlPathpath0M.AssertModel(models[23],_testData[23], false);
                NpgsqlPathpath0M.AssertModel(models[24],_testData[24], false);
                NpgsqlPathpath0M.AssertModel(models[25],_testData[25], false);
                NpgsqlPathpath0M.AssertModel(models[26],_testData[26], false);
                NpgsqlPathpath0M.AssertModel(models[27],_testData[27], false);
                NpgsqlPathpath0M.AssertModel(models[28],_testData[28], false);
                NpgsqlPathpath0M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpath0mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpath0M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpath0M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpath0mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpath0MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(14),
                (NpgsqlTypes.NpgsqlDbType)(14)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathSingleTypepath))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlPathSingleTypepath)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathSingleTypepath)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpath0MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

