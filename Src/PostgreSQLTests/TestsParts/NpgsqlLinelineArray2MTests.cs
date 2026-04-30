

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
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2750040143590273d, b: 0.1348678362519149d, c: 0.1555873349618997d),

new NpgsqlTypes.NpgsqlLine(a: 0.2223192144912569d, b: 0.3197383663375649d, c: 0.9717388101037797d),

new NpgsqlTypes.NpgsqlLine(a: 0.8916019179126532d, b: 0.8417885634612231d, c: 0.03649709113139199d),

new NpgsqlTypes.NpgsqlLine(a: 0.9728629058730509d, b: 0.791882749727754d, c: 0.15919115869326583d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2197401635143832d, b: 0.5401804559660155d, c: 0.6884210772047286d),

new NpgsqlTypes.NpgsqlLine(a: 0.013921627708140094d, b: 0.8094645732575266d, c: 0.9027099667707631d),

new NpgsqlTypes.NpgsqlLine(a: 0.6929976068790085d, b: 0.505716715587491d, c: 0.0512743616052993d),

new NpgsqlTypes.NpgsqlLine(a: 0.8083503855728946d, b: 0.5905023139248724d, c: 0.08948828170771561d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.29748337776050426d, b: 0.9705879483700747d, c: 0.7186162863668465d),

new NpgsqlTypes.NpgsqlLine(a: 0.2766186018813782d, b: 0.13404730526869402d, c: 0.08139140189924665d),

new NpgsqlTypes.NpgsqlLine(a: 0.8818485614130224d, b: 0.554472531083078d, c: 0.2542178215890435d),

new NpgsqlTypes.NpgsqlLine(a: 0.632616515086959d, b: 0.10941958126135964d, c: 0.550357447645091d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47966702761618674d, b: 0.520017946870885d, c: 0.23611761317521662d),

new NpgsqlTypes.NpgsqlLine(a: 0.26860110115961067d, b: 0.11937523984565157d, c: 0.08396446114533362d),

new NpgsqlTypes.NpgsqlLine(a: 0.3948798839628548d, b: 0.052860782450771304d, c: 0.3122553842925502d),

new NpgsqlTypes.NpgsqlLine(a: 0.8507868214888832d, b: 0.11036518741453827d, c: 0.8793367151017206d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7771305204269927d, b: 0.6291692592983963d, c: 0.06744631115081601d),

new NpgsqlTypes.NpgsqlLine(a: 0.06965989675229989d, b: 0.9285810690033416d, c: 0.09274560454904623d),

new NpgsqlTypes.NpgsqlLine(a: 0.5489796393456362d, b: 0.007111365107993706d, c: 0.43493899191250207d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 15,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.02409485728586791d, b: 0.2843946260431994d, c: 0.7916379099789548d),

new NpgsqlTypes.NpgsqlLine(a: 0.19469382858909123d, b: 0.02231197793133699d, c: 0.0698119259513248d),

new NpgsqlTypes.NpgsqlLine(a: 0.7173633521866348d, b: 0.3077146860264368d, c: 0.951939974965867d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3820802124765875d, b: 0.11665642429063972d, c: 0.09695791858160152d),

new NpgsqlTypes.NpgsqlLine(a: 0.37581592822928367d, b: 0.039443266153378786d, c: 0.09137159425907337d),

new NpgsqlTypes.NpgsqlLine(a: 0.4133563890719667d, b: 0.2132027269514647d, c: 0.5786721999363054d),

new NpgsqlTypes.NpgsqlLine(a: 0.8650523894488378d, b: 0.49157591012831936d, c: 0.41180161387980696d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13393814290693007d, b: 0.4792344456386981d, c: 0.7678232084837603d),

new NpgsqlTypes.NpgsqlLine(a: 0.48842137494595317d, b: 0.026497042341535493d, c: 0.6358583067303757d),

new NpgsqlTypes.NpgsqlLine(a: 0.43662580684560814d, b: 0.9554743331127439d, c: 0.4094329486448798d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6020079177536158d, b: 0.48791949890249164d, c: 0.6282548172610822d),

new NpgsqlTypes.NpgsqlLine(a: 0.05301824487214646d, b: 0.7797450293857923d, c: 0.09759644006687718d),

new NpgsqlTypes.NpgsqlLine(a: 0.7976607782755104d, b: 0.9189337984369018d, c: 0.7747196947827034d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9142015125347979d, b: 0.37118114231186006d, c: 0.3201156495668185d),

new NpgsqlTypes.NpgsqlLine(a: 0.8741135932485786d, b: 0.6203847098338133d, c: 0.67667672368018d),

new NpgsqlTypes.NpgsqlLine(a: 0.334864873706922d, b: 0.9274580547735711d, c: 0.7650265691061585d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5480265754023492d, b: 0.29834899211694155d, c: 0.8030612257094554d),

new NpgsqlTypes.NpgsqlLine(a: 0.6925388262060497d, b: 0.35808831117964923d, c: 0.5320154634590355d),

new NpgsqlTypes.NpgsqlLine(a: 0.29176889457808886d, b: 0.6047308898238327d, c: 0.7092028464915927d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47066410269698333d, b: 0.5573928752304801d, c: 0.9948673382411358d),

new NpgsqlTypes.NpgsqlLine(a: 0.42869532620880846d, b: 0.6453253682044772d, c: 0.6140543913248168d),

new NpgsqlTypes.NpgsqlLine(a: 0.7901949916782111d, b: 0.13776451230238673d, c: 0.9556745052270055d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7662034024952321d, b: 0.7662336547693858d, c: 0.8193543021305685d),

new NpgsqlTypes.NpgsqlLine(a: 0.2981942690670363d, b: 0.36468795191333614d, c: 0.1559496364148104d),

new NpgsqlTypes.NpgsqlLine(a: 0.7734480051986855d, b: 0.20499519978238467d, c: 0.168348560726999d),

new NpgsqlTypes.NpgsqlLine(a: 0.8771110523615528d, b: 0.5733567006525184d, c: 0.33405285502996884d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4629008567073688d, b: 0.12363115768920185d, c: 0.03208431205754514d),

new NpgsqlTypes.NpgsqlLine(a: 0.8695187771250347d, b: 0.8048291487577858d, c: 0.5274038766902678d),

new NpgsqlTypes.NpgsqlLine(a: 0.9103362791304874d, b: 0.32655571150155627d, c: 0.3941590194145226d),

new NpgsqlTypes.NpgsqlLine(a: 0.2964212359325996d, b: 0.7170490157110818d, c: 0.3742945684264273d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4402550778665911d, b: 0.6490174202537992d, c: 0.6546710329547777d),

new NpgsqlTypes.NpgsqlLine(a: 0.8575605512350549d, b: 0.27883497188510276d, c: 0.8229215452353675d),

new NpgsqlTypes.NpgsqlLine(a: 0.2522541806048837d, b: 0.7844227508138014d, c: 0.9945477181522556d),

new NpgsqlTypes.NpgsqlLine(a: 0.33485650984097304d, b: 0.8191639358490158d, c: 0.47216387243300484d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9000071200090575d, b: 0.4446557922622282d, c: 0.0703465432248177d),

new NpgsqlTypes.NpgsqlLine(a: 0.4386591310982848d, b: 0.1847258084664294d, c: 0.7659509810701892d),

new NpgsqlTypes.NpgsqlLine(a: 0.5569158011500734d, b: 0.14698871486748843d, c: 0.9260443235080477d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8263844833013161d, b: 0.7220304294552428d, c: 0.12414710418542685d),

new NpgsqlTypes.NpgsqlLine(a: 0.46706279764154945d, b: 0.3463842820777243d, c: 0.8808190960776706d),

new NpgsqlTypes.NpgsqlLine(a: 0.9289507535740043d, b: 0.5658687569704899d, c: 0.3426471356177182d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39886600924334537d, b: 0.8084790076137741d, c: 0.6006062096576211d),

new NpgsqlTypes.NpgsqlLine(a: 0.07686122675072682d, b: 0.9454402646325518d, c: 0.8540982722857825d),

new NpgsqlTypes.NpgsqlLine(a: 0.04932841892201234d, b: 0.8626303021266901d, c: 0.14623476559417947d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5835177071082527d, b: 0.3885689927350272d, c: 0.504309867729d),

new NpgsqlTypes.NpgsqlLine(a: 0.7237207537643563d, b: 0.4991337470728311d, c: 0.4792136451179281d),

new NpgsqlTypes.NpgsqlLine(a: 0.82513509915716d, b: 0.6246953888295721d, c: 0.5849149993531174d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 44,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3494449073607435d, b: 0.709045988040378d, c: 0.29602324795187085d),

new NpgsqlTypes.NpgsqlLine(a: 0.6415885072224128d, b: 0.8437195886521696d, c: 0.7671587406146997d),

new NpgsqlTypes.NpgsqlLine(a: 0.7252204906952713d, b: 0.411265680612832d, c: 0.10025219108450434d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24297433096815757d, b: 0.5083529751834859d, c: 0.9198508925080686d),

new NpgsqlTypes.NpgsqlLine(a: 0.5777130445702501d, b: 0.930310145549875d, c: 0.4253624080461901d),

new NpgsqlTypes.NpgsqlLine(a: 0.5111306882309249d, b: 0.2734916594117175d, c: 0.630452740680639d),

new NpgsqlTypes.NpgsqlLine(a: 0.06134022784763715d, b: 0.3298248468566025d, c: 0.08831155098051768d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.454997178584838d, b: 0.18576430260471877d, c: 0.1822160488179907d),

new NpgsqlTypes.NpgsqlLine(a: 0.7570712483712384d, b: 0.42469142309704355d, c: 0.210860526813346d),

new NpgsqlTypes.NpgsqlLine(a: 0.8947457950149753d, b: 0.9749185054300902d, c: 0.7399755126428487d),

new NpgsqlTypes.NpgsqlLine(a: 0.37835857729448463d, b: 0.4486238075435336d, c: 0.3703323268393176d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 47,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7495488091556721d, b: 0.5965086671280565d, c: 0.41058297076737915d),

new NpgsqlTypes.NpgsqlLine(a: 0.5617935582125291d, b: 0.14053874209503603d, c: 0.3696306171115965d),

new NpgsqlTypes.NpgsqlLine(a: 0.7495819368279656d, b: 0.6789380147009277d, c: 0.9113847039046071d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8487341633044244d, b: 0.3682471931828457d, c: 0.16085780890970292d),

new NpgsqlTypes.NpgsqlLine(a: 0.26002579663529735d, b: 0.25597041184806224d, c: 0.9495577886347786d),

new NpgsqlTypes.NpgsqlLine(a: 0.5652590325154664d, b: 0.019482835849158886d, c: 0.49183403586886254d),

new NpgsqlTypes.NpgsqlLine(a: 0.9076712958323991d, b: 0.00357978394924241d, c: 0.5230540504140221d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7774520642437397d, b: 0.28806969475955013d, c: 0.3970310378528259d),

new NpgsqlTypes.NpgsqlLine(a: 0.7277722778537885d, b: 0.3595092485288284d, c: 0.5572442670202996d),

new NpgsqlTypes.NpgsqlLine(a: 0.04420048893528683d, b: 0.15069696813656464d, c: 0.889543613804455d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6408743084063658d, b: 0.5304675187857772d, c: 0.39586737224076174d),

new NpgsqlTypes.NpgsqlLine(a: 0.7066772184525495d, b: 0.7285572316897542d, c: 0.3544835789119315d),

new NpgsqlTypes.NpgsqlLine(a: 0.6076482125778191d, b: 0.997114017684495d, c: 0.17319277901273078d),

new NpgsqlTypes.NpgsqlLine(a: 0.8324061392313268d, b: 0.6183753460451048d, c: 0.11006949569052771d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.053175353687259896d, b: 0.7962433613992352d, c: 0.6468445130113724d),

new NpgsqlTypes.NpgsqlLine(a: 0.2910256187657905d, b: 0.5482226326948317d, c: 0.9236454056323823d),

new NpgsqlTypes.NpgsqlLine(a: 0.06826583846657619d, b: 0.7456196957100463d, c: 0.7170309015189085d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 59,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6934542837505552d, b: 0.6566842492412576d, c: 0.9050260709775945d),

new NpgsqlTypes.NpgsqlLine(a: 0.8001494392971288d, b: 0.5318210294585133d, c: 0.9885961584508964d),

new NpgsqlTypes.NpgsqlLine(a: 0.08800352552326185d, b: 0.4954691175222603d, c: 0.5483635461026137d),

new NpgsqlTypes.NpgsqlLine(a: 0.24811351481086386d, b: 0.18891173721280308d, c: 0.028088579780409573d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.663545800697671d, b: 0.9847817796595351d, c: 0.10716176866779903d),

new NpgsqlTypes.NpgsqlLine(a: 0.04072820564669488d, b: 0.5309219155064026d, c: 0.4835841025046783d),

new NpgsqlTypes.NpgsqlLine(a: 0.7026017120283925d, b: 0.6132401673957711d, c: 0.8702853632954648d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 67,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7511561211275836d, b: 0.5846017461875124d, c: 0.9101153603944694d),

new NpgsqlTypes.NpgsqlLine(a: 0.3709017176955327d, b: 0.2465888659976243d, c: 0.8142440643900494d),

new NpgsqlTypes.NpgsqlLine(a: 0.6954478457853438d, b: 0.04807315967873993d, c: 0.6139032110940353d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36428909127816367d, b: 0.004108562962613416d, c: 0.5877037662741195d),

new NpgsqlTypes.NpgsqlLine(a: 0.3442961820059476d, b: 0.9005389843868201d, c: 0.6063216417075254d),

new NpgsqlTypes.NpgsqlLine(a: 0.3567067253376258d, b: 0.10427516656261149d, c: 0.14091259964224623d),

new NpgsqlTypes.NpgsqlLine(a: 0.19930332491169012d, b: 0.11310772456879281d, c: 0.7455605358045514d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40295040516988d, b: 0.05377224029743799d, c: 0.19576024836026173d),

new NpgsqlTypes.NpgsqlLine(a: 0.09341333820052966d, b: 0.4438263682703899d, c: 0.8441752947219292d),

new NpgsqlTypes.NpgsqlLine(a: 0.751482906264638d, b: 0.989468961794561d, c: 0.34980099034826573d),

new NpgsqlTypes.NpgsqlLine(a: 0.8898804164888129d, b: 0.8573688075647327d, c: 0.09556279477845742d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.037278292757155995d, b: 0.21948602628793756d, c: 0.18505547505122177d),

new NpgsqlTypes.NpgsqlLine(a: 0.8054565833707661d, b: 0.6647929500423421d, c: 0.9342159252948846d),

new NpgsqlTypes.NpgsqlLine(a: 0.29614317056141526d, b: 0.7297532177280481d, c: 0.7420793216047772d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7860316076787537d, b: 0.486136864992461d, c: 0.015315224934203564d),

new NpgsqlTypes.NpgsqlLine(a: 0.009195810306809826d, b: 0.9412093246736426d, c: 0.05905367468723821d),

new NpgsqlTypes.NpgsqlLine(a: 4.4341243232715044E-05d, b: 0.057793000719825405d, c: 0.34569674355949287d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 77,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5147940021960318d, b: 0.37471428543241514d, c: 0.13694589799253032d),

new NpgsqlTypes.NpgsqlLine(a: 0.1277954159063175d, b: 0.557235341433937d, c: 0.7161642397857736d),

new NpgsqlTypes.NpgsqlLine(a: 0.9565529506860972d, b: 0.48775606884930367d, c: 0.9828868990553988d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 18,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.05409711989874444d, b: 0.7581019875240411d, c: 0.45680723800986733d),

new NpgsqlTypes.NpgsqlLine(a: 0.28646159693958206d, b: 0.2021470161984329d, c: 0.04661003197564584d),

new NpgsqlTypes.NpgsqlLine(a: 0.6155157448256878d, b: 0.8199970977175673d, c: 0.37307524835594463d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03654045629369285d, b: 0.9237057692800592d, c: 0.11644066303079581d),

new NpgsqlTypes.NpgsqlLine(a: 0.8280645988242389d, b: 0.36961054391777526d, c: 0.06169859491970997d),

new NpgsqlTypes.NpgsqlLine(a: 0.8733747648888202d, b: 0.8242318977428779d, c: 0.9487527235415638d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5671369086287615d, b: 0.42516367293868473d, c: 0.3507749672239344d),

new NpgsqlTypes.NpgsqlLine(a: 0.39012221748671005d, b: 0.8674028052873858d, c: 0.7578372428218154d),

new NpgsqlTypes.NpgsqlLine(a: 0.777084687898411d, b: 0.758330319525792d, c: 0.2784856826894042d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9991036616976868d, b: 0.26411522888679495d, c: 0.0747936853932516d),

new NpgsqlTypes.NpgsqlLine(a: 0.1772491811342406d, b: 0.025830335058970366d, c: 0.5898126537196758d),

new NpgsqlTypes.NpgsqlLine(a: 0.0067397403081473906d, b: 0.00635537711066303d, c: 0.8374485199324299d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7485611231135725d, b: 0.9849619197276842d, c: 0.5329430990314121d),

new NpgsqlTypes.NpgsqlLine(a: 0.9946724860278571d, b: 0.9624509522701001d, c: 0.2698513450008764d),

new NpgsqlTypes.NpgsqlLine(a: 0.11450282361447428d, b: 0.6511557135503863d, c: 0.25693886482024264d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04456935012063923d, b: 0.8100563310433646d, c: 0.3154767247404314d),

new NpgsqlTypes.NpgsqlLine(a: 0.34816238125440513d, b: 0.4330103308729266d, c: 0.19167530792034881d),

new NpgsqlTypes.NpgsqlLine(a: 0.2943575113929996d, b: 0.8239633699671041d, c: 0.08699721994330667d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.040364289401544795d, b: 0.809835436434602d, c: 0.8938028240880913d),

new NpgsqlTypes.NpgsqlLine(a: 0.926070619164904d, b: 0.5574801896271966d, c: 0.5010309256836674d),

new NpgsqlTypes.NpgsqlLine(a: 0.30755321122666657d, b: 0.2596956908806374d, c: 0.006573085357608366d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7986642952246387d, b: 0.371376225494902d, c: 0.5832601801756435d),

new NpgsqlTypes.NpgsqlLine(a: 0.5269761021474956d, b: 0.39273342197297645d, c: 0.9299330362219398d),

new NpgsqlTypes.NpgsqlLine(a: 0.7831227248808266d, b: 0.8683298487268498d, c: 0.11816751066314268d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9819712954150115d, b: 0.27563623891528033d, c: 0.7264095558484175d),

new NpgsqlTypes.NpgsqlLine(a: 0.006679245169333936d, b: 0.7140547406841183d, c: 0.11423669940951564d),

new NpgsqlTypes.NpgsqlLine(a: 0.5219020203769553d, b: 0.9191220712582426d, c: 0.3146548360164124d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 95,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8465179971596257d, b: 0.7227408489893937d, c: 0.828312193861766d),

new NpgsqlTypes.NpgsqlLine(a: 0.24434150809681765d, b: 0.6673273294309225d, c: 0.20720408905869436d),

new NpgsqlTypes.NpgsqlLine(a: 0.05422437838156058d, b: 0.7386232898365672d, c: 0.1691693603095984d),

new NpgsqlTypes.NpgsqlLine(a: 0.21877407577559238d, b: 0.18625914852544023d, c: 0.9811067435078294d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5623649417860952d, b: 0.046954313668518766d, c: 0.5584214927000073d),

new NpgsqlTypes.NpgsqlLine(a: 0.40329977094176095d, b: 0.5652646913147209d, c: 0.43148120834423587d),

new NpgsqlTypes.NpgsqlLine(a: 0.9114267634220189d, b: 0.13752994800715623d, c: 0.6564483163351521d),

new NpgsqlTypes.NpgsqlLine(a: 0.923103272201583d, b: 0.9972135679271568d, c: 0.8204588209055823d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.006157423084543701d, b: 0.11468009209740493d, c: 0.4365157384684908d),

new NpgsqlTypes.NpgsqlLine(a: 0.6940277663492332d, b: 0.11255866663724601d, c: 0.11128018334015688d),

new NpgsqlTypes.NpgsqlLine(a: 0.8967787649730695d, b: 0.7325971919978514d, c: 0.7599681946820005d),

new NpgsqlTypes.NpgsqlLine(a: 0.02464191269806637d, b: 0.5801895609110154d, c: 0.27531824189212784d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24738908547677751d, b: 0.47181423624289875d, c: 0.33862563137562696d),

new NpgsqlTypes.NpgsqlLine(a: 0.6354698674191203d, b: 0.7051874001750005d, c: 0.27740591720173124d),

new NpgsqlTypes.NpgsqlLine(a: 0.470961865112704d, b: 0.48230476144860435d, c: 0.35181809609712933d),

new NpgsqlTypes.NpgsqlLine(a: 0.48637517875249103d, b: 0.1803868205421476d, c: 0.19631011992533476d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8726848485160112d, b: 0.9584401476265383d, c: 0.13733255827254842d),

new NpgsqlTypes.NpgsqlLine(a: 0.07678062867104019d, b: 0.368611147000919d, c: 0.7742140236585071d),

new NpgsqlTypes.NpgsqlLine(a: 0.05643371076197856d, b: 0.6139002200433408d, c: 0.5322880077728663d),

new NpgsqlTypes.NpgsqlLine(a: 0.8388223053205923d, b: 0.7466281930995704d, c: 0.23564666191408667d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6041214094014952d, b: 0.15188228685218785d, c: 0.3616647598143685d),

new NpgsqlTypes.NpgsqlLine(a: 0.6069958761421774d, b: 0.9990960837521299d, c: 0.47050628022472085d),

new NpgsqlTypes.NpgsqlLine(a: 0.7816101634509867d, b: 0.2688428106978661d, c: 0.1284554258919779d),

new NpgsqlTypes.NpgsqlLine(a: 0.6515518778645901d, b: 0.876616079969095d, c: 0.7001066965188688d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22605551349830277d, b: 0.2869168471157232d, c: 0.2380005106968276d),

new NpgsqlTypes.NpgsqlLine(a: 0.018458761459953177d, b: 0.43243953300843163d, c: 0.8380262702871404d),

new NpgsqlTypes.NpgsqlLine(a: 0.12970517084487831d, b: 0.9061797916250426d, c: 0.18437160597999547d),

new NpgsqlTypes.NpgsqlLine(a: 0.8518003892487546d, b: 0.8019985370284163d, c: 0.04898524964825124d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1918341279061908d, b: 0.14303199763575913d, c: 0.5167442603702996d),

new NpgsqlTypes.NpgsqlLine(a: 0.731059446428481d, b: 0.6676113796723301d, c: 0.9322361729395858d),

new NpgsqlTypes.NpgsqlLine(a: 0.9737926536435496d, b: 0.3469154130365293d, c: 0.4254398492134589d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8382241231693993d, b: 0.44852959782580504d, c: 0.12456142577301565d),

new NpgsqlTypes.NpgsqlLine(a: 0.8765216169854251d, b: 0.5420353783240964d, c: 0.009007228181282967d),

new NpgsqlTypes.NpgsqlLine(a: 0.3335901676645153d, b: 0.8218836583508968d, c: 0.28815878217395297d),

new NpgsqlTypes.NpgsqlLine(a: 0.5139529940811112d, b: 0.056923681889805344d, c: 0.6271717852484121d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.39542407696356174d, b: 0.5178354125223228d, c: 0.30688994486683385d),

new NpgsqlTypes.NpgsqlLine(a: 0.8286135147073702d, b: 0.5447909496204317d, c: 0.5072686626425871d),

new NpgsqlTypes.NpgsqlLine(a: 0.6484295159316652d, b: 0.3309809226019873d, c: 0.8246470677764025d),

new NpgsqlTypes.NpgsqlLine(a: 0.6058773256818287d, b: 0.784260321095903d, c: 0.42504969826031425d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.051756065295419984d, b: 0.9209074528739164d, c: 0.6355417517475875d),

new NpgsqlTypes.NpgsqlLine(a: 0.9521113985102775d, b: 0.08489511786319537d, c: 0.6019320864026075d),

new NpgsqlTypes.NpgsqlLine(a: 0.27780823037500846d, b: 0.8411380376689259d, c: 0.003834781696738121d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.773511861409013d, b: 0.9822941142845014d, c: 0.8735089449552972d),

new NpgsqlTypes.NpgsqlLine(a: 0.8806149201110024d, b: 0.6259709302278315d, c: 0.25009989278598976d),

new NpgsqlTypes.NpgsqlLine(a: 0.6651015137169738d, b: 0.47946316008098233d, c: 0.5802842609293604d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.24569288445567405d, b: 0.13136638050689775d, c: 0.07681868075715459d),

new NpgsqlTypes.NpgsqlLine(a: 0.817282677371101d, b: 0.8693620168152983d, c: 0.7632027702757773d),

new NpgsqlTypes.NpgsqlLine(a: 0.55105310432427d, b: 0.44274341337156187d, c: 0.08358379668558624d),

new NpgsqlTypes.NpgsqlLine(a: 0.33219236156216625d, b: 0.43442601050600893d, c: 0.7801977181348826d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 120,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7256929791682222d, b: 0.5516718499114427d, c: 0.938902840110447d),

new NpgsqlTypes.NpgsqlLine(a: 0.8505343198165515d, b: 0.0973322138332483d, c: 0.9287566637206511d),

new NpgsqlTypes.NpgsqlLine(a: 0.900605465632674d, b: 0.08651814939614888d, c: 0.43854288754261384d),

new NpgsqlTypes.NpgsqlLine(a: 0.20534478827397662d, b: 0.7914841622252744d, c: 0.384566448821136d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8366373607042809d, b: 0.4226493598381099d, c: 0.40921381021872594d),

new NpgsqlTypes.NpgsqlLine(a: 0.27121353905747003d, b: 0.9422153454603922d, c: 0.5417434886540509d),

new NpgsqlTypes.NpgsqlLine(a: 0.39159712178759054d, b: 0.605937760332797d, c: 0.8115167226238142d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8383020440912904d, b: 0.49502568441375183d, c: 0.9637436952894444d),

new NpgsqlTypes.NpgsqlLine(a: 0.3154331164155849d, b: 0.2730208869934305d, c: 0.42326586310431746d),

new NpgsqlTypes.NpgsqlLine(a: 0.6786981898032054d, b: 0.7678740093398188d, c: 0.21702799539406858d),

new NpgsqlTypes.NpgsqlLine(a: 0.6518669539858029d, b: 0.7855989222367535d, c: 0.8144779582152899d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2794733197578533d, b: 0.8269423036303641d, c: 0.2898473782037364d),

new NpgsqlTypes.NpgsqlLine(a: 0.6597089985633786d, b: 0.31468191880970775d, c: 0.7433677810460507d),

new NpgsqlTypes.NpgsqlLine(a: 0.6135259790926428d, b: 0.48665151400463114d, c: 0.5714487533308641d),

new NpgsqlTypes.NpgsqlLine(a: 0.2519224593994257d, b: 0.865014220175744d, c: 0.20736202914331936d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8195935387188297d, b: 0.9315994411429944d, c: 0.5547913307413642d),

new NpgsqlTypes.NpgsqlLine(a: 0.17068603490231848d, b: 0.24501704458333584d, c: 0.8986218215173001d),

new NpgsqlTypes.NpgsqlLine(a: 0.36103257331917704d, b: 0.8124980119561988d, c: 0.10916109423887799d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 136,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2061753481679961d, b: 0.70404680469564d, c: 0.28192420743541213d),

new NpgsqlTypes.NpgsqlLine(a: 0.19403677981176193d, b: 0.295398114026429d, c: 0.29623684864330135d),

new NpgsqlTypes.NpgsqlLine(a: 0.49507119908305164d, b: 0.9543598999556676d, c: 0.18242943944630352d),

new NpgsqlTypes.NpgsqlLine(a: 0.6320669497329586d, b: 0.34223645443707396d, c: 0.8014154425134385d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.902704648354421d, b: 0.20491811857823672d, c: 0.454273838284992d),

new NpgsqlTypes.NpgsqlLine(a: 0.5322142142097714d, b: 0.28721303007165644d, c: 0.5948123751718036d),

new NpgsqlTypes.NpgsqlLine(a: 0.7924683261137319d, b: 0.7334793868007192d, c: 0.054309426206623934d),

new NpgsqlTypes.NpgsqlLine(a: 0.2541265944379312d, b: 0.30165523862461774d, c: 0.5848135579771587d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16459502720245678d, b: 0.7356414809447658d, c: 0.8296619396473542d),

new NpgsqlTypes.NpgsqlLine(a: 0.2226725118093802d, b: 0.8915289016456466d, c: 0.5274611044489144d),

new NpgsqlTypes.NpgsqlLine(a: 0.5163255065857262d, b: 0.15973213716790768d, c: 0.0701683410073134d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5207065202551576d, b: 0.7381651374997819d, c: 0.13698753024063703d),

new NpgsqlTypes.NpgsqlLine(a: 0.9667788475796705d, b: 0.5611457711035879d, c: 0.12640276533094352d),

new NpgsqlTypes.NpgsqlLine(a: 0.1150991980961642d, b: 0.7202785888400277d, c: 0.7747703692359442d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5157769271328295d, b: 0.4162632738160451d, c: 0.03836441270361168d),

new NpgsqlTypes.NpgsqlLine(a: 0.004589524587441107d, b: 0.5067924041945696d, c: 0.8849710325929812d),

new NpgsqlTypes.NpgsqlLine(a: 0.2676571196900288d, b: 0.731343286583405d, c: 0.6014135337388209d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3037399305353554d, b: 0.41079945156485254d, c: 0.1076335441128653d),

new NpgsqlTypes.NpgsqlLine(a: 0.5886402790216592d, b: 0.8027373344205098d, c: 0.8717786368327854d),

new NpgsqlTypes.NpgsqlLine(a: 0.832989244681551d, b: 0.9495346958678574d, c: 0.3534522023441369d),

new NpgsqlTypes.NpgsqlLine(a: 0.45953142912127987d, b: 0.8791719979873919d, c: 0.9400053220653549d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.670847672453828d, b: 0.2515674105338407d, c: 0.7110070391094483d),

new NpgsqlTypes.NpgsqlLine(a: 0.14094235489553641d, b: 0.41599234404101015d, c: 0.3116817571323106d),

new NpgsqlTypes.NpgsqlLine(a: 0.9821322082564605d, b: 0.16469457009005217d, c: 0.3618989757737323d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3672983491744499d, b: 0.262927627288455d, c: 0.14097006031826476d),

new NpgsqlTypes.NpgsqlLine(a: 0.5917084115223386d, b: 0.9550548872738199d, c: 0.5527337300862615d),

new NpgsqlTypes.NpgsqlLine(a: 0.9436194483099211d, b: 0.925937838077923d, c: 0.18970546588884152d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1703021445004671d, b: 0.009305532481437395d, c: 0.23932326496204848d),

new NpgsqlTypes.NpgsqlLine(a: 0.10972160332742276d, b: 0.3040959086247105d, c: 0.463780861448288d),

new NpgsqlTypes.NpgsqlLine(a: 0.9874362357237321d, b: 0.33325789091020563d, c: 0.3630040860660163d),

new NpgsqlTypes.NpgsqlLine(a: 0.26918793753644465d, b: 0.8913385819458054d, c: 0.27040934463820565d),

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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 19;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 68;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
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

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 53;
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                Assert.That(firstItems2, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
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
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
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
                parametr2.Value = 15;
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
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
                parametr1.Value = 77;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[29], false);
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
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 115;
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[29], false);
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
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 23;
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelDynParBatch",
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
                var models = await((INpgsqlLineListlineArray)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(30));
                for (int i = 0; i < 30; i++)
                {
                    NpgsqlLinelineArray2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 136;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 8;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 44;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[29], false);
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

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 116, query1, 78, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                Assert.That(firstItems2, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 93, query1, 23, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 23, query1, 95, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                Assert.That(firstItems2, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[29], false);
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
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var firstItems2 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 8, query1, 129, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(3));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[29], false);
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
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
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
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
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
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 93, query1, 23, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 77, query1, 15, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                Assert.That(secondItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[29], false);
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
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 102, query1, 136, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[29], false);
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
FROM public.npgsqllinelinearray2m m
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
FROM public.npgsqllinelinearray2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems1 = new List<FlatNpgsqlLinelineArray2M>();
                var secondItems2 = new List<FlatNpgsqlLinelineArray2M>();
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 116, query1, 19, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[29], false);
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
            batchName: "DbConnectionSTSelectModelBatch",
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
        private void DbConnectionSTSelectModelBatchConfig()
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
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 116, 15))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
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
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 8, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(28));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[2], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[3], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 116);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 7);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(29));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
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

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryImportModelInnerTest()
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
                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
");
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
            queryMapType: typeof(NpgsqlLinelineArray2MI),
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
            queryMapType: typeof(NpgsqlLinelineArray2M),
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

