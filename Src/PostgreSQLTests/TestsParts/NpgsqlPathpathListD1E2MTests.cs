

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
    internal partial interface INpgsqlPathListpathListD1
    {
    }
    
    internal partial class NpgsqlPathListpathListD1 : INpgsqlPathListpathListD1
    {


#region TestData

        private readonly NpgsqlPathpathListD1E2M[] _testData = new NpgsqlPathpathListD1E2M[]
        {
            new NpgsqlPathpathListD1E2M
{
    Id = 7,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4737667265106663d, y: 0.5378627969571556d), new NpgsqlTypes.NpgsqlPoint(x: 0.9052046414619469d, y: 0.925468094561604d), new NpgsqlTypes.NpgsqlPoint(x: 0.4288774006803501d, y: 0.38095040052243334d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9964964917364787d, y: 0.17796428054265123d), new NpgsqlTypes.NpgsqlPoint(x: 0.6206576804044631d, y: 0.2415944172102702d), new NpgsqlTypes.NpgsqlPoint(x: 0.5195061723893291d, y: 0.49163506798860845d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33504430096686566d, y: 0.358638174953711d), new NpgsqlTypes.NpgsqlPoint(x: 0.09986229061662955d, y: 0.3210333651921339d), new NpgsqlTypes.NpgsqlPoint(x: 0.9508921545786294d, y: 0.47764934034057727d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9946166993124825d, y: 0.2939805736231129d), new NpgsqlTypes.NpgsqlPoint(x: 0.66462862730693d, y: 0.8170078837635334d), new NpgsqlTypes.NpgsqlPoint(x: 0.6056533955064278d, y: 0.9607734137240366d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 8,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6635980392735564d, y: 0.3329511804230937d), new NpgsqlTypes.NpgsqlPoint(x: 0.6333529808586089d, y: 0.8115324943233676d), new NpgsqlTypes.NpgsqlPoint(x: 0.29011054005496595d, y: 0.996563341999588d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6981382553299369d, y: 0.4872660012988226d), new NpgsqlTypes.NpgsqlPoint(x: 0.305939940441348d, y: 0.0011162121650973855d), new NpgsqlTypes.NpgsqlPoint(x: 0.8433077215474651d, y: 0.867543788626683d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5703132227602016d, y: 0.22530918668776623d), new NpgsqlTypes.NpgsqlPoint(x: 0.20826088937102039d, y: 0.7898613761542161d), new NpgsqlTypes.NpgsqlPoint(x: 0.317708544516198d, y: 0.17870432545506476d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.011691549475718821d, y: 0.2622715896026103d), new NpgsqlTypes.NpgsqlPoint(x: 0.7129039454269211d, y: 0.9998168851232471d), new NpgsqlTypes.NpgsqlPoint(x: 0.8581371526682701d, y: 0.8548956069263591d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2499641572367376d, y: 0.6911786036157114d), new NpgsqlTypes.NpgsqlPoint(x: 0.9144073723403608d, y: 0.48004921775462206d), new NpgsqlTypes.NpgsqlPoint(x: 0.710317197800855d, y: 0.0267760535854209d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.012969268433234649d, y: 0.3506384616948258d), new NpgsqlTypes.NpgsqlPoint(x: 0.6451140905571904d, y: 0.8133572328022889d), new NpgsqlTypes.NpgsqlPoint(x: 0.6416966690761536d, y: 0.36224819713581924d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8881667260810832d, y: 0.7867175650599939d), new NpgsqlTypes.NpgsqlPoint(x: 0.2753006862427829d, y: 0.6819750105129317d), new NpgsqlTypes.NpgsqlPoint(x: 0.6179665241213187d, y: 0.595165067118646d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.413669140842829d, y: 0.16936130217840029d), new NpgsqlTypes.NpgsqlPoint(x: 0.7304037838683686d, y: 0.7718555725012454d), new NpgsqlTypes.NpgsqlPoint(x: 0.9582670044687186d, y: 0.23808584306529101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5268758532862451d, y: 0.36179218815648306d), new NpgsqlTypes.NpgsqlPoint(x: 0.5521785996200901d, y: 0.6383723335553715d), new NpgsqlTypes.NpgsqlPoint(x: 0.30792405738874873d, y: 0.40214658695266303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7500145008032858d, y: 0.16175281233665662d), new NpgsqlTypes.NpgsqlPoint(x: 0.13025087185829953d, y: 0.5780336129162996d), new NpgsqlTypes.NpgsqlPoint(x: 0.0747952603614056d, y: 0.5500024455632253d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8652063129945522d, y: 0.7678186123228222d), new NpgsqlTypes.NpgsqlPoint(x: 0.030765873372662678d, y: 0.8406836527255978d), new NpgsqlTypes.NpgsqlPoint(x: 0.12265967400590494d, y: 0.7717482201278371d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5517669648499431d, y: 0.006847019740077176d), new NpgsqlTypes.NpgsqlPoint(x: 0.32318768973463097d, y: 0.9068975446179371d), new NpgsqlTypes.NpgsqlPoint(x: 0.411072049083825d, y: 0.737791267041377d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9114894755370347d, y: 0.3268262615736003d), new NpgsqlTypes.NpgsqlPoint(x: 0.14154701392223812d, y: 0.9546532743593538d), new NpgsqlTypes.NpgsqlPoint(x: 0.4021462953575996d, y: 0.6485707755836694d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.002433125479801679d, y: 0.16772845150273152d), new NpgsqlTypes.NpgsqlPoint(x: 0.7403518207216655d, y: 0.5449518661931909d), new NpgsqlTypes.NpgsqlPoint(x: 0.09190768051097975d, y: 0.27547107043618146d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 13,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8382446365835673d, y: 0.13215974916442264d), new NpgsqlTypes.NpgsqlPoint(x: 0.277790387022781d, y: 0.678490260502424d), new NpgsqlTypes.NpgsqlPoint(x: 0.5222884281010179d, y: 0.6052743201510933d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8316589124486478d, y: 0.041814016843291224d), new NpgsqlTypes.NpgsqlPoint(x: 0.21963876975721652d, y: 0.22713602542000044d), new NpgsqlTypes.NpgsqlPoint(x: 0.886550033566748d, y: 0.6318753261727671d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5727351038640789d, y: 0.09753088956118827d), new NpgsqlTypes.NpgsqlPoint(x: 0.5961695797807244d, y: 0.18513710623325474d), new NpgsqlTypes.NpgsqlPoint(x: 0.439439984824487d, y: 0.7282140729702126d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 16,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526106374013449d, y: 0.3840922306442558d), new NpgsqlTypes.NpgsqlPoint(x: 0.5992105334102756d, y: 0.6610187535720076d), new NpgsqlTypes.NpgsqlPoint(x: 0.09769129290564094d, y: 0.5167070186997146d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8953645674377486d, y: 0.44785544820838363d), new NpgsqlTypes.NpgsqlPoint(x: 0.9266477265558771d, y: 0.7132702954743377d), new NpgsqlTypes.NpgsqlPoint(x: 0.014871879876829253d, y: 0.020730226420235143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8807530026215121d, y: 0.6404879552474678d), new NpgsqlTypes.NpgsqlPoint(x: 0.9919571415252444d, y: 0.2778605078794719d), new NpgsqlTypes.NpgsqlPoint(x: 0.31448245738943104d, y: 0.7254048902170094d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5715318403119011d, y: 0.9128335814319087d), new NpgsqlTypes.NpgsqlPoint(x: 0.5188612802519889d, y: 0.39805603083578844d), new NpgsqlTypes.NpgsqlPoint(x: 0.9245281649467567d, y: 0.1966721282202043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6050566168378635d, y: 0.4623318541830277d), new NpgsqlTypes.NpgsqlPoint(x: 0.0171443493280804d, y: 0.7335680279372127d), new NpgsqlTypes.NpgsqlPoint(x: 0.6495466599638134d, y: 0.4908394891618949d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3026274819031832d, y: 0.8508845328631335d), new NpgsqlTypes.NpgsqlPoint(x: 0.48236835185249105d, y: 0.95121532569961d), new NpgsqlTypes.NpgsqlPoint(x: 0.03040839943264828d, y: 0.2660112850665244d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22348094724427536d, y: 0.9968394812356133d), new NpgsqlTypes.NpgsqlPoint(x: 0.1770524075641169d, y: 0.3822658691021221d), new NpgsqlTypes.NpgsqlPoint(x: 0.9592483302546567d, y: 0.9910318577045711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44681858384276574d, y: 0.9088973512942943d), new NpgsqlTypes.NpgsqlPoint(x: 0.3367389899152773d, y: 0.5280830925286214d), new NpgsqlTypes.NpgsqlPoint(x: 0.7827844889100002d, y: 0.6037576142254373d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5426018403029547d, y: 0.9008290912389458d), new NpgsqlTypes.NpgsqlPoint(x: 0.0595301942545583d, y: 0.5691973487335509d), new NpgsqlTypes.NpgsqlPoint(x: 0.24133522786230688d, y: 0.3794819300971489d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 27,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8802053106126977d, y: 0.9158948108122228d), new NpgsqlTypes.NpgsqlPoint(x: 0.885745475480829d, y: 0.634802656918492d), new NpgsqlTypes.NpgsqlPoint(x: 0.025187589865662163d, y: 0.704392179137127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9495365259796467d, y: 0.5761435146166946d), new NpgsqlTypes.NpgsqlPoint(x: 0.5183061105738616d, y: 0.5299942857191153d), new NpgsqlTypes.NpgsqlPoint(x: 0.445090004945501d, y: 0.7064881327918245d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33417984106592846d, y: 0.7321557183365451d), new NpgsqlTypes.NpgsqlPoint(x: 0.7132450870968676d, y: 0.6744953707917188d), new NpgsqlTypes.NpgsqlPoint(x: 0.273997953101651d, y: 0.9277968092078008d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7760470800732118d, y: 0.7611141120372189d), new NpgsqlTypes.NpgsqlPoint(x: 0.5487541707196857d, y: 0.4722478485741384d), new NpgsqlTypes.NpgsqlPoint(x: 0.6505915974391921d, y: 0.014478905624356608d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 19,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9206643065409489d, y: 0.043809827925615163d), new NpgsqlTypes.NpgsqlPoint(x: 0.2172808004602198d, y: 0.8113858767505129d), new NpgsqlTypes.NpgsqlPoint(x: 0.5667009760755047d, y: 0.48978257399321246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4159784979921891d, y: 0.321973766452585d), new NpgsqlTypes.NpgsqlPoint(x: 0.08027988623595383d, y: 0.4756022785725743d), new NpgsqlTypes.NpgsqlPoint(x: 0.7371717209981116d, y: 0.292111474984325d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004131594578642095d, y: 0.7702616900707757d), new NpgsqlTypes.NpgsqlPoint(x: 0.4456968546971314d, y: 0.32121684559852837d), new NpgsqlTypes.NpgsqlPoint(x: 0.6847504166885752d, y: 0.9093926191869977d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.13475383129785257d, y: 0.8395269508441394d), new NpgsqlTypes.NpgsqlPoint(x: 0.29161668586898093d, y: 0.07004631720622356d), new NpgsqlTypes.NpgsqlPoint(x: 0.19601811305485428d, y: 0.6009116965621727d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2164334501639268d, y: 0.10182076101305126d), new NpgsqlTypes.NpgsqlPoint(x: 0.52606602773398d, y: 0.00015726361321433124d), new NpgsqlTypes.NpgsqlPoint(x: 0.7905109805991858d, y: 0.2817689661275987d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.033767090244873676d, y: 0.3302221564550757d), new NpgsqlTypes.NpgsqlPoint(x: 0.7601703896579824d, y: 0.8484115095300839d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013213671175289488d, y: 0.7575128300895361d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21194899628757924d, y: 0.7403089482137891d), new NpgsqlTypes.NpgsqlPoint(x: 0.677078062452205d, y: 0.027243252339058444d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675214720864169d, y: 0.9665551878545043d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7786133406798015d, y: 0.4928786415866012d), new NpgsqlTypes.NpgsqlPoint(x: 0.5769917798161313d, y: 0.5184126710036842d), new NpgsqlTypes.NpgsqlPoint(x: 0.8466479761940873d, y: 0.8703911567659155d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 32,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8508885056852243d, y: 0.8832148427726076d), new NpgsqlTypes.NpgsqlPoint(x: 0.21462309087230447d, y: 0.7004485173230327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9440650998471415d, y: 0.8956043107396514d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.32854210593279365d, y: 0.9725984081736866d), new NpgsqlTypes.NpgsqlPoint(x: 0.8781870023690763d, y: 0.11281510733631561d), new NpgsqlTypes.NpgsqlPoint(x: 0.8878952470250989d, y: 0.24669054107282884d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.28997035296819174d, y: 0.40409557017174746d), new NpgsqlTypes.NpgsqlPoint(x: 0.6395378616965725d, y: 0.6150760968675041d), new NpgsqlTypes.NpgsqlPoint(x: 0.19132521481093134d, y: 0.757102083800197d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 34,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1216315409768971d, y: 0.348034359227279d), new NpgsqlTypes.NpgsqlPoint(x: 0.7124030646792262d, y: 0.2804409606653163d), new NpgsqlTypes.NpgsqlPoint(x: 0.9922915086053071d, y: 0.254642456029303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.46303201859501253d, y: 0.35714207773562034d), new NpgsqlTypes.NpgsqlPoint(x: 0.31126944483778973d, y: 0.10163945232148208d), new NpgsqlTypes.NpgsqlPoint(x: 0.8651861144940548d, y: 0.08399931536884653d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8890607809144113d, y: 0.9008213959006769d), new NpgsqlTypes.NpgsqlPoint(x: 0.30309097585063516d, y: 0.29699665449404433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9254189099950596d, y: 0.30335267006491107d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5380127106524988d, y: 0.7895346302378783d), new NpgsqlTypes.NpgsqlPoint(x: 0.5504904484646698d, y: 0.8650241018971881d), new NpgsqlTypes.NpgsqlPoint(x: 0.6053291526792611d, y: 0.28067288417154634d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 24,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5248032171246678d, y: 0.5024089905142468d), new NpgsqlTypes.NpgsqlPoint(x: 0.7476541387186638d, y: 0.018214757081107646d), new NpgsqlTypes.NpgsqlPoint(x: 0.9889064434667264d, y: 0.7040724763483498d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0762422599969651d, y: 0.662435770680078d), new NpgsqlTypes.NpgsqlPoint(x: 0.48013797451145623d, y: 0.13199373186950858d), new NpgsqlTypes.NpgsqlPoint(x: 0.8286383077215994d, y: 0.08284457365543474d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.27060119415020145d, y: 0.28597420970178766d), new NpgsqlTypes.NpgsqlPoint(x: 0.8947036079203085d, y: 0.7889280865409255d), new NpgsqlTypes.NpgsqlPoint(x: 0.1100695399010766d, y: 0.669485094150313d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09119855401152765d, y: 0.978320866823967d), new NpgsqlTypes.NpgsqlPoint(x: 0.6759491705844957d, y: 0.7921835106058285d), new NpgsqlTypes.NpgsqlPoint(x: 0.7052280725592677d, y: 0.6953220876140808d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 35,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7318030566414221d, y: 0.2092243170500968d), new NpgsqlTypes.NpgsqlPoint(x: 0.5511393793274102d, y: 0.36287603832392745d), new NpgsqlTypes.NpgsqlPoint(x: 0.9631954875298128d, y: 0.27966216298250246d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18067397325637435d, y: 0.7635932556265743d), new NpgsqlTypes.NpgsqlPoint(x: 0.9751516559859396d, y: 0.8972177021659966d), new NpgsqlTypes.NpgsqlPoint(x: 0.629651902877041d, y: 0.7428407011734711d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7901373540138216d, y: 0.4814994036274537d), new NpgsqlTypes.NpgsqlPoint(x: 0.17893537156634542d, y: 0.006040284462826784d), new NpgsqlTypes.NpgsqlPoint(x: 0.7374142565008173d, y: 0.2878219139199292d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.385598366028023d, y: 0.10608666390743227d), new NpgsqlTypes.NpgsqlPoint(x: 0.5130012046149236d, y: 0.1801498786215049d), new NpgsqlTypes.NpgsqlPoint(x: 0.004268402797552251d, y: 0.4549742794062127d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9103884632841908d, y: 0.4823414999774932d), new NpgsqlTypes.NpgsqlPoint(x: 0.13260668376710316d, y: 0.21358451759066044d), new NpgsqlTypes.NpgsqlPoint(x: 0.13367909959986368d, y: 0.015193711487232031d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5695484722174751d, y: 0.7672732912424896d), new NpgsqlTypes.NpgsqlPoint(x: 0.8639125638966368d, y: 0.698558874608745d), new NpgsqlTypes.NpgsqlPoint(x: 0.8913998342523598d, y: 0.06019306825981896d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8644341281316353d, y: 0.08656110099869885d), new NpgsqlTypes.NpgsqlPoint(x: 0.20625515443711495d, y: 0.5176581046307448d), new NpgsqlTypes.NpgsqlPoint(x: 0.30993839326305117d, y: 0.1384310291304225d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8047775344854882d, y: 0.007174535588090891d), new NpgsqlTypes.NpgsqlPoint(x: 0.9289391087154515d, y: 0.28227190817040815d), new NpgsqlTypes.NpgsqlPoint(x: 0.6569320166604155d, y: 0.8017642628314248d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9416784861921124d, y: 0.5340305898280502d), new NpgsqlTypes.NpgsqlPoint(x: 0.6510319932434625d, y: 0.06360944318817796d), new NpgsqlTypes.NpgsqlPoint(x: 0.4915512813101087d, y: 0.8982206815986097d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4628227085993001d, y: 0.2913071237402487d), new NpgsqlTypes.NpgsqlPoint(x: 0.1553143566816434d, y: 0.7685693792716132d), new NpgsqlTypes.NpgsqlPoint(x: 0.005245712739079811d, y: 0.10188388016215943d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8325380037645875d, y: 0.5498151082570435d), new NpgsqlTypes.NpgsqlPoint(x: 0.4888590626009356d, y: 0.2136574627876724d), new NpgsqlTypes.NpgsqlPoint(x: 0.3328272763613882d, y: 0.9427866511146181d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8170004054623077d, y: 0.3558704763297035d), new NpgsqlTypes.NpgsqlPoint(x: 0.846349132908353d, y: 0.6709464477172762d), new NpgsqlTypes.NpgsqlPoint(x: 0.1374718070981965d, y: 0.04342051790750956d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31164386494252616d, y: 0.3126069838188297d), new NpgsqlTypes.NpgsqlPoint(x: 0.1399251983863241d, y: 0.5009748093548277d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993046300715402d, y: 0.044689170018761604d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6277194560788454d, y: 0.14678054817432928d), new NpgsqlTypes.NpgsqlPoint(x: 0.8394437434351613d, y: 0.05542088341927376d), new NpgsqlTypes.NpgsqlPoint(x: 0.4757207396995563d, y: 0.0036184963893226563d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7266791822323395d, y: 0.29242318665908673d), new NpgsqlTypes.NpgsqlPoint(x: 0.5935548826086438d, y: 0.3105645499568169d), new NpgsqlTypes.NpgsqlPoint(x: 0.858062063254068d, y: 0.44512014586864856d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8503562868561096d, y: 0.18889413995199744d), new NpgsqlTypes.NpgsqlPoint(x: 0.311342901904359d, y: 0.16711858606265206d), new NpgsqlTypes.NpgsqlPoint(x: 0.678127181907246d, y: 0.0928552066111551d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.34532823149726766d, y: 0.8272086207418483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8255606876178172d, y: 0.8009043263817407d), new NpgsqlTypes.NpgsqlPoint(x: 0.024838923826186354d, y: 0.35048345556443994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41537598630148975d, y: 0.5367411275501894d), new NpgsqlTypes.NpgsqlPoint(x: 0.6776694765111306d, y: 0.9756587982012934d), new NpgsqlTypes.NpgsqlPoint(x: 0.8194675685270337d, y: 0.43649958632373087d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 29,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8408620570208378d, y: 0.8894783694411172d), new NpgsqlTypes.NpgsqlPoint(x: 0.05360051428808932d, y: 0.0060628854691255896d), new NpgsqlTypes.NpgsqlPoint(x: 0.0016795727311806896d, y: 0.9800594660485311d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4723970063709937d, y: 0.3540281894654518d), new NpgsqlTypes.NpgsqlPoint(x: 0.1893261523747496d, y: 0.051344739691092656d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647716706796109d, y: 0.11351708781559733d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6951168936562083d, y: 0.06058267624467639d), new NpgsqlTypes.NpgsqlPoint(x: 0.9097607275935807d, y: 0.22385243523056242d), new NpgsqlTypes.NpgsqlPoint(x: 0.9544097159506917d, y: 0.6774204541525081d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4620070386954005d, y: 0.7638863974100385d), new NpgsqlTypes.NpgsqlPoint(x: 0.19834934497481072d, y: 0.45317254562161513d), new NpgsqlTypes.NpgsqlPoint(x: 0.651609436338044d, y: 0.44441755578372566d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6161171315588877d, y: 0.6225039633258357d), new NpgsqlTypes.NpgsqlPoint(x: 0.24981880398859047d, y: 0.37646961405440904d), new NpgsqlTypes.NpgsqlPoint(x: 0.8471130440490378d, y: 0.14489123705668672d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9099206981131017d, y: 0.7340383380256149d), new NpgsqlTypes.NpgsqlPoint(x: 0.36965219612547573d, y: 0.0891547935399154d), new NpgsqlTypes.NpgsqlPoint(x: 0.6573690285921475d, y: 0.13611594722329978d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15102265486387656d, y: 0.3581132401003553d), new NpgsqlTypes.NpgsqlPoint(x: 0.5686199465407991d, y: 0.2355493599792161d), new NpgsqlTypes.NpgsqlPoint(x: 0.5488189778005814d, y: 0.4255535905689337d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.37295699589342857d, y: 0.7055779634228747d), new NpgsqlTypes.NpgsqlPoint(x: 0.8198287237572023d, y: 0.9489890663753252d), new NpgsqlTypes.NpgsqlPoint(x: 0.8674024145998913d, y: 0.5189623958163793d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.48078195619054676d, y: 0.28551669640754096d), new NpgsqlTypes.NpgsqlPoint(x: 0.909924369922937d, y: 0.44945572076247087d), new NpgsqlTypes.NpgsqlPoint(x: 0.7048413112757538d, y: 0.9867596184254185d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9542040868598778d, y: 0.5378150764088128d), new NpgsqlTypes.NpgsqlPoint(x: 0.18034343411824816d, y: 0.32312936082552923d), new NpgsqlTypes.NpgsqlPoint(x: 0.20460019869751944d, y: 0.4491325078194933d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.26179815107060045d, y: 0.7330883342335683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5449088159485576d, y: 0.36292271363768835d), new NpgsqlTypes.NpgsqlPoint(x: 0.5016782605122936d, y: 0.13400657432599583d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.526568351432092d, y: 0.4861595206008803d), new NpgsqlTypes.NpgsqlPoint(x: 0.5352085615164058d, y: 0.8801375860957134d), new NpgsqlTypes.NpgsqlPoint(x: 0.3332431097609052d, y: 0.9986770879874781d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7664697093203968d, y: 0.9475495736476166d), new NpgsqlTypes.NpgsqlPoint(x: 0.38958847177848854d, y: 0.4444309734274624d), new NpgsqlTypes.NpgsqlPoint(x: 0.5400506711263405d, y: 0.21228831745349863d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6422260281750228d, y: 0.24280173363970226d), new NpgsqlTypes.NpgsqlPoint(x: 0.45203703126204076d, y: 0.6649576426676114d), new NpgsqlTypes.NpgsqlPoint(x: 0.3947689767927831d, y: 9.467920029793131E-05d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040410130513611975d, y: 0.7984346162924099d), new NpgsqlTypes.NpgsqlPoint(x: 0.33789079966787117d, y: 0.1407578358056426d), new NpgsqlTypes.NpgsqlPoint(x: 0.28824897440049024d, y: 0.10092118740412614d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6967633066736021d, y: 0.4617615728851868d), new NpgsqlTypes.NpgsqlPoint(x: 0.99820162308465d, y: 0.7896560353737695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7968818544449268d, y: 0.7873091770529345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5369335362379511d, y: 0.06019241903962114d), new NpgsqlTypes.NpgsqlPoint(x: 0.14580644629130535d, y: 0.9762002882524988d), new NpgsqlTypes.NpgsqlPoint(x: 0.12366231024796359d, y: 0.7253197072226728d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.23056221070456773d, y: 0.608628305871881d), new NpgsqlTypes.NpgsqlPoint(x: 0.2553710518833774d, y: 0.08811536632165695d), new NpgsqlTypes.NpgsqlPoint(x: 0.6075206454858758d, y: 0.2113720182531168d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.832439061697931d, y: 0.24042031486471593d), new NpgsqlTypes.NpgsqlPoint(x: 0.1466932664074747d, y: 0.3962284223220516d), new NpgsqlTypes.NpgsqlPoint(x: 0.5563801271996349d, y: 0.19768128157036802d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4913710353186741d, y: 0.380365378427974d), new NpgsqlTypes.NpgsqlPoint(x: 0.8089602473086244d, y: 0.12391782746241364d), new NpgsqlTypes.NpgsqlPoint(x: 0.24026134023287737d, y: 0.4561947811213476d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.25329007929150005d, y: 0.38603578278097905d), new NpgsqlTypes.NpgsqlPoint(x: 0.1177250185105303d, y: 0.2890751471276256d), new NpgsqlTypes.NpgsqlPoint(x: 0.7335532273637079d, y: 0.9043134089251867d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 37,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14056147042321665d, y: 0.5055597715910846d), new NpgsqlTypes.NpgsqlPoint(x: 0.2573433082749311d, y: 0.01197512161550518d), new NpgsqlTypes.NpgsqlPoint(x: 0.2977575475249019d, y: 0.42340657892527855d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6315397526378996d, y: 0.9867702098136115d), new NpgsqlTypes.NpgsqlPoint(x: 0.8354522443860734d, y: 0.4252179018641732d), new NpgsqlTypes.NpgsqlPoint(x: 0.30370365703743585d, y: 0.3638868543336331d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6049301969980445d, y: 0.7569951118010695d), new NpgsqlTypes.NpgsqlPoint(x: 0.5007801868711861d, y: 0.7270709191965791d), new NpgsqlTypes.NpgsqlPoint(x: 0.7799231996048559d, y: 0.002685108721244056d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2112564316475154d, y: 0.273997193347145d), new NpgsqlTypes.NpgsqlPoint(x: 0.3079145827930452d, y: 0.9746234632473681d), new NpgsqlTypes.NpgsqlPoint(x: 0.1483069846721976d, y: 0.9077738057492157d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 57,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6383810478764091d, y: 0.5890468073064852d), new NpgsqlTypes.NpgsqlPoint(x: 0.19483760329304967d, y: 0.8005789307405632d), new NpgsqlTypes.NpgsqlPoint(x: 0.24124096834738484d, y: 0.3513081382577491d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18482906506678942d, y: 0.19031008262962068d), new NpgsqlTypes.NpgsqlPoint(x: 0.6914697758840803d, y: 0.16128826523137052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7036516359207949d, y: 0.5352031569596369d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.59897360067896d, y: 0.4273685138403528d), new NpgsqlTypes.NpgsqlPoint(x: 0.590812074023286d, y: 0.46049491673373966d), new NpgsqlTypes.NpgsqlPoint(x: 0.6081876338828706d, y: 0.5353454091134022d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42463404701369667d, y: 0.8286766343582765d), new NpgsqlTypes.NpgsqlPoint(x: 0.983478112731574d, y: 0.8721034278397052d), new NpgsqlTypes.NpgsqlPoint(x: 0.4390374433177623d, y: 0.9495139903643985d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5296559211945133d, y: 0.0008990714310751491d), new NpgsqlTypes.NpgsqlPoint(x: 0.3680786477228548d, y: 0.8963137211569753d), new NpgsqlTypes.NpgsqlPoint(x: 0.45053293235912817d, y: 0.8911721238304445d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1362384121556779d, y: 0.13327807585894946d), new NpgsqlTypes.NpgsqlPoint(x: 0.11189023794915087d, y: 0.4992678000323634d), new NpgsqlTypes.NpgsqlPoint(x: 0.14757036641544408d, y: 0.05214097019892194d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.745906031008403d, y: 0.5291933410365527d), new NpgsqlTypes.NpgsqlPoint(x: 0.40385027744020696d, y: 0.41823401570963636d), new NpgsqlTypes.NpgsqlPoint(x: 0.5100153114370101d, y: 0.848697603060497d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2565217814387347d, y: 0.7143011223899128d), new NpgsqlTypes.NpgsqlPoint(x: 0.3940794402049529d, y: 0.9736544011678914d), new NpgsqlTypes.NpgsqlPoint(x: 0.8884060359272722d, y: 0.27449573468928057d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 38,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.055785835959252794d, y: 0.06384333361386552d), new NpgsqlTypes.NpgsqlPoint(x: 0.9223677441483911d, y: 0.8731557862599241d), new NpgsqlTypes.NpgsqlPoint(x: 0.7489314081463153d, y: 0.8488883330990054d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11632322468639866d, y: 0.9859162500284953d), new NpgsqlTypes.NpgsqlPoint(x: 0.29108421230056347d, y: 0.9258505658028187d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675028717242577d, y: 0.33143192151259415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.624313900174415d, y: 0.07114566971010161d), new NpgsqlTypes.NpgsqlPoint(x: 0.9673948672315735d, y: 0.041734714735391254d), new NpgsqlTypes.NpgsqlPoint(x: 0.602771222683506d, y: 0.9302842715737589d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.47250433403576175d, y: 0.3851363603492779d), new NpgsqlTypes.NpgsqlPoint(x: 0.5364015651289656d, y: 0.08690248127496947d), new NpgsqlTypes.NpgsqlPoint(x: 0.0930713529541356d, y: 0.6079930563699025d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.004938725347577222d, y: 0.08453322349636327d), new NpgsqlTypes.NpgsqlPoint(x: 0.9806332791292569d, y: 0.7915146345051689d), new NpgsqlTypes.NpgsqlPoint(x: 0.7232478087891168d, y: 0.9995743629087067d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7369566409291792d, y: 0.5020186026980875d), new NpgsqlTypes.NpgsqlPoint(x: 0.13549576117703954d, y: 0.9330724195046671d), new NpgsqlTypes.NpgsqlPoint(x: 0.09438673784959017d, y: 0.9201841972844963d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.42866637513321826d, y: 0.921760869345886d), new NpgsqlTypes.NpgsqlPoint(x: 0.9750296638314213d, y: 0.5979711159463582d), new NpgsqlTypes.NpgsqlPoint(x: 0.23511300454835282d, y: 0.7114891961010005d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14786000810166333d, y: 0.4788657787143207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7937584179832119d, y: 0.683975482135866d), new NpgsqlTypes.NpgsqlPoint(x: 0.4733394066731561d, y: 0.5629230190323404d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7150436539334571d, y: 0.017493183176103155d), new NpgsqlTypes.NpgsqlPoint(x: 0.5589064662884752d, y: 0.5422528727893038d), new NpgsqlTypes.NpgsqlPoint(x: 0.503756312682568d, y: 0.6000947687138615d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.588524683071337d, y: 0.17474590946571555d), new NpgsqlTypes.NpgsqlPoint(x: 0.18973243380168503d, y: 0.8797686672304521d), new NpgsqlTypes.NpgsqlPoint(x: 0.1977188299755389d, y: 0.1473468015308208d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5679408840249437d, y: 0.3501245691682744d), new NpgsqlTypes.NpgsqlPoint(x: 0.6672272661299258d, y: 0.03485964810474118d), new NpgsqlTypes.NpgsqlPoint(x: 0.6699971695992116d, y: 0.017681951839890186d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8493836943224143d, y: 0.33706338212798215d), new NpgsqlTypes.NpgsqlPoint(x: 0.07436081708281872d, y: 0.3271197034555492d), new NpgsqlTypes.NpgsqlPoint(x: 0.19935261867988952d, y: 0.7031731164246388d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04799878844619443d, y: 0.6550092033398437d), new NpgsqlTypes.NpgsqlPoint(x: 0.35325853814546027d, y: 0.626527912700658d), new NpgsqlTypes.NpgsqlPoint(x: 0.1864666046368706d, y: 0.0983150629072651d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7105605155245583d, y: 0.617752876581216d), new NpgsqlTypes.NpgsqlPoint(x: 0.8444285702593579d, y: 0.6482002449346249d), new NpgsqlTypes.NpgsqlPoint(x: 0.2767481598026621d, y: 0.9827557662022391d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4567331148171273d, y: 0.02997305232637315d), new NpgsqlTypes.NpgsqlPoint(x: 0.023699738553464633d, y: 0.6642570361742512d), new NpgsqlTypes.NpgsqlPoint(x: 0.34179889435559674d, y: 0.44729309831509434d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18240112256486585d, y: 0.5783790841288923d), new NpgsqlTypes.NpgsqlPoint(x: 0.21228593218266056d, y: 0.18264340514664845d), new NpgsqlTypes.NpgsqlPoint(x: 0.23389071595483713d, y: 0.5055373141766122d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9066013870219256d, y: 0.5218100463067488d), new NpgsqlTypes.NpgsqlPoint(x: 0.008027050381613887d, y: 0.8367337429096294d), new NpgsqlTypes.NpgsqlPoint(x: 0.08718628677311979d, y: 0.9004892071990214d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8465193433564989d, y: 0.13647147085985967d), new NpgsqlTypes.NpgsqlPoint(x: 0.5999941927588258d, y: 0.9751699462943835d), new NpgsqlTypes.NpgsqlPoint(x: 0.6811997312112167d, y: 0.11881152434991171d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9590212732539588d, y: 0.9231703172181497d), new NpgsqlTypes.NpgsqlPoint(x: 0.552950624027208d, y: 0.9182490894184451d), new NpgsqlTypes.NpgsqlPoint(x: 0.32256841192021846d, y: 0.7371013281107415d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20531840008858637d, y: 0.47447120107611673d), new NpgsqlTypes.NpgsqlPoint(x: 0.2703587567713589d, y: 0.9438499461046888d), new NpgsqlTypes.NpgsqlPoint(x: 0.07685211582493179d, y: 0.9094099012135319d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 40,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6941966917799907d, y: 0.29729016262384855d), new NpgsqlTypes.NpgsqlPoint(x: 0.7644013791377074d, y: 0.8922252147866508d), new NpgsqlTypes.NpgsqlPoint(x: 0.6600783516106234d, y: 0.9637835709279191d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4525391770524433d, y: 0.9934556448085647d), new NpgsqlTypes.NpgsqlPoint(x: 0.3159241207044d, y: 0.1922149427589519d), new NpgsqlTypes.NpgsqlPoint(x: 0.8719923978303663d, y: 0.8499942232360632d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5952276644936723d, y: 0.09765695166376764d), new NpgsqlTypes.NpgsqlPoint(x: 0.09811547534159759d, y: 0.08917670077813611d), new NpgsqlTypes.NpgsqlPoint(x: 0.7838720907408667d, y: 0.14574156162947471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.43351999084882886d, y: 0.06499037755537929d), new NpgsqlTypes.NpgsqlPoint(x: 0.2916231751578181d, y: 0.43457802299192216d), new NpgsqlTypes.NpgsqlPoint(x: 0.45884356035191765d, y: 0.9457844137667804d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 72,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.804310822541547d, y: 0.8862244453539394d), new NpgsqlTypes.NpgsqlPoint(x: 0.0009546589119684423d, y: 0.9342378858890211d), new NpgsqlTypes.NpgsqlPoint(x: 0.3704778873785183d, y: 0.9954135403319593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04735830990868006d, y: 0.13059612419989497d), new NpgsqlTypes.NpgsqlPoint(x: 0.6844598091845043d, y: 0.8403822538604948d), new NpgsqlTypes.NpgsqlPoint(x: 0.2153822968343322d, y: 0.21876755292802386d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39087604548653043d, y: 0.811536573572536d), new NpgsqlTypes.NpgsqlPoint(x: 0.5254352735529985d, y: 0.6128857055224546d), new NpgsqlTypes.NpgsqlPoint(x: 0.15727977464058418d, y: 0.09845833960668282d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 75,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22572042894833388d, y: 0.9837900723437868d), new NpgsqlTypes.NpgsqlPoint(x: 0.3568904695126355d, y: 0.19681670349488678d), new NpgsqlTypes.NpgsqlPoint(x: 0.3138987717768138d, y: 0.10421168319411722d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4382933331050898d, y: 0.4396641839289054d), new NpgsqlTypes.NpgsqlPoint(x: 0.8585139593612822d, y: 0.7580769902536266d), new NpgsqlTypes.NpgsqlPoint(x: 0.5278804599498903d, y: 0.9658982657772345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21687501667377163d, y: 0.45501507771742244d), new NpgsqlTypes.NpgsqlPoint(x: 0.6765140316642063d, y: 0.011078510298246469d), new NpgsqlTypes.NpgsqlPoint(x: 0.10365022505670507d, y: 0.1399739747257288d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0070725587265553225d, y: 0.35240473927720006d), new NpgsqlTypes.NpgsqlPoint(x: 0.8810703054813219d, y: 0.10004208366158196d), new NpgsqlTypes.NpgsqlPoint(x: 0.3747174322531258d, y: 0.23599004619950514d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5698149565413935d, y: 0.23621703774442404d), new NpgsqlTypes.NpgsqlPoint(x: 0.19328617633940715d, y: 0.5439138027625388d), new NpgsqlTypes.NpgsqlPoint(x: 0.8794509091822337d, y: 0.350527591299879d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.16338134260230708d, y: 0.28979235213129884d), new NpgsqlTypes.NpgsqlPoint(x: 0.9006767347492811d, y: 0.28306647764514836d), new NpgsqlTypes.NpgsqlPoint(x: 0.8083514542086886d, y: 0.5926354046463403d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.44319679845028614d, y: 0.5092300414972432d), new NpgsqlTypes.NpgsqlPoint(x: 0.7344961427182259d, y: 0.3631243116757157d), new NpgsqlTypes.NpgsqlPoint(x: 0.7954767911821502d, y: 0.5478699601232663d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11842706227156052d, y: 0.8428676389666631d), new NpgsqlTypes.NpgsqlPoint(x: 0.2369259836011124d, y: 0.9708267691925475d), new NpgsqlTypes.NpgsqlPoint(x: 0.5919944184999679d, y: 0.09663719667493642d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39203920656220215d, y: 0.7208351106813847d), new NpgsqlTypes.NpgsqlPoint(x: 0.2979346596200233d, y: 0.6047996925588283d), new NpgsqlTypes.NpgsqlPoint(x: 0.06787413752516402d, y: 0.8185878973038047d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9465081559863743d, y: 0.9115079839553112d), new NpgsqlTypes.NpgsqlPoint(x: 0.3705805817887712d, y: 0.5964734469362949d), new NpgsqlTypes.NpgsqlPoint(x: 0.22073140402555846d, y: 0.8207924929136384d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8481896834123411d, y: 0.056582298768918626d), new NpgsqlTypes.NpgsqlPoint(x: 0.8127195519429389d, y: 0.3538980442859483d), new NpgsqlTypes.NpgsqlPoint(x: 0.8850785476054686d, y: 0.25314614065472585d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5972026307090754d, y: 0.6680781385329218d), new NpgsqlTypes.NpgsqlPoint(x: 0.00637996477166336d, y: 0.3292239414098248d), new NpgsqlTypes.NpgsqlPoint(x: 0.9339034196049787d, y: 0.3199058033816665d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6162187832650676d, y: 0.21115754873325232d), new NpgsqlTypes.NpgsqlPoint(x: 0.9347925414034557d, y: 0.5506696052010746d), new NpgsqlTypes.NpgsqlPoint(x: 0.42946057138360116d, y: 0.621354694807224d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.512867603683927d, y: 0.9489821151797548d), new NpgsqlTypes.NpgsqlPoint(x: 0.40172600626282284d, y: 0.7349543690340515d), new NpgsqlTypes.NpgsqlPoint(x: 0.18350621551188373d, y: 0.7466441782035609d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6843342750543681d, y: 0.9940338307510603d), new NpgsqlTypes.NpgsqlPoint(x: 0.356406513357477d, y: 0.7271710229130468d), new NpgsqlTypes.NpgsqlPoint(x: 0.4721643301277265d, y: 0.6559752755847433d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.00621395778009004d, y: 0.3921442796299043d), new NpgsqlTypes.NpgsqlPoint(x: 0.295098923488625d, y: 0.04016550190020207d), new NpgsqlTypes.NpgsqlPoint(x: 0.23351117409589128d, y: 0.6942956453346383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7092583589415408d, y: 0.37215391543307685d), new NpgsqlTypes.NpgsqlPoint(x: 0.4666478099317952d, y: 0.7857092954182361d), new NpgsqlTypes.NpgsqlPoint(x: 0.917146235703791d, y: 0.6686887085675917d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 45,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12165294214290712d, y: 0.26365368994276206d), new NpgsqlTypes.NpgsqlPoint(x: 0.45089072905780725d, y: 0.9921026046088005d), new NpgsqlTypes.NpgsqlPoint(x: 0.8095297900609979d, y: 0.26419175969196396d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7942294964535963d, y: 0.9507284710794771d), new NpgsqlTypes.NpgsqlPoint(x: 0.8837910076048803d, y: 0.07146784295809905d), new NpgsqlTypes.NpgsqlPoint(x: 0.5928478636956606d, y: 0.4755517462493115d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8211400871702041d, y: 0.8014137107071083d), new NpgsqlTypes.NpgsqlPoint(x: 0.21777546415801874d, y: 0.9461975759348286d), new NpgsqlTypes.NpgsqlPoint(x: 0.6026039879497803d, y: 0.7460083180306561d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 91,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.048873844563512736d, y: 0.8641454316618637d), new NpgsqlTypes.NpgsqlPoint(x: 0.5323132335110549d, y: 0.13415044246733365d), new NpgsqlTypes.NpgsqlPoint(x: 0.7872518889995002d, y: 0.9096106588549522d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3235558904100153d, y: 0.8363373958445081d), new NpgsqlTypes.NpgsqlPoint(x: 0.7522207961579273d, y: 0.17870308752811281d), new NpgsqlTypes.NpgsqlPoint(x: 0.649496118652039d, y: 0.1459519797050628d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.008146632847335966d, y: 0.7402223516572521d), new NpgsqlTypes.NpgsqlPoint(x: 0.30570168680595744d, y: 0.5583882559811346d), new NpgsqlTypes.NpgsqlPoint(x: 0.7707649302159152d, y: 0.5433335576663193d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.11425735875961884d, y: 0.6128020511151475d), new NpgsqlTypes.NpgsqlPoint(x: 0.28799965579694975d, y: 0.676183493295165d), new NpgsqlTypes.NpgsqlPoint(x: 0.213366723526756d, y: 0.7477333401552798d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5644591290189531d, y: 0.3285168406190424d), new NpgsqlTypes.NpgsqlPoint(x: 0.15523794549326442d, y: 0.9482633119124697d), new NpgsqlTypes.NpgsqlPoint(x: 0.9799995751741323d, y: 0.4640814658611796d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6711415665822685d, y: 0.8121868896556987d), new NpgsqlTypes.NpgsqlPoint(x: 0.5298633189102098d, y: 0.03926932071908951d), new NpgsqlTypes.NpgsqlPoint(x: 0.09812965797032591d, y: 0.5030898556328716d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6282507161218767d, y: 0.21507233691993433d), new NpgsqlTypes.NpgsqlPoint(x: 0.4429285078878499d, y: 0.12075270699660767d), new NpgsqlTypes.NpgsqlPoint(x: 0.44065987890327385d, y: 0.2376154166042279d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 94,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.17610387547515804d, y: 0.8503172726324676d), new NpgsqlTypes.NpgsqlPoint(x: 0.9502909128129785d, y: 0.6511603406715158d), new NpgsqlTypes.NpgsqlPoint(x: 0.2739758097308552d, y: 0.0996443290770539d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8444384753744202d, y: 0.5904744863117889d), new NpgsqlTypes.NpgsqlPoint(x: 0.34928112536650346d, y: 0.6274256000928677d), new NpgsqlTypes.NpgsqlPoint(x: 0.4769824031180806d, y: 0.21378477394451345d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2896541483946711d, y: 0.05100139371725709d), new NpgsqlTypes.NpgsqlPoint(x: 0.8636451339120265d, y: 0.2715385754961688d), new NpgsqlTypes.NpgsqlPoint(x: 0.4457491098489683d, y: 0.17231264368349708d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1365387258449532d, y: 0.937642187069221d), new NpgsqlTypes.NpgsqlPoint(x: 0.39369351216304205d, y: 0.32767914826469113d), new NpgsqlTypes.NpgsqlPoint(x: 0.8669931716288003d, y: 0.23765204121093553d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8136866473456373d, y: 0.4222698020023816d), new NpgsqlTypes.NpgsqlPoint(x: 0.7386919816774977d, y: 0.44769562934646945d), new NpgsqlTypes.NpgsqlPoint(x: 0.8728122713610525d, y: 0.2274133089846173d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7722839372755538d, y: 0.6825838648387728d), new NpgsqlTypes.NpgsqlPoint(x: 0.32608255000212216d, y: 0.6010731352090873d), new NpgsqlTypes.NpgsqlPoint(x: 0.6655152692752225d, y: 0.3798215838683293d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2300650756156858d, y: 0.6654056161596923d), new NpgsqlTypes.NpgsqlPoint(x: 0.35889006169943116d, y: 0.9020641030696913d), new NpgsqlTypes.NpgsqlPoint(x: 0.6497774698863754d, y: 0.19362794705942743d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31028914284281583d, y: 0.8736333883429145d), new NpgsqlTypes.NpgsqlPoint(x: 0.09311352755932345d, y: 0.32506473345655174d), new NpgsqlTypes.NpgsqlPoint(x: 0.5654744516661449d, y: 0.8857869699967775d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5618588510587712d, y: 0.7264426632378005d), new NpgsqlTypes.NpgsqlPoint(x: 0.05619783658731192d, y: 0.9878603699270753d), new NpgsqlTypes.NpgsqlPoint(x: 0.18698624645901407d, y: 0.3154062465584426d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.04812067745804827d, y: 0.9569427574460154d), new NpgsqlTypes.NpgsqlPoint(x: 0.2075514502527923d, y: 0.6151998916221345d), new NpgsqlTypes.NpgsqlPoint(x: 0.8614381064449725d, y: 0.6349995179028619d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8688670804277758d, y: 0.9834453356789872d), new NpgsqlTypes.NpgsqlPoint(x: 0.4853812587351498d, y: 0.43612568312361855d), new NpgsqlTypes.NpgsqlPoint(x: 0.847980188107855d, y: 0.38583846668297994d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5707065416916313d, y: 0.20782898760788948d), new NpgsqlTypes.NpgsqlPoint(x: 0.9823548367775999d, y: 0.4220578147158808d), new NpgsqlTypes.NpgsqlPoint(x: 0.027997379778152198d, y: 0.4537332288698571d)),

},
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06291684985209278d, y: 0.2880185748635038d), new NpgsqlTypes.NpgsqlPoint(x: 0.9728183271093073d, y: 0.7250883324823346d), new NpgsqlTypes.NpgsqlPoint(x: 0.3712046291683d, y: 0.1564890681082729d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5789414417610228d, y: 0.29794953871804886d), new NpgsqlTypes.NpgsqlPoint(x: 0.4532204279170131d, y: 0.08517252856831159d), new NpgsqlTypes.NpgsqlPoint(x: 0.6989349211624357d, y: 0.8978267589156746d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5811723736350216d, y: 0.8018065948773433d), new NpgsqlTypes.NpgsqlPoint(x: 0.9908455285623424d, y: 0.9045187877656906d), new NpgsqlTypes.NpgsqlPoint(x: 0.5330544889814298d, y: 0.9931080911017323d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 99,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9149444357418457d, y: 0.556271183739091d), new NpgsqlTypes.NpgsqlPoint(x: 0.5285611555600767d, y: 0.2611796235288757d), new NpgsqlTypes.NpgsqlPoint(x: 0.3731920878294528d, y: 0.383842568944029d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.24746786353879502d, y: 0.8220355460956126d), new NpgsqlTypes.NpgsqlPoint(x: 0.28439359578733936d, y: 0.8741234414230369d), new NpgsqlTypes.NpgsqlPoint(x: 0.15083180975390997d, y: 0.30008581757995767d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.928856305738507d, y: 0.725483375977901d), new NpgsqlTypes.NpgsqlPoint(x: 0.10745369751606404d, y: 0.5036196578046154d), new NpgsqlTypes.NpgsqlPoint(x: 0.9319569782491679d, y: 0.1762689698572073d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03631188445199929d, y: 0.5764556633319683d), new NpgsqlTypes.NpgsqlPoint(x: 0.5960396179680061d, y: 0.5149039604460197d), new NpgsqlTypes.NpgsqlPoint(x: 0.9639638274690249d, y: 0.2733441123787058d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.05899871495850528d, y: 0.642359663762507d), new NpgsqlTypes.NpgsqlPoint(x: 0.9136046842917482d, y: 0.21515014855126724d), new NpgsqlTypes.NpgsqlPoint(x: 0.9917349464327461d, y: 0.2253391305707101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6837460169402435d, y: 0.3694812396290953d), new NpgsqlTypes.NpgsqlPoint(x: 0.8123647187415255d, y: 0.9824892730341643d), new NpgsqlTypes.NpgsqlPoint(x: 0.09576433390877381d, y: 0.4067635719535143d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.15967035767170423d, y: 0.23978433415610934d), new NpgsqlTypes.NpgsqlPoint(x: 0.14001940875560825d, y: 0.4475177634465124d), new NpgsqlTypes.NpgsqlPoint(x: 0.057454677664138254d, y: 0.19616849344422493d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 58,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8670750249245199d, y: 0.7317150405632367d), new NpgsqlTypes.NpgsqlPoint(x: 0.6411074012207997d, y: 0.296577650445071d), new NpgsqlTypes.NpgsqlPoint(x: 0.891195230768211d, y: 0.394905230239571d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7571129502639659d, y: 0.37470636516439426d), new NpgsqlTypes.NpgsqlPoint(x: 0.22341052856002386d, y: 0.5607354782247193d), new NpgsqlTypes.NpgsqlPoint(x: 0.9377977816763113d, y: 0.40909439387808133d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6160666058140144d, y: 0.8700520796964839d), new NpgsqlTypes.NpgsqlPoint(x: 0.4203492262361299d, y: 0.07973668532027123d), new NpgsqlTypes.NpgsqlPoint(x: 0.23720889647820986d, y: 0.8281763890774796d)),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 103,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3214370336987744d, y: 0.4944234080814408d), new NpgsqlTypes.NpgsqlPoint(x: 0.4632118371439965d, y: 0.43421486599534964d), new NpgsqlTypes.NpgsqlPoint(x: 0.6917480901571483d, y: 0.8581037192494946d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5053347774028616d, y: 0.7886649834121945d), new NpgsqlTypes.NpgsqlPoint(x: 0.0006406496402320272d, y: 0.2086575174978832d), new NpgsqlTypes.NpgsqlPoint(x: 0.6602006566352115d, y: 0.18885215873603023d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.895432080527833d, y: 0.6470803841364104d), new NpgsqlTypes.NpgsqlPoint(x: 0.4927260908861464d, y: 0.8677095710408124d), new NpgsqlTypes.NpgsqlPoint(x: 0.6601260377162219d, y: 0.5354471806602723d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.08921484868930507d, y: 0.6931206466020637d), new NpgsqlTypes.NpgsqlPoint(x: 0.04058327319471744d, y: 0.8725453533251573d), new NpgsqlTypes.NpgsqlPoint(x: 0.6772726889459041d, y: 0.14410357659706052d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.006387254500131001d, y: 0.9172897427757244d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175534927282481d, y: 0.7965012624783099d), new NpgsqlTypes.NpgsqlPoint(x: 0.9065963148170766d, y: 0.27979819693024155d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4554347232515399d, y: 0.8144446771179477d), new NpgsqlTypes.NpgsqlPoint(x: 0.04935718049579063d, y: 0.004259043813205188d), new NpgsqlTypes.NpgsqlPoint(x: 0.5853873124693205d, y: 0.9359802836036599d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9305054765535581d, y: 0.18428777647404693d), new NpgsqlTypes.NpgsqlPoint(x: 0.03799419024841455d, y: 0.1457823358363024d), new NpgsqlTypes.NpgsqlPoint(x: 0.37116215869498115d, y: 0.2553273907242949d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 105,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4162866524813822d, y: 0.09807717578460695d), new NpgsqlTypes.NpgsqlPoint(x: 0.09545294034402041d, y: 0.8133796269108262d), new NpgsqlTypes.NpgsqlPoint(x: 0.14012861332273208d, y: 0.5234831108134422d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.20719162727196594d, y: 0.04770445301005877d), new NpgsqlTypes.NpgsqlPoint(x: 0.6708107090690142d, y: 0.16346557007701346d), new NpgsqlTypes.NpgsqlPoint(x: 0.2552040453425236d, y: 0.8685425469323375d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4020086032326814d, y: 0.9120927420173747d), new NpgsqlTypes.NpgsqlPoint(x: 0.3868538502890444d, y: 0.5809910409578127d), new NpgsqlTypes.NpgsqlPoint(x: 0.33771995504139374d, y: 0.898669494093043d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 62,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8124499955874196d, y: 0.9593246185711132d), new NpgsqlTypes.NpgsqlPoint(x: 0.9709793291628745d, y: 0.9270599691016819d), new NpgsqlTypes.NpgsqlPoint(x: 0.4999538093169298d, y: 0.4813065140838788d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.22687623407896595d, y: 0.7875096581991732d), new NpgsqlTypes.NpgsqlPoint(x: 0.9174214734811837d, y: 0.8619330500015818d), new NpgsqlTypes.NpgsqlPoint(x: 0.6722871762398132d, y: 0.48119621793360523d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6862096253228079d, y: 0.024711034921272024d), new NpgsqlTypes.NpgsqlPoint(x: 0.8407993482158141d, y: 0.6668597044838082d), new NpgsqlTypes.NpgsqlPoint(x: 0.6020331435421178d, y: 0.7592474519658975d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9070370304350263d, y: 0.20676889042232138d), new NpgsqlTypes.NpgsqlPoint(x: 0.06009640832258745d, y: 0.9495732268349052d), new NpgsqlTypes.NpgsqlPoint(x: 0.7535819134578886d, y: 0.5021647256267997d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.1338925743754843d, y: 0.033039375541196736d), new NpgsqlTypes.NpgsqlPoint(x: 0.9295049367840346d, y: 0.4612641909230306d), new NpgsqlTypes.NpgsqlPoint(x: 0.6875794449437536d, y: 0.7128831722238593d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.31293942997082547d, y: 0.7971943875643948d), new NpgsqlTypes.NpgsqlPoint(x: 0.5421475873042736d, y: 0.11113340810973293d), new NpgsqlTypes.NpgsqlPoint(x: 0.2882523987319672d, y: 0.3196454391624629d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6620986804753095d, y: 0.7905841015407514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8922074170766755d, y: 0.8562022699906446d), new NpgsqlTypes.NpgsqlPoint(x: 0.03747922860940145d, y: 0.4528824371204986d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 110,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7284796075374834d, y: 0.9447726996435281d), new NpgsqlTypes.NpgsqlPoint(x: 0.6968512923121188d, y: 0.6352107310611911d), new NpgsqlTypes.NpgsqlPoint(x: 0.20019487596255836d, y: 0.3279184379716342d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8588843251254777d, y: 0.693111968389877d), new NpgsqlTypes.NpgsqlPoint(x: 0.5574218945860584d, y: 0.5796119077962492d), new NpgsqlTypes.NpgsqlPoint(x: 0.29845259570354266d, y: 0.9221419157802101d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4027139187942387d, y: 0.908611823581847d), new NpgsqlTypes.NpgsqlPoint(x: 0.4049912578238918d, y: 0.046381290303141864d), new NpgsqlTypes.NpgsqlPoint(x: 0.3988038156717457d, y: 0.8916783596774001d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6156798846362951d, y: 0.008216474936884932d), new NpgsqlTypes.NpgsqlPoint(x: 0.727328819762575d, y: 0.8312501699374171d), new NpgsqlTypes.NpgsqlPoint(x: 0.514850761157627d, y: 0.7198372126105648d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.45525942555287124d, y: 0.29206874219294965d), new NpgsqlTypes.NpgsqlPoint(x: 0.21860089536774197d, y: 0.940310768839786d), new NpgsqlTypes.NpgsqlPoint(x: 0.70314345741063d, y: 0.6463970939477723d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.18864110956511093d, y: 0.9749852967767566d), new NpgsqlTypes.NpgsqlPoint(x: 0.23728697855629854d, y: 0.7825532307509673d), new NpgsqlTypes.NpgsqlPoint(x: 0.6535884270152315d, y: 0.31290690199274473d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 115,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4188314300315995d, y: 0.3814706549557664d), new NpgsqlTypes.NpgsqlPoint(x: 0.02508361997877584d, y: 0.47270063416318786d), new NpgsqlTypes.NpgsqlPoint(x: 0.10326970211808228d, y: 0.4496088762395992d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.36031401948123176d, y: 0.6776393537924207d), new NpgsqlTypes.NpgsqlPoint(x: 0.7789562902576812d, y: 0.5411370306672233d), new NpgsqlTypes.NpgsqlPoint(x: 0.5388701772030356d, y: 0.5150372758628383d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35512079342881586d, y: 0.03526018670203657d), new NpgsqlTypes.NpgsqlPoint(x: 0.4423468389960399d, y: 0.6377398383587959d), new NpgsqlTypes.NpgsqlPoint(x: 0.6882544405478215d, y: 0.007878040754112803d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6684960968201411d, y: 0.9612303714307853d), new NpgsqlTypes.NpgsqlPoint(x: 0.8698709417904222d, y: 0.2557613632507336d), new NpgsqlTypes.NpgsqlPoint(x: 0.25746719486508163d, y: 0.5244985466681443d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 64,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7775762229200268d, y: 0.2201025388636786d), new NpgsqlTypes.NpgsqlPoint(x: 0.8766790480584756d, y: 0.7820551182027208d), new NpgsqlTypes.NpgsqlPoint(x: 0.9659073473036418d, y: 0.25461094851552535d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6616905560129929d, y: 0.7034498254792271d), new NpgsqlTypes.NpgsqlPoint(x: 0.5305446125862991d, y: 0.5533030207712936d), new NpgsqlTypes.NpgsqlPoint(x: 0.5727048838010398d, y: 0.3672490413290891d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3799137597003318d, y: 0.42593515636770996d), new NpgsqlTypes.NpgsqlPoint(x: 0.25572862393367146d, y: 0.004651497691853246d), new NpgsqlTypes.NpgsqlPoint(x: 0.18514380002481112d, y: 0.5422914327579783d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7033204853376147d, y: 0.8338149206184946d), new NpgsqlTypes.NpgsqlPoint(x: 0.09253503510380001d, y: 0.6040316220483478d), new NpgsqlTypes.NpgsqlPoint(x: 0.5457031088066017d, y: 0.9515992760057378d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.040927246345835555d, y: 0.9928068337760462d), new NpgsqlTypes.NpgsqlPoint(x: 0.8432780552266482d, y: 0.30294811717625436d), new NpgsqlTypes.NpgsqlPoint(x: 0.8647198549013247d, y: 0.7280168623421475d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9074075033448462d, y: 0.6360511958568033d), new NpgsqlTypes.NpgsqlPoint(x: 0.533471065739072d, y: 0.5633212530613124d), new NpgsqlTypes.NpgsqlPoint(x: 0.8756507267614421d, y: 0.6787025029203636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3599405264959119d, y: 0.5711086701789555d), new NpgsqlTypes.NpgsqlPoint(x: 0.23933054813904142d, y: 0.7256383328532576d), new NpgsqlTypes.NpgsqlPoint(x: 0.0013913109389909195d, y: 0.38690799683296373d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 116,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21323469636507875d, y: 0.7132218347787612d), new NpgsqlTypes.NpgsqlPoint(x: 0.6231555034237225d, y: 0.01651041795422259d), new NpgsqlTypes.NpgsqlPoint(x: 0.27415348870580203d, y: 0.08828935864023557d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7903763475603784d, y: 0.6700116736687611d), new NpgsqlTypes.NpgsqlPoint(x: 0.18398482692737206d, y: 0.9355104136816792d), new NpgsqlTypes.NpgsqlPoint(x: 0.15323503869794264d, y: 0.5752804020293443d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9049478144670361d, y: 0.1832653690054541d), new NpgsqlTypes.NpgsqlPoint(x: 0.6952036850439358d, y: 0.14827732947603844d), new NpgsqlTypes.NpgsqlPoint(x: 0.1867005702852529d, y: 0.6848866527397721d)),

},
    ModelInner = null,
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 117,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6693382414346277d, y: 0.5843594250205186d), new NpgsqlTypes.NpgsqlPoint(x: 0.9320464062310745d, y: 0.6088989518680362d), new NpgsqlTypes.NpgsqlPoint(x: 0.5954103860915312d, y: 0.5199551543652471d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.12171878652044321d, y: 0.9979842268907961d), new NpgsqlTypes.NpgsqlPoint(x: 0.08709684353827951d, y: 0.593898633140507d), new NpgsqlTypes.NpgsqlPoint(x: 0.09695711942566854d, y: 0.673334827479041d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09737309193085109d, y: 0.2834010382838721d), new NpgsqlTypes.NpgsqlPoint(x: 0.3952123736709007d, y: 0.6675345735925069d), new NpgsqlTypes.NpgsqlPoint(x: 0.4932100779317212d, y: 0.1818939837414948d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 68,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.35715370108333033d, y: 0.1564769272552199d), new NpgsqlTypes.NpgsqlPoint(x: 0.7882682104887556d, y: 0.7685025666269231d), new NpgsqlTypes.NpgsqlPoint(x: 0.060651735561776055d, y: 0.07519700889310532d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41825831515180867d, y: 0.9095912258215838d), new NpgsqlTypes.NpgsqlPoint(x: 0.22765605869470695d, y: 0.14714388058565864d), new NpgsqlTypes.NpgsqlPoint(x: 0.675033251891796d, y: 0.8299676074446907d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6688922017726912d, y: 0.6041332540504327d), new NpgsqlTypes.NpgsqlPoint(x: 0.06118259485177058d, y: 0.2839884113979638d), new NpgsqlTypes.NpgsqlPoint(x: 0.6825531217465154d, y: 0.4538307981745432d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7235504475022598d, y: 0.7313130476456446d), new NpgsqlTypes.NpgsqlPoint(x: 0.15967651776299774d, y: 0.25092891809550155d), new NpgsqlTypes.NpgsqlPoint(x: 0.25140444188843925d, y: 0.4899348056238346d)),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.06497879256313044d, y: 0.16422909142637998d), new NpgsqlTypes.NpgsqlPoint(x: 0.46444348440593586d, y: 0.17467677648615476d), new NpgsqlTypes.NpgsqlPoint(x: 0.7858450427850492d, y: 0.969211890857717d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5566814764735922d, y: 0.07585667307100774d), new NpgsqlTypes.NpgsqlPoint(x: 0.9126972525379302d, y: 0.8514151474980577d), new NpgsqlTypes.NpgsqlPoint(x: 0.4522531868451336d, y: 0.5934454477056492d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.03194818531764887d, y: 0.37712271865448277d), new NpgsqlTypes.NpgsqlPoint(x: 0.309328642333214d, y: 0.7712546495071605d), new NpgsqlTypes.NpgsqlPoint(x: 0.21798026223011124d, y: 0.8912588818124332d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.09897834269104078d, y: 0.4006421835506092d), new NpgsqlTypes.NpgsqlPoint(x: 0.193721283211433d, y: 0.9098802871306539d), new NpgsqlTypes.NpgsqlPoint(x: 0.6675616568410955d, y: 0.11840664170577819d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 125,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.8303237276940617d, y: 0.10504362131017886d), new NpgsqlTypes.NpgsqlPoint(x: 0.3441823023869992d, y: 0.9320440150474046d), new NpgsqlTypes.NpgsqlPoint(x: 0.9492878933230947d, y: 0.6650871867824654d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4588905635439574d, y: 0.3580124288005747d), new NpgsqlTypes.NpgsqlPoint(x: 0.19529738548874653d, y: 0.28429595155618237d), new NpgsqlTypes.NpgsqlPoint(x: 0.5407282784414242d, y: 0.8018711937067545d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6903995767864523d, y: 0.7351318084771683d), new NpgsqlTypes.NpgsqlPoint(x: 0.29694122919569166d, y: 0.9275762741363065d), new NpgsqlTypes.NpgsqlPoint(x: 0.549302736314219d, y: 0.6892419851897779d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4554680443415352d, y: 0.13442979381321052d), new NpgsqlTypes.NpgsqlPoint(x: 0.8517170362254951d, y: 0.6335258407145691d), new NpgsqlTypes.NpgsqlPoint(x: 0.18484827405597581d, y: 0.5652626487313958d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7058139153869033d, y: 0.950184555097484d), new NpgsqlTypes.NpgsqlPoint(x: 0.20762078883004842d, y: 0.5762079664104639d), new NpgsqlTypes.NpgsqlPoint(x: 0.6873501228672347d, y: 0.05166093119209125d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.21898547005884217d, y: 0.6861563049822063d), new NpgsqlTypes.NpgsqlPoint(x: 0.2726807842077765d, y: 0.8155026508061949d), new NpgsqlTypes.NpgsqlPoint(x: 0.4416021447407379d, y: 0.5741832250958976d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4020601882423319d, y: 0.42535684134689067d), new NpgsqlTypes.NpgsqlPoint(x: 0.2507028974030714d, y: 0.24356276327641957d), new NpgsqlTypes.NpgsqlPoint(x: 0.22472787055196686d, y: 0.5100295484513071d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5406677136293321d, y: 0.10459958481110299d), new NpgsqlTypes.NpgsqlPoint(x: 0.8822976003412605d, y: 0.10938646247728212d), new NpgsqlTypes.NpgsqlPoint(x: 0.7351176095727124d, y: 0.15354886130644985d)),

},
},
            new NpgsqlPathpathListD1E2M
{
    Id = 126,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.14516532692950412d, y: 0.26991124028780533d), new NpgsqlTypes.NpgsqlPoint(x: 0.7725848371773989d, y: 0.20728848117834686d), new NpgsqlTypes.NpgsqlPoint(x: 0.0841153423302039d, y: 0.6507709288714755d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39226846722401076d, y: 0.8747742897585266d), new NpgsqlTypes.NpgsqlPoint(x: 0.9229053855293105d, y: 0.11587422862825514d), new NpgsqlTypes.NpgsqlPoint(x: 0.8501359423840033d, y: 0.11306144713069655d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.2723137144189478d, y: 0.14378286799412276d), new NpgsqlTypes.NpgsqlPoint(x: 0.009833752662177342d, y: 0.28449013790585964d), new NpgsqlTypes.NpgsqlPoint(x: 0.5993220746703742d, y: 0.26142567831971d)),

},
    ModelInner = new NpgsqlPathpathListD1E2MI
{
    Id = 71,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.4824037167193507d, y: 0.8686679191530368d), new NpgsqlTypes.NpgsqlPoint(x: 0.7175526397328937d, y: 0.70011276996693d), new NpgsqlTypes.NpgsqlPoint(x: 0.3944347999195743d, y: 0.37512151136147276d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.19654149000183474d, y: 0.5440088984229574d), new NpgsqlTypes.NpgsqlPoint(x: 0.8747701806521778d, y: 0.4479429668881695d), new NpgsqlTypes.NpgsqlPoint(x: 0.7826481713873075d, y: 0.13303316445267088d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9659282669761682d, y: 0.4845292358346114d), new NpgsqlTypes.NpgsqlPoint(x: 0.3385160367550345d, y: 0.33887148187358407d), new NpgsqlTypes.NpgsqlPoint(x: 0.7245019590282367d, y: 0.5270327567975389d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.6197654437881126d, y: 0.04027647706559767d), new NpgsqlTypes.NpgsqlPoint(x: 0.28869040303682403d, y: 0.8009579702220021d), new NpgsqlTypes.NpgsqlPoint(x: 0.7543181115897355d, y: 0.02635634916314533d)),

},
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.33966992368759874d, y: 0.9194224151120944d), new NpgsqlTypes.NpgsqlPoint(x: 0.703018216053373d, y: 0.2904120663307044d), new NpgsqlTypes.NpgsqlPoint(x: 0.07660210285277269d, y: 0.4849524952408303d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7491920693647562d, y: 0.8307299547884747d), new NpgsqlTypes.NpgsqlPoint(x: 0.7574277957490456d, y: 0.23952559270237828d), new NpgsqlTypes.NpgsqlPoint(x: 0.2211370891995621d, y: 0.580118718567561d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.39108297374020295d, y: 0.194179548418973d), new NpgsqlTypes.NpgsqlPoint(x: 0.4971709223723365d, y: 0.2219339506256206d), new NpgsqlTypes.NpgsqlPoint(x: 0.49346990553160786d, y: 0.8095715735924786d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.627747201153943d, y: 0.3212670092423434d), new NpgsqlTypes.NpgsqlPoint(x: 0.7560286496023632d, y: 0.1863369666412047d), new NpgsqlTypes.NpgsqlPoint(x: 0.6771566013611093d, y: 0.4155812751867596d)),

},
},
    NullableValue = null,
},
            new NpgsqlPathpathListD1E2M
{
    Id = 134,
    Value = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(4)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.41411227632400505d, y: 0.13159233358454336d), new NpgsqlTypes.NpgsqlPoint(x: 0.830021436739401d, y: 0.763734996484331d), new NpgsqlTypes.NpgsqlPoint(x: 0.26799829740881087d, y: 0.03496964613632636d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7433003975332992d, y: 0.11502722897121698d), new NpgsqlTypes.NpgsqlPoint(x: 0.5358347703356634d, y: 0.4868778714657188d), new NpgsqlTypes.NpgsqlPoint(x: 0.4150583063730142d, y: 0.3738223279024738d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.7302869569544719d, y: 0.9567909784634482d), new NpgsqlTypes.NpgsqlPoint(x: 0.8112836173862008d, y: 0.5252385469152098d), new NpgsqlTypes.NpgsqlPoint(x: 0.5433067781791746d, y: 0.30751746423588366d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.0854233603772454d, y: 0.34907472223849123d), new NpgsqlTypes.NpgsqlPoint(x: 0.2864164546167699d, y: 0.1647325816063534d), new NpgsqlTypes.NpgsqlPoint(x: 0.6104848568506309d, y: 0.9991973405560268d)),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>(3)
{
new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.3998956728291393d, y: 0.10251552627905547d), new NpgsqlTypes.NpgsqlPoint(x: 0.05607081570910866d, y: 0.9051436433037333d), new NpgsqlTypes.NpgsqlPoint(x: 0.314232542225902d, y: 0.7492209047160406d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.9473690907794687d, y: 0.9759654356015296d), new NpgsqlTypes.NpgsqlPoint(x: 0.3299796735362026d, y: 0.7304906392432423d), new NpgsqlTypes.NpgsqlPoint(x: 0.7051950885547003d, y: 0.8672545446077284d)),

new NpgsqlTypes.NpgsqlPath(new NpgsqlTypes.NpgsqlPoint(x: 0.5951524208670075d, y: 0.933799677762861d), new NpgsqlTypes.NpgsqlPoint(x: 0.9293106508651031d, y: 0.9614493432995365d), new NpgsqlTypes.NpgsqlPoint(x: 0.4682874411648471d, y: 0.6895070275347882d)),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2mi(
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
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634))]
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

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((INpgsqlPathListpathListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((INpgsqlPathListpathListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((INpgsqlPathListpathListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((INpgsqlPathListpathListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.npgsqlpathpathlistd1e2m(
	id,
    value,
    nullablevalue,
    npgsqlpathpathlistd1e2mi_id
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
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<NpgsqlTypes.NpgsqlPath>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483634)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "npgsqlpathpathlistd1e2mi_id", 
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
                List<NpgsqlPathpathListD1E2M> models = null;

                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((INpgsqlPathListpathListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<NpgsqlPathpathListD1E2M> models = null;

                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((INpgsqlPathListpathListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((INpgsqlPathListpathListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await ((INpgsqlPathListpathListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((INpgsqlPathListpathListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 7;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                Assert.That(secondItems2, Has.Count.EqualTo(34));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[1], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[2], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[31],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[32],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[33],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 64;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 89;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 89;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 11;
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                Assert.That(firstItems2, Has.Count.EqualTo(32));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[3], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[29],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[30],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 54;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 117;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(21));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[34], false);
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
                parametr1.Value = 57;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 105;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(7));
                Assert.That(secondItems2, Has.Count.EqualTo(7));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 72;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 110;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[34], false);
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
                parametr2.Value = 103;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(8));
                Assert.That(secondItems2, Has.Count.EqualTo(8));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[4], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[5], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[29],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[30],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 117;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 27;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[6], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[7], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[8], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[9], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[10], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[11], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[12], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[13], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[14], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[20],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[21],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[22],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[23],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[24],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[25],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[26],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[27],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[28],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M), typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 54, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 94, query1, 34, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(11));
                Assert.That(firstItems2, Has.Count.EqualTo(11));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var models2 = new List<FlatNpgsqlPathpathListD1E2M>();
                ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 27, query1, 72, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[28],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var firstItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 72, query1, 116, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                Assert.That(firstItems2, Has.Count.EqualTo(16));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems2[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatNpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 75, query1, 116, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                await ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 20, query1, 13, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatNpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 103, query1, 72, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[19], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[20], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[21], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[22], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
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
FROM public.npgsqlpathpathlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems1 = new List<FlatNpgsqlPathpathListD1E2M>();
                var secondItems2 = new List<FlatNpgsqlPathpathListD1E2M>();
                 ((INpgsqlPathListpathListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 99, query1, 91, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(12));
                Assert.That(secondItems2, Has.Count.EqualTo(12));
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[0],_testData[23], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[1],_testData[24], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[2],_testData[25], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[3],_testData[26], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[4],_testData[27], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[5],_testData[28], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[6],_testData[29], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[7],_testData[30], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[8],_testData[31], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[9],_testData[32], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[10],_testData[33], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems1[11],_testData[34], false);
                        FlatNpgsqlPathpathListD1E2M.AssertModel(secondItems2[11],_testData[34], false);
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
FROM public.npgsqlpathpathlistd1e2m m
LEFT JOIN public.npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
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
                var models = await((INpgsqlPathListpathListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 115, 116))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(5));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(4));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[34], false);
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
                var models = ((INpgsqlPathListpathListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    NpgsqlPathpathListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((INpgsqlPathListpathListD1)this).DbConnectionSTSelectModelBatch(connection, 99, 57))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(20));

                        NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[15], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[16], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[17], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[18], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[19], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[20], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[21], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[22], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[23], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[24], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[25], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[26], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[27], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[28], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[29], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[30], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[31], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[32], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[33], false);
                        NpgsqlPathpathListD1E2M.AssertModel(models[19],_testData[34], false);
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
                await using var cmd = await ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 94);
                var models = await ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((INpgsqlPathListpathListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((INpgsqlPathListpathListD1)this).SetDbConnectionSelectModelParametrs(cmd, 58);
                var models =  ((INpgsqlPathListpathListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(19));

                NpgsqlPathpathListD1E2M.AssertModel(models[0],_testData[16], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[1],_testData[17], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[2],_testData[18], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[3],_testData[19], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[4],_testData[20], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[5],_testData[21], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[6],_testData[22], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[7],_testData[23], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[8],_testData[24], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[9],_testData[25], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[10],_testData[26], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[11],_testData[27], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[12],_testData[28], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[13],_testData[29], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[14],_testData[30], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[15],_testData[31], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[16],_testData[32], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[17],_testData[33], false);
                NpgsqlPathpathListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((INpgsqlPathListpathListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_npgsqlpathpathlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(NpgsqlPathpathListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new NpgsqlPathpathListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((INpgsqlPathListpathListD1)this).ImportModelInner(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(NpgsqlPathpathListD1E2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
FROM public.binary_npgsqlpathpathlistd1e2m m
LEFT JOIN public.binary_npgsqlpathpathlistd1e2mi mi ON mi.id = m.npgsqlpathpathlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((INpgsqlPathListpathListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((INpgsqlPathListpathListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<NpgsqlPathpathListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((INpgsqlPathListpathListD1)this).ImportModel(connection, importCollection);
                var models = ((INpgsqlPathListpathListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    npgsqlpathpathlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models =  ((INpgsqlPathListpathListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    NpgsqlPathpathListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_npgsqlpathpathlistd1e2mi
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
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI), typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                await ((INpgsqlPathListpathListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MI>();
                var models2 = new List<NpgsqlPathpathListD1E2MI>();
                ((INpgsqlPathListpathListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634),
                (NpgsqlTypes.NpgsqlDbType)(-2147483634)
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
                var models = await ((INpgsqlPathListpathListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_npgsqlpathpathlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA), typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                await ((INpgsqlPathListpathListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<NpgsqlPathpathListD1E2MIWA>();
                var models2 = new List<NpgsqlPathpathListD1E2MIWA>();
                ((INpgsqlPathListpathListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_npgsqlpathpathlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(NpgsqlPathpathListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(INpgsqlPathListpathListD1))]
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
                var models = await ((INpgsqlPathListpathListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((INpgsqlPathListpathListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    NpgsqlPathpathListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

