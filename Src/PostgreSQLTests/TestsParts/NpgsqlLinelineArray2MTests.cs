

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
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7270837340145111d, b: 0.9872927152496987d, c: 0.15506291426503926d),

new NpgsqlTypes.NpgsqlLine(a: 0.010648521115846687d, b: 0.5849750448985872d, c: 0.5484569995131395d),

new NpgsqlTypes.NpgsqlLine(a: 0.11099747246001479d, b: 0.41171870600043303d, c: 0.3310069341000679d),

new NpgsqlTypes.NpgsqlLine(a: 0.18869497754612508d, b: 0.10485640611831504d, c: 0.5701330067990449d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5616070692178853d, b: 0.9329073026699977d, c: 0.8182857074086778d),

new NpgsqlTypes.NpgsqlLine(a: 0.2064382645174233d, b: 0.6666794833990921d, c: 0.9988587314719823d),

new NpgsqlTypes.NpgsqlLine(a: 0.014389458629885166d, b: 0.37546654584610517d, c: 0.5209578036417764d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 2,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04388283942067972d, b: 0.7601643083134568d, c: 0.24798224844038208d),

new NpgsqlTypes.NpgsqlLine(a: 0.08481634963821572d, b: 0.45631530340578175d, c: 0.7832898637772284d),

new NpgsqlTypes.NpgsqlLine(a: 0.3874739039957886d, b: 0.20584273597575886d, c: 0.8854564806655548d),

new NpgsqlTypes.NpgsqlLine(a: 0.20327010786234367d, b: 0.1752889241434109d, c: 0.1198929123878617d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8865757370989735d, b: 0.48461486597913106d, c: 0.5251448895924287d),

new NpgsqlTypes.NpgsqlLine(a: 0.8998170696589259d, b: 0.6452408936971066d, c: 0.5041997137856848d),

new NpgsqlTypes.NpgsqlLine(a: 0.5851357378141888d, b: 0.6363291402093356d, c: 0.3723655460159775d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5249508359241831d, b: 0.9558120081019215d, c: 0.36395358260838273d),

new NpgsqlTypes.NpgsqlLine(a: 0.21327924301849d, b: 0.03874095856447235d, c: 0.8815774376997141d),

new NpgsqlTypes.NpgsqlLine(a: 0.8592833991324095d, b: 0.8747440058749328d, c: 0.19193279691483334d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 17,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18833444397506804d, b: 0.8337891183698674d, c: 0.07718841937329834d),

new NpgsqlTypes.NpgsqlLine(a: 0.11243733685416046d, b: 0.013591955976034908d, c: 0.7775970557251949d),

new NpgsqlTypes.NpgsqlLine(a: 0.8582524431481352d, b: 0.7991440470681935d, c: 0.3913849203224117d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 26,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.47335673789455657d, b: 0.4021672484170892d, c: 0.4363679546995535d),

new NpgsqlTypes.NpgsqlLine(a: 0.18400906470463696d, b: 0.7477246832845316d, c: 0.3912242866802005d),

new NpgsqlTypes.NpgsqlLine(a: 0.22211762830613824d, b: 0.5889446456811622d, c: 0.03513138703285179d),

new NpgsqlTypes.NpgsqlLine(a: 0.8025490397580693d, b: 0.844723938546262d, c: 0.8063444421813334d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 3,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9295264445479572d, b: 0.2095887741216682d, c: 0.4166846376681884d),

new NpgsqlTypes.NpgsqlLine(a: 0.6248410856762311d, b: 0.486479992738333d, c: 0.8277086238342556d),

new NpgsqlTypes.NpgsqlLine(a: 0.7493758600905965d, b: 0.22221427435935148d, c: 0.33010970682660146d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9336270382682543d, b: 0.49055840433405506d, c: 0.9529894606829843d),

new NpgsqlTypes.NpgsqlLine(a: 0.529444387667359d, b: 0.14949638850380675d, c: 0.8785303125302771d),

new NpgsqlTypes.NpgsqlLine(a: 0.6804868621672078d, b: 0.06665084607856131d, c: 0.5332678840950068d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 28,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.42066517591214725d, b: 0.43700683095439086d, c: 0.3789333275455128d),

new NpgsqlTypes.NpgsqlLine(a: 0.43231320592790623d, b: 0.16780223957389517d, c: 0.8084012592609814d),

new NpgsqlTypes.NpgsqlLine(a: 0.7381813624771805d, b: 0.8677396005737167d, c: 0.015969543681493836d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2911009900646988d, b: 0.6565148374188642d, c: 0.7152025411113535d),

new NpgsqlTypes.NpgsqlLine(a: 0.6507787729454588d, b: 0.19007670486075334d, c: 0.5720457823976794d),

new NpgsqlTypes.NpgsqlLine(a: 0.0922191871942124d, b: 0.3248207456785095d, c: 0.1933271249552686d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6635500297010252d, b: 0.8240549290614054d, c: 0.3438563079975585d),

new NpgsqlTypes.NpgsqlLine(a: 0.6444460036256121d, b: 0.38196136487268506d, c: 0.49911842750594726d),

new NpgsqlTypes.NpgsqlLine(a: 0.8723310484981452d, b: 0.8358666822449353d, c: 0.03808050217023928d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.16227235879856794d, b: 0.8750819397720204d, c: 0.006366322117680734d),

new NpgsqlTypes.NpgsqlLine(a: 0.4787574025460508d, b: 0.988968641166209d, c: 0.4982869682165284d),

new NpgsqlTypes.NpgsqlLine(a: 0.6929455582465427d, b: 0.3605058899843099d, c: 0.9830410588023494d),

new NpgsqlTypes.NpgsqlLine(a: 0.17612948432593256d, b: 0.3540976141829859d, c: 0.5767267067760206d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5331356416016318d, b: 0.5046881506060071d, c: 0.6519045184172604d),

new NpgsqlTypes.NpgsqlLine(a: 0.5170928827808479d, b: 0.4899973649438162d, c: 0.9681335769563395d),

new NpgsqlTypes.NpgsqlLine(a: 0.05572964934822677d, b: 0.4278948944667955d, c: 0.1571885947359437d),

new NpgsqlTypes.NpgsqlLine(a: 0.6585768748936759d, b: 0.6150910094060371d, c: 0.5646596801577406d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9044636031548915d, b: 0.33490889377853816d, c: 0.6784562927208627d),

new NpgsqlTypes.NpgsqlLine(a: 0.22716371262691104d, b: 0.23608108366461844d, c: 0.30145394204389897d),

new NpgsqlTypes.NpgsqlLine(a: 0.42729835416187545d, b: 0.2668512634736274d, c: 0.6657246617360916d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2815799784145324d, b: 0.7131669669421241d, c: 0.4418867320996883d),

new NpgsqlTypes.NpgsqlLine(a: 0.4063229597438508d, b: 0.8047816363342731d, c: 0.7621692204544998d),

new NpgsqlTypes.NpgsqlLine(a: 0.6706229265584794d, b: 0.3627625058445584d, c: 0.24359654044057488d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03690908125892767d, b: 0.13926854320814475d, c: 0.43983478757648187d),

new NpgsqlTypes.NpgsqlLine(a: 0.808016285835965d, b: 0.11575589439168565d, c: 0.13630456787995004d),

new NpgsqlTypes.NpgsqlLine(a: 0.506045548998152d, b: 0.4598267276186766d, c: 0.20605804235305225d),

new NpgsqlTypes.NpgsqlLine(a: 0.1414313889057358d, b: 0.9390489809189884d, c: 0.06355591422216722d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9683420801589612d, b: 0.6822259335541787d, c: 0.8344248506642646d),

new NpgsqlTypes.NpgsqlLine(a: 0.5691295230921449d, b: 0.03359459308302204d, c: 0.9280596064075427d),

new NpgsqlTypes.NpgsqlLine(a: 0.027714249128998558d, b: 0.5807230664779159d, c: 0.1620816365305171d),

new NpgsqlTypes.NpgsqlLine(a: 0.2143866695128579d, b: 0.8330026497737757d, c: 0.3220725265227339d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7750272149979837d, b: 0.5781851370807045d, c: 0.3068127741048434d),

new NpgsqlTypes.NpgsqlLine(a: 0.6339219423463303d, b: 0.8616730704317173d, c: 0.46460767947157544d),

new NpgsqlTypes.NpgsqlLine(a: 0.8024929904297441d, b: 0.4107460284745179d, c: 0.8860801695967594d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 55,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.46356356503259766d, b: 0.6382750797124873d, c: 0.7708888959732082d),

new NpgsqlTypes.NpgsqlLine(a: 0.0054442987060709935d, b: 0.5105703928964714d, c: 0.70186454993313d),

new NpgsqlTypes.NpgsqlLine(a: 0.04637417385995324d, b: 0.44437067524099716d, c: 0.5651415560055569d),

new NpgsqlTypes.NpgsqlLine(a: 0.23334241277858203d, b: 0.13491810880693111d, c: 0.3942237786619309d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23471535415557454d, b: 0.6965502059008688d, c: 0.19308172817753744d),

new NpgsqlTypes.NpgsqlLine(a: 0.5715015268189827d, b: 0.8305027432362764d, c: 0.5820454668460566d),

new NpgsqlTypes.NpgsqlLine(a: 0.15273835594843488d, b: 0.4105074338994624d, c: 0.15835134482543967d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7576378932426301d, b: 0.7318693466372937d, c: 0.38171840683856084d),

new NpgsqlTypes.NpgsqlLine(a: 0.4360398329749974d, b: 0.7892644027377865d, c: 0.19569044604454822d),

new NpgsqlTypes.NpgsqlLine(a: 0.1868134026845747d, b: 0.793065421428785d, c: 0.8812651987638246d),

new NpgsqlTypes.NpgsqlLine(a: 0.2330733407690584d, b: 0.7836336327289104d, c: 0.562441718374799d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1989295403326038d, b: 0.030963432983039718d, c: 0.0069507766454219855d),

new NpgsqlTypes.NpgsqlLine(a: 0.804927599859969d, b: 0.555954826820782d, c: 0.07407908455825518d),

new NpgsqlTypes.NpgsqlLine(a: 0.9085918346719413d, b: 0.3441223764614201d, c: 0.8295650362460532d),

new NpgsqlTypes.NpgsqlLine(a: 0.8801870952086432d, b: 0.8153755369444996d, c: 0.3037327302686491d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.06506719112087056d, b: 0.7706559292835629d, c: 0.20492466364663142d),

new NpgsqlTypes.NpgsqlLine(a: 0.2611085465514713d, b: 0.121456219465094d, c: 0.03760698678578556d),

new NpgsqlTypes.NpgsqlLine(a: 0.8803399877985562d, b: 0.8557228407162544d, c: 0.9124331555641889d),

new NpgsqlTypes.NpgsqlLine(a: 0.7129351337319427d, b: 0.9456371146956835d, c: 0.06501128409860057d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8482392230378166d, b: 0.5796734152344882d, c: 0.7256720240884412d),

new NpgsqlTypes.NpgsqlLine(a: 0.5657833763174616d, b: 0.554415516509001d, c: 0.06987577208699758d),

new NpgsqlTypes.NpgsqlLine(a: 0.9273689201319623d, b: 0.022248541773823627d, c: 0.41382970489161675d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.1945962296273761d, b: 0.1974591699948075d, c: 0.8314326296686019d),

new NpgsqlTypes.NpgsqlLine(a: 0.722268685214229d, b: 0.4405882529652093d, c: 0.3649536810395374d),

new NpgsqlTypes.NpgsqlLine(a: 0.9260522748317739d, b: 0.4268486618016072d, c: 0.5846207500381467d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 78,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4316420567084318d, b: 0.31291339465138934d, c: 0.3432851148675494d),

new NpgsqlTypes.NpgsqlLine(a: 0.7554095611723248d, b: 0.6525350935798426d, c: 0.5886500681560249d),

new NpgsqlTypes.NpgsqlLine(a: 0.8123556832372968d, b: 0.3997056585244989d, c: 0.8908575344953573d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03173770662914577d, b: 0.33313467230926064d, c: 0.29404308417253244d),

new NpgsqlTypes.NpgsqlLine(a: 0.36459898167871374d, b: 0.634538728164836d, c: 0.25450088830272566d),

new NpgsqlTypes.NpgsqlLine(a: 0.12476926192462279d, b: 0.7590003012730439d, c: 0.4229485315363213d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8615978451775581d, b: 0.3117520389498114d, c: 0.464345597934713d),

new NpgsqlTypes.NpgsqlLine(a: 0.5676870751071308d, b: 0.4599373391218218d, c: 0.6786687507180664d),

new NpgsqlTypes.NpgsqlLine(a: 0.4858361349156638d, b: 0.4658874486379181d, c: 0.314483235120272d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6030118074967246d, b: 0.4242928279271525d, c: 0.5692337608429529d),

new NpgsqlTypes.NpgsqlLine(a: 0.9167766445880327d, b: 0.7830098273256849d, c: 0.7908163052808778d),

new NpgsqlTypes.NpgsqlLine(a: 0.8815541221431157d, b: 0.18548017455560772d, c: 0.9576789147157041d),

new NpgsqlTypes.NpgsqlLine(a: 0.4284781085433822d, b: 0.48031882498846923d, c: 0.14350672729470482d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7182269835275926d, b: 0.5152329281187541d, c: 0.8360387833731568d),

new NpgsqlTypes.NpgsqlLine(a: 0.9837492336342856d, b: 0.3988005754986257d, c: 0.16558979105751193d),

new NpgsqlTypes.NpgsqlLine(a: 0.07337848869764951d, b: 0.8508172621967685d, c: 0.9319216223017526d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 93,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.03504850481706545d, b: 0.2612560597559771d, c: 0.44302568273155496d),

new NpgsqlTypes.NpgsqlLine(a: 0.10139218322559962d, b: 0.29533278737337165d, c: 0.2733283834869923d),

new NpgsqlTypes.NpgsqlLine(a: 0.4576998178763365d, b: 0.6638574642493267d, c: 0.44095457591253817d),

new NpgsqlTypes.NpgsqlLine(a: 0.34000599651503627d, b: 0.24002528253710742d, c: 0.6282416376601276d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32343518438837204d, b: 0.09241697635931556d, c: 0.09267554982968595d),

new NpgsqlTypes.NpgsqlLine(a: 0.830821506208486d, b: 0.376831292577681d, c: 0.3484582235252047d),

new NpgsqlTypes.NpgsqlLine(a: 0.6966228212774184d, b: 0.5035780376857575d, c: 0.8536044058582382d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8095260059735709d, b: 0.010513711555488747d, c: 0.33118496367027983d),

new NpgsqlTypes.NpgsqlLine(a: 0.944245493971382d, b: 0.865541838697587d, c: 0.1725672695253906d),

new NpgsqlTypes.NpgsqlLine(a: 0.05938056106496914d, b: 0.6632674744060137d, c: 0.06936917399271392d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9280088217269036d, b: 0.8371968391759715d, c: 0.7860178295835143d),

new NpgsqlTypes.NpgsqlLine(a: 0.428447133180925d, b: 0.8651657122389759d, c: 0.13961559593824513d),

new NpgsqlTypes.NpgsqlLine(a: 0.7493190979101892d, b: 0.6695387353546398d, c: 0.4343979309557927d),

new NpgsqlTypes.NpgsqlLine(a: 0.4284277792074286d, b: 0.9912979174614678d, c: 0.003209658859996467d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23497933042191366d, b: 0.5460080116803963d, c: 0.9294537617342338d),

new NpgsqlTypes.NpgsqlLine(a: 0.5654849711285483d, b: 0.789812123892367d, c: 0.9478541832623044d),

new NpgsqlTypes.NpgsqlLine(a: 0.7453242547676724d, b: 0.12514324835735746d, c: 0.05315869140441509d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.813034567414048d, b: 0.791541396202019d, c: 0.3278425273186464d),

new NpgsqlTypes.NpgsqlLine(a: 0.023671352923065436d, b: 0.7412199378411228d, c: 0.6047608618301791d),

new NpgsqlTypes.NpgsqlLine(a: 0.8391215023112222d, b: 0.8130922946058755d, c: 0.7270115441160104d),

new NpgsqlTypes.NpgsqlLine(a: 0.4746417052523425d, b: 0.07416424630508056d, c: 0.33450962816652186d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.536185997696689d, b: 0.6343298189753601d, c: 0.4887344697853271d),

new NpgsqlTypes.NpgsqlLine(a: 0.26789361004290313d, b: 0.5510682199103556d, c: 0.2450574048087768d),

new NpgsqlTypes.NpgsqlLine(a: 0.45776650606335767d, b: 0.19118469822019857d, c: 0.32428450080028015d),

new NpgsqlTypes.NpgsqlLine(a: 0.6634291801916442d, b: 0.5269763534194467d, c: 0.4158303654242468d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7863551133950749d, b: 0.9931339384389601d, c: 0.9915313646994423d),

new NpgsqlTypes.NpgsqlLine(a: 0.6810984108520718d, b: 0.7316569272401957d, c: 0.2113475017792339d),

new NpgsqlTypes.NpgsqlLine(a: 0.6666272348270732d, b: 0.035488375305972264d, c: 0.032969715312577974d),

new NpgsqlTypes.NpgsqlLine(a: 0.3342223014603539d, b: 0.337112739492059d, c: 0.325407669918079d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9777588952595452d, b: 0.5820727658136565d, c: 0.6124829103779857d),

new NpgsqlTypes.NpgsqlLine(a: 0.8765711242402577d, b: 0.7353080486383318d, c: 0.9878416414495583d),

new NpgsqlTypes.NpgsqlLine(a: 0.6042235303767719d, b: 0.3405977481364256d, c: 0.8671777351426649d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.19688591673561773d, b: 0.8663581652320221d, c: 0.36924932669765087d),

new NpgsqlTypes.NpgsqlLine(a: 0.5307338653390761d, b: 0.21069943575929972d, c: 0.7407564377061279d),

new NpgsqlTypes.NpgsqlLine(a: 0.10886630189709989d, b: 0.9150779843585668d, c: 0.05746862457893254d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 43,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.6458125285680744d, b: 0.8894285775225478d, c: 0.9649047800230308d),

new NpgsqlTypes.NpgsqlLine(a: 0.3744552578396817d, b: 0.80361768422388d, c: 0.37724587961160705d),

new NpgsqlTypes.NpgsqlLine(a: 0.028095884856704334d, b: 0.047859655319731464d, c: 0.47009516833256626d),

new NpgsqlTypes.NpgsqlLine(a: 0.3765508348563801d, b: 0.1558159990762974d, c: 0.8897705090208817d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.2544402232120271d, b: 0.3739489084388927d, c: 0.46930750321868264d),

new NpgsqlTypes.NpgsqlLine(a: 0.629502260912441d, b: 0.12342225888991076d, c: 0.010890817325016067d),

new NpgsqlTypes.NpgsqlLine(a: 0.5779740462278928d, b: 0.11012779741150092d, c: 0.11054176138732164d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7585417618336919d, b: 0.9732540637884572d, c: 0.8823179068980619d),

new NpgsqlTypes.NpgsqlLine(a: 0.8838904141782077d, b: 0.09828633209068693d, c: 0.3194867250235297d),

new NpgsqlTypes.NpgsqlLine(a: 0.6266566638219552d, b: 0.4715954417352408d, c: 0.4299046233497156d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 123,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44469898283866016d, b: 0.30866979358742697d, c: 0.7430985312023344d),

new NpgsqlTypes.NpgsqlLine(a: 0.36559698824927156d, b: 0.3756321598465524d, c: 0.21332465133442446d),

new NpgsqlTypes.NpgsqlLine(a: 0.6335329929990117d, b: 0.8294705829427967d, c: 0.9338347887356051d),

new NpgsqlTypes.NpgsqlLine(a: 0.18224103080370946d, b: 0.4918961784188375d, c: 0.9691043825896777d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 128,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4393419761059809d, b: 0.09618607597240958d, c: 0.024425691987705056d),

new NpgsqlTypes.NpgsqlLine(a: 0.21155379705508637d, b: 0.802288198437226d, c: 0.7271512850636512d),

new NpgsqlTypes.NpgsqlLine(a: 0.7764593279463559d, b: 0.42797946328785674d, c: 0.946535030099498d),

new NpgsqlTypes.NpgsqlLine(a: 0.12738083087587948d, b: 0.44227875237878056d, c: 0.3249922367889312d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 49,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.36267040609341306d, b: 0.44693237273506004d, c: 0.8633493998423142d),

new NpgsqlTypes.NpgsqlLine(a: 0.21452388706482128d, b: 0.31926081889513613d, c: 0.6108351233263168d),

new NpgsqlTypes.NpgsqlLine(a: 0.3892429804313683d, b: 0.756393042026355d, c: 0.7630226206418443d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7214143682107564d, b: 0.6927907472438568d, c: 0.3253130618798651d),

new NpgsqlTypes.NpgsqlLine(a: 0.7095784876822488d, b: 0.3242716318487756d, c: 0.15612721276838548d),

new NpgsqlTypes.NpgsqlLine(a: 0.4974716448438896d, b: 0.9139165652496969d, c: 0.0475585137384954d),

new NpgsqlTypes.NpgsqlLine(a: 0.7233377630625295d, b: 0.7484679077024667d, c: 0.2723662972248011d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 131,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5723303844072803d, b: 0.8180606386729486d, c: 0.5083177126223916d),

new NpgsqlTypes.NpgsqlLine(a: 0.9656699686427265d, b: 0.9262054665071684d, c: 0.5012585325856467d),

new NpgsqlTypes.NpgsqlLine(a: 0.7291144486497491d, b: 0.6246437023762679d, c: 0.5737159169103734d),

new NpgsqlTypes.NpgsqlLine(a: 0.8113276973946525d, b: 0.057047844612321486d, c: 0.5914078325467779d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.13968532859441551d, b: 0.4508310850111139d, c: 0.03121267166061137d),

new NpgsqlTypes.NpgsqlLine(a: 0.8196966852711804d, b: 0.3534920446219093d, c: 0.010702421104941795d),

new NpgsqlTypes.NpgsqlLine(a: 0.5498773588149357d, b: 0.1798669420137997d, c: 0.451455180949333d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.18945705973526583d, b: 0.6154557101919924d, c: 0.371946441367356d),

new NpgsqlTypes.NpgsqlLine(a: 0.08257032831906685d, b: 0.2699608192612293d, c: 0.2455788193128633d),

new NpgsqlTypes.NpgsqlLine(a: 0.20083886138261775d, b: 0.015862099524615703d, c: 0.4817109956057267d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.23060117734359453d, b: 0.32845321429653485d, c: 0.5839109741095669d),

new NpgsqlTypes.NpgsqlLine(a: 0.23843650273592387d, b: 0.8752222658505633d, c: 0.882272842764263d),

new NpgsqlTypes.NpgsqlLine(a: 0.2916578260860493d, b: 0.9537726805513109d, c: 0.7984446330417632d),

new NpgsqlTypes.NpgsqlLine(a: 0.38589913038275203d, b: 0.2731368697401674d, c: 0.27720971785863757d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8884946239621967d, b: 0.7852323568393157d, c: 0.24056803148427275d),

new NpgsqlTypes.NpgsqlLine(a: 0.6291675769951617d, b: 0.5917611209897395d, c: 0.2524944450853184d),

new NpgsqlTypes.NpgsqlLine(a: 0.5454957947889743d, b: 0.31712782410597207d, c: 0.05896899473846051d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 145,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.04187668052519877d, b: 0.9569036823558554d, c: 0.3639609924617532d),

new NpgsqlTypes.NpgsqlLine(a: 0.1315703045896509d, b: 0.4496308927789846d, c: 0.9882372104334392d),

new NpgsqlTypes.NpgsqlLine(a: 0.3969215908101106d, b: 0.778934085611095d, c: 0.11467494384754928d),

new NpgsqlTypes.NpgsqlLine(a: 0.1738944142846971d, b: 0.5620234345456354d, c: 0.19001532712922087d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.08467139329459117d, b: 0.35642925597996067d, c: 0.09227520913243537d),

new NpgsqlTypes.NpgsqlLine(a: 0.9201877254303032d, b: 0.16056771655497593d, c: 0.0792257839206103d),

new NpgsqlTypes.NpgsqlLine(a: 0.2463802751505405d, b: 0.6474780522859054d, c: 0.7477722620571621d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 146,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.024756405048412033d, b: 0.9195673733648678d, c: 0.325123342397985d),

new NpgsqlTypes.NpgsqlLine(a: 0.7636522015767642d, b: 0.5878831233865626d, c: 0.01283257433072127d),

new NpgsqlTypes.NpgsqlLine(a: 0.46952803464346715d, b: 0.1084661847885171d, c: 0.4866738246151383d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4957419483623223d, b: 0.5547941991562263d, c: 0.05206031243342002d),

new NpgsqlTypes.NpgsqlLine(a: 0.023750775244431366d, b: 0.9068393389740383d, c: 0.7831889471483187d),

new NpgsqlTypes.NpgsqlLine(a: 0.8683775293040039d, b: 0.3977685453560543d, c: 0.16363003421583644d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.44690487763451536d, b: 0.9098195196004739d, c: 0.915866511668442d),

new NpgsqlTypes.NpgsqlLine(a: 0.9458850369287131d, b: 0.6978922592229245d, c: 0.9276975280188018d),

new NpgsqlTypes.NpgsqlLine(a: 0.7682963798063026d, b: 0.8520308324626147d, c: 0.3689291300674068d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 148,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4839199587305395d, b: 0.562628287128059d, c: 0.29432896272827225d),

new NpgsqlTypes.NpgsqlLine(a: 0.4591348103415541d, b: 0.19591578087147388d, c: 0.8629225937847134d),

new NpgsqlTypes.NpgsqlLine(a: 0.14163870829628078d, b: 0.2150313917608092d, c: 0.6417436089560151d),

new NpgsqlTypes.NpgsqlLine(a: 0.7892952950164306d, b: 0.051965668895284756d, c: 0.7354087579514267d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 152,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5075276470751005d, b: 0.916972095837894d, c: 0.464702242105708d),

new NpgsqlTypes.NpgsqlLine(a: 0.8278885993336563d, b: 0.2609969461872266d, c: 0.569129045715324d),

new NpgsqlTypes.NpgsqlLine(a: 0.6271763063702904d, b: 0.17430997684771643d, c: 0.3270644890298292d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7918359374169871d, b: 0.589398992353922d, c: 0.16487140464322958d),

new NpgsqlTypes.NpgsqlLine(a: 0.8077847062654638d, b: 0.20172828553791822d, c: 0.808200626307717d),

new NpgsqlTypes.NpgsqlLine(a: 0.2996141300366467d, b: 0.4132210040281765d, c: 0.5485158166569339d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.41845601968565516d, b: 0.8259497810251994d, c: 0.9717601085224091d),

new NpgsqlTypes.NpgsqlLine(a: 0.18322360672761873d, b: 0.10316953969009779d, c: 0.9671515362157892d),

new NpgsqlTypes.NpgsqlLine(a: 0.6960658183462106d, b: 0.5667672950693675d, c: 0.33190446622375924d),

new NpgsqlTypes.NpgsqlLine(a: 0.5554710377354214d, b: 0.5681985649253537d, c: 0.8605545027648888d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 158,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7356673083820647d, b: 0.5903300808385733d, c: 0.6400013701345011d),

new NpgsqlTypes.NpgsqlLine(a: 0.021181073896737068d, b: 0.7305245767638285d, c: 0.6997181315593937d),

new NpgsqlTypes.NpgsqlLine(a: 0.30453680636195835d, b: 0.8729440821809943d, c: 0.9501329044985977d),

new NpgsqlTypes.NpgsqlLine(a: 0.9509241975541949d, b: 0.7320208714094016d, c: 0.44601509796312233d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 164,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7538255497415447d, b: 0.9359749901940523d, c: 0.39683498260742534d),

new NpgsqlTypes.NpgsqlLine(a: 0.09745367985852305d, b: 0.1806578933457601d, c: 0.22458899534660692d),

new NpgsqlTypes.NpgsqlLine(a: 0.11403310617244355d, b: 0.10991660127633607d, c: 0.1603817748114703d),

new NpgsqlTypes.NpgsqlLine(a: 0.060971823223149424d, b: 0.40175521246905355d, c: 0.6992443252049741d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.31087989048417874d, b: 0.9464710868907537d, c: 0.4396622391772399d),

new NpgsqlTypes.NpgsqlLine(a: 0.36642947240777246d, b: 0.02731197957579934d, c: 0.40645085784008683d),

new NpgsqlTypes.NpgsqlLine(a: 0.29664184804942506d, b: 0.15828998854482645d, c: 0.6771438189533052d),

new NpgsqlTypes.NpgsqlLine(a: 0.4023761031661127d, b: 0.8597480711137118d, c: 0.9621699740078475d),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 169,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.22612702613063063d, b: 0.3947105914547412d, c: 0.7383386795181046d),

new NpgsqlTypes.NpgsqlLine(a: 0.9859855153988198d, b: 0.137178100051341d, c: 0.7056168738103042d),

new NpgsqlTypes.NpgsqlLine(a: 0.4830527126251042d, b: 0.33905122701033286d, c: 0.24360556061861582d),

new NpgsqlTypes.NpgsqlLine(a: 0.615795535201082d, b: 0.3514123870064002d, c: 0.7948456304664882d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 177,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32529500915031606d, b: 0.7419387478614176d, c: 0.07102553865894967d),

new NpgsqlTypes.NpgsqlLine(a: 0.47412996464406865d, b: 0.2797244876853008d, c: 0.1806723510689795d),

new NpgsqlTypes.NpgsqlLine(a: 0.06915909244559182d, b: 0.46260467998510646d, c: 0.6804348666522527d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 82,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7808334465028743d, b: 0.048121122411375006d, c: 0.232985308555668d),

new NpgsqlTypes.NpgsqlLine(a: 0.6209099771514212d, b: 0.23555384358737763d, c: 0.6857368834798195d),

new NpgsqlTypes.NpgsqlLine(a: 0.0009101801006555776d, b: 0.8547720737646333d, c: 0.08976566520349838d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4169836904473312d, b: 0.061418047344774074d, c: 0.700687814488437d),

new NpgsqlTypes.NpgsqlLine(a: 0.5800372710675552d, b: 0.526602006389519d, c: 0.4997667287652978d),

new NpgsqlTypes.NpgsqlLine(a: 0.17785006591184072d, b: 0.7127321675156049d, c: 0.5302545148958283d),

},
},
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 181,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.4200806275900725d, b: 0.4883101418476329d, c: 0.2747724646386057d),

new NpgsqlTypes.NpgsqlLine(a: 0.7424232852109418d, b: 0.2746302002297366d, c: 0.34791187911711163d),

new NpgsqlTypes.NpgsqlLine(a: 0.35113650293038645d, b: 0.2467728194260801d, c: 0.4335238376106333d),

new NpgsqlTypes.NpgsqlLine(a: 0.35101812226005535d, b: 0.6590373754584853d, c: 0.5132759320148171d),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlLinelineArray2M
{
    Id = 185,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8412796603912988d, b: 0.13575477333335628d, c: 0.07863212819783294d),

new NpgsqlTypes.NpgsqlLine(a: 0.19515345736679124d, b: 0.06206021798426453d, c: 0.7699747358017094d),

new NpgsqlTypes.NpgsqlLine(a: 0.30644392837967727d, b: 0.9079341328386014d, c: 0.09962375010931845d),

new NpgsqlTypes.NpgsqlLine(a: 0.7118623306307791d, b: 0.19284056306275021d, c: 0.7374595766756467d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 88,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.38817679480372236d, b: 0.23689418659450068d, c: 0.12671475143546396d),

new NpgsqlTypes.NpgsqlLine(a: 0.1296454978981636d, b: 0.31625980157422395d, c: 0.4155940453179866d),

new NpgsqlTypes.NpgsqlLine(a: 0.08194149712938092d, b: 0.31056564133833875d, c: 0.695107140155223d),

new NpgsqlTypes.NpgsqlLine(a: 0.569168110923202d, b: 0.9213136103495777d, c: 0.5226096391938769d),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5495539997085587d, b: 0.43542068438371995d, c: 0.9717091534755176d),

new NpgsqlTypes.NpgsqlLine(a: 0.992985410173943d, b: 0.3771999304395336d, c: 0.2232970752684531d),

new NpgsqlTypes.NpgsqlLine(a: 0.23887116707395672d, b: 0.637719929413344d, c: 0.5285944613539811d),

new NpgsqlTypes.NpgsqlLine(a: 0.21540658826020687d, b: 0.20357974261437395d, c: 0.9753517890104134d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 190,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8486448074083391d, b: 0.8330196037919662d, c: 0.7209758752834788d),

new NpgsqlTypes.NpgsqlLine(a: 0.381927572620397d, b: 0.9117278124723417d, c: 0.43864047679756646d),

new NpgsqlTypes.NpgsqlLine(a: 0.5255153636960402d, b: 0.5636603075212222d, c: 0.5740721603343665d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9969266212230721d, b: 0.04311091308092063d, c: 0.6074489551766431d),

new NpgsqlTypes.NpgsqlLine(a: 0.12552430800253644d, b: 0.6564331194831257d, c: 0.8436178578987261d),

new NpgsqlTypes.NpgsqlLine(a: 0.5143610528411904d, b: 0.5349124501507458d, c: 0.636075049378158d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 195,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.9872611841365451d, b: 0.10755590543852545d, c: 0.45756750241500177d),

new NpgsqlTypes.NpgsqlLine(a: 0.9541131344938611d, b: 0.03150283255335817d, c: 0.3737861089143091d),

new NpgsqlTypes.NpgsqlLine(a: 0.9881722457163089d, b: 0.23907841117880924d, c: 0.4182813699145377d),

},
    ModelInner = new NpgsqlLinelineArray2MI
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8261924974712276d, b: 0.7170630796227693d, c: 0.25024324642007056d),

new NpgsqlTypes.NpgsqlLine(a: 0.9190823533893102d, b: 0.08990459560488429d, c: 0.3822060690432644d),

new NpgsqlTypes.NpgsqlLine(a: 0.16443304306849782d, b: 0.5280166015037336d, c: 0.6747289311089828d),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.32111559324765526d, b: 0.39638518345182416d, c: 0.0256717567033502d),

new NpgsqlTypes.NpgsqlLine(a: 0.1310178626700047d, b: 0.26759363546066983d, c: 0.16346949020508783d),

new NpgsqlTypes.NpgsqlLine(a: 0.9563933590894363d, b: 0.4124896253204894d, c: 0.10914013139133227d),

new NpgsqlTypes.NpgsqlLine(a: 0.6573454297328585d, b: 0.18233175196935303d, c: 0.9627255223819313d),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(3)
{
new NpgsqlTypes.NpgsqlLine(a: 0.8045275692505737d, b: 0.674175559722656d, c: 0.36273946308409954d),

new NpgsqlTypes.NpgsqlLine(a: 0.07218854159899635d, b: 0.9988432873806465d, c: 0.48419189960605535d),

new NpgsqlTypes.NpgsqlLine(a: 0.9662376124554309d, b: 0.6069901127066614d, c: 0.7912368475458048d),

},
},
            new NpgsqlLinelineArray2M
{
    Id = 197,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.5331029903240586d, b: 0.5053522392350628d, c: 0.6549880356378688d),

new NpgsqlTypes.NpgsqlLine(a: 0.403959842281973d, b: 0.4182209940868975d, c: 0.4194648239236133d),

new NpgsqlTypes.NpgsqlLine(a: 0.29732908865842744d, b: 0.8141691534896577d, c: 0.017971488019446813d),

new NpgsqlTypes.NpgsqlLine(a: 0.697510835302357d, b: 0.9127891017431611d, c: 0.27290711446542393d),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlLine>(4)
{
new NpgsqlTypes.NpgsqlLine(a: 0.7954917901987062d, b: 0.8065870204501444d, c: 0.42942732770768355d),

new NpgsqlTypes.NpgsqlLine(a: 0.01835032379456658d, b: 0.5940001505903592d, c: 0.6378465275875068d),

new NpgsqlTypes.NpgsqlLine(a: 0.9334558253537613d, b: 0.5953630717012477d, c: 0.700208542770445d),

new NpgsqlTypes.NpgsqlLine(a: 0.877469489271226d, b: 0.09165916950582553d, c: 0.811197918786271d),

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

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlLineListlineArray)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

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
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlLineListlineArray)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[34], true);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 131;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 28;
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 3;
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(34));
                Assert.That(firstItems2, Has.Count.EqualTo(34));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[33],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[33],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                parametr1.Value = 123;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 131;
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
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(14));
                Assert.That(secondItems2, Has.Count.EqualTo(14));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 181;
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
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 158;
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
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(27));

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
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[34], false);
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
                parametr1.Value = 177;
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(5));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 177;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 190;
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
                        Assert.That(models, Has.Count.EqualTo(5));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[34], false);
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
                parametr1.Value = 63;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 26;
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
                Assert.That(firstItems1, Has.Count.EqualTo(25));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[30],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 26;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

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
                        NpgsqlLinelineArray2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

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
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[17],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[18],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                parametr1.Value = 128;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 185;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 148, query1, 93, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[20],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 131, query1, 164, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(14));
                Assert.That(firstItems2, Has.Count.EqualTo(14));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[34], false);
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
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlLinelineArray2M.AssertModel(models1[i],_testData[i], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 63, query1, 169, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionMMDynQuerySelectModelBatch(connection, 93, query1, 181, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 78, query1, 106, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

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
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[34], false);
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
                await ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 118, query1, 140, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[12],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTDynQuerySelectModelBatch(connection, 3, query1, 128, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(34));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[1], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[2], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[3], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[4], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[5], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[6], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[7], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[8], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[9], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[10], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[11], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[12], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[13], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[14], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[15], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[15],_testData[16], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[16],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[17],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[18],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[19],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[20],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[21],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[22],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[23],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[24],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[25],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[26],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[27],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[28],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[29],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[30],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[31],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[32],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[33],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlLinelineArray2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(models[14],_testData[34], false);
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
                 ((INpgsqlLineListlineArray)this).DbConnectionDynQuerySelectModelBatch(connection, 110, query1, 146, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(18));
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[0],_testData[17], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[1],_testData[18], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[2],_testData[19], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[3],_testData[20], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[4],_testData[21], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[5],_testData[22], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[6],_testData[23], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[7],_testData[24], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[8],_testData[25], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[9],_testData[26], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[10],_testData[27], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[11],_testData[28], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[12],_testData[29], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[13],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[14],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[15],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[16],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(firstItems1[17],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(11));
                Assert.That(secondItems2, Has.Count.EqualTo(11));
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
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[6],_testData[30], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[7],_testData[31], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[8],_testData[32], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[9],_testData[33], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems1[10],_testData[34], false);
                        FlatNpgsqlLinelineArray2M.AssertModel(secondItems2[10],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in await ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatchAsync(connection, 152, 70))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

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
                        NpgsqlLinelineArray2M.AssertModel(models[19],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[20],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[21],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[22],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[23],_testData[34], false);
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
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
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
                foreach(var batchResult in  ((INpgsqlLineListlineArray)this).DbConnectionSTSelectModelBatch(connection, 140, 118))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(17));

                        NpgsqlLinelineArray2M.AssertModel(models[0],_testData[18], false);
                        NpgsqlLinelineArray2M.AssertModel(models[1],_testData[19], false);
                        NpgsqlLinelineArray2M.AssertModel(models[2],_testData[20], false);
                        NpgsqlLinelineArray2M.AssertModel(models[3],_testData[21], false);
                        NpgsqlLinelineArray2M.AssertModel(models[4],_testData[22], false);
                        NpgsqlLinelineArray2M.AssertModel(models[5],_testData[23], false);
                        NpgsqlLinelineArray2M.AssertModel(models[6],_testData[24], false);
                        NpgsqlLinelineArray2M.AssertModel(models[7],_testData[25], false);
                        NpgsqlLinelineArray2M.AssertModel(models[8],_testData[26], false);
                        NpgsqlLinelineArray2M.AssertModel(models[9],_testData[27], false);
                        NpgsqlLinelineArray2M.AssertModel(models[10],_testData[28], false);
                        NpgsqlLinelineArray2M.AssertModel(models[11],_testData[29], false);
                        NpgsqlLinelineArray2M.AssertModel(models[12],_testData[30], false);
                        NpgsqlLinelineArray2M.AssertModel(models[13],_testData[31], false);
                        NpgsqlLinelineArray2M.AssertModel(models[14],_testData[32], false);
                        NpgsqlLinelineArray2M.AssertModel(models[15],_testData[33], false);
                        NpgsqlLinelineArray2M.AssertModel(models[16],_testData[34], false);
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
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 78);
                var models = await ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[12], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[13], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[14], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[15], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[16], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[17], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[18], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[19], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[20], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[21], false);
                NpgsqlLinelineArray2M.AssertModel(models[10],_testData[22], false);
                NpgsqlLinelineArray2M.AssertModel(models[11],_testData[23], false);
                NpgsqlLinelineArray2M.AssertModel(models[12],_testData[24], false);
                NpgsqlLinelineArray2M.AssertModel(models[13],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[14],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[15],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[16],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[17],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[18],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[19],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[20],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[21],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[22],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlLineListlineArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlLineListlineArray)this).SetDbConnectionSelectModelParametrs(cmd, 148);
                var models =  ((INpgsqlLineListlineArray)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(10));

                NpgsqlLinelineArray2M.AssertModel(models[0],_testData[25], false);
                NpgsqlLinelineArray2M.AssertModel(models[1],_testData[26], false);
                NpgsqlLinelineArray2M.AssertModel(models[2],_testData[27], false);
                NpgsqlLinelineArray2M.AssertModel(models[3],_testData[28], false);
                NpgsqlLinelineArray2M.AssertModel(models[4],_testData[29], false);
                NpgsqlLinelineArray2M.AssertModel(models[5],_testData[30], false);
                NpgsqlLinelineArray2M.AssertModel(models[6],_testData[31], false);
                NpgsqlLinelineArray2M.AssertModel(models[7],_testData[32], false);
                NpgsqlLinelineArray2M.AssertModel(models[8],_testData[33], false);
                NpgsqlLinelineArray2M.AssertModel(models[9],_testData[34], false);
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
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
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
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
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

                await ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInnerAsync(connection);
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
        public  void DynQueryWAImportModelInnerTest()
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

                ((INpgsqlLineListlineArray)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqllinelinearray2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlLineListlineArray)this).DynQueryWASelectImportModelInner(connection);
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
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 8; i < 12; i++)
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
                Assert.That(models, Has.Count.EqualTo(6));
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

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 12; i < 16; i++)
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
                Assert.That(models, Has.Count.EqualTo(8));
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
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void WASelectImportModelInnerConfig()
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
            methodName:"WAImportModelInner",
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
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
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

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
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
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
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
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlLinelineArray2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 24; i < 28; i++)
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

                await ((INpgsqlLineListlineArray)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
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

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<NpgsqlLinelineArray2MIWA>(2);
                for (int i = 28; i < 35; i++)
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

                ((INpgsqlLineListlineArray)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
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

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlLineListlineArray)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlLineListlineArray)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlLinelineArray2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlLineListlineArray)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlLineListlineArray)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlLinelineArray2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
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
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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

        [Test, Order(13)]
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
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqllinelinearray2mi
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
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI), typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                await ((INpgsqlLineListlineArray)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MI>();
                var models2 = new List<NpgsqlLinelineArray2MI>();
                ((INpgsqlLineListlineArray)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray)),
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
                var models = await ((INpgsqlLineListlineArray)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqllinelinearray2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA), typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                await ((INpgsqlLineListlineArray)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlLinelineArray2MIWA>();
                var models2 = new List<NpgsqlLinelineArray2MIWA>();
                ((INpgsqlLineListlineArray)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqllinelinearray2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlLinelineArray2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlLineListlineArray))]
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
                var models = await ((INpgsqlLineListlineArray)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlLineListlineArray)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlLinelineArray2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

