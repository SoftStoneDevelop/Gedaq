

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
    internal partial interface INpgsqlLineListlineListD1
    {
    }
    
    internal partial class NpgsqlLineListlineListD1 : INpgsqlLineListlineListD1
    {


#region TestData

        private readonly NpgsqlLinelineListD1E2M[] _testData = new NpgsqlLinelineListD1E2M[]
        {
            new NpgsqlLinelineListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9980129864131938d, b: 0.5131123408411435d, c: 0.21639633379145118d),

new NpgsqlTypes.NpgsqlLine(a: 0.1238106910218183d, b: 0.3313765956740624d, c: 0.7426094598543187d),

new NpgsqlTypes.NpgsqlLine(a: 0.644228872071694d, b: 0.9433515421624927d, c: 0.5502923259264499d),

new NpgsqlTypes.NpgsqlLine(a: 0.25849836882817123d, b: 0.36862711857138786d, c: 0.2420717673704582d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9384006184994894d, b: 0.9076742155731612d, c: 0.6791967712291556d),

new NpgsqlTypes.NpgsqlLine(a: 0.283330384953171d, b: 0.5434790430545582d, c: 0.49193275217210763d),

new NpgsqlTypes.NpgsqlLine(a: 0.08966658393670701d, b: 0.886357657884844d, c: 0.6956682607017062d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12616807734814406d, b: 0.415529732515183d, c: 0.889333920481003d),

new NpgsqlTypes.NpgsqlLine(a: 0.9036042156999513d, b: 0.7261329418519928d, c: 0.48705060651956766d),

new NpgsqlTypes.NpgsqlLine(a: 0.07489539965869862d, b: 0.03574491536601687d, c: 0.3301004172393074d),

new NpgsqlTypes.NpgsqlLine(a: 0.2547698770798976d, b: 0.05303406490534346d, c: 0.5076012118177917d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6966130655605206d, b: 0.5100047476166999d, c: 0.01980805891101778d),

new NpgsqlTypes.NpgsqlLine(a: 0.45365156583080235d, b: 0.7783732455492809d, c: 0.6230157565341029d),

new NpgsqlTypes.NpgsqlLine(a: 0.4056542926150183d, b: 0.6143758408051205d, c: 0.4529339758540718d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6862881507534859d, b: 0.3251905988196243d, c: 0.530636981970662d),

new NpgsqlTypes.NpgsqlLine(a: 0.9884809522590953d, b: 0.4442807950692095d, c: 0.433086174556944d),

new NpgsqlTypes.NpgsqlLine(a: 0.8273106555441518d, b: 0.5345636205905999d, c: 0.9151076688080086d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3617711170022777d, b: 0.36666619276030354d, c: 0.7479147959140771d),

new NpgsqlTypes.NpgsqlLine(a: 0.6776099173040054d, b: 0.8582394381958895d, c: 0.9994136367778164d),

new NpgsqlTypes.NpgsqlLine(a: 0.20159711798469881d, b: 0.9528882453324032d, c: 0.6229577495167394d),

new NpgsqlTypes.NpgsqlLine(a: 0.8575484720012577d, b: 0.5429267186101553d, c: 0.6916692958131236d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1250729432486536d, b: 0.2170601423739541d, c: 0.10534973755923227d),

new NpgsqlTypes.NpgsqlLine(a: 0.7436878434308724d, b: 0.942042921940307d, c: 0.3824379120783916d),

new NpgsqlTypes.NpgsqlLine(a: 0.21137091945180153d, b: 0.05997802282331932d, c: 0.2606360193242587d),

new NpgsqlTypes.NpgsqlLine(a: 0.20172822716215966d, b: 0.09637072854831985d, c: 0.5147102226032969d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8741723508727226d, b: 0.3159846529004363d, c: 0.274915639051021d),

new NpgsqlTypes.NpgsqlLine(a: 0.38955481991014784d, b: 0.5936697303173684d, c: 0.7280933192157955d),

new NpgsqlTypes.NpgsqlLine(a: 0.7525800350649163d, b: 0.9984174518631442d, c: 0.16336645964731933d),

new NpgsqlTypes.NpgsqlLine(a: 0.9806183054452751d, b: 0.6426711591542182d, c: 0.8174462099233973d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4033348752142808d, b: 0.14248458491658034d, c: 0.19899884885818164d),

new NpgsqlTypes.NpgsqlLine(a: 0.5106199538309598d, b: 0.4366361734694839d, c: 0.6122956931418316d),

new NpgsqlTypes.NpgsqlLine(a: 0.43905644665008925d, b: 0.6718197932617966d, c: 0.2954531015105374d),

new NpgsqlTypes.NpgsqlLine(a: 0.6007774235812829d, b: 0.4634074933179062d, c: 0.6816705630304492d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7665956131825279d, b: 0.11305176209128387d, c: 0.7516709862250713d),

new NpgsqlTypes.NpgsqlLine(a: 0.4253709076678066d, b: 0.04084035047680168d, c: 0.9844926322738213d),

new NpgsqlTypes.NpgsqlLine(a: 0.9918702510548955d, b: 0.9429665811739302d, c: 0.9033460102400235d),

new NpgsqlTypes.NpgsqlLine(a: 0.012528324974581562d, b: 0.6778434371581239d, c: 0.3760530106580726d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7680800425033314d, b: 0.8266117784979262d, c: 0.06149988474318291d),

new NpgsqlTypes.NpgsqlLine(a: 0.9592252011336619d, b: 0.32305132564624106d, c: 0.7722538296252281d),

new NpgsqlTypes.NpgsqlLine(a: 0.9399330421967832d, b: 0.4983190921290708d, c: 0.733102000804945d),

new NpgsqlTypes.NpgsqlLine(a: 0.5160839529056271d, b: 0.14868918998618375d, c: 0.5640090590221644d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6832754395855039d, b: 0.25208768587134767d, c: 0.4586677648706097d),

new NpgsqlTypes.NpgsqlLine(a: 0.5223765770575267d, b: 0.5205240405200391d, c: 0.9495762518273604d),

new NpgsqlTypes.NpgsqlLine(a: 0.49509692256422166d, b: 0.08269466904661571d, c: 0.24387339263661167d),

new NpgsqlTypes.NpgsqlLine(a: 0.46122800363072114d, b: 0.7098827367564811d, c: 0.013568862376759916d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6997881727565759d, b: 0.5848016792977837d, c: 0.370254925763149d),

new NpgsqlTypes.NpgsqlLine(a: 0.006789257111638913d, b: 0.8895511958655502d, c: 0.1767485520821147d),

new NpgsqlTypes.NpgsqlLine(a: 0.880882448060516d, b: 0.020777184855789055d, c: 0.6805890263929869d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9334382258082354d, b: 0.7643133488024723d, c: 0.5012410816039183d),

new NpgsqlTypes.NpgsqlLine(a: 0.20378352572221936d, b: 0.04859688110326077d, c: 0.498377311984309d),

new NpgsqlTypes.NpgsqlLine(a: 0.50611047292549d, b: 0.6283737236293301d, c: 0.3656447901683906d),

new NpgsqlTypes.NpgsqlLine(a: 0.5002498405311206d, b: 0.962779233121506d, c: 0.6366882448542778d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.046715113403714925d, b: 0.15875602348157114d, c: 0.9542853584462934d),

new NpgsqlTypes.NpgsqlLine(a: 0.46434204014413416d, b: 0.9737562492760289d, c: 0.3835516353464288d),

new NpgsqlTypes.NpgsqlLine(a: 0.06128249293446819d, b: 0.0961773132182504d, c: 0.3584013939923404d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35887497997953643d, b: 0.4116692093743465d, c: 0.1578952169061768d),

new NpgsqlTypes.NpgsqlLine(a: 0.35753739509945026d, b: 0.3149322504791837d, c: 0.041082280490671974d),

new NpgsqlTypes.NpgsqlLine(a: 0.7211974154555232d, b: 0.03654212928015199d, c: 0.21303281490266524d),

new NpgsqlTypes.NpgsqlLine(a: 0.3885078019796482d, b: 0.11550632153903195d, c: 0.9281851457172519d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9368600769006117d, b: 0.6171511299136082d, c: 0.5288428370660269d),

new NpgsqlTypes.NpgsqlLine(a: 0.12105401746356614d, b: 0.7148652966394455d, c: 0.7828487312623043d),

new NpgsqlTypes.NpgsqlLine(a: 0.512212416099046d, b: 0.5240619568319417d, c: 0.6292912938189574d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4620028171196676d, b: 0.028881518117934157d, c: 0.06310916909107644d),

new NpgsqlTypes.NpgsqlLine(a: 0.9311993027982775d, b: 0.5734543693550147d, c: 0.05642491665021876d),

new NpgsqlTypes.NpgsqlLine(a: 0.8334110999742054d, b: 0.9787435954389607d, c: 0.4194623542042827d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11471343030948111d, b: 0.7050034601420815d, c: 0.042888421379206676d),

new NpgsqlTypes.NpgsqlLine(a: 0.8652594554913353d, b: 0.6819356357654881d, c: 0.6957709653611732d),

new NpgsqlTypes.NpgsqlLine(a: 0.6500586114793674d, b: 0.36295677089433576d, c: 0.909544597197634d),

new NpgsqlTypes.NpgsqlLine(a: 0.17262485843209607d, b: 0.34053929492791435d, c: 0.8443100628649723d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.27421301112328045d, b: 0.36312871992511164d, c: 0.781742026861488d),

new NpgsqlTypes.NpgsqlLine(a: 0.3071975795183639d, b: 0.48155837248043476d, c: 0.8776914202941198d),

new NpgsqlTypes.NpgsqlLine(a: 0.7936471049678975d, b: 0.4573052903090743d, c: 0.1359451665834377d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3994223529063641d, b: 0.3140978621072461d, c: 0.7517119487954032d),

new NpgsqlTypes.NpgsqlLine(a: 0.2601868579088257d, b: 0.8846593326097909d, c: 0.979443259559641d),

new NpgsqlTypes.NpgsqlLine(a: 0.061581498692260817d, b: 0.07220808655671085d, c: 0.2279687604322015d),

new NpgsqlTypes.NpgsqlLine(a: 0.386846122244755d, b: 0.9068022191312513d, c: 0.9951263890178926d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04670266601703843d, b: 0.26053376251274774d, c: 0.46509897099029707d),

new NpgsqlTypes.NpgsqlLine(a: 0.048406458473923664d, b: 0.8993366000679742d, c: 0.27620969741824763d),

new NpgsqlTypes.NpgsqlLine(a: 0.5323890102937798d, b: 0.08054811418535812d, c: 0.9655183195283563d),

new NpgsqlTypes.NpgsqlLine(a: 0.3515891799525024d, b: 0.20870406820679044d, c: 0.9234729107320518d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2772320323174179d, b: 0.10477181474580577d, c: 0.2720593213490273d),

new NpgsqlTypes.NpgsqlLine(a: 0.024726227914521504d, b: 0.45961879068756517d, c: 0.3257346348667529d),

new NpgsqlTypes.NpgsqlLine(a: 0.5304605129466091d, b: 0.6898345770317944d, c: 0.1828137902580842d),

new NpgsqlTypes.NpgsqlLine(a: 0.2704752948216559d, b: 0.0017074335257682982d, c: 0.5123524416096463d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.49786371517088057d, b: 0.0422842241395146d, c: 0.1288041388546498d),

new NpgsqlTypes.NpgsqlLine(a: 0.9238460373490504d, b: 0.20909185652643003d, c: 0.9175947895785811d),

new NpgsqlTypes.NpgsqlLine(a: 0.7586643690132159d, b: 0.18788379044316061d, c: 0.17654808803788746d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8352828751635746d, b: 0.028351816673194863d, c: 0.538081954284696d),

new NpgsqlTypes.NpgsqlLine(a: 0.04662120619676613d, b: 0.7257128919088219d, c: 0.006555962507711954d),

new NpgsqlTypes.NpgsqlLine(a: 0.03641027221402704d, b: 0.9025014436679218d, c: 0.1129849441548344d),

new NpgsqlTypes.NpgsqlLine(a: 0.36706256856509456d, b: 0.3560688607511904d, c: 0.8880889118455096d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 65,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6396996802241987d, b: 0.21549582973619885d, c: 0.8625336195045129d),

new NpgsqlTypes.NpgsqlLine(a: 0.9314662339704124d, b: 0.32055585383021246d, c: 0.5737108258863339d),

new NpgsqlTypes.NpgsqlLine(a: 0.8266204831852694d, b: 0.25497365841324215d, c: 0.11831931606958968d),

new NpgsqlTypes.NpgsqlLine(a: 0.1488201881845188d, b: 0.5661035789725277d, c: 0.1518072831793873d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38358871952467555d, b: 0.9148282599634429d, c: 0.12212930414000711d),

new NpgsqlTypes.NpgsqlLine(a: 0.510349790293273d, b: 0.8555776563989074d, c: 0.5616071635907048d),

new NpgsqlTypes.NpgsqlLine(a: 0.06728602744065482d, b: 0.8212319647568249d, c: 0.3145473301569738d),

new NpgsqlTypes.NpgsqlLine(a: 0.167440464369919d, b: 0.8016802556858289d, c: 0.03797116805482059d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2640413569541298d, b: 0.544987502508374d, c: 0.7561918537734806d),

new NpgsqlTypes.NpgsqlLine(a: 0.34637039051857266d, b: 0.6821773782445993d, c: 0.4395594016672524d),

new NpgsqlTypes.NpgsqlLine(a: 0.459867051800376d, b: 0.1507268671126144d, c: 0.2998868041537246d),

new NpgsqlTypes.NpgsqlLine(a: 0.7877625490394347d, b: 0.6155053058338887d, c: 0.11086643816827735d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8383788361822071d, b: 0.3409273295237367d, c: 0.29125747813433434d),

new NpgsqlTypes.NpgsqlLine(a: 0.26018434957830017d, b: 0.19161870394820713d, c: 0.4189216868736708d),

new NpgsqlTypes.NpgsqlLine(a: 0.22561278352098524d, b: 0.6012561089314755d, c: 0.6760893791822977d),

new NpgsqlTypes.NpgsqlLine(a: 0.005325591183635292d, b: 0.06206666307310893d, c: 0.8753027556065213d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6274991701593844d, b: 0.9363376022788746d, c: 0.7950895060737896d),

new NpgsqlTypes.NpgsqlLine(a: 0.7745878322708789d, b: 0.1094089303772453d, c: 0.7414318165242519d),

new NpgsqlTypes.NpgsqlLine(a: 0.9308584567970465d, b: 0.4792171988972068d, c: 0.4659631277443985d),

new NpgsqlTypes.NpgsqlLine(a: 0.9995883371842131d, b: 0.3458244624843596d, c: 0.9581433271116989d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 36,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8529975673153729d, b: 0.23058218861368063d, c: 0.3647915548708154d),

new NpgsqlTypes.NpgsqlLine(a: 0.7883604284125247d, b: 0.5815026723802613d, c: 0.9487027197093252d),

new NpgsqlTypes.NpgsqlLine(a: 0.26812112908487806d, b: 0.8166715955134888d, c: 0.8718126312429413d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13575470362927466d, b: 0.22725682489056798d, c: 0.6816679375238502d),

new NpgsqlTypes.NpgsqlLine(a: 0.9723056141873638d, b: 0.563421725336236d, c: 0.6053256598068818d),

new NpgsqlTypes.NpgsqlLine(a: 0.41255639429078894d, b: 0.9706785456118874d, c: 0.8320035950840312d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24824714128371395d, b: 0.07547774997950607d, c: 0.8967498334133487d),

new NpgsqlTypes.NpgsqlLine(a: 0.8121937107153532d, b: 0.45923609692988765d, c: 0.5074015166847247d),

new NpgsqlTypes.NpgsqlLine(a: 0.9955329856339638d, b: 0.9641450015470177d, c: 0.3331903415692836d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5789542159679536d, b: 0.17604102644674946d, c: 0.005529858330387216d),

new NpgsqlTypes.NpgsqlLine(a: 0.2509820940328191d, b: 0.23072372921036088d, c: 0.5991396891699605d),

new NpgsqlTypes.NpgsqlLine(a: 0.49534328148569184d, b: 0.9831158990966047d, c: 0.47625502711389067d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7942120991318543d, b: 0.175329682605335d, c: 0.21597449080612718d),

new NpgsqlTypes.NpgsqlLine(a: 0.14831307705997254d, b: 0.6626498563553149d, c: 0.5739394651847697d),

new NpgsqlTypes.NpgsqlLine(a: 0.17216014528808732d, b: 0.23412070265791685d, c: 0.9990644073552357d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7544220942791677d, b: 0.6492380884004557d, c: 0.16657898565004792d),

new NpgsqlTypes.NpgsqlLine(a: 0.9742996989337498d, b: 0.23123251522880994d, c: 0.09153216898157113d),

new NpgsqlTypes.NpgsqlLine(a: 0.7162447922509168d, b: 0.0625288857187819d, c: 0.72389145957326d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8941764661027416d, b: 0.6092777590593021d, c: 0.9326961809269521d),

new NpgsqlTypes.NpgsqlLine(a: 0.6871942170200823d, b: 0.2554367642301627d, c: 0.08669469953955d),

new NpgsqlTypes.NpgsqlLine(a: 0.4080580854776994d, b: 0.6441092752280114d, c: 0.6932132016987645d),

new NpgsqlTypes.NpgsqlLine(a: 0.6606094772703739d, b: 0.055799985349911596d, c: 0.1015395992717647d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.77076681136755d, b: 0.4069236112990041d, c: 0.19814919854019608d),

new NpgsqlTypes.NpgsqlLine(a: 0.7506523124725359d, b: 0.5308628109862962d, c: 0.6222695637760652d),

new NpgsqlTypes.NpgsqlLine(a: 0.6186198170966528d, b: 0.8546939882861457d, c: 0.1978125218716119d),

new NpgsqlTypes.NpgsqlLine(a: 0.6872091076282765d, b: 0.08866990751747728d, c: 0.47737713936281956d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9184419482581881d, b: 0.6212273084488423d, c: 0.8146756441341818d),

new NpgsqlTypes.NpgsqlLine(a: 0.30399940918198953d, b: 0.6886007734060645d, c: 0.22394820647746694d),

new NpgsqlTypes.NpgsqlLine(a: 0.26696854350516097d, b: 0.9970933113112426d, c: 0.7376694085601774d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6629931979859219d, b: 0.7844729323292805d, c: 0.44065540634826394d),

new NpgsqlTypes.NpgsqlLine(a: 0.27082802220473545d, b: 0.06417776604370962d, c: 0.4587883615403625d),

new NpgsqlTypes.NpgsqlLine(a: 0.8548537545721228d, b: 0.44955587156084265d, c: 0.8345190801064322d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6129028278374635d, b: 0.2374288284862921d, c: 0.4553966392775577d),

new NpgsqlTypes.NpgsqlLine(a: 0.1481442689149668d, b: 0.47174247461626706d, c: 0.6399300175854585d),

new NpgsqlTypes.NpgsqlLine(a: 0.23886196062673537d, b: 0.012358419985805225d, c: 0.4960702038365016d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8090897488626924d, b: 0.7557191550489799d, c: 0.36962816123417164d),

new NpgsqlTypes.NpgsqlLine(a: 0.47421880818687046d, b: 0.9123611611279095d, c: 0.9968616116167774d),

new NpgsqlTypes.NpgsqlLine(a: 0.48696511084373384d, b: 0.35108214746479405d, c: 0.7077871721703834d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 107,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5069108869816524d, b: 0.6896104772435832d, c: 0.7524307440485379d),

new NpgsqlTypes.NpgsqlLine(a: 0.8284553221993558d, b: 0.1582975110624807d, c: 0.789551931534954d),

new NpgsqlTypes.NpgsqlLine(a: 0.30168114790306255d, b: 0.012442367631581908d, c: 0.1671940923820876d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04460129189408102d, b: 0.4980236959348501d, c: 0.8288271906679947d),

new NpgsqlTypes.NpgsqlLine(a: 0.5606357057453959d, b: 0.8867972615660265d, c: 0.8869464777805784d),

new NpgsqlTypes.NpgsqlLine(a: 0.46991682011546965d, b: 0.7980308647131265d, c: 0.7894973939067615d),

new NpgsqlTypes.NpgsqlLine(a: 0.47984205459753715d, b: 0.007708731616357323d, c: 0.7753800662971873d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.12902078386615368d, b: 0.3301809376694156d, c: 0.6157189776122552d),

new NpgsqlTypes.NpgsqlLine(a: 0.2886670580329527d, b: 0.5829798269055266d, c: 0.3813161928911274d),

new NpgsqlTypes.NpgsqlLine(a: 0.012387473887041867d, b: 0.9140663497243522d, c: 0.7754204981034342d),

new NpgsqlTypes.NpgsqlLine(a: 0.9052977522881709d, b: 0.9212988382854762d, c: 0.23188897032440603d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9415233685084547d, b: 0.7865938883135006d, c: 0.7846513788256834d),

new NpgsqlTypes.NpgsqlLine(a: 0.731964747745983d, b: 0.19374933057106247d, c: 0.5121516275863874d),

new NpgsqlTypes.NpgsqlLine(a: 0.6415023920571714d, b: 0.21731591461977062d, c: 0.411530882497646d),

new NpgsqlTypes.NpgsqlLine(a: 0.2128220279675901d, b: 0.6446386190731471d, c: 0.2518061128305371d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16395709933360136d, b: 0.134165409874336d, c: 0.07030840290222606d),

new NpgsqlTypes.NpgsqlLine(a: 0.47396340168353046d, b: 0.9512935808794359d, c: 0.7255874035437225d),

new NpgsqlTypes.NpgsqlLine(a: 0.10224533315657458d, b: 0.8827937564105761d, c: 0.1117746177261496d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 124,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7670116551494629d, b: 0.10526990589038854d, c: 0.5098656709968685d),

new NpgsqlTypes.NpgsqlLine(a: 0.07876216504998679d, b: 0.701505645722629d, c: 0.2311848627190255d),

new NpgsqlTypes.NpgsqlLine(a: 0.268970218542413d, b: 0.5899380213168229d, c: 0.8723497989729857d),

new NpgsqlTypes.NpgsqlLine(a: 0.2489197380035476d, b: 0.8946864970955062d, c: 0.27169507687585914d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9310350212708441d, b: 0.09803168097687853d, c: 0.5382042753220512d),

new NpgsqlTypes.NpgsqlLine(a: 0.9402715546459275d, b: 0.40455903218893263d, c: 0.29910261133872407d),

new NpgsqlTypes.NpgsqlLine(a: 0.6375290236007359d, b: 0.42752332664370374d, c: 0.3998994808984848d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4717235861313748d, b: 0.45889304664741803d, c: 0.5295572123557982d),

new NpgsqlTypes.NpgsqlLine(a: 0.4554724612414419d, b: 0.9960442436992691d, c: 0.3325804534889366d),

new NpgsqlTypes.NpgsqlLine(a: 0.11997030731345981d, b: 0.1960402060187587d, c: 0.5494884963152447d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4896512575978369d, b: 0.7292745289736461d, c: 0.322249983120376d),

new NpgsqlTypes.NpgsqlLine(a: 0.0682864032145668d, b: 0.4369258883660856d, c: 0.5311921346797878d),

new NpgsqlTypes.NpgsqlLine(a: 0.1424195300558112d, b: 0.7397706690804368d, c: 0.7572575638601632d),

new NpgsqlTypes.NpgsqlLine(a: 0.822635839651304d, b: 0.8964723692678257d, c: 0.2300470277142702d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18046798073743842d, b: 0.8942008612321211d, c: 0.5254861511147564d),

new NpgsqlTypes.NpgsqlLine(a: 0.928168671230336d, b: 0.33630422347459166d, c: 0.1415292484849029d),

new NpgsqlTypes.NpgsqlLine(a: 0.5824880746451578d, b: 0.5085532759429073d, c: 0.9491907179099556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7620799076737969d, b: 0.8630854189878882d, c: 0.3632949704819489d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9661273959456712d, b: 0.7942941025379648d, c: 0.9824455153287458d),

new NpgsqlTypes.NpgsqlLine(a: 0.11680240398841102d, b: 0.03367451944652455d, c: 0.008279262850055202d),

new NpgsqlTypes.NpgsqlLine(a: 0.1267373544256154d, b: 0.5183651720690193d, c: 0.6563161315573185d),

new NpgsqlTypes.NpgsqlLine(a: 0.3533349896052048d, b: 0.007690265778774519d, c: 0.7975118150781398d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5547793074279506d, b: 0.2163939371502891d, c: 0.9777414305619201d),

new NpgsqlTypes.NpgsqlLine(a: 0.03609820275284448d, b: 0.34652459544221337d, c: 0.8022505202480279d),

new NpgsqlTypes.NpgsqlLine(a: 0.008661266445582738d, b: 0.5255622726641956d, c: 0.7992795575097146d),

new NpgsqlTypes.NpgsqlLine(a: 0.8487376040954481d, b: 0.6231734463292864d, c: 0.37119097128157164d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4365952518984302d, b: 0.10161487363732224d, c: 0.5038783364035967d),

new NpgsqlTypes.NpgsqlLine(a: 0.21729879467427293d, b: 0.5844433224943311d, c: 0.025947830049739884d),

new NpgsqlTypes.NpgsqlLine(a: 0.9690219082059303d, b: 0.5096168411750436d, c: 0.7951097379989644d),

new NpgsqlTypes.NpgsqlLine(a: 0.2981944445787771d, b: 0.2796755861124395d, c: 0.8867939957782046d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 151,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662915994563294d, b: 0.7467880752100525d, c: 0.13337037651533157d),

new NpgsqlTypes.NpgsqlLine(a: 0.30885359168563176d, b: 0.842921145708922d, c: 0.9865487193941416d),

new NpgsqlTypes.NpgsqlLine(a: 0.8299166605362309d, b: 0.9142555688886719d, c: 0.7079287746575909d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 66,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7094572641764711d, b: 0.8341162106385289d, c: 0.20718526033574525d),

new NpgsqlTypes.NpgsqlLine(a: 0.22761690834366943d, b: 0.09824878774078116d, c: 0.1473458260434325d),

new NpgsqlTypes.NpgsqlLine(a: 0.7395912511274728d, b: 0.06744489242348872d, c: 0.10188764545560303d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43342964857380717d, b: 0.590235285856825d, c: 0.6983297942258584d),

new NpgsqlTypes.NpgsqlLine(a: 0.037697904213879974d, b: 0.6050460276662146d, c: 0.2552012210072989d),

new NpgsqlTypes.NpgsqlLine(a: 0.5381628068878691d, b: 0.8113498882752831d, c: 0.9711297069017029d),

new NpgsqlTypes.NpgsqlLine(a: 0.8425283693838367d, b: 0.5929931062387724d, c: 0.87964195110492d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6883884937121861d, b: 0.26325517338067284d, c: 0.06608726925281061d),

new NpgsqlTypes.NpgsqlLine(a: 0.9812161379737618d, b: 0.04722792947250509d, c: 0.006814076587472129d),

new NpgsqlTypes.NpgsqlLine(a: 0.4414811548710309d, b: 0.7784372574237942d, c: 0.8981335296973332d),

new NpgsqlTypes.NpgsqlLine(a: 0.8168809941964628d, b: 0.7229576809199141d, c: 0.10456024548107334d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3087554441877819d, b: 0.42003634701790593d, c: 0.3489168580630614d),

new NpgsqlTypes.NpgsqlLine(a: 0.22976286515139865d, b: 0.0018375782368729165d, c: 0.4652433136224212d),

new NpgsqlTypes.NpgsqlLine(a: 0.13294443709461112d, b: 0.7010718439668474d, c: 0.7393125672599329d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4796886186587346d, b: 0.01887458804697595d, c: 0.2196474593670562d),

new NpgsqlTypes.NpgsqlLine(a: 0.2976825500884963d, b: 0.4892402001726639d, c: 0.8945677952763965d),

new NpgsqlTypes.NpgsqlLine(a: 0.7773682754257946d, b: 0.5642874378848051d, c: 0.5104995180810308d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18362476375039005d, b: 0.7956718960196021d, c: 0.6894666378486615d),

new NpgsqlTypes.NpgsqlLine(a: 0.009793164049266223d, b: 0.8063587349551599d, c: 0.18472254108761088d),

new NpgsqlTypes.NpgsqlLine(a: 0.3824832906016864d, b: 0.5594376476031944d, c: 0.052975953491894656d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 166,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.28282755458643627d, b: 0.27485825864001956d, c: 0.39985098277161824d),

new NpgsqlTypes.NpgsqlLine(a: 0.5411621130878265d, b: 0.757007890229041d, c: 0.5498595289752168d),

new NpgsqlTypes.NpgsqlLine(a: 0.5641178376921505d, b: 0.3244362354331892d, c: 0.6179701537345156d),

new NpgsqlTypes.NpgsqlLine(a: 0.6830202854133096d, b: 0.3032310469270776d, c: 0.5188358329923441d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20630350761169203d, b: 0.009165144001480496d, c: 0.2041460434431429d),

new NpgsqlTypes.NpgsqlLine(a: 0.7676197098587973d, b: 0.022765134796381314d, c: 0.9590080418395125d),

new NpgsqlTypes.NpgsqlLine(a: 0.8240003933865001d, b: 0.5817142912278521d, c: 0.7003689613538784d),

new NpgsqlTypes.NpgsqlLine(a: 0.7547809926154511d, b: 0.11737142578373716d, c: 0.05161516255112064d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 168,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3758688071574151d, b: 0.7010572787838397d, c: 0.33976802173024256d),

new NpgsqlTypes.NpgsqlLine(a: 0.604981104542541d, b: 0.6950815757056138d, c: 0.29725694594875807d),

new NpgsqlTypes.NpgsqlLine(a: 0.535342994985468d, b: 0.5705920973864296d, c: 0.8014333536764634d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5123466844532835d, b: 0.24735917844565736d, c: 0.5368424404864538d),

new NpgsqlTypes.NpgsqlLine(a: 0.855728229017523d, b: 0.4850823925615829d, c: 0.6215823614604076d),

new NpgsqlTypes.NpgsqlLine(a: 0.19722272246342265d, b: 0.1694652372180777d, c: 0.9286020517313083d),

new NpgsqlTypes.NpgsqlLine(a: 0.9793467386948136d, b: 0.003359882805378911d, c: 0.7322412042116306d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 172,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.09965874039615585d, b: 0.5124154076054389d, c: 0.5668329487055878d),

new NpgsqlTypes.NpgsqlLine(a: 0.6301567455100802d, b: 0.9070298695854034d, c: 0.5177347292193845d),

new NpgsqlTypes.NpgsqlLine(a: 0.3312208538465381d, b: 0.41921160781659694d, c: 0.7996981212102948d),

new NpgsqlTypes.NpgsqlLine(a: 0.9308614304586471d, b: 0.9917971753482805d, c: 0.5084757854392924d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 180,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11510019719094688d, b: 0.5624903869254754d, c: 0.7816201351041159d),

new NpgsqlTypes.NpgsqlLine(a: 0.3805584751137776d, b: 0.8063964989917158d, c: 0.7147136028286244d),

new NpgsqlTypes.NpgsqlLine(a: 0.8834537882838904d, b: 0.6821991742598693d, c: 0.7908932376760935d),

new NpgsqlTypes.NpgsqlLine(a: 0.14773552096680787d, b: 0.6259482276435002d, c: 0.9102122725273034d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13706409079902926d, b: 0.8904280218996475d, c: 0.9885135622692662d),

new NpgsqlTypes.NpgsqlLine(a: 0.5000746019812895d, b: 0.19121473550219725d, c: 0.4177861933624377d),

new NpgsqlTypes.NpgsqlLine(a: 0.5085321577265686d, b: 0.13718200443155093d, c: 0.4897292304137387d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3111307689637067d, b: 0.8524240114250687d, c: 0.5688146536893158d),

new NpgsqlTypes.NpgsqlLine(a: 0.668588310018982d, b: 0.9679796111748571d, c: 0.44139584934812925d),

new NpgsqlTypes.NpgsqlLine(a: 0.6417325552140356d, b: 0.02851300501618259d, c: 0.9758993568461579d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 182,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04556787465873691d, b: 0.5187076625349959d, c: 0.7364396592931816d),

new NpgsqlTypes.NpgsqlLine(a: 0.362784078466604d, b: 0.26307070904803354d, c: 0.027685479690701564d),

new NpgsqlTypes.NpgsqlLine(a: 0.2833393336203024d, b: 0.23822913292523062d, c: 0.003409397068857789d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineListD1E2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.816332054292533d, b: 0.47249970980992384d, c: 0.8964881382352757d),

new NpgsqlTypes.NpgsqlLine(a: 0.07029922477323114d, b: 0.2730243431905116d, c: 0.3128333026838821d),

new NpgsqlTypes.NpgsqlLine(a: 0.16831180181577698d, b: 0.9076625446794235d, c: 0.14694898537447643d),

new NpgsqlTypes.NpgsqlLine(a: 0.33973575646021503d, b: 0.227986041737417d, c: 0.41778516859853787d),

},
    ModelInner = new NpgsqlLinelineListD12MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16261337303113088d, b: 0.7341314091662766d, c: 0.1574582913647974d),

new NpgsqlTypes.NpgsqlLine(a: 0.8088712458600568d, b: 0.8865704519860772d, c: 0.4136520671575754d),

new NpgsqlTypes.NpgsqlLine(a: 0.9339141177186382d, b: 0.7581873335551598d, c: 0.4979039807667852d),

new NpgsqlTypes.NpgsqlLine(a: 0.5714045921725094d, b: 0.8636601043170405d, c: 0.1020704208470593d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.43951012446833615d, b: 0.03231163649673707d, c: 0.6046641760707205d),

new NpgsqlTypes.NpgsqlLine(a: 0.8257918523892437d, b: 0.7829408299759587d, c: 0.2952970121541656d),

new NpgsqlTypes.NpgsqlLine(a: 0.9373137417066262d, b: 0.34920741645682696d, c: 0.9460082037932241d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.491127224722797d, b: 0.37887578569981073d, c: 0.9053805761030453d),

new NpgsqlTypes.NpgsqlLine(a: 0.08915274845321308d, b: 0.13477974004298376d, c: 0.17938344580957943d),

new NpgsqlTypes.NpgsqlLine(a: 0.024980498856879252d, b: 0.48225103551964055d, c: 0.9466930852507744d),

new NpgsqlTypes.NpgsqlLine(a: 0.2830989289173852d, b: 0.2709408389392549d, c: 0.7976657739229479d),

},
},
            new NpgsqlLinelineListD1E2M
{
    Id = 192,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44052404315552496d, b: 0.1671045034573072d, c: 0.02635110556471454d),

new NpgsqlTypes.NpgsqlLine(a: 0.33139780499960136d, b: 0.9347437787469224d, c: 0.4290372678667633d),

new NpgsqlTypes.NpgsqlLine(a: 0.4460747561444026d, b: 0.315659638037987d, c: 0.9231807543620684d),

new NpgsqlTypes.NpgsqlLine(a: 0.8552920234449995d, b: 0.7573851739543574d, c: 0.39702978816274126d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45019581501927153d, b: 0.47476935411906884d, c: 0.4682995418319551d),

new NpgsqlTypes.NpgsqlLine(a: 0.40873418833512754d, b: 0.5747951702595618d, c: 0.19558759979505358d),

new NpgsqlTypes.NpgsqlLine(a: 0.8628323082975531d, b: 0.2507147182582007d, c: 0.9170845241686052d),

new NpgsqlTypes.NpgsqlLine(a: 0.4685818527210187d, b: 0.7352112078264722d, c: 0.8635568428468821d),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd12mi(
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
INSERT INTO public.npgsqllinelinelistd12mi(
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
            queryMapTypes: [typeof(NpgsqlLinelineListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlLineListlineListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd12mi_id
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)), 
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
                methodParametrName: "npgsqllinelinelistd12mi_id", 
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
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlLineListlineListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlLineListlineListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd12mi_id
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
    npgsqllinelinelistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqllinelinelistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqllinelinelistd12mi_id
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
    npgsqllinelinelistd12mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                methodParametrName: "npgsqllinelinelistd12mi_id", 
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
                List<NpgsqlLinelineListD1E2M> models = null;

                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlLineListlineListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlLinelineListD1E2M> models = null;

                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd12mi mi ON mi.id = m.npgsqllinelinelistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlLineListlineListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd12mi mi ON mi.id = m.npgsqllinelinelistd12mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await ((INpgsqlLineListlineListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlLineListlineListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 81;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 72;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 100;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 11;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(33));
                Assert.That(secondItems2, Has.Count.EqualTo(33));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[31],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[32],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[32],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 136;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 8;
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[34], false);
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
                parametr1.Value = 115;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 124;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 182;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd12mi mi ON mi.id = m.npgsqllinelinelistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 107;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 82;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 32;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 18;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M), typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 15, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                Assert.That(secondItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 81, query1, 41, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var models2 = new List<FlatNpgsqlLinelineListD1E2M>();
                ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 15, query1, 46, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 82, query1, 65, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems2[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 82, query1, 166, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                await ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 94, query1, 32, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[28],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 124, query1, 91, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
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
FROM public.npgsqllinelinelistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineListD1E2M>();
                 ((INpgsqlLineListlineListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 41, query1, 100, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(firstItems1[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqllinelinelistd1e2m m
LEFT JOIN public.npgsqllinelinelistd12mi mi ON mi.id = m.npgsqllinelinelistd12mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
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
                var models = await((INpgsqlLineListlineListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 18, 100))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[34], false);
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
                var models = ((INpgsqlLineListlineListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlLinelineListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineListD1)this).DbConnectionSTSelectModelBatch(connection, 155, 41))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[8], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[9], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[10], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[11], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[12], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[13], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[14], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[15], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[16], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[17], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[18], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[19], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[20], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[21], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[22], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[23], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[24], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[25], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[26], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[27], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[28], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[29], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[30], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[31], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[32], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[33], false);
                        NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[34], false);
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
                await using var cmd = await ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 41);
                var models = await ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(28));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[7], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[8], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[9], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[10], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[11], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[12], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[13], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[14], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[15], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[16], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[17], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[18], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[12],_testData[19], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[13],_testData[20], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[14],_testData[21], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[15],_testData[22], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[16],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[17],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[18],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[19],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[20],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[21],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[22],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[23],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[24],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[25],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[26],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineListD1)this).SetDbConnectionSelectModelParametrs(cmd, 127);
                var models =  ((INpgsqlLineListlineListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(12));

                NpgsqlLinelineListD1E2M.AssertModel(models[0],_testData[23], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[1],_testData[24], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[2],_testData[25], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[3],_testData[26], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[4],_testData[27], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[5],_testData[28], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[6],_testData[29], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[7],_testData[30], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[8],_testData[31], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[9],_testData[32], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[10],_testData[33], false);
                NpgsqlLinelineListD1E2M.AssertModel(models[11],_testData[34], false);
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
FROM public.binary_npgsqllinelinelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD12MIWA),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD12MI),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD12MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD12MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqllinelinelistd12mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd12mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineListD12MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD12MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineListD12MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqllinelinelistd12mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlLinelineListD1E2M),
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
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
FROM public.binary_npgsqllinelinelistd1e2m m
LEFT JOIN public.binary_npgsqllinelinelistd12mi mi ON mi.id = m.npgsqllinelinelistd12mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqllinelinelistd12mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlLinelineListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models =  ((INpgsqlLineListlineListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlLinelineListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA), typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd12mi
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
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd12mi
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
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA), typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                ((INpgsqlLineListlineListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinelistd12mi
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
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinelistd12mi
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
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MI), typeof(NpgsqlLinelineListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models1 = new List<NpgsqlLinelineListD12MI>();
                var models2 = new List<NpgsqlLinelineListD12MI>();
                await ((INpgsqlLineListlineListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD12MI>();
                var models2 = new List<NpgsqlLinelineListD12MI>();
                ((INpgsqlLineListlineListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd12mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638),
                (NpgsqlTypes.NpgsqlDbType)(-2147483638)
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
                var models = await ((INpgsqlLineListlineListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD12MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinelistd12mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA), typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                await ((INpgsqlLineListlineListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineListD12MIWA>();
                var models2 = new List<NpgsqlLinelineListD12MIWA>();
                ((INpgsqlLineListlineListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinelistd12mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineListD12MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineListD1))]
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
                var models = await ((INpgsqlLineListlineListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineListD12MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

