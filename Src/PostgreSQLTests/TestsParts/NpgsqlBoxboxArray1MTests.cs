

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
    internal partial interface INpgsqlBoxArrayboxArray
    {
    }
    
    internal partial class NpgsqlBoxArrayboxArray : INpgsqlBoxArrayboxArray
    {


#region TestData

        private readonly NpgsqlBoxboxArray1M[] _testData = new NpgsqlBoxboxArray1M[]
        {
            new NpgsqlBoxboxArray1M
{
    Id = 4,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.89291328925017d,right: 0.2751310893161686d,bottom: 0.369840167559524d,left: 0.08359428894654175d),
new NpgsqlTypes.NpgsqlBox(top: 0.49056529422759587d,right: 0.6130759450715138d,bottom: 0.17077535528349863d,left: 0.1482677493126736d),
new NpgsqlTypes.NpgsqlBox(top: 0.32937738795039806d,right: 0.2948327861258101d,bottom: 0.0055727041647744d,left: 0.2080435735172964d),
new NpgsqlTypes.NpgsqlBox(top: 0.9180747229844004d,right: 0.9454844652973545d,bottom: 0.8682677450967758d,left: 0.7399066682843094d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 10,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6203688090775215d,right: 0.9905780050403454d,bottom: 0.06143323300927772d,left: 0.06415436674144293d),
new NpgsqlTypes.NpgsqlBox(top: 0.7403318945700902d,right: 0.9859228324166929d,bottom: 0.5743918048271354d,left: 0.9197792826952403d),
new NpgsqlTypes.NpgsqlBox(top: 0.7139516701707135d,right: 0.8968305574996687d,bottom: 0.5930761054504528d,left: 0.5911197774986205d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 6,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9942679907378389d,right: 0.558527561917065d,bottom: 0.9658327948042434d,left: 0.23719272582451556d),
new NpgsqlTypes.NpgsqlBox(top: 0.49125336741593884d,right: 0.7790593658058222d,bottom: 0.19149201207902278d,left: 0.5767920722245545d),
new NpgsqlTypes.NpgsqlBox(top: 0.2958742904492039d,right: 0.871270495194668d,bottom: 0.23529676015084522d,left: 0.33374415483538145d),
new NpgsqlTypes.NpgsqlBox(top: 0.48729096239917724d,right: 0.9707966715954421d,bottom: 0.3067582681872594d,left: 0.06850248089591737d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8579481200517315d,right: 0.15028280117933412d,bottom: 0.8281496351797913d,left: 0.022436267487063066d),
new NpgsqlTypes.NpgsqlBox(top: 0.6501322793313091d,right: 0.7764932554200886d,bottom: 0.33132365177597634d,left: 0.6942157663297949d),
new NpgsqlTypes.NpgsqlBox(top: 0.3453589598678297d,right: 0.6622300940467615d,bottom: 0.30171116540027876d,left: 0.12048544244754988d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4886215568180319d,right: 0.18822715775260024d,bottom: 0.09892574766990903d,left: 0.08193609043007755d),
new NpgsqlTypes.NpgsqlBox(top: 0.5703016333893246d,right: 0.08508074100604257d,bottom: 0.28269829792561973d,left: 0.032043550513170094d),
new NpgsqlTypes.NpgsqlBox(top: 0.8183379773734971d,right: 0.5626944468660652d,bottom: 0.06815720566157646d,left: 0.37148131195370926d),
new NpgsqlTypes.NpgsqlBox(top: 0.9408688068483789d,right: 0.34003964561536437d,bottom: 0.8753240260830895d,left: 0.17884429875012375d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4641460225928634d,right: 0.984879641879876d,bottom: 0.3554478212343609d,left: 0.31513310533493366d),
new NpgsqlTypes.NpgsqlBox(top: 0.979146224046953d,right: 0.9746802329667344d,bottom: 0.5032450184124585d,left: 0.1789532880914667d),
new NpgsqlTypes.NpgsqlBox(top: 0.8738208239236973d,right: 0.862242251210295d,bottom: 0.34224521793725793d,left: 0.5769066793707665d),
new NpgsqlTypes.NpgsqlBox(top: 0.4028472976303953d,right: 0.32736535920005017d,bottom: 0.3145146533185845d,left: 0.0018817896166523074d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 16,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8465592372645403d,right: 0.4779291419989409d,bottom: 0.4039147327297593d,left: 0.12484285988110377d),
new NpgsqlTypes.NpgsqlBox(top: 0.14082648468813885d,right: 0.9143864412067597d,bottom: 0.09511696711842177d,left: 0.23530156947328718d),
new NpgsqlTypes.NpgsqlBox(top: 0.7500401009543478d,right: 0.404413297696928d,bottom: 0.2689253700826403d,left: 0.09334633534979009d),
new NpgsqlTypes.NpgsqlBox(top: 0.7701796486012452d,right: 0.9808184296328462d,bottom: 0.15130658248787954d,left: 0.6265503878766544d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 12,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5377926399323089d,right: 0.4707708640350068d,bottom: 0.30910960500274687d,left: 0.2748134472785654d),
new NpgsqlTypes.NpgsqlBox(top: 0.8388302381180505d,right: 0.5157004776300955d,bottom: 0.42803603703070436d,left: 0.44106504257203016d),
new NpgsqlTypes.NpgsqlBox(top: 0.5412169059728472d,right: 0.4327033286315012d,bottom: 0.5045779041036622d,left: 0.26991859659241735d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6072731123607688d,right: 0.8602476783763443d,bottom: 0.21089335104421647d,left: 0.1368642471937057d),
new NpgsqlTypes.NpgsqlBox(top: 0.8571600808423598d,right: 0.5208628299077275d,bottom: 0.46885097665088993d,left: 0.47345314854518217d),
new NpgsqlTypes.NpgsqlBox(top: 0.9924407884073929d,right: 0.6333942860358739d,bottom: 0.5729285776023421d,left: 0.07805841742914799d),
new NpgsqlTypes.NpgsqlBox(top: 0.6616210172832502d,right: 0.547791058846297d,bottom: 0.4359129227460752d,left: 0.26407042208677634d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 18,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7810461679255034d,right: 0.3783678871199535d,bottom: 0.7426745546916331d,left: 0.3021155410906263d),
new NpgsqlTypes.NpgsqlBox(top: 0.8482945863699931d,right: 0.57565251908077d,bottom: 0.1880498313048844d,left: 0.09593138902198095d),
new NpgsqlTypes.NpgsqlBox(top: 0.8910908372220548d,right: 0.689132685710121d,bottom: 0.7465280248153154d,left: 0.1662416509376199d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7677841702501456d,right: 0.5064730324570872d,bottom: 0.5996149262924664d,left: 0.38084197719424484d),
new NpgsqlTypes.NpgsqlBox(top: 0.9486202737148209d,right: 0.980641794139937d,bottom: 0.307598385655084d,left: 0.8858028029704131d),
new NpgsqlTypes.NpgsqlBox(top: 0.30507857365188795d,right: 0.3912730304187815d,bottom: 0.04155533633017827d,left: 0.3858815994728091d),
new NpgsqlTypes.NpgsqlBox(top: 0.8138804741897934d,right: 0.9813448422551609d,bottom: 0.23015130276792373d,left: 0.7060514852723686d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8210083970834411d,right: 0.8769117742708695d,bottom: 0.76342278529207d,left: 0.1681114711232854d),
new NpgsqlTypes.NpgsqlBox(top: 0.5694529352314665d,right: 0.7543768232418042d,bottom: 0.3332912162793039d,left: 0.4178126841947788d),
new NpgsqlTypes.NpgsqlBox(top: 0.8051684382099646d,right: 0.9607434923655364d,bottom: 0.2997637375362724d,left: 0.11821265779689893d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 20,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.10430175465188007d,right: 0.2922389980953779d,bottom: 0.038980693587648996d,left: 0.16998548779480915d),
new NpgsqlTypes.NpgsqlBox(top: 0.4333721137887694d,right: 0.37780652983448104d,bottom: 0.22564725800267216d,left: 0.17453665946847463d),
new NpgsqlTypes.NpgsqlBox(top: 0.3929681500973292d,right: 0.9856856202980618d,bottom: 0.35975904622179156d,left: 0.8735355060294795d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6760038481411257d,right: 0.9273239650263492d,bottom: 0.3722469510959997d,left: 0.5338095609478095d),
new NpgsqlTypes.NpgsqlBox(top: 0.7984451684316433d,right: 0.7850348145671875d,bottom: 0.12468286648075366d,left: 0.6536561268970612d),
new NpgsqlTypes.NpgsqlBox(top: 0.8332529596682858d,right: 0.6350289343769039d,bottom: 0.3463307809501308d,left: 0.23964141052825438d),
new NpgsqlTypes.NpgsqlBox(top: 0.8419959917163269d,right: 0.7095242329290471d,bottom: 0.17107289530166714d,left: 0.41898463201762803d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9367257605259524d,right: 0.3780479008291058d,bottom: 0.6775496113650573d,left: 0.3166668512411033d),
new NpgsqlTypes.NpgsqlBox(top: 0.7838847085722082d,right: 0.8653751431223918d,bottom: 0.6342739221655456d,left: 0.6213117913158442d),
new NpgsqlTypes.NpgsqlBox(top: 0.8064696107372159d,right: 0.5031891541561877d,bottom: 0.3608831388650102d,left: 0.07544517135368489d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 26,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8390573419489156d,right: 0.9194980755514378d,bottom: 0.4486641353908616d,left: 0.5042654678494317d),
new NpgsqlTypes.NpgsqlBox(top: 0.771066064437891d,right: 0.8420229355865476d,bottom: 0.5024645837534819d,left: 0.08833405206926448d),
new NpgsqlTypes.NpgsqlBox(top: 0.4936553219380555d,right: 0.9923839856213431d,bottom: 0.27407672539198613d,left: 0.35062132234308785d),
new NpgsqlTypes.NpgsqlBox(top: 0.9962433290628959d,right: 0.6887799136275944d,bottom: 0.5395808229161023d,left: 0.2526779094043887d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 30,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8141768378873421d,right: 0.9192676165955332d,bottom: 0.01208370168696804d,left: 0.6888136306555714d),
new NpgsqlTypes.NpgsqlBox(top: 0.1721907938223174d,right: 0.7434438988390054d,bottom: 0.13938530431961282d,left: 0.47019083279273377d),
new NpgsqlTypes.NpgsqlBox(top: 0.28676799232296013d,right: 0.9402997580615226d,bottom: 0.10754681579809156d,left: 0.3231029115179689d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 27,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5667493122346473d,right: 0.4178457088376909d,bottom: 0.14859202806346616d,left: 0.07209530949531895d),
new NpgsqlTypes.NpgsqlBox(top: 0.4676867749256348d,right: 0.43620790414227173d,bottom: 0.012217666773266078d,left: 0.2848018106682114d),
new NpgsqlTypes.NpgsqlBox(top: 0.8846695005853087d,right: 0.7738355785779768d,bottom: 0.5389140464201693d,left: 0.744973419802341d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8590723730749165d,right: 0.6351597058714674d,bottom: 0.4944313116168716d,left: 0.29038175471852734d),
new NpgsqlTypes.NpgsqlBox(top: 0.7571157847459836d,right: 0.7353370423933928d,bottom: 0.5036590399308436d,left: 0.629111834664836d),
new NpgsqlTypes.NpgsqlBox(top: 0.5951762619186376d,right: 0.3927855910957828d,bottom: 0.42125972879371376d,left: 0.17989497721030534d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7489593995157968d,right: 0.7389902386699899d,bottom: 0.5411269570186482d,left: 0.36407288643384905d),
new NpgsqlTypes.NpgsqlBox(top: 0.6118062497618024d,right: 0.4489951447058358d,bottom: 0.23126143892621343d,left: 0.2697210043308198d),
new NpgsqlTypes.NpgsqlBox(top: 0.8140828848269711d,right: 0.3618980473119219d,bottom: 0.07134684036587913d,left: 0.3370782636890136d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.43722023991401826d,right: 0.8953017617479985d,bottom: 0.2417653816713653d,left: 0.24509036614941082d),
new NpgsqlTypes.NpgsqlBox(top: 0.07985830109102698d,right: 0.5326286151056325d,bottom: 0.061092986803717775d,left: 0.06937982070398119d),
new NpgsqlTypes.NpgsqlBox(top: 0.5544897167578725d,right: 0.2686706367584972d,bottom: 0.03140462098980734d,left: 0.11355463112771402d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3524080670829841d,right: 0.39847456225305555d,bottom: 0.19450590256518852d,left: 0.07417443116034628d),
new NpgsqlTypes.NpgsqlBox(top: 0.39230001765973666d,right: 0.9757923755238851d,bottom: 0.19622156524450274d,left: 0.8367640265799016d),
new NpgsqlTypes.NpgsqlBox(top: 0.8623013136022816d,right: 0.8465241056899261d,bottom: 0.7583326733439295d,left: 0.10518484407873185d),
new NpgsqlTypes.NpgsqlBox(top: 0.39313421146208793d,right: 0.4877176333386596d,bottom: 0.05431639070927197d,left: 0.4032118361613749d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 36,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.2528615046428896d,right: 0.24121304001699306d,bottom: 0.1136637738728864d,left: 0.20103637833132726d),
new NpgsqlTypes.NpgsqlBox(top: 0.728602608172593d,right: 0.6882503155516898d,bottom: 0.02185263838134166d,left: 0.4378416218416228d),
new NpgsqlTypes.NpgsqlBox(top: 0.46593403487599805d,right: 0.9684016177384926d,bottom: 0.2326793757741331d,left: 0.5028646147931178d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42134625331729547d,right: 0.8942221527443258d,bottom: 0.30865137758285777d,left: 0.13033832192090022d),
new NpgsqlTypes.NpgsqlBox(top: 0.8667135439598214d,right: 0.9936559058505164d,bottom: 0.5376679296905593d,left: 0.6276623817872606d),
new NpgsqlTypes.NpgsqlBox(top: 0.6785024698551947d,right: 0.7259252712475688d,bottom: 0.08138708052102495d,left: 0.13306530357782065d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 48,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4406214718498477d,right: 0.9472716415645736d,bottom: 0.19144281919190176d,left: 0.01968919663058777d),
new NpgsqlTypes.NpgsqlBox(top: 0.659382208855739d,right: 0.6055737920383681d,bottom: 0.19302919694776666d,left: 0.5055617493727501d),
new NpgsqlTypes.NpgsqlBox(top: 0.9449590959212151d,right: 0.685248063398346d,bottom: 0.3712893876162989d,left: 0.42483916634828744d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4930050390600246d,right: 0.5898047242629458d,bottom: 0.28746751021333916d,left: 0.49806032863139815d),
new NpgsqlTypes.NpgsqlBox(top: 0.17512321770967232d,right: 0.1747143341993853d,bottom: 0.024759271373483327d,left: 0.05996301228984957d),
new NpgsqlTypes.NpgsqlBox(top: 0.15825664489008406d,right: 0.7107395908816116d,bottom: 0.07971860214879944d,left: 0.08754219939119978d),
new NpgsqlTypes.NpgsqlBox(top: 0.2737847189319691d,right: 0.7493602991036818d,bottom: 0.06869210538332216d,left: 0.15225036896167088d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 55,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5189356396148731d,right: 0.784057270668497d,bottom: 0.03954677162628062d,left: 0.5410241606608895d),
new NpgsqlTypes.NpgsqlBox(top: 0.41206032053956043d,right: 0.5099046305810927d,bottom: 0.11518571117831433d,left: 0.3129239815165934d),
new NpgsqlTypes.NpgsqlBox(top: 0.8576531178958554d,right: 0.7225604473641632d,bottom: 0.5396681678849927d,left: 0.03677039214978417d),
new NpgsqlTypes.NpgsqlBox(top: 0.9796888692742913d,right: 0.7658356201357533d,bottom: 0.4900672725232781d,left: 0.6863364405050723d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 37,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3809107370990287d,right: 0.4318100659966648d,bottom: 0.10335067275653265d,left: 0.012308724280567285d),
new NpgsqlTypes.NpgsqlBox(top: 0.28437113665593416d,right: 0.5063718084916509d,bottom: 0.2632049662054379d,left: 0.49313953387222986d),
new NpgsqlTypes.NpgsqlBox(top: 0.7674597653029391d,right: 0.7857031332815259d,bottom: 0.7109230819899144d,left: 0.5221694404074487d),
new NpgsqlTypes.NpgsqlBox(top: 0.5282716201415573d,right: 0.045345767263441306d,bottom: 0.27411140878165496d,left: 0.03005920680724905d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8767731779425127d,right: 0.970882737865145d,bottom: 0.6026570988156038d,left: 0.2233218216213646d),
new NpgsqlTypes.NpgsqlBox(top: 0.830518838079131d,right: 0.748410125914399d,bottom: 0.5531661672436948d,left: 0.3927292063487331d),
new NpgsqlTypes.NpgsqlBox(top: 0.7306289679993692d,right: 0.8336622158157458d,bottom: 0.6998769449997875d,left: 0.5559707933772996d),
new NpgsqlTypes.NpgsqlBox(top: 0.7563223508717846d,right: 0.9031551097430723d,bottom: 0.6568266150732555d,left: 0.19751278724512578d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 57,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41461910781161104d,right: 0.9564436277703054d,bottom: 0.19677216895225424d,left: 0.50673483074344d),
new NpgsqlTypes.NpgsqlBox(top: 0.7089319746725897d,right: 0.4971537457917282d,bottom: 0.3074178209189141d,left: 0.2108604883646985d),
new NpgsqlTypes.NpgsqlBox(top: 0.9622182630635349d,right: 0.8203821179111259d,bottom: 0.47554288324137506d,left: 0.7499142035398328d),
new NpgsqlTypes.NpgsqlBox(top: 0.9560166904082497d,right: 0.6928843121508834d,bottom: 0.39482501908254153d,left: 0.03159423646530679d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.174145241250812d,right: 0.6567647600694301d,bottom: 0.1256312914863461d,left: 0.024531988474252864d),
new NpgsqlTypes.NpgsqlBox(top: 0.9290249452464314d,right: 0.8344973273267499d,bottom: 0.25249360203974136d,left: 0.1198563547609186d),
new NpgsqlTypes.NpgsqlBox(top: 0.7030079721127206d,right: 0.5400240552523613d,bottom: 0.6418805869612215d,left: 0.26661954604967797d),
new NpgsqlTypes.NpgsqlBox(top: 0.9265766001390241d,right: 0.22229164891324316d,bottom: 0.35267574650220535d,left: 0.01500665729769246d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 66,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.23524590999408312d,right: 0.8148831651279776d,bottom: 0.030742043274820552d,left: 0.21091693075079287d),
new NpgsqlTypes.NpgsqlBox(top: 0.5221811577722234d,right: 0.5304712767127083d,bottom: 0.038981797621223446d,left: 0.3205057408258113d),
new NpgsqlTypes.NpgsqlBox(top: 0.7416274408811427d,right: 0.8269356986106805d,bottom: 0.348866659917732d,left: 0.22999482858567766d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3213367581115457d,right: 0.5398191951319321d,bottom: 0.3008759303391575d,left: 0.34951151026485705d),
new NpgsqlTypes.NpgsqlBox(top: 0.7373207420932909d,right: 0.8962978273347582d,bottom: 0.27523757536915416d,left: 0.053130661459171336d),
new NpgsqlTypes.NpgsqlBox(top: 0.37840527947092295d,right: 0.7262926621356716d,bottom: 0.2394237940383117d,left: 0.5500600889617375d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 72,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9153009421800679d,right: 0.9341487199218879d,bottom: 0.3620414041575071d,left: 0.8887018455471971d),
new NpgsqlTypes.NpgsqlBox(top: 0.9945179813583366d,right: 0.33903674184625987d,bottom: 0.5484002459037365d,left: 0.29429045228260664d),
new NpgsqlTypes.NpgsqlBox(top: 0.7612786255306364d,right: 0.5991285953914706d,bottom: 0.006589471845802275d,left: 0.20070789670713052d),
new NpgsqlTypes.NpgsqlBox(top: 0.7441757746653196d,right: 0.9914838738094542d,bottom: 0.4877077835266579d,left: 0.5904212755014875d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.45419168039512703d,right: 0.30726505649703406d,bottom: 0.33724028519049254d,left: 0.19820271933413924d),
new NpgsqlTypes.NpgsqlBox(top: 0.6493751814943473d,right: 0.789248199800561d,bottom: 0.6480189737516916d,left: 0.6418941702195939d),
new NpgsqlTypes.NpgsqlBox(top: 0.809213411639871d,right: 0.5111077445818921d,bottom: 0.03263795125759095d,left: 0.4222885114254116d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8951336460052706d,right: 0.6782456066139795d,bottom: 0.2843952899481619d,left: 0.2013839995425749d),
new NpgsqlTypes.NpgsqlBox(top: 0.9743858590167105d,right: 0.6495748354603215d,bottom: 0.8235945436477957d,left: 0.012434579500454568d),
new NpgsqlTypes.NpgsqlBox(top: 0.41358647154066286d,right: 0.9936772508402719d,bottom: 0.1680141271543506d,left: 0.2773825945383602d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6502033939939499d,right: 0.38391626095812514d,bottom: 0.5426720478244885d,left: 0.34728096850060275d),
new NpgsqlTypes.NpgsqlBox(top: 0.5465308219436041d,right: 0.8765325070680792d,bottom: 0.4530472398514622d,left: 0.5813042941370399d),
new NpgsqlTypes.NpgsqlBox(top: 0.9973867726537725d,right: 0.3680283871717832d,bottom: 0.8676086559362528d,left: 0.01809646715555069d),
new NpgsqlTypes.NpgsqlBox(top: 0.7729011254477298d,right: 0.9071077247572981d,bottom: 0.1727584154126306d,left: 0.8855557458325353d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7499280289937453d,right: 0.6786846890268162d,bottom: 0.7404671887972406d,left: 0.11618357466701579d),
new NpgsqlTypes.NpgsqlBox(top: 0.9366952254061232d,right: 0.7516673499886812d,bottom: 0.8280002437023131d,left: 0.5896858094850184d),
new NpgsqlTypes.NpgsqlBox(top: 0.5994529916295217d,right: 0.8208156322162298d,bottom: 0.3852164598639566d,left: 0.8052572090678581d),
new NpgsqlTypes.NpgsqlBox(top: 0.930234975789899d,right: 0.9394169521060617d,bottom: 0.17796901475689175d,left: 0.47453462752553266d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 80,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.05569823030616039d,right: 0.6251946795398384d,bottom: 0.037986180290830895d,left: 0.34142858224341766d),
new NpgsqlTypes.NpgsqlBox(top: 0.34080897590531944d,right: 0.8347482202472065d,bottom: 0.14693375870503678d,left: 0.10338615145539487d),
new NpgsqlTypes.NpgsqlBox(top: 0.8150328377171396d,right: 0.9473364207467277d,bottom: 0.0552122747812549d,left: 0.7271965399370757d),
new NpgsqlTypes.NpgsqlBox(top: 0.9649674974169242d,right: 0.0658484360903484d,bottom: 0.6279426499848173d,left: 0.04180927651804511d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4124001667686319d,right: 0.6260987795429719d,bottom: 0.2518161257216648d,left: 0.4756865116158263d),
new NpgsqlTypes.NpgsqlBox(top: 0.43810562352637883d,right: 0.9891589329213915d,bottom: 0.3036446830284397d,left: 0.3190363946851069d),
new NpgsqlTypes.NpgsqlBox(top: 0.49962527457703076d,right: 0.7811281106061266d,bottom: 0.09356406693811137d,left: 0.4899865327526406d),
new NpgsqlTypes.NpgsqlBox(top: 0.7568569467983619d,right: 0.5640997623924828d,bottom: 0.6582448343177174d,left: 0.21796469374522254d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 83,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.787130521489569d,right: 0.4800666653134208d,bottom: 0.27437781348629675d,left: 0.21739497529102325d),
new NpgsqlTypes.NpgsqlBox(top: 0.557446713163203d,right: 0.8459759992916547d,bottom: 0.0016539251999810878d,left: 0.3564777368062688d),
new NpgsqlTypes.NpgsqlBox(top: 0.5725838823724466d,right: 0.6209940110125131d,bottom: 0.2845210139645685d,left: 0.4934623334968823d),
new NpgsqlTypes.NpgsqlBox(top: 0.9987310736998447d,right: 0.910906674303308d,bottom: 0.9680976107743094d,left: 0.700291256064484d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 54,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5220328205219483d,right: 0.8863677340802408d,bottom: 0.5078956145230287d,left: 0.45963464944474086d),
new NpgsqlTypes.NpgsqlBox(top: 0.843827322004113d,right: 0.5628758000157348d,bottom: 0.7330200317093732d,left: 0.3741222025242067d),
new NpgsqlTypes.NpgsqlBox(top: 0.9493780007263901d,right: 0.9950901829523596d,bottom: 0.6303741691522018d,left: 0.9149174956297433d),
new NpgsqlTypes.NpgsqlBox(top: 0.5896318876451081d,right: 0.9410112417322075d,bottom: 0.10366685376424967d,left: 0.024826739734559067d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7983686005113361d,right: 0.8308343665644455d,bottom: 0.45885161993590673d,left: 0.20590903468456678d),
new NpgsqlTypes.NpgsqlBox(top: 0.3744555381833631d,right: 0.5034705050135403d,bottom: 0.16647748075105995d,left: 0.39799794509736974d),
new NpgsqlTypes.NpgsqlBox(top: 0.4843922335500278d,right: 0.9791500460097367d,bottom: 0.05115711273979928d,left: 0.7944510833436456d),
new NpgsqlTypes.NpgsqlBox(top: 0.8307175557196268d,right: 0.9677015600729953d,bottom: 0.3889616901527394d,left: 0.2188636262443615d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.464069236509711d,right: 0.6596783446616499d,bottom: 0.3083176902491048d,left: 0.5163982976707766d),
new NpgsqlTypes.NpgsqlBox(top: 0.5823427430551783d,right: 0.4426566553450777d,bottom: 0.5713338479764593d,left: 0.09980033074284045d),
new NpgsqlTypes.NpgsqlBox(top: 0.5974022636277694d,right: 0.5103621766928981d,bottom: 0.019297681299354497d,left: 0.019754844233666247d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33836997545279046d,right: 0.9326944480125037d,bottom: 0.10075507528398475d,left: 0.36375119281011803d),
new NpgsqlTypes.NpgsqlBox(top: 0.9711766335449921d,right: 0.7743994232356033d,bottom: 0.8017762805442746d,left: 0.2638098610076606d),
new NpgsqlTypes.NpgsqlBox(top: 0.9925677681198248d,right: 0.23897596569323998d,bottom: 0.5271335439447642d,left: 0.06936522921019683d),
new NpgsqlTypes.NpgsqlBox(top: 0.897008961677486d,right: 0.9447844212085845d,bottom: 0.3198590031949653d,left: 0.9265998589028899d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 90,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7140377458372242d,right: 0.6705321439530543d,bottom: 0.6631457655783457d,left: 0.2786687986870524d),
new NpgsqlTypes.NpgsqlBox(top: 0.9245449030602629d,right: 0.8753537975180573d,bottom: 0.5242687651364475d,left: 0.5352961280747691d),
new NpgsqlTypes.NpgsqlBox(top: 0.979430679827508d,right: 0.8636427195467064d,bottom: 0.23206611612089667d,left: 0.5720389612199424d),
new NpgsqlTypes.NpgsqlBox(top: 0.42713388601293023d,right: 0.8355255305991662d,bottom: 0.371674669407388d,left: 0.34991947134791834d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 60,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.42301798243898303d,right: 0.7443400419661846d,bottom: 0.3384299162193086d,left: 0.6360072856976612d),
new NpgsqlTypes.NpgsqlBox(top: 0.4810280587069995d,right: 0.7556394175090868d,bottom: 0.17742666155205933d,left: 0.7157689118508638d),
new NpgsqlTypes.NpgsqlBox(top: 0.5001536602617475d,right: 0.27043711119741065d,bottom: 0.006214240624151102d,left: 0.2178661313431277d),
new NpgsqlTypes.NpgsqlBox(top: 0.9041798990900196d,right: 0.5781821277893926d,bottom: 0.10111036678406948d,left: 0.45720431721562727d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7577329995672132d,right: 0.5558733489386866d,bottom: 0.5834855392151328d,left: 0.26750546693306587d),
new NpgsqlTypes.NpgsqlBox(top: 0.2694897641791455d,right: 0.9697124182811591d,bottom: 0.1352820398879978d,left: 0.24368841298398547d),
new NpgsqlTypes.NpgsqlBox(top: 0.2553772988932157d,right: 0.7490706210923429d,bottom: 0.23730398831305266d,left: 0.01585191718557144d),
new NpgsqlTypes.NpgsqlBox(top: 0.30640411335951656d,right: 0.973561771540828d,bottom: 0.13501749168647637d,left: 0.7005590746195068d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.719102337124181d,right: 0.8340896232107188d,bottom: 0.6822439580182842d,left: 0.35551130188617164d),
new NpgsqlTypes.NpgsqlBox(top: 0.5298132644297264d,right: 0.8204150095051869d,bottom: 0.25401247803868543d,left: 0.14316130360587132d),
new NpgsqlTypes.NpgsqlBox(top: 0.49174127380808874d,right: 0.33461308286401903d,bottom: 0.25224429923308345d,left: 0.07565805378873813d),
new NpgsqlTypes.NpgsqlBox(top: 0.9129287343226231d,right: 0.8418727557962193d,bottom: 0.8865781969461807d,left: 0.24849811313811776d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6525271180116857d,right: 0.5466228532949011d,bottom: 0.50965220125395d,left: 0.13939804897558328d),
new NpgsqlTypes.NpgsqlBox(top: 0.9592722623190003d,right: 0.8873583368480253d,bottom: 0.1738033834445467d,left: 0.5524109931307775d),
new NpgsqlTypes.NpgsqlBox(top: 0.6418131921347057d,right: 0.9448919830560673d,bottom: 0.27230309947325737d,left: 0.7621723335990452d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 102,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5901343183450319d,right: 0.7690358368339489d,bottom: 0.3964002934142482d,left: 0.024058967303850265d),
new NpgsqlTypes.NpgsqlBox(top: 0.9207258740204225d,right: 0.7664731970079521d,bottom: 0.9106031955354618d,left: 0.05745260177728728d),
new NpgsqlTypes.NpgsqlBox(top: 0.9839144417476146d,right: 0.44130387562959117d,bottom: 0.9763214795920445d,left: 0.2805215791243091d),
new NpgsqlTypes.NpgsqlBox(top: 0.3994123805251758d,right: 0.314056044773935d,bottom: 0.291818439185647d,left: 0.10901242166882819d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5561030829626207d,right: 0.9115751829405236d,bottom: 0.3641159132852715d,left: 0.904901321839644d),
new NpgsqlTypes.NpgsqlBox(top: 0.8399751254676946d,right: 0.8475164551986782d,bottom: 0.10382354212011202d,left: 0.7510119923310432d),
new NpgsqlTypes.NpgsqlBox(top: 0.32559123353839425d,right: 0.8888038120028912d,bottom: 0.31007063736986196d,left: 0.14888597022068784d),
new NpgsqlTypes.NpgsqlBox(top: 0.8253471028229113d,right: 0.8457422322474618d,bottom: 0.3852301889724882d,left: 0.09186380041028641d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7202006834868941d,right: 0.8374309032194104d,bottom: 0.4973143447849674d,left: 0.04162546690168545d),
new NpgsqlTypes.NpgsqlBox(top: 0.19773227115366232d,right: 0.27972330194543027d,bottom: 0.151796763128197d,left: 0.041025016493672406d),
new NpgsqlTypes.NpgsqlBox(top: 0.6491648145196706d,right: 0.5299505444331578d,bottom: 0.3208401761153795d,left: 0.1387307065878618d),
new NpgsqlTypes.NpgsqlBox(top: 0.31607465691209513d,right: 0.5443728402455055d,bottom: 0.033183533941239296d,left: 0.22219236076049453d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 107,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5381362670544387d,right: 0.6919805327797331d,bottom: 0.17893679961068742d,left: 0.44333474841472675d),
new NpgsqlTypes.NpgsqlBox(top: 0.5176211539183466d,right: 0.647067045447165d,bottom: 0.1240324637982082d,left: 0.09726801436000332d),
new NpgsqlTypes.NpgsqlBox(top: 0.8614644981000684d,right: 0.6079647594261853d,bottom: 0.28780363878906445d,left: 0.35341814412977557d),
new NpgsqlTypes.NpgsqlBox(top: 0.8371758682279993d,right: 0.514840005061695d,bottom: 0.48364871805691323d,left: 0.09986745110044903d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9886997074804054d,right: 0.9504971650772502d,bottom: 0.23435760112838477d,left: 0.31625651702806923d),
new NpgsqlTypes.NpgsqlBox(top: 0.6241779084197802d,right: 0.6062596759332209d,bottom: 0.4061094232428756d,left: 0.04398254977924376d),
new NpgsqlTypes.NpgsqlBox(top: 0.7777196924203746d,right: 0.7808653032674867d,bottom: 0.40518944475390806d,left: 0.3443431196188196d),
new NpgsqlTypes.NpgsqlBox(top: 0.8473435927966919d,right: 0.664257120208611d,bottom: 0.48972367060438027d,left: 0.5913892368938346d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 112,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5075433012224714d,right: 0.8045162782238401d,bottom: 0.31438794677143345d,left: 0.4374567261003094d),
new NpgsqlTypes.NpgsqlBox(top: 0.733519215439191d,right: 0.997719942988172d,bottom: 0.42205246065262436d,left: 0.8821001205704764d),
new NpgsqlTypes.NpgsqlBox(top: 0.5007816692626961d,right: 0.9194943700112529d,bottom: 0.40953059090006416d,left: 0.31589981224056196d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 70,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8673053407717668d,right: 0.8769280410309793d,bottom: 0.28261580920529683d,left: 0.6225311722028497d),
new NpgsqlTypes.NpgsqlBox(top: 0.7051507408261314d,right: 0.7170044834281308d,bottom: 0.16764011719952232d,left: 0.575956640568883d),
new NpgsqlTypes.NpgsqlBox(top: 0.40141840741477974d,right: 0.7015999448064497d,bottom: 0.39673149411871445d,left: 0.3229326519404988d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 114,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8060292036217318d,right: 0.9079729345942628d,bottom: 0.3569919645065125d,left: 0.5296053374988766d),
new NpgsqlTypes.NpgsqlBox(top: 0.7344790870342494d,right: 0.7639249371201798d,bottom: 0.01655187468445296d,left: 0.013396288463889516d),
new NpgsqlTypes.NpgsqlBox(top: 0.904159792010404d,right: 0.694253263174043d,bottom: 0.23800915931927313d,left: 0.3934452101904433d),
new NpgsqlTypes.NpgsqlBox(top: 0.9027332138142061d,right: 0.9274397699953569d,bottom: 0.5073947305630704d,left: 0.30601397520400286d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.977551195379923d,right: 0.6028667120594365d,bottom: 0.5137450514963872d,left: 0.4716691427325308d),
new NpgsqlTypes.NpgsqlBox(top: 0.9459580017657399d,right: 0.6732337403927674d,bottom: 0.2829100814346288d,left: 0.5383008670232815d),
new NpgsqlTypes.NpgsqlBox(top: 0.8248835736279703d,right: 0.6435956790205754d,bottom: 0.6971609146090644d,left: 0.43776390919030483d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 115,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9723456007753846d,right: 0.8855117416532604d,bottom: 0.6369070030595915d,left: 0.08724875389309539d),
new NpgsqlTypes.NpgsqlBox(top: 0.2985902368269334d,right: 0.9771959743215433d,bottom: 0.09616950709698235d,left: 0.6668777590068914d),
new NpgsqlTypes.NpgsqlBox(top: 0.9358304924905645d,right: 0.8394870133699076d,bottom: 0.9048032455047538d,left: 0.4448418536399199d),
new NpgsqlTypes.NpgsqlBox(top: 0.9525266336620636d,right: 0.5602822025418686d,bottom: 0.4029151244394823d,left: 0.14800063901008043d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7236992700760152d,right: 0.7306647798507944d,bottom: 0.5494296428477479d,left: 0.33493407542670217d),
new NpgsqlTypes.NpgsqlBox(top: 0.7398170321373566d,right: 0.43541363601000516d,bottom: 0.5270998590188646d,left: 0.09933563735951179d),
new NpgsqlTypes.NpgsqlBox(top: 0.7763672600417842d,right: 0.30899375327683754d,bottom: 0.2232126933888402d,left: 0.08852928275412297d),
new NpgsqlTypes.NpgsqlBox(top: 0.1410743039348168d,right: 0.29141645945903194d,bottom: 0.013790520123585615d,left: 0.004297631858809603d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5917002506701108d,right: 0.6341690232765729d,bottom: 0.41678661928197014d,left: 0.05829439632030653d),
new NpgsqlTypes.NpgsqlBox(top: 0.4147365695804579d,right: 0.8285188820962175d,bottom: 0.1748513106633004d,left: 0.16126997294023204d),
new NpgsqlTypes.NpgsqlBox(top: 0.8280644883305925d,right: 0.731047231122133d,bottom: 0.07689267240991315d,left: 0.1800717228129315d),
new NpgsqlTypes.NpgsqlBox(top: 0.7530847057044368d,right: 0.9474254743838918d,bottom: 0.5660512091150897d,left: 0.22569865929153055d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 123,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4838638657570451d,right: 0.6651979403251168d,bottom: 0.3670896364120755d,left: 0.030439171150926314d),
new NpgsqlTypes.NpgsqlBox(top: 0.7483199135685671d,right: 0.9275081011005687d,bottom: 0.1346228828301509d,left: 0.3393398654762678d),
new NpgsqlTypes.NpgsqlBox(top: 0.6210693564291123d,right: 0.9886830307590685d,bottom: 0.29580274148967045d,left: 0.24142849606760175d),
new NpgsqlTypes.NpgsqlBox(top: 0.8110929421077417d,right: 0.21722851352779382d,bottom: 0.34218135557485063d,left: 0.1981414416025319d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 132,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.966309275410563d,right: 0.05668830011408299d,bottom: 0.2564850135699962d,left: 0.03825410926519435d),
new NpgsqlTypes.NpgsqlBox(top: 0.574117204422543d,right: 0.6597457058348881d,bottom: 0.5546160836595534d,left: 0.21562203555610815d),
new NpgsqlTypes.NpgsqlBox(top: 0.541165050103775d,right: 0.11685193899582569d,bottom: 0.28978798682850326d,left: 0.08492859003798225d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 78,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9343993551357457d,right: 0.9527246188646047d,bottom: 0.8175399862409126d,left: 0.8250875477388481d),
new NpgsqlTypes.NpgsqlBox(top: 0.06527770114884579d,right: 0.38119929028831545d,bottom: 0.004939133506297599d,left: 0.03802789706518028d),
new NpgsqlTypes.NpgsqlBox(top: 0.8145678102622566d,right: 0.6774697162308159d,bottom: 0.025401914756075783d,left: 0.5779515052178844d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5645159132559548d,right: 0.7792092381683167d,bottom: 0.24257668498720764d,left: 0.10853295217820436d),
new NpgsqlTypes.NpgsqlBox(top: 0.6455780104236631d,right: 0.34335262386714105d,bottom: 0.43806947582788236d,left: 0.028781038084758404d),
new NpgsqlTypes.NpgsqlBox(top: 0.6136643449789394d,right: 0.11231624491158143d,bottom: 0.33950466808396373d,left: 0.08465354279849924d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.35257531062429237d,right: 0.7133359754368938d,bottom: 0.1502116018323021d,left: 0.22204282976418444d),
new NpgsqlTypes.NpgsqlBox(top: 0.5929320579772475d,right: 0.7655998296104355d,bottom: 0.041240685306675795d,left: 0.42620237540767947d),
new NpgsqlTypes.NpgsqlBox(top: 0.8646098150195806d,right: 0.5708330494628665d,bottom: 0.0999187529936465d,left: 0.5104324034703808d),
new NpgsqlTypes.NpgsqlBox(top: 0.8576306206047163d,right: 0.7251995007637192d,bottom: 0.2791379111010982d,left: 0.3301995849928343d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 140,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.33828897964193494d,right: 0.4148089245512522d,bottom: 0.13303228874044037d,left: 0.12703162151726743d),
new NpgsqlTypes.NpgsqlBox(top: 0.8842097218518421d,right: 0.8241645870732693d,bottom: 0.4420488731539006d,left: 0.7605341209531347d),
new NpgsqlTypes.NpgsqlBox(top: 0.989967181338359d,right: 0.8573752630934839d,bottom: 0.32740336970767436d,left: 0.7502260429202062d),
new NpgsqlTypes.NpgsqlBox(top: 0.8520437436086213d,right: 0.5938021596090187d,bottom: 0.3589501614057552d,left: 0.16804696145552522d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5037157728919037d,right: 0.8690434696259784d,bottom: 0.09378279424984626d,left: 0.7015779615273813d),
new NpgsqlTypes.NpgsqlBox(top: 0.8310749077805502d,right: 0.38790991628326177d,bottom: 0.49854760109296625d,left: 0.3245036826558081d),
new NpgsqlTypes.NpgsqlBox(top: 0.44788410031770687d,right: 0.7108661402523269d,bottom: 0.3532430021578087d,left: 0.5008295280272776d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 146,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.20298063695183954d,right: 0.3133094261962912d,bottom: 0.0030928969196927225d,left: 0.23079636293652706d),
new NpgsqlTypes.NpgsqlBox(top: 0.9914093218073486d,right: 0.9202264856965361d,bottom: 0.9645536972799487d,left: 0.8618017028811704d),
new NpgsqlTypes.NpgsqlBox(top: 0.48236048445973345d,right: 0.7911071653754977d,bottom: 0.2766153867197124d,left: 0.7292393540436809d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 86,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7649400543913728d,right: 0.7969124946689334d,bottom: 0.49768250667766656d,left: 0.6179534186585466d),
new NpgsqlTypes.NpgsqlBox(top: 0.28301359542225046d,right: 0.3827467358895382d,bottom: 0.23963903515260077d,left: 0.07268452888031063d),
new NpgsqlTypes.NpgsqlBox(top: 0.7372726697053753d,right: 0.45278924252483854d,bottom: 0.6536839590599872d,left: 0.10939407278098279d),
new NpgsqlTypes.NpgsqlBox(top: 0.7575830981753755d,right: 0.45261994354362045d,bottom: 0.022973504022160807d,left: 0.040446550120262215d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7034418224477395d,right: 0.21517928996593516d,bottom: 0.5166755017957222d,left: 0.02225491745657393d),
new NpgsqlTypes.NpgsqlBox(top: 0.9392490709386799d,right: 0.12418364650812186d,bottom: 0.6324041842794779d,left: 0.00037539139815090383d),
new NpgsqlTypes.NpgsqlBox(top: 0.21197005712117545d,right: 0.48107727792041877d,bottom: 0.19200172919431124d,left: 0.4301832904165511d),
new NpgsqlTypes.NpgsqlBox(top: 0.7431144683869169d,right: 0.6069043218865259d,bottom: 0.30850762251212427d,left: 0.47894910162097604d),
},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1mi(
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
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645))]
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

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlBoxArrayboxArray)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlBoxArrayboxArray)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlBoxArrayboxArray)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7677841702501456d,right: 0.5064730324570872d,bottom: 0.5996149262924664d,left: 0.38084197719424484d),
new NpgsqlTypes.NpgsqlBox(top: 0.9486202737148209d,right: 0.980641794139937d,bottom: 0.307598385655084d,left: 0.8858028029704131d),
new NpgsqlTypes.NpgsqlBox(top: 0.30507857365188795d,right: 0.3912730304187815d,bottom: 0.04155533633017827d,left: 0.3858815994728091d),
new NpgsqlTypes.NpgsqlBox(top: 0.8138804741897934d,right: 0.9813448422551609d,bottom: 0.23015130276792373d,left: 0.7060514852723686d),
}));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9367257605259524d,right: 0.3780479008291058d,bottom: 0.6775496113650573d,left: 0.3166668512411033d),
new NpgsqlTypes.NpgsqlBox(top: 0.7838847085722082d,right: 0.8653751431223918d,bottom: 0.6342739221655456d,left: 0.6213117913158442d),
new NpgsqlTypes.NpgsqlBox(top: 0.8064696107372159d,right: 0.5031891541561877d,bottom: 0.3608831388650102d,left: 0.07544517135368489d),
}));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>();
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
                    ((NpgsqlParameter<NpgsqlTypes.NpgsqlBox[]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483645);
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

                    nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7489593995157968d,right: 0.7389902386699899d,bottom: 0.5411269570186482d,left: 0.36407288643384905d),
new NpgsqlTypes.NpgsqlBox(top: 0.6118062497618024d,right: 0.4489951447058358d,bottom: 0.23126143892621343d,left: 0.2697210043308198d),
new NpgsqlTypes.NpgsqlBox(top: 0.8140828848269711d,right: 0.3618980473119219d,bottom: 0.07134684036587913d,left: 0.3370782636890136d),
}));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlboxboxarray1m(
	id,
    value,
    nullablevalue,
    npgsqlboxboxarray1mi_id
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
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(NpgsqlTypes.NpgsqlBox[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483645)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlboxboxarray1mi_id", 
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
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable =  ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                NpgsqlTypes.NpgsqlBox[] nullable = null;
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4930050390600246d,right: 0.5898047242629458d,bottom: 0.28746751021333916d,left: 0.49806032863139815d),
new NpgsqlTypes.NpgsqlBox(top: 0.17512321770967232d,right: 0.1747143341993853d,bottom: 0.024759271373483327d,left: 0.05996301228984957d),
new NpgsqlTypes.NpgsqlBox(top: 0.15825664489008406d,right: 0.7107395908816116d,bottom: 0.07971860214879944d,left: 0.08754219939119978d),
new NpgsqlTypes.NpgsqlBox(top: 0.2737847189319691d,right: 0.7493602991036818d,bottom: 0.06869210538332216d,left: 0.15225036896167088d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[14], true);
                models =  ((INpgsqlBoxArrayboxArray)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlBoxboxArray1M> models = null;

                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlBoxArrayboxArray)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[29], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await ((INpgsqlBoxArrayboxArray)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlBoxArrayboxArray)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 66;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 96;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 78;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 83;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 10;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 40;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 37;
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 48;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[29], false);
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
                parametr1.Value = 96;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 10;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 90;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 114;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 16;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M), typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                await((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 55, query1, 18, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 14, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlBoxboxArray1M>();
                var models2 = new List<FlatNpgsqlBoxboxArray1M>();
                ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models1[i],_testData[i], false);
                }

                Assert.That(models2, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 72, query1, 123, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                Assert.That(secondItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var firstItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 37, query1, 80, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[29], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 80, query1, 132, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 96, query1, 4, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[28],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    FlatNpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 57, query1, 16, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[25],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
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
FROM public.npgsqlboxboxarray1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems1 = new List<FlatNpgsqlBoxboxArray1M>();
                var secondItems2 = new List<FlatNpgsqlBoxboxArray1M>();
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 90, query1, 132, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(2));
                Assert.That(secondItems2, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[29], false);
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
FROM public.npgsqlboxboxarray1m m
LEFT JOIN public.npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
            asPartInterface: typeof(INpgsqlBoxArrayboxArray)),
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
                var models = await((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 57, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
                var models = ((INpgsqlBoxArrayboxArray)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlBoxboxArray1M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 18, 88))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
                await using var cmd = await ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 22);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(24));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(6));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[29], false);
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
FROM public.binary_npgsqlboxboxarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlBoxboxArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task ImportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1MI>(15);

                importCollection.Add(_testData[1].ModelInner);
                importCollection.Add(_testData[3].ModelInner);
                importCollection.Add(_testData[5].ModelInner);
                importCollection.Add(_testData[7].ModelInner);
                importCollection.Add(_testData[9].ModelInner);
                importCollection.Add(_testData[11].ModelInner);
                importCollection.Add(_testData[13].ModelInner);
                ((INpgsqlBoxArrayboxArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(7));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelInnerAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
                set.Clear();
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlBoxboxArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
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
FROM public.binary_npgsqlboxboxarray1m m
LEFT JOIN public.binary_npgsqlboxboxarray1mi mi ON mi.id = m.npgsqlboxboxarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(1)]
        public async Task ImportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();

                var importCollection = new List<NpgsqlBoxboxArray1M>(15);

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
                ((INpgsqlBoxArrayboxArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlBoxArrayboxArray)this).SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(15));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
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
                await ((INpgsqlBoxArrayboxArray)this).ImportModelAsync(connection, importCollection);
                models = await ((INpgsqlBoxArrayboxArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(30));

                NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[0], false);
                NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[1], false);
                NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[2], false);
                NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[3], false);
                NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[4], false);
                NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[5], false);
                NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[6], false);
                NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[7], false);
                NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[8], false);
                NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[9], false);
                NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[10], false);
                NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[11], false);
                NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[12], false);
                NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[13], false);
                NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[14], false);
                NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[15], false);
                NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[16], false);
                NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[17], false);
                NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[18], false);
                NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[19], false);
                NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[20], false);
                NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[21], false);
                NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[22], false);
                NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[23], false);
                NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[24], false);
                NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[25], false);
                NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[26], false);
                NpgsqlBoxboxArray1M.AssertModel(models[27],_testData[27], false);
                NpgsqlBoxboxArray1M.AssertModel(models[28],_testData[28], false);
                NpgsqlBoxboxArray1M.AssertModel(models[29],_testData[29], false);
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlboxboxarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1M)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlBoxboxArray1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlboxboxarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlBoxboxArray1MI)],
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645),
                (NpgsqlTypes.NpgsqlDbType)(-2147483645)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlBoxArrayboxArray))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task ExportModelInnerTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((INpgsqlBoxArrayboxArray)this).ExportModelInner(connection).ToList();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(2)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlBoxArrayboxArray)this).ExportModelInnerAsync(connection).ToListAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlBoxboxArray1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

