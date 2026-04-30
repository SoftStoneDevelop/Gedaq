

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
    Id = 4,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5143440075453086d, b: 0.687742902379018d, c: 0.16695188841999808d),

new NpgsqlTypes.NpgsqlLine(a: 0.01400938709712607d, b: 0.8117528018410266d, c: 0.9859195615796985d),

new NpgsqlTypes.NpgsqlLine(a: 0.060767542766657856d, b: 0.9554809513759458d, c: 0.9986863169188294d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 5,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.17549973608766445d, b: 0.17557562628946988d, c: 0.4266139690675781d),

new NpgsqlTypes.NpgsqlLine(a: 0.06604957349371221d, b: 0.19118398376596257d, c: 0.6759317942732811d),

new NpgsqlTypes.NpgsqlLine(a: 0.2033635870243865d, b: 0.23722976619112168d, c: 0.7330560451854445d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 1,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.21339282283913952d, b: 0.10210730052553962d, c: 0.006746651932007075d),

new NpgsqlTypes.NpgsqlLine(a: 0.4237154241073615d, b: 0.9863030089623164d, c: 0.8234128345281996d),

new NpgsqlTypes.NpgsqlLine(a: 0.320524533596219d, b: 0.8007017475547852d, c: 0.02288467510098835d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.585936159100892d, b: 0.693254775062939d, c: 0.8312525259467205d),

new NpgsqlTypes.NpgsqlLine(a: 0.5390931192856121d, b: 0.026813291310205267d, c: 0.597611191246005d),

new NpgsqlTypes.NpgsqlLine(a: 0.18742959822745187d, b: 0.8527434625792312d, c: 0.012655707479269585d),

new NpgsqlTypes.NpgsqlLine(a: 0.26982205038974205d, b: 0.2533335125995818d, c: 0.19446182332222195d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4519494785987448d, b: 0.009273350523094637d, c: 0.06892715994023291d),

new NpgsqlTypes.NpgsqlLine(a: 0.6484027341990467d, b: 0.2546067058495812d, c: 0.5880943163447871d),

new NpgsqlTypes.NpgsqlLine(a: 0.08114875632409047d, b: 0.22633633927843566d, c: 0.7703356952282461d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8125602125440848d, b: 0.13834394079007284d, c: 0.8787579044900472d),

new NpgsqlTypes.NpgsqlLine(a: 0.8947920872845535d, b: 0.8424331710046152d, c: 0.7531778282885143d),

new NpgsqlTypes.NpgsqlLine(a: 0.659079457244763d, b: 0.7229255540015731d, c: 0.5029991620365611d),

new NpgsqlTypes.NpgsqlLine(a: 0.5569743499048069d, b: 0.5057106681098469d, c: 0.3305469656594149d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.07055843989907373d, b: 0.3483261931091872d, c: 0.2832051306167973d),

new NpgsqlTypes.NpgsqlLine(a: 0.5576091027121778d, b: 0.7418614271904252d, c: 0.5958177129128426d),

new NpgsqlTypes.NpgsqlLine(a: 0.44092901631810155d, b: 0.920522682167323d, c: 0.7456458049258061d),

new NpgsqlTypes.NpgsqlLine(a: 0.832704439415713d, b: 0.18116335503657666d, c: 7.984313507880536E-05d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7813681430229162d, b: 0.0073825025254088406d, c: 0.2043279259453883d),

new NpgsqlTypes.NpgsqlLine(a: 0.9133149731726203d, b: 0.5967021954084795d, c: 0.3183169269284265d),

new NpgsqlTypes.NpgsqlLine(a: 0.7130819740327252d, b: 0.1708470874127368d, c: 0.34546425177854445d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 6,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2951038794489057d, b: 0.5181665784960643d, c: 0.49967408485641385d),

new NpgsqlTypes.NpgsqlLine(a: 0.8316226724786331d, b: 0.14525246852024065d, c: 0.9785232012378265d),

new NpgsqlTypes.NpgsqlLine(a: 0.08804486707616466d, b: 0.7004014312815572d, c: 0.4884531416631992d),

new NpgsqlTypes.NpgsqlLine(a: 0.10541115983532479d, b: 0.3348908243944786d, c: 0.44467858261708326d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9866872064982768d, b: 0.9862213297780942d, c: 0.4592529217440172d),

new NpgsqlTypes.NpgsqlLine(a: 0.4961980254715844d, b: 0.4931801901933226d, c: 0.04492037455051734d),

new NpgsqlTypes.NpgsqlLine(a: 0.5458162622714763d, b: 0.8959028291726241d, c: 0.42696247335398474d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.25711105806132306d, b: 0.5294075532788608d, c: 0.23454108956622977d),

new NpgsqlTypes.NpgsqlLine(a: 0.5868046136059806d, b: 0.11543653407265586d, c: 0.5672774949925136d),

new NpgsqlTypes.NpgsqlLine(a: 0.18628996053072833d, b: 0.280022061072116d, c: 0.43505299279929865d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3966835810402167d, b: 0.2738037041678353d, c: 0.3898977406185524d),

new NpgsqlTypes.NpgsqlLine(a: 0.36648178212821103d, b: 0.8635930472568633d, c: 0.041815712735795874d),

new NpgsqlTypes.NpgsqlLine(a: 0.9438546777766393d, b: 0.5985885043437732d, c: 0.8909087076315716d),

new NpgsqlTypes.NpgsqlLine(a: 0.4069104909131306d, b: 0.7803463913023198d, c: 0.45833233148261254d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6062318451291043d, b: 0.20845107120643014d, c: 0.07714239405113843d),

new NpgsqlTypes.NpgsqlLine(a: 0.6624541171639442d, b: 0.976918398512674d, c: 0.9402955662682464d),

new NpgsqlTypes.NpgsqlLine(a: 0.2326866041497847d, b: 0.10222695435131202d, c: 0.9446350838534131d),

new NpgsqlTypes.NpgsqlLine(a: 0.09635780569871821d, b: 0.525616035200783d, c: 0.21475086379497577d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9539823650174784d, b: 0.39837876444601583d, c: 0.5750162155441013d),

new NpgsqlTypes.NpgsqlLine(a: 0.06453249989774223d, b: 0.9137003937901573d, c: 0.45840529700887667d),

new NpgsqlTypes.NpgsqlLine(a: 0.9526750277533289d, b: 0.15263364915805455d, c: 0.15002811328336574d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6472366979405902d, b: 0.15798400820637826d, c: 0.5178847472331104d),

new NpgsqlTypes.NpgsqlLine(a: 0.10249392733038731d, b: 0.9204909412327642d, c: 0.5892825660812503d),

new NpgsqlTypes.NpgsqlLine(a: 0.3280154581078941d, b: 0.2535680241821492d, c: 0.09267328551896292d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8044391698226554d, b: 0.17253764258772686d, c: 0.5519919900457267d),

new NpgsqlTypes.NpgsqlLine(a: 0.8136638296375309d, b: 0.27517659052270427d, c: 0.8188781698993988d),

new NpgsqlTypes.NpgsqlLine(a: 0.28633568671504916d, b: 0.8917610205838074d, c: 0.6683816023087988d),

new NpgsqlTypes.NpgsqlLine(a: 0.4973659017908387d, b: 0.6441747606777001d, c: 0.6652266762805945d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1822024327751901d, b: 0.5341927467574089d, c: 0.1429734733323551d),

new NpgsqlTypes.NpgsqlLine(a: 0.9709215502508277d, b: 0.09612862726696136d, c: 0.928532681489439d),

new NpgsqlTypes.NpgsqlLine(a: 0.04683320059309837d, b: 0.3946102632129652d, c: 0.3795784187911647d),

new NpgsqlTypes.NpgsqlLine(a: 0.7754669505432303d, b: 0.8985840286484778d, c: 0.28198468219273554d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7217399979904661d, b: 0.5082882370653605d, c: 0.582548837367837d),

new NpgsqlTypes.NpgsqlLine(a: 0.40182835478621826d, b: 0.27130777417078944d, c: 0.20898952454514996d),

new NpgsqlTypes.NpgsqlLine(a: 0.14981260472694335d, b: 0.8282356995120417d, c: 0.42391948511819144d),

new NpgsqlTypes.NpgsqlLine(a: 0.9091499257453886d, b: 0.9084999453136016d, c: 0.6905851214707457d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8701600871275137d, b: 0.33316687145413626d, c: 0.6901361002637525d),

new NpgsqlTypes.NpgsqlLine(a: 0.5792206249979667d, b: 0.14785255789920293d, c: 0.1131385909337349d),

new NpgsqlTypes.NpgsqlLine(a: 0.3273876458030913d, b: 0.812603232606086d, c: 0.20139656870237022d),

new NpgsqlTypes.NpgsqlLine(a: 0.7009977350161272d, b: 0.5301047464593941d, c: 0.14930453714426473d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.552395253710009d, b: 0.8048871879509143d, c: 0.07258041154011663d),

new NpgsqlTypes.NpgsqlLine(a: 0.20949526431730403d, b: 0.08153260583653588d, c: 0.9537808599802735d),

new NpgsqlTypes.NpgsqlLine(a: 0.4675994388792034d, b: 0.9968515041506093d, c: 0.9556506064178961d),

new NpgsqlTypes.NpgsqlLine(a: 0.17707830888885723d, b: 0.8627996340552478d, c: 0.4493049059853421d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9491882113757869d, b: 0.9680960578292581d, c: 0.580088484079841d),

new NpgsqlTypes.NpgsqlLine(a: 0.28401121851941236d, b: 0.5796939115467467d, c: 0.7101227935841841d),

new NpgsqlTypes.NpgsqlLine(a: 0.9700807306858155d, b: 0.30986301458158916d, c: 0.3280921601109036d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3865583282462255d, b: 0.7419036095660982d, c: 0.7609526065493392d),

new NpgsqlTypes.NpgsqlLine(a: 0.9620388708388428d, b: 0.3133913903490796d, c: 0.8450335574113885d),

new NpgsqlTypes.NpgsqlLine(a: 0.31470127467689135d, b: 0.13115834195837484d, c: 0.4205056810554888d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 10,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38089252952717856d, b: 0.9929124566047983d, c: 0.8556858429362659d),

new NpgsqlTypes.NpgsqlLine(a: 0.8386645153656627d, b: 0.8320483011039327d, c: 0.13760313239359567d),

new NpgsqlTypes.NpgsqlLine(a: 0.2508119093802196d, b: 0.36671880070266794d, c: 0.4545463992636245d),

new NpgsqlTypes.NpgsqlLine(a: 0.08776044357442303d, b: 0.7562365201169658d, c: 0.9004199332964303d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6718819376618864d, b: 0.9153788498408281d, c: 0.26926621329900313d),

new NpgsqlTypes.NpgsqlLine(a: 0.23267152499539845d, b: 0.5680154370022666d, c: 0.9967028974174467d),

new NpgsqlTypes.NpgsqlLine(a: 0.4523423950224392d, b: 0.32872697942150897d, c: 0.36906412261462085d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6784864222793318d, b: 0.4697168442716435d, c: 0.23674879149926276d),

new NpgsqlTypes.NpgsqlLine(a: 0.1683293405274504d, b: 0.02454675383376348d, c: 0.19571825075572347d),

new NpgsqlTypes.NpgsqlLine(a: 0.6518201781054674d, b: 0.20461342301651586d, c: 0.7311306478486794d),

new NpgsqlTypes.NpgsqlLine(a: 0.2668779016012538d, b: 0.49638856612417526d, c: 0.8394108508822403d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5020194086132856d, b: 0.8958846027509113d, c: 0.37459014117423395d),

new NpgsqlTypes.NpgsqlLine(a: 0.9803021227526869d, b: 0.07229043375947264d, c: 0.042322159677007254d),

new NpgsqlTypes.NpgsqlLine(a: 0.8436398011158861d, b: 0.3892563122118754d, c: 0.860031496951402d),

new NpgsqlTypes.NpgsqlLine(a: 0.8222608923247111d, b: 0.4008477316401138d, c: 0.13743773711262397d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4968103782913065d, b: 0.3962779507177082d, c: 0.8032170323020879d),

new NpgsqlTypes.NpgsqlLine(a: 0.8285165413646779d, b: 0.26546649638703d, c: 0.17550100610759267d),

new NpgsqlTypes.NpgsqlLine(a: 0.3482748806511704d, b: 0.48286094467645446d, c: 0.30813583140922707d),

new NpgsqlTypes.NpgsqlLine(a: 0.8856134163204273d, b: 0.0033761478857468052d, c: 0.871866048894964d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6900183899348348d, b: 0.18612177514829698d, c: 0.1695298797215118d),

new NpgsqlTypes.NpgsqlLine(a: 0.8562638848292679d, b: 0.7000200370170093d, c: 0.7572944840662799d),

new NpgsqlTypes.NpgsqlLine(a: 0.02466485966642562d, b: 0.7591635691325762d, c: 0.9251159346053435d),

new NpgsqlTypes.NpgsqlLine(a: 0.6977832263532036d, b: 0.29896488835001545d, c: 0.7973650016797404d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.37225877244390804d, b: 0.7955167638850571d, c: 0.5161260827226851d),

new NpgsqlTypes.NpgsqlLine(a: 0.3647349535558696d, b: 0.45997274340855554d, c: 0.13331558590266646d),

new NpgsqlTypes.NpgsqlLine(a: 0.8971363704916863d, b: 0.4024225291036816d, c: 0.11917919396811982d),

new NpgsqlTypes.NpgsqlLine(a: 0.3896959628215886d, b: 0.37628108003051786d, c: 0.9688496742321424d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6642096491283116d, b: 0.7094508266466784d, c: 0.5280069910935609d),

new NpgsqlTypes.NpgsqlLine(a: 0.6133128912955675d, b: 0.2962460400512017d, c: 0.9790923339680183d),

new NpgsqlTypes.NpgsqlLine(a: 0.1590683818943498d, b: 0.12377435753874522d, c: 0.6278197483105424d),

new NpgsqlTypes.NpgsqlLine(a: 0.22633309128056278d, b: 0.7857297332152594d, c: 0.9508816951181706d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6452766419424828d, b: 0.6196787786419481d, c: 0.16813238529729047d),

new NpgsqlTypes.NpgsqlLine(a: 0.22566823122236934d, b: 0.44925684608590977d, c: 0.9518992752995478d),

new NpgsqlTypes.NpgsqlLine(a: 0.5464180429642673d, b: 0.1906301241914089d, c: 0.9628034805698955d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45337180214028316d, b: 0.818295099754985d, c: 0.7673657041129912d),

new NpgsqlTypes.NpgsqlLine(a: 0.17337580378717832d, b: 0.8084058161434808d, c: 0.8633878088276288d),

new NpgsqlTypes.NpgsqlLine(a: 0.9905806768938616d, b: 0.23819837545583178d, c: 0.2006400338399419d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5164207705333625d, b: 0.5132152130695035d, c: 0.5175383820831458d),

new NpgsqlTypes.NpgsqlLine(a: 0.16419200040527626d, b: 0.9566090987552385d, c: 0.8130883853339129d),

new NpgsqlTypes.NpgsqlLine(a: 0.3064852007234872d, b: 0.5432984476725401d, c: 0.22448977757062905d),

new NpgsqlTypes.NpgsqlLine(a: 0.8327046612885263d, b: 0.18351698212762657d, c: 0.7849428722422039d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32639228485344607d, b: 0.08726308712953523d, c: 0.652444719434816d),

new NpgsqlTypes.NpgsqlLine(a: 0.9644223069095513d, b: 0.14541961786528235d, c: 0.23495786342723435d),

new NpgsqlTypes.NpgsqlLine(a: 0.28803577145690806d, b: 0.10871749467133629d, c: 0.7284988555305917d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9944181726626082d, b: 0.15487113140634d, c: 0.052872683777520746d),

new NpgsqlTypes.NpgsqlLine(a: 0.6797187363375686d, b: 0.9661258440949119d, c: 0.38986711317023603d),

new NpgsqlTypes.NpgsqlLine(a: 0.07084657266937211d, b: 0.0011814453174412431d, c: 0.8278037691600638d),

new NpgsqlTypes.NpgsqlLine(a: 0.20198527878186956d, b: 0.7962751835925626d, c: 0.34331538699204367d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 23,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22575990261142453d, b: 0.7663506509496413d, c: 0.45508771280142024d),

new NpgsqlTypes.NpgsqlLine(a: 0.17804662928969817d, b: 0.44456229983857454d, c: 0.8442831340199018d),

new NpgsqlTypes.NpgsqlLine(a: 0.5199655305979229d, b: 0.6426726048038685d, c: 0.10433481631067121d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08614474705879405d, b: 0.05357959185705519d, c: 0.408441725260688d),

new NpgsqlTypes.NpgsqlLine(a: 0.7881510519552687d, b: 0.21788669409759553d, c: 0.40650627934456307d),

new NpgsqlTypes.NpgsqlLine(a: 0.958363101908162d, b: 0.19227464658508886d, c: 0.7958824777721902d),

new NpgsqlTypes.NpgsqlLine(a: 0.1215917978211124d, b: 0.5935271978232018d, c: 0.6990920801403173d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 81,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6016284300811495d, b: 0.08598217107205952d, c: 0.6083137486580642d),

new NpgsqlTypes.NpgsqlLine(a: 0.11997067170217268d, b: 0.5347483666582677d, c: 0.039801616655422256d),

new NpgsqlTypes.NpgsqlLine(a: 0.5515902163309622d, b: 0.30940345581509987d, c: 0.18377474563251095d),

new NpgsqlTypes.NpgsqlLine(a: 0.3535983125214682d, b: 0.8469033719367565d, c: 0.7979411832914713d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.656061651909317d, b: 0.26154836414997085d, c: 0.7128961179254547d),

new NpgsqlTypes.NpgsqlLine(a: 0.730673041679287d, b: 0.7696117956778197d, c: 0.6017001987152184d),

new NpgsqlTypes.NpgsqlLine(a: 0.49289692657001993d, b: 0.4077177172805201d, c: 0.9698591158792362d),

new NpgsqlTypes.NpgsqlLine(a: 0.720583962204953d, b: 0.5415375120198996d, c: 0.7919131161601263d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 86,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6718555878846515d, b: 0.06316227289671761d, c: 0.74905185762067d),

new NpgsqlTypes.NpgsqlLine(a: 0.023819079156224277d, b: 0.10058722516018836d, c: 0.35060167402286513d),

new NpgsqlTypes.NpgsqlLine(a: 0.4205446888628147d, b: 0.005401689090611672d, c: 0.3677453537802763d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6394771868038096d, b: 0.5128676808207755d, c: 0.012364294348014226d),

new NpgsqlTypes.NpgsqlLine(a: 0.5584707624985975d, b: 0.7511226064143425d, c: 0.03250937961942901d),

new NpgsqlTypes.NpgsqlLine(a: 0.041051678748421194d, b: 0.3086668177984183d, c: 0.9084532915655106d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4643611959394305d, b: 0.9776607369918913d, c: 0.11351032186246457d),

new NpgsqlTypes.NpgsqlLine(a: 0.5261392293738594d, b: 0.28629057770153754d, c: 0.32812190071976677d),

new NpgsqlTypes.NpgsqlLine(a: 0.8204131804298302d, b: 0.5060193755751237d, c: 0.6500702673276458d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 90,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8869147189715514d, b: 0.6315392453191896d, c: 0.12079073207129742d),

new NpgsqlTypes.NpgsqlLine(a: 0.7004118708509712d, b: 0.2748653385000498d, c: 0.8401466276079883d),

new NpgsqlTypes.NpgsqlLine(a: 0.5918313292732562d, b: 0.2200164783030113d, c: 0.9770209010234843d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5379278059074957d, b: 0.5731970249949196d, c: 0.8252126651615007d),

new NpgsqlTypes.NpgsqlLine(a: 0.7047120131462659d, b: 0.07569989313732417d, c: 0.67699045723406d),

new NpgsqlTypes.NpgsqlLine(a: 0.48494170323755537d, b: 0.7495693747771344d, c: 0.8493858423086582d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 92,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.40915935404091786d, b: 0.4152288247355478d, c: 0.0267174127120815d),

new NpgsqlTypes.NpgsqlLine(a: 0.5600495628927349d, b: 0.6011571180592593d, c: 0.7277848475475008d),

new NpgsqlTypes.NpgsqlLine(a: 0.7638189066537103d, b: 0.9944439063203052d, c: 0.36568760967261715d),

new NpgsqlTypes.NpgsqlLine(a: 0.5448636499035503d, b: 0.18477077729063218d, c: 0.835479496732061d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08323260581195202d, b: 0.8711237927208839d, c: 0.8186841180785186d),

new NpgsqlTypes.NpgsqlLine(a: 0.9985477427926753d, b: 0.8091950444660113d, c: 0.19419028548437767d),

new NpgsqlTypes.NpgsqlLine(a: 0.42395338712408126d, b: 0.8582642336430545d, c: 0.7280887551460796d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3434000949826772d, b: 0.9559287106072993d, c: 0.09337058107983331d),

new NpgsqlTypes.NpgsqlLine(a: 0.6599426882050311d, b: 0.7381057778285933d, c: 0.783420918469472d),

new NpgsqlTypes.NpgsqlLine(a: 0.26370234797285064d, b: 0.44830940829343857d, c: 0.21700856842688665d),

new NpgsqlTypes.NpgsqlLine(a: 0.1826483410789025d, b: 0.7060086206086842d, c: 0.46568196096815473d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.3153955236853335d, b: 0.7324344364281008d, c: 0.7322698425592848d),

new NpgsqlTypes.NpgsqlLine(a: 0.014743051390421424d, b: 0.3058546576293564d, c: 0.7198986086444368d),

new NpgsqlTypes.NpgsqlLine(a: 0.45057973939509055d, b: 0.11861143672561192d, c: 0.5283084370066112d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 101,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.901647139820739d, b: 0.7058044456040806d, c: 0.06744554318192264d),

new NpgsqlTypes.NpgsqlLine(a: 0.3241850463375391d, b: 0.8701514413135646d, c: 0.4775310132452778d),

new NpgsqlTypes.NpgsqlLine(a: 0.9023580927241831d, b: 0.985748207607024d, c: 0.2906748902542067d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18768702176836205d, b: 0.9500362328131184d, c: 0.2411720649097734d),

new NpgsqlTypes.NpgsqlLine(a: 0.8637716903587394d, b: 0.8925929522879708d, c: 0.09326590742918062d),

new NpgsqlTypes.NpgsqlLine(a: 0.41287200349929776d, b: 0.3467170111586225d, c: 0.3027757185941634d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.255572504244724d, b: 0.06799311519701068d, c: 0.21506324622249529d),

new NpgsqlTypes.NpgsqlLine(a: 0.8910471809842628d, b: 0.3829159685931326d, c: 0.03090163123128753d),

new NpgsqlTypes.NpgsqlLine(a: 0.9266556979115244d, b: 0.620008420377308d, c: 0.9969495845563993d),

new NpgsqlTypes.NpgsqlLine(a: 0.7935462296838474d, b: 0.1629329881801338d, c: 0.9078045919242479d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11029222344254952d, b: 0.015526807601215054d, c: 0.7818910198995561d),

new NpgsqlTypes.NpgsqlLine(a: 0.2990727910465949d, b: 0.48710723157457103d, c: 0.375282308016481d),

new NpgsqlTypes.NpgsqlLine(a: 0.8355374962026995d, b: 0.3213264869443909d, c: 0.8865909010951528d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6078546895477168d, b: 0.15148276602080735d, c: 0.05066671782583532d),

new NpgsqlTypes.NpgsqlLine(a: 0.17417700128963975d, b: 0.07860677671684857d, c: 0.4601262662260007d),

new NpgsqlTypes.NpgsqlLine(a: 0.6100162628260091d, b: 0.4689660011869152d, c: 0.2078183166512979d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5090941675215377d, b: 0.7565420325671756d, c: 0.7132671028133468d),

new NpgsqlTypes.NpgsqlLine(a: 0.8793971871518373d, b: 0.3979535603668698d, c: 0.8792918356464218d),

new NpgsqlTypes.NpgsqlLine(a: 0.21825484655117644d, b: 0.9074928420865915d, c: 0.16049717719722922d),

new NpgsqlTypes.NpgsqlLine(a: 0.3258391054075851d, b: 0.5542622801382144d, c: 0.38061630427171556d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8435359940123138d, b: 0.5522616292163216d, c: 0.9976361788889028d),

new NpgsqlTypes.NpgsqlLine(a: 0.8203339509504665d, b: 0.0123447977295712d, c: 0.6908561399193927d),

new NpgsqlTypes.NpgsqlLine(a: 0.12041729166879478d, b: 0.1431247698706294d, c: 0.8521049932632804d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 114,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.20448233004141214d, b: 0.5903097192800416d, c: 0.4151666161925175d),

new NpgsqlTypes.NpgsqlLine(a: 0.8482623532136134d, b: 0.5943482157827271d, c: 0.14637460797024637d),

new NpgsqlTypes.NpgsqlLine(a: 0.4423498434809171d, b: 0.9450125514333376d, c: 0.9687901625103977d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.054084951189771746d, b: 0.6680395561186505d, c: 0.7661888203033144d),

new NpgsqlTypes.NpgsqlLine(a: 0.48864114527326674d, b: 0.02517447789474736d, c: 0.9384815798838668d),

new NpgsqlTypes.NpgsqlLine(a: 0.09642827745415938d, b: 0.0875834822800804d, c: 0.49848562849952605d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18729101006311355d, b: 0.7788589174873223d, c: 0.343731441937707d),

new NpgsqlTypes.NpgsqlLine(a: 0.8762138054187062d, b: 0.8352855213404773d, c: 0.268492422228382d),

new NpgsqlTypes.NpgsqlLine(a: 0.3586868700967367d, b: 0.3896606923109539d, c: 0.19229216968466212d),

new NpgsqlTypes.NpgsqlLine(a: 0.3687583319421813d, b: 0.1665570756635365d, c: 0.9724531455115173d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 127,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4514702644883346d, b: 0.619039296810074d, c: 0.36589040583966537d),

new NpgsqlTypes.NpgsqlLine(a: 0.22786380635917114d, b: 0.6526076317756389d, c: 0.057897573401440194d),

new NpgsqlTypes.NpgsqlLine(a: 0.6305900530031503d, b: 0.12035595593063608d, c: 0.14343492361753185d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.11179789974966736d, b: 0.5533559423872443d, c: 0.7886299556382319d),

new NpgsqlTypes.NpgsqlLine(a: 0.4896665351519752d, b: 0.06141548538707853d, c: 0.9967813074080947d),

new NpgsqlTypes.NpgsqlLine(a: 0.19891086315533735d, b: 0.020573432384988433d, c: 0.6541795987155488d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7694170725424143d, b: 0.27971913167389895d, c: 0.8820172137521012d),

new NpgsqlTypes.NpgsqlLine(a: 0.46863762036443823d, b: 0.6148753241255601d, c: 0.13506622871528084d),

new NpgsqlTypes.NpgsqlLine(a: 0.8976225970708755d, b: 0.6878871554863072d, c: 0.4820676363317069d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 132,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31437495801140014d, b: 0.1282676089612621d, c: 0.04587684502028d),

new NpgsqlTypes.NpgsqlLine(a: 0.7220324212261736d, b: 0.8850497499871228d, c: 0.8554934365422042d),

new NpgsqlTypes.NpgsqlLine(a: 0.7234192495759765d, b: 0.26427267521553444d, c: 0.6853655457843102d),

new NpgsqlTypes.NpgsqlLine(a: 0.5258961895399448d, b: 0.25932770303205044d, c: 0.42754083324273984d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7631642475148408d, b: 0.42615778702379814d, c: 0.6656399976962449d),

new NpgsqlTypes.NpgsqlLine(a: 0.45275769643572583d, b: 0.4850843269630475d, c: 0.24185437188979542d),

new NpgsqlTypes.NpgsqlLine(a: 0.6415510348964809d, b: 0.057843324485392644d, c: 0.25385211365090155d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 52,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7834447094564957d, b: 0.6357877145608933d, c: 0.8475142948251396d),

new NpgsqlTypes.NpgsqlLine(a: 0.5662754478905386d, b: 0.9140704230673926d, c: 0.8471742387162503d),

new NpgsqlTypes.NpgsqlLine(a: 0.6034124351230254d, b: 0.7745603754744095d, c: 0.3494790229628494d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5917040992353523d, b: 0.07674223863701868d, c: 0.27991430531700545d),

new NpgsqlTypes.NpgsqlLine(a: 0.866657077497417d, b: 0.8190084241596399d, c: 0.7665731384413097d),

new NpgsqlTypes.NpgsqlLine(a: 0.42669123764801853d, b: 0.16842374098163815d, c: 0.43453685896493754d),

new NpgsqlTypes.NpgsqlLine(a: 0.828379153979989d, b: 0.18725626900751713d, c: 0.9613235282237723d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6024832192865585d, b: 0.24313511391097997d, c: 0.4158078678560345d),

new NpgsqlTypes.NpgsqlLine(a: 0.2255834999255747d, b: 0.1151706980693803d, c: 0.10931373069800854d),

new NpgsqlTypes.NpgsqlLine(a: 0.4380831175112957d, b: 0.7126707512072636d, c: 0.4816675264699348d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.45058022100248685d, b: 0.047793645648502525d, c: 0.47703709425541063d),

new NpgsqlTypes.NpgsqlLine(a: 0.4406210828262699d, b: 0.8665505480117786d, c: 0.036664719822386505d),

new NpgsqlTypes.NpgsqlLine(a: 0.1041905517336994d, b: 0.11601451660831663d, c: 0.12342306721600504d),

new NpgsqlTypes.NpgsqlLine(a: 0.8774215090637028d, b: 0.5794763490164039d, c: 0.549190088425132d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8270035139780681d, b: 0.705798351286121d, c: 0.1796618214636988d),

new NpgsqlTypes.NpgsqlLine(a: 0.1217338446004016d, b: 0.218782213572834d, c: 0.2199064035330186d),

new NpgsqlTypes.NpgsqlLine(a: 0.26605990199854146d, b: 0.9469688881381152d, c: 0.824642864069001d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.35765008392507247d, b: 0.9691213890118806d, c: 0.4258437301486383d),

new NpgsqlTypes.NpgsqlLine(a: 0.255377309996612d, b: 0.361180403278792d, c: 0.9851817132702624d),

new NpgsqlTypes.NpgsqlLine(a: 0.6802165722267417d, b: 0.1929221086368872d, c: 0.7086305629452783d),

new NpgsqlTypes.NpgsqlLine(a: 0.4830168909914735d, b: 0.4433464096350208d, c: 0.8151818349749692d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2529530176272867d, b: 0.4241729098032636d, c: 0.922077839090312d),

new NpgsqlTypes.NpgsqlLine(a: 0.05568426889018285d, b: 0.04233642579352703d, c: 0.5066732346613295d),

new NpgsqlTypes.NpgsqlLine(a: 0.44250513648335144d, b: 0.8671608378236718d, c: 0.5458233504748268d),

new NpgsqlTypes.NpgsqlLine(a: 0.24464843196110575d, b: 0.9589214669257384d, c: 0.6841805923356524d),

},
},
    NullableValue = null,
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
                parametr1.Value = 80;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 4;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[28],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[29], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 75;
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
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                Assert.That(firstItems2, Has.Count.EqualTo(27));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[26],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(15));
                Assert.That(secondItems2, Has.Count.EqualTo(15));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 28;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 46;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[29], false);
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
                parametr1.Value = 46;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 81;
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
                        Assert.That(models, Has.Count.EqualTo(22));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 90;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[29], false);
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
                parametr1.Value = 102;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 14;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
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
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 63;
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
                Assert.That(firstItems1, Has.Count.EqualTo(19));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[29], false);
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
                parametr1.Value = 62;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 102;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
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
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 64;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[29], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 46, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[29], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 127, query1, 86, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                Assert.That(firstItems2, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 28, query1, 92, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 46, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                Assert.That(firstItems2, Has.Count.EqualTo(22));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 14, query1, 102, query2))
                {
                    if(++resultIndex == 1)
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

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 72, query1, 80, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 123, query1, 123, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 33, query1, 72, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[29], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[29], false);
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 54, 127))
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
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 62, 20))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[29], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(26));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 14);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(27));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[3], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[26],_testData[29], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 20);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(26));
NpgsqlLinelineArray2M.AssertModel(models[0],_testData[4], false);NpgsqlLinelineArray2M.AssertModel(models[1],_testData[5], false);NpgsqlLinelineArray2M.AssertModel(models[2],_testData[6], false);NpgsqlLinelineArray2M.AssertModel(models[3],_testData[7], false);NpgsqlLinelineArray2M.AssertModel(models[4],_testData[8], false);NpgsqlLinelineArray2M.AssertModel(models[5],_testData[9], false);NpgsqlLinelineArray2M.AssertModel(models[6],_testData[10], false);NpgsqlLinelineArray2M.AssertModel(models[7],_testData[11], false);NpgsqlLinelineArray2M.AssertModel(models[8],_testData[12], false);NpgsqlLinelineArray2M.AssertModel(models[9],_testData[13], false);NpgsqlLinelineArray2M.AssertModel(models[10],_testData[14], false);NpgsqlLinelineArray2M.AssertModel(models[11],_testData[15], false);NpgsqlLinelineArray2M.AssertModel(models[12],_testData[16], false);NpgsqlLinelineArray2M.AssertModel(models[13],_testData[17], false);NpgsqlLinelineArray2M.AssertModel(models[14],_testData[18], false);NpgsqlLinelineArray2M.AssertModel(models[15],_testData[19], false);NpgsqlLinelineArray2M.AssertModel(models[16],_testData[20], false);NpgsqlLinelineArray2M.AssertModel(models[17],_testData[21], false);NpgsqlLinelineArray2M.AssertModel(models[18],_testData[22], false);NpgsqlLinelineArray2M.AssertModel(models[19],_testData[23], false);NpgsqlLinelineArray2M.AssertModel(models[20],_testData[24], false);NpgsqlLinelineArray2M.AssertModel(models[21],_testData[25], false);NpgsqlLinelineArray2M.AssertModel(models[22],_testData[26], false);NpgsqlLinelineArray2M.AssertModel(models[23],_testData[27], false);NpgsqlLinelineArray2M.AssertModel(models[24],_testData[28], false);NpgsqlLinelineArray2M.AssertModel(models[25],_testData[29], false);
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
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
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
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlLineListlineArray)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlLinelineArray2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlLineListlineArray)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(actual, expect, false);
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

        [Test, Order(2)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 12; i < 30; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(15));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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

        [Test, Order(5)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

        [Test, Order(6)]
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

