

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
    Id = 2,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4151937235967791d,right: 0.9096292566091796d,bottom: 0.19204970879395133d,left: 0.5513075131833456d),
new NpgsqlTypes.NpgsqlBox(top: 0.17366341811344077d,right: 0.7968636944676304d,bottom: 0.1120814625985932d,left: 0.3718541264659635d),
new NpgsqlTypes.NpgsqlBox(top: 0.9128852078315094d,right: 0.5860390494575016d,bottom: 0.5114103794420403d,left: 0.5523640467602661d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 7,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6420635103270408d,right: 0.6885888864895107d,bottom: 0.2696725342855256d,left: 0.09006777323183479d),
new NpgsqlTypes.NpgsqlBox(top: 0.2565751147844385d,right: 0.4779092478440796d,bottom: 0.09485816816080239d,left: 0.2633042933277825d),
new NpgsqlTypes.NpgsqlBox(top: 0.2697197944090417d,right: 0.7593177114159283d,bottom: 0.1375304616040417d,left: 0.12258534754856698d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 8,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9917129920210466d,right: 0.5474952962105364d,bottom: 0.22976370251581535d,left: 0.30629019637163923d),
new NpgsqlTypes.NpgsqlBox(top: 0.6414506717750882d,right: 0.9597454957225441d,bottom: 0.10030825733990867d,left: 0.4609565478953316d),
new NpgsqlTypes.NpgsqlBox(top: 0.8615447345041041d,right: 0.34566541990795907d,bottom: 0.4863333376170238d,left: 0.05310992318254093d),
new NpgsqlTypes.NpgsqlBox(top: 0.9909966564634222d,right: 0.7704702505733854d,bottom: 0.8454120142911444d,left: 0.7159903320103421d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8897707662997058d,right: 0.8264453394918689d,bottom: 0.24727478299513417d,left: 0.7140608192771444d),
new NpgsqlTypes.NpgsqlBox(top: 0.521056474416049d,right: 0.9803191994305676d,bottom: 0.3061856433615815d,left: 0.6419985458884115d),
new NpgsqlTypes.NpgsqlBox(top: 0.7082642716687819d,right: 0.4771500415750878d,bottom: 0.11406908520789905d,left: 0.23323748378881248d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8367977460594054d,right: 0.8677525395470728d,bottom: 0.08297418901649434d,left: 0.5480197753741464d),
new NpgsqlTypes.NpgsqlBox(top: 0.8379661824270016d,right: 0.9317637496905338d,bottom: 0.08305732508516417d,left: 0.568448150352494d),
new NpgsqlTypes.NpgsqlBox(top: 0.8407222810139661d,right: 0.6463221318047898d,bottom: 0.8241685023383214d,left: 0.43570436741924146d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 13,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8701322419083913d,right: 0.5437181733356686d,bottom: 0.6948664337948315d,left: 0.03784697630474465d),
new NpgsqlTypes.NpgsqlBox(top: 0.8683370000300614d,right: 0.7298047327631763d,bottom: 0.3600241465965436d,left: 0.04992564555080958d),
new NpgsqlTypes.NpgsqlBox(top: 0.2659185459355978d,right: 0.38768067154205865d,bottom: 0.06287858074989428d,left: 0.17620705382151414d),
new NpgsqlTypes.NpgsqlBox(top: 0.3096787301257171d,right: 0.32117514655594903d,bottom: 0.3036456362371093d,left: 0.3164504262807767d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 17,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9630441248158826d,right: 0.7633380444994742d,bottom: 0.07272784405963095d,left: 0.43742606798632255d),
new NpgsqlTypes.NpgsqlBox(top: 0.8116221716893763d,right: 0.3693530109766243d,bottom: 0.09522116696587624d,left: 0.07200606411441768d),
new NpgsqlTypes.NpgsqlBox(top: 0.8053693320748412d,right: 0.9524538328232246d,bottom: 0.7867481883942552d,left: 0.5656829943243574d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 14,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3962536879595482d,right: 0.4298771960391611d,bottom: 0.00805768845701782d,left: 0.2163466030229344d),
new NpgsqlTypes.NpgsqlBox(top: 0.8515697036792532d,right: 0.6808267586407378d,bottom: 0.6351206517343561d,left: 0.47451924580064775d),
new NpgsqlTypes.NpgsqlBox(top: 0.9427048433268993d,right: 0.8731923710295081d,bottom: 0.5243011484739363d,left: 0.19982881217350412d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7782211208371579d,right: 0.9868851055288813d,bottom: 0.597560174870751d,left: 0.9409731864342831d),
new NpgsqlTypes.NpgsqlBox(top: 0.3820579341624414d,right: 0.8965587356674908d,bottom: 0.02054522698819672d,left: 0.1134340589050935d),
new NpgsqlTypes.NpgsqlBox(top: 0.5182409779833873d,right: 0.6268817447840513d,bottom: 0.009680794562860084d,left: 0.02260088619412326d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 22,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3358745874301664d,right: 0.3064858147368953d,bottom: 0.26298025634600297d,left: 0.030627367536649852d),
new NpgsqlTypes.NpgsqlBox(top: 0.791540823234396d,right: 0.5984149739320545d,bottom: 0.2815783085321809d,left: 0.29397209570014293d),
new NpgsqlTypes.NpgsqlBox(top: 0.636580237533395d,right: 0.9227352985082403d,bottom: 0.5610669851785812d,left: 0.03463883769019338d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 31,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5551717483107511d,right: 0.6891852448393728d,bottom: 0.214812349435069d,left: 0.29552553403526294d),
new NpgsqlTypes.NpgsqlBox(top: 0.4283733368015099d,right: 0.9529067491205109d,bottom: 0.31172201839197666d,left: 0.7641604261909517d),
new NpgsqlTypes.NpgsqlBox(top: 0.8038924780899006d,right: 0.7505901126824066d,bottom: 0.5566205366813495d,left: 0.6569496547381627d),
new NpgsqlTypes.NpgsqlBox(top: 0.2636359618956936d,right: 0.9095457418792451d,bottom: 0.14868673945134114d,left: 0.24442877119676742d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 19,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.585502555945473d,right: 0.7130656047347906d,bottom: 0.4180605061915862d,left: 0.4139964505576026d),
new NpgsqlTypes.NpgsqlBox(top: 0.5244560324814216d,right: 0.5819750038064405d,bottom: 0.30853240909346846d,left: 0.3817200937320032d),
new NpgsqlTypes.NpgsqlBox(top: 0.9299246231635024d,right: 0.5199123237693789d,bottom: 0.0698688009151377d,left: 0.04803211218993664d),
new NpgsqlTypes.NpgsqlBox(top: 0.4304355155480948d,right: 0.6411097016617382d,bottom: 0.27356173808454665d,left: 0.06699749927981391d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6198265711888457d,right: 0.5986866742957929d,bottom: 0.07064964288897724d,left: 0.5913493296521427d),
new NpgsqlTypes.NpgsqlBox(top: 0.941633820911574d,right: 0.5851815303356888d,bottom: 0.8568161791256048d,left: 0.5219366021776861d),
new NpgsqlTypes.NpgsqlBox(top: 0.9090091945511916d,right: 0.5684485711432055d,bottom: 0.7581278491518243d,left: 0.019016171285477612d),
new NpgsqlTypes.NpgsqlBox(top: 0.7299486677216883d,right: 0.6535427120076672d,bottom: 0.16720851518457924d,left: 0.38979589929051583d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6034274124839237d,right: 0.7318620647050875d,bottom: 0.5503429719042372d,left: 0.5304564787906925d),
new NpgsqlTypes.NpgsqlBox(top: 0.6177285254995206d,right: 0.8384726483148238d,bottom: 0.3266297796846017d,left: 0.5539142854369895d),
new NpgsqlTypes.NpgsqlBox(top: 0.631887527145945d,right: 0.8146509866939016d,bottom: 0.6112429727435715d,left: 0.6151295457717012d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 32,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9638845578836969d,right: 0.9219818698381044d,bottom: 0.04260705600693049d,left: 0.1503028181134144d),
new NpgsqlTypes.NpgsqlBox(top: 0.6817126646331021d,right: 0.7303053749247123d,bottom: 0.03856204420235354d,left: 0.654847671695962d),
new NpgsqlTypes.NpgsqlBox(top: 0.6694975649400895d,right: 0.9129808134465496d,bottom: 0.1418186526936278d,left: 0.5675047982729183d),
new NpgsqlTypes.NpgsqlBox(top: 0.273272801716943d,right: 0.8822716997533031d,bottom: 0.12833663199903322d,left: 0.18276216316556515d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6356381713347408d,right: 0.7278225554842537d,bottom: 0.41643308515201183d,left: 0.5818226766496348d),
new NpgsqlTypes.NpgsqlBox(top: 0.9624523757766952d,right: 0.5369267250977033d,bottom: 0.3921846250935421d,left: 0.14308219023338054d),
new NpgsqlTypes.NpgsqlBox(top: 0.8404661421871673d,right: 0.7547458638489286d,bottom: 0.7491928056219938d,left: 0.5017911763819966d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 40,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.236585805717191d,right: 0.27318370287685756d,bottom: 0.05689111199715813d,left: 0.06565249432842568d),
new NpgsqlTypes.NpgsqlBox(top: 0.26115461465999856d,right: 0.5072192626360476d,bottom: 0.024317855607591365d,left: 0.49545521004872317d),
new NpgsqlTypes.NpgsqlBox(top: 0.48405014280637715d,right: 0.8455995385797415d,bottom: 0.29226620317794216d,left: 0.3863875972062015d),
new NpgsqlTypes.NpgsqlBox(top: 0.8370258069509491d,right: 0.697087262513737d,bottom: 0.6407223922604883d,left: 0.6923487857293094d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 24,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7776666162342453d,right: 0.60932609247166d,bottom: 0.7737200298933659d,left: 0.27566898192247347d),
new NpgsqlTypes.NpgsqlBox(top: 0.476487537753273d,right: 0.9513151475487961d,bottom: 0.03580974978722584d,left: 0.16661183971282423d),
new NpgsqlTypes.NpgsqlBox(top: 0.26118678351804914d,right: 0.5539519818284984d,bottom: 0.11194087033916178d,left: 0.06888021597934957d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6094508427243176d,right: 0.8803623571709116d,bottom: 0.5031432875765355d,left: 0.1081213437646853d),
new NpgsqlTypes.NpgsqlBox(top: 0.8403814018437398d,right: 0.886669886848007d,bottom: 0.19921390378472137d,left: 0.40713104118546195d),
new NpgsqlTypes.NpgsqlBox(top: 0.5764300823986619d,right: 0.7032258912089461d,bottom: 0.2324755222105651d,left: 0.1520987901963362d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 46,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9124428734381345d,right: 0.9001115119807721d,bottom: 0.4443484890223435d,left: 0.17328135946943113d),
new NpgsqlTypes.NpgsqlBox(top: 0.4539645181595362d,right: 0.6915695995792249d,bottom: 0.271822477697365d,left: 0.5337568717370847d),
new NpgsqlTypes.NpgsqlBox(top: 0.7789679439048399d,right: 0.8848209456755762d,bottom: 0.5457982950351283d,left: 0.549292232953992d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9821988829597493d,right: 0.9116219539487297d,bottom: 0.4397705051481683d,left: 0.28434161565399363d),
new NpgsqlTypes.NpgsqlBox(top: 0.3694885859212742d,right: 0.7657300317828836d,bottom: 0.16714380030683307d,left: 0.018847896713734436d),
new NpgsqlTypes.NpgsqlBox(top: 0.6373448418974655d,right: 0.7570896708060989d,bottom: 0.6250602261416877d,left: 0.1523577408115636d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 29,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7900072249515685d,right: 0.5071212106176103d,bottom: 0.4248451310160609d,left: 0.04592999016313626d),
new NpgsqlTypes.NpgsqlBox(top: 0.3606821860863224d,right: 0.505744974927748d,bottom: 0.24838544661514939d,left: 0.4487971282544646d),
new NpgsqlTypes.NpgsqlBox(top: 0.5465269893693584d,right: 0.8517474894578054d,bottom: 0.2865184667711057d,left: 0.2624826339656331d),
new NpgsqlTypes.NpgsqlBox(top: 0.724592021694368d,right: 0.4823399012038425d,bottom: 0.2607788031371445d,left: 0.2646908431348214d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 56,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9030472553838371d,right: 0.9980054210274057d,bottom: 0.17198697636090654d,left: 0.13124430925376862d),
new NpgsqlTypes.NpgsqlBox(top: 0.4170903976913236d,right: 0.3801174729140142d,bottom: 0.18827395672049974d,left: 0.017758168280560205d),
new NpgsqlTypes.NpgsqlBox(top: 0.30162147745387924d,right: 0.5212977524036428d,bottom: 0.2918766485903944d,left: 0.398373051562829d),
new NpgsqlTypes.NpgsqlBox(top: 0.13039489115604963d,right: 0.30392640517192127d,bottom: 0.08221465896258784d,left: 0.2712867367698306d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.04650963909045558d,right: 0.5596658136156357d,bottom: 0.005828883510951788d,left: 0.15297303295762077d),
new NpgsqlTypes.NpgsqlBox(top: 0.46056913374078867d,right: 0.23516546912049763d,bottom: 0.27550021033917627d,left: 0.09229893472044881d),
new NpgsqlTypes.NpgsqlBox(top: 0.38653916351842377d,right: 0.7729942413069737d,bottom: 0.27082435643260394d,left: 0.41390099321451124d),
new NpgsqlTypes.NpgsqlBox(top: 0.7346220216908831d,right: 0.8503542128739146d,bottom: 0.37613284548184533d,left: 0.5237165060323723d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 62,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7976702843093204d,right: 0.30267952510956386d,bottom: 0.1768176965642032d,left: 0.19498146044621711d),
new NpgsqlTypes.NpgsqlBox(top: 0.5530221604005573d,right: 0.10107226890584431d,bottom: 0.48598910627207625d,left: 0.06991215028707087d),
new NpgsqlTypes.NpgsqlBox(top: 0.32429571990158035d,right: 0.6480408401958705d,bottom: 0.06569905308523871d,left: 0.22232328121756972d),
new NpgsqlTypes.NpgsqlBox(top: 0.9494316510580151d,right: 0.478396630926225d,bottom: 0.9313634941662523d,left: 0.29220486549199287d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 35,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8397642457645513d,right: 0.9567314424667626d,bottom: 0.6042458762575145d,left: 0.4317063549292258d),
new NpgsqlTypes.NpgsqlBox(top: 0.9301376608793593d,right: 0.7101892913551294d,bottom: 0.01826700406839077d,left: 0.3307695253301378d),
new NpgsqlTypes.NpgsqlBox(top: 0.6809666552583415d,right: 0.6268151697542688d,bottom: 0.08230995620561843d,left: 0.5589986169499909d),
new NpgsqlTypes.NpgsqlBox(top: 0.38451761273923446d,right: 0.8840505314799767d,bottom: 0.3748786226957821d,left: 0.2651084080966797d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9545878124002704d,right: 0.6380883465475474d,bottom: 0.32997005627030285d,left: 0.22463704808198048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8797324254498966d,right: 0.9392446922783845d,bottom: 0.3476114625866449d,left: 0.24914002255119339d),
new NpgsqlTypes.NpgsqlBox(top: 0.2941127095115761d,right: 0.9626074717441807d,bottom: 0.07956764318128018d,left: 0.07313971961214583d),
new NpgsqlTypes.NpgsqlBox(top: 0.6002314872917437d,right: 0.13132808301458088d,bottom: 0.49720553022052694d,left: 0.12145476982502956d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 65,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9612300932848727d,right: 0.49073253960437246d,bottom: 0.9441795830531388d,left: 0.04787458239871123d),
new NpgsqlTypes.NpgsqlBox(top: 0.8412201298767735d,right: 0.4052704122342483d,bottom: 0.6776845805363502d,left: 0.21221404510067343d),
new NpgsqlTypes.NpgsqlBox(top: 0.7488384569283321d,right: 0.29658912472601195d,bottom: 0.30165690636332d,left: 0.020124004323224476d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 74,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.90572468527422d,right: 0.6814217083386926d,bottom: 0.8224599187893618d,left: 0.5522038096899516d),
new NpgsqlTypes.NpgsqlBox(top: 0.8061531872825023d,right: 0.6423444143132538d,bottom: 0.2745094381920269d,left: 0.23388234709943023d),
new NpgsqlTypes.NpgsqlBox(top: 0.3871425484980241d,right: 0.6019544988181702d,bottom: 0.25467543396343273d,left: 0.04196715593466327d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 42,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6487880349659687d,right: 0.5414524273115675d,bottom: 0.05815675814216004d,left: 0.1275291857775901d),
new NpgsqlTypes.NpgsqlBox(top: 0.3678731419406188d,right: 0.6987765261409761d,bottom: 0.21050652223003685d,left: 0.5342783873570459d),
new NpgsqlTypes.NpgsqlBox(top: 0.313257242148651d,right: 0.9582535388650769d,bottom: 0.08865764493853656d,left: 0.4975974747198857d),
new NpgsqlTypes.NpgsqlBox(top: 0.6104541052438248d,right: 0.797251246047203d,bottom: 0.4491143309153338d,left: 0.1416512782887357d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 82,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.915147282290755d,right: 0.8153209346812229d,bottom: 0.17021520913550048d,left: 0.02158918268224619d),
new NpgsqlTypes.NpgsqlBox(top: 0.43650640608332936d,right: 0.7931560331440946d,bottom: 0.39259257276469917d,left: 0.1615181352802516d),
new NpgsqlTypes.NpgsqlBox(top: 0.6938969744063571d,right: 0.7730538040191559d,bottom: 0.5295259848954439d,left: 0.6324475062700755d),
new NpgsqlTypes.NpgsqlBox(top: 0.8796645658252461d,right: 0.7784150389419353d,bottom: 0.35842990746327175d,left: 0.7247832008437025d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6929005976275714d,right: 0.8445823559043095d,bottom: 0.5239105031881676d,left: 0.5968698471434652d),
new NpgsqlTypes.NpgsqlBox(top: 0.218133122840947d,right: 0.907072202879669d,bottom: 0.1514791434564855d,left: 0.41498870941943944d),
new NpgsqlTypes.NpgsqlBox(top: 0.672225725142285d,right: 0.42254033738265684d,bottom: 0.38812941310619875d,left: 0.3712198845170396d),
new NpgsqlTypes.NpgsqlBox(top: 0.7094399144672506d,right: 0.8580470951309658d,bottom: 0.36676087440713834d,left: 0.4315322558361885d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 85,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9978275619210921d,right: 0.901078862177582d,bottom: 0.3432274217702491d,left: 0.7570284289298407d),
new NpgsqlTypes.NpgsqlBox(top: 0.6723029737615356d,right: 0.44768457604405676d,bottom: 0.5482688504245947d,left: 0.37624801517941864d),
new NpgsqlTypes.NpgsqlBox(top: 0.032323519765721676d,right: 0.7610859452131835d,bottom: 0.016983654663994097d,left: 0.24737528324105762d),
new NpgsqlTypes.NpgsqlBox(top: 0.6756971066120105d,right: 0.7214534392451678d,bottom: 0.3822168918742753d,left: 0.717078336240638d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 49,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9009701265715352d,right: 0.5674399917958424d,bottom: 0.4158364859675687d,left: 0.09582995525296412d),
new NpgsqlTypes.NpgsqlBox(top: 0.9075611163907792d,right: 0.57845028447658d,bottom: 0.35826746249217367d,left: 0.09132417209568233d),
new NpgsqlTypes.NpgsqlBox(top: 0.9660678652138653d,right: 0.8423721606707777d,bottom: 0.1958000239130281d,left: 0.16026187891915622d),
new NpgsqlTypes.NpgsqlBox(top: 0.8432143744378862d,right: 0.4462652779855112d,bottom: 0.4088056226659451d,left: 0.34184622914872764d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.3166156112362625d,right: 0.5004833118290059d,bottom: 0.1327838053526037d,left: 0.3376010030914198d),
new NpgsqlTypes.NpgsqlBox(top: 0.33501736995686915d,right: 0.4905284996524405d,bottom: 0.16007492404932144d,left: 0.3055000830356873d),
new NpgsqlTypes.NpgsqlBox(top: 0.7333623050786382d,right: 0.9640599839692829d,bottom: 0.3693350963049171d,left: 0.1541137659366586d),
new NpgsqlTypes.NpgsqlBox(top: 0.6652012280972495d,right: 0.812296187987628d,bottom: 0.4064176281448737d,left: 0.056905816454642766d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 88,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.819868876376124d,right: 0.9237557232691246d,bottom: 0.1436804799948005d,left: 0.6657392436332198d),
new NpgsqlTypes.NpgsqlBox(top: 0.9806033192095553d,right: 0.9521470050993531d,bottom: 0.29446960859773164d,left: 0.022476950753484437d),
new NpgsqlTypes.NpgsqlBox(top: 0.9618259307512761d,right: 0.5019470068554115d,bottom: 0.3390905459871284d,left: 0.24962061971346172d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 96,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.505922722393571d,right: 0.8299328710250556d,bottom: 0.11538168920904823d,left: 0.4641966701711997d),
new NpgsqlTypes.NpgsqlBox(top: 0.5015891287038482d,right: 0.5937918193406952d,bottom: 0.006159615044146527d,left: 0.39977796922347564d),
new NpgsqlTypes.NpgsqlBox(top: 0.9409283516808228d,right: 0.14338705511871108d,bottom: 0.732692460003933d,left: 0.0068001334594423035d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 53,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7882627849401759d,right: 0.1164870785540374d,bottom: 0.13728094959743986d,left: 0.062300796208476394d),
new NpgsqlTypes.NpgsqlBox(top: 0.6485858267883413d,right: 0.5012009257488487d,bottom: 0.18419769127566255d,left: 0.29621667906163074d),
new NpgsqlTypes.NpgsqlBox(top: 0.8767594470301986d,right: 0.6837260344492813d,bottom: 0.6630843185228498d,left: 0.2481176116570818d),
new NpgsqlTypes.NpgsqlBox(top: 0.5741893698854922d,right: 0.702341806834702d,bottom: 0.2350497810008486d,left: 0.2159015316502343d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.986741099639092d,right: 0.7735092967904247d,bottom: 0.8015505787276467d,left: 0.5227536447714612d),
new NpgsqlTypes.NpgsqlBox(top: 0.3180212577009657d,right: 0.8425581812098207d,bottom: 0.08451710038474791d,left: 0.6652435729164938d),
new NpgsqlTypes.NpgsqlBox(top: 0.39208029933494193d,right: 0.42703375317897285d,bottom: 0.1399076728727654d,left: 0.22332323731708015d),
new NpgsqlTypes.NpgsqlBox(top: 0.4926371018758383d,right: 0.7779092496959729d,bottom: 0.07082032005957217d,left: 0.4238247622068645d),
},
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.517919701748203d,right: 0.7444128541147645d,bottom: 0.10205819129700133d,left: 0.04866016408050089d),
new NpgsqlTypes.NpgsqlBox(top: 0.711846140411891d,right: 0.8462898987212777d,bottom: 0.362180170539689d,left: 0.1279258587174501d),
new NpgsqlTypes.NpgsqlBox(top: 0.8617042433120685d,right: 0.17692055456756828d,bottom: 0.15556295816929688d,left: 0.05929591271538637d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 103,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.41865815265507356d,right: 0.8826455884150955d,bottom: 0.246353407854788d,left: 0.13302916027010392d),
new NpgsqlTypes.NpgsqlBox(top: 0.3309126079710494d,right: 0.7698685165467736d,bottom: 0.24188825305898798d,left: 0.3344893819220728d),
new NpgsqlTypes.NpgsqlBox(top: 0.22406900378184413d,right: 0.6945192084436504d,bottom: 0.13184552464623356d,left: 0.5317301832387383d),
new NpgsqlTypes.NpgsqlBox(top: 0.5055382795492686d,right: 0.709463039532797d,bottom: 0.400574749001135d,left: 0.31365542986448314d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4327036675119873d,right: 0.2848512485771689d,bottom: 0.03687817424839501d,left: 0.11183791798572928d),
new NpgsqlTypes.NpgsqlBox(top: 0.34761743073281093d,right: 0.7140780946330147d,bottom: 0.10455175991409527d,left: 0.07243516232734726d),
new NpgsqlTypes.NpgsqlBox(top: 0.9718782109976114d,right: 0.7896548913036466d,bottom: 0.2553942176501355d,left: 0.5952528835716301d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 106,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.670501450559454d,right: 0.2539894991851982d,bottom: 0.2019963467087339d,left: 0.12089336541994244d),
new NpgsqlTypes.NpgsqlBox(top: 0.6137779670289206d,right: 0.3299060621370812d,bottom: 0.031226958441318176d,left: 0.10646512395487384d),
new NpgsqlTypes.NpgsqlBox(top: 0.9785448221234951d,right: 0.8681073968907492d,bottom: 0.9675847161285441d,left: 0.7295848128587392d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 58,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7495722200473554d,right: 0.33274585066189055d,bottom: 0.6139421782028741d,left: 0.04125932598745097d),
new NpgsqlTypes.NpgsqlBox(top: 0.9103040487135328d,right: 0.5461326594578219d,bottom: 0.5510118683795903d,left: 0.4236708133109217d),
new NpgsqlTypes.NpgsqlBox(top: 0.9022912197154399d,right: 0.9577589418290257d,bottom: 0.2835933811827863d,left: 0.5946360736525925d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 109,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.26018126637350003d,right: 0.4506272117278589d,bottom: 0.131635300064332d,left: 0.11270724669164578d),
new NpgsqlTypes.NpgsqlBox(top: 0.30745379441459897d,right: 0.3742695375148819d,bottom: 0.237266419125837d,left: 0.3586960714022861d),
new NpgsqlTypes.NpgsqlBox(top: 0.33782576885664906d,right: 0.5426405531723311d,bottom: 0.15989518516961176d,left: 0.5041697010750874d),
new NpgsqlTypes.NpgsqlBox(top: 0.7737653835098885d,right: 0.8118175914943028d,bottom: 0.49727326850784626d,left: 0.29799459395478867d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 116,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5641766262513107d,right: 0.858942019583501d,bottom: 0.402680271238705d,left: 0.2735024140215593d),
new NpgsqlTypes.NpgsqlBox(top: 0.5686450539939697d,right: 0.3927078646486043d,bottom: 0.5573566246534432d,left: 0.15329121957200154d),
new NpgsqlTypes.NpgsqlBox(top: 0.597167454396788d,right: 0.8578107166408667d,bottom: 0.018828028742538527d,left: 0.31129139110050974d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 63,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6059480146864453d,right: 0.9728825685729386d,bottom: 0.05911415426592348d,left: 0.17238526493529316d),
new NpgsqlTypes.NpgsqlBox(top: 0.9575668249075536d,right: 0.3777302649623302d,bottom: 0.7462118594263948d,left: 0.08054331452816621d),
new NpgsqlTypes.NpgsqlBox(top: 0.44916479509226725d,right: 0.9318608456391775d,bottom: 0.25117984258439574d,left: 0.7802349679553486d),
new NpgsqlTypes.NpgsqlBox(top: 0.9703356411953574d,right: 0.29725452042666345d,bottom: 0.9097503420790987d,left: 0.2967609764460545d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.25761534449729795d,right: 0.39988315709217304d,bottom: 0.06463500299792946d,left: 0.024860730831143596d),
new NpgsqlTypes.NpgsqlBox(top: 0.9913736603317773d,right: 0.7557312765315211d,bottom: 0.35260627466826167d,left: 0.29307261174408483d),
new NpgsqlTypes.NpgsqlBox(top: 0.17213349765227426d,right: 0.5777091701529028d,bottom: 0.08666081695666239d,left: 0.32197537591021874d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 122,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6598967909836476d,right: 0.5839185824159232d,bottom: 0.06413864588553986d,left: 0.44021801227558177d),
new NpgsqlTypes.NpgsqlBox(top: 0.6510329882382224d,right: 0.7676516774623054d,bottom: 0.6157553003002358d,left: 0.617405718757858d),
new NpgsqlTypes.NpgsqlBox(top: 0.9582551751874389d,right: 0.46617920935349133d,bottom: 0.10015414401641232d,left: 0.32221638170780786d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 127,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9830965361748657d,right: 0.8385462065194411d,bottom: 0.9427609998572953d,left: 0.2752976642853463d),
new NpgsqlTypes.NpgsqlBox(top: 0.23293332343102024d,right: 0.942074933349522d,bottom: 0.05759888067198249d,left: 0.7312879040551832d),
new NpgsqlTypes.NpgsqlBox(top: 0.5208100408778374d,right: 0.17977488066768166d,bottom: 0.4110456965844277d,left: 0.04439526003529015d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 71,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.1733750790530595d,right: 0.46253726692711694d,bottom: 0.016206679325772244d,left: 0.152018505346885d),
new NpgsqlTypes.NpgsqlBox(top: 0.8123849053547848d,right: 0.7411867801952292d,bottom: 0.7820795202129128d,left: 0.611195036694515d),
new NpgsqlTypes.NpgsqlBox(top: 0.31316777254779793d,right: 0.74020236488954d,bottom: 0.21399323975018436d,left: 0.23691146963791043d),
new NpgsqlTypes.NpgsqlBox(top: 0.7154375823274411d,right: 0.8567386391224616d,bottom: 0.47572874078425864d,left: 0.1294306445104575d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.4630927373782626d,right: 0.8422116351189868d,bottom: 0.05323600775852366d,left: 0.49748557825810247d),
new NpgsqlTypes.NpgsqlBox(top: 0.9895906431242445d,right: 0.9309478321963953d,bottom: 0.8660523347770512d,left: 0.19007695098742106d),
new NpgsqlTypes.NpgsqlBox(top: 0.5752578956010034d,right: 0.9429489545740115d,bottom: 0.44937301023961307d,left: 0.3352007724545264d),
new NpgsqlTypes.NpgsqlBox(top: 0.3281693266517417d,right: 0.9085403731300498d,bottom: 0.09035333897479525d,left: 0.0804656220550446d),
},
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 136,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.18035460025993444d,right: 0.8104580278717094d,bottom: 0.0025303405780894295d,left: 0.5603939000968425d),
new NpgsqlTypes.NpgsqlBox(top: 0.6010193959494671d,right: 0.8654686894713398d,bottom: 0.40467121512240545d,left: 0.0624281931243269d),
new NpgsqlTypes.NpgsqlBox(top: 0.7438386697072779d,right: 0.9088782091226516d,bottom: 0.5435669930456408d,left: 0.08384635700979526d),
},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 144,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7413784221417462d,right: 0.7516808499312306d,bottom: 0.5585045834778535d,left: 0.33470343734155805d),
new NpgsqlTypes.NpgsqlBox(top: 0.7433160826075462d,right: 0.6237765739882377d,bottom: 0.03950599482323636d,left: 0.3523851764679322d),
new NpgsqlTypes.NpgsqlBox(top: 0.7501772469612621d,right: 0.5297646448054466d,bottom: 0.18325604339626012d,left: 0.0604696880343798d),
new NpgsqlTypes.NpgsqlBox(top: 0.6482445641046323d,right: 0.8300077501773524d,bottom: 0.6105734493156796d,left: 0.5401621838244403d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 76,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.5916126464254963d,right: 0.41722999356024326d,bottom: 0.33451165580106357d,left: 0.04915419148958167d),
new NpgsqlTypes.NpgsqlBox(top: 0.8840038976380497d,right: 0.8842408444315886d,bottom: 0.0282550327539981d,left: 0.12998965554958553d),
new NpgsqlTypes.NpgsqlBox(top: 0.38399399937224765d,right: 0.8174390949998019d,bottom: 0.23201551828799716d,left: 0.2996873361629977d),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlBoxboxArray1M
{
    Id = 151,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8938543768552477d,right: 0.6958841190829217d,bottom: 0.35866062239761054d,left: 0.6663813581067274d),
new NpgsqlTypes.NpgsqlBox(top: 0.597164652248517d,right: 0.7069528960453093d,bottom: 0.16870025339567507d,left: 0.018842690316850264d),
new NpgsqlTypes.NpgsqlBox(top: 0.784033077511246d,right: 0.7948328236008098d,bottom: 0.6720787017763273d,left: 0.6501395765635131d),
new NpgsqlTypes.NpgsqlBox(top: 0.9092938101020155d,right: 0.49791276789997385d,bottom: 0.7109529643878237d,left: 0.4505533975944894d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8329964243373221d,right: 0.9184891360722515d,bottom: 0.5700458666435905d,left: 0.3820527580165829d),
new NpgsqlTypes.NpgsqlBox(top: 0.9616817375039044d,right: 0.7087133944230414d,bottom: 0.0952685244581215d,left: 0.49102718540230406d),
new NpgsqlTypes.NpgsqlBox(top: 0.7682303364102755d,right: 0.912635819880766d,bottom: 0.6656011662021032d,left: 0.7230405348850207d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 155,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.17206158405550065d,right: 0.9843014111899959d,bottom: 0.028282190869572177d,left: 0.13308845499303879d),
new NpgsqlTypes.NpgsqlBox(top: 0.35289915551173523d,right: 0.9849444540907674d,bottom: 0.3112024721111555d,left: 0.9825640978429611d),
new NpgsqlTypes.NpgsqlBox(top: 0.3337760851227609d,right: 0.9873831370459255d,bottom: 0.16200674681084382d,left: 0.8150630088352951d),
new NpgsqlTypes.NpgsqlBox(top: 0.8607114265487267d,right: 0.12913411844422518d,bottom: 0.16371129706569632d,left: 0.007788299938422005d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 77,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7763921060585387d,right: 0.9696982670113544d,bottom: 0.6562331041940376d,left: 0.50972467950043d),
new NpgsqlTypes.NpgsqlBox(top: 0.6759409297165463d,right: 0.4717960825923472d,bottom: 0.572351358625842d,left: 0.4704495327074285d),
new NpgsqlTypes.NpgsqlBox(top: 0.775271662861534d,right: 0.8677509011865325d,bottom: 0.71648751408549d,left: 0.26913990474522653d),
},
    NullableValue = null,
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7525992532237464d,right: 0.3300212834606049d,bottom: 0.5777687282394571d,left: 0.31237013449749185d),
new NpgsqlTypes.NpgsqlBox(top: 0.698394484984228d,right: 0.1769348620516421d,bottom: 0.3489603011550726d,left: 0.13372418085324467d),
new NpgsqlTypes.NpgsqlBox(top: 0.2947818681739849d,right: 0.7465028944438276d,bottom: 0.1289354501015908d,left: 0.12262393138557459d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 164,
    Value = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.31163752402286526d,right: 0.5667535358734268d,bottom: 0.2535479352396911d,left: 0.044925727297150164d),
new NpgsqlTypes.NpgsqlBox(top: 0.7643168958373033d,right: 0.5360588351480395d,bottom: 0.4477447169916745d,left: 0.1558489477964673d),
new NpgsqlTypes.NpgsqlBox(top: 0.5845786866363711d,right: 0.9430117932048132d,bottom: 0.5436180314111897d,left: 0.9036041222582528d),
},
    ModelInner = null,
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.7057593034648298d,right: 0.3011213456959121d,bottom: 0.6556508667231148d,left: 0.05395232179198717d),
new NpgsqlTypes.NpgsqlBox(top: 0.784883839948575d,right: 0.8121109355233573d,bottom: 0.049772638567528116d,left: 0.7319810023784914d),
new NpgsqlTypes.NpgsqlBox(top: 0.1302507160030888d,right: 0.48906172491737976d,bottom: 0.03131880728280023d,left: 0.18083529082951488d),
},
},
            new NpgsqlBoxboxArray1M
{
    Id = 172,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6271576548986879d,right: 0.6143805340956765d,bottom: 0.16849115213231747d,left: 0.11994607240965671d),
new NpgsqlTypes.NpgsqlBox(top: 0.8995017190606471d,right: 0.9438234896675614d,bottom: 0.1770228610144341d,left: 0.018645081787582063d),
new NpgsqlTypes.NpgsqlBox(top: 0.880312530776249d,right: 0.41067545395157024d,bottom: 0.08868751274016928d,left: 0.2420416339567214d),
new NpgsqlTypes.NpgsqlBox(top: 0.6172142952177108d,right: 0.18360168742320593d,bottom: 0.30382195535613266d,left: 0.10919825282970252d),
},
    ModelInner = new NpgsqlBoxboxArray1MI
{
    Id = 84,
    Value = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9423355913809708d,right: 0.6964254715505914d,bottom: 0.35014684870126234d,left: 0.517022927449087d),
new NpgsqlTypes.NpgsqlBox(top: 0.7998046194941886d,right: 0.693111161843794d,bottom: 0.1372013378269762d,left: 0.208892251368895d),
new NpgsqlTypes.NpgsqlBox(top: 0.758326397407617d,right: 0.8253914572194319d,bottom: 0.4254534180292492d,left: 0.040259336776470867d),
new NpgsqlTypes.NpgsqlBox(top: 0.7764736345676853d,right: 0.8100239957698067d,bottom: 0.02509064904280567d,left: 0.11032571329637753d),
},
    NullableValue = 
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.8584147554913327d,right: 0.7393468278670032d,bottom: 0.34446226731468965d,left: 0.25410983247626895d),
new NpgsqlTypes.NpgsqlBox(top: 0.9477750089990197d,right: 0.7482377553498509d,bottom: 0.1944880483406335d,left: 0.15747333270462638d),
new NpgsqlTypes.NpgsqlBox(top: 0.8653257895228242d,right: 0.7533188974697893d,bottom: 0.07136400684260114d,left: 0.4761803141765688d),
new NpgsqlTypes.NpgsqlBox(top: 0.5342684095448058d,right: 0.3632525779544342d,bottom: 0.0524724081682042d,left: 0.009778589492477563d),
},
},
    NullableValue = null,
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
                Assert.That(nullable, Is.Null);
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
new NpgsqlTypes.NpgsqlBox(top: 0.6034274124839237d,right: 0.7318620647050875d,bottom: 0.5503429719042372d,left: 0.5304564787906925d),
new NpgsqlTypes.NpgsqlBox(top: 0.6177285254995206d,right: 0.8384726483148238d,bottom: 0.3266297796846017d,left: 0.5539142854369895d),
new NpgsqlTypes.NpgsqlBox(top: 0.631887527145945d,right: 0.8146509866939016d,bottom: 0.6112429727435715d,left: 0.6151295457717012d),
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[3]
{
new NpgsqlTypes.NpgsqlBox(top: 0.6356381713347408d,right: 0.7278225554842537d,bottom: 0.41643308515201183d,left: 0.5818226766496348d),
new NpgsqlTypes.NpgsqlBox(top: 0.9624523757766952d,right: 0.5369267250977033d,bottom: 0.3921846250935421d,left: 0.14308219023338054d),
new NpgsqlTypes.NpgsqlBox(top: 0.8404661421871673d,right: 0.7547458638489286d,bottom: 0.7491928056219938d,left: 0.5017911763819966d),
}));
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
new NpgsqlTypes.NpgsqlBox(top: 0.6094508427243176d,right: 0.8803623571709116d,bottom: 0.5031432875765355d,left: 0.1081213437646853d),
new NpgsqlTypes.NpgsqlBox(top: 0.8403814018437398d,right: 0.886669886848007d,bottom: 0.19921390378472137d,left: 0.40713104118546195d),
new NpgsqlTypes.NpgsqlBox(top: 0.5764300823986619d,right: 0.7032258912089461d,bottom: 0.2324755222105651d,left: 0.1520987901963362d),
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
new NpgsqlTypes.NpgsqlBox(top: 0.04650963909045558d,right: 0.5596658136156357d,bottom: 0.005828883510951788d,left: 0.15297303295762077d),
new NpgsqlTypes.NpgsqlBox(top: 0.46056913374078867d,right: 0.23516546912049763d,bottom: 0.27550021033917627d,left: 0.09229893472044881d),
new NpgsqlTypes.NpgsqlBox(top: 0.38653916351842377d,right: 0.7729942413069737d,bottom: 0.27082435643260394d,left: 0.41390099321451124d),
new NpgsqlTypes.NpgsqlBox(top: 0.7346220216908831d,right: 0.8503542128739146d,bottom: 0.37613284548184533d,left: 0.5237165060323723d),
}));
                nullable = await ((INpgsqlBoxArrayboxArray)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new NpgsqlTypes.NpgsqlBox[4]
{
new NpgsqlTypes.NpgsqlBox(top: 0.9545878124002704d,right: 0.6380883465475474d,bottom: 0.32997005627030285d,left: 0.22463704808198048d),
new NpgsqlTypes.NpgsqlBox(top: 0.8797324254498966d,right: 0.9392446922783845d,bottom: 0.3476114625866449d,left: 0.24914002255119339d),
new NpgsqlTypes.NpgsqlBox(top: 0.2941127095115761d,right: 0.9626074717441807d,bottom: 0.07956764318128018d,left: 0.07313971961214583d),
new NpgsqlTypes.NpgsqlBox(top: 0.6002314872917437d,right: 0.13132808301458088d,bottom: 0.49720553022052694d,left: 0.12145476982502956d),
}));
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 40;
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
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 151;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[29], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 127;
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
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[29], false);
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
                parametr1.Value = 127;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
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
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
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
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(2));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
                parametr1.Value = 32;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[29], false);
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
                parametr1.Value = 116;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 88;
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
                Assert.That(firstItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[29], false);
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
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[3], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[4], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[5], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[24],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[25],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 62;
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[29], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 22, query1, 13, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[26],_testData[29], false);
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 49, query1, 96, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 82, query1, 103, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[29], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 7, query1, 22, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[24],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 22, query1, 65, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[5], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[6], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[7], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[8], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[20],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[21],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[22],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[23],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[24],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                await ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 74, query1, 46, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(secondItems2[20],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 49, query1, 144, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlBoxboxArray1M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(models[3],_testData[29], false);
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
                 ((INpgsqlBoxArrayboxArray)this).DbConnectionDynQuerySelectModelBatch(connection, 49, query1, 136, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlBoxboxArray1M.AssertModel(firstItems1[19],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatchAsync(connection, 136, 31))
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
                        Assert.That(models, Has.Count.EqualTo(24));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[6], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[23],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlBoxArrayboxArray)this).DbConnectionSTSelectModelBatch(connection, 32, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[7], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[8], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[9], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[10], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[11], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[12], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[13], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[14], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[15], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[16], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[17], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[18], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[19], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[20], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[21], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[21],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[22],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[22], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[23], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[24], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[25], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[26], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[27], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[28], false);
                        NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[29], false);
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
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 65);
                var models = await ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(17));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlBoxArrayboxArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlBoxArrayboxArray)this).SetDbConnectionSelectModelParametrs(cmd, 46);
                var models =  ((INpgsqlBoxArrayboxArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(21));
NpgsqlBoxboxArray1M.AssertModel(models[0],_testData[9], false);NpgsqlBoxboxArray1M.AssertModel(models[1],_testData[10], false);NpgsqlBoxboxArray1M.AssertModel(models[2],_testData[11], false);NpgsqlBoxboxArray1M.AssertModel(models[3],_testData[12], false);NpgsqlBoxboxArray1M.AssertModel(models[4],_testData[13], false);NpgsqlBoxboxArray1M.AssertModel(models[5],_testData[14], false);NpgsqlBoxboxArray1M.AssertModel(models[6],_testData[15], false);NpgsqlBoxboxArray1M.AssertModel(models[7],_testData[16], false);NpgsqlBoxboxArray1M.AssertModel(models[8],_testData[17], false);NpgsqlBoxboxArray1M.AssertModel(models[9],_testData[18], false);NpgsqlBoxboxArray1M.AssertModel(models[10],_testData[19], false);NpgsqlBoxboxArray1M.AssertModel(models[11],_testData[20], false);NpgsqlBoxboxArray1M.AssertModel(models[12],_testData[21], false);NpgsqlBoxboxArray1M.AssertModel(models[13],_testData[22], false);NpgsqlBoxboxArray1M.AssertModel(models[14],_testData[23], false);NpgsqlBoxboxArray1M.AssertModel(models[15],_testData[24], false);NpgsqlBoxboxArray1M.AssertModel(models[16],_testData[25], false);NpgsqlBoxboxArray1M.AssertModel(models[17],_testData[26], false);NpgsqlBoxboxArray1M.AssertModel(models[18],_testData[27], false);NpgsqlBoxboxArray1M.AssertModel(models[19],_testData[28], false);NpgsqlBoxboxArray1M.AssertModel(models[20],_testData[29], false);
            }
        }

#endregion

#region BinaryImportModelInner

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

